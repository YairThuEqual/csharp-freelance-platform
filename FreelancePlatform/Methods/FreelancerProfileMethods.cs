using FreelancePlatform.GetterSetter;
using FreelancePlatform.UserControls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FreelancePlatform.Methods
{
    public class FreelancerProfileMethods
    {

        private MySqlConnection connection;

        private string SELECTALLPROFILE = "select id, freelancer_id, name, email, phone, profession, bio, image from freelancerprofile";

        public FreelancerProfileMethods()
        {
            this.connection = new ConnectDatabase().getConnection();
        }

        public FreelancerProfileService freelancerProfileId(int id)
        {
            var sql = SELECTALLPROFILE + " where freelancer_id = @freelancer_id";
            var freelancer = new FreelancerProfileService();
            
            using (var command = new MySqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@freelancer_id", id);

                using (var reader = command.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        freelancer.FreeProfileId = reader.GetInt32("id");
                        freelancer.FreelancerId = reader.GetInt32("freelancer_id");
                        freelancer.Name = reader.GetString("name");
                        freelancer.Email = reader.GetString("email");
                        freelancer.Phone = reader.GetString("phone");
                        freelancer.Profession = reader.GetString("profession");
                        freelancer.Bio = reader.GetString("bio");
                    }
                }
            }
            return freelancer;
        }

        public List<FreelancerProfileService> showAllFreelancerProfile()
        {
            var list = new List<FreelancerProfileService>();
            var sql = SELECTALLPROFILE;

            using (var command = new MySqlCommand(sql, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new FreelancerProfileService
                    {
                        Name = reader.GetString("name"),
                        Email = reader.GetString("email"),
                        Phone = reader.GetString("phone"),
                        Profession = reader.GetString("profession"),
                        Bio = reader.GetString("bio"),
                        Image = reader["image"] != DBNull.Value ? (byte[])reader["image"] : null
                    });
                }
            }
            return list; // Return the correct list
        }

        public FreelancerProfileService freelancerProfileView(int profileId)
        {
            var sql = SELECTALLPROFILE + " where id = @id";
            var freelancer = new FreelancerProfileService();

            using (var command = new MySqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("id", profileId);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        freelancer.FreeProfileId = reader.GetInt32("id");
                        freelancer.FreelancerId = reader.GetInt32("freelancer_id");
                        freelancer.Name = reader.GetString("name");
                        freelancer.Email = reader.GetString("email");
                        freelancer.Phone = reader.GetString("phone");
                        freelancer.Profession = reader.GetString("profession");
                        freelancer.Bio = reader.GetString("bio");
                        // Handling NULL values for Image
                        if (!reader.IsDBNull(reader.GetOrdinal("image")))
                        {
                            freelancer.Image = (byte[])reader["image"];
                        }
                    }
                }
            }
            return freelancer;
        }

        public void createProfile(int id, FreelancerProfileService service)
        {
            var sql = "insert into freelancerprofile (freelancer_id, name, email, phone, profession, bio)" +
                "values (@freelancer_id, @name, @email, @phone, @profession, @bio)";

            using (var comand = new MySqlCommand(sql, connection))
            {
                comand.Parameters.AddWithValue("@freelancer_id", id);
                comand.Parameters.AddWithValue("@name", service.Name);
                comand.Parameters.AddWithValue("@email", service.Email);
                comand.Parameters.AddWithValue("@phone", service.Phone);
                comand.Parameters.AddWithValue("@profession", service.Profession);
                comand.Parameters.AddWithValue("@bio", service.Bio);

                comand.ExecuteNonQuery();
            }
        }

        public void freeProfileImage(int profileId, byte[] image)
        {
            var sql = "update freelancerprofile set image = @image where id = @id";
            
            using(var comand = new MySqlCommand( sql, connection))
            {
                comand.Parameters.AddWithValue("@id", profileId);
                comand.Parameters.AddWithValue("@image", image);

                comand.ExecuteNonQuery();
            }
        }

        public void updateProfile(int profileId, FreelancerProfileService service)
        {
            var sql = "update freelancerprofile set name = @name, email = @email, phone = @phone, profession = @profession, bio = @bio where id = @id";

            using (var comand = new MySqlCommand(sql, connection))
            {
                comand.Parameters.AddWithValue("@id", profileId);
                comand.Parameters.AddWithValue("@name", service.Name);
                comand.Parameters.AddWithValue("@email", service.Email);
                comand.Parameters.AddWithValue("@phone", service.Phone);
                comand.Parameters.AddWithValue("@profession", service.Profession);
                comand.Parameters.AddWithValue("@bio", service.Bio);

                comand.ExecuteNonQuery();
            }
        }

        public List<ClientPostView> ClientPostBrowse()
        {
            var list = new List<ClientPostView>();
            var sql = @"SELECT c.name, c.image, cp.title, cp.client_pf_id, cp.id, cp.budget, cp.status, cp.description
                    FROM clientpost cp 
                    JOIN clientprofile c ON cp.client_pf_id = c.id ORDER BY cp.id ASC";

            using (var command = new MySqlCommand(sql, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new ClientPostView
                    {
                        ClientPfId = Convert.ToInt32(reader["client_pf_id"]),
                        ClientName = reader["name"].ToString(),
                        ClientImage = reader["image"] != DBNull.Value ? (byte[])reader["image"] : null, // Handle null values
                        PostId = Convert.ToInt32(reader["id"]),
                        Title = reader["title"].ToString(),
                        Budget = reader["budget"].ToString(),
                        Status = reader["status"].ToString(),
                        Description = reader["description"].ToString(),
                    });
                }
            }

            return list;
        }

        private void choiceProject(int postId)
        {
            var sql = "update clientpost set status = @status where id = @post_id";
            using (var command = new MySqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@status", "selected");
                command.Parameters.AddWithValue("@post_id", postId);

                command.ExecuteNonQuery();
            }
        }

        public void placeBid(int profileId, int postId, int clientPfId)
        {
            var sql = "insert into bids (post_id, client_pf_id, free_pf_id, status) values (@post_id, @client_pf_id, @free_pf_id, @status)";

            using(var command = new MySqlCommand(sql,connection))
            {
                command.Parameters.AddWithValue("@post_id", postId);
                command.Parameters.AddWithValue("@client_pf_id", clientPfId);
                command.Parameters.AddWithValue("@free_pf_id", profileId);
                command.Parameters.AddWithValue("@status", "in progress");

                command.ExecuteNonQuery();
            }

            choiceProject(postId);
        }

       
    }
}
