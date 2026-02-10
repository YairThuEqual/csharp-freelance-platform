using FreelancePlatform.GetterSetter;
using FreelancePlatform.Methods;
using MySql.Data.MySqlClient;
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

namespace FreelancePlatform.Forms.Client
{
    public partial class ClientProfile : Form
    {

        private int profileId;

        private ClientProfileMethods profile;
        private ValidationMethods validator;

        public ClientProfile(int profileId)
        {
            InitializeComponent();
            this.profileId = profileId;
            this.profile = new ClientProfileMethods();
            this.validator = new ValidationMethods();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkButton();
        }

        private void ClientProfile_Load(object sender, EventArgs e)
        {

            var result = profile.clientProfile(profileId);
            if (result != null)
            {

                txtName.Text = result.Name;
                txtEmail.Text = result.Email;
                txtPhone.Text = result.Phone;
                txtCompany.Text = result.Company;
                txtAddress.Text = result.Address;

                if (result.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream(result.Image))
                    {
                        pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }
        }



        private void checkButton()
        {
            if (checkBox1.Checked)
            {
                txtName.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtPhone.ReadOnly = false;
                txtCompany.ReadOnly = false;
                txtAddress.ReadOnly = false;
                btnEdit.Visible = true;

                txtName.BorderStyle = BorderStyle.FixedSingle;
                txtEmail.BorderStyle = BorderStyle.FixedSingle;
                txtPhone.BorderStyle = BorderStyle.FixedSingle;
                txtCompany.BorderStyle = BorderStyle.FixedSingle;
                txtAddress.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                txtName.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtPhone.ReadOnly = true;
                txtCompany.ReadOnly = true;
                txtAddress.ReadOnly = true;
                btnEdit.Visible = false;

                txtName.BorderStyle = BorderStyle.None;
                txtEmail.BorderStyle = BorderStyle.None;
                txtPhone.BorderStyle = BorderStyle.None;
                txtCompany.BorderStyle = BorderStyle.None;
                txtAddress.BorderStyle = BorderStyle.None;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // valid inputs
            string? name = validator.validationInputDatas(txtName.Text.Trim(), "name") ? txtName.Text.Trim() : null;
            string? email = validator.emailValidation(txtEmail.Text.Trim()) ? txtEmail.Text.Trim() : null;
            string? phone = validator.phoneValidation(txtPhone.Text.Trim()) ? txtPhone.Text.Trim() : null;
            string? company = validator.validationInputDatas(txtCompany.Text.Trim(), "compant") ? txtCompany.Text.Trim() : null;
            string? address = validator.validationInputDatas(txtAddress.Text.Trim(), "address") ? txtAddress.Text.Trim() : null;

            if (name != null || email != null || phone != null || company != null || address != null)
            {

                var client = new ClientProfileService
                {
                    Name = name,
                    Email = email,
                    Phone = phone,
                    Company = company,
                    Address = address
                };

                profile.editProfileStatus(profileId, client);

                checkBox1.Checked = false;
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
                profile.editProfileImage(profileId, imageBytes);
            }

            ClientProfile_Load(sender, e);
        }
    }
}
