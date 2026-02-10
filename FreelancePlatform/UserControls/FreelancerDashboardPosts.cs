using FreelancePlatform.Forms;
using FreelancePlatform.GetterSetter;
using FreelancePlatform.Methods;
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
    public partial class FreelancerDashboardPosts : UserControl
    {

        private int profileId;
        private FreelancerProfileMethods profileMethods;

        public FreelancerDashboardPosts(int profileId, ClientPostView view)
        {
            InitializeComponent();
            this.profileId = profileId;
            this.profileMethods = new FreelancerProfileMethods();

            lblName.Text = view.ClientName;
            lblTitle.Text = view.Title;
            lblDescription.Text = view.Description;
            lblBudget.Text = string.Format("{0:n0}", Convert.ToInt32(view.Budget));
            lblStatus.Text = view.Status;

            // Handle client image safely
            if (view.ClientImage != null && view.ClientImage.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(view.ClientImage))
                {
                    picClientImage.Image = Image.FromStream(ms);
                }
            }

            btnBid.Click += (sender, e) => btnBid_Click(sender, e, view.PostId, view.ClientPfId);

            UpdateBidButtonStatus(view.PostId);
        }

        private void UpdateBidButtonStatus(int postId)
        {
            var posts = profileMethods.ClientPostBrowse();

            var currentPost = posts.FirstOrDefault(post => post.PostId == postId);

            if (currentPost?.Status == "selected")
            {
                btnBid.Text = "In Progress";
                btnBid.ForeColor = Color.Black;
                btnBid.Enabled = false;
                btnBid.Font = new Font(btnBid.Font.FontFamily, 8);
            }
        }

        private void btnBid_Click(object sender, EventArgs e, int postId, int clientPfId)
        {
            if (MessageBox.Show("Are you bid project?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                profileMethods.placeBid(profileId, postId, clientPfId);

                UpdateBidButtonStatus(postId);
            }
        }

        private void FreelancerDashboardPosts_Load(object sender, EventArgs e)
        {

        }

        private void btnBid_Click(object sender, EventArgs e)
        {

        }

        private void FreelancerDashboardPosts_Load_1(object sender, EventArgs e)
        {

        }
    }
}
