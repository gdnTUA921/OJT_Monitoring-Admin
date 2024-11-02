namespace OJT_Monitoring
{
    partial class Home_Admin_
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
            panel1 = new Panel();
            panel3 = new Panel();
            welcomeLabel = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 93, 43);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 555);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(228, 230, 228);
            panel3.Controls.Add(welcomeLabel);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(43, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(716, 429);
            panel3.TabIndex = 1;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(203, 370);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(141, 34);
            welcomeLabel.TabIndex = 4;
            welcomeLabel.Text = "Welcome";
            welcomeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ojt_2_logo;
            pictureBox1.Location = new Point(168, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 380);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(200, 23);
            label1.Name = "label1";
            label1.Size = new Size(426, 50);
            label1.TabIndex = 0;
            label1.Text = "TUA OJT MONITORING";
            // 
            // Home_Admin_
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 555);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home_Admin_";
            Text = "Home_Admin_";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label welcomeLabel;
    }
}