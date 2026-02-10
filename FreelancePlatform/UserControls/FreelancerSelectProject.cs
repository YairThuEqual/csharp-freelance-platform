using FreelancePlatform.GetterSetter;
using FreelancePlatform.Methods;
using K4os.Compression.LZ4.Encoders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FreelancePlatform.UserControls
{
    public partial class FreelancerSelectProject : UserControl
    {
        private int profileId;
        private int bidId;
        private string status;

        private FreelancerCompletedProject completedProject;
        private FreelancerProfileMethods profileMethods;

        public FreelancerSelectProject(int profileId, CompleteProject post)
        {
            InitializeComponent();
            this.profileId = profileId;
            this.profileMethods = new FreelancerProfileMethods();
            this.completedProject = new FreelancerCompletedProject();
            this.bidId = post.BidId;
            this.status = post.Status;

            load(post);
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you complete project?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Visible = false;
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog imageFile = new OpenFileDialog();
            imageFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (imageFile.ShowDialog() == DialogResult.OK)
            {
                string imagePath = imageFile.FileName;

                byte[] imageBytes = File.ReadAllBytes(imagePath);
                completedProject.completedProjectImage(this.bidId, imageBytes);

                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
                btnComplete.Visible = true;
            }
            else
            {
                MessageBox.Show("no reach image");
            }
        }

        private void FreelancerSelectProject_Load(object sender, EventArgs e)
        {

        }

        private void load(CompleteProject post)
        {
            if(post.Status != "complete")
            {
                lblTitle.Text = post.Title;
                lblBudget.Text = int.Parse(post.Budget).ToString("N0");
                txtDescription.Text = post.Description;     

                btnComplete.Visible = false;
            } 
            else if(post.Status == "complete")
            {
                this.Visible = false;
            }
            else
            {
                using (MemoryStream ms = new MemoryStream(post.Image))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
                btnComplete.Visible = true;
            }
        }
    }
}
