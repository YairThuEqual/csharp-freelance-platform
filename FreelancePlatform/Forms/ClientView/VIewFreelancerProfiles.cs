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
    public partial class VIewFreelancerProfiles : Form
    {

        private FreelancerProfileMethods profiles;

        public VIewFreelancerProfiles()
        {
            InitializeComponent();

            this.profiles = new FreelancerProfileMethods();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void VIewFreelancerProfiles_Load(object sender, EventArgs e)
        {
            var result = profiles.showAllFreelancerProfile();

            // Clear existing controls if necessary
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }

            // Loop through each post to create and add user controls
            foreach(var data in result)
            {
                var browseItem = new ShowFreelancerProfile(data);

                // Add the user control to the FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(browseItem);

            }
        }
    }
}
