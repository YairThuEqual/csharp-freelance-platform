using FreelancePlatform.GetterSetter;
using FreelancePlatform.Methods;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FreelancePlatform.Forms.FreelancerView
{
    public partial class FreelancerProfile : Form
    {

        private int profileId;

        private FreelancerProfileMethods profileMethods;
        private ValidationMethods validator;

        public FreelancerProfile(int profileId)
        {
            InitializeComponent();
            this.profileId = profileId;
            this.profileMethods = new FreelancerProfileMethods();
            this.validator = new ValidationMethods();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            editProfile();
        }

        private void editProfile()
        {
            if (checkBox1.Checked)
            {
                txtName.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtPhone.ReadOnly = false;
                txtProfession.ReadOnly = false;
                txtBio.ReadOnly = false;

                btnEdit.Visible = true;

                txtName.BorderStyle = BorderStyle.FixedSingle;
                txtEmail.BorderStyle = BorderStyle.FixedSingle;
                txtPhone.BorderStyle = BorderStyle.FixedSingle;
                txtProfession.BorderStyle = BorderStyle.FixedSingle;
                txtBio.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                txtName.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtPhone.ReadOnly = true;
                txtProfession.ReadOnly = true;
                txtBio.ReadOnly = true;

                btnEdit.Visible = false;

                txtName.BorderStyle = BorderStyle.None;
                txtEmail.BorderStyle = BorderStyle.None;
                txtPhone.BorderStyle = BorderStyle.None;
                txtProfession.BorderStyle = BorderStyle.None;
                txtBio.BorderStyle = BorderStyle.None;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void FreelancerProfile_Load(object sender, EventArgs e)
        {
            var profile = profileMethods.freelancerProfileView(profileId);
            if (profile != null)
            {
                txtName.Text = profile.Name;
                txtEmail.Text = profile.Email;
                txtPhone.Text = profile.Phone;
                txtProfession.Text = profile.Profession;
                txtBio.Text = profile.Bio;

                if (profile.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream(profile.Image))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageFile = new OpenFileDialog();
            imageFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (imageFile.ShowDialog() == DialogResult.OK)
            {
                string imagePath = imageFile.FileName;

                byte[] imageBytes = File.ReadAllBytes(imagePath);
                profileMethods.freeProfileImage(profileId, imageBytes);
            } else
            {
                MessageBox.Show("no reach image");
            }

            FreelancerProfile_Load(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string? name = validator.nameValidation(txtName.Text) ? txtName.Text : null;
            string? email = validator.emailValidation(txtEmail.Text) ? txtEmail.Text : null;
            string? phone = validator.phoneValidation(txtPhone.Text) ? txtPhone.Text : null;
            string? profession = validator.validationInputDatas(txtProfession.Text, "Prefession") ? txtProfession.Text : null;
            string? bio = validator.validationInputDatas(txtBio.Text, "Bio") ? txtBio.Text : null;

            if (name != null || email != null || phone != null || profession != null || bio != null)
            {
                var freelancerProfile = new FreelancerProfileService
                {
                    Name = name,
                    Email = email,
                    Phone = phone,
                    Profession = profession,
                    Bio = bio
                };

                profileMethods.updateProfile(profileId, freelancerProfile);

                checkBox1.Checked = false;
            }
        }
    }
}
