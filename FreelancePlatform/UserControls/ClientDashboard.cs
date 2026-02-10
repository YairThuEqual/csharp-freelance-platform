using FreelancePlatform.Forms.Client;
using FreelancePlatform.Forms.ClientView;
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
    public partial class ClientDashboard : UserControl
    {

        private int profileId;

        private ClientProfileMethods profileMethods;
        private ValidationMethods validator;

        public ClientDashboard(int clientId)
        {
            InitializeComponent();

            profileMethods = new ClientProfileMethods();
            validator = new ValidationMethods();
            profileId = profileMethods.clientProfileId(clientId);
        }

        private void ClientDashboard_Load(object sender, EventArgs e)
        {
            refreshDataGridView();

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            var profile = new ClientProfile(profileId);
            DialogResult show = profile.ShowDialog();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string? title = validator.validationInputDatas(txtTitle.Text, "Title") ? txtTitle.Text : null;
            string? budget = validator.numberValidation(txtbudget.Text, "Budget") ? txtbudget.Text : null;
            string? description = validator.validationInputDatas(txtDescription.Text, "Description") ? txtDescription.Text : null;

            if (title != null || budget != null || description != null)
            {

                var post = new ClientPostService
                {
                    Title = title,
                    Budget = budget,
                    Timeline = DateTime.Now.Date.ToString("dd-MM-yyyy"),
                    Description = description,
                    Status = "unselected"
                };

                profileMethods.clientPost(profileId, post);
                refreshDataGridView();
                MessageBox.Show("Post success.");
            }
        }

        private void refreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            var posts = profileMethods.clientViewPosted(profileId);

            if (posts != null) // Ensure the list is not null
            {
                foreach (var post in posts)
                {
                    dataGridView1.Rows.Add(post.Title, int.Parse(post.Budget).ToString("N0"), post.Timeline, post.Description);
                }
            }
        }

        private void btnFreelancers_Click(object sender, EventArgs e)
        {
            VIewFreelancerProfiles profiles = new VIewFreelancerProfiles();
            DialogResult result = profiles.ShowDialog();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            ViewCompletedProjects projects = new ViewCompletedProjects(profileId);
            DialogResult result = projects.ShowDialog();
        }
    }
}
