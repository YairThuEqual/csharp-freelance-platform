namespace FreelancePlatform.UserControls
{
    partial class ShowFreelancerProfile
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
            pbProfileImage = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblProfession = new Label();
            txtBio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbProfileImage).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbProfileImage
            // 
            pbProfileImage.BackColor = Color.FromArgb(224, 224, 224);
            pbProfileImage.BorderStyle = BorderStyle.FixedSingle;
            pbProfileImage.Image = Properties.Resources.profile1;
            pbProfileImage.Location = new Point(44, 55);
            pbProfileImage.Name = "pbProfileImage";
            pbProfileImage.Size = new Size(200, 200);
            pbProfileImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProfileImage.TabIndex = 0;
            pbProfileImage.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 64, 0);
            panel1.Controls.Add(pbProfileImage);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 300);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(331, 18);
            label1.Name = "label1";
            label1.Size = new Size(65, 26);
            label1.TabIndex = 2;
            label1.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label2.Location = new Point(331, 67);
            label2.Name = "label2";
            label2.Size = new Size(70, 26);
            label2.TabIndex = 3;
            label2.Text = "email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(192, 64, 0);
            label3.Location = new Point(331, 113);
            label3.Name = "label3";
            label3.Size = new Size(80, 26);
            label3.TabIndex = 4;
            label3.Text = "phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 64, 0);
            label4.Location = new Point(331, 159);
            label4.Name = "label4";
            label4.Size = new Size(131, 26);
            label4.TabIndex = 5;
            label4.Text = "profession";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(192, 64, 0);
            label5.Location = new Point(331, 208);
            label5.Name = "label5";
            label5.Size = new Size(47, 26);
            label5.TabIndex = 6;
            label5.Text = "bio";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Showcard Gothic", 9F);
            lblName.ForeColor = Color.Gray;
            lblName.Location = new Point(500, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 23);
            lblName.TabIndex = 7;
            lblName.Text = "User";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Showcard Gothic", 9F);
            lblEmail.ForeColor = Color.Gray;
            lblEmail.Location = new Point(500, 69);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(165, 23);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "user@gmail.com";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Showcard Gothic", 9F);
            lblPhone.ForeColor = Color.Gray;
            lblPhone.Location = new Point(500, 115);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(120, 23);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "09987897436";
            // 
            // lblProfession
            // 
            lblProfession.AutoSize = true;
            lblProfession.Font = new Font("Showcard Gothic", 9F);
            lblProfession.ForeColor = Color.Gray;
            lblProfession.Location = new Point(500, 162);
            lblProfession.Name = "lblProfession";
            lblProfession.Size = new Size(78, 23);
            lblProfession.TabIndex = 10;
            lblProfession.Text = "C#, PHP";
            // 
            // txtBio
            // 
            txtBio.BackColor = Color.White;
            txtBio.BorderStyle = BorderStyle.None;
            txtBio.Location = new Point(498, 207);
            txtBio.Multiline = true;
            txtBio.Name = "txtBio";
            txtBio.ReadOnly = true;
            txtBio.Size = new Size(305, 79);
            txtBio.TabIndex = 11;
            // 
            // ShowFreelancerProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(txtBio);
            Controls.Add(lblProfession);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ShowFreelancerProfile";
            Size = new Size(839, 298);
            Load += ShowFreelancerProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pbProfileImage).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbProfileImage;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblName;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblProfession;
        private TextBox txtBio;
    }
}
