using FreelancePlatform.Forms.FreelancerView;
using FreelancePlatform.GetterSetter;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancePlatform.Methods
{
    public class FreelancerCompletedProject
    {

        private MySqlConnection connection;

        public FreelancerCompletedProject()
        {
            connection = new ConnectDatabase().getConnection();
        }

        public List<CompleteProject> bidPosts(int profileId)
        {
            var list = new List<CompleteProject>();
            var sql = "SELECT b.id, b.status,b.image, cp.title, cp.budget, cp.description FROM bids b JOIN clientpost cp ON b.post_id = cp.id WHERE b.free_pf_id = @free_pf_id;";

            using (var command = new MySqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@free_pf_id", profileId);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CompleteProject
                        {
                            BidId = Convert.ToInt32(reader["id"]),
                            Title = reader["title"].ToString(),
                            Budget = reader["budget"].ToString(),
                            Description = reader["description"].ToString(),
                            Status = reader["status"].ToString(),
                            Image = reader["image"] != DBNull.Value ? (byte[])reader["image"] : null
                        });
                    }
                }
            }

            return list;
        }

        public void completedProjectImage(int bidId, byte[] image)
        {
            var sql = "update bids set image = @image, status = @status, date = @date where id = @id";

            using (var command = new  MySqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@id", bidId);
                command.Parameters.AddWithValue("@image", image);
                command.Parameters.AddWithValue("@status", "complete");
                command.Parameters.AddWithValue("@date", DateTime.Now.Date.ToString("dd-MM-yyyy"));

                command.ExecuteNonQuery();
            }
        }

        public bool checkCompledProject(int bidId)
        {
            var sql = "SELECT image FROM bids WHERE id = @id";

            using (var command = new MySqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@id", bidId);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var image = reader["image"];

                        // Ensure the column is not NULL before accessing it
                        if(image != DBNull.Value && image != null && !string.IsNullOrEmpty(image.ToString()))
                        {
                            return true;
                        } 
                    }
                }
            }
            return false; // Return false if no record is found
        }

        public List<CompleteProject> showCompleteProjects(int freePf_id)
        {
            var list = new List<CompleteProject>();
            var sql = @"select b.id, c.name, c.image as client_image, b.image as bid_image, b.status, b.date, cp.title, cp.budget 
                                    from bids b join clientprofile c on b.client_pf_id = c.id
                                    join clientpost cp on b.post_id = cp.id where free_pf_id = @free_pf_id";
            
            using (var command = new MySqlCommand( sql, connection))
            {
                command.Parameters.AddWithValue("@free_pf_id", freePf_id);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CompleteProject
                        {
                            BidId = Convert.ToInt32(reader["id"]),
                            Title = reader["title"].ToString(),
                            Budget = reader["budget"].ToString(),
                            Status = reader["status"].ToString(),
                            Date = reader["date"].ToString(),
                            Image = reader["bid_image"] != DBNull.Value ? (byte[])reader["bid_image"] : null,
                            Name = reader["name"].ToString(),
                            ProfileImgae = reader["client_image"] != DBNull.Value ? (byte[])reader["client_image"] : null
                        });
                    }
                }
            }

            return list;
        }

        public List<CompleteProject> showCompleteProjectForClient()
        {
            var list = new List<CompleteProject>();
            var sql = @"SELECT b.id, c.name, c.image AS client_image, b.image AS bid_image, b.status, b.date, cp.title, cp.budget 
                        FROM bids b JOIN clientprofile c ON b.client_pf_id = c.id 
                        JOIN clientpost cp ON b.post_id = cp.id";

            using (var command = new MySqlCommand(sql, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new CompleteProject
                        {
                            BidId = Convert.ToInt32(reader["id"]),
                            Title = reader["title"].ToString(),
                            Budget = reader["budget"].ToString(),
                            Status = reader["status"].ToString(),
                            Date = reader["date"].ToString(),
                            Image = reader["bid_image"] != DBNull.Value ? (byte[])reader["bid_image"] : null,
                            Name = reader["name"].ToString(),
                            ProfileImgae = reader["client_image"] != DBNull.Value ? (byte[])reader["client_image"] : null
                        });
                    }
                }
            }

            return list;
        }

        public void reviewProject(int bidId, string rating, string comment)
        {
            var sql = "insert into review (bid_id, rating, comment) values (@bid_id, @rating, @comment)";

            using (var command = new MySqlCommand (sql, connection))
            {
                command.Parameters.AddWithValue("@bid_id", bidId);
                command.Parameters.AddWithValue("@rating", rating);
                command.Parameters.AddWithValue("@comment", comment);

                command.ExecuteNonQuery();
            }
        }

        public List<ClientReview> showReviewComment(int bidId)
        {
            var list = new List<ClientReview>();
            var sql = "SELECT rating, comment FROM review WHERE bid_id = @bid_id";

            using (var command = new MySqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@bid_id", bidId);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ClientReview
                        {
                            Rating = reader["rating"].ToString(),
                            Comment = reader["comment"].ToString()
                        });
                    }
                }
            }
            return list;
        }


    }
}
