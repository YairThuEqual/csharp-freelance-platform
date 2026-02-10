namespace FreelancePlatform.Forms
{
    partial class Freelancer
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
            label6 = new Label();
            btnSave = new Button();
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
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 128, 0);
            label6.Location = new Point(90, 37);
            label6.Name = "label6";
            label6.Size = new Size(428, 50);
            label6.TabIndex = 27;
            label6.Text = "freelancer profile";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(192, 64, 0);
            btnSave.Location = new Point(90, 399);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(191, 56);
            btnSave.TabIndex = 26;
            btnSave.Text = "save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtBio
            // 
            txtBio.BorderStyle = BorderStyle.FixedSingle;
            txtBio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBio.Location = new Point(433, 250);
            txtBio.Multiline = true;
            txtBio.Name = "txtBio";
            txtBio.Size = new Size(252, 120);
            txtBio.TabIndex = 24;
            // 
            // txtProfession
            // 
            txtProfession.BorderStyle = BorderStyle.FixedSingle;
            txtProfession.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProfession.Location = new Point(433, 164);
            txtProfession.Name = "txtProfession";
            txtProfession.Size = new Size(252, 34);
            txtProfession.TabIndex = 23;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(90, 336);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(252, 34);
            txtPhone.TabIndex = 22;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(90, 250);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(252, 34);
            txtEmail.TabIndex = 21;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(90, 164);
            txtName.Name = "txtName";
            txtName.Size = new Size(252, 34);
            txtName.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(192, 64, 0);
            label5.Location = new Point(433, 221);
            label5.Name = "label5";
            label5.Size = new Size(47, 26);
            label5.TabIndex = 19;
            label5.Text = "bio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 64, 0);
            label4.Location = new Point(433, 135);
            label4.Name = "label4";
            label4.Size = new Size(131, 26);
            label4.TabIndex = 18;
            label4.Text = "profession";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(192, 64, 0);
            label3.Location = new Point(90, 307);
            label3.Name = "label3";
            label3.Size = new Size(80, 26);
            label3.TabIndex = 17;
            label3.Text = "phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label2.Location = new Point(90, 221);
            label2.Name = "label2";
            label2.Size = new Size(70, 26);
            label2.TabIndex = 16;
            label2.Text = "email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(90, 135);
            label1.Name = "label1";
            label1.Size = new Size(65, 26);
            label1.TabIndex = 15;
            label1.Text = "name";
            // 
            // Freelancer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(787, 522);
            Controls.Add(label6);
            Controls.Add(btnSave);
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
            Name = "Freelancer";
            Text = "FreelancerProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button btnSave;
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
    }
}