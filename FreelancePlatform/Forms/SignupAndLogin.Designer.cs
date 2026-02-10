
namespace FreelancePlatform.Forms
{
    partial class SignupAndLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSignupName = new TextBox();
            txtSignupPass = new TextBox();
            chkSignup = new CheckBox();
            btnSignup = new Button();
            button2 = new Button();
            chkLogin = new CheckBox();
            txtLoginPass = new TextBox();
            txtLoginName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            pnlSignup = new Panel();
            button3 = new Button();
            label7 = new Label();
            btnpnlSignip = new Button();
            pnlLogin = new Panel();
            button1 = new Button();
            label8 = new Label();
            btnpnlLogin = new Button();
            pnlSignup.SuspendLayout();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(172, 71);
            label1.Name = "label1";
            label1.Size = new Size(179, 50);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label2.Location = new Point(709, 71);
            label2.Name = "label2";
            label2.Size = new Size(142, 50);
            label2.TabIndex = 1;
            label2.Text = "login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 10F);
            label3.ForeColor = Color.FromArgb(192, 64, 0);
            label3.Location = new Point(105, 185);
            label3.Name = "label3";
            label3.Size = new Size(114, 26);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 10F);
            label4.ForeColor = Color.FromArgb(192, 64, 0);
            label4.Location = new Point(105, 298);
            label4.Name = "label4";
            label4.Size = new Size(122, 26);
            label4.TabIndex = 3;
            label4.Text = "password";
            // 
            // txtSignupName
            // 
            txtSignupName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSignupName.Location = new Point(105, 218);
            txtSignupName.Name = "txtSignupName";
            txtSignupName.Size = new Size(342, 39);
            txtSignupName.TabIndex = 4;
            // 
            // txtSignupPass
            // 
            txtSignupPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSignupPass.Location = new Point(105, 331);
            txtSignupPass.Name = "txtSignupPass";
            txtSignupPass.Size = new Size(342, 39);
            txtSignupPass.TabIndex = 5;
            txtSignupPass.UseSystemPasswordChar = true;
            // 
            // chkSignup
            // 
            chkSignup.AutoSize = true;
            chkSignup.ForeColor = Color.FromArgb(192, 64, 0);
            chkSignup.Location = new Point(301, 299);
            chkSignup.Name = "chkSignup";
            chkSignup.Size = new Size(146, 29);
            chkSignup.TabIndex = 6;
            chkSignup.Text = "see password";
            chkSignup.UseVisualStyleBackColor = true;
            chkSignup.CheckedChanged += chkSignup_CheckedChanged;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.FromArgb(255, 192, 128);
            btnSignup.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = Color.FromArgb(192, 64, 0);
            btnSignup.Location = new Point(172, 424);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(179, 65);
            btnSignup.TabIndex = 7;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(192, 64, 0);
            button2.Location = new Point(681, 424);
            button2.Name = "button2";
            button2.Size = new Size(179, 65);
            button2.TabIndex = 13;
            button2.Text = "login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // chkLogin
            // 
            chkLogin.AutoSize = true;
            chkLogin.ForeColor = Color.FromArgb(192, 64, 0);
            chkLogin.Location = new Point(796, 299);
            chkLogin.Name = "chkLogin";
            chkLogin.Size = new Size(146, 29);
            chkLogin.TabIndex = 12;
            chkLogin.Text = "see password";
            chkLogin.UseVisualStyleBackColor = true;
            chkLogin.CheckedChanged += chkLogin_CheckedChanged;
            // 
            // txtLoginPass
            // 
            txtLoginPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLoginPass.Location = new Point(600, 331);
            txtLoginPass.Name = "txtLoginPass";
            txtLoginPass.Size = new Size(342, 39);
            txtLoginPass.TabIndex = 11;
            txtLoginPass.UseSystemPasswordChar = true;
            // 
            // txtLoginName
            // 
            txtLoginName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLoginName.Location = new Point(600, 218);
            txtLoginName.Name = "txtLoginName";
            txtLoginName.Size = new Size(342, 39);
            txtLoginName.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 10F);
            label5.ForeColor = Color.FromArgb(192, 64, 0);
            label5.Location = new Point(600, 298);
            label5.Name = "label5";
            label5.Size = new Size(122, 26);
            label5.TabIndex = 9;
            label5.Text = "password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 10F);
            label6.ForeColor = Color.FromArgb(192, 64, 0);
            label6.Location = new Point(600, 185);
            label6.Name = "label6";
            label6.Size = new Size(114, 26);
            label6.TabIndex = 8;
            label6.Text = "Username";
            // 
            // pnlSignup
            // 
            pnlSignup.BackColor = Color.FromArgb(128, 64, 0);
            pnlSignup.BackgroundImageLayout = ImageLayout.Stretch;
            pnlSignup.Controls.Add(button3);
            pnlSignup.Controls.Add(label7);
            pnlSignup.Controls.Add(btnpnlSignip);
            pnlSignup.Location = new Point(43, 34);
            pnlSignup.Name = "pnlSignup";
            pnlSignup.Size = new Size(467, 482);
            pnlSignup.TabIndex = 14;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(26, 22);
            button3.Name = "button3";
            button3.Size = new Size(138, 65);
            button3.TabIndex = 20;
            button3.Text = "back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(62, 137);
            label7.Name = "label7";
            label7.Size = new Size(320, 40);
            label7.TabIndex = 17;
            label7.Text = "create account !";
            // 
            // btnpnlSignip
            // 
            btnpnlSignip.BackColor = Color.White;
            btnpnlSignip.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnpnlSignip.ForeColor = Color.FromArgb(192, 64, 0);
            btnpnlSignip.Location = new Point(129, 284);
            btnpnlSignip.Name = "btnpnlSignip";
            btnpnlSignip.Size = new Size(179, 65);
            btnpnlSignip.TabIndex = 16;
            btnpnlSignip.Text = "sign up";
            btnpnlSignip.UseVisualStyleBackColor = false;
            btnpnlSignip.Click += btnpnlSignip_Click;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.FromArgb(128, 64, 0);
            pnlLogin.Controls.Add(button1);
            pnlLogin.Controls.Add(label8);
            pnlLogin.Controls.Add(btnpnlLogin);
            pnlLogin.Location = new Point(533, 34);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(467, 482);
            pnlLogin.TabIndex = 15;
            pnlLogin.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(21, 22);
            button1.Name = "button1";
            button1.Size = new Size(138, 65);
            button1.TabIndex = 21;
            button1.Text = "back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(21, 137);
            label8.Name = "label8";
            label8.Size = new Size(434, 40);
            label8.TabIndex = 18;
            label8.Text = "already haveaccount !";
            // 
            // btnpnlLogin
            // 
            btnpnlLogin.BackColor = Color.White;
            btnpnlLogin.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnpnlLogin.ForeColor = Color.FromArgb(192, 64, 0);
            btnpnlLogin.Location = new Point(139, 284);
            btnpnlLogin.Name = "btnpnlLogin";
            btnpnlLogin.Size = new Size(179, 65);
            btnpnlLogin.TabIndex = 17;
            btnpnlLogin.Text = "login";
            btnpnlLogin.UseVisualStyleBackColor = false;
            btnpnlLogin.Click += btnpnlLogin_Click;
            // 
            // SignupAndLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1050, 555);
            Controls.Add(pnlLogin);
            Controls.Add(pnlSignup);
            Controls.Add(button2);
            Controls.Add(chkLogin);
            Controls.Add(txtLoginPass);
            Controls.Add(txtLoginName);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(btnSignup);
            Controls.Add(chkSignup);
            Controls.Add(txtSignupPass);
            Controls.Add(txtSignupName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignupAndLogin";
            Text = "SinupAndLogin";
            pnlSignup.ResumeLayout(false);
            pnlSignup.PerformLayout();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSignupName;
        private TextBox txtSignupPass;
        private CheckBox chkSignup;
        private Button btnSignup;
        private Button button2;
        private CheckBox chkLogin;
        private TextBox txtLoginPass;
        private TextBox txtLoginName;
        private Label label5;
        private Label label6;
        private Panel pnlSignup;
        private Panel pnlLogin;
        private Button btnpnlSignip;
        private Button btnpnlLogin;
        private Label label7;
        private Label label8;
        private Button button3;
        private Button button1;
    }
}