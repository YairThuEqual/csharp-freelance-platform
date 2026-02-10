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
    public partial class ClientProfileEdit : UserControl
    {

        private int profileId;

        public ClientProfileEdit(int profileId)
        {
            InitializeComponent();

            this.profileId = profileId;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) {
                txtName.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtPhone.ReadOnly = false;
                txtCompany.ReadOnly = false;
                txtAddress.ReadOnly = false;
            }
            else
            {
                txtName.ReadOnly = true;
                txtEmail.ReadOnly= true;
                txtPhone.ReadOnly= true;
                txtCompany.ReadOnly= true;
                txtAddress.ReadOnly= true;
            }
        }
    }
}
