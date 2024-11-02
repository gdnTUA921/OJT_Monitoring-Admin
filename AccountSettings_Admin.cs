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

    using MySql.Data.MySqlClient; // Do not forget this part
    using Org.BouncyCastle.Crypto.Engines;
    using System.Data;
    using System.Data.Common;

    public partial class AccountSettings_Admin : Form
    {
        static string server = "localhost";
        static string port = "3306";
        static string username = "root";
        static string password = "";
        static string database = "tua_ojt_monitoring";

        MySqlConnection dbConn = new MySqlConnection(
            "server=" + server + ";" +
            "port=" + port + ";" +
            "username=" + username + ";" +
            "password=" + password + ";" +
            "database=" + database + ";");

        MainAdmin back2Home;

        public AccountSettings_Admin(MainAdmin mainAdmin)
        {
            InitializeComponent();
            back2Home = mainAdmin;
        }

        private void AccountSettings_Load(object sender, EventArgs e)
        {
            loadSettings();
        }

        //Load Settings Page
        private void loadSettings()
        {
            dbConn.Open();

            string dbQuery = "SELECT admin_id, first_name, last_name, contact_number FROM admin WHERE user_id = " + OJTSession.userID;

            MySqlCommand dbCmd = new MySqlCommand(dbQuery, dbConn);

            MySqlDataReader dataReader = dbCmd.ExecuteReader();

            if (dataReader.Read())
            {
                string admin_ID = dataReader.GetInt32("admin_id").ToString();
                string first_name = dataReader.GetString("first_name");
                string last_name = dataReader.GetString("last_name");
                string contact_num = dataReader.GetString("contact_number");

                adminID.Text = admin_ID;
                fullName.Text = first_name + " " + last_name;
                contactNum.Text = contact_num;
                accType.Text = OJTSession.accType;
                tbEmail_Admin.Text = OJTSession.userEmail;

                dbConn.Close();
            }

            else
            {
                MessageBox.Show("Can't Load Details");
            }
        }


        //Checking if New Password and Confirm New Password Matches
        private void newPass_TextChanged(object sender, EventArgs e)
        {
            ValidatePass();
        }

        private void confirmNewPass_TextChanged(object sender, EventArgs e)
        {
            ValidatePass();
        }

        private void ValidatePass()
        {
            if (confirmNewPass.Text == "" && newPass.Text == "")
            {
                matchMessage.Visible = false;
                matchMessage2.Visible = false;
            }

            else if (confirmNewPass.Text == newPass.Text)
            {
                matchMessage.Visible = true;
                matchMessage2.Visible = true;
                matchMessage.Text = "Passwords Matched";
                matchMessage2.Text = "Passwords Matched";
                matchMessage.ForeColor = Color.DarkOliveGreen;
                matchMessage2.ForeColor = Color.DarkOliveGreen;
            }

            else
            {
                matchMessage.Visible = true;
                matchMessage2.Visible = true;
                matchMessage.Text = "Passwords Don't Match";
                matchMessage2.Text = "Passwords Don't Match";
                matchMessage.ForeColor = Color.Red;
                matchMessage2.ForeColor = Color.Red;
            }
        }


        //EYE and EYE CROSSED (SHOW AND HIDE PASSWORD)
        private void oldPassEyeShow_Click(object sender, EventArgs e)
        {
            CheckEyePass(oldPass, oldPassEyeShow, oldPassEyeHidden);
        }

        private void oldPassEyeHidden_Click(object sender, EventArgs e)
        {
            CheckEyePass(oldPass, oldPassEyeShow, oldPassEyeHidden);
        }

        private void newPassEyeShow_Click(object sender, EventArgs e)
        {
            CheckEyePass(newPass, newPassEyeShow, newPassEyeHidden);
        }

        private void newPassEyeHidden_Click(object sender, EventArgs e)
        {
            CheckEyePass(newPass, newPassEyeShow, newPassEyeHidden);
        }

        private void confirmNewPassEyeShow_Click(object sender, EventArgs e)
        {
            CheckEyePass(confirmNewPass, confirmNewPassEyeShow, confirmPassEyeHidden);
        }

        private void confirmPassEyeHidden_Click(object sender, EventArgs e)
        {
            CheckEyePass(confirmNewPass, confirmNewPassEyeShow, confirmPassEyeHidden);
        }

        private void CheckEyePass(TextBox passWord, PictureBox eyeShow, PictureBox eyeHide)
        {
            if (passWord.PasswordChar == '•')
            {
                passWord.PasswordChar = '\0';
                eyeHide.BringToFront();
            }

            else if (passWord.PasswordChar == '\0')
            {
                passWord.PasswordChar = '•';
                eyeShow.BringToFront();
            }
        }


        //UPDATE BUTTON
        private void updateAccount_Click(object sender, EventArgs e)
        {
            if (tbEmail_Admin.Text != "" && oldPass.Text != "" && newPass.Text != "" && confirmNewPass.Text != "")
            {
                dbConn.Open();

                string dbQuery1 = "SELECT password FROM users WHERE user_id = " + OJTSession.userID;
                MySqlCommand dbCmd1 = new MySqlCommand(dbQuery1, dbConn);

                MySqlDataReader dataReader1 = dbCmd1.ExecuteReader();

                string oldPassWord;
                if (dataReader1.Read())
                {
                    oldPassWord = dataReader1.GetString("password");
                    dataReader1.Close();

                    if (oldPassWord == oldPass.Text && newPass.Text == confirmNewPass.Text)
                    {
                        string dbQuery2 = "UPDATE users SET user_email = @new_user_email, password = @new_password WHERE user_id = " + OJTSession.userID;
                        MySqlCommand dbCmd2 = new MySqlCommand(dbQuery2, dbConn);

                        dbCmd2.Parameters.AddWithValue("@new_user_email", tbEmail_Admin.Text);
                        dbCmd2.Parameters.AddWithValue("@new_password", newPass.Text);

                        int query2 = dbCmd2.ExecuteNonQuery();

                        if (query2 > 0)
                        {
                            MessageBox.Show("Account Updated Successfully");
                            dbConn.Close();
                            this.Close();
                            back2Home.loadItem();
                        }

                        else
                        {
                            MessageBox.Show("Account Update Failed");
                            dbConn.Close();
                            loadSettings();
                        }
                    }

                    else
                    {
                        MessageBox.Show("Account Update Failed. Passwords Don't Match");
                        dbConn.Close();
                        loadSettings();
                    }
                }

                else
                {
                    MessageBox.Show("Failed to Update Details");
                    dbConn.Close();
                    loadSettings();
                }
            }

            else
            {
                MessageBox.Show("Invalid Details");
                loadSettings();
            }
        }
    }
}
