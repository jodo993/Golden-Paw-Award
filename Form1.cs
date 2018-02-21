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

        // Tool tips to help user know what is expected
        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(signupFullNameTextBox, "Enter your full name here.");
            toolTip1.SetToolTip(signupUsernameTextBox, "Enter a unique username that is easy to remember, but hard for others to guess.");
            toolTip1.SetToolTip(linkAccoutToComputerCheckBox, "Link this computer to this account for quick login via the Login via Computer option on the login screen. " +
                                                              "Check only if this is your computer.");
        }
        // Style the labels to let user know which selection is active
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

            if (usernameTextBox.Text == "")
                usernameTextBox.Text = "Username";
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

            if (signupFullNameTextBox.Text == "")
                signupFullNameTextBox.Text = "Full name";
            if (signupUsernameTextBox.Text == "")
                signupUsernameTextBox.Text = "Username";
        }

        // Clear textbox placeholders when clicked
        private void usernameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            usernameTextBox.Clear();
        }

        private void signupFullNameTextBox_Click(object sender, EventArgs e)
        {
            signupFullNameTextBox.Clear();
            if (signupUsernameTextBox.Text == "")
                signupUsernameTextBox.Text = "Username";
        }

        private void signupUsernameTextBox_Click(object sender, EventArgs e)
        {
            signupUsernameTextBox.Clear();
            if (signupFullNameTextBox.Text == "")
                signupFullNameTextBox.Text = "Full name";
        }

    }
}
