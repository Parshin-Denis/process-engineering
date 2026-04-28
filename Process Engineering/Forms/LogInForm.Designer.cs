namespace Process_Engineering.Forms
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.bLogIn = new System.Windows.Forms.Button();
            this.lResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(63, 62);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(188, 20);
            this.tbPassword.TabIndex = 0;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(63, 24);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(188, 20);
            this.tbId.TabIndex = 0;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(12, 31);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(29, 13);
            this.lName.TabIndex = 1;
            this.lName.Text = "Имя";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(12, 69);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(45, 13);
            this.lPassword.TabIndex = 1;
            this.lPassword.Text = "Пароль";
            // 
            // bLogIn
            // 
            this.bLogIn.Location = new System.Drawing.Point(93, 117);
            this.bLogIn.Name = "bLogIn";
            this.bLogIn.Size = new System.Drawing.Size(75, 23);
            this.bLogIn.TabIndex = 2;
            this.bLogIn.Text = "Войти";
            this.bLogIn.UseVisualStyleBackColor = true;
            this.bLogIn.Click += new System.EventHandler(this.bLogIn_Click);
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.ForeColor = System.Drawing.Color.Red;
            this.lResult.Location = new System.Drawing.Point(70, 93);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(0, 13);
            this.lResult.TabIndex = 3;
            // 
            // LogInForm
            // 
            this.AcceptButton = this.bLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 151);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.bLogIn);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(275, 190);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(275, 190);
            this.Name = "LogInForm";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Button bLogIn;
        private System.Windows.Forms.Label lResult;
    }
}