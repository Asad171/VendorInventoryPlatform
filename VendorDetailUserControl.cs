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
    public partial class VendorDetailUserControl : UserControl
    {
        public static VendorDetailUserControl VendorDetailInstance = new VendorDetailUserControl();

        public int vendorId = -1;
        public VendorDetailUserControl()
        {
            InitializeComponent();
            VendorDetailInstance = this;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.MainInstance.Text = "Vendor View";
            VendorViewUserControl.VendorViewInstance.Show();
            VendorViewUserControl.VendorViewInstance.BringToFront();
        }

        public void SetData(int data)
        {
            Vendor vendor = MenuUserControl.VendorList[data];
            vendorId = data;

            CompanyNameLabel.Text = vendor.CompanyName;
            EstablishmentDateLabel.Text = vendor.EstablishmentDate;
            if (vendor.ProfessionalService)
            {
                InternalProfessionalServiceLabel.Text = "Yes";
            }
            else
            {
                InternalProfessionalServiceLabel.Text = "No";
            }
            NoOfEmployeesLabel.Text = vendor.NoOfEmployees.ToString();
            PhoneNumbersLabel.Text = vendor.PhoneNos;
            AddressesLabel.Text = vendor.Addresses;
            LocationCountriesLabel.Text = vendor.LocationCountries;
            LocationCitiesLabel.Text = vendor.LocationCities;
            if (vendor.Images != null)
            {
                using (var ms = new MemoryStream(vendor.Images))
                {
                    PosterImagePictureBox.Image = Image.FromStream(ms);
                }
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Vendor vendor = new Vendor();
            vendor.DeleteVendorById(MenuUserControl.VendorList[vendorId].Idvendors);
            MessageBox.Show(MenuUserControl.VendorList[vendorId].Idvendors.ToString());
            MenuUserControl.VendorList.Remove(MenuUserControl.VendorList[vendorId]);


            this.Hide();
            MainForm.MainInstance.Text = "Main Menu";
            MenuUserControl.MenuInstance.Show();
            MenuUserControl.MenuInstance.BringToFront();
        }
    }
}
