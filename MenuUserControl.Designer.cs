namespace VendorAppInventory
{
    partial class MenuUserControl
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
            tableLayoutPanel2 = new TableLayoutPanel();
            LoginLabel = new Label();
            AddVendorMenuButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ViewProductsMenuButton = new Button();
            ViewVendorsMenuButton = new Button();
            AddProductMenuButton = new Button();
            ExitButton = new Button();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(LoginLabel, 0, 0);
            tableLayoutPanel2.Location = new Point(4, 3);
            tableLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(897, 96);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // LoginLabel
            // 
            LoginLabel.Anchor = AnchorStyles.None;
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LoginLabel.ForeColor = SystemColors.ControlLightLight;
            LoginLabel.Location = new Point(359, 27);
            LoginLabel.Margin = new Padding(4, 0, 4, 0);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(179, 41);
            LoginLabel.TabIndex = 5;
            LoginLabel.Text = "Main Menu";
            LoginLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // AddVendorMenuButton
            // 
            AddVendorMenuButton.Anchor = AnchorStyles.None;
            AddVendorMenuButton.BackColor = Color.Honeydew;
            AddVendorMenuButton.ForeColor = Color.MediumSlateBlue;
            AddVendorMenuButton.Location = new Point(3, 3);
            AddVendorMenuButton.Name = "AddVendorMenuButton";
            AddVendorMenuButton.Size = new Size(218, 266);
            AddVendorMenuButton.TabIndex = 13;
            AddVendorMenuButton.Text = "Add Vendor";
            AddVendorMenuButton.UseVisualStyleBackColor = false;
            AddVendorMenuButton.Click += AddVendorMenuButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(ViewProductsMenuButton, 3, 0);
            tableLayoutPanel1.Controls.Add(ViewVendorsMenuButton, 2, 0);
            tableLayoutPanel1.Controls.Add(AddProductMenuButton, 1, 0);
            tableLayoutPanel1.Controls.Add(AddVendorMenuButton, 0, 0);
            tableLayoutPanel1.Location = new Point(4, 133);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(897, 272);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // ViewProductsMenuButton
            // 
            ViewProductsMenuButton.Anchor = AnchorStyles.None;
            ViewProductsMenuButton.BackColor = Color.Honeydew;
            ViewProductsMenuButton.ForeColor = Color.MediumSlateBlue;
            ViewProductsMenuButton.Location = new Point(675, 3);
            ViewProductsMenuButton.Name = "ViewProductsMenuButton";
            ViewProductsMenuButton.Size = new Size(218, 266);
            ViewProductsMenuButton.TabIndex = 16;
            ViewProductsMenuButton.Text = "View Products";
            ViewProductsMenuButton.UseVisualStyleBackColor = false;
            ViewProductsMenuButton.Click += ViewProductsMenuButton_Click;
            // 
            // ViewVendorsMenuButton
            // 
            ViewVendorsMenuButton.Anchor = AnchorStyles.None;
            ViewVendorsMenuButton.BackColor = Color.Honeydew;
            ViewVendorsMenuButton.ForeColor = Color.MediumSlateBlue;
            ViewVendorsMenuButton.Location = new Point(451, 3);
            ViewVendorsMenuButton.Name = "ViewVendorsMenuButton";
            ViewVendorsMenuButton.Size = new Size(218, 266);
            ViewVendorsMenuButton.TabIndex = 15;
            ViewVendorsMenuButton.Text = "View Vendors";
            ViewVendorsMenuButton.UseVisualStyleBackColor = false;
            ViewVendorsMenuButton.Click += ViewVendorsMenuButton_Click;
            // 
            // AddProductMenuButton
            // 
            AddProductMenuButton.Anchor = AnchorStyles.None;
            AddProductMenuButton.BackColor = Color.Honeydew;
            AddProductMenuButton.ForeColor = Color.MediumSlateBlue;
            AddProductMenuButton.Location = new Point(227, 3);
            AddProductMenuButton.Name = "AddProductMenuButton";
            AddProductMenuButton.Size = new Size(218, 266);
            AddProductMenuButton.TabIndex = 14;
            AddProductMenuButton.Text = "Add Product";
            AddProductMenuButton.UseVisualStyleBackColor = false;
            AddProductMenuButton.Click += AddProductMenuButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Right;
            ExitButton.ForeColor = Color.OrangeRed;
            ExitButton.Location = new Point(748, 449);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(149, 49);
            ExitButton.TabIndex = 15;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // MenuUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            Controls.Add(ExitButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MenuUserControl";
            Size = new Size(905, 523);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label LoginLabel;
        private Button AddVendorMenuButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Button ViewProductsMenuButton;
        private Button ViewVendorsMenuButton;
        private Button AddProductMenuButton;
        private Button ExitButton;
    }
}
