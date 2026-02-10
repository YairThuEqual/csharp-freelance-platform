namespace FreelancePlatform.UserControls
{
    partial class FreelancerSelectProject
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
            btnComplete = new Button();
            btnUploadImage = new Button();
            lblTitle = new Label();
            lblBudget = new Label();
            label6 = new Label();
            txtDescription = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 213);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(258, 19);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 1;
            label1.Text = "title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 64, 0);
            label2.Location = new Point(468, 19);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 2;
            label2.Text = "budget";
            // 
            // btnComplete
            // 
            btnComplete.Cursor = Cursors.Hand;
            btnComplete.FlatStyle = FlatStyle.Flat;
            btnComplete.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComplete.ForeColor = Color.FromArgb(0, 192, 0);
            btnComplete.Location = new Point(674, 25);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(149, 57);
            btnComplete.TabIndex = 3;
            btnComplete.Text = "complete";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Cursor = Cursors.Hand;
            btnUploadImage.FlatStyle = FlatStyle.Flat;
            btnUploadImage.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUploadImage.ForeColor = Color.FromArgb(192, 64, 0);
            btnUploadImage.Location = new Point(3, 222);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(213, 57);
            btnUploadImage.TabIndex = 4;
            btnUploadImage.Text = "upload image";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(258, 42);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(77, 25);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Youtube";
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(468, 42);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(66, 25);
            lblBudget.TabIndex = 6;
            lblBudget.Text = "20,000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(192, 64, 0);
            label6.Location = new Point(258, 129);
            label6.Name = "label6";
            label6.Size = new Size(125, 23);
            label6.TabIndex = 8;
            label6.Text = "description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(263, 161);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(349, 118);
            txtDescription.TabIndex = 9;
            // 
            // FreelancerSelectProject
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(txtDescription);
            Controls.Add(label6);
            Controls.Add(lblBudget);
            Controls.Add(lblTitle);
            Controls.Add(btnUploadImage);
            Controls.Add(btnComplete);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FreelancerSelectProject";
            Size = new Size(850, 298);
            Load += FreelancerSelectProject_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnComplete;
        private Button btnUploadImage;
        private Label lblTitle;
        private Label lblBudget;
        private Label label6;
        private TextBox txtDescription;
    }
}
