namespace Process_Engineering.Forms
{
    partial class ScrewingToolTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrewingToolTypeForm));
            this.dgTools = new System.Windows.Forms.DataGridView();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.lNumber = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.bFind = new System.Windows.Forms.Button();
            this.lCount = new System.Windows.Forms.Label();
            this.lType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbTolerance = new System.Windows.Forms.TextBox();
            this.tbMinTorque = new System.Windows.Forms.TextBox();
            this.tbMaxTorque = new System.Windows.Forms.TextBox();
            this.lTolerance = new System.Windows.Forms.Label();
            this.lMinTorque = new System.Windows.Forms.Label();
            this.lMaxTorque = new System.Windows.Forms.Label();
            this.cbTool = new System.Windows.Forms.ComboBox();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.lBrand = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.bClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTools)).BeginInit();
            this.gbEdit.SuspendLayout();
            this.gbFilter.SuspendLayout();
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
            this.dgTools.Location = new System.Drawing.Point(0, 49);
            this.dgTools.Name = "dgTools";
            this.dgTools.RowHeadersVisible = false;
            this.dgTools.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTools.Size = new System.Drawing.Size(884, 350);
            this.dgTools.TabIndex = 0;
            this.dgTools.SelectionChanged += new System.EventHandler(this.dgTools_SelectionChanged);
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(274, 46);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(140, 20);
            this.tbModel.TabIndex = 1;
            this.tbModel.TextChanged += new System.EventHandler(this.toolTypeParameterChanged);
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Location = new System.Drawing.Point(12, 22);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(41, 13);
            this.lNumber.TabIndex = 2;
            this.lNumber.Text = "Номер";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(222, 49);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(46, 13);
            this.lName.TabIndex = 2;
            this.lName.Text = "Модель";
            // 
            // bUpdate
            // 
            this.bUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bUpdate.Location = new System.Drawing.Point(6, 83);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(193, 23);
            this.bUpdate.TabIndex = 3;
            this.bUpdate.Text = "Принять изменения";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAdd.Location = new System.Drawing.Point(618, 83);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(178, 23);
            this.bAdd.TabIndex = 4;
            this.bAdd.Text = "Добавить новый инструмент";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.Location = new System.Drawing.Point(802, 82);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(76, 24);
            this.bClose.TabIndex = 5;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bFind
            // 
            this.bFind.Location = new System.Drawing.Point(316, 16);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(75, 23);
            this.bFind.TabIndex = 7;
            this.bFind.Text = "Найти";
            this.bFind.UseVisualStyleBackColor = true;
            this.bFind.Click += new System.EventHandler(this.updateDataGrid);
            // 
            // lCount
            // 
            this.lCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lCount.Location = new System.Drawing.Point(778, 26);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(100, 20);
            this.lCount.TabIndex = 8;
            this.lCount.Text = "Найдено: 0 шт.";
            this.lCount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(619, 22);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(26, 13);
            this.lType.TabIndex = 2;
            this.lType.Text = "Тип";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(651, 19);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(221, 21);
            this.cbType.TabIndex = 9;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.toolTypeParameterChanged);
            // 
            // tbTolerance
            // 
            this.tbTolerance.Location = new System.Drawing.Point(807, 46);
            this.tbTolerance.Name = "tbTolerance";
            this.tbTolerance.Size = new System.Drawing.Size(65, 20);
            this.tbTolerance.TabIndex = 10;
            this.tbTolerance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTolerance.TextChanged += new System.EventHandler(this.toolTypeParameterChanged);
            this.tbTolerance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxbToolParameter_KeyPress);
            // 
            // tbMinTorque
            // 
            this.tbMinTorque.Location = new System.Drawing.Point(513, 47);
            this.tbMinTorque.Name = "tbMinTorque";
            this.tbMinTorque.Size = new System.Drawing.Size(65, 20);
            this.tbMinTorque.TabIndex = 10;
            this.tbMinTorque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMinTorque.TextChanged += new System.EventHandler(this.toolTypeParameterChanged);
            this.tbMinTorque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxbToolParameter_KeyPress);
            // 
            // tbMaxTorque
            // 
            this.tbMaxTorque.Location = new System.Drawing.Point(662, 46);
            this.tbMaxTorque.Name = "tbMaxTorque";
            this.tbMaxTorque.Size = new System.Drawing.Size(65, 20);
            this.tbMaxTorque.TabIndex = 10;
            this.tbMaxTorque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMaxTorque.TextChanged += new System.EventHandler(this.toolTypeParameterChanged);
            this.tbMaxTorque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxbToolParameter_KeyPress);
            // 
            // lTolerance
            // 
            this.lTolerance.AutoSize = true;
            this.lTolerance.Location = new System.Drawing.Point(733, 50);
            this.lTolerance.Name = "lTolerance";
            this.lTolerance.Size = new System.Drawing.Size(68, 13);
            this.lTolerance.TabIndex = 11;
            this.lTolerance.Text = "Точность, %";
            // 
            // lMinTorque
            // 
            this.lMinTorque.AutoSize = true;
            this.lMinTorque.Location = new System.Drawing.Point(438, 50);
            this.lMinTorque.Name = "lMinTorque";
            this.lMinTorque.Size = new System.Drawing.Size(69, 13);
            this.lMinTorque.TabIndex = 11;
            this.lMinTorque.Text = "MIN момент";
            // 
            // lMaxTorque
            // 
            this.lMaxTorque.AutoSize = true;
            this.lMaxTorque.Location = new System.Drawing.Point(584, 50);
            this.lMaxTorque.Name = "lMaxTorque";
            this.lMaxTorque.Size = new System.Drawing.Size(72, 13);
            this.lMaxTorque.TabIndex = 11;
            this.lMaxTorque.Text = "MAX момент";
            // 
            // cbTool
            // 
            this.cbTool.FormattingEnabled = true;
            this.cbTool.Location = new System.Drawing.Point(59, 19);
            this.cbTool.Name = "cbTool";
            this.cbTool.Size = new System.Drawing.Size(441, 21);
            this.cbTool.TabIndex = 12;
            this.cbTool.SelectedIndexChanged += new System.EventHandler(this.toolTypeParameterChanged);
            this.cbTool.TextChanged += new System.EventHandler(this.cbTool_TextChanged);
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.cbBrand);
            this.gbEdit.Controls.Add(this.lBrand);
            this.gbEdit.Controls.Add(this.lNumber);
            this.gbEdit.Controls.Add(this.cbTool);
            this.gbEdit.Controls.Add(this.tbModel);
            this.gbEdit.Controls.Add(this.lMaxTorque);
            this.gbEdit.Controls.Add(this.bClose);
            this.gbEdit.Controls.Add(this.lName);
            this.gbEdit.Controls.Add(this.bAdd);
            this.gbEdit.Controls.Add(this.bUpdate);
            this.gbEdit.Controls.Add(this.lMinTorque);
            this.gbEdit.Controls.Add(this.lType);
            this.gbEdit.Controls.Add(this.lTolerance);
            this.gbEdit.Controls.Add(this.cbType);
            this.gbEdit.Controls.Add(this.tbMaxTorque);
            this.gbEdit.Controls.Add(this.tbTolerance);
            this.gbEdit.Controls.Add(this.tbMinTorque);
            this.gbEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbEdit.Location = new System.Drawing.Point(0, 399);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(884, 112);
            this.gbEdit.TabIndex = 13;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Параметры инструмента";
            // 
            // cbBrand
            // 
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(59, 46);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(140, 21);
            this.cbBrand.TabIndex = 14;
            this.cbBrand.TextChanged += new System.EventHandler(this.toolTypeParameterChanged);
            // 
            // lBrand
            // 
            this.lBrand.AutoSize = true;
            this.lBrand.Location = new System.Drawing.Point(15, 49);
            this.lBrand.Name = "lBrand";
            this.lBrand.Size = new System.Drawing.Size(38, 13);
            this.lBrand.TabIndex = 13;
            this.lBrand.Text = "Бренд";
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.bClear);
            this.gbFilter.Controls.Add(this.tbFilter);
            this.gbFilter.Controls.Add(this.lCount);
            this.gbFilter.Controls.Add(this.bFind);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(884, 49);
            this.gbFilter.TabIndex = 14;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Фильтр";
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(15, 19);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(295, 20);
            this.tbFilter.TabIndex = 9;
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(397, 17);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 10;
            this.bClear.Text = "Очистить";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.updateDataGrid);
            // 
            // ScrewingToolTypeForm
            // 
            this.AcceptButton = this.bFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.dgTools);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.gbEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "ScrewingToolTypeForm";
            this.Text = "Виды завинчивающих инструментов";
            this.Load += new System.EventHandler(this.ToolForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTools)).EndInit();
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTools;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label lNumber;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bFind;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox tbTolerance;
        private System.Windows.Forms.TextBox tbMinTorque;
        private System.Windows.Forms.TextBox tbMaxTorque;
        private System.Windows.Forms.Label lTolerance;
        private System.Windows.Forms.Label lMinTorque;
        private System.Windows.Forms.Label lMaxTorque;
        private System.Windows.Forms.ComboBox cbTool;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.Label lBrand;
        private System.Windows.Forms.Button bClear;
    }
}