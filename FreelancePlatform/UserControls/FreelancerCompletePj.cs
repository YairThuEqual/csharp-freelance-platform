using FreelancePlatform.Forms;
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
    public partial class FreelancerCompletePj : UserControl
    {

        private int bidId;

        public FreelancerCompletePj(CompleteProject project)
        {
            InitializeComponent();
            this.bidId = project.BidId;
            if (project.Status == "complete")
            {
                lblClientName.Text = project.Name;
                lblTitle.Text = project.Title;
                lblBudget.Text = int.Parse(project.Budget).ToString("N0");
                lblDate.Text = project.Date;

                // Handle client image safely
                if (project.ProfileImgae != null && project.ProfileImgae.Count() > 0)
                {
                    using (MemoryStream ms = new MemoryStream(project.ProfileImgae))
                    {
                        pbClient.Image = Image.FromStream(ms);
                    }
                }

                // Handle client image safely
                if (project.Image != null && project.Image.Count() > 0)
                {
                    using (MemoryStream ms = new MemoryStream(project.Image))
                    {
                        pbProject.Image = Image.FromStream(ms);
                    }
                }
            }
            else
            {
                this.Visible = false;
            }
        }

        private void FreelancerCompletePj_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReviewForCompletePost post = new ReviewForCompletePost(bidId);
            DialogResult result = post.ShowDialog();
        }
    }
}
