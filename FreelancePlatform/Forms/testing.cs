using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FreelancePlatform.Forms
{
    public partial class testing : Form
    {
        public testing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Step 1: Open a file dialog to select the image
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                //string imageName = Path.GetFileName(imagePath);
                string imageName = "testing";

                // Step 2: Convert the image to a byte array
                byte[] imageBytes = File.ReadAllBytes(imagePath);
                var connection = new ConnectDatabase().getConnection();
                // Step 5: Define the SQL query to insert the image
                string query = "INSERT INTO Images (ImageData, ImageName) VALUES (@ImageData, @ImageName)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@ImageData", imageBytes);
                    cmd.Parameters.AddWithValue("@ImageName", imageName);

                    // Step 7: Execute the query
                    cmd.ExecuteNonQuery();
                }
            }

            testing_Load(sender, e);
        }

        private void testing_Load(object sender, EventArgs e)
        {
            var conn = new ConnectDatabase().getConnection();
            string query = "SELECT ImageData, imageName FROM Images";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Retrieve image data
                        byte[] imageBytes = (byte[])reader["ImageData"];
                        string? imageName = reader["imageName"].ToString();

                        long maxSizeInBytes = 5 * 1024 * 1024; // 5MB
                        if (imageBytes.Length > maxSizeInBytes)
                        {
                            MessageBox.Show("The image file is too large. Please select a smaller file.");
                            return;
                        }

                        // Convert byte array to image
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                            label1.Text = imageName;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No image data found in the database.");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
