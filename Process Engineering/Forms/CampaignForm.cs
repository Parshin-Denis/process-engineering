using Process_Engineering.DTO;
using Process_Engineering.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Process_Engineering.Forms
{
    public partial class CampaignForm : Form
    {
        private Campaign campaign = new Campaign();
        private bool isFilterActive = true;

        #region Основная форма

        public CampaignForm()
        {
            InitializeComponent();
            cbToolType.Items.Add("Все типы");
            cbToolType.Items.AddRange(ConstStorage.SCREWING_TOOL_TYPES);
            cbBLM.DataSource = ConstStorage.BLM_LIST;
            cbBLM.SelectedIndex = -1;
            cbSector.DataSource = ConstStorage.SECTORS;
            cbSector.SelectedIndex = -1;

            ConstStorage.BLM_LIST
                .ToList()
                .ForEach(b => cbBlmFilter.Items.Add(b));
            cbSectorFilter.Items.AddRange(ConstStorage.SECTORS);
            cbToolTypeFilter.Items.Add("Все типы");
            cbToolTypeFilter.Items.AddRange(ConstStorage.SCREWING_TOOL_TYPES);
            cbUserFilter.Items.AddRange(Campaign.campaigns.Select(c => c.checker).Where(c => c != null).Distinct().ToArray());
        }

        private void ToolForm_Load(object sender, EventArgs e)
        {
            FilterParameterChanged(sender, e);
            dgCampaigns.Columns[0].Visible = false;
            dgCampaigns.Columns[1].Visible = false;
            dgCampaigns.Columns[6].Visible = false;
            dgCampaigns.Columns[2].HeaderText = "Дата начала";
            dgCampaigns.Columns[3].HeaderText = "Дата завершения";
            dgCampaigns.Columns[4].HeaderText = "BLM";
            dgCampaigns.Columns[5].HeaderText = "Участок";
            dgCampaigns.Columns[7].HeaderText = "Тип инструмента";
            dgCampaigns.Columns[8].HeaderText = "Всего инстр.";
            dgCampaigns.Columns[9].HeaderText = "Рез-т OK";
            dgCampaigns.Columns[10].HeaderText = "Рез-т NOK";
            dgCampaigns.Columns[11].HeaderText = "Не провер.";
            dgCampaigns.Columns[12].HeaderText = "Провел";
            dgCampaigns.Columns[4].Width = 50;
            dgCampaigns.Columns[5].Width = 50;
            dgCampaigns.Columns[8].Width = 50;
            dgCampaigns.Columns[9].Width = 50;
            dgCampaigns.Columns[10].Width = 50;
            dgCampaigns.Columns[11].Width = 50;
            dgCampaigns.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgCampaigns.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgCampaigns.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgCampaigns.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgCampaigns.Columns[7].Width = dgCampaigns.Width - SystemInformation.VerticalScrollBarWidth -
                dgCampaigns.Columns[2].Width - dgCampaigns.Columns[3].Width - dgCampaigns.Columns[4].Width - dgCampaigns.Columns[5].Width -
                dgCampaigns.Columns[8].Width - dgCampaigns.Columns[9].Width - dgCampaigns.Columns[10].Width - dgCampaigns.Columns[11].Width -
                dgCampaigns.Columns[12].Width - 3;
            dgCampaigns.ReadOnly = true;
            gbCampaign.Enabled = User.isToolCheckingAllowed();
            bSensors.Visible = User.isScrewingEditingAllowed();
            bDelete.Visible = User.isAdmin();
        }

        private void dgTools_SelectionChanged(object sender, EventArgs e)
        {
            if (dgCampaigns.SelectedRows.Count == 0) { return; }
            campaign.copyFrom(dgCampaigns.SelectedRows[0].DataBoundItem as Campaign);
            bUnloadAgain.Enabled = User.isToolCheckingAllowed() && campaign.checker == null;            
            bToolCheck.Enabled = campaign.checker != null;
            bGetResult.Enabled = bToolCheck.Enabled;
        }

        #endregion

        #region Загрузка кампаний

        private async void bUnload_Click(object sender, EventArgs e)
        {
            if (!areParametersSelected()) { return; }
            string diskName = getDiskName();
            if (diskName.Equals(string.Empty))
            {
                return;
            }
            Campaign campaign = new Campaign();
            campaign.sector = cbSector.SelectedItem.ToString();
            campaign.blm = (int)cbBLM.SelectedItem;
            campaign.toolType = cbToolType.SelectedIndex + 2;
            GeneralResponse<Campaign> response = await DataBaseService.createCampaign(campaign);
            if (!response.isResultOK)
            {
                MessageBox.Show(response.message, ConstStorage.CAMPAIGN_LOAD, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            campaign = response.data;
            Sensor.sensors = await DataBaseService.getSensorList();
            writeOnDisk(diskName, campaign);
            campaign.setDetails();
            Campaign.campaigns.Insert(0, campaign);
            MessageBox.Show(string.Format(ConstStorage.CAMPAIGN_LOADED, diskName), ConstStorage.CAMPAIGN_LOAD,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            FilterParameterChanged(sender, e);
        }

        private bool areParametersSelected()
        {
            if (cbBLM.SelectedIndex == -1)
            {
                MessageBox.Show(ConstStorage.BLM_NOT_SELECTED, ConstStorage.CAMPAIGN_LOAD, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (cbSector.SelectedIndex == -1)
            {
                MessageBox.Show(ConstStorage.SECTOR_NOT_SELECTED, ConstStorage.CAMPAIGN_LOAD, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (cbToolType.SelectedIndex == -1)
            {
                MessageBox.Show(ConstStorage.TOOL_NOT_SELECTED, ConstStorage.CAMPAIGN_LOAD, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (MessageBox.Show(string.Format(ConstStorage.START_NEW_CAMPAIGN, cbBLM.SelectedItem.ToString()), ConstStorage.CAMPAIGN_LOAD,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return false;
            }
            return true;
        }

        private void writeOnDisk(string disk, Campaign campaign)
        {
            List<string> lines = new List<string>
            {
                $"\"header\";{campaign.number};{Array.IndexOf(ConstStorage.BLM_LIST, campaign.blm) + 1};\"3860.{campaign.blm}\"{new string(';', 21)}"
            };
            List<ScrewingTool> toolsToCheck = campaign.tools;
            foreach (ScrewingTool tool in toolsToCheck)
            {
                lines.Add(getToolInfo(tool, campaign.blm));
            }
            File.WriteAllLines($"{disk}\\{Array.IndexOf(ConstStorage.BLM_LIST, campaign.blm):000}.38", lines);
        }

        private string getToolInfo(ScrewingTool tool, int blm)
        {
            string[] toolInfo = new string[32];
            for (int i = 0; i < toolInfo.Length; i++)
            {
                toolInfo[i] = "0";
            }
            ScrewingToolType toolType = ScrewingToolType.types.Find(t => t.id == tool.toolTypeId);
            toolInfo[0] = "\"Tool\"";
            toolInfo[1] = $"\"{tool.id}\"";
            toolInfo[2] = toolType.techType == 6 ? "3" : toolType.techType.ToString();
            toolInfo[3] = $"\"{toolType.number}\"";
            toolInfo[4] = $"\"{tool.cardNumber}\"";
            toolInfo[5] = $"\"\"";
            toolInfo[6] = $"\"{tool.pitch}\"";
            toolInfo[7] = $"\"\"";
            toolInfo[8] = $"\"{toolType.model}\"";
            toolInfo[11] = "3";
            toolInfo[12] = tool.torque.ToString("F2");
            toolInfo[13] = toolType.tolerance.ToString();
            toolInfo[14] = (tool.torque * (100 - toolType.tolerance) / 100).ToString("F2");
            toolInfo[15] = (tool.torque * (100 + toolType.tolerance) / 100).ToString("F2");
            toolInfo[16] = (tool.torque * (100 - toolType.tolerance * 0.6727) / 100).ToString("F2");
            toolInfo[17] = (tool.torque * (100 + toolType.tolerance * 0.6727) / 100).ToString("F2");
            toolInfo[18] = (tool.torque * (100 - toolType.tolerance * 0.5093) / 100).ToString("F2");
            toolInfo[19] = (tool.torque * (100 + toolType.tolerance * 0.5093) / 100).ToString("F2");
            toolInfo[20] = (0.00922 * tool.torque * toolType.tolerance).ToString("F2");
            toolInfo[21] = (0.01268 * tool.torque * toolType.tolerance).ToString("F2");
            toolInfo[22] = (tool.brakeTime ?? 0).ToString("F3");
            toolInfo[23] = "90,0";
            toolInfo[24] = getSensorNumber(blm, tool.torque).ToString();
            toolInfo[25] = (tool.torque / 2).ToString("F2");
            return string.Join(";", toolInfo) + ";";
        }

        private int getSensorNumber(int blm, float torque)
        {            
            return Sensor.sensors.Find(s => s.blm == blm && s.minTorque <= torque && torque <= s.maxTorque)?.number ?? 0;
        }

        private string getDiskName()
        {
            List<DriveInfo> drives = DriveInfo.GetDrives().Where(d => d.DriveType == DriveType.Removable).ToList();
            if (drives.Count == 0)
            {
                MessageBox.Show(ConstStorage.DISK_NOT_FOUND, ConstStorage.CAMPAIGN_LOAD, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return string.Empty;
            }
            if (drives.Count > 1)
            {
                MessageBox.Show(ConstStorage.SEVERAL_DISKS, ConstStorage.CAMPAIGN_LOAD, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return string.Empty;
            }
            return drives[0].Name;
        }

        private async void bUploadResults_Click(object sender, EventArgs e)
        {
            string diskName = getDiskName();
            if (diskName.Equals(string.Empty))
            {
                return;
            }
            if (cbBLM.SelectedIndex == -1)
            {
                MessageBox.Show(ConstStorage.BLM_NOT_SELECTED, ConstStorage.CAMPAIGN_LOAD, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            int blm = (int)cbBLM.SelectedItem;
            int blmIndex = cbBLM.SelectedIndex;
            GeneralResponse<Campaign> response = await DataBaseService.getOpenCampaign(blm);
            if (!response.isResultOK)
            {
                MessageBox.Show(response.message, ConstStorage.CAMPAIGN_LOAD, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            int campaignNumberExpected = response.data.number + 1;
            int campaignNumberInFile = getCampaignNumber($"{diskName}{blmIndex:000}.38b");
            if (campaignNumberExpected != campaignNumberInFile)
            {
                MessageBox.Show(string.Format(ConstStorage.NO_CAMPAIGN_RESULT, blm),
                ConstStorage.CAMPAIGN_LOAD, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            uploadResults($"{diskName}{blmIndex:000}.38b", response.data);
            MessageBox.Show(string.Format(ConstStorage.CAMPAIGN_UPLOADED, blm),
                ConstStorage.CAMPAIGN_LOAD, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int getCampaignNumber(string file)
        {
            if (!File.Exists(file)) return 0;
            string header = File.ReadLines(file).First();
            string[] parameters = header.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            if (parameters.Length < 4) return 0;
            return int.TryParse(parameters[1], out int campaignNumber) ? campaignNumber : 0;
        }

        private async void uploadResults(string file, Campaign campaign)
        {
            string[] lines = File.ReadAllLines(file);
            List<ToolCheck> checks = new List<ToolCheck>();
            for (int i = 1; i < lines.Length; i++)
            {
                try
                {
                    string[] parameters = lines[i].Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                    ToolCheck toolCheck = new ToolCheck();
                    toolCheck.toolId = int.Parse(parameters[1].Trim(new char[] { '"' }));
                    toolCheck.brakeTime = float.Parse(parameters[4]);
                    toolCheck.brakeAngle = float.Parse(parameters[5]);
                    toolCheck.checkTime = DateTime.Parse(parameters[6].Trim(new char[] { '"' })).ToUniversalTime();
                    toolCheck.torque1 = float.Parse(parameters[10]);
                    toolCheck.torque2 = float.Parse(parameters[11]);
                    toolCheck.torque3 = float.Parse(parameters[12]);
                    toolCheck.torqueSpread = float.Parse(parameters[17]);
                    toolCheck.torqueAverage = float.Parse(parameters[18]);
                    toolCheck.angleAverage = float.Parse(parameters[19]);
                    toolCheck.codeResult = int.Parse(parameters[20]);
                    toolCheck.sensorNumber = int.Parse(parameters[23]);
                    checks.Add(toolCheck);
                }
                catch (Exception) { continue; }
            }
            campaign = (await DataBaseService.setToolCheckResults(campaign, checks)).data;
            campaign.setDetails();
            Campaign.campaigns.Find(c => c.id == campaign.id).copyFrom(campaign);
            dgCampaigns.Refresh();
            dgTools_SelectionChanged(this, EventArgs.Empty);
        }

        #endregion

        #region Доп.функции и Фильтр
        
        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void bGetResult_Click(object sender, EventArgs e)
        {
            if (campaign.checker == null) return;
            Campaign campaignDetailed = await DataBaseService.getCampaign(campaign.id ?? 0);
            campaignDetailed.setDetails();
            ExtractionService.getCampaignResult(campaignDetailed);
        }

        private async void bSensors_Click(object sender, EventArgs e)
        {
            Sensor.sensors = await DataBaseService.getSensorList();
            SensorForm sensorForm = new SensorForm();            
            sensorForm.ShowDialog();
        }

        private void FilterParameterChanged(object sender, EventArgs e)
        {
            if (!isFilterActive) return;

            dtPicker.Enabled = cbDate.Checked;
            List<Campaign> filteredCampaigns = Campaign.campaigns
                .Where(c => cbDate.Checked ? GeneralService.AreDatesEqual(c.startDate, dtPicker.Value) : true)
                .Where(c => cbBlmFilter.SelectedIndex != -1 ? c.blm == cbBlmFilter.SelectedItem as int? : true)
                .Where(c => cbSectorFilter.SelectedIndex != -1 ? c.sector.Equals(cbSectorFilter.SelectedItem as string) : true)
                .Where(c => cbToolTypeFilter.SelectedIndex != -1 ? c.techType.Equals(cbToolTypeFilter.SelectedItem as string) : true)
                .Where(c => cbUserFilter.SelectedIndex != -1 ? (cbUserFilter.SelectedItem as string).Equals(c.checker) : true)
                .ToList();
            dgCampaigns.DataSource = new BindingList<Campaign>(filteredCampaigns);
            lCount.Text = $"Найдено: {dgCampaigns.Rows.Count} шт.";
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            isFilterActive = false;
            cbToolTypeFilter.SelectedIndex = -1;
            cbBlmFilter.SelectedIndex = -1;
            cbSectorFilter.SelectedIndex = -1;
            cbUserFilter.SelectedIndex = -1;
            cbDate.Checked = false;
            isFilterActive = true;
            FilterParameterChanged(sender, e);
        }

        private async void bDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(ConstStorage.DELETE_CAMPAIGN, ConstStorage.DELETING_CAMPAIGN,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            GeneralResponse<object> response = await DataBaseService.deleteCampaign(campaign);
            if (!response.isResultOK)
            {
                MessageBox.Show(ConstStorage.DELETE_ERROR + Environment.NewLine + response.message,
                    ConstStorage.DELETING_CAMPAIGN, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Campaign.campaigns.Remove(Campaign.campaigns.First(c => c.id == campaign.id));
            FilterParameterChanged(sender, e);
            MessageBox.Show(response.message, ConstStorage.DELETING_CAMPAIGN, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void bToolCheck_Click(object sender, EventArgs e)
        {
            if (campaign.checker == null) return;
            CampaignScrewingToolCheckForm form = new CampaignScrewingToolCheckForm(campaign);
            ToolCheck.toolChecks = await DataBaseService.getToolCheckResults(campaign);
            form.ShowDialog();
        }

        private async void bUnloadAgain_Click(object sender, EventArgs e)
        {
            string diskName = getDiskName();
            if (diskName.Equals(string.Empty))
            {
                return;
            }
            Campaign campaignDetailed = await DataBaseService.getCampaign(campaign.id ?? 0);
            Sensor.sensors = await DataBaseService.getSensorList();
            writeOnDisk(diskName, campaignDetailed);
            MessageBox.Show(string.Format(ConstStorage.CAMPAIGN_LOADED, diskName), ConstStorage.CAMPAIGN_LOAD,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

    }
}
