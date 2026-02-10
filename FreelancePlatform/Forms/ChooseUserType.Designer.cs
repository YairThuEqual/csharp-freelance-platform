namespace FreelancePlatform.Forms
{
    partial class ChooseUserType
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
            btnFreelancer = new Button();
            btnClient = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnFreelancer
            // 
            btnFreelancer.BackColor = Color.FromArgb(128, 64, 0);
            btnFreelancer.Font = new Font("Showcard Gothic", 16F);
            btnFreelancer.ForeColor = Color.White;
            btnFreelancer.Location = new Point(62, 275);
            btnFreelancer.Name = "btnFreelancer";
            btnFreelancer.Size = new Size(295, 111);
            btnFreelancer.TabIndex = 0;
            btnFreelancer.Text = "Freelancer";
            btnFreelancer.UseVisualStyleBackColor = false;
            btnFreelancer.Click += btnFreelancer_Click;
            // 
            // btnClient
            // 
            btnClient.BackColor = Color.FromArgb(128, 64, 0);
            btnClient.Font = new Font("Showcard Gothic", 16F);
            btnClient.ForeColor = Color.White;
            btnClient.Location = new Point(462, 275);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(295, 111);
            btnClient.TabIndex = 1;
            btnClient.Text = "Client";
            btnClient.UseVisualStyleBackColor = false;
            btnClient.Click += btnClient_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 22F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(145, 50);
            label1.Name = "label1";
            label1.Size = new Size(524, 162);
            label1.TabIndex = 2;
            label1.Text = "Please select either \r\nFreelancer or Client\r\nSelection Required";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ChooseUserType
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(836, 450);
            Controls.Add(label1);
            Controls.Add(btnClient);
            Controls.Add(btnFreelancer);
            Name = "ChooseUserType";
            Text = "ChooseUserType";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFreelancer;
        private Button btnClient;
        private Label label1;
    }
}