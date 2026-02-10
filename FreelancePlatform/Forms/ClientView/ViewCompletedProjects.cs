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

namespace FreelancePlatform.Forms.ClientView
{
    public partial class ViewCompletedProjects : Form
    {

        private int profileId;

        private FreelancerCompletedProject project;

        public ViewCompletedProjects(int profileId)
        {
            InitializeComponent();
            this.profileId = profileId;
            this.project = new FreelancerCompletedProject();
        }

        private void ViewCompletedProjects_Load(object sender, EventArgs e)
        {
            var result = project.showCompleteProjectForClient();  // Fetch posts only once

            // Clear existing controls if necessary
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }

            // Loop through each post to create and add user controls
            foreach (var data in result)
            {
                // Create an instance of FreelancerDashboardPosts
                var browseItem = new FreelancerCompletePj(data);

                // Add the user control to the FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(browseItem);

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }
    }
}
