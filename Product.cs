using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace VendorAppInventory
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string CloudType { get; set; }
        public string WebUrl { get; set; }
        public string TypeOfSoftware { get; set; }
        public string Description { get; set; }
        public string Modules { get; set; }
        public string BusinessAreas { get; set; }
        public string AdditionalInformation { get; set; }
        public byte[]? PosterImage { get; set; }
        public string PdfFiles { get; set; }
        public int VendorId { get; set; }

        private string connectionString = "server=localhost;uid=root;pwd=Ali12345.;database=vendorinventoryplatform";

        // Function to get data from the products table
        public List<Product> GetAllProducts()
        {
            List<Product> productList = new List<Product>();

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM products";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productList.Add(new Product
                            {
                                Id = reader.GetInt32("idproducts"),
                                ProductName = reader.GetString("productnames"),
                                CloudType = reader.GetString("cloudtypes"),
                                WebUrl = reader.GetString("weburls"),
                                TypeOfSoftware = reader.GetString("typeofsoftwares"),
                                Description = reader.GetString("description"),
                                Modules = reader.GetString("modules"),
                                BusinessAreas = reader.GetString("businessareas"),
                                AdditionalInformation = reader.GetString("additionalinformations"),
                                PosterImage = reader["posterimages"] == DBNull.Value ? null : (byte[])reader["posterimages"],
                                PdfFiles = reader["pdfs"] == DBNull.Value ? null: reader.GetString("pdfs"),
                                VendorId = reader.GetInt32("idvendors")
                            }); ;
                        }
                    }
                }
            }

            return productList;
        }

        // Function to add data to the products table
        public void AddProduct(string productName, string cloudType, string webUrl, string typeOfSoftware, string description, string modules, string businessAreas, string additionalInformation, byte[]? posterImage, string fileNames, int vendorId)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO products (productnames, cloudtypes, weburls, typeofsoftwares, description, 
                                modules, businessareas, additionalinformations, posterimages, pdfs, idvendors) 
                                VALUES (@ProductName, @CloudType, @WebUrl, @TypeOfSoftware, @Description, 
                                @Modules, @BusinessAreas, @AdditionalInformation, @PosterImage, @Pdf, @VendorId)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@CloudType", cloudType);
                    cmd.Parameters.AddWithValue("@WebUrl", webUrl);
                    cmd.Parameters.AddWithValue("@TypeOfSoftware", typeOfSoftware);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Modules", modules);
                    cmd.Parameters.AddWithValue("@BusinessAreas", businessAreas);
                    cmd.Parameters.AddWithValue("@AdditionalInformation", additionalInformation);
                    cmd.Parameters.AddWithValue("@PosterImage", posterImage);
                    cmd.Parameters.AddWithValue("@Pdf", fileNames);
                    cmd.Parameters.AddWithValue("@VendorId", vendorId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool DeleteProductById(int productId)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM products WHERE idproducts = @ProductId";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        // Use a parameterized query to prevent SQL injection
                        cmd.Parameters.AddWithValue("@ProductId", productId);

                        int result = cmd.ExecuteNonQuery();

                        // Check if any row was deleted
                        if (result > 0)
                        {
                            MessageBox.Show("Product deleted successfully.");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No product found with the given ID.");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions, such as database connection issues
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }
    }
}
