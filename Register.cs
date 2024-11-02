using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OJT_Monitoring
{
    using MySql.Data.MySqlClient; // Do not forget this part
    using Org.BouncyCastle.Bcpg;
    using Org.BouncyCastle.Crypto.Engines;
    using System.Data;
    using System.Data.Common;

    public partial class Register : Form
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

        MainAdmin back2home;

        public Register(MainAdmin backHome)
        {
            InitializeComponent();
            back2home = backHome;
        }

        private void cmbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Point panelLocation = new Point(62, 60);

            if (cmbAccountType.SelectedIndex == 0)
            {
                pnlSupervisor.Visible = false;
                pnlAdmin.Visible = false;

                pnlStudent.Location = panelLocation;
                pnlStudent.Visible = true;
            }

            else if (cmbAccountType.SelectedIndex == 1)
            {
                pnlStudent.Visible = false;
                pnlAdmin.Visible = false;

                pnlSupervisor.Location = panelLocation;
                pnlSupervisor.Visible = true;
            }

            else if (cmbAccountType.SelectedIndex == 2)
            {
                pnlStudent.Visible = false;
                pnlSupervisor.Visible = false;

                pnlAdmin.Visible = true;
                pnlAdmin.Location = panelLocation;
            }
        }

        //Register Student
        private void btnRegisterStud_Click(object sender, EventArgs e)
        {
            dbConn.Open();

            String dbQuery1 = "INSERT INTO users (user_email, account_type, password) " +
                "VALUES (@user_email, @account_type, @password)";

            MySqlCommand dbCmd1 = new MySqlCommand(dbQuery1, dbConn);

            dbCmd1.Parameters.AddWithValue("@user_email", tbStudEmail.Text);
            dbCmd1.Parameters.AddWithValue("@account_type", cmbAccountType.Text);
            dbCmd1.Parameters.AddWithValue("@password", tbStudPassword.Text);

            int queryStatus1 = dbCmd1.ExecuteNonQuery();

            if (queryStatus1 > 0)
            {
                //Fetching new user_id for next INSERT Query dbQuery2
                String subQuery = "SELECT user_id FROM users WHERE user_email = @user_email";
                MySqlCommand dbSubQuery = new MySqlCommand(subQuery, dbConn);

                dbSubQuery.Parameters.AddWithValue("@user_email", tbStudEmail.Text);
                MySqlDataReader dataReader = dbSubQuery.ExecuteReader();


                if (dataReader.Read())
                {
                    String userID = dataReader.GetInt32("user_id").ToString();
                    dataReader.Close();

                    //Next INSERT QUERY dbQuery2
                    String dbQuery2 = "INSERT INTO students (student_number, last_name, first_name, contact_number, user_id, supervisor_id) " +
                     "VALUES (@student_number, @last_name, @first_name, @contact_number," + userID + ", @supervisor_id)";

                    MySqlCommand dbCmd2 = new MySqlCommand(dbQuery2, dbConn);

                    dbCmd2.Parameters.AddWithValue("@student_number", tbStudID.Text);
                    dbCmd2.Parameters.AddWithValue("@last_name", tbStudLastName.Text);
                    dbCmd2.Parameters.AddWithValue("@first_name", tbStudFirstName.Text);
                    dbCmd2.Parameters.AddWithValue("@contact_number", tbStudContactNum.Text);
                    dbCmd2.Parameters.AddWithValue("@supervisor_id", tbStudSupervisorID.Text);

                    int queryStatus2 = dbCmd2.ExecuteNonQuery();

                    if (queryStatus2 > 0)
                    {
                        MessageBox.Show("Account Registered Successfully.");
                        dbConn.Close();
                        this.Close();
                        back2home.loadItem();
                    }

                    else
                    {
                        MessageBox.Show("Failed to Register Account. - OJT3");
                        dbConn.Close();
                    }
                }

                else
                {
                    MessageBox.Show("Failed to Register Account. - OJT2");
                    dbConn.Close();
                }
            }

            else
            {
                MessageBox.Show("Failed to Register Account. - OJT1");
                dbConn.Close();
            }
        }

        //Register Supervisor
        private void btnRegisterSup_Click(object sender, EventArgs e)
        {
            dbConn.Open();

            String dbQuery1 = "INSERT INTO users (user_email, account_type, password) " +
                "VALUES (@user_email, @account_type, @password)";

            MySqlCommand dbCmd1 = new MySqlCommand(dbQuery1, dbConn);

            dbCmd1.Parameters.AddWithValue("@user_email", tbSupEmail.Text);
            dbCmd1.Parameters.AddWithValue("@account_type", cmbAccountType.Text);
            dbCmd1.Parameters.AddWithValue("@password", tbSupPassword.Text);

            int queryStatus1 = dbCmd1.ExecuteNonQuery();

            if (queryStatus1 > 0)
            {
                //Fetching new user_id for next INSERT Query dbQuery2
                String subQuery = "SELECT user_id FROM users WHERE user_email = @user_email";
                MySqlCommand dbSubQuery = new MySqlCommand(subQuery, dbConn);

                dbSubQuery.Parameters.AddWithValue("@user_email", tbSupEmail.Text);
                MySqlDataReader dataReader = dbSubQuery.ExecuteReader();


                if (dataReader.Read())
                {
                    String userID = dataReader.GetInt32("user_id").ToString();
                    dataReader.Close();

                    //Next INSERT QUERY dbQuery2
                    String dbQuery2 = "INSERT INTO supervisors (supervisor_id, last_name, first_name, contact_number, company, user_id) " +
                     "VALUES (@supervisor_id, @last_name, @first_name, @contact_number, @company, " + userID + ")";

                    MySqlCommand dbCmd2 = new MySqlCommand(dbQuery2, dbConn);

                    dbCmd2.Parameters.AddWithValue("@supervisor_id", tbSupID.Text);
                    dbCmd2.Parameters.AddWithValue("@last_name", tbSupLastName.Text);
                    dbCmd2.Parameters.AddWithValue("@first_name", tbSupFirstName.Text);
                    dbCmd2.Parameters.AddWithValue("@contact_number", tbSupContactNum.Text);
                    dbCmd2.Parameters.AddWithValue("@company", tbSupCompany.Text);

                    int queryStatus2 = dbCmd2.ExecuteNonQuery();

                    if (queryStatus2 > 0)
                    {
                        MessageBox.Show("Account Registered Successfully.");
                        dbConn.Close();
                        this.Close();
                        back2home.loadItem();
                    }

                    else
                    {
                        MessageBox.Show("Failed to Register Account. - OJT3");
                        dbConn.Close();
                    }
                }

                else
                {
                    MessageBox.Show("Failed to Register Account. - OJT2");
                    dbConn.Close();
                }
            }

            else
            {
                MessageBox.Show("Failed to Register Account. - OJT1");
                dbConn.Close();
            }
        }

        //Register Admin
        private void btnRegisterAdmin_Click(object sender, EventArgs e)
        {
            dbConn.Open();

            String dbQuery1 = "INSERT INTO users (user_email, account_type, password) " +
                "VALUES (@user_email, @account_type, @password)";

            MySqlCommand dbCmd1 = new MySqlCommand(dbQuery1, dbConn);

            dbCmd1.Parameters.AddWithValue("@user_email", tbAdminEmail.Text);
            dbCmd1.Parameters.AddWithValue("@account_type", cmbAccountType.Text);
            dbCmd1.Parameters.AddWithValue("@password", tbAdminPassword.Text);

            int queryStatus1 = dbCmd1.ExecuteNonQuery();

            if (queryStatus1 > 0)
            {
                //Fetching new user_id for next INSERT Query dbQuery2
                String subQuery = "SELECT user_id FROM users WHERE user_email = @user_email";
                MySqlCommand dbSubQuery = new MySqlCommand(subQuery, dbConn);

                dbSubQuery.Parameters.AddWithValue("@user_email", tbAdminEmail.Text);
                MySqlDataReader dataReader = dbSubQuery.ExecuteReader();


                if (dataReader.Read())
                {
                    String userID = dataReader.GetInt32("user_id").ToString();
                    dataReader.Close();

                    //Next INSERT QUERY dbQuery2
                    String dbQuery2 = "INSERT INTO admin (admin_id, user_id, last_name, first_name, contact_number) " +
                     "VALUES (@admin_id, " + userID + ", @last_name, @first_name, @contact_number)";

                    MySqlCommand dbCmd2 = new MySqlCommand(dbQuery2, dbConn);

                    dbCmd2.Parameters.AddWithValue("@admin_id", tbAdminID.Text);
                    dbCmd2.Parameters.AddWithValue("@last_name", tbAdminLastName.Text);
                    dbCmd2.Parameters.AddWithValue("@first_name", tbAdminFirstName.Text);
                    dbCmd2.Parameters.AddWithValue("@contact_number", tbAdminContactNum.Text);

                    int queryStatus2 = dbCmd2.ExecuteNonQuery();

                    if (queryStatus2 > 0)
                    {
                        MessageBox.Show("Account Registered Successfully.");
                        dbConn.Close();
                        this.Close();
                        back2home.loadItem();
                    }

                    else
                    {
                        MessageBox.Show("Failed to Register Account. - OJT3");
                        dbConn.Close();
                    }
                }

                else
                {
                    MessageBox.Show("Failed to Register Account. - OJT2");
                    dbConn.Close();
                }
            }

            else
            {
                MessageBox.Show("Failed to Register Account. - OJT1");
                dbConn.Close();
            }
        }

        //Password Eye SHOW/HIDE
        private void studEyeHidden_Click(object sender, EventArgs e)
        {
            showHidePass(tbStudPassword, studEyeHidden, studEyeShow);
        }

        private void studEyeShow_Click(object sender, EventArgs e)
        {
            showHidePass(tbStudPassword, studEyeHidden, studEyeShow);
        }

        private void supEyeHidden_Click(object sender, EventArgs e)
        {
            showHidePass(tbSupPassword, supEyeHidden, supEyeShow);
        }

        private void supEyeShow_Click(object sender, EventArgs e)
        {
            showHidePass(tbSupPassword, supEyeHidden, supEyeShow);
        }

        private void adminEyeHidden_Click(object sender, EventArgs e)
        {
            showHidePass(tbAdminPassword, adminEyeHidden, adminEyeShow);
        }

        private void adminEyeShow_Click(object sender, EventArgs e)
        {
            showHidePass(tbAdminPassword, adminEyeHidden, adminEyeShow);
        }

        public void showHidePass(TextBox tbAccPass, PictureBox eyeHide, PictureBox eyeShow)
        { 

            if (tbAccPass.PasswordChar == '•')
            {
                tbAccPass.PasswordChar = '\0';
                eyeHide.BringToFront();
            }

            else if (tbAccPass.PasswordChar == '\0')
            {
                tbAccPass.PasswordChar = '•';
                eyeShow.BringToFront();
            }
        }
    }

}

