using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OJT_Monitoring
{
    public partial class MainAdmin : Form
    {
        bool sidebarExpand = false;
        Home_Admin_ homeAdmin;
        Register register;
        managingAcc manageAccount;
        AccountSettings_Admin accountSettings;

        public MainAdmin()
        {
            InitializeComponent();
            loadItem();
        }

        public void loadItem()
        {
            homeAdmin = new Home_Admin_();
            homeAdmin.FormClosed += Home_Admin_FormClosed;
            homeAdmin.MdiParent = this;
            homeAdmin.Dock = DockStyle.Fill;
            homeAdmin.Show();
        }


        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == true)
            {
                sideBar.Width -= 10;

                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sideBarTimer.Stop();
                }
            }

            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Log Out?", "Log Out Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Logged Out Succcessfully");
                OJTSession.Clear();
                this.Hide();

                LogIn form1 = new LogIn();
                form1.ShowDialog();

                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //NO ACTION DONE...
            }
        }


        private void registerAccount_Click(object sender, EventArgs e)
        {
            if (register == null)
            {
                register = new Register(this);
                register.FormClosed += Register_FormClosed;
                register.MdiParent = this;
                register.Dock = DockStyle.Fill;
                register.Show();
            }

            else
            {
                register = null;
                register = new Register(this);
                register.FormClosed += Register_FormClosed;
                register.MdiParent = this;
                register.Dock = DockStyle.Fill;
                register.Show();
            }
        }

        private void Register_FormClosed(object sender, EventArgs e)
        {
            register = null;
        }


        private void homeButton_Click(object sender, EventArgs e)
        {
            if (homeAdmin == null)
            {
                homeAdmin = new Home_Admin_();
                homeAdmin.FormClosed += Home_Admin_FormClosed;
                homeAdmin.MdiParent = this;
                homeAdmin.Dock = DockStyle.Fill;
                homeAdmin.Show();
            }

            else
            {
                homeAdmin.Activate();
            }
        }

        private void Home_Admin_FormClosed(object sender, EventArgs e)
        {
            homeAdmin = null;
        }

        private void manageAccounts_Click(object sender, EventArgs e)
        {
            if (manageAccount == null)
            {
                manageAccount = new managingAcc();
                manageAccount.FormClosed += manageAcc_FormClosed;
                manageAccount.MdiParent = this;
                manageAccount.Dock = DockStyle.Fill;
                manageAccount.Show();
            }

            else
            {
                manageAccount = null;
                manageAccount = new managingAcc();
                manageAccount.FormClosed += manageAcc_FormClosed;
                manageAccount.MdiParent = this;
                manageAccount.Dock = DockStyle.Fill;
                manageAccount.Show();
            }
        }

        private void manageAcc_FormClosed(object sender, EventArgs e)
        {
            manageAccount = null;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            if (accountSettings == null)
            {
                accountSettings = new AccountSettings_Admin(this);
                accountSettings.FormClosed += AccountSettings_FormClosed;
                accountSettings.MdiParent = this;
                accountSettings.Dock = DockStyle.Fill;
                accountSettings.Show();
            }

            else
            {
                accountSettings = null;
                accountSettings = new AccountSettings_Admin(this);
                accountSettings.FormClosed += AccountSettings_FormClosed;
                accountSettings.MdiParent = this;
                accountSettings.Dock = DockStyle.Fill;
                accountSettings.Show();
            }
        }

        private void AccountSettings_FormClosed(object sender, EventArgs e)
        {
            accountSettings = null;
        }
    }
}
