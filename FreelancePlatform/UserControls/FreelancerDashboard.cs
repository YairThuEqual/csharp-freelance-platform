using FreelancePlatform.Forms.FreelancerView;
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

namespace FreelancePlatform.UserControls
{
    public partial class FreelancerDashboard : UserControl
    {

        private int profileId;

        private FreelancerProfileMethods profileMethods;
        private FreelancerCompletedProject project;

        public FreelancerDashboard(int userId)
        {
            InitializeComponent();

            this.profileMethods = new FreelancerProfileMethods();
            this.project = new FreelancerCompletedProject();
            this.profileId = profileMethods.freelancerProfileId(userId).FreeProfileId;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            FreelancerProfile profile = new FreelancerProfile(profileId);
            DialogResult reult = profile.ShowDialog();
            FreelancerDashboard_Load(sender, e);
        }

        private void FreelancerDashboard_Load(object sender, EventArgs e)
        {
            var posts = project.bidPosts(profileId);  // Fetch posts only once

            // Clear existing controls if necessary
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }

            // Loop through each post to create and add user controls
            foreach (var post in posts)
            {
                // Create an instance of FreelancerDashboardPosts
                var browseItem = new FreelancerSelectProject(profileId, post);

                // Add the user control to the FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(browseItem);

            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FreelancerBrowse browse = new FreelancerBrowse(profileId, "browse");
            DialogResult result = browse.ShowDialog();

            FreelancerDashboard_Load(sender, e);
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            FreelancerBrowse browse = new FreelancerBrowse(profileId, "complete projects");
            DialogResult result = browse.ShowDialog();
        }
    }
}
