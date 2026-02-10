using FreelancePlatform.GetterSetter;
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
    public partial class Clients : Form
    {
        private int id;

        private ValidationMethods validator;
        private ClientProfileMethods profile;

        public Clients(int id)
        {
            InitializeComponent();

            this.id = id;
            this.validator = new ValidationMethods();
            this.profile = new ClientProfileMethods();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // valid inputs
            string? name = validator.validationInputDatas(txtName.Text, "name") ? txtName.Text : null;
            string? email = validator.emailValidation(txtEmail.Text) ? txtEmail.Text : null;
            string? phone = validator.phoneValidation(txtPhone.Text) ? txtPhone.Text : null;
            string? company = validator.validationInputDatas(txtCompany.Text, "compant") ? txtCompany.Text : null;
            string? address = validator.validationInputDatas(txtAddress.Text, "address") ? txtAddress.Text : null;

            if(name != null || email != null || phone != null || company != null || address != null)
            {

                var client = new ClientProfileService
                {
                    ClientId = id,
                    Name = name,
                    Email = email,
                    Phone = phone,
                    Company = company,
                    Address = address
                };

                profile.createProfile(client); // save profile

                MessageBox.Show("Profile create successful.");

                this.Hide();
                Dashboard dashboard = new Dashboard(id, "client");
                dashboard.ShowDialog();
            }
        }
    }
}
