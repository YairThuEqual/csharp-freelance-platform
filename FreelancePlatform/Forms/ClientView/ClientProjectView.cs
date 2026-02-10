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

namespace FreelancePlatform.Forms.ClientView
{
    public partial class ClientProjectView : Form
    {
        public ClientProjectView()
        {
            InitializeComponent();
        }

        private void ClientProjectView_Load(object sender, EventArgs e)
        {

            // Clear existing controls if necessary
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }
            // Initialize the array properly
            ClientProjects[] clients = new ClientProjects[5];

            for (int i = 0; i < clients.Length; i++)
            {
                clients[i] = new ClientProjects(); // Ensure each element is instantiated
                flowLayoutPanel1.Controls.Add(clients[i]);
            }
        }
    }
}
