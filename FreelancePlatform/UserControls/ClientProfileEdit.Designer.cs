namespace FreelancePlatform.UserControls
{
    partial class ClientProfileEdit
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtCompany = new TextBox();
            txtAddress = new TextBox();
            btnEdit = new Button();
            checkBox1 = new CheckBox();
            btnImage = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.profile1;
            pictureBox1.Location = new Point(52, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(302, 47);
            label1.Name = "label1";
            label1.Size = new Size(65, 26);
            label1.TabIndex = 1;
            label1.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label2.Location = new Point(591, 47);
            label2.Name = "label2";
            label2.Size = new Size(70, 26);
            label2.TabIndex = 2;
            label2.Text = "email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(192, 64, 0);
            label3.Location = new Point(302, 149);
            label3.Name = "label3";
            label3.Size = new Size(80, 26);
            label3.TabIndex = 3;
            label3.Text = "phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 64, 0);
            label4.Location = new Point(591, 149);
            label4.Name = "label4";
            label4.Size = new Size(108, 26);
            label4.TabIndex = 4;
            label4.Text = "company";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(192, 64, 0);
            label5.Location = new Point(302, 244);
            label5.Name = "label5";
            label5.Size = new Size(99, 26);
            label5.TabIndex = 5;
            label5.Text = "address";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(302, 76);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(217, 34);
            txtName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(591, 76);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(217, 34);
            txtEmail.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(302, 178);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(217, 34);
            txtPhone.TabIndex = 8;
            // 
            // txtCompany
            // 
            txtCompany.BackColor = Color.White;
            txtCompany.BorderStyle = BorderStyle.FixedSingle;
            txtCompany.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCompany.Location = new Point(591, 178);
            txtCompany.Name = "txtCompany";
            txtCompany.ReadOnly = true;
            txtCompany.Size = new Size(217, 34);
            txtCompany.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(302, 273);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(217, 116);
            txtAddress.TabIndex = 10;
            // 
            // btnEdit
            // 
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.FromArgb(255, 128, 0);
            btnEdit.Location = new Point(544, 334);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(124, 55);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.FromArgb(192, 192, 0);
            checkBox1.Location = new Point(544, 272);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(93, 34);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "edit";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnImage
            // 
            btnImage.Cursor = Cursors.Hand;
            btnImage.FlatStyle = FlatStyle.Flat;
            btnImage.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnImage.ForeColor = Color.FromArgb(255, 128, 0);
            btnImage.Location = new Point(52, 285);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(223, 61);
            btnImage.TabIndex = 13;
            btnImage.Text = "upload image";
            btnImage.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(64, 64, 64);
            btnCancel.Location = new Point(684, 334);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(124, 55);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "cancel";
            btnCancel.UseVisualStyleBackColor = true;
            //btnCancel.Click += this.button1_Click;
            // 
            // ClientProfileEdit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnCancel);
            Controls.Add(btnImage);
            Controls.Add(checkBox1);
            Controls.Add(btnEdit);
            Controls.Add(txtAddress);
            Controls.Add(txtCompany);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "ClientProfileEdit";
            Size = new Size(839, 424);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtCompany;
        private TextBox txtAddress;
        private Button btnEdit;
        private CheckBox checkBox1;
        private Button btnImage;
        private Button btnCancel;
    }
}
