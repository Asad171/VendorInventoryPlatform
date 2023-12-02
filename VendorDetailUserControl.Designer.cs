namespace VendorAppInventory
{
    partial class VendorDetailUserControl
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
            PosterImagePictureBox = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            CompanyNameLabel = new Label();
            EstablishmentDateLabel = new Label();
            InternalProfessionalServiceLabel = new Label();
            NoOfEmployeesLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel4 = new Panel();
            LocationCountriesLabel = new Label();
            panel3 = new Panel();
            LocationCitiesLabel = new Label();
            panel2 = new Panel();
            AddressesLabel = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            PhoneNumbersLabel = new Label();
            BackButton = new Button();
            DeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PosterImagePictureBox).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PosterImagePictureBox
            // 
            PosterImagePictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PosterImagePictureBox.Location = new Point(688, 82);
            PosterImagePictureBox.Name = "PosterImagePictureBox";
            PosterImagePictureBox.Size = new Size(244, 204);
            PosterImagePictureBox.TabIndex = 0;
            PosterImagePictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(148, 23);
            label1.TabIndex = 1;
            label1.Text = "Company Name: ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 65);
            label2.Name = "label2";
            label2.Size = new Size(175, 23);
            label2.TabIndex = 2;
            label2.Text = "Establishment Date: ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 116);
            label3.Name = "label3";
            label3.Size = new Size(246, 23);
            label3.TabIndex = 3;
            label3.Text = "Internal Professional Service: ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 167);
            label4.Name = "label4";
            label4.Size = new Size(160, 23);
            label4.TabIndex = 4;
            label4.Text = "No. of Employees: ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(CompanyNameLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(EstablishmentDateLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(InternalProfessionalServiceLabel, 1, 2);
            tableLayoutPanel1.Controls.Add(NoOfEmployeesLabel, 1, 3);
            tableLayoutPanel1.Location = new Point(6, 82);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(538, 204);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // CompanyNameLabel
            // 
            CompanyNameLabel.Anchor = AnchorStyles.Left;
            CompanyNameLabel.AutoSize = true;
            CompanyNameLabel.Location = new Point(272, 14);
            CompanyNameLabel.Name = "CompanyNameLabel";
            CompanyNameLabel.Size = new Size(43, 23);
            CompanyNameLabel.TabIndex = 5;
            CompanyNameLabel.Text = "Null";
            // 
            // EstablishmentDateLabel
            // 
            EstablishmentDateLabel.Anchor = AnchorStyles.Left;
            EstablishmentDateLabel.AutoSize = true;
            EstablishmentDateLabel.Location = new Point(272, 65);
            EstablishmentDateLabel.Name = "EstablishmentDateLabel";
            EstablishmentDateLabel.Size = new Size(43, 23);
            EstablishmentDateLabel.TabIndex = 6;
            EstablishmentDateLabel.Text = "Null";
            // 
            // InternalProfessionalServiceLabel
            // 
            InternalProfessionalServiceLabel.Anchor = AnchorStyles.Left;
            InternalProfessionalServiceLabel.AutoSize = true;
            InternalProfessionalServiceLabel.Location = new Point(272, 116);
            InternalProfessionalServiceLabel.Name = "InternalProfessionalServiceLabel";
            InternalProfessionalServiceLabel.Size = new Size(43, 23);
            InternalProfessionalServiceLabel.TabIndex = 7;
            InternalProfessionalServiceLabel.Text = "Null";
            // 
            // NoOfEmployeesLabel
            // 
            NoOfEmployeesLabel.Anchor = AnchorStyles.Left;
            NoOfEmployeesLabel.AutoSize = true;
            NoOfEmployeesLabel.Location = new Point(272, 167);
            NoOfEmployeesLabel.Name = "NoOfEmployeesLabel";
            NoOfEmployeesLabel.Size = new Size(43, 23);
            NoOfEmployeesLabel.TabIndex = 8;
            NoOfEmployeesLabel.Text = "Null";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(panel4, 3, 1);
            tableLayoutPanel2.Controls.Add(panel3, 2, 1);
            tableLayoutPanel2.Controls.Add(panel2, 1, 1);
            tableLayoutPanel2.Controls.Add(label8, 3, 0);
            tableLayoutPanel2.Controls.Add(label7, 2, 0);
            tableLayoutPanel2.Controls.Add(label6, 1, 0);
            tableLayoutPanel2.Controls.Add(label5, 0, 0);
            tableLayoutPanel2.Controls.Add(panel1, 0, 1);
            tableLayoutPanel2.Location = new Point(6, 316);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel2.Size = new Size(926, 310);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoScroll = true;
            panel4.Controls.Add(LocationCountriesLabel);
            panel4.Location = new Point(696, 49);
            panel4.Name = "panel4";
            panel4.Size = new Size(227, 258);
            panel4.TabIndex = 5;
            // 
            // LocationCountriesLabel
            // 
            LocationCountriesLabel.AutoSize = true;
            LocationCountriesLabel.Location = new Point(5, 5);
            LocationCountriesLabel.Name = "LocationCountriesLabel";
            LocationCountriesLabel.Size = new Size(43, 23);
            LocationCountriesLabel.TabIndex = 3;
            LocationCountriesLabel.Text = "Null";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.AutoScroll = true;
            panel3.Controls.Add(LocationCitiesLabel);
            panel3.Location = new Point(465, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 258);
            panel3.TabIndex = 5;
            // 
            // LocationCitiesLabel
            // 
            LocationCitiesLabel.AutoSize = true;
            LocationCitiesLabel.Location = new Point(5, 5);
            LocationCitiesLabel.Name = "LocationCitiesLabel";
            LocationCitiesLabel.Size = new Size(43, 23);
            LocationCitiesLabel.TabIndex = 2;
            LocationCitiesLabel.Text = "Null";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoScroll = true;
            panel2.Controls.Add(AddressesLabel);
            panel2.Location = new Point(234, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 258);
            panel2.TabIndex = 5;
            // 
            // AddressesLabel
            // 
            AddressesLabel.AutoSize = true;
            AddressesLabel.Location = new Point(5, 5);
            AddressesLabel.Name = "AddressesLabel";
            AddressesLabel.Size = new Size(43, 23);
            AddressesLabel.TabIndex = 1;
            AddressesLabel.Text = "Null";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(730, 11);
            label8.Name = "label8";
            label8.Size = new Size(159, 23);
            label8.TabIndex = 3;
            label8.Text = "Location Countries";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(514, 11);
            label7.Name = "label7";
            label7.Size = new Size(127, 23);
            label7.TabIndex = 2;
            label7.Text = "Location Cities";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(301, 11);
            label6.Name = "label6";
            label6.Size = new Size(90, 23);
            label6.TabIndex = 1;
            label6.Text = "Addresses";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(47, 11);
            label5.Name = "label5";
            label5.Size = new Size(137, 23);
            label5.TabIndex = 0;
            label5.Text = "Phone Numbers";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.Controls.Add(PhoneNumbersLabel);
            panel1.Location = new Point(3, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 258);
            panel1.TabIndex = 4;
            // 
            // PhoneNumbersLabel
            // 
            PhoneNumbersLabel.AutoSize = true;
            PhoneNumbersLabel.Location = new Point(5, 5);
            PhoneNumbersLabel.Name = "PhoneNumbersLabel";
            PhoneNumbersLabel.Size = new Size(43, 23);
            PhoneNumbersLabel.TabIndex = 0;
            PhoneNumbersLabel.Text = "Null";
            // 
            // BackButton
            // 
            BackButton.ForeColor = Color.MediumSlateBlue;
            BackButton.Location = new Point(6, 14);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(136, 42);
            BackButton.TabIndex = 7;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.ForeColor = Color.MediumSlateBlue;
            DeleteButton.Location = new Point(793, 14);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(136, 42);
            DeleteButton.TabIndex = 8;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // VendorDetailUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            Controls.Add(DeleteButton);
            Controls.Add(BackButton);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(PosterImagePictureBox);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(4, 3, 4, 3);
            Name = "VendorDetailUserControl";
            Size = new Size(935, 626);
            ((System.ComponentModel.ISupportInitialize)PosterImagePictureBox).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PosterImagePictureBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private Label CompanyNameLabel;
        private Label EstablishmentDateLabel;
        private Label InternalProfessionalServiceLabel;
        private Label NoOfEmployeesLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label PhoneNumbersLabel;
        private Label LocationCitiesLabel;
        private Label AddressesLabel;
        private Label LocationCountriesLabel;
        private Button BackButton;
        private Button DeleteButton;
    }
}
