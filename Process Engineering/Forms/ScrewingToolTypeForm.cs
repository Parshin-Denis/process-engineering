using Process_Engineering.DTO;
using Process_Engineering.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Process_Engineering.Forms
{
    public partial class ScrewingToolTypeForm : Form
    {
        private ScrewingToolType toolType = new ScrewingToolType();

        public ScrewingToolTypeForm()
        {
            InitializeComponent();

            tbModel.DataBindings.Add("Text", toolType, "model");
            cbBrand.DataBindings.Add("Text", toolType, "brand");
            cbBrand.Items.AddRange(ConstStorage.BRANDS);
            tbMaxTorque.DataBindings.Add("Text", toolType, "maxTorque");
            tbMaxTorque.DataBindings[0].ControlUpdateMode = ControlUpdateMode.Never;
            tbMinTorque.DataBindings.Add("Text", toolType, "minTorque");
            tbMinTorque.DataBindings[0].ControlUpdateMode = ControlUpdateMode.Never;
            tbTolerance.DataBindings.Add("Text", toolType, "tolerance");
            tbTolerance.DataBindings[0].ControlUpdateMode = ControlUpdateMode.Never;
            cbTool.Items.AddRange(Tool.tools.ToArray());
            cbType.DataSource = ConstStorage.SCREWING_TOOL_TYPES;

            gbEdit.Enabled = User.isScrewingEditingAllowed();
        }

        private void ToolForm_Load(object sender, EventArgs e)
        {
            updateDataGrid(sender, e);

            dgTools.Columns[0].HeaderText = "ID";
            dgTools.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgTools.Columns[1].HeaderText = "№";
            dgTools.Columns[2].HeaderText = "Тип";
            dgTools.Columns[3].Visible = false;
            dgTools.Columns[4].HeaderText = "Бренд";
            dgTools.Columns[5].HeaderText = "Модель";
            dgTools.Columns[6].HeaderText = "Момент MIN";
            dgTools.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgTools.Columns[1].HeaderText = "№";
            dgTools.Columns[7].HeaderText = "Момент MAX";
            dgTools.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgTools.Columns[1].HeaderText = "№";
            dgTools.Columns[8].HeaderText = "Точность";
            dgTools.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgTools.Columns[1].HeaderText = "№";
            dgTools.Columns[0].Width = 30;
            dgTools.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgTools.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgTools.Columns[5].Width = 150;
            //dgTools.Columns[6].Width = 70;
            //dgTools.Columns[7].Width = 70;
            //dgTools.Columns[8].Width = 70;

            dgTools.Columns[4].Width = dgTools.Width - SystemInformation.VerticalScrollBarWidth -
                dgTools.Columns[0].Width - dgTools.Columns[1].Width - dgTools.Columns[2].Width - dgTools.Columns[5].Width -
                dgTools.Columns[6].Width - dgTools.Columns[7].Width - dgTools.Columns[8].Width - 3;
            dgTools.ReadOnly = true;
        }

        private void dgTools_SelectionChanged(object sender, EventArgs e)
        {
            toolType.copyFrom(dgTools.SelectedRows.Count != 0
                ? dgTools.SelectedRows[0].DataBoundItem as ScrewingToolType
                : new ScrewingToolType());

            cbTool.SelectedItem = Tool.tools.FirstOrDefault(t => t.id == toolType.id);
            cbType.SelectedIndex = toolType.techType < 3 ? -1 : toolType.techType - 3;
            tbMinTorque.DataBindings[0].ReadValue();
            tbMaxTorque.DataBindings[0].ReadValue();
            tbTolerance.DataBindings[0].ReadValue();
        }

        private async void bAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(ConstStorage.ADD_TOOL, $"{toolType.number} {toolType.model}"), ConstStorage.TOOL_EDITING,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            GeneralResponse<ScrewingToolType> response = await DataBaseService.createScrewingToolType(toolType);
            if (!response.isResultOK)
            {
                MessageBox.Show(ConstStorage.ADD_ERROR + Environment.NewLine + response.message,
                    ConstStorage.TOOL_EDITING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ScrewingToolType newToolType = response.data;
            ScrewingToolType.types.Add(newToolType);
            MessageBox.Show(ConstStorage.TOOL_IS_ADDED, ConstStorage.TOOL_EDITING);
            tbFilter.Text = string.Empty;
            updateDataGrid(sender, e);
            dgTools.Rows[dgTools.Rows.Count - 1].Selected = true;
            dgTools.FirstDisplayedScrollingRowIndex = dgTools.Rows.Count - 1;
        }

        private async void bUpdate_Click(object sender, EventArgs e)
        {
            if ((dgTools.SelectedRows[0].DataBoundItem as ScrewingToolType).id != toolType.id)
            {
                MessageBox.Show(ConstStorage.IMPOSSIBLE_CHANGE_TOOL, ConstStorage.TOOL_EDITING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show(string.Format(ConstStorage.UPDATE_TOOL, toolType.id),
                ConstStorage.TOOL_EDITING, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            GeneralResponse<ScrewingToolType> response = await DataBaseService.updateScrewingToolType(toolType);
            if (!response.isResultOK)
            {
                MessageBox.Show(ConstStorage.UPDATE_ERROR + Environment.NewLine + response.message,
                    ConstStorage.TOOL_EDITING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ScrewingToolType toolToUpdate = ScrewingToolType.types.First(t => t.id == toolType.id);
            toolToUpdate.copyFrom(toolType);
            dgTools_SelectionChanged(sender, e);
            MessageBox.Show(ConstStorage.TOOL_IS_UPDATED, ConstStorage.TOOL_EDITING);
            dgTools.Refresh();
            bUpdate.Enabled = false;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateDataGrid(object sender, EventArgs e)
        {
            if (sender.Equals(bClear))
            {
                tbFilter.Text = string.Empty;
            }
            List<ScrewingToolType> filteredTypes = ScrewingToolType.types
                .Where(t => t.Contains(tbFilter.Text))
                .ToList();
            dgTools.DataSource = new BindingList<ScrewingToolType>(filteredTypes);
            dgTools.ClearSelection();
            lCount.Text = $"Найдено: {dgTools.Rows.Count} шт.";
        }

        private void toolTypeParameterChanged(object sender, EventArgs e)
        {
            if (sender.Equals(cbTool))
            {
                toolType.id = cbTool.SelectedIndex == -1 ? null : (cbTool.SelectedItem as Tool).id;
                bAdd.Enabled = toolType.id !=
                    (dgTools.SelectedRows.Count > 0
                    ? (dgTools.SelectedRows[0].DataBoundItem as ScrewingToolType).id
                    : null);
            }
            else if (sender.Equals(cbType))
            {
                toolType.techType = cbType.SelectedIndex + 3;
            }
            else if (sender.Equals(cbBrand))
            {
                ((ComboBox)sender).DataBindings[0].WriteValue();
            }
            else if (sender is TextBox)
            {
                ((TextBox)sender).DataBindings[0].WriteValue();
            }
            bUpdate.Enabled = dgTools.SelectedRows.Count > 0 && !toolType.Equals(dgTools.SelectedRows[0].DataBoundItem as ScrewingToolType);
        }

        private void cbTool_TextChanged(object sender, EventArgs e)
        {
            GeneralService.FilterComboBoxItems(sender as ComboBox, Tool.tools);
        }

        private void textBoxbToolParameter_KeyPress(object sender, KeyPressEventArgs e)
        {
            GeneralService.FilterDigitKeyPress(sender as TextBox, e, false);
        }
    }
}
