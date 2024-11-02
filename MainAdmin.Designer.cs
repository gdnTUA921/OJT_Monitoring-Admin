namespace OJT_Monitoring
{
    partial class MainAdmin
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
            components = new System.ComponentModel.Container();
            sideBar = new FlowLayoutPanel();
            panel2 = new Panel();
            button3 = new Button();
            menu_button = new PictureBox();
            homeButton = new Button();
            listInterns = new Button();
            registerAccount = new Button();
            manageAccounts = new Button();
            settings = new Button();
            logOut = new Button();
            sideBarTimer = new System.Windows.Forms.Timer(components);
            sideBar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menu_button).BeginInit();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.BackColor = SystemColors.ActiveCaptionText;
            sideBar.Controls.Add(panel2);
            sideBar.Controls.Add(homeButton);
            sideBar.Controls.Add(listInterns);
            sideBar.Controls.Add(registerAccount);
            sideBar.Controls.Add(manageAccounts);
            sideBar.Controls.Add(settings);
            sideBar.Controls.Add(logOut);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 0);
            sideBar.MaximumSize = new Size(227, 561);
            sideBar.MinimumSize = new Size(73, 561);
            sideBar.Name = "sideBar";
            sideBar.Padding = new Padding(3, 15, 0, 0);
            sideBar.Size = new Size(73, 561);
            sideBar.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(menu_button);
            panel2.Location = new Point(6, 18);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 15, 0, 0);
            panel2.Size = new Size(221, 71);
            panel2.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.home1;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Padding = new Padding(20, 0, 0, 0);
            button3.Size = new Size(0, 0);
            button3.TabIndex = 0;
            button3.Text = "HOME";
            button3.UseVisualStyleBackColor = false;
            // 
            // menu_button
            // 
            menu_button.Image = Properties.Resources.menu_burger1;
            menu_button.Location = new Point(17, 18);
            menu_button.Name = "menu_button";
            menu_button.Size = new Size(30, 30);
            menu_button.SizeMode = PictureBoxSizeMode.StretchImage;
            menu_button.TabIndex = 0;
            menu_button.TabStop = false;
            menu_button.Click += menu_button_Click;
            // 
            // homeButton
            // 
            homeButton.BackColor = SystemColors.ActiveCaptionText;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            homeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.Font = new Font("Microsoft Sans Serif", 11.9999981F);
            homeButton.ForeColor = Color.White;
            homeButton.Image = Properties.Resources.home1;
            homeButton.ImageAlign = ContentAlignment.MiddleLeft;
            homeButton.Location = new Point(6, 95);
            homeButton.Name = "homeButton";
            homeButton.Padding = new Padding(15, 0, 0, 0);
            homeButton.Size = new Size(222, 41);
            homeButton.TabIndex = 5;
            homeButton.Text = "           Home";
            homeButton.TextAlign = ContentAlignment.MiddleLeft;
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // listInterns
            // 
            listInterns.BackColor = SystemColors.ActiveCaptionText;
            listInterns.FlatAppearance.BorderSize = 0;
            listInterns.FlatAppearance.MouseDownBackColor = Color.Gray;
            listInterns.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            listInterns.FlatStyle = FlatStyle.Flat;
            listInterns.Font = new Font("Microsoft Sans Serif", 11.9999981F);
            listInterns.ForeColor = Color.White;
            listInterns.Image = Properties.Resources.member_list;
            listInterns.ImageAlign = ContentAlignment.MiddleLeft;
            listInterns.Location = new Point(6, 142);
            listInterns.Name = "listInterns";
            listInterns.Padding = new Padding(15, 0, 0, 0);
            listInterns.Size = new Size(221, 41);
            listInterns.TabIndex = 6;
            listInterns.Text = "           List of Interns";
            listInterns.TextAlign = ContentAlignment.MiddleLeft;
            listInterns.UseVisualStyleBackColor = false;
            // 
            // registerAccount
            // 
            registerAccount.BackColor = SystemColors.ActiveCaptionText;
            registerAccount.FlatAppearance.BorderSize = 0;
            registerAccount.FlatAppearance.MouseDownBackColor = Color.Gray;
            registerAccount.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            registerAccount.FlatStyle = FlatStyle.Flat;
            registerAccount.Font = new Font("Microsoft Sans Serif", 11.9999981F);
            registerAccount.ForeColor = Color.White;
            registerAccount.Image = Properties.Resources.output_onlinepngtools__1_;
            registerAccount.ImageAlign = ContentAlignment.MiddleLeft;
            registerAccount.Location = new Point(6, 189);
            registerAccount.Name = "registerAccount";
            registerAccount.Padding = new Padding(15, 0, 0, 0);
            registerAccount.Size = new Size(221, 41);
            registerAccount.TabIndex = 7;
            registerAccount.Text = "           Register Account";
            registerAccount.TextAlign = ContentAlignment.MiddleLeft;
            registerAccount.UseVisualStyleBackColor = false;
            registerAccount.Click += registerAccount_Click;
            // 
            // manageAccounts
            // 
            manageAccounts.BackColor = SystemColors.ActiveCaptionText;
            manageAccounts.FlatAppearance.BorderSize = 0;
            manageAccounts.FlatAppearance.MouseDownBackColor = Color.Gray;
            manageAccounts.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            manageAccounts.FlatStyle = FlatStyle.Flat;
            manageAccounts.Font = new Font("Microsoft Sans Serif", 11.9999981F);
            manageAccounts.ForeColor = Color.White;
            manageAccounts.Image = Properties.Resources.manage_accounts_icon;
            manageAccounts.ImageAlign = ContentAlignment.MiddleLeft;
            manageAccounts.Location = new Point(6, 236);
            manageAccounts.Name = "manageAccounts";
            manageAccounts.Padding = new Padding(15, 0, 0, 0);
            manageAccounts.Size = new Size(221, 41);
            manageAccounts.TabIndex = 8;
            manageAccounts.Text = "           Manage Accounts";
            manageAccounts.TextAlign = ContentAlignment.MiddleLeft;
            manageAccounts.UseVisualStyleBackColor = false;
            manageAccounts.Click += manageAccounts_Click;
            // 
            // settings
            // 
            settings.BackColor = SystemColors.ActiveCaptionText;
            settings.FlatAppearance.BorderSize = 0;
            settings.FlatAppearance.MouseDownBackColor = Color.Gray;
            settings.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            settings.FlatStyle = FlatStyle.Flat;
            settings.Font = new Font("Microsoft Sans Serif", 11.9999981F);
            settings.ForeColor = Color.White;
            settings.Image = Properties.Resources.user_gear;
            settings.ImageAlign = ContentAlignment.MiddleLeft;
            settings.Location = new Point(6, 283);
            settings.Name = "settings";
            settings.Padding = new Padding(15, 0, 0, 0);
            settings.Size = new Size(221, 41);
            settings.TabIndex = 9;
            settings.Text = "           Settings";
            settings.TextAlign = ContentAlignment.MiddleLeft;
            settings.UseVisualStyleBackColor = false;
            settings.Click += settings_Click;
            // 
            // logOut
            // 
            logOut.BackColor = SystemColors.ActiveCaptionText;
            logOut.FlatAppearance.BorderSize = 0;
            logOut.FlatAppearance.MouseDownBackColor = Color.Gray;
            logOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            logOut.FlatStyle = FlatStyle.Flat;
            logOut.Font = new Font("Microsoft Sans Serif", 11.9999981F);
            logOut.ForeColor = Color.White;
            logOut.Image = Properties.Resources.sign_out_alt1;
            logOut.ImageAlign = ContentAlignment.MiddleLeft;
            logOut.Location = new Point(6, 330);
            logOut.Name = "logOut";
            logOut.Padding = new Padding(15, 0, 0, 0);
            logOut.Size = new Size(221, 41);
            logOut.TabIndex = 10;
            logOut.Text = "           Log Out";
            logOut.TextAlign = ContentAlignment.MiddleLeft;
            logOut.UseVisualStyleBackColor = false;
            logOut.Click += logOut_Click;
            // 
            // sideBarTimer
            // 
            sideBarTimer.Interval = 10;
            sideBarTimer.Tick += sideBarTimer_Tick;
            // 
            // MainAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(sideBar);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IsMdiContainer = true;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "MainAdmin";
            Text = "TUA OJT MONITORING (Admin/Coordinator)";
            sideBar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menu_button).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sideBar;
        private PictureBox menu_button;
        private Panel panel2;
        private Button button3;
        private Button homeButton;
        private Button listInterns;
        private Button registerAccount;
        private Button manageAccounts;
        private Button settings;
        private Button logOut;
        private System.Windows.Forms.Timer sideBarTimer;
    }
}