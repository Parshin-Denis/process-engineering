namespace Process_Engineering.Forms
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lId = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lRole = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.bAddUser = new System.Windows.Forms.Button();
            this.bUpdateUser = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUsers
            // 
            this.dgUsers.AllowUserToAddRows = false;
            this.dgUsers.AllowUserToDeleteRows = false;
            this.dgUsers.AllowUserToResizeColumns = false;
            this.dgUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.EnableHeadersVisualStyles = false;
            this.dgUsers.Location = new System.Drawing.Point(12, 12);
            this.dgUsers.MultiSelect = false;
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.RowHeadersVisible = false;
            this.dgUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsers.Size = new System.Drawing.Size(460, 152);
            this.dgUsers.TabIndex = 0;
            this.dgUsers.SelectionChanged += new System.EventHandler(this.dgUsers_SelectionChanged);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(12, 190);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(71, 20);
            this.tbId.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(89, 190);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(151, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(389, 190);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(83, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(29, 174);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(41, 13);
            this.lId.TabIndex = 2;
            this.lId.Text = "Номер";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(117, 174);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(103, 13);
            this.lName.TabIndex = 2;
            this.lName.Text = "Имя пользователя";
            // 
            // lRole
            // 
            this.lRole.AutoSize = true;
            this.lRole.Location = new System.Drawing.Point(286, 174);
            this.lRole.Name = "lRole";
            this.lRole.Size = new System.Drawing.Size(32, 13);
            this.lRole.TabIndex = 3;
            this.lRole.Text = "Роль";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(405, 174);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(45, 13);
            this.lPassword.TabIndex = 3;
            this.lPassword.Text = "Пароль";
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(246, 190);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(137, 21);
            this.cbRole.TabIndex = 4;
            // 
            // bAddUser
            // 
            this.bAddUser.Location = new System.Drawing.Point(220, 217);
            this.bAddUser.Name = "bAddUser";
            this.bAddUser.Size = new System.Drawing.Size(182, 23);
            this.bAddUser.TabIndex = 5;
            this.bAddUser.Text = "Добавить нового пользователя";
            this.bAddUser.UseVisualStyleBackColor = true;
            this.bAddUser.Click += new System.EventHandler(this.bAddUser_Click);
            // 
            // bUpdateUser
            // 
            this.bUpdateUser.Location = new System.Drawing.Point(12, 216);
            this.bUpdateUser.Name = "bUpdateUser";
            this.bUpdateUser.Size = new System.Drawing.Size(129, 23);
            this.bUpdateUser.TabIndex = 6;
            this.bUpdateUser.Text = "Принять изменения";
            this.bUpdateUser.UseVisualStyleBackColor = true;
            this.bUpdateUser.Click += new System.EventHandler(this.bUpdateUser_Click);
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(408, 216);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(64, 23);
            this.bClose.TabIndex = 7;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 251);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bUpdateUser);
            this.Controls.Add(this.bAddUser);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lRole);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lId);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.dgUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 290);
            this.MinimumSize = new System.Drawing.Size(500, 290);
            this.Name = "UserForm";
            this.Text = "Пользователи";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lRole;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Button bAddUser;
        private System.Windows.Forms.Button bUpdateUser;
        private System.Windows.Forms.Button bClose;
    }
}