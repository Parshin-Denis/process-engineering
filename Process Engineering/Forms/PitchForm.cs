using Process_Engineering.DTO;
using Process_Engineering.Service;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Process_Engineering.Forms
{
    public partial class PitchForm : Form
    {
        private Pitch pitch = new Pitch();

        public PitchForm()
        {
            InitializeComponent();
            tbName.DataBindings.Add("Text", pitch, "name");
            tbNumber.DataBindings.Add("Text", pitch, "number");
            tbName.Enabled = User.isParameterEditingAllowed();
            tbNumber.Enabled = User.isParameterEditingAllowed();
        }

        private void PitchForm_Load(object sender, EventArgs e)
        {
            showPitches(sender, e);
            dgPitches.Columns[0].HeaderText = "ID";
            dgPitches.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgPitches.Columns[1].HeaderText = "№";
            dgPitches.Columns[2].HeaderText = "Название";
            dgPitches.Columns[0].Width = 30;
            dgPitches.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgPitches.Columns[2].Width = dgPitches.Width - SystemInformation.VerticalScrollBarWidth -
                dgPitches.Columns[0].Width - dgPitches.Columns[1].Width - 3;
            dgPitches.ReadOnly = true;
        }

        private void dgPitch_SelectionChanged(object sender, EventArgs e)
        {
            pitch.CopyFrom(dgPitches.SelectedRows.Count != 0
                ? dgPitches.SelectedRows[0].DataBoundItem as Pitch
                : new Pitch());
            tbNumber.DataBindings[0].ReadValue();
            tbName.DataBindings[0].ReadValue();
            bAdd.Enabled = false;
            bUpdate.Enabled = false;
        }

        private async void bAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(ConstStorage.ADD_PITCH, pitch.ToString()), ConstStorage.PITCH_EDITING,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            GeneralResponse<Pitch> response = await DataBaseService.createPitch(pitch);
            if (!response.isResultOK)
            {
                MessageBox.Show(response.message, ConstStorage.PITCH_EDITING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Pitch newPitch = response.data;
            Pitch.pitches.Add(newPitch);
            MessageBox.Show(response.message, ConstStorage.PITCH_EDITING, MessageBoxButtons.OK, MessageBoxIcon.Information);

            tbFind.Text = string.Empty;
            showPitches(sender, e);
            dgPitches.Rows[dgPitches.Rows.Count - 1].Selected = true;
            dgPitches.FirstDisplayedScrollingRowIndex = dgPitches.Rows.Count - 1;
        }

        private async void bUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(ConstStorage.UPDATE_PITCH, pitch.id),
                ConstStorage.PITCH_EDITING, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            GeneralResponse<Pitch> response = await DataBaseService.updatePitch(pitch);
            if (!response.isResultOK)
            {
                MessageBox.Show(response.message, ConstStorage.PITCH_EDITING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Pitch pitchToUpdate = Pitch.pitches.Find(p => p.id == pitch.id);
            pitchToUpdate?.CopyFrom(pitch);
            MessageBox.Show(response.message, ConstStorage.PITCH_EDITING, MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgPitches.Refresh();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showPitches(object sender, EventArgs e)
        {
            dgPitches.DataSource = new BindingList<Pitch>(Pitch.pitches.Where(p => p.Contains(tbFind.Text)).ToList());
            dgPitches.ClearSelection();
            lCount.Text = $"Найдено: {dgPitches.Rows.Count} шт.";
        }

        private void pitchParameterChanged(object sender, EventArgs e)
        {
            if (sender.Equals(tbNumber))
            {
                bAdd.Enabled = true;
            }
            bUpdate.Enabled = dgPitches.SelectedRows.Count > 0;
        }
    }
}
