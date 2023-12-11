using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Home_library.Implementations;
using Home_library.Interfaces;
using Home_library.Models;

namespace Home_library.Forms
{
    public partial class UserDashboardForm : Form
    {
        private readonly IManager<User> _userManager;

        public UserDashboardForm(IManager<User> userManager)
        {
            InitializeComponent();

            _userManager = userManager;

            RefreshUsersBox();
        }

        private void RefreshUsersBox()
        {
            usersBox.DataSource = _userManager.Load().Select(x => x.Username).ToList();
        }

        private void UserDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void UsersBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var users = _userManager.Load();
            var selectedUser = users.ElementAt(usersBox.SelectedIndex);

            UsernameBox.Text = selectedUser.Username;
            PasswordBox.Text = selectedUser.Password;
            IdBox.Text = selectedUser.Id.ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            var users = _userManager.Load();
            var selectedUser = users.ElementAt(usersBox.SelectedIndex);

            users.RemoveAt(usersBox.SelectedIndex);

            selectedUser.Username = UsernameBox.Text;
            selectedUser.Password = PasswordBox.Text;

            users.Insert(usersBox.SelectedIndex, selectedUser);
            _userManager.Save(users);

            messageBox.Text = "Changes applied successfully!";

            RefreshUsersBox();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var resultDialog = MessageBox.Show("Are you sure you want to delete selected user?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultDialog == DialogResult.Yes)
            {
                var index = usersBox.SelectedIndex;
                var users = _userManager.Load();

                users.RemoveAt(index);
                _userManager.Save(users);
                RefreshUsersBox();
            }
        }
    }
}
