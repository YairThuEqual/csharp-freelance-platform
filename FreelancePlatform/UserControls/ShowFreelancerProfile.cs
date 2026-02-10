using FreelancePlatform.GetterSetter;
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
    public partial class ShowFreelancerProfile : UserControl
    {
        public ShowFreelancerProfile(FreelancerProfileService profile)
        {
            InitializeComponent();

            lblName.Text = profile.Name;
            lblEmail.Text = profile.Email;
            lblPhone.Text = profile.Phone;
            lblProfession.Text = profile.Profession;
            txtBio.Text = profile.Bio;

            if(profile.Image != null )
            {
                using (MemoryStream ms = new MemoryStream(profile.Image))
                {
                    pbProfileImage.Image = Image.FromStream(ms);
                }
            }
        }

        private void ShowFreelancerProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
