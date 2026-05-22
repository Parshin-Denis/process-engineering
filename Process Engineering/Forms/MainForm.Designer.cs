namespace Process_Engineering.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgCards = new System.Windows.Forms.DataGridView();
            this.cardIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardPosColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharacterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ecdvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLogIn = new System.Windows.Forms.Button();
            this.lUser = new System.Windows.Forms.Label();
            this.bCreateCard = new System.Windows.Forms.Button();
            this.bChangePassword = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.dgCardInfo = new System.Windows.Forms.DataGridView();
            this.parameterNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardFieldColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCards = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.gbCardInfo = new System.Windows.Forms.GroupBox();
            this.bMovements = new System.Windows.Forms.Button();
            this.bDescription = new System.Windows.Forms.Button();
            this.bArchive = new System.Windows.Forms.Button();
            this.lVersion = new System.Windows.Forms.Label();
            this.cbVersion = new System.Windows.Forms.ComboBox();
            this.bNewVersion = new System.Windows.Forms.Button();
            this.lPosition = new System.Windows.Forms.Label();
            this.lPitchNumber = new System.Windows.Forms.Label();
            this.bPosition = new System.Windows.Forms.Button();
            this.udPosition = new System.Windows.Forms.NumericUpDown();
            this.bPutPitch = new System.Windows.Forms.Button();
            this.bTest = new System.Windows.Forms.Button();
            this.bExcel = new System.Windows.Forms.Button();
            this.cbCardPitch = new System.Windows.Forms.ComboBox();
            this.bCopyCard = new System.Windows.Forms.Button();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.lControlPlan = new System.Windows.Forms.Label();
            this.tbControlPlan = new System.Windows.Forms.TextBox();
            this.tbCardNumber = new System.Windows.Forms.TextBox();
            this.lCreatorFilter = new System.Windows.Forms.Label();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.lCount = new System.Windows.Forms.Label();
            this.bChrono = new System.Windows.Forms.Button();
            this.cbCharacter = new System.Windows.Forms.ComboBox();
            this.cbPitch = new System.Windows.Forms.ComboBox();
            this.bFind = new System.Windows.Forms.Button();
            this.lName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lPitch = new System.Windows.Forms.Label();
            this.lCharacter = new System.Windows.Forms.Label();
            this.lPart = new System.Windows.Forms.Label();
            this.bResetFilter = new System.Windows.Forms.Button();
            this.lCardNumber = new System.Windows.Forms.Label();
            this.lCardType = new System.Windows.Forms.Label();
            this.lProject = new System.Windows.Forms.Label();
            this.cbCardType = new System.Windows.Forms.ComboBox();
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.cbPart = new System.Windows.Forms.ComboBox();
            this.bPrint = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.gbManagement = new System.Windows.Forms.GroupBox();
            this.gbFunctions = new System.Windows.Forms.GroupBox();
            this.bLoadFromDB = new System.Windows.Forms.Button();
            this.bEditPitches = new System.Windows.Forms.Button();
            this.bToolCheck = new System.Windows.Forms.Button();
            this.bScrewingTools = new System.Windows.Forms.Button();
            this.bEditTools = new System.Windows.Forms.Button();
            this.bEditParts = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCardInfo)).BeginInit();
            this.gbCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.gbCardInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udPosition)).BeginInit();
            this.gbFilter.SuspendLayout();
            this.gbUser.SuspendLayout();
            this.gbManagement.SuspendLayout();
            this.gbFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgCards
            // 
            this.dgCards.AllowUserToAddRows = false;
            this.dgCards.AllowUserToDeleteRows = false;
            this.dgCards.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgCards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardIdColumn,
            this.cardPosColumn,
            this.cardNumberColumn,
            this.CharacterColumn,
            this.cardNameColumn,
            this.ecdvColumn});
            this.dgCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCards.EnableHeadersVisualStyles = false;
            this.dgCards.Location = new System.Drawing.Point(3, 164);
            this.dgCards.Name = "dgCards";
            this.dgCards.ReadOnly = true;
            this.dgCards.RowHeadersVisible = false;
            this.dgCards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCards.Size = new System.Drawing.Size(636, 444);
            this.dgCards.TabIndex = 0;
            this.dgCards.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCards_CellDoubleClick);
            this.dgCards.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgCards_Scroll);
            this.dgCards.SelectionChanged += new System.EventHandler(this.dgCards_SelectionChanged);
            this.dgCards.SizeChanged += new System.EventHandler(this.dgCards_SizeChanged);
            // 
            // cardIdColumn
            // 
            this.cardIdColumn.HeaderText = "ID";
            this.cardIdColumn.Name = "cardIdColumn";
            this.cardIdColumn.ReadOnly = true;
            this.cardIdColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cardIdColumn.Visible = false;
            // 
            // cardPosColumn
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cardPosColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.cardPosColumn.HeaderText = "Поз.";
            this.cardPosColumn.Name = "cardPosColumn";
            this.cardPosColumn.ReadOnly = true;
            this.cardPosColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cardPosColumn.Visible = false;
            this.cardPosColumn.Width = 30;
            // 
            // cardNumberColumn
            // 
            this.cardNumberColumn.HeaderText = "Номер";
            this.cardNumberColumn.Name = "cardNumberColumn";
            this.cardNumberColumn.ReadOnly = true;
            this.cardNumberColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cardNumberColumn.Width = 70;
            // 
            // CharacterColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.CharacterColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.CharacterColumn.HeaderText = "Хар.";
            this.CharacterColumn.Name = "CharacterColumn";
            this.CharacterColumn.ReadOnly = true;
            this.CharacterColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CharacterColumn.Width = 30;
            // 
            // cardNameColumn
            // 
            this.cardNameColumn.HeaderText = "Название";
            this.cardNameColumn.Name = "cardNameColumn";
            this.cardNameColumn.ReadOnly = true;
            this.cardNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cardNameColumn.Width = 295;
            // 
            // ecdvColumn
            // 
            this.ecdvColumn.HeaderText = "ECDV";
            this.ecdvColumn.Name = "ecdvColumn";
            this.ecdvColumn.ReadOnly = true;
            this.ecdvColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ecdvColumn.Width = 80;
            // 
            // bLogIn
            // 
            this.bLogIn.BackgroundImage = global::Process_Engineering.Properties.Resources.login;
            this.bLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bLogIn.Location = new System.Drawing.Point(6, 17);
            this.bLogIn.Name = "bLogIn";
            this.bLogIn.Size = new System.Drawing.Size(45, 45);
            this.bLogIn.TabIndex = 1;
            this.toolTip.SetToolTip(this.bLogIn, "Вход");
            this.bLogIn.UseVisualStyleBackColor = true;
            this.bLogIn.Click += new System.EventHandler(this.bLogIn_Click);
            // 
            // lUser
            // 
            this.lUser.Location = new System.Drawing.Point(6, 64);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(130, 28);
            this.lUser.TabIndex = 2;
            this.lUser.Text = "Неизвестный пользователь";
            this.lUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lUser.DoubleClick += new System.EventHandler(this.lUser_DoubleClick);
            // 
            // bCreateCard
            // 
            this.bCreateCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bCreateCard.Enabled = false;
            this.bCreateCard.Image = ((System.Drawing.Image)(resources.GetObject("bCreateCard.Image")));
            this.bCreateCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCreateCard.Location = new System.Drawing.Point(6, 19);
            this.bCreateCard.Name = "bCreateCard";
            this.bCreateCard.Size = new System.Drawing.Size(130, 50);
            this.bCreateCard.TabIndex = 3;
            this.bCreateCard.Text = "Создать\r\nгамму";
            this.bCreateCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.bCreateCard, "Создать гамму");
            this.bCreateCard.UseVisualStyleBackColor = true;
            this.bCreateCard.Click += new System.EventHandler(this.bCreateCard_Click);
            // 
            // bChangePassword
            // 
            this.bChangePassword.BackgroundImage = global::Process_Engineering.Properties.Resources.password;
            this.bChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bChangePassword.Location = new System.Drawing.Point(91, 16);
            this.bChangePassword.Name = "bChangePassword";
            this.bChangePassword.Size = new System.Drawing.Size(45, 45);
            this.bChangePassword.TabIndex = 4;
            this.toolTip.SetToolTip(this.bChangePassword, "Сменить пароль");
            this.bChangePassword.UseVisualStyleBackColor = true;
            this.bChangePassword.Visible = false;
            this.bChangePassword.Click += new System.EventHandler(this.bChangePassword_Click);
            // 
            // bEdit
            // 
            this.bEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bEdit.BackgroundImage")));
            this.bEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bEdit.Location = new System.Drawing.Point(62, 438);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(50, 50);
            this.bEdit.TabIndex = 5;
            this.toolTip.SetToolTip(this.bEdit, "Редактировать");
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Visible = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // dgCardInfo
            // 
            this.dgCardInfo.AllowUserToAddRows = false;
            this.dgCardInfo.AllowUserToDeleteRows = false;
            this.dgCardInfo.AllowUserToResizeColumns = false;
            this.dgCardInfo.AllowUserToResizeRows = false;
            this.dgCardInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgCardInfo.ColumnHeadersVisible = false;
            this.dgCardInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parameterNameColumn,
            this.cardFieldColumn});
            this.dgCardInfo.EnableHeadersVisualStyles = false;
            this.dgCardInfo.Location = new System.Drawing.Point(6, 48);
            this.dgCardInfo.Name = "dgCardInfo";
            this.dgCardInfo.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCardInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgCardInfo.RowHeadersVisible = false;
            this.dgCardInfo.RowHeadersWidth = 120;
            this.dgCardInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCardInfo.Size = new System.Drawing.Size(285, 309);
            this.dgCardInfo.TabIndex = 6;
            // 
            // parameterNameColumn
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.parameterNameColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.parameterNameColumn.HeaderText = "Параметр";
            this.parameterNameColumn.Name = "parameterNameColumn";
            this.parameterNameColumn.ReadOnly = true;
            // 
            // cardFieldColumn
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cardFieldColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.cardFieldColumn.HeaderText = "Значение";
            this.cardFieldColumn.Name = "cardFieldColumn";
            this.cardFieldColumn.ReadOnly = true;
            this.cardFieldColumn.Width = 182;
            // 
            // gbCards
            // 
            this.gbCards.Controls.Add(this.dgCards);
            this.gbCards.Controls.Add(this.pictureBox);
            this.gbCards.Controls.Add(this.gbCardInfo);
            this.gbCards.Controls.Add(this.gbFilter);
            this.gbCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCards.Location = new System.Drawing.Point(0, 0);
            this.gbCards.Name = "gbCards";
            this.gbCards.Size = new System.Drawing.Size(936, 611);
            this.gbCards.TabIndex = 7;
            this.gbCards.TabStop = false;
            this.gbCards.Text = "Гаммы";
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(3, 114);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(636, 50);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // gbCardInfo
            // 
            this.gbCardInfo.Controls.Add(this.bMovements);
            this.gbCardInfo.Controls.Add(this.bDescription);
            this.gbCardInfo.Controls.Add(this.bArchive);
            this.gbCardInfo.Controls.Add(this.lVersion);
            this.gbCardInfo.Controls.Add(this.cbVersion);
            this.gbCardInfo.Controls.Add(this.bNewVersion);
            this.gbCardInfo.Controls.Add(this.lPosition);
            this.gbCardInfo.Controls.Add(this.lPitchNumber);
            this.gbCardInfo.Controls.Add(this.bPosition);
            this.gbCardInfo.Controls.Add(this.udPosition);
            this.gbCardInfo.Controls.Add(this.bPutPitch);
            this.gbCardInfo.Controls.Add(this.bTest);
            this.gbCardInfo.Controls.Add(this.bExcel);
            this.gbCardInfo.Controls.Add(this.cbCardPitch);
            this.gbCardInfo.Controls.Add(this.dgCardInfo);
            this.gbCardInfo.Controls.Add(this.bCopyCard);
            this.gbCardInfo.Controls.Add(this.bEdit);
            this.gbCardInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbCardInfo.Location = new System.Drawing.Point(639, 114);
            this.gbCardInfo.Name = "gbCardInfo";
            this.gbCardInfo.Size = new System.Drawing.Size(294, 494);
            this.gbCardInfo.TabIndex = 8;
            this.gbCardInfo.TabStop = false;
            this.gbCardInfo.Text = " Информация о гамме";
            // 
            // bMovements
            // 
            this.bMovements.Location = new System.Drawing.Point(190, 19);
            this.bMovements.Name = "bMovements";
            this.bMovements.Size = new System.Drawing.Size(98, 23);
            this.bMovements.TabIndex = 19;
            this.bMovements.Text = "Перемещения";
            this.bMovements.UseVisualStyleBackColor = true;
            this.bMovements.Click += new System.EventHandler(this.bMovements_Click);
            // 
            // bDescription
            // 
            this.bDescription.Location = new System.Drawing.Point(102, 19);
            this.bDescription.Name = "bDescription";
            this.bDescription.Size = new System.Drawing.Size(82, 23);
            this.bDescription.TabIndex = 18;
            this.bDescription.Text = "Изменения";
            this.bDescription.UseVisualStyleBackColor = true;
            this.bDescription.Click += new System.EventHandler(this.bDescription_Click);
            // 
            // bArchive
            // 
            this.bArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bArchive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bArchive.BackgroundImage")));
            this.bArchive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bArchive.Location = new System.Drawing.Point(174, 438);
            this.bArchive.Name = "bArchive";
            this.bArchive.Size = new System.Drawing.Size(50, 50);
            this.bArchive.TabIndex = 17;
            this.toolTip.SetToolTip(this.bArchive, "Удалить");
            this.bArchive.UseVisualStyleBackColor = true;
            this.bArchive.Visible = false;
            this.bArchive.Click += new System.EventHandler(this.bArchive_Click);
            // 
            // lVersion
            // 
            this.lVersion.AutoSize = true;
            this.lVersion.Location = new System.Drawing.Point(6, 24);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(44, 13);
            this.lVersion.TabIndex = 16;
            this.lVersion.Text = "Версия";
            // 
            // cbVersion
            // 
            this.cbVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVersion.FormattingEnabled = true;
            this.cbVersion.Location = new System.Drawing.Point(56, 21);
            this.cbVersion.Name = "cbVersion";
            this.cbVersion.Size = new System.Drawing.Size(40, 21);
            this.cbVersion.TabIndex = 15;
            this.cbVersion.SelectedIndexChanged += new System.EventHandler(this.cbVersion_SelectedIndexChanged);
            // 
            // bNewVersion
            // 
            this.bNewVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bNewVersion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bNewVersion.BackgroundImage")));
            this.bNewVersion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bNewVersion.Location = new System.Drawing.Point(118, 438);
            this.bNewVersion.Name = "bNewVersion";
            this.bNewVersion.Size = new System.Drawing.Size(50, 50);
            this.bNewVersion.TabIndex = 14;
            this.toolTip.SetToolTip(this.bNewVersion, "Создать новую версию");
            this.bNewVersion.UseVisualStyleBackColor = true;
            this.bNewVersion.Visible = false;
            this.bNewVersion.Click += new System.EventHandler(this.bNewVersion_Click);
            // 
            // lPosition
            // 
            this.lPosition.AutoSize = true;
            this.lPosition.Location = new System.Drawing.Point(225, 368);
            this.lPosition.Name = "lPosition";
            this.lPosition.Size = new System.Drawing.Size(63, 13);
            this.lPosition.TabIndex = 13;
            this.lPosition.Text = "№ позиции";
            this.lPosition.Visible = false;
            // 
            // lPitchNumber
            // 
            this.lPitchNumber.AutoSize = true;
            this.lPitchNumber.Location = new System.Drawing.Point(83, 368);
            this.lPitchNumber.Name = "lPitchNumber";
            this.lPitchNumber.Size = new System.Drawing.Size(50, 13);
            this.lPitchNumber.TabIndex = 12;
            this.lPitchNumber.Text = "№ поста";
            this.lPitchNumber.Visible = false;
            // 
            // bPosition
            // 
            this.bPosition.BackgroundImage = global::Process_Engineering.Properties.Resources.move;
            this.bPosition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPosition.Enabled = false;
            this.bPosition.Location = new System.Drawing.Point(169, 363);
            this.bPosition.Name = "bPosition";
            this.bPosition.Size = new System.Drawing.Size(50, 50);
            this.bPosition.TabIndex = 11;
            this.toolTip.SetToolTip(this.bPosition, "Перенести в позицию");
            this.bPosition.UseVisualStyleBackColor = true;
            this.bPosition.Visible = false;
            this.bPosition.Click += new System.EventHandler(this.bPosition_Click);
            // 
            // udPosition
            // 
            this.udPosition.Enabled = false;
            this.udPosition.Location = new System.Drawing.Point(238, 392);
            this.udPosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPosition.Name = "udPosition";
            this.udPosition.Size = new System.Drawing.Size(40, 20);
            this.udPosition.TabIndex = 10;
            this.udPosition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPosition.Visible = false;
            // 
            // bPutPitch
            // 
            this.bPutPitch.BackgroundImage = global::Process_Engineering.Properties.Resources.transfer;
            this.bPutPitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPutPitch.Location = new System.Drawing.Point(6, 363);
            this.bPutPitch.Name = "bPutPitch";
            this.bPutPitch.Size = new System.Drawing.Size(50, 50);
            this.bPutPitch.TabIndex = 9;
            this.toolTip.SetToolTip(this.bPutPitch, "Разместить на посту");
            this.bPutPitch.UseVisualStyleBackColor = true;
            this.bPutPitch.Visible = false;
            this.bPutPitch.Click += new System.EventHandler(this.bPutPitch_Click);
            // 
            // bTest
            // 
            this.bTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bTest.Location = new System.Drawing.Point(9, 413);
            this.bTest.Name = "bTest";
            this.bTest.Size = new System.Drawing.Size(279, 25);
            this.bTest.TabIndex = 4;
            this.bTest.Text = "Тест";
            this.bTest.UseVisualStyleBackColor = true;
            this.bTest.Visible = false;
            this.bTest.Click += new System.EventHandler(this.bTest_Click);
            // 
            // bExcel
            // 
            this.bExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bExcel.BackgroundImage")));
            this.bExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bExcel.Location = new System.Drawing.Point(6, 438);
            this.bExcel.Name = "bExcel";
            this.bExcel.Size = new System.Drawing.Size(50, 50);
            this.bExcel.TabIndex = 11;
            this.toolTip.SetToolTip(this.bExcel, "Открыть в EXCEL");
            this.bExcel.UseVisualStyleBackColor = true;
            this.bExcel.Click += new System.EventHandler(this.bExcel_Click);
            // 
            // cbCardPitch
            // 
            this.cbCardPitch.FormattingEnabled = true;
            this.cbCardPitch.Location = new System.Drawing.Point(62, 391);
            this.cbCardPitch.Name = "cbCardPitch";
            this.cbCardPitch.Size = new System.Drawing.Size(101, 21);
            this.cbCardPitch.TabIndex = 8;
            this.cbCardPitch.Visible = false;
            this.cbCardPitch.TextChanged += new System.EventHandler(this.cbPitch_TextChanged);
            // 
            // bCopyCard
            // 
            this.bCopyCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bCopyCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bCopyCard.BackgroundImage")));
            this.bCopyCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bCopyCard.Location = new System.Drawing.Point(238, 438);
            this.bCopyCard.Name = "bCopyCard";
            this.bCopyCard.Size = new System.Drawing.Size(50, 50);
            this.bCopyCard.TabIndex = 5;
            this.toolTip.SetToolTip(this.bCopyCard, "Создать новую гамму копированием");
            this.bCopyCard.UseVisualStyleBackColor = true;
            this.bCopyCard.Visible = false;
            this.bCopyCard.Click += new System.EventHandler(this.bCopyCard_Click);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.lControlPlan);
            this.gbFilter.Controls.Add(this.tbControlPlan);
            this.gbFilter.Controls.Add(this.tbCardNumber);
            this.gbFilter.Controls.Add(this.lCreatorFilter);
            this.gbFilter.Controls.Add(this.cbUsers);
            this.gbFilter.Controls.Add(this.lCount);
            this.gbFilter.Controls.Add(this.bChrono);
            this.gbFilter.Controls.Add(this.cbCharacter);
            this.gbFilter.Controls.Add(this.cbPitch);
            this.gbFilter.Controls.Add(this.bFind);
            this.gbFilter.Controls.Add(this.lName);
            this.gbFilter.Controls.Add(this.tbName);
            this.gbFilter.Controls.Add(this.lPitch);
            this.gbFilter.Controls.Add(this.lCharacter);
            this.gbFilter.Controls.Add(this.lPart);
            this.gbFilter.Controls.Add(this.bResetFilter);
            this.gbFilter.Controls.Add(this.lCardNumber);
            this.gbFilter.Controls.Add(this.lCardType);
            this.gbFilter.Controls.Add(this.lProject);
            this.gbFilter.Controls.Add(this.cbCardType);
            this.gbFilter.Controls.Add(this.cbProject);
            this.gbFilter.Controls.Add(this.cbPart);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFilter.Location = new System.Drawing.Point(3, 16);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(930, 98);
            this.gbFilter.TabIndex = 5;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Фильтр";
            // 
            // lControlPlan
            // 
            this.lControlPlan.AutoSize = true;
            this.lControlPlan.Location = new System.Drawing.Point(437, 40);
            this.lControlPlan.Name = "lControlPlan";
            this.lControlPlan.Size = new System.Drawing.Size(90, 26);
            this.lControlPlan.TabIndex = 18;
            this.lControlPlan.Text = "№ Контр плана\r\nПрименяемость";
            this.lControlPlan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbControlPlan
            // 
            this.tbControlPlan.Location = new System.Drawing.Point(533, 43);
            this.tbControlPlan.Name = "tbControlPlan";
            this.tbControlPlan.Size = new System.Drawing.Size(145, 20);
            this.tbControlPlan.TabIndex = 17;
            this.tbControlPlan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.Location = new System.Drawing.Point(59, 70);
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.Size = new System.Drawing.Size(92, 20);
            this.tbCardNumber.TabIndex = 16;
            this.tbCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // lCreatorFilter
            // 
            this.lCreatorFilter.AutoSize = true;
            this.lCreatorFilter.Location = new System.Drawing.Point(185, 44);
            this.lCreatorFilter.Name = "lCreatorFilter";
            this.lCreatorFilter.Size = new System.Drawing.Size(37, 13);
            this.lCreatorFilter.TabIndex = 15;
            this.lCreatorFilter.Text = "Автор";
            // 
            // cbUsers
            // 
            this.cbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(226, 41);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(192, 21);
            this.cbUsers.TabIndex = 14;
            this.cbUsers.DropDown += new System.EventHandler(this.cbUsers_DropDown);
            this.cbUsers.SelectedIndexChanged += new System.EventHandler(this.FilterCardParameterChanged);
            // 
            // lCount
            // 
            this.lCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lCount.Location = new System.Drawing.Point(820, 74);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(104, 18);
            this.lCount.TabIndex = 9;
            this.lCount.Text = "Найдено: 0 шт.";
            this.lCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bChrono
            // 
            this.bChrono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bChrono.BackgroundImage")));
            this.bChrono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bChrono.Enabled = false;
            this.bChrono.Location = new System.Drawing.Point(759, 23);
            this.bChrono.Name = "bChrono";
            this.bChrono.Size = new System.Drawing.Size(40, 40);
            this.bChrono.TabIndex = 11;
            this.toolTip.SetToolTip(this.bChrono, "Хронология поста в EXCEL");
            this.bChrono.UseVisualStyleBackColor = true;
            this.bChrono.Click += new System.EventHandler(this.bChrono_Click);
            // 
            // cbCharacter
            // 
            this.cbCharacter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCharacter.FormattingEnabled = true;
            this.cbCharacter.Location = new System.Drawing.Point(533, 17);
            this.cbCharacter.Name = "cbCharacter";
            this.cbCharacter.Size = new System.Drawing.Size(144, 21);
            this.cbCharacter.TabIndex = 10;
            this.cbCharacter.DropDown += new System.EventHandler(this.cbCharacter_DropDown);
            this.cbCharacter.SelectedIndexChanged += new System.EventHandler(this.FilterCardParameterChanged);
            // 
            // cbPitch
            // 
            this.cbPitch.FormattingEnabled = true;
            this.cbPitch.Location = new System.Drawing.Point(685, 67);
            this.cbPitch.Name = "cbPitch";
            this.cbPitch.Size = new System.Drawing.Size(114, 21);
            this.cbPitch.TabIndex = 9;
            this.cbPitch.SelectedIndexChanged += new System.EventHandler(this.FilterCardParameterChanged);
            this.cbPitch.TextChanged += new System.EventHandler(this.cbPitch_TextChanged);
            // 
            // bFind
            // 
            this.bFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bFind.BackgroundImage = global::Process_Engineering.Properties.Resources.find;
            this.bFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bFind.Location = new System.Drawing.Point(818, 15);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(50, 50);
            this.bFind.TabIndex = 7;
            this.toolTip.SetToolTip(this.bFind, "Поиск");
            this.bFind.UseVisualStyleBackColor = true;
            this.bFind.Click += new System.EventHandler(this.FilterCardParameterChanged);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(163, 19);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(57, 13);
            this.lName.TabIndex = 6;
            this.lName.Text = "Название";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(226, 15);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(192, 20);
            this.tbName.TabIndex = 5;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // lPitch
            // 
            this.lPitch.AutoSize = true;
            this.lPitch.Location = new System.Drawing.Point(686, 36);
            this.lPitch.Name = "lPitch";
            this.lPitch.Size = new System.Drawing.Size(67, 26);
            this.lPitch.TabIndex = 2;
            this.lPitch.Text = "Пост\r\nХронология";
            this.lPitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lCharacter
            // 
            this.lCharacter.AutoSize = true;
            this.lCharacter.Location = new System.Drawing.Point(437, 20);
            this.lCharacter.Name = "lCharacter";
            this.lCharacter.Size = new System.Drawing.Size(90, 13);
            this.lCharacter.TabIndex = 2;
            this.lCharacter.Text = "Характеристика";
            // 
            // lPart
            // 
            this.lPart.AutoSize = true;
            this.lPart.Location = new System.Drawing.Point(175, 71);
            this.lPart.Name = "lPart";
            this.lPart.Size = new System.Drawing.Size(45, 13);
            this.lPart.TabIndex = 2;
            this.lPart.Text = "Деталь";
            // 
            // bResetFilter
            // 
            this.bResetFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bResetFilter.BackgroundImage = global::Process_Engineering.Properties.Resources.filter;
            this.bResetFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bResetFilter.Location = new System.Drawing.Point(874, 15);
            this.bResetFilter.Name = "bResetFilter";
            this.bResetFilter.Size = new System.Drawing.Size(50, 50);
            this.bResetFilter.TabIndex = 4;
            this.toolTip.SetToolTip(this.bResetFilter, "Очистить фильтр");
            this.bResetFilter.UseVisualStyleBackColor = true;
            this.bResetFilter.Click += new System.EventHandler(this.bResetFilter_Click);
            // 
            // lCardNumber
            // 
            this.lCardNumber.AutoSize = true;
            this.lCardNumber.Location = new System.Drawing.Point(12, 73);
            this.lCardNumber.Name = "lCardNumber";
            this.lCardNumber.Size = new System.Drawing.Size(41, 13);
            this.lCardNumber.TabIndex = 2;
            this.lCardNumber.Text = "Номер";
            // 
            // lCardType
            // 
            this.lCardType.AutoSize = true;
            this.lCardType.Location = new System.Drawing.Point(27, 21);
            this.lCardType.Name = "lCardType";
            this.lCardType.Size = new System.Drawing.Size(26, 13);
            this.lCardType.TabIndex = 2;
            this.lCardType.Text = "Тип";
            // 
            // lProject
            // 
            this.lProject.AutoSize = true;
            this.lProject.Location = new System.Drawing.Point(9, 46);
            this.lProject.Name = "lProject";
            this.lProject.Size = new System.Drawing.Size(44, 13);
            this.lProject.TabIndex = 2;
            this.lProject.Text = "Проект";
            // 
            // cbCardType
            // 
            this.cbCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCardType.FormattingEnabled = true;
            this.cbCardType.Location = new System.Drawing.Point(59, 16);
            this.cbCardType.Name = "cbCardType";
            this.cbCardType.Size = new System.Drawing.Size(92, 21);
            this.cbCardType.TabIndex = 1;
            this.cbCardType.DropDown += new System.EventHandler(this.cbCardType_DropDown);
            this.cbCardType.SelectedIndexChanged += new System.EventHandler(this.FilterCardParameterChanged);
            // 
            // cbProject
            // 
            this.cbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Location = new System.Drawing.Point(59, 43);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(92, 21);
            this.cbProject.TabIndex = 1;
            this.cbProject.DropDown += new System.EventHandler(this.cbProject_DropDown);
            this.cbProject.SelectedIndexChanged += new System.EventHandler(this.FilterCardParameterChanged);
            // 
            // cbPart
            // 
            this.cbPart.FormattingEnabled = true;
            this.cbPart.Location = new System.Drawing.Point(226, 68);
            this.cbPart.Name = "cbPart";
            this.cbPart.Size = new System.Drawing.Size(452, 21);
            this.cbPart.TabIndex = 1;
            this.cbPart.SelectedIndexChanged += new System.EventHandler(this.FilterCardParameterChanged);
            this.cbPart.TextChanged += new System.EventHandler(this.cbPart_TextChanged);
            // 
            // bPrint
            // 
            this.bPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bPrint.Image = global::Process_Engineering.Properties.Resources.print;
            this.bPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bPrint.Location = new System.Drawing.Point(6, 355);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(130, 50);
            this.bPrint.TabIndex = 12;
            this.bPrint.Text = "Распечатать\r\nвыбранные\r\nгаммы";
            this.bPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(6, 409);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(130, 26);
            this.progressBar.TabIndex = 13;
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.lUser);
            this.gbUser.Controls.Add(this.bLogIn);
            this.gbUser.Controls.Add(this.bChangePassword);
            this.gbUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbUser.Location = new System.Drawing.Point(3, 16);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(142, 98);
            this.gbUser.TabIndex = 9;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "Авторизация";
            // 
            // gbManagement
            // 
            this.gbManagement.Controls.Add(this.gbFunctions);
            this.gbManagement.Controls.Add(this.gbUser);
            this.gbManagement.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbManagement.Location = new System.Drawing.Point(936, 0);
            this.gbManagement.Name = "gbManagement";
            this.gbManagement.Size = new System.Drawing.Size(148, 611);
            this.gbManagement.TabIndex = 10;
            this.gbManagement.TabStop = false;
            this.gbManagement.Text = "Управление";
            // 
            // gbFunctions
            // 
            this.gbFunctions.Controls.Add(this.bLoadFromDB);
            this.gbFunctions.Controls.Add(this.bEditPitches);
            this.gbFunctions.Controls.Add(this.bToolCheck);
            this.gbFunctions.Controls.Add(this.bPrint);
            this.gbFunctions.Controls.Add(this.progressBar);
            this.gbFunctions.Controls.Add(this.bScrewingTools);
            this.gbFunctions.Controls.Add(this.bEditTools);
            this.gbFunctions.Controls.Add(this.bEditParts);
            this.gbFunctions.Controls.Add(this.bCreateCard);
            this.gbFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFunctions.Location = new System.Drawing.Point(3, 114);
            this.gbFunctions.Name = "gbFunctions";
            this.gbFunctions.Size = new System.Drawing.Size(142, 494);
            this.gbFunctions.TabIndex = 10;
            this.gbFunctions.TabStop = false;
            this.gbFunctions.Text = "Функции";
            this.toolTip.SetToolTip(this.gbFunctions, "Инструменты завинчивания");
            // 
            // bLoadFromDB
            // 
            this.bLoadFromDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bLoadFromDB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bLoadFromDB.Image = ((System.Drawing.Image)(resources.GetObject("bLoadFromDB.Image")));
            this.bLoadFromDB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bLoadFromDB.Location = new System.Drawing.Point(6, 441);
            this.bLoadFromDB.Name = "bLoadFromDB";
            this.bLoadFromDB.Size = new System.Drawing.Size(130, 50);
            this.bLoadFromDB.TabIndex = 12;
            this.bLoadFromDB.Text = "Обновить\r\nданные";
            this.bLoadFromDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bLoadFromDB.UseVisualStyleBackColor = true;
            this.bLoadFromDB.Click += new System.EventHandler(this.bLoadFromDB_Click);
            // 
            // bEditPitches
            // 
            this.bEditPitches.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bEditPitches.Image = global::Process_Engineering.Properties.Resources.pitches;
            this.bEditPitches.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEditPitches.Location = new System.Drawing.Point(6, 187);
            this.bEditPitches.Name = "bEditPitches";
            this.bEditPitches.Size = new System.Drawing.Size(130, 50);
            this.bEditPitches.TabIndex = 11;
            this.bEditPitches.Text = "Посты";
            this.bEditPitches.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.bEditPitches, "Посты");
            this.bEditPitches.UseVisualStyleBackColor = true;
            this.bEditPitches.Click += new System.EventHandler(this.bEditPitches_Click);
            // 
            // bToolCheck
            // 
            this.bToolCheck.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bToolCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bToolCheck.Image = global::Process_Engineering.Properties.Resources.check;
            this.bToolCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bToolCheck.Location = new System.Drawing.Point(6, 299);
            this.bToolCheck.Name = "bToolCheck";
            this.bToolCheck.Size = new System.Drawing.Size(130, 50);
            this.bToolCheck.TabIndex = 10;
            this.bToolCheck.Text = "Кампании\r\nповерки";
            this.bToolCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bToolCheck.UseVisualStyleBackColor = true;
            this.bToolCheck.Click += new System.EventHandler(this.bToolCheck_Click);
            // 
            // bScrewingTools
            // 
            this.bScrewingTools.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bScrewingTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bScrewingTools.Image = global::Process_Engineering.Properties.Resources.screwdriver;
            this.bScrewingTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bScrewingTools.Location = new System.Drawing.Point(6, 243);
            this.bScrewingTools.Name = "bScrewingTools";
            this.bScrewingTools.Size = new System.Drawing.Size(130, 50);
            this.bScrewingTools.TabIndex = 9;
            this.bScrewingTools.Text = "Инструменты\r\nзавинчивания";
            this.bScrewingTools.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bScrewingTools.UseVisualStyleBackColor = true;
            this.bScrewingTools.Click += new System.EventHandler(this.bScrewingTools_Click);
            // 
            // bEditTools
            // 
            this.bEditTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bEditTools.Image = ((System.Drawing.Image)(resources.GetObject("bEditTools.Image")));
            this.bEditTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEditTools.Location = new System.Drawing.Point(6, 131);
            this.bEditTools.Name = "bEditTools";
            this.bEditTools.Size = new System.Drawing.Size(130, 50);
            this.bEditTools.TabIndex = 7;
            this.bEditTools.Text = "Инструменты";
            this.bEditTools.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bEditTools.UseVisualStyleBackColor = true;
            this.bEditTools.Click += new System.EventHandler(this.bEditTools_Click);
            // 
            // bEditParts
            // 
            this.bEditParts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bEditParts.Image = ((System.Drawing.Image)(resources.GetObject("bEditParts.Image")));
            this.bEditParts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEditParts.Location = new System.Drawing.Point(6, 75);
            this.bEditParts.Name = "bEditParts";
            this.bEditParts.Size = new System.Drawing.Size(130, 50);
            this.bEditParts.TabIndex = 6;
            this.bEditParts.Text = "Детали";
            this.bEditParts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bEditParts.UseVisualStyleBackColor = true;
            this.bEditParts.Click += new System.EventHandler(this.bEditParts_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.gbCards);
            this.Controls.Add(this.gbManagement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "MainForm";
            this.Text = "Технологический процесс";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCardInfo)).EndInit();
            this.gbCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.gbCardInfo.ResumeLayout(false);
            this.gbCardInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udPosition)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.gbUser.ResumeLayout(false);
            this.gbManagement.ResumeLayout(false);
            this.gbFunctions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCards;
        private System.Windows.Forms.Button bLogIn;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.Button bCreateCard;
        private System.Windows.Forms.Button bChangePassword;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.DataGridView dgCardInfo;
        private System.Windows.Forms.GroupBox gbCards;
        private System.Windows.Forms.GroupBox gbCardInfo;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.ComboBox cbPart;
        private System.Windows.Forms.ComboBox cbProject;
        private System.Windows.Forms.ComboBox cbCardType;
        private System.Windows.Forms.Label lPart;
        private System.Windows.Forms.Label lCardNumber;
        private System.Windows.Forms.Label lProject;
        private System.Windows.Forms.Label lCardType;
        private System.Windows.Forms.Button bResetFilter;
        private System.Windows.Forms.GroupBox gbManagement;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.GroupBox gbFunctions;
        private System.Windows.Forms.Button bTest;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button bFind;
        private System.Windows.Forms.Button bEditParts;
        private System.Windows.Forms.Button bEditTools;
        private System.Windows.Forms.Button bScrewingTools;
        private System.Windows.Forms.ComboBox cbCardPitch;
        private System.Windows.Forms.Button bPutPitch;
        private System.Windows.Forms.ComboBox cbPitch;
        private System.Windows.Forms.Label lPitch;
        private System.Windows.Forms.ComboBox cbCharacter;
        private System.Windows.Forms.Label lCharacter;
        private System.Windows.Forms.Button bPosition;
        private System.Windows.Forms.NumericUpDown udPosition;
        private System.Windows.Forms.Button bChrono;
        private System.Windows.Forms.Button bToolCheck;
        private System.Windows.Forms.Label lPosition;
        private System.Windows.Forms.Label lPitchNumber;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button bEditPitches;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.Button bLoadFromDB;
        private System.Windows.Forms.Label lCreatorFilter;
        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.TextBox tbCardNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn parameterNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardFieldColumn;
        private System.Windows.Forms.Button bExcel;
        private System.Windows.Forms.Button bCopyCard;
        private System.Windows.Forms.Button bNewVersion;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ComboBox cbVersion;
        private System.Windows.Forms.Label lVersion;
        private System.Windows.Forms.TextBox tbControlPlan;
        private System.Windows.Forms.Label lControlPlan;
        private System.Windows.Forms.Button bArchive;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button bDescription;
        private System.Windows.Forms.Button bMovements;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardPosColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharacterColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ecdvColumn;
    }
}