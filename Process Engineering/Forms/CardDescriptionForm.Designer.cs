namespace Process_Engineering.Forms
{
    partial class CardDescriptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardDescriptionForm));
            this.dgDescriptions = new System.Windows.Forms.DataGridView();
            this.bClose = new System.Windows.Forms.Button();
            this.lCount = new System.Windows.Forms.Label();
            this.lCard = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDescriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDescriptions
            // 
            this.dgDescriptions.AllowUserToAddRows = false;
            this.dgDescriptions.AllowUserToDeleteRows = false;
            this.dgDescriptions.AllowUserToResizeColumns = false;
            this.dgDescriptions.AllowUserToResizeRows = false;
            this.dgDescriptions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgDescriptions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDescriptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDescriptions.EnableHeadersVisualStyles = false;
            this.dgDescriptions.Location = new System.Drawing.Point(12, 25);
            this.dgDescriptions.Name = "dgDescriptions";
            this.dgDescriptions.ReadOnly = true;
            this.dgDescriptions.RowHeadersVisible = false;
            this.dgDescriptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDescriptions.Size = new System.Drawing.Size(560, 294);
            this.dgDescriptions.TabIndex = 0;
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.Location = new System.Drawing.Point(496, 325);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(76, 24);
            this.bClose.TabIndex = 5;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // lCount
            // 
            this.lCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lCount.Location = new System.Drawing.Point(430, 2);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(142, 20);
            this.lCount.TabIndex = 8;
            this.lCount.Text = "Найдено: 0 шт.";
            this.lCount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lCard
            // 
            this.lCard.AutoSize = true;
            this.lCard.Location = new System.Drawing.Point(12, 8);
            this.lCard.Name = "lCard";
            this.lCard.Size = new System.Drawing.Size(44, 13);
            this.lCard.TabIndex = 9;
            this.lCard.Text = "Гамма ";
            // 
            // CardDescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.lCard);
            this.Controls.Add(this.lCount);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.dgDescriptions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "CardDescriptionForm";
            this.Text = "История изменений";
            this.Load += new System.EventHandler(this.ToolForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDescriptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDescriptions;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.Label lCard;
    }
}