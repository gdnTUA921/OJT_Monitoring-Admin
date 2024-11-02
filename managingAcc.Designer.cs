namespace OJT_Monitoring
{
    partial class managingAcc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lvUsers = new ListView();
            lvID = new ColumnHeader();
            lvLastName = new ColumnHeader();
            lvFirstName = new ColumnHeader();
            lvAccountType = new ColumnHeader();
            tbFilter = new TextBox();
            label2 = new Label();
            btnRemove = new Button();
            btnUpdate = new Button();
            tbID = new TextBox();
            label3 = new Label();
            pnlUpdate = new Panel();
            tbAccountType = new TextBox();
            tbLastName = new TextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(237, 26);
            label1.Name = "label1";
            label1.Size = new Size(342, 45);
            label1.TabIndex = 0;
            label1.Text = "MANAGE ACCOUNTS";
            // 
            // lvUsers
            // 
            lvUsers.BackColor = SystemColors.Window;
            lvUsers.Columns.AddRange(new ColumnHeader[] { lvID, lvLastName, lvFirstName, lvAccountType });
            lvUsers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lvUsers.FullRowSelect = true;
            lvUsers.GridLines = true;
            lvUsers.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvUsers.Location = new Point(95, 145);
            lvUsers.Name = "lvUsers";
            lvUsers.Size = new Size(608, 378);
            lvUsers.TabIndex = 1;
            toolTip1.SetToolTip(lvUsers, "Click a row to select");
            lvUsers.UseCompatibleStateImageBehavior = false;
            lvUsers.View = View.Details;
            lvUsers.MouseClick += lvUsers_MouseClick;
            // 
            // lvID
            // 
            lvID.Text = "ID#";
            lvID.Width = 120;
            // 
            // lvLastName
            // 
            lvLastName.Text = "Last Name";
            lvLastName.TextAlign = HorizontalAlignment.Center;
            lvLastName.Width = 160;
            // 
            // lvFirstName
            // 
            lvFirstName.Text = "First Name";
            lvFirstName.TextAlign = HorizontalAlignment.Center;
            lvFirstName.Width = 160;
            // 
            // lvAccountType
            // 
            lvAccountType.Text = "Account Type";
            lvAccountType.TextAlign = HorizontalAlignment.Center;
            lvAccountType.Width = 160;
            // 
            // tbFilter
            // 
            tbFilter.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbFilter.Location = new Point(166, 95);
            tbFilter.Name = "tbFilter";
            tbFilter.Size = new Size(100, 25);
            tbFilter.TabIndex = 2;
            tbFilter.TextChanged += tbFilter_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(95, 95);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 3;
            label2.Text = "Search:";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(616, 90);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(87, 33);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Lime;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(511, 90);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(87, 33);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tbID
            // 
            tbID.Enabled = false;
            tbID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbID.Location = new Point(365, 95);
            tbID.Name = "tbID";
            tbID.Size = new Size(100, 25);
            tbID.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(323, 95);
            label3.Name = "label3";
            label3.Size = new Size(36, 21);
            label3.TabIndex = 7;
            label3.Text = "ID#";
            // 
            // pnlUpdate
            // 
            pnlUpdate.Location = new Point(0, 0);
            pnlUpdate.Name = "pnlUpdate";
            pnlUpdate.Size = new Size(816, 580);
            pnlUpdate.TabIndex = 8;
            pnlUpdate.Visible = false;
            // 
            // tbAccountType
            // 
            tbAccountType.BackColor = Color.FromArgb(44, 95, 52);
            tbAccountType.BorderStyle = BorderStyle.None;
            tbAccountType.Location = new Point(298, 64);
            tbAccountType.Name = "tbAccountType";
            tbAccountType.Size = new Size(100, 16);
            tbAccountType.TabIndex = 9;
            tbAccountType.Visible = false;
            // 
            // tbLastName
            // 
            tbLastName.BackColor = Color.FromArgb(44, 95, 52);
            tbLastName.BorderStyle = BorderStyle.None;
            tbLastName.Location = new Point(422, 64);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(100, 16);
            tbLastName.TabIndex = 10;
            tbLastName.Visible = false;
            // 
            // managingAcc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 95, 52);
            ClientSize = new Size(816, 580);
            Controls.Add(pnlUpdate);
            Controls.Add(tbLastName);
            Controls.Add(tbAccountType);
            Controls.Add(label3);
            Controls.Add(tbID);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemove);
            Controls.Add(label2);
            Controls.Add(tbFilter);
            Controls.Add(lvUsers);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(44, 95, 52);
            FormBorderStyle = FormBorderStyle.None;
            Name = "managingAcc";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lvUsers;
        private ColumnHeader lvID;
        private ColumnHeader lvLastName;
        private ColumnHeader lvAccountType;
        private TextBox tbFilter;
        private Label label2;
        private Button btnRemove;
        private Button btnUpdate;
        private TextBox tbID;
        private Label label3;
        private Panel pnlUpdate;
        private TextBox tbAccountType;
        private TextBox tbLastName;
        private ToolTip toolTip1;
        private ColumnHeader lvFirstName;
    }
}
