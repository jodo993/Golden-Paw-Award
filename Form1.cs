using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webber_Golden_Paw_Award
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginLabel_MouseHover(object sender, EventArgs e)
        {
            loginLabel.Font = new Font("Arial", 10, FontStyle.Bold);
            loginLabel.ForeColor = Color.Red;
        }

        private void loginLabel_MouseLeave(object sender, EventArgs e)
        {
            if (loginPanel.Visible == false)
                loginLabel.Font = new Font("Arial", 8, FontStyle.Regular);
            loginLabel.ForeColor = Color.Black;
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = true;
            signupPanel.Visible = false;

            loginLabel.Font = new Font("Arial", 10, FontStyle.Bold);
            signupLabel.Font = new Font("Arial", 8, FontStyle.Regular);
        }

        private void signupLabel_MouseHover(object sender, EventArgs e)
        {
            signupLabel.Font = new Font("Arial", 10, FontStyle.Bold);
            signupLabel.ForeColor = Color.Red;
        }

        private void signupLabel_MouseLeave(object sender, EventArgs e)
        {
            if (signupPanel.Visible == false)
                signupLabel.Font = new Font("Arial", 8, FontStyle.Regular);
            signupLabel.ForeColor = Color.Black;
        }

        private void signupLabel_Click(object sender, EventArgs e)
        {
            signupPanel.Visible = true;
            loginPanel.Visible = false;

            signupLabel.Font = new Font("Arial", 10, FontStyle.Bold);
            loginLabel.Font = new Font("Arial", 8, FontStyle.Regular);
        }

        private void usernameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            usernameTextBox.Clear();
        }
    }
}
