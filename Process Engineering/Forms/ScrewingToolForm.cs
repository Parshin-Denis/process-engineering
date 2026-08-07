using Process_Engineering.DTO;
using Process_Engineering.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Process_Engineering.Forms
{
    public partial class ScrewingToolForm : Form
    {
        private ScrewingTool modifiedTool = new ScrewingTool();
        private ScrewingTool selectedTool;
        private ScrewingTool replacementTool;
        private List<CardWithScrewing> cards = ScrewingTool.screwingTools
            .Select(t => t.card)
            .Where(c => c != null)
            .Concat(CardWithScrewing.cards)
            .Distinct()
            .OrderBy(n => n.number)
            .ToList();
        private List<string> models = ScrewingToolType.types.Select(t => t.ToString()).OrderBy(m => m).ToList();
        private List<string> cardNumbers = ScrewingTool.screwingTools
            .Where(t => t.cardNumber != string.Empty)
            .Select(t => t.cardNumber)
            .Distinct()
            .OrderBy(n => n)
            .ToList();
        private List<Pitch> pitchesFilter = Pitch.pitches.Where(p => ScrewingTool.screwingTools.Select(t => t.pitchId).Contains(p.id)).ToList();
        private List<ScrewingTool> toolsReplace;
        private bool isFilterActive = false;
        private bool userAction = false;

        #region Главная форма

        public ScrewingToolForm()
        {
            InitializeComponent();
            cards.Insert(0, new CardWithScrewing());
            cardNumbers.Insert(0, ConstStorage.CARD_IS_NOT_SET);

            tbNumber.DataBindings.Add("Text", modifiedTool, "id", false, DataSourceUpdateMode.Never);
            tbNumber.DataBindings[0].ControlUpdateMode = ControlUpdateMode.Never;
            tbSerialNumber.DataBindings.Add("Text", modifiedTool, "serialNumber", false, DataSourceUpdateMode.Never);
            tbTorque.DataBindings.Add("Text", modifiedTool, "torque", false, DataSourceUpdateMode.Never);
            tbTorque.DataBindings[0].ControlUpdateMode = ControlUpdateMode.Never;
            tbCardNumber.DataBindings.Add("Text", modifiedTool, "cardNumber", false, DataSourceUpdateMode.Never);
            tbCardName.DataBindings.Add("Text", modifiedTool, "cardName", false, DataSourceUpdateMode.Never);

            cbPitch.Items.AddRange(Pitch.pitches.ToArray());
            cbCards.Items.AddRange(cards.ToArray());
            cbToolType.Items.AddRange(ScrewingToolType.types.ToArray());
            cbStatus.DataSource = ScrewingTool.statuses;

            cbModelFilter.Items.AddRange(models.ToArray());
            cbCardFilter.Items.AddRange(cardNumbers.ToArray());
            cbPitchFilter.Items.AddRange(pitchesFilter.ToArray());

            cbStatusFilter.DataSource = new List<StringConst>(ScrewingTool.statuses);
            cbToolTypeFilter.DataSource = ConstStorage.SCREWING_TOOL_TYPES;
        }

        private void ToolForm_Load(object sender, EventArgs e)
        {
            bResetFilter_Click(this, EventArgs.Empty);

            dgTools.Columns[0].HeaderText = "№";
            dgTools.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgTools.Columns[1].HeaderText = "Тип";
            dgTools.Columns[2].HeaderText = "Модель";
            dgTools.Columns[3].HeaderText = "Серийный №";
            dgTools.Columns[4].HeaderText = "Статус";
            dgTools.Columns[5].HeaderText = "Гамма";
            dgTools.Columns[6].HeaderText = "Пост";
            dgTools.Columns[7].HeaderText = "Момент";
            dgTools.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgTools.Columns[8].HeaderText = "Время торм.";
            dgTools.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgTools.Columns[9].Visible = false;
            dgTools.Columns[10].Visible = false;
            dgTools.Columns[11].Visible = false;
            dgTools.Columns[12].Visible = false;
            dgTools.Columns[13].Visible = false;
            dgTools.Columns[14].Visible = false;
            for (int i = 0; i < dgTools.Columns.Count; i++)
            {
                dgTools.Columns[i].Width = 80;
            }
            dgTools.Columns[0].Width = 50;
            dgTools.Columns[2].Width = 190;
            dgTools.Columns[4].Width = 150;
            dgTools.Columns[1].Width = dgTools.Width - SystemInformation.VerticalScrollBarWidth -
                dgTools.Columns[0].Width - dgTools.Columns[2].Width - dgTools.Columns[3].Width - dgTools.Columns[4].Width -
                dgTools.Columns[5].Width - dgTools.Columns[6].Width - dgTools.Columns[7].Width - dgTools.Columns[8].Width - 3;
            dgTools.ReadOnly = true;            
        }

        private void dgTools_SelectionChanged(object sender, EventArgs e)
        {
            if (!userAction) return;
            userAction = false;

            selectedTool = dgTools.SelectedRows.Count == 0
                ? new ScrewingTool()
                : dgTools.SelectedRows[0].DataBoundItem as ScrewingTool;

            modifiedTool.CopyFrom(selectedTool);

            tbNumber.DataBindings[0].ReadValue();
            tbTorque.DataBindings[0].ReadValue();
            tbSerialNumber.DataBindings[0].ReadValue();
            tbCardNumber.DataBindings[0].ReadValue();
            tbCardName.DataBindings[0].ReadValue();

            cbCards.SelectedItem = cards.Find(c => c.id == modifiedTool.cardId);            
            cbToolType.SelectedItem = ScrewingToolType.types.Find(s => s.id == modifiedTool.toolTypeId);
            cbPitch.SelectedItem = Pitch.pitches.Find(p => p.id == modifiedTool.pitchId);
            cbStatus.SelectedItem = ScrewingTool.statuses.Find(s => s.id == modifiedTool.statusId);
            CheckData();
            AdjustEditFields();

            bCheckHistory.Enabled = dgTools.SelectedRows.Count != 0;
            bMovements.Enabled = dgTools.SelectedRows.Count != 0;
            bPrint.Enabled = dgTools.SelectedRows.Count != 0;
            gbEdit.Enabled = false;
            bUpdate.Enabled = dgTools.SelectedRows.Count != 0 && User.isScrewingEditingAllowed();
            bUpdate.Text = ConstStorage.EDIT;
            bAdd.Enabled = User.isScrewingEditingAllowed();

            userAction = true;
        }

        private void dgTools_SizeChanged(object sender, EventArgs e)
        {
            //for (int i = 0; i < dgTools.Columns.Count; i++)
            //{
            //    dgTools.Columns[i].Width = 80 + (dgTools.Width - 984) / 8;
            //}
            //dgTools.Columns[0].Width = 50;
            //dgTools.Columns[2].Width = 190 + (dgTools.Width - 984) / 8;
            //dgTools.Columns[4].Width = 150 + (dgTools.Width - 984) / 8;
            //dgTools.Columns[1].Width = dgTools.Width - SystemInformation.VerticalScrollBarWidth -
            //    dgTools.Columns[0].Width - dgTools.Columns[2].Width - dgTools.Columns[3].Width - dgTools.Columns[4].Width -
            //    dgTools.Columns[5].Width - dgTools.Columns[6].Width - dgTools.Columns[7].Width - dgTools.Columns[8].Width - 3;
        }

        private void UpdateRowStyle(DataGridViewRow row)
        {
            ScrewingTool tool = row.DataBoundItem as ScrewingTool;
            row.Cells[5].Style.BackColor = tool.IsCardCorrect() ? SystemColors.Window : Color.Red;
            row.Cells[6].Style.BackColor = tool.IsPitchCorrect() ? SystemColors.Window : Color.Red;
            row.Cells[7].Style.BackColor = tool.IsTorqueCorrect() ? SystemColors.Window : Color.Red;            
        }

        private void UpdateRowStyle(ScrewingTool tool)
        {            
            foreach (DataGridViewRow row in dgTools.Rows)
            {
                ScrewingTool toolToCompare = row.DataBoundItem as ScrewingTool;
                if (tool.Equals(toolToCompare))
                {
                    UpdateRowStyle(row);
                    break;
                }                
            }            
        }

        #endregion

        #region Фильтр

        private void UpdateDataGrid(object sender, EventArgs e)
        {
            if (!isFilterActive) { return; }
            List<ScrewingTool> filteredTools = ScrewingTool.screwingTools
                .Where(t => !tbNumberFilter.Text.Equals(string.Empty) ? int.Parse(tbNumberFilter.Text.ToString()) == t.id : true)
                .Where(t => cbToolTypeFilter.SelectedIndex != -1 ? t.type.Equals(cbToolTypeFilter.SelectedItem.ToString()) : true)
                .Where(t => cbModelFilter.SelectedIndex != -1 ? t.model.Equals(cbModelFilter.Text) : true)
                .Where(t => t.serialNumber.Contains(tbSerialNumberFilter.Text))
                .Where(t => cbPitchFilter.SelectedItem != null ? (cbPitchFilter.SelectedItem as Pitch).id == t.pitchId : t.pitch.Contains(cbPitchFilter.Text.ToUpper()))
                .Where(t => cbCardFilter.SelectedIndex == 0 ? t.cardNumber == string.Empty : t.cardNumber.Contains(cbCardFilter.Text))
                .Where(t => cbStatusFilter.SelectedItem != null ? (cbStatusFilter.SelectedItem as StringConst).id == t.statusId : true)
                .Where(t => !tbTorqueFilter.Text.Equals(string.Empty) ? float.Parse(tbTorqueFilter.Text) == t.torque : true)
                .Where(t => cbAnomaly.Checked ? t.HasAnomaly() : true)
                .ToList();
            userAction = false;
            dgTools.DataSource = new BindingList<ScrewingTool>(filteredTools);
            dgTools.ClearSelection();
            userAction = true;
            if (selectedTool == null || selectedTool.id != 0)
            {
                dgTools_SelectionChanged(sender, EventArgs.Empty);
            }
            
            foreach (DataGridViewRow row in dgTools.Rows)
            {
                UpdateRowStyle(row);
            }
            lCount.Text = $"Найдено: {dgTools.Rows.Count} шт.";
        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(ConstStorage.PRINT_LABELS, dgTools.SelectedRows.Count),
                ConstStorage.LABELS_PRINTING, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            if (DialogResult.OK != printDialog.ShowDialog())
            {
                return;
            }
            List<ScrewingTool> tools = new List<ScrewingTool>();
            foreach (DataGridViewRow row in dgTools.SelectedRows)
            {
                tools.Add(row.DataBoundItem as ScrewingTool);
            }
            ExtractionService.printToolLabel(tools, printDialog.PrinterSettings, progressBar);
            MessageBox.Show(ConstStorage.LABELS_PRINTED, ConstStorage.LABELS_PRINTING, MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar.Value = 0;
        }

        private void bResetFilter_Click(object sender, EventArgs e)
        {
            isFilterActive = false;
            tbNumberFilter.Text = string.Empty;
            cbToolTypeFilter.SelectedIndex = -1;
            cbModelFilter.Text = string.Empty;
            cbModelFilter.SelectedIndex = -1;
            cbPitchFilter.Text = string.Empty;
            cbPitchFilter.SelectedIndex = -1;
            cbCardFilter.Text = string.Empty;
            cbCardFilter.SelectedIndex = -1;
            cbStatusFilter.SelectedIndex = -1;
            tbSerialNumberFilter.Text = string.Empty;
            tbTorqueFilter.Text = string.Empty;
            cbAnomaly.Checked = false;
            isFilterActive = true;
            UpdateDataGrid(sender, e);
        }

        private void tbNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            GeneralService.FilterDigitKeyPress(textBox, e, textBox.Name.Contains("Number"));
        }

        private void cbCardFilter_TextChanged(object sender, EventArgs e)
        {
            GeneralService.FilterComboBoxItems(sender as ComboBox, cardNumbers);
        }

        private void cbPitchFilter_TextChanged(object sender, EventArgs e)
        {
            GeneralService.FilterComboBoxItems(sender as ComboBox, pitchesFilter);
        }

        private void cbModelFilter_TextChanged(object sender, EventArgs e)
        {
            GeneralService.FilterComboBoxItems(sender as ComboBox, models);
        }

        #endregion

        #region Редактирование        

        private void bSetTorque_Click(object sender, EventArgs e)
        {
            if (cbCards.SelectedIndex == -1)
            {
                return;
            }
            modifiedTool.torque = (float)(cbCards.SelectedItem as CardWithScrewing)?.screwing.torque;
            tbTorque.DataBindings[0].ReadValue();
        }

        private async void bShowCard_Click(object sender, EventArgs e)
        {
            if (cbCards.SelectedIndex == -1)
            {
                return;
            }
            Card card = await DataBaseService.getCard((cbCards.SelectedItem as CardWithScrewing).id);
            ExtractionService.show(card);
        }

        private void ToolParamaterChanged(object sender, EventArgs e)
        {
            if (!userAction) return;
            if (sender.Equals(cbCards))
            {
                CardWithScrewing selectedCard = cbCards.SelectedItem as CardWithScrewing;
                modifiedTool.card = selectedCard;
                bShowCard.Enabled = selectedCard?.id != null;
                tbCardNumber.DataBindings[0].ReadValue();
                tbCardName.DataBindings[0].ReadValue();
                tbCardNumber.Enabled = selectedCard?.id == null;
                tbCardName.Enabled = selectedCard?.id == null;
                bSetTorque.Enabled = selectedCard?.id != null;
            }
            else if (sender.Equals(cbToolType))
            {
                modifiedTool.toolTypeId = (cbToolType.SelectedItem as ScrewingToolType)?.id;
            }
            else if (sender.Equals(cbPitch))
            {
                modifiedTool.pitchId = (cbPitch.SelectedItem as Pitch)?.id;
            }
            else if (sender.Equals(cbStatus))
            {
                modifiedTool.statusId = (cbStatus.SelectedItem as StringConst)?.id;
                AdjustEditFields();
            }
            else if (sender is TextBox)
            {
                (sender as TextBox).DataBindings[0].WriteValue();
            }
            CheckData();

            bAdd.Enabled = dgTools.SelectedRows.Count == 0;
            bUpdate.Enabled = dgTools.SelectedRows.Count > 0 && !modifiedTool.Equals(selectedTool);
        }

        private void AdjustEditFields()
        {
            if (cbStatus.SelectedIndex != 1)
            {
                cbPitch.SelectedIndex = 0;
                cbCards.SelectedIndex = 0;
                modifiedTool.torque = 0;
                tbTorque.DataBindings[0].ReadValue();
                modifiedTool.cardName = null;
                modifiedTool.cardNumber = null;
            }

            lToolReplace.Visible = cbStatus.SelectedIndex != 1 && selectedTool.statusId == 1;
            cbToolReplace.Visible = lToolReplace.Visible;
            if (cbToolReplace.Visible)
            {
                toolsReplace = ScrewingTool.screwingTools.Where(t => t.statusId != 1 && t.statusId != 6
                    && t.GetToolType().minTorque <= selectedTool.torque && t.GetToolType().maxTorque >= selectedTool.torque)
                    .ToList();
                cbToolReplace.Items.AddRange(toolsReplace.ToArray());
                cbToolReplace.Text = string.Empty;
            }
            else
            {
                cbToolReplace.Items.Clear();
            }

            cbPitch.Enabled = cbStatus.SelectedIndex == 1;
            cbCards.Enabled = cbStatus.SelectedIndex == 1;
            tbTorque.Enabled = cbStatus.SelectedIndex == 1;
            bSetTorque.Enabled = modifiedTool.cardId != null;
            tbCardName.Enabled = cbStatus.SelectedIndex == 1 && cbCards.SelectedIndex == 0;
            tbCardNumber.Enabled = cbStatus.SelectedIndex == 1 && cbCards.SelectedIndex == 0;
        }

        private void CheckData()
        {
            if (!modifiedTool.IsTorqueAchivable())
            {
                lTorqueError.Text = ConstStorage.TOOL_IS_NOT_CORRECT;
            }
            else if (!modifiedTool.IsCardActual())
            {
                lTorqueError.Text = ConstStorage.CARD_IS_NOT_ACTUAL;
            }
            else if (!modifiedTool.IsCardWithScrewing())
            {
                lTorqueError.Text = ConstStorage.CARD_IS_WITHOUT_SCREWING;
            }
            else if (!modifiedTool.EqualCardTorque())
            {
                lTorqueError.Text = string.Format(ConstStorage.TORQUE_IS_NOT_CONFORM, modifiedTool.card.screwing.torque);
            }
            else if (!modifiedTool.IsPitchCorrect())
            {
                lTorqueError.Text = string.Format(ConstStorage.PITCH_IS_NOT_CONFORM, Pitch.GetPitch(modifiedTool.card?.pitchId).number);
            }
            else
            {
                lTorqueError.Text = string.Empty;
            }
        }

        private void cbToolType_TextChanged(object sender, EventArgs e)
        {
            GeneralService.FilterComboBoxItems(sender as ComboBox, ScrewingToolType.types);
        }

        private void cbCards_TextChanged(object sender, EventArgs e)
        {
            GeneralService.FilterComboBoxItems(sender as ComboBox, cards);
        }

        private void cbPitch_TextChanged(object sender, EventArgs e)
        {
            GeneralService.FilterComboBoxItems(sender as ComboBox, Pitch.pitches.ToArray());
        }

        private void cbToolReplace_TextChanged(object sender, EventArgs e)
        {
            GeneralService.FilterComboBoxItems(sender as ComboBox, toolsReplace);
        }

        #endregion

        #region Кнопки внизу

        private async void bAdd_Click(object sender, EventArgs e)
        {
            if (!gbEdit.Enabled)
            {
                dgTools.ClearSelection();
                gbEdit.Enabled = true;
                bAdd.Enabled = false;
                tbNumber.ReadOnly = false;
                return;
            }
            if (MessageBox.Show(string.Format(ConstStorage.ADD_TOOL, modifiedTool.id), ConstStorage.TOOL_EDITING,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            GeneralResponse<ScrewingTool> response = await DataBaseService.createScrewingTool(modifiedTool);
            if (!response.isResultOK)
            {
                MessageBox.Show(ConstStorage.ADD_ERROR + Environment.NewLine + response.message,
                    ConstStorage.TOOL_EDITING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ScrewingTool newTool = response.data;
            ScrewingTool.screwingTools.Add(newTool);
            MessageBox.Show(response.message, ConstStorage.TOOL_EDITING, MessageBoxButtons.OK, MessageBoxIcon.Information);
            bResetFilter_Click(sender, e);
            UpdateFilterFields();
            dgTools.Rows[dgTools.Rows.Count - 1].Selected = true;
            UpdateRowStyle(dgTools.Rows[dgTools.Rows.Count - 1]);
            dgTools.FirstDisplayedScrollingRowIndex = dgTools.Rows.Count - 1;
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            if (!gbEdit.Enabled)
            {
                gbEdit.Enabled = true;
                bUpdate.Enabled = false;
                bUpdate.Text = ConstStorage.ACCEPT_CHANGES;
                bAdd.Enabled = false;
                tbNumber.ReadOnly = true;
                return;
            }
            replacementTool = cbToolReplace.SelectedItem as ScrewingTool;
            string updateQuestion = replacementTool == null ? string.Format(ConstStorage.UPDATE_TOOL, selectedTool.id)
                                                            : string.Format(ConstStorage.UPDATE_TOOLS, selectedTool.id, replacementTool.id);
            if (MessageBox.Show(updateQuestion, ConstStorage.TOOL_EDITING, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            if (replacementTool != null)
            {
                selectedTool.ReplaceWith(replacementTool);
                UpdateTool(replacementTool);
            }
            UpdateTool(modifiedTool);
            
            dgTools.Refresh();
            dgTools_SelectionChanged(dgTools, e);
            UpdateFilterFields();            
        }

        private void UpdateTool(ScrewingTool tool)
        {
            GeneralResponse<ScrewingTool> response = Task.Run(() => DataBaseService.updateScrewingTool(tool)).Result;
            if (!response.isResultOK)
            {
                MessageBox.Show(ConstStorage.UPDATE_ERROR + Environment.NewLine + response.message,
                    ConstStorage.TOOL_EDITING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ScrewingTool updatedTool = ScrewingTool.screwingTools.Find(t => t.id == tool.id);
            updatedTool.CopyFrom(response.data); 
            
            if ((dgTools.DataSource as BindingList<ScrewingTool>).Count == 1 &&
                !(dgTools.Rows[0].DataBoundItem as ScrewingTool).Equals(updatedTool))
            {
                (dgTools.DataSource as BindingList<ScrewingTool>).Add(updatedTool);
            }
            UpdateRowStyle(updatedTool);
            MessageBox.Show(response.message, ConstStorage.TOOL_EDITING);            
        }

        private void UpdateFilterFields()
        {
            if (!cbPitchFilter.Items.Contains(cbPitch.SelectedItem))
            {
                cbPitchFilter.Items.Add(cbPitch.SelectedItem);
            }
            if (modifiedTool.cardNumber.Equals(string.Empty))
            {
                return;
            }
            if (!cbCardFilter.Items.Contains(modifiedTool.cardNumber))
            {
                cbCardFilter.Items.Add(modifiedTool.cardNumber);
            }
        }

        private async void bCheckHistory_Click(object sender, EventArgs e)
        {
            ToolCheck.toolChecks = await DataBaseService.getToolCheckResults(modifiedTool);
            if (ToolCheck.toolChecks.Count > 0 && ToolCheck.toolChecks[0].codeResult == null)
            {
                ToolCheck.toolChecks.Remove(ToolCheck.toolChecks[0]);
            }
            ScrewingToolCheckForm screwingToolCheckForm = new ScrewingToolCheckForm(modifiedTool);
            screwingToolCheckForm.ShowDialog();
        }

        private async void bMovements_Click(object sender, EventArgs e)
        {
            ScrewingToolMovement.screwingToolMovements = await DataBaseService.getToolMovements(modifiedTool);
            ScrewingToolMovementForm screwingToolMovementForm = new ScrewingToolMovementForm(modifiedTool);
            screwingToolMovementForm.ShowDialog();
        }

        private async void bToolType_Click(object sender, EventArgs e)
        {
            Tool.tools = await DataBaseService.getToolList();
            ScrewingToolType.types = await DataBaseService.getScrewingToolTypeList();            
            ConstStorage.BRANDS = await DataBaseService.getConstants(ConstStorage.BRAND);
            ScrewingToolTypeForm screwingToolTypeForm = new ScrewingToolTypeForm();
            screwingToolTypeForm.ShowDialog();
            GeneralService.FilterComboBoxItems(cbToolType, ScrewingToolType.types);
            models = ScrewingToolType.types.Select(t => t.ToString()).OrderBy(m => m).ToList();
            GeneralService.FilterComboBoxItems(cbModelFilter, models);            
        }

        #endregion

    }
}
