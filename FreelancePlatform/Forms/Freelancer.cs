using FreelancePlatform.GetterSetter;
using FreelancePlatform.Methods;
using Org.BouncyCastle.Asn1.Nist;
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
    public partial class Freelancer : Form
    {
        private int id;

        private ValidationMethods validator;
        private FreelancerProfileMethods profileMethods;
        public Freelancer(int id)
        {
            InitializeComponent();

            this.id = id;
            validator = new ValidationMethods();
            profileMethods = new FreelancerProfileMethods();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string? name = validator.nameValidation(txtName.Text) ? txtName.Text : null;
            string? email = validator.emailValidation(txtEmail.Text) ? txtEmail.Text : null;
            string? phone = validator.phoneValidation(txtPhone.Text) ? txtPhone.Text : null;
            string? profession = validator.validationInputDatas(txtProfession.Text, "Prefession") ? txtProfession.Text : null;
            string? bio = validator.validationInputDatas(txtBio.Text, "Bio") ? txtBio.Text : null;

            if(name != null || email !=  null || phone != null || profession != null || bio != null)
            {
                var freelancerProfile = new FreelancerProfileService
                {
                    Name = name,
                    Email = email,
                    Phone = phone,
                    Profession = profession,
                    Bio = bio
                };

                profileMethods.createProfile(id, freelancerProfile);

                MessageBox.Show("Frelancer prfile saved.");

                this.Hide();
                Dashboard dashboard = new Dashboard(id, "freelancer");
                dashboard.ShowDialog();
            }
        }
    }
}
