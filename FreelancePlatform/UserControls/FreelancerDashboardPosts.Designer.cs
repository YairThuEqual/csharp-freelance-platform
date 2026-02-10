namespace FreelancePlatform.UserControls
{
    partial class FreelancerDashboardPosts
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
            picClientImage = new PictureBox();
            lblName = new Label();
            label2 = new Label();
            lblTitle = new Label();
            lblBudget = new Label();
            label5 = new Label();
            lblStatus = new Label();
            label7 = new Label();
            btnBid = new Button();
            label9 = new Label();
            lblDescription = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picClientImage).BeginInit();
            SuspendLayout();
            // 
            // picClientImage
            // 
            picClientImage.BorderStyle = BorderStyle.FixedSingle;
            picClientImage.Image = Properties.Resources.profile1;
            picClientImage.Location = new Point(3, 3);
            picClientImage.Name = "picClientImage";
            picClientImage.Size = new Size(54, 54);
            picClientImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picClientImage.TabIndex = 1;
            picClientImage.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(63, 14);
            lblName.Name = "lblName";
            lblName.Size = new Size(105, 25);
            lblName.TabIndex = 2;
            lblName.Text = "Client name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(15, 86);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 3;
            label2.Text = "Title";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(79, 85);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(41, 25);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "title";
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(15, 151);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(105, 25);
            lblBudget.TabIndex = 6;
            lblBudget.Text = "Client name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(15, 128);
            label5.Name = "label5";
            label5.Size = new Size(81, 23);
            label5.TabIndex = 5;
            label5.Text = "budget";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(200, 151);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(105, 25);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Client name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(255, 128, 0);
            label7.Location = new Point(200, 128);
            label7.Name = "label7";
            label7.Size = new Size(74, 23);
            label7.TabIndex = 7;
            label7.Text = "status";
            // 
            // btnBid
            // 
            btnBid.FlatStyle = FlatStyle.Flat;
            btnBid.Font = new Font("Showcard Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBid.ForeColor = Color.FromArgb(192, 64, 0);
            btnBid.Location = new Point(354, 14);
            btnBid.Name = "btnBid";
            btnBid.Size = new Size(163, 53);
            btnBid.TabIndex = 9;
            btnBid.Text = "bid";
            btnBid.UseVisualStyleBackColor = true;
            btnBid.Click += btnBid_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(255, 128, 0);
            label9.Location = new Point(15, 192);
            label9.Name = "label9";
            label9.Size = new Size(125, 23);
            label9.TabIndex = 10;
            label9.Text = "description";
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(15, 218);
            lblDescription.Multiline = true;
            lblDescription.Name = "lblDescription";
            lblDescription.ReadOnly = true;
            lblDescription.Size = new Size(360, 81);
            lblDescription.TabIndex = 11;
            // 
            // FreelancerDashboardPosts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblDescription);
            Controls.Add(label9);
            Controls.Add(btnBid);
            Controls.Add(lblStatus);
            Controls.Add(label7);
            Controls.Add(lblBudget);
            Controls.Add(label5);
            Controls.Add(lblTitle);
            Controls.Add(label2);
            Controls.Add(lblName);
            Controls.Add(picClientImage);
            Name = "FreelancerDashboardPosts";
            Size = new Size(539, 321);
            Load += FreelancerDashboardPosts_Load_1;
            ((System.ComponentModel.ISupportInitialize)picClientImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picClientImage;
        private Label lblName;
        private Label label2;
        private Label lblTitle;
        private Label lblBudget;
        private Label label5;
        private Label lblStatus;
        private Label label7;
        private Button btnBid;
        private Label label9;
        private TextBox lblDescription;
    }
}
