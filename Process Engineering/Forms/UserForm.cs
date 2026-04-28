using Process_Engineering.DTO;
using Process_Engineering.Service;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Process_Engineering.Forms
{
    public partial class UserForm : Form
    {
        private User user = new User();
        public UserForm()
        {
            InitializeComponent();
        }

        private async void UserForm_Load(object sender, EventArgs e)
        {
            User.users = await DataBaseService.getUserList();
            dgUsers.DataSource = new BindingList<User>(User.users);
            cbRole.Items.AddRange(ConstStorage.ROLE_TYPES);
            dgUsers.Columns[0].HeaderText = "ID";
            dgUsers.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgUsers.Columns[1].HeaderText = "№";
            dgUsers.Columns[2].HeaderText = "Имя пользователя";
            dgUsers.Columns[3].HeaderText = "Роль";
            dgUsers.Columns[4].Visible = false;
            dgUsers.Columns[0].Width = 30;
            dgUsers.Columns[1].Width = 50;
            dgUsers.Columns[3].Width = 200;
            dgUsers.Columns[2].Width = dgUsers.Width - SystemInformation.VerticalScrollBarWidth -
                dgUsers.Columns[0].Width - dgUsers.Columns[1].Width - dgUsers.Columns[3].Width - 3;
            dgUsers.ReadOnly = true;
        }

        private void dgUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgUsers.SelectedRows.Count == 0)
            {
                return;
            }
            user.copyFrom(User.users[dgUsers.SelectedRows[0].Index]);
            tbId.Text = user.idIntern;
            tbName.Text = user.name;
            cbRole.SelectedItem = user.role;
            tbPassword.Text = user.password;
        }

        private async void bAddUser_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser.idIntern = tbId.Text;
            newUser.name = tbName.Text;
            newUser.role = cbRole.SelectedItem.ToString();
            newUser.password = tbPassword.Text;
            GeneralResponse<User> response = await DataBaseService.createUser(newUser);
            if (response.isResultOK)
            {
                newUser = response.data;
                User.users.Add(newUser);
                MessageBox.Show(ConstStorage.USER_IS_ADDED, ConstStorage.USER_EDITING);
                dgUsers.DataSource = new BindingList<User>(User.users);
            }
        }

        private async void bUpdateUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format(ConstStorage.UPDATE_USER, user.id),
                ConstStorage.USER_EDITING, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            user.idIntern = tbId.Text.Trim();
            user.name = tbName.Text.Trim();
            user.role = cbRole.SelectedItem.ToString();
            user.password = tbPassword.Text.Trim();
            GeneralResponse<object> response = await DataBaseService.updateUser(user);
            if (response.isResultOK)
            {
                User userToUpdate = User.users.First(u => u.id == user.id);
                userToUpdate.copyFrom(user);
                MessageBox.Show(ConstStorage.USER_IS_UPDATED, ConstStorage.USER_EDITING);
                dgUsers.Refresh();
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
