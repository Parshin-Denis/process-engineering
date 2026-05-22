using Process_Engineering.DTO;
using Process_Engineering.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Process_Engineering.Forms
{
    public partial class PartForm : Form
    {
        private Part part = new Part();

        public PartForm()
        {
            InitializeComponent();
            pPartParameter.Enabled = User.isParameterEditingAllowed();
        }

        private void PartForm_Load(object sender, EventArgs e)
        {
            bFind_Click(sender, e);
            dgParts.Columns[0].HeaderText = "ID";
            dgParts.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgParts.Columns[1].HeaderText = "№";
            dgParts.Columns[2].HeaderText = "Название";
            dgParts.Columns[3].HeaderText = "Ед.изм.";
            dgParts.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgParts.Columns[0].Width = 40;
            dgParts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgParts.Columns[3].Width = 50;
            dgParts.Columns[2].Width = dgParts.Width - SystemInformation.VerticalScrollBarWidth -
                dgParts.Columns[0].Width - dgParts.Columns[3].Width - dgParts.Columns[1].Width - 3;
            dgParts.ReadOnly = true;
        }

        private void dgParts_SelectionChanged(object sender, EventArgs e)
        {
            if (!dgParts.Enabled) { return; }
            if (dgParts.SelectedRows.Count != 0)
            {
                part.CopyFrom(dgParts.SelectedRows[0].DataBoundItem as Part);
                lbCards.DataSource = DataBaseService.getAllCardsByPart(part.id);
                lbCards.ClearSelected();
            }
            else
            {
                lbCards.DataSource = null;
            }
            tbNumber.Text = dgParts.SelectedRows.Count != 0 ? part.number : string.Empty;
            tbName.Text = dgParts.SelectedRows.Count != 0 ? part.name : string.Empty;
            tbUnit.Text = dgParts.SelectedRows.Count != 0 ? part.unit : string.Empty;
            bUpdate.Enabled = false;
            bAdd.Enabled = false;
        }

        private async void bAdd_Click(object sender, EventArgs e)
        {
            Part newPart = new Part();
            newPart.number = tbNumber.Text.Trim();
            newPart.name = tbName.Text.Trim();
            newPart.unit = tbUnit.Text.Trim();
            if (MessageBox.Show(string.Format(ConstStorage.ADD_PART, newPart.ToString()), ConstStorage.PART_EDITING,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            GeneralResponse<Part> response = await DataBaseService.createPart(newPart);
            if (!response.isResultOK)
            {
                MessageBox.Show(ConstStorage.ADD_ERROR + Environment.NewLine + response.message,
                    ConstStorage.PART_EDITING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            newPart = response.data;
            Part.parts.Add(newPart);
            MessageBox.Show(ConstStorage.PART_IS_ADDED, ConstStorage.PART_EDITING);
            dgParts.DataSource = new BindingList<Part>(Part.parts);
            tbFind.Text = string.Empty;
            dgParts.ClearSelection();
            dgParts.Rows[dgParts.Rows.Count - 1].Selected = true;
            dgParts.FirstDisplayedScrollingRowIndex = dgParts.Rows.Count - 1;
        }

        private async void bUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(ConstStorage.UPDATE_PART, part.id),
                ConstStorage.PART_EDITING, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            part.number = tbNumber.Text.Trim();
            part.name = tbName.Text.Trim();
            part.unit = tbUnit.Text.Trim();
            GeneralResponse<object> response = await DataBaseService.updatePart(part);
            if (!response.isResultOK)
            {
                MessageBox.Show(ConstStorage.UPDATE_ERROR + Environment.NewLine + response.message,
                    ConstStorage.PART_EDITING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Part partToUpdate = Part.parts.First(p => p.id == part.id);
            partToUpdate.number = tbNumber.Text;
            partToUpdate.name = tbName.Text;
            partToUpdate.unit = tbUnit.Text;
            MessageBox.Show(ConstStorage.PART_IS_UPDATED, ConstStorage.PART_EDITING);
            dgParts.Refresh();
        }

        private async void bFind_Click(object sender, EventArgs e)
        {
            dgParts.Enabled = false;
            List<long?> usedPartsId = cbNotUsed.Checked
                ? (await DataBaseService.getConsumptionList()).Select(c => c.partId).Distinct().ToList()
                : new List<long?>();
            dgParts.DataSource = new BindingList<Part>(Part.parts)
                .Where(p => p.Contains(tbFind.Text))
                .Where(p => !usedPartsId.Contains(p.id))
                .ToList();
            dgParts.Enabled = true;
            dgParts.ClearSelection();
            lQuantity.Text = $"Найдено: {dgParts.Rows.Count} шт.";
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bShowAll_Click(object sender, EventArgs e)
        {
            tbFind.Text = string.Empty;
            cbNotUsed.Checked = false;
            bFind_Click(sender, e);
        }

        private void cbNotUsed_CheckedChanged(object sender, EventArgs e)
        {
            bFind_Click(sender, e);
        }

        private void partParameterChanged(object sender, EventArgs e)
        {
            if (sender.Equals(tbNumber))
            {
                bAdd.Enabled = true;
            }
            bUpdate.Enabled = dgParts.SelectedRows.Count != 0;
        }

        private async void lbCards_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbCards.SelectedIndex == -1) return;
            Card card = await DataBaseService.getCard((lbCards.SelectedItem as CardBase).id);
            ExtractionService.show(card);
        }

        private async void bConsumptions_Click(object sender, EventArgs e)
        {
            List<ConsumptionResponse> consumptions = await DataBaseService.getDetailedConsumptionList();
            ExtractionService.show(consumptions);
        }

        private void lbCards_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.FillRectangle((lbCards.Items[e.Index] as CardShortInfo).isActual ? Brushes.White : Brushes.LightGray, e.Bounds);

            e.Graphics.DrawString(lbCards.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                Pen pen = new Pen(Color.Blue, 2);

                Rectangle rect = new Rectangle(e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 2, e.Bounds.Height - 2);
                
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
    }
}
