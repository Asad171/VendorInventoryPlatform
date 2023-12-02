namespace VendorAppInventory
{

    public partial class LoginUserControl : UserControl
    {


        static public LoginUserControl LoginInstance = new LoginUserControl();
        public LoginUserControl()
        {
            InitializeComponent();
            LoginInstance = this;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.MainInstance.Text = "Register";
            RegisterUserControl.RegisterInstance.Show();
            RegisterUserControl.RegisterInstance.BringToFront();

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userName = NameTextBox.Text;
            string userPassword = PasswordTextBox.Text;

            if (userName == string.Empty || userPassword == string.Empty)
            {
                MessageBox.Show("All fields must be filled", "Invalid Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isUser = MainForm.user.ValidateUser(userName, userPassword);


            if (isUser)
            {
                // Login successful
                MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                MainForm.MainInstance.Text = "Main Menu";

                MenuUserControl.MenuInstance.Show();
                MenuUserControl.MenuInstance.BringToFront();
            }
            else
            {
                // Login failed
                MessageBox.Show("Login failed. Please check your username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
