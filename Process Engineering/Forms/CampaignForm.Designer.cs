namespace Process_Engineering.Forms
{
    partial class CampaignForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CampaignForm));
            this.dgCampaigns = new System.Windows.Forms.DataGridView();
            this.bClose = new System.Windows.Forms.Button();
            this.lCount = new System.Windows.Forms.Label();
            this.cbBLM = new System.Windows.Forms.ComboBox();
            this.lBLM = new System.Windows.Forms.Label();
            this.cbSector = new System.Windows.Forms.ComboBox();
            this.lSector = new System.Windows.Forms.Label();
            this.cbToolType = new System.Windows.Forms.ComboBox();
            this.lToolType = new System.Windows.Forms.Label();
            this.bUnload = new System.Windows.Forms.Button();
            this.bUploadResults = new System.Windows.Forms.Button();
            this.gbCampaign = new System.Windows.Forms.GroupBox();
            this.bGetResult = new System.Windows.Forms.Button();
            this.bSensors = new System.Windows.Forms.Button();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.bReset = new System.Windows.Forms.Button();
            this.lBlmFilter = new System.Windows.Forms.Label();
            this.cbUserFilter = new System.Windows.Forms.ComboBox();
            this.cbToolTypeFilter = new System.Windows.Forms.ComboBox();
            this.cbSectorFilter = new System.Windows.Forms.ComboBox();
            this.cbBlmFilter = new System.Windows.Forms.ComboBox();
            this.lSectorFilter = new System.Windows.Forms.Label();
            this.lUserFilter = new System.Windows.Forms.Label();
            this.lToolTypeFilter = new System.Windows.Forms.Label();
            this.bDelete = new System.Windows.Forms.Button();
            this.bToolCheck = new System.Windows.Forms.Button();
            this.bUnloadAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCampaigns)).BeginInit();
            this.gbCampaign.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgCampaigns
            // 
            this.dgCampaigns.AllowUserToAddRows = false;
            this.dgCampaigns.AllowUserToDeleteRows = false;
            this.dgCampaigns.AllowUserToResizeColumns = false;
            this.dgCampaigns.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCampaigns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCampaigns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCampaigns.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgCampaigns.EnableHeadersVisualStyles = false;
            this.dgCampaigns.Location = new System.Drawing.Point(12, 132);
            this.dgCampaigns.Name = "dgCampaigns";
            this.dgCampaigns.RowHeadersVisible = false;
            this.dgCampaigns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCampaigns.Size = new System.Drawing.Size(760, 232);
            this.dgCampaigns.TabIndex = 0;
            this.dgCampaigns.SelectionChanged += new System.EventHandler(this.dgTools_SelectionChanged);
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.Location = new System.Drawing.Point(696, 370);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(76, 25);
            this.bClose.TabIndex = 5;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // lCount
            // 
            this.lCount.Location = new System.Drawing.Point(678, 36);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(100, 20);
            this.lCount.TabIndex = 8;
            this.lCount.Text = "Найдено: 0 шт.";
            this.lCount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // cbBLM
            // 
            this.cbBLM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBLM.FormattingEnabled = true;
            this.cbBLM.Location = new System.Drawing.Point(5, 32);
            this.cbBLM.Name = "cbBLM";
            this.cbBLM.Size = new System.Drawing.Size(85, 21);
            this.cbBLM.TabIndex = 9;
            // 
            // lBLM
            // 
            this.lBLM.AutoSize = true;
            this.lBLM.Location = new System.Drawing.Point(29, 16);
            this.lBLM.Name = "lBLM";
            this.lBLM.Size = new System.Drawing.Size(29, 13);
            this.lBLM.TabIndex = 10;
            this.lBLM.Text = "BLM";
            // 
            // cbSector
            // 
            this.cbSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSector.FormattingEnabled = true;
            this.cbSector.Location = new System.Drawing.Point(96, 32);
            this.cbSector.Name = "cbSector";
            this.cbSector.Size = new System.Drawing.Size(89, 21);
            this.cbSector.TabIndex = 11;
            // 
            // lSector
            // 
            this.lSector.AutoSize = true;
            this.lSector.Location = new System.Drawing.Point(114, 16);
            this.lSector.Name = "lSector";
            this.lSector.Size = new System.Drawing.Size(49, 13);
            this.lSector.TabIndex = 10;
            this.lSector.Text = "Участок";
            // 
            // cbToolType
            // 
            this.cbToolType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbToolType.FormattingEnabled = true;
            this.cbToolType.Location = new System.Drawing.Point(191, 32);
            this.cbToolType.Name = "cbToolType";
            this.cbToolType.Size = new System.Drawing.Size(232, 21);
            this.cbToolType.TabIndex = 12;
            // 
            // lToolType
            // 
            this.lToolType.AutoSize = true;
            this.lToolType.Location = new System.Drawing.Point(263, 16);
            this.lToolType.Name = "lToolType";
            this.lToolType.Size = new System.Drawing.Size(94, 13);
            this.lToolType.TabIndex = 10;
            this.lToolType.Text = "Тип инструмента";
            // 
            // bUnload
            // 
            this.bUnload.Location = new System.Drawing.Point(429, 12);
            this.bUnload.Name = "bUnload";
            this.bUnload.Size = new System.Drawing.Size(171, 41);
            this.bUnload.TabIndex = 13;
            this.bUnload.Text = "Выгрузить новую кампанию";
            this.bUnload.UseVisualStyleBackColor = true;
            this.bUnload.Click += new System.EventHandler(this.bUnload_Click);
            // 
            // bUploadResults
            // 
            this.bUploadResults.Location = new System.Drawing.Point(606, 12);
            this.bUploadResults.Name = "bUploadResults";
            this.bUploadResults.Size = new System.Drawing.Size(172, 41);
            this.bUploadResults.TabIndex = 14;
            this.bUploadResults.Text = "Загрузить результаты";
            this.bUploadResults.UseVisualStyleBackColor = true;
            this.bUploadResults.Click += new System.EventHandler(this.bUploadResults_Click);
            // 
            // gbCampaign
            // 
            this.gbCampaign.Controls.Add(this.lBLM);
            this.gbCampaign.Controls.Add(this.bUploadResults);
            this.gbCampaign.Controls.Add(this.cbBLM);
            this.gbCampaign.Controls.Add(this.bUnload);
            this.gbCampaign.Controls.Add(this.lSector);
            this.gbCampaign.Controls.Add(this.cbToolType);
            this.gbCampaign.Controls.Add(this.lToolType);
            this.gbCampaign.Controls.Add(this.cbSector);
            this.gbCampaign.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCampaign.Location = new System.Drawing.Point(0, 0);
            this.gbCampaign.Name = "gbCampaign";
            this.gbCampaign.Size = new System.Drawing.Size(784, 61);
            this.gbCampaign.TabIndex = 15;
            this.gbCampaign.TabStop = false;
            this.gbCampaign.Text = "Загрузка кампаний";
            // 
            // bGetResult
            // 
            this.bGetResult.Location = new System.Drawing.Point(596, 370);
            this.bGetResult.Name = "bGetResult";
            this.bGetResult.Size = new System.Drawing.Size(94, 25);
            this.bGetResult.TabIndex = 16;
            this.bGetResult.Text = "Отчет";
            this.bGetResult.UseVisualStyleBackColor = true;
            this.bGetResult.Click += new System.EventHandler(this.bGetResult_Click);
            // 
            // bSensors
            // 
            this.bSensors.Location = new System.Drawing.Point(12, 370);
            this.bSensors.Name = "bSensors";
            this.bSensors.Size = new System.Drawing.Size(75, 25);
            this.bSensors.TabIndex = 17;
            this.bSensors.Text = "Датчики";
            this.bSensors.UseVisualStyleBackColor = true;
            this.bSensors.Click += new System.EventHandler(this.bSensors_Click);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.cbDate);
            this.gbFilter.Controls.Add(this.dtPicker);
            this.gbFilter.Controls.Add(this.bReset);
            this.gbFilter.Controls.Add(this.lBlmFilter);
            this.gbFilter.Controls.Add(this.cbUserFilter);
            this.gbFilter.Controls.Add(this.cbToolTypeFilter);
            this.gbFilter.Controls.Add(this.cbSectorFilter);
            this.gbFilter.Controls.Add(this.cbBlmFilter);
            this.gbFilter.Controls.Add(this.lSectorFilter);
            this.gbFilter.Controls.Add(this.lUserFilter);
            this.gbFilter.Controls.Add(this.lCount);
            this.gbFilter.Controls.Add(this.lToolTypeFilter);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFilter.Location = new System.Drawing.Point(0, 61);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(784, 65);
            this.gbFilter.TabIndex = 18;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Фильтр";
            // 
            // cbDate
            // 
            this.cbDate.AutoSize = true;
            this.cbDate.Location = new System.Drawing.Point(64, 17);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(90, 17);
            this.cbDate.TabIndex = 13;
            this.cbDate.Text = "Дата начала";
            this.cbDate.UseVisualStyleBackColor = true;
            this.cbDate.CheckedChanged += new System.EventHandler(this.FilterParameterChanged);
            // 
            // dtPicker
            // 
            this.dtPicker.Enabled = false;
            this.dtPicker.Location = new System.Drawing.Point(12, 35);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(142, 20);
            this.dtPicker.TabIndex = 12;
            this.dtPicker.ValueChanged += new System.EventHandler(this.FilterParameterChanged);
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(697, 11);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(75, 23);
            this.bReset.TabIndex = 11;
            this.bReset.Text = "Очистить";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // lBlmFilter
            // 
            this.lBlmFilter.AutoSize = true;
            this.lBlmFilter.Location = new System.Drawing.Point(183, 18);
            this.lBlmFilter.Name = "lBlmFilter";
            this.lBlmFilter.Size = new System.Drawing.Size(29, 13);
            this.lBlmFilter.TabIndex = 10;
            this.lBlmFilter.Text = "BLM";
            // 
            // cbUserFilter
            // 
            this.cbUserFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserFilter.FormattingEnabled = true;
            this.cbUserFilter.Location = new System.Drawing.Point(507, 34);
            this.cbUserFilter.Name = "cbUserFilter";
            this.cbUserFilter.Size = new System.Drawing.Size(161, 21);
            this.cbUserFilter.TabIndex = 9;
            this.cbUserFilter.SelectedIndexChanged += new System.EventHandler(this.FilterParameterChanged);
            // 
            // cbToolTypeFilter
            // 
            this.cbToolTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbToolTypeFilter.FormattingEnabled = true;
            this.cbToolTypeFilter.Location = new System.Drawing.Point(323, 34);
            this.cbToolTypeFilter.Name = "cbToolTypeFilter";
            this.cbToolTypeFilter.Size = new System.Drawing.Size(178, 21);
            this.cbToolTypeFilter.TabIndex = 9;
            this.cbToolTypeFilter.SelectedIndexChanged += new System.EventHandler(this.FilterParameterChanged);
            // 
            // cbSectorFilter
            // 
            this.cbSectorFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSectorFilter.FormattingEnabled = true;
            this.cbSectorFilter.Location = new System.Drawing.Point(240, 34);
            this.cbSectorFilter.Name = "cbSectorFilter";
            this.cbSectorFilter.Size = new System.Drawing.Size(77, 21);
            this.cbSectorFilter.TabIndex = 9;
            this.cbSectorFilter.SelectedIndexChanged += new System.EventHandler(this.FilterParameterChanged);
            // 
            // cbBlmFilter
            // 
            this.cbBlmFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBlmFilter.FormattingEnabled = true;
            this.cbBlmFilter.Location = new System.Drawing.Point(160, 34);
            this.cbBlmFilter.Name = "cbBlmFilter";
            this.cbBlmFilter.Size = new System.Drawing.Size(74, 21);
            this.cbBlmFilter.TabIndex = 9;
            this.cbBlmFilter.SelectedIndexChanged += new System.EventHandler(this.FilterParameterChanged);
            // 
            // lSectorFilter
            // 
            this.lSectorFilter.AutoSize = true;
            this.lSectorFilter.Location = new System.Drawing.Point(258, 18);
            this.lSectorFilter.Name = "lSectorFilter";
            this.lSectorFilter.Size = new System.Drawing.Size(49, 13);
            this.lSectorFilter.TabIndex = 10;
            this.lSectorFilter.Text = "Участок";
            // 
            // lUserFilter
            // 
            this.lUserFilter.AutoSize = true;
            this.lUserFilter.Location = new System.Drawing.Point(545, 18);
            this.lUserFilter.Name = "lUserFilter";
            this.lUserFilter.Size = new System.Drawing.Size(74, 13);
            this.lUserFilter.TabIndex = 10;
            this.lUserFilter.Text = "Исполнитель";
            // 
            // lToolTypeFilter
            // 
            this.lToolTypeFilter.AutoSize = true;
            this.lToolTypeFilter.Location = new System.Drawing.Point(361, 18);
            this.lToolTypeFilter.Name = "lToolTypeFilter";
            this.lToolTypeFilter.Size = new System.Drawing.Size(94, 13);
            this.lToolTypeFilter.TabIndex = 10;
            this.lToolTypeFilter.Text = "Тип инструмента";
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(427, 370);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(89, 25);
            this.bDelete.TabIndex = 19;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bToolCheck
            // 
            this.bToolCheck.Location = new System.Drawing.Point(291, 370);
            this.bToolCheck.Name = "bToolCheck";
            this.bToolCheck.Size = new System.Drawing.Size(130, 25);
            this.bToolCheck.TabIndex = 20;
            this.bToolCheck.Text = "Результаты проверки";
            this.bToolCheck.UseVisualStyleBackColor = true;
            this.bToolCheck.Click += new System.EventHandler(this.bToolCheck_Click);
            // 
            // bUnloadAgain
            // 
            this.bUnloadAgain.Location = new System.Drawing.Point(160, 370);
            this.bUnloadAgain.Name = "bUnloadAgain";
            this.bUnloadAgain.Size = new System.Drawing.Size(125, 25);
            this.bUnloadAgain.TabIndex = 21;
            this.bUnloadAgain.Text = "Выгрузить повторно";
            this.bUnloadAgain.UseVisualStyleBackColor = true;
            this.bUnloadAgain.Click += new System.EventHandler(this.bUnloadAgain_Click);
            // 
            // CampaignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 406);
            this.Controls.Add(this.bUnloadAgain);
            this.Controls.Add(this.bToolCheck);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.bSensors);
            this.Controls.Add(this.bGetResult);
            this.Controls.Add(this.gbCampaign);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.dgCampaigns);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 445);
            this.MinimumSize = new System.Drawing.Size(800, 445);
            this.Name = "CampaignForm";
            this.Text = "Поверка инструментов";
            this.Load += new System.EventHandler(this.ToolForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCampaigns)).EndInit();
            this.gbCampaign.ResumeLayout(false);
            this.gbCampaign.PerformLayout();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCampaigns;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.ComboBox cbBLM;
        private System.Windows.Forms.Label lBLM;
        private System.Windows.Forms.ComboBox cbSector;
        private System.Windows.Forms.Label lSector;
        private System.Windows.Forms.ComboBox cbToolType;
        private System.Windows.Forms.Label lToolType;
        private System.Windows.Forms.Button bUnload;
        private System.Windows.Forms.Button bUploadResults;
        private System.Windows.Forms.GroupBox gbCampaign;
        private System.Windows.Forms.Button bGetResult;
        private System.Windows.Forms.Button bSensors;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.ComboBox cbToolTypeFilter;
        private System.Windows.Forms.ComboBox cbSectorFilter;
        private System.Windows.Forms.ComboBox cbBlmFilter;
        private System.Windows.Forms.Label lBlmFilter;
        private System.Windows.Forms.Label lSectorFilter;
        private System.Windows.Forms.Label lToolTypeFilter;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.ComboBox cbUserFilter;
        private System.Windows.Forms.Label lUserFilter;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bToolCheck;
        private System.Windows.Forms.Button bUnloadAgain;
    }
}