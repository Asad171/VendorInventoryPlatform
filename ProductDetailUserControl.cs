using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendorAppInventory
{
    public partial class ProductDetailUserControl : UserControl
    {
        public static ProductDetailUserControl ProductDetailInstance = new ProductDetailUserControl();

        public int productId = -1;
        public ProductDetailUserControl()
        {
            InitializeComponent();
            ProductDetailInstance = this;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void SetData(int data)
        {
            Product product = MenuUserControl.ProductList[data];
            productId = data;
            string vendorName = String.Empty;


            foreach (Vendor vendor in MenuUserControl.VendorList)
            {
                if (product.VendorId == vendor.Idvendors)
                {
                    vendorName = vendor.CompanyName;
                    break;
                }
            }


            ProductNameLabel.Text = product.ProductName;

            CompanyNameLabel.Text = vendorName;
            ProductWebsiteLinkLabel.Text = product.WebUrl;
            TypeOfSoftwareLabel.Text = product.TypeOfSoftware;
            DescriptionTextBox.Text = product.Description;
            ModulesLabel.Text = product.Modules;
            AdditionalInformationLabel.Text = product.AdditionalInformation;

            if (product.PosterImage != null)
            {
                using (var ms = new MemoryStream(product.PosterImage))
                {
                    ProductPosterImage.Image = Image.FromStream(ms);
                }
            }

            foreach (string pdffile in product.PdfFiles.Split(','))
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Location = new Point(3, 0);
                label.Size = new Size(69, 23);
                label.Text = pdffile;
                AttachedDocumentsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                AttachedDocumentsTableLayoutPanel.Controls.Add(label);
                label.Click += (sender, e) => OpenPdfFile($"../../../PDF Files/{label.Text}"); ;
            }

        }

        void OpenPdfFile(string filename)
        {
            string absolutePath = Path.GetFullPath(filename);

            // Check if the file exists
            if (File.Exists(absolutePath))
            {
                try
                {
                    Process.Start(new ProcessStartInfo(absolutePath) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show($"The file {absolutePath} does not exist.");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.DeleteProductById(MenuUserControl.ProductList[productId].Id);
            MenuUserControl.ProductList.Remove(MenuUserControl.ProductList[productId]);


            this.Hide();
            MainForm.MainInstance.Text = "Main Menu";
            MenuUserControl.MenuInstance.Show();
            MenuUserControl.MenuInstance.BringToFront();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.MainInstance.Text = "Vendor View";
            VendorViewUserControl.VendorViewInstance.Show();
            VendorViewUserControl.VendorViewInstance.BringToFront();
        }
    }
}
