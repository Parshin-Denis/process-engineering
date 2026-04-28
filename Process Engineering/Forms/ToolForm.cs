using Process_Engineering.DTO;
using Process_Engineering.Service;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Process_Engineering.Forms
{
    public partial class ToolForm : Form
    {
        private Tool tool = new Tool();

        public ToolForm()
        {
            InitializeComponent();
            tbName.Enabled = User.isParameterEditingAllowed();
            tbNumber.Enabled = User.isParameterEditingAllowed();
        }

        private void ToolForm_Load(object sender, EventArgs e)
        {
            updateDataGrid(sender, e);
            dgTools.Columns[0].HeaderText = "ID";
            dgTools.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgTools.Columns[1].HeaderText = "№";
            dgTools.Columns[2].HeaderText = "Название";
            dgTools.Columns[0].Width = 30;
            dgTools.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgTools.Columns[2].Width = dgTools.Width - SystemInformation.VerticalScrollBarWidth -
                dgTools.Columns[0].Width - dgTools.Columns[1].Width - 3;
            dgTools.ReadOnly = true;
        }

        private void dgTools_SelectionChanged(object sender, EventArgs e)
        {
            if (dgTools.SelectedRows.Count != 0)
            {
                tool.copyFrom(dgTools.SelectedRows[0].DataBoundItem as Tool);
                tbNumber.Text = tool.number;
                tbName.Text = tool.name;
            }
            else
            {
                tbNumber.Text = string.Empty;
                tbName.Text = string.Empty;
            }
            bAdd.Enabled = false;
            bUpdate.Enabled = false;
        }

        private async void bAdd_Click(object sender, EventArgs e)
        {
            Tool newTool = new Tool();
            newTool.number = tbNumber.Text.Trim();
            newTool.name = tbName.Text.Trim();
            if (MessageBox.Show(string.Format(ConstStorage.ADD_TOOL, newTool.ToString()), ConstStorage.TOOL_EDITING,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            GeneralResponse<Tool> response = await DataBaseService.createTool(newTool);
            if (!response.isResultOK)
            {
                MessageBox.Show(ConstStorage.ADD_ERROR + Environment.NewLine + response.message,
                    ConstStorage.TOOL_EDITING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            newTool = response.data;
            Tool.tools.Add(newTool);
            MessageBox.Show(ConstStorage.TOOL_IS_ADDED, ConstStorage.TOOL_EDITING);
            tbFind.Text = string.Empty;
            updateDataGrid(sender, e);
            dgTools.Rows[dgTools.Rows.Count - 1].Selected = true;
            dgTools.FirstDisplayedScrollingRowIndex = dgTools.Rows.Count - 1;
        }

        private async void bUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(ConstStorage.UPDATE_TOOL, tool.id),
                ConstStorage.TOOL_EDITING, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            tool.number = tbNumber.Text.Trim();
            tool.name = tbName.Text.Trim();
            GeneralResponse<Object> response = await DataBaseService.updateTool(tool);
            if (!response.isResultOK)
            {
                MessageBox.Show(ConstStorage.UPDATE_ERROR + Environment.NewLine + response.message,
                    ConstStorage.TOOL_EDITING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Tool toolToUpdate = Tool.tools.First(t => t.id == tool.id);
            toolToUpdate.number = tbNumber.Text;
            toolToUpdate.name = tbName.Text;
            MessageBox.Show(ConstStorage.TOOL_IS_UPDATED, ConstStorage.TOOL_EDITING);
            dgTools.Refresh();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateDataGrid(object sender, EventArgs e)
        {
            dgTools.DataSource = new BindingList<Tool>(Tool.tools.Where(t => t.Contains(tbFind.Text)).ToList());
            dgTools.ClearSelection();
            lCount.Text = $"Найдено: {dgTools.Rows.Count} шт.";
        }

        private void toolParameterChanged(object sender, EventArgs e)
        {
            if (sender.Equals(tbNumber))
            {
                bAdd.Enabled = true;
            }
            bUpdate.Enabled = dgTools.SelectedRows.Count != 0;
        }
    }
}
