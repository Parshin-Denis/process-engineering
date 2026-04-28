namespace Process_Engineering.Forms
{
    partial class CampaignScrewingToolCheckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CampaignScrewingToolCheckForm));
            this.dgTools = new System.Windows.Forms.DataGridView();
            this.checkResultColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lCampaign = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTools)).BeginInit();
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
            this.dgTools.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkResultColumn});
            this.dgTools.EnableHeadersVisualStyles = false;
            this.dgTools.Location = new System.Drawing.Point(12, 38);
            this.dgTools.Name = "dgTools";
            this.dgTools.RowHeadersVisible = false;
            this.dgTools.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTools.Size = new System.Drawing.Size(900, 275);
            this.dgTools.TabIndex = 0;
            // 
            // checkResultColumn
            // 
            this.checkResultColumn.HeaderText = "Результат";
            this.checkResultColumn.Name = "checkResultColumn";
            this.checkResultColumn.ReadOnly = true;
            // 
            // lCampaign
            // 
            this.lCampaign.AutoSize = true;
            this.lCampaign.Location = new System.Drawing.Point(12, 15);
            this.lCampaign.Name = "lCampaign";
            this.lCampaign.Size = new System.Drawing.Size(125, 13);
            this.lCampaign.TabIndex = 9;
            this.lCampaign.Text = "Параметры кампании: ";
            // 
            // CampaignScrewingToolCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 326);
            this.Controls.Add(this.lCampaign);
            this.Controls.Add(this.dgTools);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(940, 365);
            this.MinimumSize = new System.Drawing.Size(940, 365);
            this.Name = "CampaignScrewingToolCheckForm";
            this.Text = "Результаты проверки";
            this.Load += new System.EventHandler(this.ToolForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTools)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTools;
        private System.Windows.Forms.Label lCampaign;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkResultColumn;
    }
}