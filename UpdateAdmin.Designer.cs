namespace OJT_Monitoring
{
    partial class UpdateAdmin
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
            lblUpdateSupervisor = new Label();
            panel1 = new Panel();
            label5 = new Label();
            tbUserID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbContactNo = new TextBox();
            tbAdminLastName = new TextBox();
            btnUpdateAdmin = new Button();
            tbAdminID = new TextBox();
            tbAdminFirstName = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUpdateSupervisor
            // 
            lblUpdateSupervisor.AutoSize = true;
            lblUpdateSupervisor.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdateSupervisor.ForeColor = Color.White;
            lblUpdateSupervisor.Location = new Point(276, 39);
            lblUpdateSupervisor.Name = "lblUpdateSupervisor";
            lblUpdateSupervisor.Size = new Size(238, 45);
            lblUpdateSupervisor.TabIndex = 3;
            lblUpdateSupervisor.Text = "Update Admin";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(228, 230, 228);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbUserID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbContactNo);
            panel1.Controls.Add(tbAdminLastName);
            panel1.Controls.Add(btnUpdateAdmin);
            panel1.Controls.Add(tbAdminID);
            panel1.Controls.Add(tbAdminFirstName);
            panel1.Location = new Point(70, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 353);
            panel1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(116, 38);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 13;
            label5.Text = "User ID";
            // 
            // tbUserID
            // 
            tbUserID.Enabled = false;
            tbUserID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbUserID.Location = new Point(222, 36);
            tbUserID.Name = "tbUserID";
            tbUserID.PlaceholderText = "User ID#";
            tbUserID.Size = new Size(157, 27);
            tbUserID.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 202);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 10;
            label3.Text = "Contact No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(125, 148);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 93);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 8;
            label1.Text = "Admin ID";
            // 
            // tbContactNo
            // 
            tbContactNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbContactNo.Location = new Point(222, 200);
            tbContactNo.Name = "tbContactNo";
            tbContactNo.PlaceholderText = "Contact No#";
            tbContactNo.Size = new Size(157, 27);
            tbContactNo.TabIndex = 4;
            // 
            // tbAdminLastName
            // 
            tbAdminLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbAdminLastName.Location = new Point(413, 148);
            tbAdminLastName.Name = "tbAdminLastName";
            tbAdminLastName.PlaceholderText = "Last Name";
            tbAdminLastName.Size = new Size(157, 27);
            tbAdminLastName.TabIndex = 6;
            // 
            // btnUpdateAdmin
            // 
            btnUpdateAdmin.BackColor = Color.FromArgb(44, 95, 52);
            btnUpdateAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateAdmin.ForeColor = Color.White;
            btnUpdateAdmin.Location = new Point(257, 273);
            btnUpdateAdmin.Name = "btnUpdateAdmin";
            btnUpdateAdmin.Size = new Size(138, 43);
            btnUpdateAdmin.TabIndex = 7;
            btnUpdateAdmin.Text = "Update ";
            btnUpdateAdmin.UseVisualStyleBackColor = false;
            btnUpdateAdmin.Click += btnUpdateAdmin_Click;
            // 
            // tbAdminID
            // 
            tbAdminID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbAdminID.Location = new Point(222, 91);
            tbAdminID.Name = "tbAdminID";
            tbAdminID.PlaceholderText = "Admin ID#";
            tbAdminID.Size = new Size(157, 27);
            tbAdminID.TabIndex = 2;
            // 
            // tbAdminFirstName
            // 
            tbAdminFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbAdminFirstName.Location = new Point(222, 146);
            tbAdminFirstName.Name = "tbAdminFirstName";
            tbAdminFirstName.PlaceholderText = "First Name";
            tbAdminFirstName.Size = new Size(157, 27);
            tbAdminFirstName.TabIndex = 3;
            // 
            // UpdateAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 95, 52);
            ClientSize = new Size(800, 541);
            Controls.Add(panel1);
            Controls.Add(lblUpdateSupervisor);
            Name = "UpdateAdmin";
            Text = "UpdateAdmin";
            Load += UpdateAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUpdateSupervisor;
        private Panel panel1;
        private Label label5;
        public TextBox tbUserID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbContactNo;
        public TextBox tbAdminLastName;
        private Button btnUpdateAdmin;
        private TextBox tbSupervisorID;
        public TextBox tbAdminID;
        private TextBox tbAdminFirstName;
    }
}