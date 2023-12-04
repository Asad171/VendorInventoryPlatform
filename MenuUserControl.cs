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
    public partial class MenuUserControl : UserControl
    {
        public static MenuUserControl MenuInstance = new MenuUserControl();

        public static Vendor vendor = new Vendor();

        public static List<Vendor> VendorList = vendor.GetDataFromTable();

        public static Product product = new Product();

        public static List<Product> ProductList = product.GetAllProducts();
        public MenuUserControl()
        {
            InitializeComponent();
            MenuInstance = this;
        }

        // Method to navigate to Add Vendor Page
        private void AddVendorMenuButton_Click(object sender, EventArgs e)
        {
            if (MainForm.user.IsAdmin)
            {
                this.Hide();
                MainForm.MainInstance.Text = "Add Vendor";
                VendorAddUserControl.VendorAddInstance.Show();
                VendorAddUserControl.VendorAddInstance.BringToFront();
            }
            else
            {
                MessageBox.Show("Only admin can add vendors and products.", "Authentication Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        // Method to navigate to Add Product Page
        private void AddProductMenuButton_Click(object sender, EventArgs e)
        {
            if (MainForm.user.IsAdmin)
            {
                this.Hide();
                foreach (Vendor vendor in MenuUserControl.VendorList)
                {
                    if (vendor.UserEmail == MainForm.user.Email)
                    {
                        AddProductUserControl.vendorComboBox2.Items.Add(vendor.CompanyName);
                    }
                }
                MainForm.MainInstance.Text = "Add Product";

                AddProductUserControl.AddProductInstance.Show();
                AddProductUserControl.AddProductInstance.BringToFront();
            }
            else
            {
                MessageBox.Show("Only admin can add vendors and products.", "Authentication Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // Method to navigate to View Vendor Page
        private void ViewVendorsMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.MainInstance.Text = "View Vendors";
            VendorViewUserControl.VendorViewInstance.Show();
            VendorViewUserControl.VendorViewInstance.BringToFront();
            VendorViewUserControl.VendorViewInstance.DisplayData("Vendors");
        }


        // Method to navigate to View Product Page
        private void ViewProductsMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.MainInstance.Text = "View Products";
            VendorViewUserControl.VendorViewInstance.Show();
            VendorViewUserControl.VendorViewInstance.BringToFront();
            VendorViewUserControl.VendorViewInstance.DisplayData("Products");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MainForm.MainInstance.Close();
        }
    }
}
