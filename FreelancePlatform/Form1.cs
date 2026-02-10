using FreelancePlatform.Forms;

namespace FreelancePlatform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Hide();
            ChooseUserType user = new ChooseUserType();
            user.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
