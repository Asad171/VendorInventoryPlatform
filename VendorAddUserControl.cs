using MySqlX.XDevAPI.Common;
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
    public partial class VendorAddUserControl : UserControl
    {
        public static VendorAddUserControl VendorAddInstance = new VendorAddUserControl();

        byte[]? imageBytes = null;

        public VendorAddUserControl()
        {
            InitializeComponent();
            VendorAddInstance = this;
            ImageFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
        }

        private void AddVendorButton_Click(object sender, EventArgs e)
        {
            string companyName = CompanyNameTextBox.Text;
            string compnayEstablishmentDate = dateTimePicker1.Text;
            string locationCities = CitiesLocationTextBox.Text;
            string locationCountries = CountriesLocationTextBox.Text;
            string contactTelephone = TelephoneTextBox.Text;
            string addresses = AddressesTextBox.Text;
            string noOfEmployees = NoOfEmployeesTextBox.Text;
            bool professionalService = InternalProfessionalCheckBox.Checked;
            int intNoOfEmployees;

            bool success = int.TryParse(noOfEmployees, out intNoOfEmployees);
            if (success)
            {
                MenuUserControl.vendor.WriteDataToTable(companyName, compnayEstablishmentDate, locationCities, locationCountries, addresses, contactTelephone, intNoOfEmployees, imageBytes, professionalService, MainForm.user.Email);
            }
            else
            {
                MessageBox.Show("No. of Employees must be a number", "Invalid Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Vendor newVendor = new Vendor();

            MenuUserControl.VendorList = newVendor.GetDataFromTable();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = ImageFileDialog.FileName;
                imageBytes = File.ReadAllBytes(filePath);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuUserControl.MenuInstance.Show();
            MenuUserControl.MenuInstance.BringToFront();
        }
    }
}
