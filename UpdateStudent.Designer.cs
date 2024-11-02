namespace OJT_Monitoring
{
    partial class UpdateStudent
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
            lblUpdateStudent = new Label();
            tbStudentID = new TextBox();
            tbFirstName = new TextBox();
            tbContactNo = new TextBox();
            tbSupervisorID = new TextBox();
            tbLastName = new TextBox();
            btnUpdateStudent = new Button();
            panel1 = new Panel();
            label5 = new Label();
            tbUserID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUpdateStudent
            // 
            lblUpdateStudent.AutoSize = true;
            lblUpdateStudent.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdateStudent.ForeColor = Color.White;
            lblUpdateStudent.Location = new Point(270, 19);
            lblUpdateStudent.Name = "lblUpdateStudent";
            lblUpdateStudent.Size = new Size(268, 45);
            lblUpdateStudent.TabIndex = 1;
            lblUpdateStudent.Text = "Update Students";
            // 
            // tbStudentID
            // 
            tbStudentID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbStudentID.Location = new Point(222, 83);
            tbStudentID.Name = "tbStudentID";
            tbStudentID.PlaceholderText = "Student ID#";
            tbStudentID.Size = new Size(157, 27);
            tbStudentID.TabIndex = 2;
            // 
            // tbFirstName
            // 
            tbFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbFirstName.Location = new Point(222, 138);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.PlaceholderText = "First Name";
            tbFirstName.Size = new Size(157, 27);
            tbFirstName.TabIndex = 3;
            // 
            // tbContactNo
            // 
            tbContactNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbContactNo.Location = new Point(222, 192);
            tbContactNo.Name = "tbContactNo";
            tbContactNo.PlaceholderText = "Contact No#";
            tbContactNo.Size = new Size(157, 27);
            tbContactNo.TabIndex = 4;
            // 
            // tbSupervisorID
            // 
            tbSupervisorID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbSupervisorID.Location = new Point(222, 250);
            tbSupervisorID.Name = "tbSupervisorID";
            tbSupervisorID.PlaceholderText = "Supervisor ID";
            tbSupervisorID.Size = new Size(157, 27);
            tbSupervisorID.TabIndex = 5;
            // 
            // tbLastName
            // 
            tbLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbLastName.Location = new Point(413, 140);
            tbLastName.Name = "tbLastName";
            tbLastName.PlaceholderText = "Last Name";
            tbLastName.Size = new Size(157, 27);
            tbLastName.TabIndex = 6;
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.BackColor = Color.FromArgb(44, 95, 52);
            btnUpdateStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateStudent.ForeColor = Color.White;
            btnUpdateStudent.Location = new Point(259, 317);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(138, 43);
            btnUpdateStudent.TabIndex = 7;
            btnUpdateStudent.Text = "Update ";
            btnUpdateStudent.UseVisualStyleBackColor = false;
            btnUpdateStudent.Click += btnUpdateStudent_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(228, 230, 228);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tbUserID);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbContactNo);
            panel1.Controls.Add(tbLastName);
            panel1.Controls.Add(btnUpdateStudent);
            panel1.Controls.Add(tbSupervisorID);
            panel1.Controls.Add(tbStudentID);
            panel1.Controls.Add(tbFirstName);
            panel1.Location = new Point(73, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 399);
            panel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(116, 30);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 13;
            label5.Text = "User ID";
            // 
            // tbUserID
            // 
            tbUserID.Enabled = false;
            tbUserID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbUserID.Location = new Point(222, 28);
            tbUserID.Name = "tbUserID";
            tbUserID.PlaceholderText = "User ID#";
            tbUserID.Size = new Size(157, 27);
            tbUserID.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(68, 252);
            label4.Name = "label4";
            label4.Size = new Size(113, 21);
            label4.TabIndex = 11;
            label4.Text = "Supervisor ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 194);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 10;
            label3.Text = "Contact No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(125, 140);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 83);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 8;
            label1.Text = "ID Number";
            // 
            // UpdateStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 95, 52);
            ClientSize = new Size(816, 580);
            Controls.Add(lblUpdateStudent);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateStudent";
            Text = "UpdateStudent";
            Load += UpdateStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUpdateStudent;
        private TextBox tbFirstName;
        private TextBox tbContactNo;
        private TextBox tbSupervisorID;
        private Button btnUpdateStudent;
        public TextBox tbStudentID;
        public TextBox tbLastName;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        public TextBox tbUserID;
    }
}