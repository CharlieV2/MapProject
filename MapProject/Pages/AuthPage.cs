using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapProject.Pages
{
    public partial class AuthPage : UserControl
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void guestLoginButton_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void hidePasswordSwitch_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = hidePasswordSwitch.Switch;
        }
    }
}
