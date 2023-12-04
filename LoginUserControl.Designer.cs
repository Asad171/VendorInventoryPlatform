namespace VendorAppInventory
{
    partial class LoginUserControl
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
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            RegisterButton = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            LoginButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            LoginLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            PasswordLabel = new Label();
            NameLabel = new Label();
            PasswordTextBox = new TextBox();
            NameTextBox = new TextBox();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.16125F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.6031532F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.2355957F));
            tableLayoutPanel4.Controls.Add(label1, 1, 0);
            tableLayoutPanel4.Controls.Add(RegisterButton, 2, 0);
            tableLayoutPanel4.Location = new Point(79, 435);
            tableLayoutPanel4.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(838, 40);
            tableLayoutPanel4.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(378, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 23);
            label1.TabIndex = 0;
            label1.Text = "Don't have an account?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegisterButton
            // 
            RegisterButton.Anchor = AnchorStyles.Left;
            RegisterButton.AutoSize = true;
            RegisterButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            RegisterButton.ForeColor = Color.DarkGreen;
            RegisterButton.Location = new Point(579, 8);
            RegisterButton.Margin = new Padding(4, 0, 4, 0);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(125, 23);
            RegisterButton.TabIndex = 1;
            RegisterButton.Text = "Register Here!";
            RegisterButton.Click += RegisterButton_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.4817429F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.5182571F));
            tableLayoutPanel3.Controls.Add(LoginButton, 1, 0);
            tableLayoutPanel3.Location = new Point(79, 356);
            tableLayoutPanel3.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(830, 61);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.None;
            LoginButton.BackColor = Color.Lavender;
            LoginButton.BackgroundImageLayout = ImageLayout.None;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.ForeColor = Color.MediumSlateBlue;
            LoginButton.Location = new Point(568, 8);
            LoginButton.Margin = new Padding(4, 3, 4, 3);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(145, 45);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(LoginLabel, 0, 0);
            tableLayoutPanel2.Location = new Point(4, 14);
            tableLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(980, 96);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // LoginLabel
            // 
            LoginLabel.Anchor = AnchorStyles.None;
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LoginLabel.ForeColor = SystemColors.ControlLightLight;
            LoginLabel.Location = new Point(441, 27);
            LoginLabel.Margin = new Padding(4, 0, 4, 0);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(97, 41);
            LoginLabel.TabIndex = 5;
            LoginLabel.Text = "Login";
            LoginLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.759037F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.240963F));
            tableLayoutPanel1.Controls.Add(PasswordLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(NameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(PasswordTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(NameTextBox, 1, 0);
            tableLayoutPanel1.Location = new Point(4, 191);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.Size = new Size(980, 121);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.Right;
            PasswordLabel.AutoSize = true;
            PasswordLabel.ForeColor = SystemColors.ControlLightLight;
            PasswordLabel.Location = new Point(289, 78);
            PasswordLabel.Margin = new Padding(5, 0, 5, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(95, 23);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password :";
            PasswordLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.Right;
            NameLabel.AutoSize = true;
            NameLabel.ForeColor = SystemColors.ControlLightLight;
            NameLabel.Location = new Point(225, 17);
            NameLabel.Margin = new Padding(5, 0, 5, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(159, 23);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "User Name/Email :";
            NameLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Left;
            PasswordTextBox.Location = new Point(393, 74);
            PasswordTextBox.Margin = new Padding(4, 3, 4, 3);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(380, 30);
            PasswordTextBox.TabIndex = 1;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Left;
            NameTextBox.Location = new Point(393, 14);
            NameTextBox.Margin = new Padding(4, 3, 4, 3);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(380, 30);
            NameTextBox.TabIndex = 3;
            // 
            // LoginUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginUserControl";
            Size = new Size(1000, 700);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private Label RegisterButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Button LoginButton;
        private TableLayoutPanel tableLayoutPanel2;
        private Label LoginLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label PasswordLabel;
        private Label NameLabel;
        private TextBox PasswordTextBox;
        private TextBox NameTextBox;
    }
}
