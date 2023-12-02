using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendorAppInventory
{

    public partial class VendorViewUserControl : UserControl
    {
        public static VendorViewUserControl VendorViewInstance = new VendorViewUserControl();

        public VendorViewUserControl()
        {
            InitializeComponent();
            VendorViewInstance = this;
            PopulateVendorMainTableLayoutPanel();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void PopulateProductMainTableLayoutPanel()
        {
            tableLayoutPanel1.Controls.Clear();

            for (int i = 0; i < (MenuUserControl.ProductList.Count / 2); i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 350F));
            }

            int productId = 0;
            foreach (var prodcut in MenuUserControl.ProductList)
            {
                TableLayoutPanel subLayout = CreateSubTableLayoutPanel(prodcut.PosterImage, prodcut.ProductName, prodcut.Description, productId, "product");
                tableLayoutPanel1.Controls.Add(subLayout);
                productId++;
            }
        }


        private void PopulateVendorMainTableLayoutPanel()
        {
            tableLayoutPanel1.Controls.Clear();
            for (int i = 0; i < (MenuUserControl.VendorList.Count / 2); i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 350F));
            }

            int vendorId = 0;
            foreach (var vendor in MenuUserControl.VendorList)
            {
                TableLayoutPanel subLayout = CreateSubTableLayoutPanel(vendor.Images, vendor.CompanyName, vendor.CompanyName, vendorId, "vendor");
                tableLayoutPanel1.Controls.Add(subLayout);
                vendorId++;
            }
        }

        private void tableLayoutPanel1_Resize(object sender, EventArgs e)
        {

            //// Set the threshold width for increasing/decreasing columns
            //int increaseThreshold = 500;
            //int decreaseThreshold = 300;

            //// Adjust the number of columns based on the form's width
            //if (tableLayoutPanel1.Width > increaseThreshold)
            //{
            //    // Increase the number of columns
            //    tableLayoutPanel1.ColumnCount = 3; // Set the desired number of columns
            //}
            //else if (tableLayoutPanel1.Width < decreaseThreshold)
            //{
            //    // Decrease the number of columns
            //    tableLayoutPanel1.ColumnCount = 1; // Set the desired number of columns
            //}
            //else
            //{
            //    // Keep the default number of columns
            //    tableLayoutPanel1.ColumnCount = 2; // Set the default number of columns
            //}


            //// Reshuffle the items in the TableLayoutPanel
            //ReshuffleTableLayout();
        }



        public TableLayoutPanel CreateSubTableLayoutPanel(byte[] blobData, string detailText, string descriptionText, int vendorID, string redirect)
        {

            // Create the sub TableLayoutPanel
            TableLayoutPanel subTableLayoutPanel = new TableLayoutPanel();
            subTableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            subTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            subTableLayoutPanel.Location = new Point(3, 3);
            subTableLayoutPanel.ColumnCount = 1;
            subTableLayoutPanel.RowCount = 3;
            subTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            subTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            subTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
            if (redirect == "vendor")
            {
                subTableLayoutPanel.Click += (sender, e) => redirectToVendorDetailPage(vendorID);
            }
            else
            {
                subTableLayoutPanel.Click += (sender, e) => redirectToProductDetailPage(vendorID);
            }

            // Add PictureBox
            PictureBox pictureBox = new PictureBox();
            pictureBox.Anchor = AnchorStyles.None;
            pictureBox.Location = new Point(101, 3);
            pictureBox.Size = new Size(234, 194);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;

            if (blobData != null)
            {
                using (var ms = new MemoryStream(blobData))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }
            }

            subTableLayoutPanel.Controls.Add(pictureBox, 0, 0);

            if (redirect == "vendor")
            {
                pictureBox.Click += (sender, e) => redirectToVendorDetailPage(vendorID);
            }
            else
            {
                pictureBox.Click += (sender, e) => redirectToProductDetailPage(vendorID);
            }

            // Add Label
            Label detailLabel = new Label();
            detailLabel.Anchor = AnchorStyles.None;
            detailLabel.AutoSize = true;
            detailLabel.Location = new Point(189, 200);
            detailLabel.Size = new Size(59, 20);
            detailLabel.Text = detailText;
            detailLabel.TextAlign = ContentAlignment.MiddleCenter;
            subTableLayoutPanel.Controls.Add(detailLabel, 0, 1);

            if (redirect == "vendor")
            {
                detailLabel.Click += (sender, e) => redirectToVendorDetailPage(vendorID);
            }
            else
            {
                detailLabel.Click += (sender, e) => redirectToProductDetailPage(vendorID);
            }

            // Add TextBox for description
            TextBox descriptionTextBox = new TextBox();
            descriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            descriptionTextBox.ForeColor = SystemColors.InactiveCaption;
            descriptionTextBox.Location = new Point(3, 223);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.ReadOnly = true;
            descriptionTextBox.Size = new Size(431, 124);
            descriptionTextBox.TabIndex = 1;
            descriptionTextBox.Text = descriptionText;
            descriptionTextBox.ScrollBars = ScrollBars.Vertical;
            subTableLayoutPanel.Controls.Add(descriptionTextBox, 0, 2);

            return subTableLayoutPanel;
        }

        public void redirectToVendorDetailPage(int data)
        {
            this.Hide();
            MainForm.MainInstance.Text = "Vendor Details";
            VendorDetailUserControl.VendorDetailInstance.Show();
            VendorDetailUserControl.VendorDetailInstance.BringToFront();
            VendorDetailUserControl.VendorDetailInstance.SetData(data);
        }

        public void redirectToProductDetailPage(int data)
        {
            this.Hide();
            MainForm.MainInstance.Text = "Product Details";
            ProductDetailUserControl.ProductDetailInstance.Show();
            ProductDetailUserControl.ProductDetailInstance.BringToFront();
            ProductDetailUserControl.ProductDetailInstance.SetData(data);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.MainInstance.Text = "Main Menu";
            MenuUserControl.MenuInstance.Show();
            MenuUserControl.MenuInstance.BringToFront();
        }

        private void VednorsButton_Click(object sender, EventArgs e)
        {
            PopulateVendorMainTableLayoutPanel();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            PopulateProductMainTableLayoutPanel();
        }

        // A method to decide which data to show
        public void DisplayData(string dataType)
        {
            if (dataType == "Vendors")
            {
                PopulateVendorMainTableLayoutPanel();
            }
            else if (dataType == "Products")
            {
                PopulateProductMainTableLayoutPanel();
            }
        }
    }
}
