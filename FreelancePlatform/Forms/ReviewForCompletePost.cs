using FreelancePlatform.Forms.ClientView;
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

namespace FreelancePlatform.Forms
{
    public partial class ReviewForCompletePost : Form
    {

        private int bidId;

        private FreelancerCompletedProject projects;

        public ReviewForCompletePost(int bidId)
        {
            InitializeComponent();
            this.bidId = bidId;
            this.projects = new FreelancerCompletedProject();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string rating = comboBox1.Text;
            string comment = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(rating))
            {
                MessageBox.Show("Select rating.");
                return;
            }

            if (string.IsNullOrEmpty(comment))
            {
                MessageBox.Show("Something write a comment.");
                return;
            }

            projects.reviewProject(bidId, rating, comment);
            ReviewForCompletePost_Load(sender, e);
        }

        private void ReviewForCompletePost_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            var comments = projects.showReviewComment(bidId);  // Call the correct method

            foreach (var review in comments)
            {
                dataGridView1.Rows.Add(review.Rating, review.Comment);
            }
        }
    }
}
