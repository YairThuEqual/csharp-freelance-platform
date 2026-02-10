using FreelancePlatform.Methods;
using FreelancePlatform.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreelancePlatform.Forms.FreelancerView
{
    public partial class FreelancerBrowse : Form
    {

        private int profileId;
        private string page;

        private FreelancerProfileMethods profileMethods;
        private FreelancerCompletedProject project;

        public FreelancerBrowse(int profileId, string page)
        {
            InitializeComponent();
            this.profileId = profileId;
            this.page = page;
            this.profileMethods = new FreelancerProfileMethods();
            this.project = new FreelancerCompletedProject();

            label1.Text = page;
        }

        private void FreelancerBrowse_Load(object sender, EventArgs e)
        {

            if(page == "browse")
            {
                var posts = profileMethods.ClientPostBrowse();  // Fetch posts only once

                // Clear existing controls if necessary
                if (flowLayoutPanel1.Controls.Count > 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }

                // Loop through each post to create and add user controls
                foreach (var post in posts)
                {
                    // Create an instance of FreelancerDashboardPosts
                    var browseItem = new FreelancerDashboardPosts(profileId, post);

                    // Add the user control to the FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(browseItem);

                }
            }
            else
            {
                var posts = project.showCompleteProjects(profileId);  // Fetch posts only once

                // Clear existing controls if necessary
                if (flowLayoutPanel1.Controls.Count > 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }

                // Loop through each post to create and add user controls
                foreach (var post in posts)
                {
                    // Create an instance of FreelancerDashboardPosts
                    var browseItem = new FreelancerCompletePj(post);

                    // Add the user control to the FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(browseItem);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;   
        }
    }
}
