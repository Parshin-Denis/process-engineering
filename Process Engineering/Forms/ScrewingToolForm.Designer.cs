namespace Process_Engineering.Forms
{
    partial class ScrewingToolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrewingToolForm));
            this.dgTools = new System.Windows.Forms.DataGridView();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbTorque = new System.Windows.Forms.TextBox();
            this.lNumber = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bFind = new System.Windows.Forms.Button();
            this.lCount = new System.Windows.Forms.Label();
            this.cbCards = new System.Windows.Forms.ComboBox();
            this.lCard = new System.Windows.Forms.Label();
            this.cbPitch = new System.Windows.Forms.ComboBox();
            this.lPitch = new System.Windows.Forms.Label();
            this.cbToolType = new System.Windows.Forms.ComboBox();
            this.lToolType = new System.Windows.Forms.Label();
            this.tbSerialNumber = new System.Windows.Forms.TextBox();
            this.lSerialNumber = new System.Windows.Forms.Label();
            this.cbToolTypeFilter = new System.Windows.Forms.ComboBox();
            this.cbCardFilter = new System.Windows.Forms.ComboBox();
            this.cbPitchFilter = new System.Windows.Forms.ComboBox();
            this.bPrint = new System.Windows.Forms.Button();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.bResetFilter = new System.Windows.Forms.Button();
            this.lToolNumberFilter = new System.Windows.Forms.Label();
            this.lTollTypeFilter = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.bToolType = new System.Windows.Forms.Button();
            this.cbAnomaly = new System.Windows.Forms.CheckBox();
            this.tbNumberFilter = new System.Windows.Forms.TextBox();
            this.tbTorqueFilter = new System.Windows.Forms.TextBox();
            this.lTorqueFilter = new System.Windows.Forms.Label();
            this.pPrint = new System.Windows.Forms.Panel();
            this.cbStatusFilter = new System.Windows.Forms.ComboBox();
            this.lPitchFilter = new System.Windows.Forms.Label();
            this.lCardFilter = new System.Windows.Forms.Label();
            this.tbSerialNumberFilter = new System.Windows.Forms.TextBox();
            this.cbModelFilter = new System.Windows.Forms.ComboBox();
            this.lSerialNumberFilter = new System.Windows.Forms.Label();
            this.lStatusFilter = new System.Windows.Forms.Label();
            this.lModelFilter = new System.Windows.Forms.Label();
            this.lNmFilter = new System.Windows.Forms.Label();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.cbToolReplace = new System.Windows.Forms.ComboBox();
            this.lToolReplace = new System.Windows.Forms.Label();
            this.lCardName = new System.Windows.Forms.Label();
            this.lCardNumber = new System.Windows.Forms.Label();
            this.tbCardName = new System.Windows.Forms.TextBox();
            this.tbCardNumber = new System.Windows.Forms.TextBox();
            this.lTorqueError = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.bSetTorque = new System.Windows.Forms.Button();
            this.bShowCard = new System.Windows.Forms.Button();
            this.lStatus = new System.Windows.Forms.Label();
            this.lNm = new System.Windows.Forms.Label();
            this.bCheckHistory = new System.Windows.Forms.Button();
            this.pButtons = new System.Windows.Forms.Panel();
            this.bMovements = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgTools)).BeginInit();
            this.gbFilter.SuspendLayout();
            this.pPrint.SuspendLayout();
            this.gbEdit.SuspendLayout();
            this.pButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgTools
            // 
            this.dgTools.AllowUserToAddRows = false;
            this.dgTools.AllowUserToDeleteRows = false;
            this.dgTools.AllowUserToResizeColumns = false;
            this.dgTools.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTools.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTools.EnableHeadersVisualStyles = false;
            this.dgTools.Location = new System.Drawing.Point(0, 100);
            this.dgTools.Name = "dgTools";
            this.dgTools.RowHeadersVisible = false;
            this.dgTools.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTools.Size = new System.Drawing.Size(984, 299);
            this.dgTools.TabIndex = 0;
            this.dgTools.SelectionChanged += new System.EventHandler(this.dgTools_SelectionChanged);
            this.dgTools.SizeChanged += new System.EventHandler(this.dgTools_SizeChanged);
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(84, 19);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(75, 20);
            this.tbNumber.TabIndex = 1;
            this.tbNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumber.TextChanged += new System.EventHandler(this.ToolParamaterChanged);
            this.tbNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeric_KeyPress);
            // 
            // tbTorque
            // 
            this.tbTorque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTorque.Location = new System.Drawing.Point(404, 73);
            this.tbTorque.Name = "tbTorque";
            this.tbTorque.Size = new System.Drawing.Size(72, 20);
            this.tbTorque.TabIndex = 1;
            this.tbTorque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTorque.TextChanged += new System.EventHandler(this.ToolParamaterChanged);
            this.tbTorque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeric_KeyPress);
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Location = new System.Drawing.Point(37, 22);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(41, 13);
            this.lNumber.TabIndex = 2;
            this.lNumber.Text = "Номер";
            // 
            // lName
            // 
            this.lName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(351, 76);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(47, 13);
            this.lName.TabIndex = 2;
            this.lName.Text = "Момент";
            // 
            // bUpdate
            // 
            this.bUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bUpdate.Location = new System.Drawing.Point(3, 2);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(193, 32);
            this.bUpdate.TabIndex = 3;
            this.bUpdate.Text = "Принять изменения";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAdd.Location = new System.Drawing.Point(803, 2);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(178, 32);
            this.bAdd.TabIndex = 4;
            this.bAdd.Text = "Добавить новый инструмент";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bFind
            // 
            this.bFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bFind.BackgroundImage = global::Process_Engineering.Properties.Resources.find;
            this.bFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bFind.Location = new System.Drawing.Point(713, 17);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(50, 50);
            this.bFind.TabIndex = 7;
            this.toolTip.SetToolTip(this.bFind, "Найти");
            this.bFind.UseVisualStyleBackColor = true;
            this.bFind.Click += new System.EventHandler(this.UpdateDataGrid);
            // 
            // lCount
            // 
            this.lCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lCount.Location = new System.Drawing.Point(775, 77);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(100, 20);
            this.lCount.TabIndex = 8;
            this.lCount.Text = "Найдено: 0 шт.";
            this.lCount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // cbCards
            // 
            this.cbCards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCards.FormattingEnabled = true;
            this.cbCards.Location = new System.Drawing.Point(404, 18);
            this.cbCards.Name = "cbCards";
            this.cbCards.Size = new System.Drawing.Size(499, 21);
            this.cbCards.TabIndex = 9;
            this.cbCards.SelectedIndexChanged += new System.EventHandler(this.ToolParamaterChanged);
            this.cbCards.TextChanged += new System.EventHandler(this.cbCards_TextChanged);
            // 
            // lCard
            // 
            this.lCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lCard.AutoSize = true;
            this.lCard.Location = new System.Drawing.Point(357, 35);
            this.lCard.Name = "lCard";
            this.lCard.Size = new System.Drawing.Size(41, 13);
            this.lCard.TabIndex = 2;
            this.lCard.Text = "Гамма";
            // 
            // cbPitch
            // 
            this.cbPitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPitch.FormattingEnabled = true;
            this.cbPitch.Location = new System.Drawing.Point(872, 70);
            this.cbPitch.Name = "cbPitch";
            this.cbPitch.Size = new System.Drawing.Size(106, 21);
            this.cbPitch.TabIndex = 10;
            this.cbPitch.SelectedIndexChanged += new System.EventHandler(this.ToolParamaterChanged);
            this.cbPitch.TextChanged += new System.EventHandler(this.cbPitch_TextChanged);
            // 
            // lPitch
            // 
            this.lPitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lPitch.AutoSize = true;
            this.lPitch.Location = new System.Drawing.Point(834, 76);
            this.lPitch.Name = "lPitch";
            this.lPitch.Size = new System.Drawing.Size(32, 13);
            this.lPitch.TabIndex = 2;
            this.lPitch.Text = "Пост";
            // 
            // cbToolType
            // 
            this.cbToolType.FormattingEnabled = true;
            this.cbToolType.Location = new System.Drawing.Point(84, 45);
            this.cbToolType.Name = "cbToolType";
            this.cbToolType.Size = new System.Drawing.Size(212, 21);
            this.cbToolType.TabIndex = 11;
            this.cbToolType.SelectedIndexChanged += new System.EventHandler(this.ToolParamaterChanged);
            this.cbToolType.TextChanged += new System.EventHandler(this.cbToolType_TextChanged);
            // 
            // lToolType
            // 
            this.lToolType.AutoSize = true;
            this.lToolType.Location = new System.Drawing.Point(32, 48);
            this.lToolType.Name = "lToolType";
            this.lToolType.Size = new System.Drawing.Size(46, 13);
            this.lToolType.TabIndex = 2;
            this.lToolType.Text = "Модель";
            // 
            // tbSerialNumber
            // 
            this.tbSerialNumber.Location = new System.Drawing.Point(84, 72);
            this.tbSerialNumber.Name = "tbSerialNumber";
            this.tbSerialNumber.Size = new System.Drawing.Size(212, 20);
            this.tbSerialNumber.TabIndex = 1;
            this.tbSerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSerialNumber.TextChanged += new System.EventHandler(this.ToolParamaterChanged);
            // 
            // lSerialNumber
            // 
            this.lSerialNumber.AutoSize = true;
            this.lSerialNumber.Location = new System.Drawing.Point(6, 75);
            this.lSerialNumber.Name = "lSerialNumber";
            this.lSerialNumber.Size = new System.Drawing.Size(72, 13);
            this.lSerialNumber.TabIndex = 2;
            this.lSerialNumber.Text = "Серийный №";
            // 
            // cbToolTypeFilter
            // 
            this.cbToolTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbToolTypeFilter.FormattingEnabled = true;
            this.cbToolTypeFilter.Location = new System.Drawing.Point(260, 17);
            this.cbToolTypeFilter.Name = "cbToolTypeFilter";
            this.cbToolTypeFilter.Size = new System.Drawing.Size(235, 21);
            this.cbToolTypeFilter.TabIndex = 13;
            this.cbToolTypeFilter.SelectedIndexChanged += new System.EventHandler(this.UpdateDataGrid);
            // 
            // cbCardFilter
            // 
            this.cbCardFilter.FormattingEnabled = true;
            this.cbCardFilter.Location = new System.Drawing.Point(84, 69);
            this.cbCardFilter.Name = "cbCardFilter";
            this.cbCardFilter.Size = new System.Drawing.Size(100, 21);
            this.cbCardFilter.TabIndex = 14;
            this.cbCardFilter.SelectedIndexChanged += new System.EventHandler(this.UpdateDataGrid);
            this.cbCardFilter.TextChanged += new System.EventHandler(this.cbCardFilter_TextChanged);
            // 
            // cbPitchFilter
            // 
            this.cbPitchFilter.FormattingEnabled = true;
            this.cbPitchFilter.Location = new System.Drawing.Point(572, 16);
            this.cbPitchFilter.Name = "cbPitchFilter";
            this.cbPitchFilter.Size = new System.Drawing.Size(96, 21);
            this.cbPitchFilter.TabIndex = 15;
            this.cbPitchFilter.SelectedIndexChanged += new System.EventHandler(this.UpdateDataGrid);
            this.cbPitchFilter.TextChanged += new System.EventHandler(this.cbPitchFilter_TextChanged);
            // 
            // bPrint
            // 
            this.bPrint.BackgroundImage = global::Process_Engineering.Properties.Resources.print;
            this.bPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.bPrint.Location = new System.Drawing.Point(0, 0);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(100, 50);
            this.bPrint.TabIndex = 16;
            this.toolTip.SetToolTip(this.bPrint, "Печать этикеток");
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 53);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 28);
            this.progressBar.TabIndex = 17;
            // 
            // bResetFilter
            // 
            this.bResetFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bResetFilter.BackgroundImage = global::Process_Engineering.Properties.Resources.filter;
            this.bResetFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bResetFilter.Location = new System.Drawing.Point(769, 17);
            this.bResetFilter.Name = "bResetFilter";
            this.bResetFilter.Size = new System.Drawing.Size(50, 50);
            this.bResetFilter.TabIndex = 18;
            this.toolTip.SetToolTip(this.bResetFilter, "Сбросить фильтр");
            this.bResetFilter.UseVisualStyleBackColor = true;
            this.bResetFilter.Click += new System.EventHandler(this.bResetFilter_Click);
            // 
            // lToolNumberFilter
            // 
            this.lToolNumberFilter.AutoSize = true;
            this.lToolNumberFilter.Location = new System.Drawing.Point(37, 20);
            this.lToolNumberFilter.Name = "lToolNumberFilter";
            this.lToolNumberFilter.Size = new System.Drawing.Size(41, 13);
            this.lToolNumberFilter.TabIndex = 19;
            this.lToolNumberFilter.Text = "Номер";
            // 
            // lTollTypeFilter
            // 
            this.lTollTypeFilter.AutoSize = true;
            this.lTollTypeFilter.Location = new System.Drawing.Point(228, 20);
            this.lTollTypeFilter.Name = "lTollTypeFilter";
            this.lTollTypeFilter.Size = new System.Drawing.Size(26, 13);
            this.lTollTypeFilter.TabIndex = 19;
            this.lTollTypeFilter.Text = "Тип";
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.bToolType);
            this.gbFilter.Controls.Add(this.cbAnomaly);
            this.gbFilter.Controls.Add(this.tbNumberFilter);
            this.gbFilter.Controls.Add(this.tbTorqueFilter);
            this.gbFilter.Controls.Add(this.lTorqueFilter);
            this.gbFilter.Controls.Add(this.pPrint);
            this.gbFilter.Controls.Add(this.cbStatusFilter);
            this.gbFilter.Controls.Add(this.lPitchFilter);
            this.gbFilter.Controls.Add(this.lCardFilter);
            this.gbFilter.Controls.Add(this.tbSerialNumberFilter);
            this.gbFilter.Controls.Add(this.cbModelFilter);
            this.gbFilter.Controls.Add(this.cbPitchFilter);
            this.gbFilter.Controls.Add(this.bResetFilter);
            this.gbFilter.Controls.Add(this.lToolNumberFilter);
            this.gbFilter.Controls.Add(this.lSerialNumberFilter);
            this.gbFilter.Controls.Add(this.lStatusFilter);
            this.gbFilter.Controls.Add(this.lModelFilter);
            this.gbFilter.Controls.Add(this.lTollTypeFilter);
            this.gbFilter.Controls.Add(this.cbToolTypeFilter);
            this.gbFilter.Controls.Add(this.lNmFilter);
            this.gbFilter.Controls.Add(this.cbCardFilter);
            this.gbFilter.Controls.Add(this.lCount);
            this.gbFilter.Controls.Add(this.bFind);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(984, 100);
            this.gbFilter.TabIndex = 20;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Фильтр";
            // 
            // bToolType
            // 
            this.bToolType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bToolType.Image = global::Process_Engineering.Properties.Resources.screwdriver;
            this.bToolType.Location = new System.Drawing.Point(825, 17);
            this.bToolType.Name = "bToolType";
            this.bToolType.Size = new System.Drawing.Size(50, 50);
            this.bToolType.TabIndex = 27;
            this.toolTip.SetToolTip(this.bToolType, "Виды инструментов");
            this.bToolType.UseVisualStyleBackColor = true;
            this.bToolType.Click += new System.EventHandler(this.bToolType_Click);
            // 
            // cbAnomaly
            // 
            this.cbAnomaly.AutoSize = true;
            this.cbAnomaly.Location = new System.Drawing.Point(572, 73);
            this.cbAnomaly.Name = "cbAnomaly";
            this.cbAnomaly.Size = new System.Drawing.Size(114, 17);
            this.cbAnomaly.TabIndex = 30;
            this.cbAnomaly.Text = "Ошибки момента";
            this.cbAnomaly.UseVisualStyleBackColor = true;
            this.cbAnomaly.CheckedChanged += new System.EventHandler(this.UpdateDataGrid);
            // 
            // tbNumberFilter
            // 
            this.tbNumberFilter.Location = new System.Drawing.Point(84, 17);
            this.tbNumberFilter.Name = "tbNumberFilter";
            this.tbNumberFilter.Size = new System.Drawing.Size(100, 20);
            this.tbNumberFilter.TabIndex = 29;
            this.tbNumberFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeric_KeyPress);
            // 
            // tbTorqueFilter
            // 
            this.tbTorqueFilter.Location = new System.Drawing.Point(572, 43);
            this.tbTorqueFilter.Name = "tbTorqueFilter";
            this.tbTorqueFilter.Size = new System.Drawing.Size(67, 20);
            this.tbTorqueFilter.TabIndex = 28;
            this.tbTorqueFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTorqueFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeric_KeyPress);
            // 
            // lTorqueFilter
            // 
            this.lTorqueFilter.AutoSize = true;
            this.lTorqueFilter.Location = new System.Drawing.Point(519, 46);
            this.lTorqueFilter.Name = "lTorqueFilter";
            this.lTorqueFilter.Size = new System.Drawing.Size(47, 13);
            this.lTorqueFilter.TabIndex = 27;
            this.lTorqueFilter.Text = "Момент";
            // 
            // pPrint
            // 
            this.pPrint.Controls.Add(this.progressBar);
            this.pPrint.Controls.Add(this.bPrint);
            this.pPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.pPrint.Location = new System.Drawing.Point(881, 16);
            this.pPrint.Name = "pPrint";
            this.pPrint.Size = new System.Drawing.Size(100, 81);
            this.pPrint.TabIndex = 25;
            // 
            // cbStatusFilter
            // 
            this.cbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusFilter.FormattingEnabled = true;
            this.cbStatusFilter.Location = new System.Drawing.Point(260, 43);
            this.cbStatusFilter.Name = "cbStatusFilter";
            this.cbStatusFilter.Size = new System.Drawing.Size(235, 21);
            this.cbStatusFilter.TabIndex = 24;
            this.cbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.UpdateDataGrid);
            // 
            // lPitchFilter
            // 
            this.lPitchFilter.AutoSize = true;
            this.lPitchFilter.Location = new System.Drawing.Point(534, 20);
            this.lPitchFilter.Name = "lPitchFilter";
            this.lPitchFilter.Size = new System.Drawing.Size(32, 13);
            this.lPitchFilter.TabIndex = 23;
            this.lPitchFilter.Text = "Пост";
            // 
            // lCardFilter
            // 
            this.lCardFilter.AutoSize = true;
            this.lCardFilter.Location = new System.Drawing.Point(37, 72);
            this.lCardFilter.Name = "lCardFilter";
            this.lCardFilter.Size = new System.Drawing.Size(41, 13);
            this.lCardFilter.TabIndex = 22;
            this.lCardFilter.Text = "Гамма";
            // 
            // tbSerialNumberFilter
            // 
            this.tbSerialNumberFilter.Location = new System.Drawing.Point(84, 43);
            this.tbSerialNumberFilter.Name = "tbSerialNumberFilter";
            this.tbSerialNumberFilter.Size = new System.Drawing.Size(100, 20);
            this.tbSerialNumberFilter.TabIndex = 21;
            // 
            // cbModelFilter
            // 
            this.cbModelFilter.FormattingEnabled = true;
            this.cbModelFilter.Location = new System.Drawing.Point(260, 70);
            this.cbModelFilter.Name = "cbModelFilter";
            this.cbModelFilter.Size = new System.Drawing.Size(235, 21);
            this.cbModelFilter.TabIndex = 20;
            this.cbModelFilter.SelectedIndexChanged += new System.EventHandler(this.UpdateDataGrid);
            this.cbModelFilter.TextChanged += new System.EventHandler(this.cbModelFilter_TextChanged);
            // 
            // lSerialNumberFilter
            // 
            this.lSerialNumberFilter.AutoSize = true;
            this.lSerialNumberFilter.Location = new System.Drawing.Point(6, 48);
            this.lSerialNumberFilter.Name = "lSerialNumberFilter";
            this.lSerialNumberFilter.Size = new System.Drawing.Size(72, 13);
            this.lSerialNumberFilter.TabIndex = 19;
            this.lSerialNumberFilter.Text = "Серийный №";
            // 
            // lStatusFilter
            // 
            this.lStatusFilter.AutoSize = true;
            this.lStatusFilter.Location = new System.Drawing.Point(213, 46);
            this.lStatusFilter.Name = "lStatusFilter";
            this.lStatusFilter.Size = new System.Drawing.Size(41, 13);
            this.lStatusFilter.TabIndex = 19;
            this.lStatusFilter.Text = "Статус";
            // 
            // lModelFilter
            // 
            this.lModelFilter.AutoSize = true;
            this.lModelFilter.Location = new System.Drawing.Point(208, 73);
            this.lModelFilter.Name = "lModelFilter";
            this.lModelFilter.Size = new System.Drawing.Size(46, 13);
            this.lModelFilter.TabIndex = 19;
            this.lModelFilter.Text = "Модель";
            // 
            // lNmFilter
            // 
            this.lNmFilter.AutoSize = true;
            this.lNmFilter.Location = new System.Drawing.Point(645, 46);
            this.lNmFilter.Name = "lNmFilter";
            this.lNmFilter.Size = new System.Drawing.Size(23, 13);
            this.lNmFilter.TabIndex = 2;
            this.lNmFilter.Text = "Нм";
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.cbToolReplace);
            this.gbEdit.Controls.Add(this.lToolReplace);
            this.gbEdit.Controls.Add(this.lCardName);
            this.gbEdit.Controls.Add(this.lCardNumber);
            this.gbEdit.Controls.Add(this.tbCardName);
            this.gbEdit.Controls.Add(this.tbCardNumber);
            this.gbEdit.Controls.Add(this.lTorqueError);
            this.gbEdit.Controls.Add(this.cbStatus);
            this.gbEdit.Controls.Add(this.bSetTorque);
            this.gbEdit.Controls.Add(this.bShowCard);
            this.gbEdit.Controls.Add(this.tbNumber);
            this.gbEdit.Controls.Add(this.tbSerialNumber);
            this.gbEdit.Controls.Add(this.cbToolType);
            this.gbEdit.Controls.Add(this.tbTorque);
            this.gbEdit.Controls.Add(this.cbPitch);
            this.gbEdit.Controls.Add(this.lNumber);
            this.gbEdit.Controls.Add(this.cbCards);
            this.gbEdit.Controls.Add(this.lSerialNumber);
            this.gbEdit.Controls.Add(this.lStatus);
            this.gbEdit.Controls.Add(this.lToolType);
            this.gbEdit.Controls.Add(this.lCard);
            this.gbEdit.Controls.Add(this.lPitch);
            this.gbEdit.Controls.Add(this.lNm);
            this.gbEdit.Controls.Add(this.lName);
            this.gbEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbEdit.Location = new System.Drawing.Point(0, 399);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(984, 125);
            this.gbEdit.TabIndex = 21;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Параметры инструмента";
            // 
            // cbToolReplace
            // 
            this.cbToolReplace.FormattingEnabled = true;
            this.cbToolReplace.Location = new System.Drawing.Point(404, 101);
            this.cbToolReplace.Name = "cbToolReplace";
            this.cbToolReplace.Size = new System.Drawing.Size(243, 21);
            this.cbToolReplace.TabIndex = 29;
            this.cbToolReplace.Visible = false;
            this.cbToolReplace.SelectedIndexChanged += new System.EventHandler(this.ToolParamaterChanged);
            this.cbToolReplace.TextChanged += new System.EventHandler(this.cbToolReplace_TextChanged);
            // 
            // lToolReplace
            // 
            this.lToolReplace.AutoSize = true;
            this.lToolReplace.Location = new System.Drawing.Point(326, 101);
            this.lToolReplace.Name = "lToolReplace";
            this.lToolReplace.Size = new System.Drawing.Size(72, 13);
            this.lToolReplace.TabIndex = 28;
            this.lToolReplace.Text = "Заменить на";
            this.lToolReplace.Visible = false;
            // 
            // lCardName
            // 
            this.lCardName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lCardName.AutoSize = true;
            this.lCardName.Location = new System.Drawing.Point(519, 48);
            this.lCardName.Name = "lCardName";
            this.lCardName.Size = new System.Drawing.Size(57, 13);
            this.lCardName.TabIndex = 27;
            this.lCardName.Text = "Название";
            // 
            // lCardNumber
            // 
            this.lCardNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lCardNumber.AutoSize = true;
            this.lCardNumber.Location = new System.Drawing.Point(401, 48);
            this.lCardNumber.Name = "lCardNumber";
            this.lCardNumber.Size = new System.Drawing.Size(18, 13);
            this.lCardNumber.TabIndex = 27;
            this.lCardNumber.Text = "№";
            // 
            // tbCardName
            // 
            this.tbCardName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCardName.Location = new System.Drawing.Point(582, 44);
            this.tbCardName.Name = "tbCardName";
            this.tbCardName.Size = new System.Drawing.Size(396, 20);
            this.tbCardName.TabIndex = 26;
            this.tbCardName.TextChanged += new System.EventHandler(this.ToolParamaterChanged);
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCardNumber.Location = new System.Drawing.Point(425, 45);
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.Size = new System.Drawing.Size(76, 20);
            this.tbCardNumber.TabIndex = 26;
            this.tbCardNumber.TextChanged += new System.EventHandler(this.ToolParamaterChanged);
            // 
            // lTorqueError
            // 
            this.lTorqueError.AllowDrop = true;
            this.lTorqueError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lTorqueError.ForeColor = System.Drawing.Color.Red;
            this.lTorqueError.Location = new System.Drawing.Point(413, 100);
            this.lTorqueError.Name = "lTorqueError";
            this.lTorqueError.Size = new System.Drawing.Size(565, 22);
            this.lTorqueError.TabIndex = 25;
            this.lTorqueError.Text = "Ошибка момента";
            this.lTorqueError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(84, 98);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(212, 21);
            this.cbStatus.TabIndex = 24;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.ToolParamaterChanged);
            // 
            // bSetTorque
            // 
            this.bSetTorque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSetTorque.Location = new System.Drawing.Point(511, 70);
            this.bSetTorque.Name = "bSetTorque";
            this.bSetTorque.Size = new System.Drawing.Size(136, 23);
            this.bSetTorque.TabIndex = 13;
            this.bSetTorque.Text = "Установить из гаммы";
            this.bSetTorque.UseVisualStyleBackColor = true;
            this.bSetTorque.Click += new System.EventHandler(this.bSetTorque_Click);
            // 
            // bShowCard
            // 
            this.bShowCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bShowCard.Location = new System.Drawing.Point(909, 16);
            this.bShowCard.Name = "bShowCard";
            this.bShowCard.Size = new System.Drawing.Size(69, 23);
            this.bShowCard.TabIndex = 12;
            this.bShowCard.Text = "Открыть";
            this.bShowCard.UseVisualStyleBackColor = true;
            this.bShowCard.Click += new System.EventHandler(this.bShowCard_Click);
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(37, 101);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(41, 13);
            this.lStatus.TabIndex = 19;
            this.lStatus.Text = "Статус";
            // 
            // lNm
            // 
            this.lNm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lNm.AutoSize = true;
            this.lNm.Location = new System.Drawing.Point(482, 76);
            this.lNm.Name = "lNm";
            this.lNm.Size = new System.Drawing.Size(23, 13);
            this.lNm.TabIndex = 2;
            this.lNm.Text = "Нм";
            // 
            // bCheckHistory
            // 
            this.bCheckHistory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bCheckHistory.Location = new System.Drawing.Point(522, 2);
            this.bCheckHistory.Name = "bCheckHistory";
            this.bCheckHistory.Size = new System.Drawing.Size(240, 32);
            this.bCheckHistory.TabIndex = 26;
            this.bCheckHistory.Text = "История проверок";
            this.bCheckHistory.UseVisualStyleBackColor = true;
            this.bCheckHistory.Click += new System.EventHandler(this.bCheckHistory_Click);
            // 
            // pButtons
            // 
            this.pButtons.Controls.Add(this.bMovements);
            this.pButtons.Controls.Add(this.bCheckHistory);
            this.pButtons.Controls.Add(this.bAdd);
            this.pButtons.Controls.Add(this.bUpdate);
            this.pButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButtons.Location = new System.Drawing.Point(0, 524);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(984, 37);
            this.pButtons.TabIndex = 22;
            // 
            // bMovements
            // 
            this.bMovements.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bMovements.Location = new System.Drawing.Point(236, 2);
            this.bMovements.Name = "bMovements";
            this.bMovements.Size = new System.Drawing.Size(240, 32);
            this.bMovements.TabIndex = 26;
            this.bMovements.Text = "История перемещений";
            this.bMovements.UseVisualStyleBackColor = true;
            this.bMovements.Click += new System.EventHandler(this.bMovements_Click);
            // 
            // ScrewingToolForm
            // 
            this.AcceptButton = this.bFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dgTools);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.pButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "ScrewingToolForm";
            this.Text = "Инструменты завинчивания";
            this.Load += new System.EventHandler(this.ToolForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTools)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.pPrint.ResumeLayout(false);
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.pButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTools;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbTorque;
        private System.Windows.Forms.Label lNumber;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bFind;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.ComboBox cbCards;
        private System.Windows.Forms.Label lCard;
        private System.Windows.Forms.ComboBox cbPitch;
        private System.Windows.Forms.Label lPitch;
        private System.Windows.Forms.ComboBox cbToolType;
        private System.Windows.Forms.Label lToolType;
        private System.Windows.Forms.TextBox tbSerialNumber;
        private System.Windows.Forms.Label lSerialNumber;
        private System.Windows.Forms.ComboBox cbToolTypeFilter;
        private System.Windows.Forms.ComboBox cbCardFilter;
        private System.Windows.Forms.ComboBox cbPitchFilter;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button bResetFilter;
        private System.Windows.Forms.Label lToolNumberFilter;
        private System.Windows.Forms.Label lTollTypeFilter;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.ComboBox cbModelFilter;
        private System.Windows.Forms.Label lSerialNumberFilter;
        private System.Windows.Forms.Label lModelFilter;
        private System.Windows.Forms.TextBox tbSerialNumberFilter;
        private System.Windows.Forms.Label lCardFilter;
        private System.Windows.Forms.Label lPitchFilter;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.Button bShowCard;
        private System.Windows.Forms.Button bSetTorque;
        private System.Windows.Forms.Label lNm;
        private System.Windows.Forms.ComboBox cbStatusFilter;
        private System.Windows.Forms.Label lStatusFilter;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Panel pPrint;
        private System.Windows.Forms.TextBox tbTorqueFilter;
        private System.Windows.Forms.Label lTorqueFilter;
        private System.Windows.Forms.Label lNmFilter;
        private System.Windows.Forms.Label lTorqueError;
        private System.Windows.Forms.Button bCheckHistory;
        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.TextBox tbNumberFilter;
        private System.Windows.Forms.Label lCardNumber;
        private System.Windows.Forms.TextBox tbCardNumber;
        private System.Windows.Forms.Label lCardName;
        private System.Windows.Forms.TextBox tbCardName;
        private System.Windows.Forms.CheckBox cbAnomaly;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lToolReplace;
        private System.Windows.Forms.ComboBox cbToolReplace;
        private System.Windows.Forms.Button bToolType;
        private System.Windows.Forms.Button bMovements;
    }
}