namespace VendorAppInventory
{
    partial class RegisterUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel5 = new TableLayoutPanel();
            label1 = new Label();
            LoginButton = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            RegisterButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            RegisterLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            UsernameLabel = new Label();
            UsernameTextBox = new TextBox();
            EmailLabel = new Label();
            EmailTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            PasswordLabel = new Label();
            ConfirmPasswordTextBox = new TextBox();
            ConfirmPasswordLabel = new Label();
            AdminCheckBox = new CheckBox();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top;
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.16125F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.6031532F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.2355957F));
            tableLayoutPanel5.Controls.Add(label1, 1, 0);
            tableLayoutPanel5.Controls.Add(LoginButton, 2, 0);
            tableLayoutPanel5.Location = new Point(25, 479);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(901, 49);
            tableLayoutPanel5.TabIndex = 14;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(428, 13);
            label1.Name = "label1";
            label1.Size = new Size(187, 23);
            label1.TabIndex = 0;
            label1.Text = "Already have account?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Left;
            LoginButton.AutoSize = true;
            LoginButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LoginButton.ForeColor = Color.Chartreuse;
            LoginButton.Location = new Point(621, 13);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(104, 23);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Login Here!";
            LoginButton.Click += LoginButton_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(RegisterButton, 1, 0);
            tableLayoutPanel4.Location = new Point(25, 408);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(901, 53);
            tableLayoutPanel4.TabIndex = 13;
            // 
            // RegisterButton
            // 
            RegisterButton.Anchor = AnchorStyles.None;
            RegisterButton.BackColor = Color.Lavender;
            RegisterButton.ForeColor = Color.MediumSlateBlue;
            RegisterButton.Location = new Point(605, 4);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(140, 45);
            RegisterButton.TabIndex = 0;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(RegisterLabel, 0, 0);
            tableLayoutPanel2.Location = new Point(25, 16);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(898, 96);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // RegisterLabel
            // 
            RegisterLabel.Anchor = AnchorStyles.None;
            RegisterLabel.AutoSize = true;
            RegisterLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterLabel.ForeColor = SystemColors.ControlLightLight;
            RegisterLabel.Location = new Point(382, 27);
            RegisterLabel.Margin = new Padding(4, 0, 4, 0);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(134, 41);
            RegisterLabel.TabIndex = 5;
            RegisterLabel.Text = "Register";
            RegisterLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.2933F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.7067032F));
            tableLayoutPanel1.Controls.Add(label2, 0, 4);
            tableLayoutPanel1.Controls.Add(UsernameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(UsernameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(EmailLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(EmailTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(PasswordTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(PasswordLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(ConfirmPasswordTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(ConfirmPasswordLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(AdminCheckBox, 1, 4);
            tableLayoutPanel1.Location = new Point(25, 130);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0010681F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0010567F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0010567F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0010567F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9957619F));
            tableLayoutPanel1.Size = new Size(901, 253);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(288, 215);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 23);
            label2.TabIndex = 11;
            label2.Text = "User Type: ";
            // 
            // UsernameLabel
            // 
            UsernameLabel.Anchor = AnchorStyles.Right;
            UsernameLabel.AutoSize = true;
            UsernameLabel.ForeColor = SystemColors.ControlLightLight;
            UsernameLabel.Location = new Point(279, 13);
            UsernameLabel.Margin = new Padding(4, 0, 4, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(107, 23);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "User Name: ";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Anchor = AnchorStyles.Left;
            UsernameTextBox.Location = new Point(393, 10);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(352, 30);
            UsernameTextBox.TabIndex = 1;
            // 
            // EmailLabel
            // 
            EmailLabel.Anchor = AnchorStyles.Right;
            EmailLabel.AutoSize = true;
            EmailLabel.ForeColor = SystemColors.ControlLightLight;
            EmailLabel.Location = new Point(322, 63);
            EmailLabel.Margin = new Padding(4, 0, 4, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(64, 23);
            EmailLabel.TabIndex = 2;
            EmailLabel.Text = "Email: ";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Anchor = AnchorStyles.Left;
            EmailTextBox.Location = new Point(393, 60);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(352, 30);
            EmailTextBox.TabIndex = 5;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Left;
            PasswordTextBox.Location = new Point(393, 110);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(352, 30);
            PasswordTextBox.TabIndex = 7;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.Right;
            PasswordLabel.AutoSize = true;
            PasswordLabel.ForeColor = SystemColors.ControlLightLight;
            PasswordLabel.Location = new Point(291, 113);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(95, 23);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "Password: ";
            // 
            // ConfirmPasswordTextBox
            // 
            ConfirmPasswordTextBox.Anchor = AnchorStyles.Left;
            ConfirmPasswordTextBox.Location = new Point(393, 160);
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.Size = new Size(352, 30);
            ConfirmPasswordTextBox.TabIndex = 9;
            // 
            // ConfirmPasswordLabel
            // 
            ConfirmPasswordLabel.Anchor = AnchorStyles.Right;
            ConfirmPasswordLabel.AutoSize = true;
            ConfirmPasswordLabel.ForeColor = SystemColors.ControlLightLight;
            ConfirmPasswordLabel.Location = new Point(220, 163);
            ConfirmPasswordLabel.Margin = new Padding(4, 0, 4, 0);
            ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            ConfirmPasswordLabel.Size = new Size(166, 23);
            ConfirmPasswordLabel.TabIndex = 8;
            ConfirmPasswordLabel.Text = "Confirm Password: ";
            // 
            // AdminCheckBox
            // 
            AdminCheckBox.Anchor = AnchorStyles.Left;
            AdminCheckBox.AutoSize = true;
            AdminCheckBox.Location = new Point(393, 213);
            AdminCheckBox.Name = "AdminCheckBox";
            AdminCheckBox.Size = new Size(86, 27);
            AdminCheckBox.TabIndex = 12;
            AdminCheckBox.Text = "Admin";
            AdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // RegisterUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            Controls.Add(tableLayoutPanel5);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "RegisterUserControl";
            Size = new Size(950, 600);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel5;
        private Label label1;
        private Label LoginButton;
        private TableLayoutPanel tableLayoutPanel4;
        private Button RegisterButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Label RegisterLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label UsernameLabel;
        private TextBox UsernameTextBox;
        private Label EmailLabel;
        private TextBox EmailTextBox;
        private TextBox PasswordTextBox;
        private Label PasswordLabel;
        private Label ConfirmPasswordLabel;
        private TextBox ConfirmPasswordTextBox;
        private Label label2;
        private CheckBox AdminCheckBox;
    }
}
