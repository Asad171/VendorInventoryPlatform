using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendorAppInventory
{
    public partial class AddProductUserControl : UserControl
    {
        public static ComboBox vendorComboBox2 = new ComboBox();

        public static AddProductUserControl AddProductInstance = new AddProductUserControl();

        public List<string> pdfFiles = new List<string>();

        public string[] filesToCopy;

        List<Vendor> userSpecificVendorList = new List<Vendor>();

        byte[]? imageBytes = null;

        public AddProductUserControl()
        {
            InitializeComponent();
            AddProductInstance = this;
            ImageFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            vendorComboBox2 = VendorComboBox;
        }

        private void BrowseImageButton_Click(object sender, EventArgs e)
        {
            if (ImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = ImageFileDialog.FileName;
                imageBytes = File.ReadAllBytes(filePath);
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            string productName = ProductNameTextBox.Text;
            string webUrl = WesbiteURLTextBox.Text;
            string typeOfSoftware = TypeOfSoftwareTextBox.Text;
            string businessAreas = BusinessAreaTextBox.Text;
            string modules = ModulesTextBox.Text;
            string description = DescriptionTextBox.Text;
            string additionalInformation = AdditionalInformationTextBox.Text;

            if (productName == null || webUrl == null || typeOfSoftware == null || businessAreas == null || modules == null || description == null || additionalInformation == null)
            {
                MessageBox.Show("Don't leave text boxes empty", "Empty TextBox Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            object selectedVendorObject = VendorComboBox.SelectedItem;
            if (selectedVendorObject == null)
            {
                MessageBox.Show("Select a Vendor for Product.", "Null ComboBox Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string vendorName = VendorComboBox.SelectedItem.ToString();
            string cloudType = String.Empty;

            if (BasedRadioButton.Checked)
            {
                cloudType = BasedRadioButton.Text;
            }
            else if (NativeRadioButton.Checked)
            {
                cloudType = NativeRadioButton.Text;
            }
            else if (EnabledRadioButton.Checked)
            {
                cloudType = EnabledRadioButton.Text;
            }
            else
            {
                MessageBox.Show("Select a Cloud for Product.", "No Cloud Seletected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int vendorId = -1;

            foreach (Vendor vendor in MenuUserControl.VendorList)
            {
                if (vendor.CompanyName == vendorName)
                {
                    vendorId = vendor.Idvendors;
                }
            }

            try
            {
                foreach (string filePath in filesToCopy)
                {

                    string fileName = Path.GetFileName(filePath);

                    string destFile = Path.Combine("../../../PDF Files/", fileName);

                    File.Copy(filePath, destFile, overwrite: false);

                    pdfFiles.Add(fileName);
                }

            }
            catch (IOException ioEx)
            {
                MessageBox.Show($"An error occurred: {ioEx.Message}");
                return;
            }

            MenuUserControl.product.AddProduct(productName, cloudType, webUrl, typeOfSoftware, description, modules, businessAreas, additionalInformation, imageBytes, String.Join(',', pdfFiles), vendorId);


            Product newProduct = new Product();

            MenuUserControl.ProductList = newProduct.GetAllProducts();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuUserControl.MenuInstance.Show();
            MenuUserControl.MenuInstance.BringToFront();
        }

        private void CopySelectedPdfFiles()
        {
            using (PdfFileDialog)
            {
                PdfFileDialog.Filter = "PDF files (*.pdf)|*.pdf"; // Set the filter to PDF files only

                if (PdfFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filesToCopy = PdfFileDialog.FileNames;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CopySelectedPdfFiles();
        }
    }
}
