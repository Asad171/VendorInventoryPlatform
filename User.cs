using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorAppInventory
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        private string connectionString = "server=localhost;uid=root;pwd=Ali12345.;database=vendorinventoryplatform";

        // Function to write data into the users table
        public bool WriteDataToTable(string name, string email, string password, bool isAdmin)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // First, check if a user with the same name or email already exists
                string checkQuery = "SELECT COUNT(*) FROM users WHERE Name = @Name OR Email = @Email";
                using (var checkCmd = new MySqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Name", name);
                    checkCmd.Parameters.AddWithValue("@Email", email);

                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (exists > 0)
                    {
                        // A user with the same name or email already exists
                        MessageBox.Show("A user with the same name or email already exists.", "User Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                // If the user does not exist, insert the new user
                string sqlquery = "INSERT INTO users (Name, Email, Password, Admin) VALUES (@Name, @Email, @Password, @Admin)";
                using (var cmd = new MySqlCommand(sqlquery, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password); // In production, hash the password
                    cmd.Parameters.AddWithValue("@Admin", isAdmin);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }

        // Function to validate if the input matches an email/name and password in the database
        public bool ValidateUser(string input, string password)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sqlquery = @"SELECT * FROM users WHERE (Email = @Input OR Name = @Input) AND Password = @Password";
                using (var cmd = new MySqlCommand(sqlquery, conn))
                {
                    cmd.Parameters.AddWithValue("@Input", input);
                    cmd.Parameters.AddWithValue("@Password", password); // In production, use a hashed password

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // The user with the input email/name and password exists
                            this.ID = reader.GetInt32("ID");
                            this.Name = reader.GetString("Name");
                            this.Email = reader.GetString("Email");
                            this.Password = reader.GetString("Password"); 
                            this.IsAdmin = reader.GetBoolean("Admin");
                            return true;
                        }
                        else
                        {
                            // No user found with the given email/name and password
                            return false;
                        }
                    }
                }
            }
        }
    }
}
