using Process_Engineering.DTO;
using Process_Engineering.Service;
using System;
using System.Windows.Forms;

namespace Process_Engineering.Forms
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private async void bChangePassword_Click(object sender, EventArgs e)
        {
            if (!tbOldPassword.Text.Equals(DataBaseService.user.password) || !tbNewPassword.Text.Equals(tbRepeatNewPassword.Text))
            {
                return;
            }
            GeneralResponse<object> response = await DataBaseService.changePassword(tbNewPassword.Text);
            if (response.isResultOK)
            {
                DataBaseService.user.password = tbNewPassword.Text;
                DataBaseService.updateAuthorization();
            }
            MessageBox.Show(response.message, "Изменение пароля");
            Close();
        }

        private void tbOldPassword_Leave(object sender, EventArgs e)
        {
            lCheckOldPassword.Text = tbOldPassword.Text.Equals(DataBaseService.user.password) ? string.Empty : "Пароль не верный";
        }

        private void tbRepeatNewPassword_Leave(object sender, EventArgs e)
        {
            lCheckNewPassword.Text = tbNewPassword.Text.Equals(tbRepeatNewPassword.Text) ? string.Empty : "Пароли не совпадают";
        }
    }
}
