namespace FreelancePlatform.UserControls
{
    partial class FreelancerDashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBrowse = new Button();
            btnProfile = new Button();
            btnProjects = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.Cursor = Cursors.Hand;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowse.Location = new Point(38, 21);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(153, 67);
            btnBrowse.TabIndex = 17;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnProfile
            // 
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfile.Location = new Point(356, 21);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(153, 67);
            btnProfile.TabIndex = 18;
            btnProfile.Text = "profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnProjects
            // 
            btnProjects.Cursor = Cursors.Hand;
            btnProjects.FlatStyle = FlatStyle.Flat;
            btnProjects.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProjects.Location = new Point(197, 21);
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(153, 67);
            btnProjects.TabIndex = 16;
            btnProjects.Text = "projects";
            btnProjects.UseVisualStyleBackColor = true;
            btnProjects.Click += btnProjects_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(38, 94);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(950, 435);
            flowLayoutPanel1.TabIndex = 19;
            // 
            // FreelancerDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnBrowse);
            Controls.Add(btnProfile);
            Controls.Add(btnProjects);
            Name = "FreelancerDashboard";
            Size = new Size(1039, 560);
            Load += FreelancerDashboard_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnBrowse;
        private Button btnProfile;
        private Button btnProjects;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
