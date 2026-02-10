namespace FreelancePlatform.UserControls
{
    partial class ClientDashboard
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnPost = new Button();
            txtbudget = new TextBox();
            txtDescription = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnFreelancers = new Button();
            btnProfile = new Button();
            btnProjects = new Button();
            label4 = new Label();
            txtTitle = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(38, 343);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(882, 196);
            dataGridView1.TabIndex = 26;
            // 
            // Column1
            // 
            Column1.HeaderText = "Titles";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Budgets";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Timeline";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Descriptions";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // btnPost
            // 
            btnPost.Cursor = Cursors.Hand;
            btnPost.FlatStyle = FlatStyle.Flat;
            btnPost.Font = new Font("Showcard Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPost.ForeColor = Color.CornflowerBlue;
            btnPost.Location = new Point(44, 199);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(162, 57);
            btnPost.TabIndex = 25;
            btnPost.Text = "post";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // txtbudget
            // 
            txtbudget.Location = new Point(43, 145);
            txtbudget.Name = "txtbudget";
            txtbudget.Size = new Size(254, 31);
            txtbudget.TabIndex = 23;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(355, 74);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(340, 102);
            txtDescription.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label2.Location = new Point(43, 119);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 20;
            label2.Text = "budgets";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(355, 41);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 19;
            label1.Text = "description";
            // 
            // btnFreelancers
            // 
            btnFreelancers.Cursor = Cursors.Hand;
            btnFreelancers.FlatStyle = FlatStyle.Flat;
            btnFreelancers.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFreelancers.Location = new Point(782, 217);
            btnFreelancers.Name = "btnFreelancers";
            btnFreelancers.Size = new Size(153, 67);
            btnFreelancers.TabIndex = 17;
            btnFreelancers.Text = "freelancers";
            btnFreelancers.UseVisualStyleBackColor = true;
            btnFreelancers.Click += btnFreelancers_Click;
            // 
            // btnProfile
            // 
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfile.Location = new Point(782, 41);
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
            btnProjects.Location = new Point(782, 129);
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(153, 67);
            btnProjects.TabIndex = 16;
            btnProjects.Text = "projects";
            btnProjects.UseVisualStyleBackColor = true;
            btnProjects.Click += btnProjects_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 64, 0);
            label4.Location = new Point(38, 300);
            label4.Name = "label4";
            label4.Size = new Size(168, 30);
            label4.TabIndex = 27;
            label4.Text = "your posts";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(43, 74);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(254, 31);
            txtTitle.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(192, 64, 0);
            label5.Location = new Point(43, 48);
            label5.Name = "label5";
            label5.Size = new Size(58, 23);
            label5.TabIndex = 28;
            label5.Text = "title";
            // 
            // ClientDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(txtTitle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(btnPost);
            Controls.Add(txtbudget);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFreelancers);
            Controls.Add(btnProfile);
            Controls.Add(btnProjects);
            Name = "ClientDashboard";
            Size = new Size(959, 560);
            Load += ClientDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnPost;
        private TextBox txtbudget;
        private TextBox txtDescription;
        private Label label2;
        private Label label1;
        private Button btnFreelancers;
        private Button btnProfile;
        private Button btnProjects;
        private Label label4;
        private TextBox txtTitle;
        private Label label5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
