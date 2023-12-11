using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace Home_library.Forms
{
    public partial class AdminForm : Form
    {
        private readonly IServiceProvider _provider;

        public AdminForm(IServiceProvider provider)
        {
            InitializeComponent();
            _provider = provider;
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            Hide();
            _provider.GetRequiredService<UserDashboardForm>().ShowDialog();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
