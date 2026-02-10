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

namespace FreelancePlatform.Forms
{
    public partial class Dashboard : Form
    {

        private int userId;
        private string type;

        private ClientProfileMethods clientProfile;
        private FreelancerProfileMethods freelancerProfile;

        public Dashboard(int userId, string type)
        {
            InitializeComponent();
            this.userId = userId;
            this.type = type;

            lblShow.Text = type;

            clientProfile = new ClientProfileMethods();
            freelancerProfile = new FreelancerProfileMethods();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                SignupAndLogin signupAndLogin = new SignupAndLogin(type);
                signupAndLogin.ShowDialog();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            if(this.type.ToLower() == "client")
            {
                ClientDashboard client = new ClientDashboard(userId);
                client.Dock = DockStyle.Fill;
                panel1.Controls.Add(client);
                return;
            } 
            else if (this.type.ToLower() == "freelancer")
            {
                FreelancerDashboard freelancer = new FreelancerDashboard(userId);
                freelancer.Dock = DockStyle.Fill;
                panel1.Controls.Add(freelancer);
                return;
            }
        }
    }
}
