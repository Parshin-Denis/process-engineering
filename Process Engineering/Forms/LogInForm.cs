using Process_Engineering.DTO;
using Process_Engineering.Service;
using System;
using System.Windows.Forms;

namespace Process_Engineering.Forms
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private async void bLogIn_Click(object sender, EventArgs e)
        {
            GeneralResponse<Object> response = await DataBaseService.logIn(tbId.Text, tbPassword.Text);
            if (response.isResultOK)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                lResult.Text = response.message ?? "Вход не выполнен";
            }
        }
    }
}
