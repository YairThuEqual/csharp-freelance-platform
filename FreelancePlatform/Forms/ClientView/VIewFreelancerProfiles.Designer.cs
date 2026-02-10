namespace FreelancePlatform.Forms.ClientView
{
    partial class VIewFreelancerProfiles
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnBack = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 91);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(894, 495);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 26);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 59);
            btnBack.TabIndex = 1;
            btnBack.Text = "<< back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(266, 28);
            label1.Name = "label1";
            label1.Size = new Size(425, 44);
            label1.TabIndex = 2;
            label1.Text = "Freelancer profiles";
            // 
            // VIewFreelancerProfiles
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 609);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(flowLayoutPanel1);
            Name = "VIewFreelancerProfiles";
            Text = "VIewFreelancerProfiles";
            Load += VIewFreelancerProfiles_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnBack;
        private Label label1;
    }
}