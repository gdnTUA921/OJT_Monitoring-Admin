namespace OJT_Monitoring
{
    partial class Register
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
            btnRegisterStud = new Button();
            label2 = new Label();
            cmbAccountType = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            pnlAdmin = new Panel();
            adminEyeShow = new PictureBox();
            adminEyeHidden = new PictureBox();
            tbAdminPassword = new TextBox();
            label17 = new Label();
            tbAdminEmail = new TextBox();
            label18 = new Label();
            tbAdminContactNum = new TextBox();
            label20 = new Label();
            tbAdminLastName = new TextBox();
            tbAdminFirstName = new TextBox();
            label21 = new Label();
            label22 = new Label();
            tbAdminID = new TextBox();
            btnRegisterAdmin = new Button();
            pnlSupervisor = new Panel();
            supEyeShow = new PictureBox();
            supEyeHidden = new PictureBox();
            tbSupPassword = new TextBox();
            label11 = new Label();
            tbSupEmail = new TextBox();
            label12 = new Label();
            tbSupCompany = new TextBox();
            label13 = new Label();
            tbSupContactNum = new TextBox();
            label14 = new Label();
            tbSupLastName = new TextBox();
            tbSupFirstName = new TextBox();
            label15 = new Label();
            label16 = new Label();
            tbSupID = new TextBox();
            btnRegisterSup = new Button();
            pnlStudent = new Panel();
            studEyeShow = new PictureBox();
            studEyeHidden = new PictureBox();
            tbStudPassword = new TextBox();
            label10 = new Label();
            tbStudEmail = new TextBox();
            label9 = new Label();
            tbStudSupervisorID = new TextBox();
            label6 = new Label();
            tbStudContactNum = new TextBox();
            label5 = new Label();
            tbStudLastName = new TextBox();
            tbStudFirstName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tbStudID = new TextBox();
            panel1.SuspendLayout();
            pnlAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adminEyeShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)adminEyeHidden).BeginInit();
            pnlSupervisor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)supEyeShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supEyeHidden).BeginInit();
            pnlStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studEyeShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studEyeHidden).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(240, 36);
            label1.Name = "label1";
            label1.Size = new Size(328, 45);
            label1.TabIndex = 0;
            label1.Text = "REGISTER ACCOUNT";
            // 
            // btnRegisterStud
            // 
            btnRegisterStud.BackColor = Color.FromArgb(39, 93, 43);
            btnRegisterStud.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterStud.ForeColor = Color.White;
            btnRegisterStud.Location = new Point(238, 272);
            btnRegisterStud.Name = "btnRegisterStud";
            btnRegisterStud.Size = new Size(119, 32);
            btnRegisterStud.TabIndex = 3;
            btnRegisterStud.Text = "REGISTER";
            btnRegisterStud.UseVisualStyleBackColor = false;
            btnRegisterStud.Click += btnRegisterStud_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 128);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // cmbAccountType
            // 
            cmbAccountType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAccountType.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAccountType.FormattingEnabled = true;
            cmbAccountType.Items.AddRange(new object[] { "student", "supervisor", "admin" });
            cmbAccountType.Location = new Point(264, 29);
            cmbAccountType.Name = "cmbAccountType";
            cmbAccountType.Size = new Size(212, 25);
            cmbAccountType.TabIndex = 8;
            cmbAccountType.SelectedIndexChanged += cmbAccountType_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(152, 32);
            label7.Name = "label7";
            label7.Size = new Size(91, 17);
            label7.TabIndex = 13;
            label7.Text = "Account Type";
            // 
            // label8
            // 
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(228, 230, 228);
            panel1.Controls.Add(pnlAdmin);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cmbAccountType);
            panel1.Controls.Add(pnlSupervisor);
            panel1.Controls.Add(pnlStudent);
            panel1.Location = new Point(54, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(707, 394);
            panel1.TabIndex = 16;
            // 
            // pnlAdmin
            // 
            pnlAdmin.Controls.Add(adminEyeShow);
            pnlAdmin.Controls.Add(adminEyeHidden);
            pnlAdmin.Controls.Add(tbAdminPassword);
            pnlAdmin.Controls.Add(label17);
            pnlAdmin.Controls.Add(tbAdminEmail);
            pnlAdmin.Controls.Add(label18);
            pnlAdmin.Controls.Add(tbAdminContactNum);
            pnlAdmin.Controls.Add(label20);
            pnlAdmin.Controls.Add(tbAdminLastName);
            pnlAdmin.Controls.Add(tbAdminFirstName);
            pnlAdmin.Controls.Add(label21);
            pnlAdmin.Controls.Add(label22);
            pnlAdmin.Controls.Add(tbAdminID);
            pnlAdmin.Controls.Add(btnRegisterAdmin);
            pnlAdmin.Location = new Point(62, 383);
            pnlAdmin.Name = "pnlAdmin";
            pnlAdmin.Size = new Size(598, 317);
            pnlAdmin.TabIndex = 18;
            pnlAdmin.Visible = false;
            // 
            // adminEyeShow
            // 
            adminEyeShow.BackColor = Color.White;
            adminEyeShow.Image = Properties.Resources.eye;
            adminEyeShow.Location = new Point(331, 180);
            adminEyeShow.Name = "adminEyeShow";
            adminEyeShow.Size = new Size(20, 20);
            adminEyeShow.SizeMode = PictureBoxSizeMode.StretchImage;
            adminEyeShow.TabIndex = 31;
            adminEyeShow.TabStop = false;
            adminEyeShow.Click += adminEyeShow_Click;
            // 
            // adminEyeHidden
            // 
            adminEyeHidden.BackColor = Color.White;
            adminEyeHidden.Image = Properties.Resources.eye_crossed;
            adminEyeHidden.Location = new Point(331, 180);
            adminEyeHidden.Name = "adminEyeHidden";
            adminEyeHidden.Size = new Size(20, 20);
            adminEyeHidden.SizeMode = PictureBoxSizeMode.StretchImage;
            adminEyeHidden.TabIndex = 30;
            adminEyeHidden.TabStop = false;
            adminEyeHidden.Click += adminEyeHidden_Click;
            // 
            // tbAdminPassword
            // 
            tbAdminPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAdminPassword.Location = new Point(202, 177);
            tbAdminPassword.Name = "tbAdminPassword";
            tbAdminPassword.PasswordChar = '•';
            tbAdminPassword.PlaceholderText = "Password";
            tbAdminPassword.Size = new Size(155, 25);
            tbAdminPassword.TabIndex = 25;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.ActiveCaptionText;
            label17.Location = new Point(111, 180);
            label17.Name = "label17";
            label17.Size = new Size(66, 17);
            label17.TabIndex = 24;
            label17.Text = "Password";
            // 
            // tbAdminEmail
            // 
            tbAdminEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAdminEmail.Location = new Point(202, 136);
            tbAdminEmail.Name = "tbAdminEmail";
            tbAdminEmail.PlaceholderText = "Email";
            tbAdminEmail.Size = new Size(155, 25);
            tbAdminEmail.TabIndex = 23;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = SystemColors.ActiveCaptionText;
            label18.Location = new Point(135, 139);
            label18.Name = "label18";
            label18.Size = new Size(42, 17);
            label18.TabIndex = 22;
            label18.Text = "Email";
            // 
            // tbAdminContactNum
            // 
            tbAdminContactNum.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAdminContactNum.Location = new Point(202, 92);
            tbAdminContactNum.Name = "tbAdminContactNum";
            tbAdminContactNum.PlaceholderText = "Contact Number";
            tbAdminContactNum.Size = new Size(155, 25);
            tbAdminContactNum.TabIndex = 19;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = SystemColors.ActiveCaptionText;
            label20.Location = new Point(100, 95);
            label20.Name = "label20";
            label20.Size = new Size(81, 17);
            label20.TabIndex = 18;
            label20.Text = "Contact No.";
            // 
            // tbAdminLastName
            // 
            tbAdminLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAdminLastName.Location = new Point(390, 49);
            tbAdminLastName.Name = "tbAdminLastName";
            tbAdminLastName.PlaceholderText = "Last Name";
            tbAdminLastName.Size = new Size(155, 25);
            tbAdminLastName.TabIndex = 17;
            // 
            // tbAdminFirstName
            // 
            tbAdminFirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAdminFirstName.Location = new Point(202, 49);
            tbAdminFirstName.Name = "tbAdminFirstName";
            tbAdminFirstName.PlaceholderText = "First Name";
            tbAdminFirstName.Size = new Size(155, 25);
            tbAdminFirstName.TabIndex = 16;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = SystemColors.ActiveCaptionText;
            label21.Location = new Point(137, 52);
            label21.Name = "label21";
            label21.Size = new Size(44, 17);
            label21.TabIndex = 15;
            label21.Text = "Name";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = SystemColors.ActiveCaptionText;
            label22.Location = new Point(114, 12);
            label22.Name = "label22";
            label22.Size = new Size(67, 17);
            label22.TabIndex = 14;
            label22.Text = "Admin ID";
            // 
            // tbAdminID
            // 
            tbAdminID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAdminID.Location = new Point(202, 9);
            tbAdminID.Name = "tbAdminID";
            tbAdminID.PlaceholderText = "Admin ID";
            tbAdminID.Size = new Size(212, 25);
            tbAdminID.TabIndex = 4;
            // 
            // btnRegisterAdmin
            // 
            btnRegisterAdmin.BackColor = Color.FromArgb(39, 93, 43);
            btnRegisterAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterAdmin.ForeColor = Color.White;
            btnRegisterAdmin.Location = new Point(238, 249);
            btnRegisterAdmin.Name = "btnRegisterAdmin";
            btnRegisterAdmin.Size = new Size(119, 32);
            btnRegisterAdmin.TabIndex = 3;
            btnRegisterAdmin.Text = "REGISTER";
            btnRegisterAdmin.UseVisualStyleBackColor = false;
            btnRegisterAdmin.Click += btnRegisterAdmin_Click;
            // 
            // pnlSupervisor
            // 
            pnlSupervisor.Controls.Add(supEyeShow);
            pnlSupervisor.Controls.Add(supEyeHidden);
            pnlSupervisor.Controls.Add(tbSupPassword);
            pnlSupervisor.Controls.Add(label11);
            pnlSupervisor.Controls.Add(tbSupEmail);
            pnlSupervisor.Controls.Add(label12);
            pnlSupervisor.Controls.Add(tbSupCompany);
            pnlSupervisor.Controls.Add(label13);
            pnlSupervisor.Controls.Add(tbSupContactNum);
            pnlSupervisor.Controls.Add(label14);
            pnlSupervisor.Controls.Add(tbSupLastName);
            pnlSupervisor.Controls.Add(tbSupFirstName);
            pnlSupervisor.Controls.Add(label15);
            pnlSupervisor.Controls.Add(label16);
            pnlSupervisor.Controls.Add(tbSupID);
            pnlSupervisor.Controls.Add(btnRegisterSup);
            pnlSupervisor.Location = new Point(679, 60);
            pnlSupervisor.Name = "pnlSupervisor";
            pnlSupervisor.Size = new Size(598, 317);
            pnlSupervisor.TabIndex = 17;
            pnlSupervisor.Visible = false;
            // 
            // supEyeShow
            // 
            supEyeShow.BackColor = Color.White;
            supEyeShow.Image = Properties.Resources.eye;
            supEyeShow.Location = new Point(332, 221);
            supEyeShow.Name = "supEyeShow";
            supEyeShow.Size = new Size(20, 20);
            supEyeShow.SizeMode = PictureBoxSizeMode.StretchImage;
            supEyeShow.TabIndex = 29;
            supEyeShow.TabStop = false;
            supEyeShow.Click += supEyeShow_Click;
            // 
            // supEyeHidden
            // 
            supEyeHidden.BackColor = Color.White;
            supEyeHidden.Image = Properties.Resources.eye_crossed;
            supEyeHidden.Location = new Point(332, 221);
            supEyeHidden.Name = "supEyeHidden";
            supEyeHidden.Size = new Size(20, 20);
            supEyeHidden.SizeMode = PictureBoxSizeMode.StretchImage;
            supEyeHidden.TabIndex = 28;
            supEyeHidden.TabStop = false;
            supEyeHidden.Click += supEyeHidden_Click;
            // 
            // tbSupPassword
            // 
            tbSupPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSupPassword.Location = new Point(202, 218);
            tbSupPassword.Name = "tbSupPassword";
            tbSupPassword.PasswordChar = '•';
            tbSupPassword.PlaceholderText = "Password";
            tbSupPassword.Size = new Size(155, 25);
            tbSupPassword.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(113, 221);
            label11.Name = "label11";
            label11.Size = new Size(66, 17);
            label11.TabIndex = 24;
            label11.Text = "Password";
            // 
            // tbSupEmail
            // 
            tbSupEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSupEmail.Location = new Point(202, 177);
            tbSupEmail.Name = "tbSupEmail";
            tbSupEmail.PlaceholderText = "Email";
            tbSupEmail.Size = new Size(155, 25);
            tbSupEmail.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(137, 180);
            label12.Name = "label12";
            label12.Size = new Size(42, 17);
            label12.TabIndex = 22;
            label12.Text = "Email";
            // 
            // tbSupCompany
            // 
            tbSupCompany.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSupCompany.Location = new Point(202, 136);
            tbSupCompany.Name = "tbSupCompany";
            tbSupCompany.PlaceholderText = "Company";
            tbSupCompany.Size = new Size(155, 25);
            tbSupCompany.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(115, 139);
            label13.Name = "label13";
            label13.Size = new Size(66, 17);
            label13.TabIndex = 20;
            label13.Text = "Company";
            // 
            // tbSupContactNum
            // 
            tbSupContactNum.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSupContactNum.Location = new Point(202, 92);
            tbSupContactNum.Name = "tbSupContactNum";
            tbSupContactNum.PlaceholderText = "Contact Number";
            tbSupContactNum.Size = new Size(155, 25);
            tbSupContactNum.TabIndex = 19;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(100, 95);
            label14.Name = "label14";
            label14.Size = new Size(81, 17);
            label14.TabIndex = 18;
            label14.Text = "Contact No.";
            // 
            // tbSupLastName
            // 
            tbSupLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSupLastName.Location = new Point(390, 49);
            tbSupLastName.Name = "tbSupLastName";
            tbSupLastName.PlaceholderText = "Last Name";
            tbSupLastName.Size = new Size(155, 25);
            tbSupLastName.TabIndex = 17;
            // 
            // tbSupFirstName
            // 
            tbSupFirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSupFirstName.Location = new Point(202, 49);
            tbSupFirstName.Name = "tbSupFirstName";
            tbSupFirstName.PlaceholderText = "First Name";
            tbSupFirstName.Size = new Size(155, 25);
            tbSupFirstName.TabIndex = 16;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ActiveCaptionText;
            label15.Location = new Point(137, 52);
            label15.Name = "label15";
            label15.Size = new Size(44, 17);
            label15.TabIndex = 15;
            label15.Text = "Name";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(90, 12);
            label16.Name = "label16";
            label16.Size = new Size(92, 17);
            label16.TabIndex = 14;
            label16.Text = "Supervisor ID";
            // 
            // tbSupID
            // 
            tbSupID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSupID.Location = new Point(202, 9);
            tbSupID.Name = "tbSupID";
            tbSupID.PlaceholderText = "Supervisor ID";
            tbSupID.Size = new Size(212, 25);
            tbSupID.TabIndex = 4;
            // 
            // btnRegisterSup
            // 
            btnRegisterSup.BackColor = Color.FromArgb(39, 93, 43);
            btnRegisterSup.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterSup.ForeColor = Color.White;
            btnRegisterSup.Location = new Point(238, 272);
            btnRegisterSup.Name = "btnRegisterSup";
            btnRegisterSup.Size = new Size(119, 32);
            btnRegisterSup.TabIndex = 3;
            btnRegisterSup.Text = "REGISTER";
            btnRegisterSup.UseVisualStyleBackColor = false;
            btnRegisterSup.Click += btnRegisterSup_Click;
            // 
            // pnlStudent
            // 
            pnlStudent.Controls.Add(studEyeShow);
            pnlStudent.Controls.Add(studEyeHidden);
            pnlStudent.Controls.Add(tbStudPassword);
            pnlStudent.Controls.Add(label10);
            pnlStudent.Controls.Add(tbStudEmail);
            pnlStudent.Controls.Add(label9);
            pnlStudent.Controls.Add(tbStudSupervisorID);
            pnlStudent.Controls.Add(label6);
            pnlStudent.Controls.Add(tbStudContactNum);
            pnlStudent.Controls.Add(label5);
            pnlStudent.Controls.Add(tbStudLastName);
            pnlStudent.Controls.Add(tbStudFirstName);
            pnlStudent.Controls.Add(label4);
            pnlStudent.Controls.Add(label3);
            pnlStudent.Controls.Add(tbStudID);
            pnlStudent.Controls.Add(btnRegisterStud);
            pnlStudent.Location = new Point(62, 60);
            pnlStudent.Name = "pnlStudent";
            pnlStudent.Size = new Size(598, 317);
            pnlStudent.TabIndex = 14;
            pnlStudent.Visible = false;
            // 
            // studEyeShow
            // 
            studEyeShow.BackColor = Color.White;
            studEyeShow.Image = Properties.Resources.eye;
            studEyeShow.Location = new Point(332, 221);
            studEyeShow.Name = "studEyeShow";
            studEyeShow.Size = new Size(20, 20);
            studEyeShow.SizeMode = PictureBoxSizeMode.StretchImage;
            studEyeShow.TabIndex = 27;
            studEyeShow.TabStop = false;
            studEyeShow.Click += studEyeShow_Click;
            // 
            // studEyeHidden
            // 
            studEyeHidden.BackColor = Color.White;
            studEyeHidden.Image = Properties.Resources.eye_crossed;
            studEyeHidden.Location = new Point(332, 221);
            studEyeHidden.Name = "studEyeHidden";
            studEyeHidden.Size = new Size(20, 20);
            studEyeHidden.SizeMode = PictureBoxSizeMode.StretchImage;
            studEyeHidden.TabIndex = 26;
            studEyeHidden.TabStop = false;
            studEyeHidden.Click += studEyeHidden_Click;
            // 
            // tbStudPassword
            // 
            tbStudPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbStudPassword.Location = new Point(202, 218);
            tbStudPassword.Name = "tbStudPassword";
            tbStudPassword.PasswordChar = '•';
            tbStudPassword.PlaceholderText = "Password";
            tbStudPassword.Size = new Size(155, 25);
            tbStudPassword.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(115, 221);
            label10.Name = "label10";
            label10.Size = new Size(66, 17);
            label10.TabIndex = 24;
            label10.Text = "Password";
            // 
            // tbStudEmail
            // 
            tbStudEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbStudEmail.Location = new Point(202, 177);
            tbStudEmail.Name = "tbStudEmail";
            tbStudEmail.PlaceholderText = "Email";
            tbStudEmail.Size = new Size(155, 25);
            tbStudEmail.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(139, 180);
            label9.Name = "label9";
            label9.Size = new Size(42, 17);
            label9.TabIndex = 22;
            label9.Text = "Email";
            // 
            // tbStudSupervisorID
            // 
            tbStudSupervisorID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbStudSupervisorID.Location = new Point(202, 136);
            tbStudSupervisorID.Name = "tbStudSupervisorID";
            tbStudSupervisorID.PlaceholderText = "Supervisor ID";
            tbStudSupervisorID.Size = new Size(155, 25);
            tbStudSupervisorID.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(89, 140);
            label6.Name = "label6";
            label6.Size = new Size(92, 17);
            label6.TabIndex = 20;
            label6.Text = "Supervisor ID";
            // 
            // tbStudContactNum
            // 
            tbStudContactNum.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbStudContactNum.Location = new Point(202, 92);
            tbStudContactNum.Name = "tbStudContactNum";
            tbStudContactNum.PlaceholderText = "Contact Number";
            tbStudContactNum.Size = new Size(155, 25);
            tbStudContactNum.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(100, 95);
            label5.Name = "label5";
            label5.Size = new Size(81, 17);
            label5.TabIndex = 18;
            label5.Text = "Contact No.";
            // 
            // tbStudLastName
            // 
            tbStudLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbStudLastName.Location = new Point(390, 49);
            tbStudLastName.Name = "tbStudLastName";
            tbStudLastName.PlaceholderText = "Last Name";
            tbStudLastName.Size = new Size(155, 25);
            tbStudLastName.TabIndex = 17;
            // 
            // tbStudFirstName
            // 
            tbStudFirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbStudFirstName.Location = new Point(202, 49);
            tbStudFirstName.Name = "tbStudFirstName";
            tbStudFirstName.PlaceholderText = "First Name";
            tbStudFirstName.Size = new Size(155, 25);
            tbStudFirstName.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(137, 52);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 15;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(105, 12);
            label3.Name = "label3";
            label3.Size = new Size(76, 17);
            label3.TabIndex = 14;
            label3.Text = "ID Number";
            // 
            // tbStudID
            // 
            tbStudID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbStudID.Location = new Point(202, 9);
            tbStudID.Name = "tbStudID";
            tbStudID.PlaceholderText = "ID Number";
            tbStudID.Size = new Size(212, 25);
            tbStudID.TabIndex = 4;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 93, 43);
            ClientSize = new Size(805, 555);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlAdmin.ResumeLayout(false);
            pnlAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)adminEyeShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)adminEyeHidden).EndInit();
            pnlSupervisor.ResumeLayout(false);
            pnlSupervisor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)supEyeShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)supEyeHidden).EndInit();
            pnlStudent.ResumeLayout(false);
            pnlStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studEyeShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)studEyeHidden).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegisterStud;
        private Label label2;
        private ComboBox cmbAccountType;
        private Label label7;
        private Label label8;
        private Panel panel1;
        private Panel pnlStudent;
        private TextBox tbStudID;
        private Label label3;
        private TextBox tbStudFirstName;
        private Label label4;
        private TextBox tbStudEmail;
        private Label label9;
        private TextBox tbStudSupervisorID;
        private Label label6;
        private TextBox tbStudContactNum;
        private Label label5;
        private TextBox tbStudLastName;
        private TextBox tbStudPassword;
        private Label label10;
        private Panel pnlSupervisor;
        private TextBox tbSupPassword;
        private Label label11;
        private TextBox tbSupEmail;
        private Label label12;
        private TextBox tbSupCompany;
        private Label label13;
        private TextBox tbSupContactNum;
        private Label label14;
        private TextBox tbSupLastName;
        private TextBox tbSupFirstName;
        private Label label15;
        private Label label16;
        private TextBox tbSupID;
        private Button btnRegisterSup;
        private Panel pnlAdmin;
        private TextBox tbAdminPassword;
        private Label label17;
        private TextBox tbAdminEmail;
        private Label label18;
        private TextBox tbAdminContactNum;
        private Label label20;
        private TextBox tbAdminLastName;
        private TextBox tbAdminFirstName;
        private Label label21;
        private Label label22;
        private TextBox tbAdminID;
        private Button btnRegisterAdmin;
        private PictureBox studEyeHidden;
        private PictureBox studEyeShow;
        private PictureBox supEyeHidden;
        private PictureBox supEyeShow;
        private PictureBox adminEyeHidden;
        private PictureBox adminEyeShow;
    }
}