namespace Process_Engineering.Forms
{
    partial class PasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordForm));
            this.lOldPassword = new System.Windows.Forms.Label();
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.lNewPassword = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.lRepeatNewPassword = new System.Windows.Forms.Label();
            this.tbRepeatNewPassword = new System.Windows.Forms.TextBox();
            this.bChangePassword = new System.Windows.Forms.Button();
            this.lCheckOldPassword = new System.Windows.Forms.Label();
            this.lCheckNewPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lOldPassword
            // 
            this.lOldPassword.AutoSize = true;
            this.lOldPassword.Location = new System.Drawing.Point(12, 17);
            this.lOldPassword.Name = "lOldPassword";
            this.lOldPassword.Size = new System.Drawing.Size(84, 13);
            this.lOldPassword.TabIndex = 0;
            this.lOldPassword.Text = "Старый пароль";
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.Location = new System.Drawing.Point(138, 17);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.PasswordChar = '*';
            this.tbOldPassword.Size = new System.Drawing.Size(115, 20);
            this.tbOldPassword.TabIndex = 1;
            this.tbOldPassword.Leave += new System.EventHandler(this.tbOldPassword_Leave);
            // 
            // lNewPassword
            // 
            this.lNewPassword.AutoSize = true;
            this.lNewPassword.Location = new System.Drawing.Point(12, 55);
            this.lNewPassword.Name = "lNewPassword";
            this.lNewPassword.Size = new System.Drawing.Size(80, 13);
            this.lNewPassword.TabIndex = 0;
            this.lNewPassword.Text = "Новый пароль";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(138, 55);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '*';
            this.tbNewPassword.Size = new System.Drawing.Size(115, 20);
            this.tbNewPassword.TabIndex = 2;
            // 
            // lRepeatNewPassword
            // 
            this.lRepeatNewPassword.AutoSize = true;
            this.lRepeatNewPassword.Location = new System.Drawing.Point(12, 84);
            this.lRepeatNewPassword.Name = "lRepeatNewPassword";
            this.lRepeatNewPassword.Size = new System.Drawing.Size(100, 13);
            this.lRepeatNewPassword.TabIndex = 0;
            this.lRepeatNewPassword.Text = "Повторите пароль";
            // 
            // tbRepeatNewPassword
            // 
            this.tbRepeatNewPassword.Location = new System.Drawing.Point(138, 81);
            this.tbRepeatNewPassword.Name = "tbRepeatNewPassword";
            this.tbRepeatNewPassword.PasswordChar = '*';
            this.tbRepeatNewPassword.Size = new System.Drawing.Size(115, 20);
            this.tbRepeatNewPassword.TabIndex = 3;
            this.tbRepeatNewPassword.Leave += new System.EventHandler(this.tbRepeatNewPassword_Leave);
            // 
            // bChangePassword
            // 
            this.bChangePassword.Location = new System.Drawing.Point(81, 140);
            this.bChangePassword.Name = "bChangePassword";
            this.bChangePassword.Size = new System.Drawing.Size(104, 29);
            this.bChangePassword.TabIndex = 4;
            this.bChangePassword.Text = "Сменить пароль";
            this.bChangePassword.UseVisualStyleBackColor = true;
            this.bChangePassword.Click += new System.EventHandler(this.bChangePassword_Click);
            // 
            // lCheckOldPassword
            // 
            this.lCheckOldPassword.AutoSize = true;
            this.lCheckOldPassword.ForeColor = System.Drawing.Color.Red;
            this.lCheckOldPassword.Location = new System.Drawing.Point(149, 39);
            this.lCheckOldPassword.Name = "lCheckOldPassword";
            this.lCheckOldPassword.Size = new System.Drawing.Size(0, 13);
            this.lCheckOldPassword.TabIndex = 3;
            // 
            // lCheckNewPassword
            // 
            this.lCheckNewPassword.AutoSize = true;
            this.lCheckNewPassword.ForeColor = System.Drawing.Color.Red;
            this.lCheckNewPassword.Location = new System.Drawing.Point(135, 104);
            this.lCheckNewPassword.Name = "lCheckNewPassword";
            this.lCheckNewPassword.Size = new System.Drawing.Size(0, 13);
            this.lCheckNewPassword.TabIndex = 3;
            // 
            // PasswordForm
            // 
            this.AcceptButton = this.bChangePassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(259, 181);
            this.Controls.Add(this.lCheckNewPassword);
            this.Controls.Add(this.lCheckOldPassword);
            this.Controls.Add(this.bChangePassword);
            this.Controls.Add(this.tbRepeatNewPassword);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.tbOldPassword);
            this.Controls.Add(this.lRepeatNewPassword);
            this.Controls.Add(this.lNewPassword);
            this.Controls.Add(this.lOldPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(275, 220);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(275, 220);
            this.Name = "PasswordForm";
            this.Text = "Смена пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lOldPassword;
        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.Label lNewPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label lRepeatNewPassword;
        private System.Windows.Forms.TextBox tbRepeatNewPassword;
        private System.Windows.Forms.Button bChangePassword;
        private System.Windows.Forms.Label lCheckOldPassword;
        private System.Windows.Forms.Label lCheckNewPassword;
    }
}