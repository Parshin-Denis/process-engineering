using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Process_Engineering.Forms
{
    internal partial class CampaignScrewingToolCheckForm : Form
    {        

        public CampaignScrewingToolCheckForm(Campaign campaign)
        {
            InitializeComponent();            
            lCampaign.Text += campaign.ToString();
        }

        private void ToolForm_Load(object sender, EventArgs e)
        {
            dgTools.DataSource = new BindingList<ToolCheck>(ToolCheck.toolChecks);            
            dgTools.Columns[1].HeaderText = "Номер ключа";
            dgTools.Columns[2].HeaderText = "Дата проверки";
            dgTools.Columns[3].HeaderText = "Момент номинал";
            dgTools.Columns[4].HeaderText = "Момент 1-й";
            dgTools.Columns[5].HeaderText = "Момент 2-й";
            dgTools.Columns[6].HeaderText = "Момент 3-й";
            dgTools.Columns[7].HeaderText = "Разброс момента";
            dgTools.Columns[8].HeaderText = "Средний момент";
            dgTools.Columns[9].HeaderText = "Средний угол";
            dgTools.Columns[10].HeaderText = "Время торможения";
            dgTools.Columns[11].HeaderText = "Угол торможения";
            dgTools.Columns[12].Visible = false;
            dgTools.Columns[13].HeaderText = "Номер датчика";

            for (int i = 0; i < dgTools.Columns.Count; i++)
            {
                if (i == 2) continue;
                dgTools.Columns[i].Width = 65;
                dgTools.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            for (int i = 0; i < dgTools.Rows.Count; i++)
            {
                dgTools.Rows[i].Cells[0].Value = ToolCheck.toolChecks[i].codeResult == 128 ? "OK" : "NOK";
            }
            //dgTools.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgTools.Columns[2].Width = dgTools.Width - SystemInformation.VerticalScrollBarWidth -
            //    dgTools.Columns[0].Width - dgTools.Columns[1].Width - 3;
            dgTools.ReadOnly = true;
            dgTools.Columns[0].DisplayIndex = 13;
        }        

    }
}
