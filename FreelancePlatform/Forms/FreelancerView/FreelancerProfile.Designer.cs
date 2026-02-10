namespace FreelancePlatform.Forms.FreelancerView
{
    partial class FreelancerProfile
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBack = new Button();
            btnImage = new Button();
            checkBox1 = new CheckBox();
            btnEdit = new Button();
            txtBio = new TextBox();
            txtProfession = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(64, 64, 64);
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(124, 55);
            btnBack.TabIndex = 44;
            btnBack.Text = "back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnImage
            // 
            btnImage.Cursor = Cursors.Hand;
            btnImage.FlatStyle = FlatStyle.Flat;
            btnImage.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnImage.ForeColor = Color.FromArgb(255, 128, 0);
            btnImage.Location = new Point(12, 322);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(223, 61);
            btnImage.TabIndex = 43;
            btnImage.Text = "upload image";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.FromArgb(192, 192, 0);
            checkBox1.Location = new Point(738, 23);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(93, 34);
            checkBox1.TabIndex = 42;
            checkBox1.Text = "edit";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnEdit
            // 
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.FromArgb(255, 128, 0);
            btnEdit.Location = new Point(679, 325);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(152, 55);
            btnEdit.TabIndex = 41;
            btnEdit.Text = "edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Visible = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtBio
            // 
            txtBio.BackColor = Color.White;
            txtBio.BorderStyle = BorderStyle.None;
            txtBio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBio.Location = new Point(261, 310);
            txtBio.Multiline = true;
            txtBio.Name = "txtBio";
            txtBio.ReadOnly = true;
            txtBio.Size = new Size(312, 73);
            txtBio.TabIndex = 40;
            // 
            // txtProfession
            // 
            txtProfession.BackColor = Color.White;
            txtProfession.BorderStyle = BorderStyle.None;
            txtProfession.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProfession.Location = new Point(580, 217);
            txtProfession.Name = "txtProfession";
            txtProfession.ReadOnly = true;
            txtProfession.Size = new Size(251, 27);
            txtProfession.TabIndex = 39;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(261, 217);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(241, 27);
            txtPhone.TabIndex = 38;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(580, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(251, 27);
            txtEmail.TabIndex = 37;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(261, 120);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(241, 27);
            txtName.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(192, 64, 0);
            label5.Location = new Point(261, 281);
            label5.Name = "label5";
            label5.Size = new Size(47, 26);
            label5.TabIndex = 35;
            label5.Text = "bio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 64, 0);
            label4.Location = new Point(575, 188);
            label4.Name = "label4";
            label4.Size = new Size(131, 26);
            label4.TabIndex = 34;
            label4.Text = "profession";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(192, 64, 0);
            label3.Location = new Point(256, 188);
            label3.Name = "label3";
            label3.Size = new Size(80, 26);
            label3.TabIndex = 33;
            label3.Text = "phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label2.Location = new Point(575, 91);
            label2.Name = "label2";
            label2.Size = new Size(70, 26);
            label2.TabIndex = 32;
            label2.Text = "email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(256, 91);
            label1.Name = "label1";
            label1.Size = new Size(65, 26);
            label1.TabIndex = 31;
            label1.Text = "name";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.profile1;
            pictureBox1.Location = new Point(12, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // FreelancerProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(886, 410);
            Controls.Add(btnBack);
            Controls.Add(btnImage);
            Controls.Add(checkBox1);
            Controls.Add(btnEdit);
            Controls.Add(txtBio);
            Controls.Add(txtProfession);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FreelancerProfile";
            Text = "FreelancerProfile";
            Load += FreelancerProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnImage;
        private CheckBox checkBox1;
        private Button btnEdit;
        private TextBox txtBio;
        private TextBox txtProfession;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}