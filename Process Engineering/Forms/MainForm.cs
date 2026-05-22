using Process_Engineering.DTO;
using Process_Engineering.Objects;
using Process_Engineering.Properties;
using Process_Engineering.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Process_Engineering.Forms
{
    public partial class MainForm : Form
    {
        private List<CardShortInfo> cards;

        private long cardsCount;

        private List<Part> usedParts;

        private List<User> cardCreators;

        private CardShortInfo selectedCardFinalVS;

        private CardMainInfo selectedCard; 

        private CardFilter filter = new CardFilter();

        private bool isFilterActive = false;

        private bool isActualCardsMode = true;

        #region Основная форма

        public MainForm()
        {
            InitializeComponent();
            dgCardInfo.Rows.Add(13);
            dgCardInfo.Rows[0].Cells[0].Value = "Тип";
            dgCardInfo.Rows[1].Cells[0].Value = "Проект";
            dgCardInfo.Rows[2].Cells[0].Value = "Номер";            
            dgCardInfo.Rows[3].Cells[0].Value = "Название";
            dgCardInfo.Rows[4].Cells[0].Value = "Применяемость";
            dgCardInfo.Rows[5].Cells[0].Value = "План контроля";
            dgCardInfo.Rows[6].Cells[0].Value = "Характеристика";
            dgCardInfo.Rows[7].Cells[0].Value = "Завинчивание";
            dgCardInfo.Rows[8].Cells[0].Value = "Инструмент";
            dgCardInfo.Rows[9].Cells[0].Value = "Автор";
            dgCardInfo.Rows[10].Cells[0].Value = "Дата создания";
            dgCardInfo.Rows[11].Cells[0].Value = "Дата посл. изм.";
            dgCardInfo.Rows[12].Cells[0].Value = "Пост";            
            dgCardInfo.Rows[3].Height = dgCardInfo.Height - 12 * dgCardInfo.RowTemplate.Height - 3;            
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            dgCards_SizeChanged(sender, e);

            await loadDataFromDB();

            FindCards();
        }

        private void updateForm()
        {
            bChangePassword.Visible = DataBaseService.user != null;
            toolTip.SetToolTip(bLogIn, DataBaseService.user != null ? "Выход" : "Вход");
            bLogIn.BackgroundImage = DataBaseService.user != null ? Resources.logout : Resources.login;
            lUser.Text = DataBaseService.user?.name ?? "Неизвестный пользователь";
            bCreateCard.Enabled = User.isCardEditingAllowed();
            bEdit.Visible = User.isCardEditingAllowed() && isActualCardsMode;
            bNewVersion.Visible = User.isCardEditingAllowed() && isActualCardsMode;
            bArchive.Visible = User.isCardEditingAllowed();
            bArchive.BackgroundImage = isActualCardsMode ? Resources.delete : Resources.restore;
            toolTip.SetToolTip(bArchive, isActualCardsMode ? "Переместить в архив" : "Восстановить из архива");
            bCopyCard.Visible = User.isCardEditingAllowed();            
            cbCardPitch.Visible = User.isCardEditingAllowed() && isActualCardsMode;
            bPutPitch.Visible = User.isCardEditingAllowed() && isActualCardsMode;
            bPosition.Visible = User.isCardEditingAllowed() && isActualCardsMode;
            udPosition.Visible = User.isCardEditingAllowed() && isActualCardsMode;
            lPitchNumber.Visible = User.isCardEditingAllowed() && isActualCardsMode;
            lPosition.Visible = User.isCardEditingAllowed() && isActualCardsMode;
            bChrono.Visible = isActualCardsMode;
            lPitch.Visible = isActualCardsMode;
            cbPitch.Visible = isActualCardsMode;
            lPart.Visible = isActualCardsMode;
            cbPart.Visible = isActualCardsMode;
        }        

        #endregion

        #region Пользователь

        private void bLogIn_Click(object sender, EventArgs e)
        {
            if (DataBaseService.user == null)
            {
                LogInForm logInForm = new LogInForm();
                DialogResult dialogResult = logInForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    lUser.Text = DataBaseService.user.name;
                }
                updateForm();
                return;
            }
            DataBaseService.clearUser();
            updateForm();
        }

        private void bChangePassword_Click(object sender, EventArgs e)
        {
            PasswordForm passwordForm = new PasswordForm();
            passwordForm.ShowDialog();
        }

        private void lUser_DoubleClick(object sender, EventArgs e)
        {
            if (DataBaseService.user?.role != ConstStorage.ROLE_ADMIN)
            {
                return;
            }
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
        }

        #endregion

        #region Фильтр

        private void FilterCardParameterChanged(object sender, EventArgs e)
        {
            if (sender.Equals(cbPitch))
            {
                Pitch selectedPitch = cbPitch.SelectedItem as Pitch;
                dgCards.Columns[1].Visible = selectedPitch?.id != null;
                cbCardType.Enabled = selectedPitch?.id == null;
                cbProject.Enabled = selectedPitch?.id == null;
                tbCardNumber.Enabled = selectedPitch?.id == null;
                tbName.Enabled = selectedPitch?.id == null;
                cbCharacter.Enabled = selectedPitch?.id == null;
                cbPart.Enabled = selectedPitch?.id == null;
                cbUsers.Enabled = selectedPitch?.id == null;
                bChrono.Enabled = selectedPitch?.id != null;
                udPosition.Enabled = selectedPitch?.id != null;
                bPosition.Enabled = selectedPitch?.id != null;
                dgCards_SizeChanged(sender, EventArgs.Empty);
            }
            if (!isFilterActive)
            {
                return;
            }
            FindCards();
        }

        private void FindCards(bool isNew = true)
        {
            if (isNew)
            {
                Pitch pitch = cbPitch.SelectedItem as Pitch;
                filter.isActual = isActualCardsMode;
                filter.cardType = pitch?.id == null ? cbCardType.SelectedItem?.ToString().Substring(0, 1) : null;
                filter.project = pitch?.id == null ? cbProject.SelectedItem?.ToString().Substring(0, 1) : null;
                filter.number = pitch?.id == null && !tbCardNumber.Text.Equals(string.Empty) ? int.Parse(tbCardNumber.Text) : 0;
                filter.name = pitch?.id == null ? tbName.Text : null;
                filter.code = pitch?.id == null ? tbControlPlan.Text : null;
                filter.character = pitch?.id == null ? cbCharacter.SelectedItem?.ToString().Substring(0, 1) : null;
                filter.userId = pitch?.id == null ? (cbUsers.SelectedItem as User)?.id : null;                
                filter.pitchId = pitch == null ? null : pitch.id ?? (long?)0;
                filter.partId = pitch?.id == null ? (cbPart.SelectedItem as Part)?.id : null;
            }            
            CardList cardList = Task.Run(() => DataBaseService.getAllCards(filter, isNew ? 0 : cards.Count / 100, 100)).Result;
            if (isNew)
            {
                cards = cardList.cards;
            }
            else
            {
                cards.AddRange(cardList.cards);
            }
            cardsCount = cardList.totalCount;
            lCount.Text = $"Найдено: {cardsCount} шт.";
            UpdateDGCards(isNew);
        }

        private void bResetFilter_Click(object sender, EventArgs e)
        {
            isFilterActive = false;
            cbCardType.SelectedIndex = -1;
            cbCardType.Text = string.Empty;
            cbProject.SelectedIndex = -1;
            cbProject.Text = string.Empty;
            tbCardNumber.Text = string.Empty;
            tbName.Text = string.Empty;
            tbControlPlan.Text = string.Empty;
            cbPart.SelectedIndex = -1;
            cbPart.Text = string.Empty;
            cbCharacter.SelectedIndex = -1;
            cbCharacter.Text = string.Empty;
            cbPitch.SelectedIndex = -1;
            cbPitch.Text = string.Empty;
            cbUsers.SelectedIndex = -1;
            cbUsers.Text = string.Empty;
            isFilterActive = true;
            FilterCardParameterChanged(cbPitch, e);            
        }

        private async void cbPart_TextChanged(object sender, EventArgs e)
        {
            if (cbPart.Text.Length == 1)
            {
                usedParts = await DataBaseService.getPartsFromCards();
            }
            GeneralService.FilterComboBoxItems(sender as ComboBox, usedParts);
        }

        private async void cbPitch_TextChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).Text.Length == 1)
            {
                Pitch.pitches = (await DataBaseService.getPitchList()).OrderBy(p => p.number).ToList();
                Pitch.pitches.Insert(0, new Pitch(ConstStorage.NO_PITCH));
            }            
            GeneralService.FilterComboBoxItems(sender as ComboBox, Pitch.pitches);
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender.Equals(tbCardNumber))
            {
                GeneralService.FilterDigitKeyPress(tbCardNumber, e, true);
            }
            if (e.KeyChar == ((char)Keys.Enter))
            {
                FindCards();
            }
        }

        private void bChrono_Click(object sender, EventArgs e)
        {
            if (cbPitch.SelectedIndex > 0)
            {
                ExtractionService.show(cbPitch.SelectedItem as Pitch, cards);
            }
        }

        private async void cbUsers_DropDown(object sender, EventArgs e)
        {
            cardCreators = await DataBaseService.getCardCreatorList(isActualCardsMode);
            GeneralService.UpdateComboBoxItems(sender as ComboBox, cardCreators);
        }

        private async void cbCardType_DropDown(object sender, EventArgs e)
        {
            ConstStorage.CARD_TYPES = await DataBaseService.getConstants(ConstStorage.CARD_TYPE);
            GeneralService.UpdateComboBoxItems(sender as ComboBox, ConstStorage.CARD_TYPES);            
        }

        private async void cbProject_DropDown(object sender, EventArgs e)
        {
            ConstStorage.PROJECTS = await DataBaseService.getConstants(ConstStorage.PROJECT);
            GeneralService.UpdateComboBoxItems(sender as ComboBox, ConstStorage.PROJECTS);
        }

        private async void cbCharacter_DropDown(object sender, EventArgs e)
        {
            ConstStorage.CARD_CHARACTERS = await DataBaseService.getConstants(ConstStorage.CHARACTER);
            GeneralService.UpdateComboBoxItems(sender as ComboBox, ConstStorage.CARD_CHARACTERS);
        }

        #endregion

        #region Список гамм

        private async void dgCards_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                if (isActualCardsMode && MessageBox.Show(ConstStorage.CHANGE_MODE, ConstStorage.MODE_CHANGING,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                isActualCardsMode = !isActualCardsMode;
                bResetFilter_Click(sender, e);
                updateForm();
                return;
            }
            long cardId = long.Parse(dgCards.Rows[e.RowIndex].Cells["cardIdColumn"].Value.ToString());
            Card cardToExtract = await DataBaseService.getCard(cardId);            
            ExtractionService.show(cardToExtract);            
        }

        private void dgCards_SelectionChanged(object sender, EventArgs e)
        {
            selectedCardFinalVS = dgCards.SelectedRows.Count != 0 && dgCards.Enabled ? cards[dgCards.SelectedRows[0].Index] : null;
            
            cbVersion.Items.Clear();
            if (selectedCardFinalVS != null)
            {
                int lastVersion = isActualCardsMode ? selectedCardFinalVS.version : DataBaseService.getLastCardVersion(selectedCardFinalVS);
                for (int i = lastVersion; i > 0; i--) cbVersion.Items.Add(i);
                if (!isActualCardsMode)
                {
                    cbVersion.Items.Insert(0, 0);
                }
                cbVersion.SelectedItem = isActualCardsMode ? selectedCardFinalVS.version : 0;
            }            
            else
            {
                selectedCard = null;
                UpdateDGCardInfo();
            }
            gbCardInfo.Enabled = dgCards.SelectedRows.Count != 0;
        }

        private void UpdateDGCards(bool isNew = true)
        {
            dgCards.Enabled = false;
            int firstIndex = isNew ? 0 : dgCards.Rows.Count;
            while (dgCards.Rows.Count != cards.Count)
            {
                if (dgCards.Rows.Count > cards.Count)
                {
                    dgCards.Rows.RemoveAt(0);
                }
                else
                {
                    dgCards.Rows.Add(cards.Count - dgCards.Rows.Count);
                }
            }
            for (int i = firstIndex ; i < cards.Count; i++)            
            {
                CardShortInfo card = cards[i];
                dgCards.Rows[i].Cells[0].Value = card.id;
                dgCards.Rows[i].Cells[1].Value = i + 1;
                dgCards.Rows[i].Cells[2].Value = card.GetDesignation();
                dgCards.Rows[i].Cells[3].Value = card.character;
                dgCards.Rows[i].Cells[4].Value = card.name;
                dgCards.Rows[i].Cells[5].Value = card.code;
            }            
            dgCards.Enabled = true;
            if (isNew && dgCards.Rows.Count !=0)
            {
                dgCards.FirstDisplayedScrollingRowIndex = 0;
            }
            dgCards.ClearSelection();
        }

        private void dgCards_SizeChanged(object sender, EventArgs e)
        {
            dgCards.Columns[4].Width = dgCards.Width - SystemInformation.VerticalScrollBarWidth -
                (dgCards.Columns[1].Visible ? dgCards.Columns[1].Width : 0) -
                dgCards.Columns[2].Width - dgCards.Columns[3].Width - dgCards.Columns[5].Width - 3;
        }

        private void dgCards_Scroll(object sender, ScrollEventArgs e)
        {
            if (dgCards.DisplayedRowCount(true) + dgCards.FirstDisplayedScrollingRowIndex == cards.Count)
            {
                if (cards.Count < cardsCount)
                {
                    FindCards(false);
                }
            }
        }

        #endregion

        #region Информация о гамме        

        private async void bEdit_Click(object sender, EventArgs e)
        {
            Card card = await DataBaseService.getCard(selectedCard.id);
            if (card.creator?.id != DataBaseService.user?.id && !tbName.Text.Equals("доступ"))
            {
                MessageBox.Show("Вы не являетесь создателем гаммы", "Изменение невозможно");
                return;
            }
            Visible = false;
            CardForm cardForm = new CardForm(card);
            cardForm.ShowDialog();
            selectedCard = await DataBaseService.getCard(selectedCard.number, selectedCard.version);
            UpdateDGCardInfo();
            dgCards.Rows[dgCards.SelectedCells[0].RowIndex].Cells["cardNameColumn"].Value = card.name;
            dgCards.Rows[dgCards.SelectedCells[0].RowIndex].Cells["ecdvColumn"].Value = card.code;
            dgCards.Rows[dgCards.SelectedCells[0].RowIndex].Cells["CharacterColumn"].Value = card.character;
            Visible = true;
        }

        private async void bNewVersion_Click(object sender, EventArgs e)
        {
            Card card = await DataBaseService.getCard(selectedCard.id);
            card.version = 0;
            card.description = string.Empty;
            Visible = false;
            CardForm cardForm = new CardForm(card);
            cardForm.ShowDialog();            
            if (card.version != 0)
            {
                int index = cards.IndexOf(selectedCardFinalVS);
                selectedCardFinalVS.copyFrom(card);                
                UpdateDGCards();
                dgCards.Rows[index].Selected = true;
            }
            Visible = true;
        }

        private async void bArchive_Click(object sender, EventArgs e)
        {            
            if (MessageBox.Show(isActualCardsMode ? ConstStorage.PUT_IN_ARCHIVE : ConstStorage.RESTORE_CARD,
                                isActualCardsMode ? ConstStorage.CARD_PUTTING_IN_ARCHIVE : ConstStorage.CARD_RESTORING,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }                        
            CardMainInfo archiveCard = isActualCardsMode ? null
                                                         : await DataBaseService.getCard(selectedCard.number, 0);
            GeneralResponse<object> response = isActualCardsMode ? DataBaseService.putInArchive(selectedCard)
                                                                 : DataBaseService.deleteCard(archiveCard);
            if (response.isResultOK)
            {                
                dgCards.Enabled = false;
                cards.Remove(selectedCardFinalVS);
                dgCards.Rows.RemoveAt(dgCards.SelectedRows[0].Index);                
                dgCards.Enabled = true;
                dgCards.ClearSelection();                                
                MessageBox.Show(response.message, isActualCardsMode ? ConstStorage.CARD_PUTTING_IN_ARCHIVE : ConstStorage.CARD_RESTORING,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(ConstStorage.UPDATE_ERROR + Environment.NewLine + response.message,
                                isActualCardsMode ? ConstStorage.CARD_PUTTING_IN_ARCHIVE : ConstStorage.CARD_RESTORING,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private async void bCopyCard_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(ConstStorage.CREATE_CARD, ConstStorage.CARD_CREATION,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            Card card = await DataBaseService.getCard(selectedCard.id);
            card.id = null;
            card.version = 0;
            card.number = 0;
            card.description = ConstStorage.CARD_CREATION;
            Visible = false;
            CardForm cardForm = new CardForm(card);
            cardForm.ShowDialog();            
            if(card.id != null)
            {
                if (dgCards.Columns[1].Visible)
                {
                    bResetFilter_Click(sender, new EventArgs());
                }
                else
                {
                    cards.Insert(0, CardShortInfo.getFrom(card));
                    dgCards.Rows.Insert(0, card.id, 0, card.GetDesignation(), card.character, card.name, card.code);
                    dgCards.ClearSelection();
                    dgCards.Rows[0].Selected = true;
                }                
            }
            Visible = true;
        }

        private void UpdateDGCardInfo()
        {            
            gbCardInfo.Text = $"Параметры гаммы № {selectedCard?.number:000000}";
            dgCardInfo.Rows[0].Cells[1].Value = selectedCard != null ? ConstStorage.CARD_TYPES.First(c => c.StartsWith(selectedCard.cardType)) : string.Empty;
            dgCardInfo.Rows[1].Cells[1].Value = selectedCard != null ? ConstStorage.PROJECTS.First(p => p.StartsWith(selectedCard.project)) : string.Empty;
            dgCardInfo.Rows[2].Cells[1].Value = selectedCard?.number.ToString("000000");            
            dgCardInfo.Rows[3].Cells[1].Value = selectedCard?.name;
            dgCardInfo.Rows[4].Cells[1].Value = selectedCard?.code;
            dgCardInfo.Rows[5].Cells[1].Value = selectedCard?.controlPlan;
            dgCardInfo.Rows[6].Cells[1].Value = ConstStorage.CARD_CHARACTERS?.FirstOrDefault(p => p.StartsWith(selectedCard?.character ?? " "));
            dgCardInfo.Rows[7].Cells[1].Value = selectedCard?.screwing == null ? null
                : $"{selectedCard.screwing.torque} \u00B1 {selectedCard.screwing.torqueTolerance} Нм";
            dgCardInfo.Rows[8].Cells[1].Value = selectedCard?.screwingTool;
            dgCardInfo.Rows[9].Cells[1].Value = selectedCard?.creator?.name;
            dgCardInfo.Rows[10].Cells[1].Value = selectedCard?.creationTime.ToLocalTime();
            dgCardInfo.Rows[11].Cells[1].Value = selectedCard?.updateTime.ToLocalTime();
            Pitch pitch = Pitch.GetPitch(selectedCard?.pitchId);
            dgCardInfo.Rows[12].Cells[1].Value = selectedCard != null ? pitch.number : string.Empty;
            udPosition.Maximum = udPosition.Enabled && cards.Count > 0 ? cards.Count : 1000;
            udPosition.Value = Convert.ToDecimal(selectedCard?.position ?? 1);
            cbCardPitch.SelectedItem = pitch;
        }

        private async void bExcel_Click(object sender, EventArgs e)
        {
            Card card = await DataBaseService.getCard(selectedCard.id);            
            ExtractionService.show(card);
        }        

        private void bPutPitch_Click(object sender, EventArgs e)
        {
            Pitch newPitch = cbCardPitch.SelectedItem as Pitch;
            if (MessageBox.Show(string.Format(newPitch == null ? ConstStorage.DELETE_PITCH : ConstStorage.PUT_PITCH, newPitch?.number),
                ConstStorage.PITCH_PUTTING, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            GeneralResponse<int> response = DataBaseService.putPitch(selectedCard.id ?? 0, newPitch?.id ?? 0);
            if (response.isResultOK)
            {                
                selectedCard.pitchId = newPitch?.id;
                if (dgCards.Columns[1].Visible) // просмотр гамм поста в хронологическом порядке
                {                    
                    dgCards.Enabled = false;
                    cards.Remove(selectedCardFinalVS);
                    dgCards.Rows.Remove(dgCards.SelectedRows[0]);
                    dgCards.Enabled = true;
                    dgCards.ClearSelection();                    
                }
                else
                {
                    dgCardInfo.Rows[12].Cells[1].Value = Pitch.GetPitch(selectedCard.pitchId).number;
                    udPosition.Value = Convert.ToDecimal(response.data);
                }                
                MessageBox.Show(response.message, ConstStorage.PITCH_PUTTING, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(ConstStorage.UPDATE_ERROR + Environment.NewLine + response.message, ConstStorage.PITCH_PUTTING, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void bPosition_Click(object sender, EventArgs e)
        {
            GeneralResponse<object> response = DataBaseService.setPosition(selectedCard.id ?? 0, udPosition.Value);
            if (response.isResultOK)
            {
                int newPosition = Convert.ToInt32(udPosition.Value);                
                
                if (dgCards.Columns[1].Visible) // просмотр гамм поста в хронологическом порядке
                {
                    cards.Remove(selectedCardFinalVS);
                    cards.Insert(newPosition - 1, selectedCardFinalVS);
                    UpdateDGCards();
                    dgCards.Rows[newPosition - 1].Selected = true;
                }                         
                
                MessageBox.Show(response.message, ConstStorage.PITCH_PUTTING, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(ConstStorage.UPDATE_ERROR + Environment.NewLine + response.message, ConstStorage.PITCH_PUTTING, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void cbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCard = await DataBaseService.getCard(selectedCardFinalVS.number, (int)cbVersion.SelectedItem);
            bool isArchiveVersion = cbVersion.SelectedItem?.Equals(0) ?? false;
            bEdit.Enabled = cbVersion.SelectedIndex == 0;
            bExcel.Enabled = !isArchiveVersion;
            bCopyCard.Enabled = !isArchiveVersion;
            dgCardInfo.Rows[10].Cells[0].Value = isArchiveVersion ? "Дата закрытия" : "Дата создания";
            dgCardInfo.Rows[11].Visible = !isArchiveVersion;
            UpdateDGCardInfo();
        }        

        private async void bDescription_Click(object sender, EventArgs e)
        {
            CardDescription.cardDescriptions = await DataBaseService.getCardDescription(selectedCard);
            CardDescriptionForm cardDescriptionForm = new CardDescriptionForm(selectedCard);
            cardDescriptionForm.ShowDialog();
        }

        private async void bMovements_Click(object sender, EventArgs e)
        {
            CardMovement.cardMovements = await DataBaseService.getAllCardMovements(selectedCard);
            CardMovementForm cardMovementForm = new CardMovementForm(selectedCard);
            cardMovementForm.ShowDialog();
        }

        #endregion

        #region Функции        

        private void bCreateCard_Click(object sender, EventArgs e)
        {
            Visible = false;
            CardForm cardForm = new CardForm();
            cardForm.ShowDialog();
            FindCards();
            Visible = true;
        }

        private void bEditParts_Click(object sender, EventArgs e)
        {
            Part.parts = Task.Run(() => DataBaseService.getPartList()).Result;
            PartForm partForm = new PartForm();
            partForm.ShowDialog();
        }

        private void bEditTools_Click(object sender, EventArgs e)
        {
            Tool.tools = Task.Run(() => DataBaseService.getToolList()).Result;
            ToolForm toolForm = new ToolForm();
            toolForm.ShowDialog();
        }

        private void bEditPitches_Click(object sender, EventArgs e)
        {
            Pitch.pitches = Task.Run(() => DataBaseService.getPitchList()).Result.OrderBy(p => p.number).ToList();            
            PitchForm pitchForm = new PitchForm();
            pitchForm.ShowDialog();
            Pitch.pitches.Insert(0, new Pitch(ConstStorage.NO_PITCH));
            GeneralService.FilterComboBoxItems(cbCardPitch, Pitch.pitches);
            GeneralService.FilterComboBoxItems(cbPitch, Pitch.pitches);
        }
        
        private async void bScrewingTools_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ScrewingToolForm"] as ScrewingToolForm != null)
            {
                Application.OpenForms["ScrewingToolForm"].WindowState = FormWindowState.Normal;
                Application.OpenForms["ScrewingToolForm"].Activate();                
                return;
            }
            ScrewingToolType.types = await DataBaseService.getScrewingToolTypeList();
            ScrewingTool.statuses = await DataBaseService.getStringConstList(ConstStorage.SCREWING_TOOL_STATUS);
            ScrewingTool.statuses.Insert(0, new StringConst());            
            ScrewingTool.screwingTools = await DataBaseService.getScrewingToolList();
            CardWithScrewing.cards = await DataBaseService.getCardsWithScrewing();
            ScrewingToolForm screwingToolForm = new ScrewingToolForm();
            screwingToolForm.Show();
        }

        private async void bToolCheck_Click(object sender, EventArgs e)
        {
            Campaign.campaigns = await DataBaseService.getCampaignList();
            Campaign.campaigns.ForEach(c => c.setDetails());
            ConstStorage.SECTORS = await DataBaseService.getConstants(ConstStorage.SECTOR);
            ConstStorage.BLM_LIST = (await DataBaseService.getConstants(ConstStorage.BLM))
                .Select(b => int.Parse(b))
                .ToArray();            
            CampaignForm screwingToolCheckForm = new CampaignForm();
            screwingToolCheckForm.ShowDialog();
        }

        private async void bLoadFromDB_Click(object sender, EventArgs e)
        {
            await loadDataFromDB();
            bResetFilter_Click(sender, e);
            MessageBox.Show(ConstStorage.UPDATED, ConstStorage.UPDATE, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async Task<bool> loadDataFromDB()
        {
            isFilterActive = false;            

            cbCardType_DropDown(cbCardType, EventArgs.Empty);

            cbProject_DropDown(cbProject, EventArgs.Empty);

            cbCharacter_DropDown(cbCharacter, EventArgs.Empty);

            cbUsers_DropDown(cbUsers, EventArgs.Empty);

            usedParts = await DataBaseService.getPartsFromCards();
            GeneralService.FilterComboBoxItems(cbPart, usedParts);

            Pitch.pitches = (await DataBaseService.getPitchList()).OrderBy(p => p.number).ToList();
            Pitch.pitches.Insert(0, new Pitch(ConstStorage.NO_PITCH));
            GeneralService.FilterComboBoxItems(cbCardPitch, Pitch.pitches);
            GeneralService.FilterComboBoxItems(cbPitch, Pitch.pitches);

            isFilterActive = true;
            return DataBaseService.isDataBaseConnected;
        }

        private async void bPrint_Click(object sender, EventArgs e)
        {
            if (dgCards.SelectedRows.Count > 50)
            {
                MessageBox.Show(string.Format(ConstStorage.TOO_MANY_CARDS, dgCards.SelectedRows.Count),
                ConstStorage.CARDS_PRINTING, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (MessageBox.Show(string.Format(ConstStorage.PRINT_CARDS, dgCards.SelectedRows.Count),
                ConstStorage.CARDS_PRINTING, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            List<Card> cards = new List<Card>();
            foreach (DataGridViewRow row in dgCards.SelectedRows)
            {
                long cardId = long.Parse(row.Cells["cardIdColumn"].Value.ToString());
                Card cardToPrint = await DataBaseService.getCard(cardId);
                cards.Add(cardToPrint);
            }
            if (DialogResult.OK != printDialog.ShowDialog())
            {
                return;
            }
            ExtractionService.printCard(cards, printDialog.PrinterSettings.PrinterName, progressBar);
            MessageBox.Show(ConstStorage.CARDS_PRINTED, ConstStorage.CARDS_PRINTING, MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar.Value = 0;
        }
        
        private void bTest_Click(object sender, EventArgs e)
        {
            Pitch pitch = new Pitch();
            pitch.CopyFrom(Pitch.pitches[1]);
            tbName.Text = Pitch.pitches[1].number + " " + Pitch.pitches[1].number.GetHashCode();
            tbControlPlan.Text = "2HC1 A01A".GetHashCode() + ("2HC1 A01A" == Pitch.pitches[1].number).ToString();
        }

        #endregion
        
    }
}
