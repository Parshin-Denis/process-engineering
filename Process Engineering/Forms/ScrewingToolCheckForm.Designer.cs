namespace Process_Engineering.Forms
{
    partial class ScrewingToolCheckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScrewingToolCheckForm));
            this.dgTools = new System.Windows.Forms.DataGridView();
            this.checkResultColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bClose = new System.Windows.Forms.Button();
            this.lCount = new System.Windows.Forms.Label();
            this.lTool = new System.Windows.Forms.Label();
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
            this.dgTools.Location = new System.Drawing.Point(1, 38);
            this.dgTools.Name = "dgTools";
            this.dgTools.RowHeadersVisible = false;
            this.dgTools.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTools.Size = new System.Drawing.Size(836, 256);
            this.dgTools.TabIndex = 0;
            // 
            // checkResultColumn
            // 
            this.checkResultColumn.HeaderText = "Результат";
            this.checkResultColumn.Name = "checkResultColumn";
            this.checkResultColumn.ReadOnly = true;
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.Location = new System.Drawing.Point(761, 300);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(76, 24);
            this.bClose.TabIndex = 5;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // lCount
            // 
            this.lCount.Location = new System.Drawing.Point(695, 15);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(142, 20);
            this.lCount.TabIndex = 8;
            this.lCount.Text = "Найдено: 0 шт.";
            this.lCount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lTool
            // 
            this.lTool.AutoSize = true;
            this.lTool.Location = new System.Drawing.Point(12, 9);
            this.lTool.Name = "lTool";
            this.lTool.Size = new System.Drawing.Size(140, 13);
            this.lTool.TabIndex = 9;
            this.lTool.Text = "Параметры инструмента: ";
            // 
            // ScrewingToolCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 331);
            this.Controls.Add(this.lTool);
            this.Controls.Add(this.lCount);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.dgTools);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(865, 370);
            this.MinimumSize = new System.Drawing.Size(865, 370);
            this.Name = "ScrewingToolCheckForm";
            this.Text = "История проверок";
            this.Load += new System.EventHandler(this.ToolForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTools)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTools;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.Label lTool;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkResultColumn;
    }
}