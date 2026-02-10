namespace FreelancePlatform.UserControls
{
    partial class FreelancerCompletePj
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
            pbClient = new PictureBox();
            lblClientName = new Label();
            pbProject = new PictureBox();
            label2 = new Label();
            lblTitle = new Label();
            lblBudget = new Label();
            label5 = new Label();
            lblDate = new Label();
            label7 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbClient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProject).BeginInit();
            SuspendLayout();
            // 
            // pbClient
            // 
            pbClient.BorderStyle = BorderStyle.FixedSingle;
            pbClient.Image = Properties.Resources.profile1;
            pbClient.Location = new Point(3, 3);
            pbClient.Name = "pbClient";
            pbClient.Size = new Size(50, 50);
            pbClient.SizeMode = PictureBoxSizeMode.StretchImage;
            pbClient.TabIndex = 0;
            pbClient.TabStop = false;
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Location = new Point(59, 28);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(102, 25);
            lblClientName.TabIndex = 1;
            lblClientName.Text = "client name";
            // 
            // pbProject
            // 
            pbProject.BorderStyle = BorderStyle.FixedSingle;
            pbProject.Location = new Point(3, 85);
            pbProject.Name = "pbProject";
            pbProject.Size = new Size(220, 220);
            pbProject.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProject.TabIndex = 2;
            pbProject.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label2.Location = new Point(293, 86);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 3;
            label2.Text = "title";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(293, 109);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(99, 25);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "application";
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(293, 181);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(66, 25);
            lblBudget.TabIndex = 6;
            lblBudget.Text = "20,000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(192, 64, 0);
            label5.Location = new Point(293, 158);
            label5.Name = "label5";
            label5.Size = new Size(81, 23);
            label5.TabIndex = 5;
            label5.Text = "budget";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(293, 251);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(106, 25);
            lblDate.TabIndex = 8;
            lblDate.Text = "10-10-1010";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(192, 64, 0);
            label7.Location = new Point(293, 228);
            label7.Name = "label7";
            label7.Size = new Size(55, 23);
            label7.TabIndex = 7;
            label7.Text = "date";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(383, 3);
            button1.Name = "button1";
            button1.Size = new Size(149, 50);
            button1.TabIndex = 9;
            button1.Text = "review";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FreelancerCompletePj
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(button1);
            Controls.Add(lblDate);
            Controls.Add(label7);
            Controls.Add(lblBudget);
            Controls.Add(label5);
            Controls.Add(lblTitle);
            Controls.Add(label2);
            Controls.Add(pbProject);
            Controls.Add(lblClientName);
            Controls.Add(pbClient);
            Name = "FreelancerCompletePj";
            Size = new Size(537, 319);
            Load += FreelancerCompletePj_Load;
            ((System.ComponentModel.ISupportInitialize)pbClient).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbClient;
        private Label lblClientName;
        private PictureBox pbProject;
        private Label label2;
        private Label lblTitle;
        private Label lblBudget;
        private Label label5;
        private Label lblDate;
        private Label label7;
        private Button button1;
    }
}
