using FreelancePlatform.GetterSetter;
using FreelancePlatform.Methods;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreelancePlatform.Forms
{
    public partial class SignupAndLogin : Form
    {

        private string type;

        private CheckAndNewAccount account;
        private ValidationMethods validate;

        private ClientProfileMethods clientProfile;
        private FreelancerProfileMethods freelancerProfile;

        public SignupAndLogin(string type)
        {
            InitializeComponent();

            this.type = type;
            this.account = new CheckAndNewAccount();
            this.validate = new ValidationMethods();
            this.clientProfile = new ClientProfileMethods();
            this.freelancerProfile = new FreelancerProfileMethods();
        }

        private void btnpnlSignip_Click(object sender, EventArgs e)
        {
            signupControlPanel();
        }

        private void btnpnlLogin_Click(object sender, EventArgs e)
        {
            loginControlPanel();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string? name = validate.nameValidation(txtSignupName.Text.Trim()) ? txtSignupName.Text.Trim() : null;
            string? password = validate.passwordValidation(txtSignupPass.Text.Trim()) ? txtSignupPass.Text.Trim() : null;

            if (name != null && password != null)
            {
                var user = new UserTypeService(name, password, this.type);


                if (!account.checkRegiration(user))
                {
                    MessageBox.Show("Registration successful! Please log in.");
                    account.registrationAccount(user);
                    loginControlPanel();
                }
                else
                {
                    MessageBox.Show("Already have account! Please try another.");
                }
            }
        }

        private void chkSignup_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSignup.Checked)
            {
                txtSignupPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtSignupPass.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string? name = validate.nameValidation(txtLoginName.Text.Trim()) ? txtLoginName.Text.Trim() : null;
            string? password = validate.passwordValidation(txtLoginPass.Text.Trim()) ? txtLoginPass.Text.Trim() : null;

            if (name != null && password != null)
            {
                var user = new UserTypeService(name, password, this.type);
                if (account.checkRegiration(user))
                {
                    int userId = account.getUserId(user);
                    MessageBox.Show("Welcome back! You have successfully logged in.");

                    this.Hide();

                    // Client
                    if (this.type.ToLower() == "client")
                    {
                        if (clientProfile.clientProfileId(userId) > 0)
                        {

                            Dashboard dashboard = new Dashboard(userId, "client");
                            dashboard.ShowDialog();
                            return;
                        }
                        else
                        {
                            Clients clinet = new Clients(userId);
                            clinet.ShowDialog(); 
                            return;
                        }
                        
                    }

                    // Freelancer
                    if (this.type.ToLower() == "freelancer")
                    {
                        var freelancer = freelancerProfile.freelancerProfileId(userId);
                        if(freelancer.FreeProfileId > 0)
                        {
                            Dashboard dashboard = new Dashboard(userId, "freelancer");
                            dashboard.ShowDialog();
                            return;
                        }  
                        else
                        {
                            Freelancer freelance = new Freelancer(userId);
                            freelance.ShowDialog();
                            return;
                        }
                       
                    }
                }
                else
                {
                    MessageBox.Show("User not found. Please try again.");
                }
            }
        }

        private void chkLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLogin.Checked)
            {
                txtLoginPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtLoginPass.UseSystemPasswordChar = true;
            }
        }

        private void signupControlPanel()
        {
            this.pnlSignup.Visible = false;
            this.pnlLogin.Visible = true;
            txtLoginName.Text = string.Empty;
            txtLoginPass.Text = string.Empty;
            chkLogin.Checked = false;
        }

        private void loginControlPanel()
        {
            this.pnlLogin.Visible = false;
            this.pnlSignup.Visible = true;
            txtSignupName.Text = string.Empty;
            txtSignupPass.Text = string.Empty;
            chkSignup.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseUserType type = new ChooseUserType();
            type.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseUserType type = new ChooseUserType();
            type.ShowDialog();
        }
    }
}
