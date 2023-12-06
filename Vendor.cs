using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace VendorAppInventory
{
    public class Vendor
    {
        public int Idvendors { get; set; }
        public string CompanyName { get; set; }
        public string EstablishmentDate { get; set; }
        public string LocationCities { get; set; }
        public string LocationCountries { get; set; }
        public string Addresses { get; set; }
        public string PhoneNos { get; set; }
        public int NoOfEmployees { get; set; }
        public byte[]? Images { get; set; }
        public bool ProfessionalService { get; set; }
        public string UserEmail { get; set; }

        private string connectionString = "server=localhost;uid=root;pwd=Asadbek2003;database=vendorinventoryplatform";

        // Function to retrieve data from the vendors table
        public List<Vendor> GetDataFromTable()
        {
            var vendorList = new List<Vendor>();

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sqlquery = "SELECT * FROM vendors";
                using (var cmd = new MySqlCommand(sqlquery, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var vendor = new Vendor
                            {
                                Idvendors = reader.GetInt32("idvendors"),
                                CompanyName = reader.GetString("companyname"),
                                EstablishmentDate = reader.GetString("establishmentdate"),
                                LocationCities = reader.GetString("locationcities"),
                                LocationCountries = reader.GetString("locationcountries"),
                                Addresses = reader.GetString("addresses"),
                                PhoneNos = reader.GetString("phonenos"),
                                NoOfEmployees = reader.GetInt32("noofemployees"),
                                Images = reader["images"] == DBNull.Value ? null : (byte[])reader["images"],
                                ProfessionalService = reader.GetBoolean("professionalservice"),
                                UserEmail = reader.GetString("useremail")
                            };
                            vendorList.Add(vendor);
                        }
                    }
                }
            }
            return vendorList;
        }

        // Function to write data into the vendors table
        public void WriteDataToTable(string companyName, string establishmentDate, string locationCities, string locationCountries, string addresses, string phoneNos, int noOfEmployees, byte[] images, bool professionalService, string userEmail)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sqlquery = @"INSERT INTO vendors (companyname, establishmentdate, locationcities, locationcountries, addresses, phonenos, noofemployees, images, professionalservice, useremail) 
                                    VALUES (@CompanyName, @EstablishmentDate, @LocationCities, @LocationCountries, @Addresses, @PhoneNos, @NoOfEmployees, @Images, @ProfessionalService, @UserEmail)";
                using (var cmd = new MySqlCommand(sqlquery, conn))
                {
                    cmd.Parameters.AddWithValue("@CompanyName", companyName);
                    cmd.Parameters.AddWithValue("@EstablishmentDate", establishmentDate);
                    cmd.Parameters.AddWithValue("@LocationCities", locationCities);
                    cmd.Parameters.AddWithValue("@LocationCountries", locationCountries);
                    cmd.Parameters.AddWithValue("@Addresses", addresses);
                    cmd.Parameters.AddWithValue("@PhoneNos", phoneNos);
                    cmd.Parameters.AddWithValue("@NoOfEmployees", noOfEmployees);
                    cmd.Parameters.AddWithValue("@Images", images);
                    cmd.Parameters.AddWithValue("@ProfessionalService", professionalService);
                    cmd.Parameters.AddWithValue("@UserEmail", userEmail);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Vendor added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool DeleteVendorById(int vendorId)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM vendors WHERE idvendors = @VendorId";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        // Use a parameterized query to prevent SQL injection
                        cmd.Parameters.AddWithValue("@VendorId", vendorId);

                        int result = cmd.ExecuteNonQuery();

                        // Check if any row was deleted
                        if (result > 0)
                        {
                            MessageBox.Show("Vendor deleted successfully.");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No vendor found with the given ID.");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }
    }
}
