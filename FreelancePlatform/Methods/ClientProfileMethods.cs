using FreelancePlatform.GetterSetter;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancePlatform.Methods
{
    public class ClientProfileMethods
    {

        public int clientProfileId(int id)
        {
            var connection = new ConnectDatabase().getConnection();
            var sql = "select id from clientprofile where client_id = @client_id";

            using (var command = new MySqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@client_id", id);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return Convert.ToInt32(reader[0]);
                    }
                    reader.Close();
                }
                command.ExecuteNonQuery();
                connection.Close();
            }

            return 0;
        }

        public void createProfile(ClientProfileService service)
        {
            var connection = new ConnectDatabase().getConnection();
            var sql = "insert into clientprofile (client_id, name, email, phone, company, address) values (@client_id, @name, @email, @phone, @company, @address)";

            using (var command = new MySqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@client_id", service.ClientId);
                command.Parameters.AddWithValue("@name", service.Name);
                command.Parameters.AddWithValue("@email", service.Email);
                command.Parameters.AddWithValue("@phone", service.Phone);
                command.Parameters.AddWithValue("@company", service.Company);
                command.Parameters.AddWithValue("@address", service.Address);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void editProfileImage(int profileId, byte[] image)
        {
            var connection = new ConnectDatabase().getConnection();
            var sql = "UPDATE clientprofile SET image = @image WHERE id = @id";

            using (var command = new MySqlCommand(sql, connection)) 
            {
                command.Parameters.AddWithValue("@id", profileId);
                command.Parameters.AddWithValue("@image", image);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void editProfileStatus(int profileId, ClientProfileService service)
        {
            var connection = new ConnectDatabase().getConnection();
            var sql = "UPDATE clientprofile SET name = @name, email = @email, phone = @phone, company = @company, address = @address WHERE id = @id";

            using (var command = new MySqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@id", profileId);
                command.Parameters.AddWithValue("@name", service.Name);
                command.Parameters.AddWithValue("@email", service.Email);
                command.Parameters.AddWithValue("@phone", service.Phone);
                command.Parameters.AddWithValue("@company", service.Company);
                command.Parameters.AddWithValue("@address", service.Address);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public ClientProfileService clientProfile(int profileId)
        {
            var profile = new ClientProfileService();
            var connection = new ConnectDatabase().getConnection();
            string sql = "select name, email, phone, company, address, image from clientprofile where id = @id";

            using (var command = new MySqlCommand(sql, connection)) {
                command.Parameters.AddWithValue("@id", profileId);

                using (var reader = command.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        profile.Name = reader.GetString("name");
                        profile.Email = reader.GetString("email");
                        profile.Phone = reader.GetString("phone");
                        profile.Company = reader.GetString("company");
                        profile.Address = reader.GetString("address");

                        // Handling NULL values for Image
                        if (!reader.IsDBNull(reader.GetOrdinal("image")))
                        {
                            profile.Image = (byte[])reader["image"];
                        }
                    }
                    reader.Close();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            return profile;
        }

        public void clientPost(int clientProfileId, ClientPostService service)
        {

            var connection = new ConnectDatabase().getConnection();
            var sql = "insert into clientpost (client_pf_id, title, budget, timeline, description, status)" +
                "values (@client_pf_id, @title, @budget, @timeline, @description, @status)";

            using (var command = new MySqlCommand(sql, connection)) {
                command.Parameters.AddWithValue("@client_pf_id", clientProfileId);
                command.Parameters.AddWithValue("@title", service.Title);
                command.Parameters.AddWithValue("@budget", service.Budget);
                command.Parameters.AddWithValue("@timeline", service.Timeline);
                command.Parameters.AddWithValue("@description", service.Description);
                command.Parameters.AddWithValue("@status", service.Status);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public List<ClientPostService> clientViewPosted(int clientPfId)
        {
            var list = new List<ClientPostService>();
            var connection = new ConnectDatabase().getConnection();
            var sql = "select title, budget, timeline, description from clientpost where client_pf_id = @client_pf_id";

            using (var command = new MySqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@client_pf_id", clientPfId);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var post = new ClientPostService
                        {
                            Title = reader.GetString("title"),
                            Budget = reader.GetString("budget"),
                            Timeline = reader.GetString("timeline"),
                            Description = reader.GetString("description")
                        };
                        list.Add(post);
                    }

                    reader.Close();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            return list;
        }
    }
}
