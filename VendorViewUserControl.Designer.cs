namespace VendorAppInventory
{
    partial class VendorViewUserControl
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
            tableLayoutPanel1 = new TableLayoutPanel();
            SearchTextBox = new TextBox();
            SearchButton = new Button();
            VednorsButton = new Button();
            ProductsButton = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(25, 108);
            tableLayoutPanel1.MaximumSize = new Size(950, 700);
            tableLayoutPanel1.MinimumSize = new Size(500, 350);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 350F));
            tableLayoutPanel1.Size = new Size(949, 574);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            tableLayoutPanel1.Resize += tableLayoutPanel1_Resize;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            SearchTextBox.Location = new Point(583, 57);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(304, 31);
            SearchTextBox.TabIndex = 0;
            // 
            // SearchButton
            // 
            SearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchButton.Location = new Point(881, 53);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(93, 38);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // VednorsButton
            // 
            VednorsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            VednorsButton.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            VednorsButton.FlatAppearance.BorderSize = 5;
            VednorsButton.ForeColor = Color.OrangeRed;
            VednorsButton.Location = new Point(372, 51);
            VednorsButton.Name = "VednorsButton";
            VednorsButton.Size = new Size(95, 40);
            VednorsButton.TabIndex = 2;
            VednorsButton.Text = "Vendors";
            VednorsButton.UseVisualStyleBackColor = true;
            VednorsButton.Click += VednorsButton_Click;
            // 
            // ProductsButton
            // 
            ProductsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ProductsButton.ForeColor = Color.OrangeRed;
            ProductsButton.Location = new Point(464, 51);
            ProductsButton.Name = "ProductsButton";
            ProductsButton.Size = new Size(95, 40);
            ProductsButton.TabIndex = 3;
            ProductsButton.Text = "Products";
            ProductsButton.UseVisualStyleBackColor = true;
            ProductsButton.Click += ProductsButton_Click;
            // 
            // BackButton
            // 
            BackButton.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            BackButton.FlatAppearance.BorderSize = 5;
            BackButton.ForeColor = Color.MediumSlateBlue;
            BackButton.Location = new Point(25, 51);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(131, 40);
            BackButton.TabIndex = 4;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // VendorViewUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            Controls.Add(BackButton);
            Controls.Add(ProductsButton);
            Controls.Add(VednorsButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchTextBox);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "VendorViewUserControl";
            Size = new Size(1000, 700);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox SearchTextBox;
        private Button SearchButton;
        private Button VednorsButton;
        private Button ProductsButton;
        private Button BackButton;
    }
}
