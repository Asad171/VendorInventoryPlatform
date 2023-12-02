using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VendorAppInventory
{
    public partial class RegisterUserControl : UserControl
    {
        public static RegisterUserControl RegisterInstance = new RegisterUserControl();
        public RegisterUserControl()
        {
            InitializeComponent();
            RegisterInstance = this;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            redirectToLogin();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;
            string confirmPassword = ConfirmPasswordTextBox.Text;
            bool userType = AdminCheckBox.Checked;

            if (username == string.Empty || email == string.Empty || password == string.Empty || confirmPassword == string.Empty) {
                MessageBox.Show("All fields must be filled", "Invalid Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword) {
                MessageBox.Show("Passwords did not match.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MainForm.user.WriteDataToTable(username, email, password, userType))
            {
                redirectToLogin();
            }
        }

        public void redirectToLogin()
        {
            this.Hide();
            MainForm.MainInstance.Text = "Login";
            LoginUserControl.LoginInstance.Show();
            LoginUserControl.LoginInstance.BringToFront();
        }
    }
}
