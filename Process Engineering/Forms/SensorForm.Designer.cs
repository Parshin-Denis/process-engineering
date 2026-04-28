namespace Process_Engineering.Forms
{
    partial class SensorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SensorForm));
            this.dgSensors = new System.Windows.Forms.DataGridView();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.lNumber = new System.Windows.Forms.Label();
            this.lBlm = new System.Windows.Forms.Label();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.lCount = new System.Windows.Forms.Label();
            this.tbMinTorque = new System.Windows.Forms.TextBox();
            this.tbMaxTorque = new System.Windows.Forms.TextBox();
            this.lMinTorque = new System.Windows.Forms.Label();
            this.lMaxTorque = new System.Windows.Forms.Label();
            this.bDelete = new System.Windows.Forms.Button();
            this.gbParameters = new System.Windows.Forms.GroupBox();
            this.cbBlmFilter = new System.Windows.Forms.ComboBox();
            this.lBlmFilter = new System.Windows.Forms.Label();
            this.cbBlm = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgSensors)).BeginInit();
            this.gbParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgSensors
            // 
            this.dgSensors.AllowUserToAddRows = false;
            this.dgSensors.AllowUserToDeleteRows = false;
            this.dgSensors.AllowUserToResizeColumns = false;
            this.dgSensors.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSensors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSensors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSensors.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgSensors.EnableHeadersVisualStyles = false;
            this.dgSensors.Location = new System.Drawing.Point(12, 38);
            this.dgSensors.Name = "dgSensors";
            this.dgSensors.RowHeadersVisible = false;
            this.dgSensors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSensors.Size = new System.Drawing.Size(410, 190);
            this.dgSensors.TabIndex = 0;
            this.dgSensors.SelectionChanged += new System.EventHandler(this.dgTools_SelectionChanged);
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(99, 36);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(94, 20);
            this.tbNumber.TabIndex = 2;
            this.tbNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumber.TextChanged += new System.EventHandler(this.sensorParameterChanged);
            this.tbNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbParameters_KeyPress);
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Location = new System.Drawing.Point(113, 20);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(61, 13);
            this.lNumber.TabIndex = 2;
            this.lNumber.Text = "№ датчика";
            // 
            // lBlm
            // 
            this.lBlm.AutoSize = true;
            this.lBlm.Location = new System.Drawing.Point(25, 20);
            this.lBlm.Name = "lBlm";
            this.lBlm.Size = new System.Drawing.Size(43, 13);
            this.lBlm.TabIndex = 2;
            this.lBlm.Text = "№ BLM";
            // 
            // bUpdate
            // 
            this.bUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bUpdate.Location = new System.Drawing.Point(12, 302);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(131, 23);
            this.bUpdate.TabIndex = 5;
            this.bUpdate.Text = "Изменить выбранный";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAdd.Location = new System.Drawing.Point(308, 302);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(114, 23);
            this.bAdd.TabIndex = 4;
            this.bAdd.Text = "Добавить новый";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // lCount
            // 
            this.lCount.Location = new System.Drawing.Point(314, 15);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(100, 20);
            this.lCount.TabIndex = 8;
            this.lCount.Text = "Найдено: 0 шт.";
            this.lCount.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tbMinTorque
            // 
            this.tbMinTorque.Location = new System.Drawing.Point(199, 36);
            this.tbMinTorque.Name = "tbMinTorque";
            this.tbMinTorque.Size = new System.Drawing.Size(100, 20);
            this.tbMinTorque.TabIndex = 3;
            this.tbMinTorque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMinTorque.TextChanged += new System.EventHandler(this.sensorParameterChanged);
            this.tbMinTorque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbParameters_KeyPress);
            // 
            // tbMaxTorque
            // 
            this.tbMaxTorque.Location = new System.Drawing.Point(305, 36);
            this.tbMaxTorque.Name = "tbMaxTorque";
            this.tbMaxTorque.Size = new System.Drawing.Size(94, 20);
            this.tbMaxTorque.TabIndex = 4;
            this.tbMaxTorque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMaxTorque.TextChanged += new System.EventHandler(this.sensorParameterChanged);
            this.tbMaxTorque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbParameters_KeyPress);
            // 
            // lMinTorque
            // 
            this.lMinTorque.AutoSize = true;
            this.lMinTorque.Location = new System.Drawing.Point(213, 20);
            this.lMinTorque.Name = "lMinTorque";
            this.lMinTorque.Size = new System.Drawing.Size(70, 13);
            this.lMinTorque.TabIndex = 10;
            this.lMinTorque.Text = "Момент MIN";
            // 
            // lMaxTorque
            // 
            this.lMaxTorque.AutoSize = true;
            this.lMaxTorque.Location = new System.Drawing.Point(313, 20);
            this.lMaxTorque.Name = "lMaxTorque";
            this.lMaxTorque.Size = new System.Drawing.Size(73, 13);
            this.lMaxTorque.TabIndex = 10;
            this.lMaxTorque.Text = "Момент MAX";
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(185, 302);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 11;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // gbParameters
            // 
            this.gbParameters.Controls.Add(this.cbBlm);
            this.gbParameters.Controls.Add(this.tbNumber);
            this.gbParameters.Controls.Add(this.lMaxTorque);
            this.gbParameters.Controls.Add(this.lNumber);
            this.gbParameters.Controls.Add(this.lMinTorque);
            this.gbParameters.Controls.Add(this.lBlm);
            this.gbParameters.Controls.Add(this.tbMaxTorque);
            this.gbParameters.Controls.Add(this.tbMinTorque);
            this.gbParameters.Location = new System.Drawing.Point(12, 234);
            this.gbParameters.Name = "gbParameters";
            this.gbParameters.Size = new System.Drawing.Size(410, 62);
            this.gbParameters.TabIndex = 12;
            this.gbParameters.TabStop = false;
            this.gbParameters.Text = "Параметры";
            // 
            // cbBlmFilter
            // 
            this.cbBlmFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBlmFilter.FormattingEnabled = true;
            this.cbBlmFilter.Location = new System.Drawing.Point(50, 11);
            this.cbBlmFilter.Name = "cbBlmFilter";
            this.cbBlmFilter.Size = new System.Drawing.Size(121, 21);
            this.cbBlmFilter.TabIndex = 13;
            this.cbBlmFilter.SelectedIndexChanged += new System.EventHandler(this.updateDataGrid);
            // 
            // lBlmFilter
            // 
            this.lBlmFilter.AutoSize = true;
            this.lBlmFilter.Location = new System.Drawing.Point(15, 15);
            this.lBlmFilter.Name = "lBlmFilter";
            this.lBlmFilter.Size = new System.Drawing.Size(29, 13);
            this.lBlmFilter.TabIndex = 14;
            this.lBlmFilter.Text = "BLM";
            // 
            // cbBlm
            // 
            this.cbBlm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBlm.FormattingEnabled = true;
            this.cbBlm.Location = new System.Drawing.Point(6, 35);
            this.cbBlm.Name = "cbBlm";
            this.cbBlm.Size = new System.Drawing.Size(87, 21);
            this.cbBlm.TabIndex = 15;
            this.cbBlm.SelectedIndexChanged += new System.EventHandler(this.sensorParameterChanged);
            // 
            // SensorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 331);
            this.Controls.Add(this.lBlmFilter);
            this.Controls.Add(this.cbBlmFilter);
            this.Controls.Add(this.gbParameters);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.lCount);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.dgSensors);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 370);
            this.MinimumSize = new System.Drawing.Size(450, 370);
            this.Name = "SensorForm";
            this.Text = "Датчики";
            this.Load += new System.EventHandler(this.ToolForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSensors)).EndInit();
            this.gbParameters.ResumeLayout(false);
            this.gbParameters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSensors;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label lNumber;
        private System.Windows.Forms.Label lBlm;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.TextBox tbMinTorque;
        private System.Windows.Forms.TextBox tbMaxTorque;
        private System.Windows.Forms.Label lMinTorque;
        private System.Windows.Forms.Label lMaxTorque;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.GroupBox gbParameters;
        private System.Windows.Forms.ComboBox cbBlmFilter;
        private System.Windows.Forms.Label lBlmFilter;
        private System.Windows.Forms.ComboBox cbBlm;
    }
}