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
    public partial class ChooseUserType : Form
    {
        public ChooseUserType()
        {
            InitializeComponent();
        }

        private void btnFreelancer_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignupAndLogin signupAndLogin = new SignupAndLogin("freelancer");
            signupAndLogin.ShowDialog();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignupAndLogin signupAndLogin = new SignupAndLogin("client");
            signupAndLogin.ShowDialog();
        }
    }
}
