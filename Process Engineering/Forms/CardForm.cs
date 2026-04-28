using Process_Engineering.DTO;
using Process_Engineering.Service;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Process_Engineering.Card;

namespace Process_Engineering
{
    internal partial class CardForm : Form
    {
        private Card card;
        private Page page;

        public CardForm()
        {
            card = new Card();
            page = new Page();
            card.pages.Add(page);
            card.controlPlan = string.Empty;
            InitializeComponent();
        }

        public CardForm(Card card)
        {
            this.card = card;
            page = card.pages[0];
            InitializeComponent();
            //TypeColumn.DataSource = new string[] { "Фаза", "Ключ" };
        }

        #region Основные функции

        private async void CardForm_Load(object sender, EventArgs e)
        {
            Tool.tools = await DataBaseService.getToolList();
            Part.parts = await DataBaseService.getPartList();
            ConstStorage.ECDV_LIST = await DataBaseService.getConstants(ConstStorage.ECDV);            
            cbPart.Items.AddRange(Part.parts.ToArray());
            cbTools.Items.AddRange(Tool.tools.ToArray());            
            cbCharacter.DataSource = ConstStorage.CARD_CHARACTERS;
            cbCardType.Items.AddRange(ConstStorage.CARD_TYPES);
            cbProject.Items.AddRange(ConstStorage.PROJECTS);
            cbCode.Items.AddRange(ConstStorage.ECDV_LIST);
            SetMainParameters();
            for (int i = 0; i < card.pages.Count; i++)
            {
                cbPageNumber.Items.Add($"Страница {i + 1}");
            }
            cbPageNumber.SelectedIndex = 0;
        }

        private void SetMainParameters()
        {
            cbCode.DataBindings.Add("Text", card, "code");
            tbName.DataBindings.Add("Text", card, "name");
            tbControlPlan.DataBindings.Add("Text", card, "controlPlan");
            tbNumber.Text = card.number.ToString("000000");
            tbVersion.Text = card.version.ToString();            
            tbDescription.Enabled = !(card.version == 1 || card.id == null); // первая версия            
            tbDescription.DataBindings.Add("Text", card, "description");
            
            foreach (var item in cbCardType.Items)
            {
                if (item.ToString().Substring(0, 1).Equals(card.cardType))
                {
                    cbCardType.SelectedItem = item;
                }
            }
            
            foreach (var item in cbProject.Items)
            {
                if (item.ToString().Substring(0, 1).Equals(card.project))
                {
                    cbProject.SelectedItem = item;
                }
            }
            
            foreach (var item in cbCharacter.Items)
            {
                if (item.ToString().Substring(0, 1).Equals(card.character))
                {
                    cbCharacter.SelectedItem = item;
                }
            }
        }

        private void AdjustDataGrid()
        {
            dgPhases.Columns[1].Visible = false;
            dgPhases.Columns[2].HeaderText = "Описание";
            dgPhases.Columns[2].Width = dgPhases.Width - dgPhases.RowHeadersWidth - SystemInformation.VerticalScrollBarWidth -
                dgPhases.Columns[0].Width - 2;
            ((DataGridViewTextBoxColumn)dgPhases.Columns[2]).MaxInputLength = 255;

            dgParts.Columns[0].Visible = false;            
            dgParts.Columns[1].ReadOnly = true;
            dgParts.Columns[1].HeaderText = "Номер";
            dgParts.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgParts.Columns[2].HeaderText = "Название";
            dgParts.Columns[2].ReadOnly = true;
            dgParts.Columns[3].HeaderText = "Кол-во";
            dgParts.Columns[3].Width = 50;
            dgParts.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgParts.Columns[4].HeaderText = "Ед.изм.";
            dgParts.Columns[4].Width = 50;
            dgParts.Columns[4].ReadOnly = true;
            dgParts.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgParts.Columns[5].Width = 50;
            dgParts.Columns[5].HeaderText = "Метка";
            dgParts.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgParts_ColumnWidthChanged(dgParts, new DataGridViewColumnEventArgs(dgParts.Columns[1]));

            dgTools.Columns[0].Visible = false;
            dgTools.Columns[1].ReadOnly = true;
            dgTools.Columns[1].HeaderText = "Номер";
            dgTools.Columns[1].Width = 80;
            dgTools.Columns[2].ReadOnly = true;
            dgTools.Columns[2].HeaderText = "Название";
            dgTools.Columns[2].Width = dgTools.Width - dgTools.RowHeadersWidth - dgTools.Columns[1].Width - 2;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (!AreMainParametersSet())
            {
                return;
            }
            card.cardType = cbCardType.SelectedItem.ToString().Substring(0, 1);
            card.project = cbProject.SelectedItem.ToString().Substring(0, 1);
            card.character = cbCharacter.SelectedItem.ToString().Substring(0, 1);
            SetPhaseNumber();

            GeneralResponse<Card> response = DataBaseService.createProcessCard(card);
            if (!response.isResultOK)
            {
                MessageBox.Show(ConstStorage.SAVE_ERROR + Environment.NewLine + response.message,
                    ConstStorage.CARD_SAVING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Card savedCard = response.data;
            if (card.id == null || card.version == 0) // новая гамма или новая версия
            {                
                card.id = savedCard.id;
                card.number = savedCard.number;
                card.version = savedCard.version;
                card.creationTime = savedCard.creationTime;
                tbNumber.Text = card.number.ToString("000000");
                tbVersion.Text = card.version.ToString();
            }            
            
            MessageBox.Show("Гамма успешно сохранена", ConstStorage.CARD_SAVING, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool AreMainParametersSet()
        {
            if (cbCardType.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран тип гаммы", ConstStorage.CARD_SAVING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbProject.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран проект", ConstStorage.CARD_SAVING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (tbName.Text.Length == 0)
            {
                MessageBox.Show("Не введено название гаммы", ConstStorage.CARD_SAVING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (card.code.Equals(string.Empty))
            {
                MessageBox.Show("Не введена применяемость гаммы", ConstStorage.CARD_SAVING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (tbDescription.Text.Length < 6)
            {
                MessageBox.Show("Не введено описание изменения", ConstStorage.CARD_SAVING, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void bShowInExcel_Click(object sender, EventArgs e)
        {
            SetPhaseNumber();
            ExtractionService.show(card);
        }

        private void CardForm_Resize(object sender, EventArgs e)
        {
            int incrementValue = (Width - 1130) / 2;
            gbParts.Width = 577 + incrementValue;
            gbTools.Width = 517 + incrementValue;
            cbPart.Width = 478 + incrementValue;
            cbTools.Width = 418 +incrementValue;
            AdjustDataGrid();
        }

        #endregion

        #region Фазы, Завинчивание

        private void dgPhases_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < dgPhases.Rows.Count && dgPhases.Rows[e.RowIndex].Cells[0].Value == null)
            {
                dgPhases.Rows[e.RowIndex].Cells[0].Value = "Фаза";
            }
            if (dgPhases.Rows.Count == 11)
            {
                dgPhases.AllowUserToAddRows = false;
            }
        }

        private void dgPhases_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgPhases.Rows.Count < 10)
            {
                dgPhases.AllowUserToAddRows = true;
            }
        }

        private void dgPhases_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1 && e.RowIndex < page.phases.Count)
            {
                dgPhases.Rows[e.RowIndex].DefaultCellStyle.BackColor =
                    dgPhases.Rows[e.RowIndex].Cells[0].Value.ToString().Equals("Фаза")
                        ? Color.White : Color.LightGray;
            }
        }

        private void dgPhases_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgPhases.SelectedRows.Count == 0)
            {
                return;
            }
            if (e.RowIndex == 0 || e.RowIndex >= page.phases.Count)
            {
                return;
            }
            Phase phase = page.phases[e.RowIndex];
            page.phases.Remove(phase);
            page.phases.Insert(e.RowIndex - 1, phase);
            object phaseType = dgPhases.Rows[e.RowIndex].Cells[0].Value;
            dgPhases.Rows[e.RowIndex].Cells[0].Value = dgPhases.Rows[e.RowIndex - 1].Cells[0].Value;
            dgPhases.Rows[e.RowIndex - 1].Cells[0].Value = phaseType;
            dgPhases.Refresh();
        }

        private void SetPhaseNumber()
        {
            if (dgPhases.DataSource == null)
            {
                return;
            }
            for (int i = 0; i < page.phases.Count; i++)
            {
                page.phases[i].number = dgPhases.Rows[i].Cells[0].Value.ToString().Equals("Фаза") ? 1 : 0;
            }
            int phaseCount = 0;
            foreach (Phase phase in card.pages.SelectMany(p => p.phases))
            {
                phase.number = phase.number == 0 ? 0 : ++phaseCount;
            }
        }

        private void SetPhaseType()
        {
            for (int i = 0; i < page.phases.Count; i++)
            {
                dgPhases.Rows[i].Cells[0].Value = page.phases[i].number == 0 ? "Ключ" : "Фаза";
            }
        }

        private void cbScrewing_CheckedChanged(object sender, EventArgs e)
        {
            tbTorque.Enabled = cbScrewing.Checked;
            tbTorqueTolerance.Enabled = cbScrewing.Checked;
            tbAngle.Enabled = cbScrewing.Checked;
            tbAngleTolerance.Enabled = cbScrewing.Checked;
            if (cbScrewing.Checked)
            {
                page.screwing = page.screwing ?? new Screwing();
                tbTorque.DataBindings.Add("Text", page.screwing, "torque");
                tbTorqueTolerance.DataBindings.Add("Text", page.screwing, "torqueTolerance");
                tbAngle.DataBindings.Add("Text", page.screwing, "angle");
                tbAngleTolerance.DataBindings.Add("Text", page.screwing, "angleTolerance");
            }
            else
            {
                tbTorque.DataBindings.Clear();
                tbTorqueTolerance.DataBindings.Clear();
                tbAngle.DataBindings.Clear();
                tbAngleTolerance.DataBindings.Clear();
                tbTorque.Text = string.Empty;
                tbTorqueTolerance.Text = string.Empty;
                tbAngle.Text = string.Empty;
                tbAngleTolerance.Text = string.Empty;
                if (page != null)
                {
                    page.screwing = null;
                }
            }
        }

        private void tbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender.GetType() == typeof(DataGridViewTextBoxEditingControl) && dgParts.CurrentCell.ColumnIndex == 5)
            {
                if (((sender as DataGridViewTextBoxEditingControl).TextLength == 1 || !char.IsLetterOrDigit(e.KeyChar)) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
                e.KeyChar = char.ToUpper(e.KeyChar);
                return;
            }
            GeneralService.FilterDigitKeyPress(sender as TextBox, e, (sender as TextBox).Name.Contains("Angle"));
        }

        #endregion

        #region Детали

        private void bAddPart_Click(object sender, EventArgs e)
        {
            if (dgParts.Rows.Count == 5 || cbPart.SelectedIndex == -1)
            {
                return;
            }
            Card.Consumption consumption = new Card.Consumption();
            Part part = cbPart.SelectedItem as Part;
            consumption.partId = part.id;
            consumption.partName = part.name;
            consumption.partNumber = part.number;
            consumption.unit = part.unit;
            ((BindingList<Card.Consumption>)dgParts.DataSource).Add(consumption);            
        }

        private void cbPart_TextChanged(object sender, EventArgs e)
        {
            GeneralService.FilterComboBoxItems(sender as ComboBox, Part.parts);
        }

        private void dgParts_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(tbNumber_KeyPress);
        }

        private void dgParts_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.Index != 1) return;
            dgParts.Columns[2].Width = dgParts.Width - dgParts.RowHeadersWidth - dgParts.Columns[1].Width - dgParts.Columns[3].Width
                - dgParts.Columns[4].Width - dgParts.Columns[5].Width - 2;
        }

        #endregion

        #region Инструменты

        private void bAddTool_Click(object sender, EventArgs e)
        {
            if (dgTools.Rows.Count == 5)
            {
                return;
            }
            Tool tool = cbTools.SelectedItem as Tool;            
            ((BindingList<Tool>)dgTools.DataSource).Add(tool);
        }

        private void cbTools_TextChanged(object sender, EventArgs e)
        {
            GeneralService.FilterComboBoxItems(sender as ComboBox, Tool.tools);
        }

        private void dgTools_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0 || e.RowIndex == 0)
            {
                return;
            }
            Tool tool = page.tools[e.RowIndex];
            page.tools.Remove(tool);
            page.tools.Insert(e.RowIndex - 1, tool);
            dgTools.Refresh();
        }

        #endregion

        #region Изображения

        private void bPicture_Click(object sender, EventArgs e)
        {
            if (openPictureDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            Image picture = Image.FromFile(openPictureDialog.FileName);
            insertPicture(picture);
        }

        private void pictureBox_DragDrop(object sender, DragEventArgs e)
        {
            insertPicture((Bitmap)e.Data.GetData(DataFormats.Bitmap));
        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (Clipboard.GetImage() != null)
                    insertPicture(Clipboard.GetImage());
                else
                    MessageBox.Show("Буфер обмена изображениями пуст.", "Ошибка чтения изображения");
            }
            catch (Exception error)
            {
                MessageBox.Show("Была встречена ошибка:\n" + error.Message, "Ошибка чтения изображения");
            }
        }

        private void insertPicture(Image picture)
        {
            if (picture.Height > 850 || picture.Width > 1000)
            {
                int newHeight;
                int newWidth;
                if (picture.Height > 0.85 * picture.Width)
                {
                    newHeight = 850;
                    newWidth = 850 * picture.Width / picture.Height;
                }
                else
                {
                    newWidth = 1000;
                    newHeight = 1000 * picture.Height / picture.Width;
                }
                page.picture = new Bitmap(picture, newWidth, newHeight);
            }
            else
            {
                page.picture = picture;
            }
            pictureBox.Image = page.picture;
        }
        #endregion

        #region Страницы

        private void cbPageNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPageNumber.SelectedIndex == -1)
            {
                page = null;
                dgPhases.DataSource = null;
                dgParts.DataSource = null;
                dgTools.DataSource = null;
                cbScrewing.Checked = false;
                cbScrewing.Enabled = false;
                pictureBox.Image = null;
                return;
            }
            page = card.pages[cbPageNumber.SelectedIndex];
            dgPhases.DataSource = new BindingList<Phase>(page.phases);
            SetPhaseType();
            dgParts.DataSource = new BindingList<Consumption>(page.consumptions);
            dgTools.DataSource = new BindingList<Tool>(page.tools);
            cbScrewing.Checked = page.screwing != null;
            cbScrewing.Enabled = cbPageNumber.SelectedIndex == 0;
            pictureBox.Image = page.picture;
            if (dgParts.Columns[1].Visible)
            {
                AdjustDataGrid();
            }
        }

        private void bAddPage_Click(object sender, EventArgs e)
        {
            if (card.pages.Count == 9) { return; }
            card.pages.Add(new Page());
            cbPageNumber.Items.Add($"Страница {card.pages.Count}");
            cbPageNumber.SelectedIndex = card.pages.Count - 1;
        }

        private void bDeletePage_Click(object sender, EventArgs e)
        {
            if (card.pages.Count == 1)
            {
                return;
            }
            if (MessageBox.Show(string.Format(ConstStorage.DELETE_PAGE, cbPageNumber.SelectedIndex + 1),
                ConstStorage.PAGE_DELETING,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            card.pages.Remove(page);
            cbPageNumber.SelectedIndex = -1;
            cbPageNumber.Items.RemoveAt(cbPageNumber.Items.Count - 1);
        }

        #endregion
                
    }

}
