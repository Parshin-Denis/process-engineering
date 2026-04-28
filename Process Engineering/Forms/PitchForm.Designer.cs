namespace Process_Engineering.Forms
{
    partial class PitchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PitchForm));
            this.dgPitches = new System.Windows.Forms.DataGridView();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lNumber = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.bFind = new System.Windows.Forms.Button();
            this.lCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPitches)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPitches
            // 
            this.dgPitches.AllowUserToAddRows = false;
            this.dgPitches.AllowUserToDeleteRows = false;
            this.dgPitches.AllowUserToResizeColumns = false;
            this.dgPitches.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPitches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPitches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPitches.EnableHeadersVisualStyles = false;
            this.dgPitches.Location = new System.Drawing.Point(12, 38);
            this.dgPitches.Name = "dgPitches";
            this.dgPitches.RowHeadersVisible = false;
            this.dgPitches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPitches.Size = new System.Drawing.Size(560, 218);
            this.dgPitches.TabIndex = 0;
            this.dgPitches.SelectionChanged += new System.EventHandler(this.dgPitch_SelectionChanged);
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(12, 275);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(120, 20);
            this.tbNumber.TabIndex = 1;
            this.tbNumber.TextChanged += new System.EventHandler(this.pitchParameterChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(138, 275);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(434, 20);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.pitchParameterChanged);
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Location = new System.Drawing.Point(46, 259);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(41, 13);
            this.lNumber.TabIndex = 2;
            this.lNumber.Text = "Номер";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(344, 259);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(57, 13);
            this.lName.TabIndex = 2;
            this.lName.Text = "Название";
            // 
            // bUpdate
            // 
            this.bUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bUpdate.Location = new System.Drawing.Point(12, 302);
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
            this.bAdd.Location = new System.Drawing.Point(312, 302);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(178, 23);
            this.bAdd.TabIndex = 4;
            this.bAdd.Text = "Добавить новый пост";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.Location = new System.Drawing.Point(496, 301);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(76, 24);
            this.bClose.TabIndex = 5;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(12, 12);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(193, 20);
            this.tbFind.TabIndex = 6;
            // 
            // bFind
            // 
            this.bFind.Location = new System.Drawing.Point(211, 9);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(75, 23);
            this.bFind.TabIndex = 7;
            this.bFind.Text = "Найти";
            this.bFind.UseVisualStyleBackColor = true;
            this.bFind.Click += new System.EventHandler(this.showPitches);
            // 
            // lCount
            // 
            this.lCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lCount.Location = new System.Drawing.Point(472, 12);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(100, 20);
            this.lCount.TabIndex = 8;
            this.lCount.Text = "Найдено: 0 шт.";
            this.lCount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // PitchForm
            // 
            this.AcceptButton = this.bFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 331);
            this.Controls.Add(this.lCount);
            this.Controls.Add(this.bFind);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lNumber);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.dgPitches);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 370);
            this.MinimumSize = new System.Drawing.Size(600, 370);
            this.Name = "PitchForm";
            this.Text = "Посты";
            this.Load += new System.EventHandler(this.PitchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPitches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPitches;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lNumber;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Button bFind;
        private System.Windows.Forms.Label lCount;
    }
}