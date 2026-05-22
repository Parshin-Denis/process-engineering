namespace Process_Engineering.Forms
{
    partial class PartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartForm));
            this.dgParts = new System.Windows.Forms.DataGridView();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lNumber = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.bUpdate = new System.Windows.Forms.Button();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.bFind = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.cbNotUsed = new System.Windows.Forms.CheckBox();
            this.bShowAll = new System.Windows.Forms.Button();
            this.lQuantity = new System.Windows.Forms.Label();
            this.lUnit = new System.Windows.Forms.Label();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.lbCards = new System.Windows.Forms.ListBox();
            this.lCards = new System.Windows.Forms.Label();
            this.bConsumptions = new System.Windows.Forms.Button();
            this.pPartParameter = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgParts)).BeginInit();
            this.pPartParameter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgParts
            // 
            this.dgParts.AllowUserToAddRows = false;
            this.dgParts.AllowUserToDeleteRows = false;
            this.dgParts.AllowUserToResizeColumns = false;
            this.dgParts.AllowUserToResizeRows = false;
            this.dgParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgParts.EnableHeadersVisualStyles = false;
            this.dgParts.Location = new System.Drawing.Point(12, 49);
            this.dgParts.Name = "dgParts";
            this.dgParts.RowHeadersVisible = false;
            this.dgParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgParts.Size = new System.Drawing.Size(760, 218);
            this.dgParts.TabIndex = 0;
            this.dgParts.SelectionChanged += new System.EventHandler(this.dgParts_SelectionChanged);
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(3, 24);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(139, 20);
            this.tbNumber.TabIndex = 1;
            this.tbNumber.TextChanged += new System.EventHandler(this.partParameterChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(148, 24);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(528, 20);
            this.tbName.TabIndex = 2;
            this.tbName.TextChanged += new System.EventHandler(this.partParameterChanged);
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Location = new System.Drawing.Point(54, 7);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(41, 13);
            this.lNumber.TabIndex = 3;
            this.lNumber.Text = "Номер";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(385, 7);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(57, 13);
            this.lName.TabIndex = 3;
            this.lName.Text = "Название";
            // 
            // bUpdate
            // 
            this.bUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bUpdate.Location = new System.Drawing.Point(12, 425);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(167, 31);
            this.bUpdate.TabIndex = 4;
            this.bUpdate.Text = "Принять изменения";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(12, 17);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(186, 20);
            this.tbFind.TabIndex = 5;
            // 
            // bFind
            // 
            this.bFind.Location = new System.Drawing.Point(366, 10);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(75, 33);
            this.bFind.TabIndex = 6;
            this.bFind.Text = "Найти";
            this.bFind.UseVisualStyleBackColor = true;
            this.bFind.Click += new System.EventHandler(this.bFind_Click);
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.Location = new System.Drawing.Point(697, 425);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 31);
            this.bClose.TabIndex = 7;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAdd.Location = new System.Drawing.Point(554, 425);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(137, 31);
            this.bAdd.TabIndex = 8;
            this.bAdd.Text = "Добавить новую деталь";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // cbNotUsed
            // 
            this.cbNotUsed.AutoSize = true;
            this.cbNotUsed.Location = new System.Drawing.Point(204, 19);
            this.cbNotUsed.Name = "cbNotUsed";
            this.cbNotUsed.Size = new System.Drawing.Size(156, 17);
            this.cbNotUsed.TabIndex = 9;
            this.cbNotUsed.Text = "Отсутствующие в гаммах";
            this.cbNotUsed.UseVisualStyleBackColor = true;
            this.cbNotUsed.CheckedChanged += new System.EventHandler(this.cbNotUsed_CheckedChanged);
            // 
            // bShowAll
            // 
            this.bShowAll.Location = new System.Drawing.Point(447, 10);
            this.bShowAll.Name = "bShowAll";
            this.bShowAll.Size = new System.Drawing.Size(92, 33);
            this.bShowAll.TabIndex = 10;
            this.bShowAll.Text = "Показать все";
            this.bShowAll.UseVisualStyleBackColor = true;
            this.bShowAll.Click += new System.EventHandler(this.bShowAll_Click);
            // 
            // lQuantity
            // 
            this.lQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lQuantity.Location = new System.Drawing.Point(651, 29);
            this.lQuantity.Name = "lQuantity";
            this.lQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lQuantity.Size = new System.Drawing.Size(121, 17);
            this.lQuantity.TabIndex = 11;
            this.lQuantity.Text = "Найдено: 0 шт.";
            this.lQuantity.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lUnit
            // 
            this.lUnit.AutoSize = true;
            this.lUnit.Location = new System.Drawing.Point(696, 7);
            this.lUnit.Name = "lUnit";
            this.lUnit.Size = new System.Drawing.Size(49, 13);
            this.lUnit.TabIndex = 12;
            this.lUnit.Text = "Ед. изм.";
            // 
            // tbUnit
            // 
            this.tbUnit.Location = new System.Drawing.Point(682, 24);
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.Size = new System.Drawing.Size(75, 20);
            this.tbUnit.TabIndex = 13;
            this.tbUnit.TextChanged += new System.EventHandler(this.partParameterChanged);
            // 
            // lbCards
            // 
            this.lbCards.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbCards.FormattingEnabled = true;
            this.lbCards.Location = new System.Drawing.Point(12, 341);
            this.lbCards.Name = "lbCards";
            this.lbCards.Size = new System.Drawing.Size(760, 69);
            this.lbCards.TabIndex = 14;
            this.lbCards.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbCards_DrawItem);
            this.lbCards.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbCards_MouseDoubleClick);
            // 
            // lCards
            // 
            this.lCards.AutoSize = true;
            this.lCards.Location = new System.Drawing.Point(342, 325);
            this.lCards.Name = "lCards";
            this.lCards.Size = new System.Drawing.Size(124, 13);
            this.lCards.TabIndex = 15;
            this.lCards.Text = "Гаммы использования";
            // 
            // bConsumptions
            // 
            this.bConsumptions.Location = new System.Drawing.Point(545, 10);
            this.bConsumptions.Name = "bConsumptions";
            this.bConsumptions.Size = new System.Drawing.Size(111, 33);
            this.bConsumptions.TabIndex = 16;
            this.bConsumptions.Text = "Выгрузка в EXCEL";
            this.bConsumptions.UseVisualStyleBackColor = true;
            this.bConsumptions.Click += new System.EventHandler(this.bConsumptions_Click);
            // 
            // pPartParameter
            // 
            this.pPartParameter.Controls.Add(this.tbNumber);
            this.pPartParameter.Controls.Add(this.tbName);
            this.pPartParameter.Controls.Add(this.lNumber);
            this.pPartParameter.Controls.Add(this.lName);
            this.pPartParameter.Controls.Add(this.tbUnit);
            this.pPartParameter.Controls.Add(this.lUnit);
            this.pPartParameter.Location = new System.Drawing.Point(12, 273);
            this.pPartParameter.Name = "pPartParameter";
            this.pPartParameter.Size = new System.Drawing.Size(760, 48);
            this.pPartParameter.TabIndex = 17;
            // 
            // PartForm
            // 
            this.AcceptButton = this.bFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pPartParameter);
            this.Controls.Add(this.bConsumptions);
            this.Controls.Add(this.lCards);
            this.Controls.Add(this.lbCards);
            this.Controls.Add(this.lQuantity);
            this.Controls.Add(this.bShowAll);
            this.Controls.Add(this.cbNotUsed);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bFind);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.dgParts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "PartForm";
            this.Text = "Детали";
            this.Load += new System.EventHandler(this.PartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgParts)).EndInit();
            this.pPartParameter.ResumeLayout(false);
            this.pPartParameter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgParts;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lNumber;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Button bFind;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.CheckBox cbNotUsed;
        private System.Windows.Forms.Button bShowAll;
        private System.Windows.Forms.Label lQuantity;
        private System.Windows.Forms.Label lUnit;
        private System.Windows.Forms.TextBox tbUnit;
        private System.Windows.Forms.ListBox lbCards;
        private System.Windows.Forms.Label lCards;
        private System.Windows.Forms.Button bConsumptions;
        private System.Windows.Forms.Panel pPartParameter;
    }
}