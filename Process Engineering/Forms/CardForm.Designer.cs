namespace Process_Engineering
{
    partial class CardForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardForm));
            this.bSave = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.bPicture = new System.Windows.Forms.Button();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.lCardType = new System.Windows.Forms.Label();
            this.cbCardType = new System.Windows.Forms.ComboBox();
            this.lProject = new System.Windows.Forms.Label();
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.lName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lCode = new System.Windows.Forms.Label();
            this.cbPageNumber = new System.Windows.Forms.ComboBox();
            this.dgPhases = new System.Windows.Forms.DataGridView();
            this.TypeColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgParts = new System.Windows.Forms.DataGridView();
            this.cbPart = new System.Windows.Forms.ComboBox();
            this.bAddPart = new System.Windows.Forms.Button();
            this.bAddPage = new System.Windows.Forms.Button();
            this.bDeletePage = new System.Windows.Forms.Button();
            this.bShowInExcel = new System.Windows.Forms.Button();
            this.gbMainParameters = new System.Windows.Forms.GroupBox();
            this.cbCode = new System.Windows.Forms.ComboBox();
            this.tbControlPlan = new System.Windows.Forms.TextBox();
            this.lControlPlan = new System.Windows.Forms.Label();
            this.lCharacter = new System.Windows.Forms.Label();
            this.cbCharacter = new System.Windows.Forms.ComboBox();
            this.lVersion = new System.Windows.Forms.Label();
            this.lNumber = new System.Windows.Forms.Label();
            this.lDescription = new System.Windows.Forms.Label();
            this.tbVersion = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.gbPageParameters = new System.Windows.Forms.GroupBox();
            this.pPage = new System.Windows.Forms.Panel();
            this.gbPhases = new System.Windows.Forms.GroupBox();
            this.gbScrewing = new System.Windows.Forms.GroupBox();
            this.cbScrewing = new System.Windows.Forms.CheckBox();
            this.lAngleTolerance = new System.Windows.Forms.Label();
            this.lAngle = new System.Windows.Forms.Label();
            this.lTorqueTolerance = new System.Windows.Forms.Label();
            this.lTorque = new System.Windows.Forms.Label();
            this.tbAngleTolerance = new System.Windows.Forms.TextBox();
            this.tbAngle = new System.Windows.Forms.TextBox();
            this.tbTorqueTolerance = new System.Windows.Forms.TextBox();
            this.tbTorque = new System.Windows.Forms.TextBox();
            this.pToolsAndParts = new System.Windows.Forms.Panel();
            this.gbTools = new System.Windows.Forms.GroupBox();
            this.dgTools = new System.Windows.Forms.DataGridView();
            this.cbTools = new System.Windows.Forms.ComboBox();
            this.bAddTool = new System.Windows.Forms.Button();
            this.gbParts = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgParts)).BeginInit();
            this.gbMainParameters.SuspendLayout();
            this.gbPageParameters.SuspendLayout();
            this.pPage.SuspendLayout();
            this.gbPhases.SuspendLayout();
            this.gbScrewing.SuspendLayout();
            this.pToolsAndParts.SuspendLayout();
            this.gbTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTools)).BeginInit();
            this.gbParts.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.BackgroundImage = global::Process_Engineering.Properties.Resources.save;
            this.bSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSave.Location = new System.Drawing.Point(1058, 17);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(50, 50);
            this.bSave.TabIndex = 0;
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.ImageLocation = "";
            this.pictureBox.Location = new System.Drawing.Point(3, 46);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(355, 275);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragDrop);
            this.pictureBox.DoubleClick += new System.EventHandler(this.pictureBox_DoubleClick);
            // 
            // bPicture
            // 
            this.bPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPicture.Location = new System.Drawing.Point(241, 3);
            this.bPicture.Name = "bPicture";
            this.bPicture.Size = new System.Drawing.Size(108, 24);
            this.bPicture.TabIndex = 2;
            this.bPicture.Text = "Загрузить фото";
            this.bPicture.UseVisualStyleBackColor = true;
            this.bPicture.Click += new System.EventHandler(this.bPicture_Click);
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.FileName = "openPictureDialog";
            this.openPictureDialog.Filter = "Картинки|*.jpeg;*.jpg;*.png";
            this.openPictureDialog.InitialDirectory = "C:\\Users\\jv00706\\Desktop";
            // 
            // lCardType
            // 
            this.lCardType.AutoSize = true;
            this.lCardType.Location = new System.Drawing.Point(9, 25);
            this.lCardType.Name = "lCardType";
            this.lCardType.Size = new System.Drawing.Size(64, 13);
            this.lCardType.TabIndex = 3;
            this.lCardType.Text = "Тип гаммы";
            // 
            // cbCardType
            // 
            this.cbCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCardType.FormattingEnabled = true;
            this.cbCardType.Location = new System.Drawing.Point(79, 23);
            this.cbCardType.Name = "cbCardType";
            this.cbCardType.Size = new System.Drawing.Size(93, 21);
            this.cbCardType.TabIndex = 4;
            // 
            // lProject
            // 
            this.lProject.AutoSize = true;
            this.lProject.Location = new System.Drawing.Point(29, 54);
            this.lProject.Name = "lProject";
            this.lProject.Size = new System.Drawing.Size(44, 13);
            this.lProject.TabIndex = 3;
            this.lProject.Text = "Проект";
            // 
            // cbProject
            // 
            this.cbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Location = new System.Drawing.Point(79, 50);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(93, 21);
            this.cbProject.TabIndex = 4;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(355, 25);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(57, 13);
            this.lName.TabIndex = 3;
            this.lName.Text = "Название";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(418, 22);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(400, 20);
            this.tbName.TabIndex = 5;
            // 
            // lCode
            // 
            this.lCode.AutoSize = true;
            this.lCode.Location = new System.Drawing.Point(322, 54);
            this.lCode.Name = "lCode";
            this.lCode.Size = new System.Drawing.Size(90, 13);
            this.lCode.TabIndex = 3;
            this.lCode.Text = "Применяемость";
            // 
            // cbPageNumber
            // 
            this.cbPageNumber.AutoCompleteCustomSource.AddRange(new string[] {
            "1"});
            this.cbPageNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPageNumber.FormattingEnabled = true;
            this.cbPageNumber.Location = new System.Drawing.Point(3, 5);
            this.cbPageNumber.Name = "cbPageNumber";
            this.cbPageNumber.Size = new System.Drawing.Size(81, 21);
            this.cbPageNumber.TabIndex = 4;
            this.cbPageNumber.SelectedIndexChanged += new System.EventHandler(this.cbPageNumber_SelectedIndexChanged);
            // 
            // dgPhases
            // 
            this.dgPhases.AllowUserToResizeColumns = false;
            this.dgPhases.AllowUserToResizeRows = false;
            this.dgPhases.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPhases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPhases.ColumnHeadersHeight = 19;
            this.dgPhases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgPhases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPhases.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgPhases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPhases.EnableHeadersVisualStyles = false;
            this.dgPhases.Location = new System.Drawing.Point(3, 16);
            this.dgPhases.Name = "dgPhases";
            this.dgPhases.RowHeadersWidth = 30;
            this.dgPhases.Size = new System.Drawing.Size(747, 228);
            this.dgPhases.TabIndex = 6;
            this.dgPhases.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgPhases_CellMouseDoubleClick);
            this.dgPhases.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPhases_CellValueChanged);
            this.dgPhases.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPhases_RowLeave);
            this.dgPhases.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgPhases_RowsRemoved);
            // 
            // TypeColumn
            // 
            this.TypeColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.TypeColumn.HeaderText = "Тип";
            this.TypeColumn.Items.AddRange(new object[] {
            "Ключ",
            "Фаза"});
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.Width = 60;
            // 
            // dgParts
            // 
            this.dgParts.AllowUserToAddRows = false;
            this.dgParts.AllowUserToResizeColumns = false;
            this.dgParts.AllowUserToResizeRows = false;
            this.dgParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgParts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgParts.EnableHeadersVisualStyles = false;
            this.dgParts.Location = new System.Drawing.Point(3, 51);
            this.dgParts.Name = "dgParts";
            this.dgParts.RowHeadersWidth = 30;
            this.dgParts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgParts.Size = new System.Drawing.Size(571, 130);
            this.dgParts.TabIndex = 7;
            this.dgParts.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgParts_ColumnWidthChanged);
            this.dgParts.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgParts_EditingControlShowing);
            // 
            // cbPart
            // 
            this.cbPart.FormattingEnabled = true;
            this.cbPart.IntegralHeight = false;
            this.cbPart.Location = new System.Drawing.Point(6, 19);
            this.cbPart.MaxDropDownItems = 10;
            this.cbPart.Name = "cbPart";
            this.cbPart.Size = new System.Drawing.Size(478, 21);
            this.cbPart.TabIndex = 9;
            this.cbPart.TextChanged += new System.EventHandler(this.cbPart_TextChanged);
            // 
            // bAddPart
            // 
            this.bAddPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAddPart.Location = new System.Drawing.Point(490, 17);
            this.bAddPart.Name = "bAddPart";
            this.bAddPart.Size = new System.Drawing.Size(81, 28);
            this.bAddPart.TabIndex = 10;
            this.bAddPart.Text = "Добавить";
            this.bAddPart.UseVisualStyleBackColor = true;
            this.bAddPart.Click += new System.EventHandler(this.bAddPart_Click);
            // 
            // bAddPage
            // 
            this.bAddPage.Location = new System.Drawing.Point(90, 3);
            this.bAddPage.Name = "bAddPage";
            this.bAddPage.Size = new System.Drawing.Size(73, 24);
            this.bAddPage.TabIndex = 11;
            this.bAddPage.Text = "Добавить";
            this.bAddPage.UseVisualStyleBackColor = true;
            this.bAddPage.Click += new System.EventHandler(this.bAddPage_Click);
            // 
            // bDeletePage
            // 
            this.bDeletePage.Location = new System.Drawing.Point(169, 3);
            this.bDeletePage.Name = "bDeletePage";
            this.bDeletePage.Size = new System.Drawing.Size(62, 24);
            this.bDeletePage.TabIndex = 11;
            this.bDeletePage.Text = "Удалить";
            this.bDeletePage.UseVisualStyleBackColor = true;
            this.bDeletePage.Click += new System.EventHandler(this.bDeletePage_Click);
            // 
            // bShowInExcel
            // 
            this.bShowInExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bShowInExcel.BackgroundImage = global::Process_Engineering.Properties.Resources.excel;
            this.bShowInExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bShowInExcel.Location = new System.Drawing.Point(1002, 17);
            this.bShowInExcel.Name = "bShowInExcel";
            this.bShowInExcel.Size = new System.Drawing.Size(50, 50);
            this.bShowInExcel.TabIndex = 12;
            this.bShowInExcel.UseVisualStyleBackColor = true;
            this.bShowInExcel.Click += new System.EventHandler(this.bShowInExcel_Click);
            // 
            // gbMainParameters
            // 
            this.gbMainParameters.Controls.Add(this.bSave);
            this.gbMainParameters.Controls.Add(this.bShowInExcel);
            this.gbMainParameters.Controls.Add(this.cbCode);
            this.gbMainParameters.Controls.Add(this.tbControlPlan);
            this.gbMainParameters.Controls.Add(this.lControlPlan);
            this.gbMainParameters.Controls.Add(this.lCharacter);
            this.gbMainParameters.Controls.Add(this.cbCharacter);
            this.gbMainParameters.Controls.Add(this.lCardType);
            this.gbMainParameters.Controls.Add(this.lVersion);
            this.gbMainParameters.Controls.Add(this.lNumber);
            this.gbMainParameters.Controls.Add(this.lProject);
            this.gbMainParameters.Controls.Add(this.lName);
            this.gbMainParameters.Controls.Add(this.cbCardType);
            this.gbMainParameters.Controls.Add(this.lDescription);
            this.gbMainParameters.Controls.Add(this.lCode);
            this.gbMainParameters.Controls.Add(this.tbVersion);
            this.gbMainParameters.Controls.Add(this.cbProject);
            this.gbMainParameters.Controls.Add(this.tbNumber);
            this.gbMainParameters.Controls.Add(this.tbDescription);
            this.gbMainParameters.Controls.Add(this.tbName);
            this.gbMainParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMainParameters.Location = new System.Drawing.Point(0, 0);
            this.gbMainParameters.Name = "gbMainParameters";
            this.gbMainParameters.Size = new System.Drawing.Size(1114, 103);
            this.gbMainParameters.TabIndex = 13;
            this.gbMainParameters.TabStop = false;
            this.gbMainParameters.Text = "Основные параметры";
            // 
            // cbCode
            // 
            this.cbCode.FormattingEnabled = true;
            this.cbCode.Location = new System.Drawing.Point(418, 50);
            this.cbCode.Name = "cbCode";
            this.cbCode.Size = new System.Drawing.Size(152, 21);
            this.cbCode.TabIndex = 10;
            // 
            // tbControlPlan
            // 
            this.tbControlPlan.Location = new System.Drawing.Point(836, 50);
            this.tbControlPlan.Name = "tbControlPlan";
            this.tbControlPlan.Size = new System.Drawing.Size(151, 20);
            this.tbControlPlan.TabIndex = 9;
            // 
            // lControlPlan
            // 
            this.lControlPlan.AutoSize = true;
            this.lControlPlan.Location = new System.Drawing.Point(849, 34);
            this.lControlPlan.Name = "lControlPlan";
            this.lControlPlan.Size = new System.Drawing.Size(125, 13);
            this.lControlPlan.TabIndex = 8;
            this.lControlPlan.Text = "№ Контрольного плана";
            // 
            // lCharacter
            // 
            this.lCharacter.AutoSize = true;
            this.lCharacter.Location = new System.Drawing.Point(607, 54);
            this.lCharacter.Name = "lCharacter";
            this.lCharacter.Size = new System.Drawing.Size(90, 13);
            this.lCharacter.TabIndex = 7;
            this.lCharacter.Text = "Характеристика";
            // 
            // cbCharacter
            // 
            this.cbCharacter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCharacter.FormattingEnabled = true;
            this.cbCharacter.Location = new System.Drawing.Point(703, 49);
            this.cbCharacter.Name = "cbCharacter";
            this.cbCharacter.Size = new System.Drawing.Size(115, 21);
            this.cbCharacter.TabIndex = 6;
            // 
            // lVersion
            // 
            this.lVersion.AutoSize = true;
            this.lVersion.Location = new System.Drawing.Point(190, 53);
            this.lVersion.Name = "lVersion";
            this.lVersion.Size = new System.Drawing.Size(44, 13);
            this.lVersion.TabIndex = 3;
            this.lVersion.Text = "Версия";
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Location = new System.Drawing.Point(190, 25);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(41, 13);
            this.lNumber.TabIndex = 3;
            this.lNumber.Text = "Номер";
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(296, 80);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(116, 13);
            this.lDescription.TabIndex = 3;
            this.lDescription.Text = "Описание изменений";
            // 
            // tbVersion
            // 
            this.tbVersion.Location = new System.Drawing.Point(240, 49);
            this.tbVersion.Name = "tbVersion";
            this.tbVersion.ReadOnly = true;
            this.tbVersion.Size = new System.Drawing.Size(40, 20);
            this.tbVersion.TabIndex = 5;
            this.tbVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(240, 23);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.ReadOnly = true;
            this.tbNumber.Size = new System.Drawing.Size(70, 20);
            this.tbNumber.TabIndex = 5;
            this.tbNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(418, 77);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(569, 20);
            this.tbDescription.TabIndex = 5;
            // 
            // gbPageParameters
            // 
            this.gbPageParameters.Controls.Add(this.pictureBox);
            this.gbPageParameters.Controls.Add(this.pPage);
            this.gbPageParameters.Controls.Add(this.gbPhases);
            this.gbPageParameters.Controls.Add(this.pToolsAndParts);
            this.gbPageParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPageParameters.Location = new System.Drawing.Point(0, 103);
            this.gbPageParameters.Name = "gbPageParameters";
            this.gbPageParameters.Size = new System.Drawing.Size(1114, 508);
            this.gbPageParameters.TabIndex = 15;
            this.gbPageParameters.TabStop = false;
            this.gbPageParameters.Text = "Параметры страницы";
            // 
            // pPage
            // 
            this.pPage.Controls.Add(this.cbPageNumber);
            this.pPage.Controls.Add(this.bAddPage);
            this.pPage.Controls.Add(this.bDeletePage);
            this.pPage.Controls.Add(this.bPicture);
            this.pPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pPage.Location = new System.Drawing.Point(3, 16);
            this.pPage.Name = "pPage";
            this.pPage.Size = new System.Drawing.Size(355, 30);
            this.pPage.TabIndex = 22;
            // 
            // gbPhases
            // 
            this.gbPhases.Controls.Add(this.dgPhases);
            this.gbPhases.Controls.Add(this.gbScrewing);
            this.gbPhases.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbPhases.Location = new System.Drawing.Point(358, 16);
            this.gbPhases.Name = "gbPhases";
            this.gbPhases.Size = new System.Drawing.Size(753, 305);
            this.gbPhases.TabIndex = 16;
            this.gbPhases.TabStop = false;
            this.gbPhases.Text = "Этапы";
            // 
            // gbScrewing
            // 
            this.gbScrewing.Controls.Add(this.cbScrewing);
            this.gbScrewing.Controls.Add(this.lAngleTolerance);
            this.gbScrewing.Controls.Add(this.lAngle);
            this.gbScrewing.Controls.Add(this.lTorqueTolerance);
            this.gbScrewing.Controls.Add(this.lTorque);
            this.gbScrewing.Controls.Add(this.tbAngleTolerance);
            this.gbScrewing.Controls.Add(this.tbAngle);
            this.gbScrewing.Controls.Add(this.tbTorqueTolerance);
            this.gbScrewing.Controls.Add(this.tbTorque);
            this.gbScrewing.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbScrewing.Location = new System.Drawing.Point(3, 244);
            this.gbScrewing.Name = "gbScrewing";
            this.gbScrewing.Size = new System.Drawing.Size(747, 58);
            this.gbScrewing.TabIndex = 19;
            this.gbScrewing.TabStop = false;
            this.gbScrewing.Text = "Завинчивание";
            // 
            // cbScrewing
            // 
            this.cbScrewing.AutoSize = true;
            this.cbScrewing.Location = new System.Drawing.Point(10, 27);
            this.cbScrewing.Name = "cbScrewing";
            this.cbScrewing.Size = new System.Drawing.Size(210, 17);
            this.cbScrewing.TabIndex = 2;
            this.cbScrewing.Text = "Добавить параметры завинчивания";
            this.cbScrewing.UseVisualStyleBackColor = true;
            this.cbScrewing.CheckedChanged += new System.EventHandler(this.cbScrewing_CheckedChanged);
            // 
            // lAngleTolerance
            // 
            this.lAngleTolerance.AutoSize = true;
            this.lAngleTolerance.Location = new System.Drawing.Point(583, 16);
            this.lAngleTolerance.Name = "lAngleTolerance";
            this.lAngleTolerance.Size = new System.Drawing.Size(56, 13);
            this.lAngleTolerance.TabIndex = 1;
            this.lAngleTolerance.Text = "Допуск %";
            // 
            // lAngle
            // 
            this.lAngle.AutoSize = true;
            this.lAngle.Location = new System.Drawing.Point(501, 16);
            this.lAngle.Name = "lAngle";
            this.lAngle.Size = new System.Drawing.Size(69, 13);
            this.lAngle.TabIndex = 1;
            this.lAngle.Text = "Угол градус";
            // 
            // lTorqueTolerance
            // 
            this.lTorqueTolerance.AutoSize = true;
            this.lTorqueTolerance.Location = new System.Drawing.Point(429, 16);
            this.lTorqueTolerance.Name = "lTorqueTolerance";
            this.lTorqueTolerance.Size = new System.Drawing.Size(71, 13);
            this.lTorqueTolerance.TabIndex = 1;
            this.lTorqueTolerance.Text = "Допуск, Н*м";
            // 
            // lTorque
            // 
            this.lTorque.AutoSize = true;
            this.lTorque.Location = new System.Drawing.Point(355, 16);
            this.lTorque.Name = "lTorque";
            this.lTorque.Size = new System.Drawing.Size(73, 13);
            this.lTorque.TabIndex = 1;
            this.lTorque.Text = "Момент, Н*м";
            // 
            // tbAngleTolerance
            // 
            this.tbAngleTolerance.Enabled = false;
            this.tbAngleTolerance.Location = new System.Drawing.Point(577, 32);
            this.tbAngleTolerance.Name = "tbAngleTolerance";
            this.tbAngleTolerance.Size = new System.Drawing.Size(67, 20);
            this.tbAngleTolerance.TabIndex = 0;
            this.tbAngleTolerance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAngleTolerance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumber_KeyPress);
            // 
            // tbAngle
            // 
            this.tbAngle.Enabled = false;
            this.tbAngle.Location = new System.Drawing.Point(504, 32);
            this.tbAngle.Name = "tbAngle";
            this.tbAngle.Size = new System.Drawing.Size(67, 20);
            this.tbAngle.TabIndex = 0;
            this.tbAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumber_KeyPress);
            // 
            // tbTorqueTolerance
            // 
            this.tbTorqueTolerance.Enabled = false;
            this.tbTorqueTolerance.Location = new System.Drawing.Point(431, 32);
            this.tbTorqueTolerance.Name = "tbTorqueTolerance";
            this.tbTorqueTolerance.Size = new System.Drawing.Size(67, 20);
            this.tbTorqueTolerance.TabIndex = 0;
            this.tbTorqueTolerance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTorqueTolerance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumber_KeyPress);
            // 
            // tbTorque
            // 
            this.tbTorque.Enabled = false;
            this.tbTorque.Location = new System.Drawing.Point(358, 32);
            this.tbTorque.Name = "tbTorque";
            this.tbTorque.Size = new System.Drawing.Size(67, 20);
            this.tbTorque.TabIndex = 0;
            this.tbTorque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTorque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumber_KeyPress);
            // 
            // pToolsAndParts
            // 
            this.pToolsAndParts.Controls.Add(this.gbTools);
            this.pToolsAndParts.Controls.Add(this.gbParts);
            this.pToolsAndParts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pToolsAndParts.Location = new System.Drawing.Point(3, 321);
            this.pToolsAndParts.Name = "pToolsAndParts";
            this.pToolsAndParts.Size = new System.Drawing.Size(1108, 184);
            this.pToolsAndParts.TabIndex = 20;
            // 
            // gbTools
            // 
            this.gbTools.Controls.Add(this.dgTools);
            this.gbTools.Controls.Add(this.cbTools);
            this.gbTools.Controls.Add(this.bAddTool);
            this.gbTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbTools.Location = new System.Drawing.Point(591, 0);
            this.gbTools.Name = "gbTools";
            this.gbTools.Size = new System.Drawing.Size(517, 184);
            this.gbTools.TabIndex = 17;
            this.gbTools.TabStop = false;
            this.gbTools.Text = "Инструменты";
            // 
            // dgTools
            // 
            this.dgTools.AllowUserToAddRows = false;
            this.dgTools.AllowUserToResizeColumns = false;
            this.dgTools.AllowUserToResizeRows = false;
            this.dgTools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTools.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgTools.EnableHeadersVisualStyles = false;
            this.dgTools.Location = new System.Drawing.Point(3, 51);
            this.dgTools.Name = "dgTools";
            this.dgTools.RowHeadersWidth = 30;
            this.dgTools.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgTools.Size = new System.Drawing.Size(511, 130);
            this.dgTools.TabIndex = 7;
            this.dgTools.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgTools_CellMouseDoubleClick);
            // 
            // cbTools
            // 
            this.cbTools.FormattingEnabled = true;
            this.cbTools.IntegralHeight = false;
            this.cbTools.Location = new System.Drawing.Point(6, 19);
            this.cbTools.MaxDropDownItems = 10;
            this.cbTools.Name = "cbTools";
            this.cbTools.Size = new System.Drawing.Size(418, 21);
            this.cbTools.TabIndex = 9;
            this.cbTools.TextChanged += new System.EventHandler(this.cbTools_TextChanged);
            // 
            // bAddTool
            // 
            this.bAddTool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAddTool.Location = new System.Drawing.Point(430, 17);
            this.bAddTool.Name = "bAddTool";
            this.bAddTool.Size = new System.Drawing.Size(81, 28);
            this.bAddTool.TabIndex = 10;
            this.bAddTool.Text = "Добавить";
            this.bAddTool.UseVisualStyleBackColor = true;
            this.bAddTool.Click += new System.EventHandler(this.bAddTool_Click);
            // 
            // gbParts
            // 
            this.gbParts.Controls.Add(this.dgParts);
            this.gbParts.Controls.Add(this.cbPart);
            this.gbParts.Controls.Add(this.bAddPart);
            this.gbParts.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbParts.Location = new System.Drawing.Point(0, 0);
            this.gbParts.Name = "gbParts";
            this.gbParts.Size = new System.Drawing.Size(577, 184);
            this.gbParts.TabIndex = 17;
            this.gbParts.TabStop = false;
            this.gbParts.Text = "Детали";
            // 
            // CardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 611);
            this.Controls.Add(this.gbPageParameters);
            this.Controls.Add(this.gbMainParameters);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1130, 650);
            this.Name = "CardForm";
            this.Text = "Гамма";
            this.Load += new System.EventHandler(this.CardForm_Load);
            this.Resize += new System.EventHandler(this.CardForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgParts)).EndInit();
            this.gbMainParameters.ResumeLayout(false);
            this.gbMainParameters.PerformLayout();
            this.gbPageParameters.ResumeLayout(false);
            this.pPage.ResumeLayout(false);
            this.gbPhases.ResumeLayout(false);
            this.gbScrewing.ResumeLayout(false);
            this.gbScrewing.PerformLayout();
            this.pToolsAndParts.ResumeLayout(false);
            this.gbTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTools)).EndInit();
            this.gbParts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button bPicture;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
        private System.Windows.Forms.Label lCardType;
        private System.Windows.Forms.ComboBox cbCardType;
        private System.Windows.Forms.Label lProject;
        private System.Windows.Forms.ComboBox cbProject;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lCode;
        private System.Windows.Forms.ComboBox cbPageNumber;
        private System.Windows.Forms.DataGridView dgPhases;
        private System.Windows.Forms.DataGridView dgParts;
        private System.Windows.Forms.ComboBox cbPart;
        private System.Windows.Forms.Button bAddPart;
        private System.Windows.Forms.Button bAddPage;
        private System.Windows.Forms.Button bDeletePage;
        private System.Windows.Forms.Button bShowInExcel;
        private System.Windows.Forms.GroupBox gbMainParameters;
        private System.Windows.Forms.Label lNumber;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label lVersion;
        private System.Windows.Forms.TextBox tbVersion;
        private System.Windows.Forms.GroupBox gbPageParameters;
        private System.Windows.Forms.GroupBox gbPhases;
        private System.Windows.Forms.GroupBox gbParts;
        private System.Windows.Forms.GroupBox gbScrewing;
        private System.Windows.Forms.TextBox tbTorque;
        private System.Windows.Forms.Label lTorque;
        private System.Windows.Forms.Label lAngleTolerance;
        private System.Windows.Forms.Label lAngle;
        private System.Windows.Forms.Label lTorqueTolerance;
        private System.Windows.Forms.TextBox tbAngleTolerance;
        private System.Windows.Forms.TextBox tbAngle;
        private System.Windows.Forms.TextBox tbTorqueTolerance;
        private System.Windows.Forms.CheckBox cbScrewing;
        private System.Windows.Forms.GroupBox gbTools;
        private System.Windows.Forms.DataGridView dgTools;
        private System.Windows.Forms.ComboBox cbTools;
        private System.Windows.Forms.Button bAddTool;
        private System.Windows.Forms.Label lCharacter;
        private System.Windows.Forms.ComboBox cbCharacter;
        private System.Windows.Forms.Label lControlPlan;
        private System.Windows.Forms.TextBox tbControlPlan;
        private System.Windows.Forms.DataGridViewComboBoxColumn TypeColumn;
        private System.Windows.Forms.ComboBox cbCode;
        private System.Windows.Forms.Panel pToolsAndParts;
        private System.Windows.Forms.Panel pPage;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lDescription;
    }
}

