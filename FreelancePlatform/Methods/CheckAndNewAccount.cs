using FreelancePlatform.GetterSetter;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FreelancePlatform.Methods
{
    public class CheckAndNewAccount
    {

        public CheckAndNewAccount() {
            
        }

        public bool checkRegiration(UserTypeService user)
        {
            var connection = new ConnectDatabase().getConnection();
            string sql = "SELECT COUNT(*) FROM signup WHERE username = @username AND password = @password AND user_type = @user_type";

            using (var cmd = new MySqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@username", user.getName());
                cmd.Parameters.AddWithValue("@password", user.getPassword());
                cmd.Parameters.AddWithValue("@user_type", user.getType()); // Ensure this returns the correct string value

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Return true if a matching record is found
                        return Convert.ToInt32(reader[0]) > 0;
                    }
                    reader.Close();
                    connection.Close();
                }
            }

            return false; // Return false if no matching record is found
        }

        public void registrationAccount(UserTypeService user)
        {
            var connection = new ConnectDatabase().getConnection();
            string sql = "INSERT INTO signup (username, password, user_type) VALUES (@username, @password, @user_type)";

            using (var cmd = new MySqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@username", user.getName());
                cmd.Parameters.AddWithValue("@password", user.getPassword());
                cmd.Parameters.AddWithValue("@user_type", user.getType());

                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public int getUserId(UserTypeService user)
        {
            var connection = new ConnectDatabase().getConnection();
            string sql = "SELECT id FROM signup WHERE username = @username AND password = @password AND user_type = @user_type";

            using (var cmd = new MySqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@username", user.getName());
                cmd.Parameters.AddWithValue("@password", user.getPassword());
                cmd.Parameters.AddWithValue("@user_type", user.getType()); // Ensure this returns the correct string value

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Return true if a matching record is found
                        return Convert.ToInt32(reader["id"]);
                    }
                    reader.Close();
                    connection.Close();
                }
            }

            return 0; // Return false if no matching record is found
        }
    }
}
