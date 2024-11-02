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

    public partial class UpdateAdmin : Form
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

        private managingAcc _manageAccForm;
        public UpdateAdmin(managingAcc manageAccForm)
        {
            InitializeComponent();
            _manageAccForm = manageAccForm;
        }

        public void loadItems()
        {
            dbConn.Open();

            string dbQuery = "SELECT admin_id, last_name, first_name, contact_number FROM admin WHERE user_id = @user_id"; // actual SQL
            MySqlCommand dbCmd = new MySqlCommand(dbQuery, dbConn); // commands from c# to MySQL

            dbCmd.Parameters.AddWithValue("@user_id", tbUserID.Text);
            MySqlDataReader dbReader = dbCmd.ExecuteReader(); // to fetch the data from database

            if (dbReader.Read())
            {
                int adminID = dbReader.GetInt32(dbReader.GetOrdinal("admin_id"));
                String lastName = dbReader.GetString("last_name");
                String firstName = dbReader.GetString("first_name");
                String contactNum = dbReader.GetString("contact_number");

                tbAdminID.Text = adminID.ToString();
                tbAdminLastName.Text = lastName;
                tbAdminFirstName.Text = firstName;
                tbContactNo.Text = contactNum;
            }

            else
            {
                MessageBox.Show("Invalid.");
            }

            dbConn.Close();
        }

        private void UpdateAdmin_Load(object sender, EventArgs e)
        {
            loadItems();
        }

        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            dbConn.Open();

            string dbQuery = "UPDATE admin SET admin_id = @admin_id, last_name = @last_name, first_name = @first_name, contact_number = @contact_num WHERE user_id = @user_id"; // actual SQL
            MySqlCommand dbCmd = new MySqlCommand(dbQuery, dbConn); // commands from c# to MySQL

            dbCmd.Parameters.AddWithValue("@admin_id", tbAdminID.Text);
            dbCmd.Parameters.AddWithValue("@last_name", tbAdminLastName.Text);
            dbCmd.Parameters.AddWithValue("@first_name", tbAdminFirstName.Text);
            dbCmd.Parameters.AddWithValue("@contact_num", tbContactNo.Text);
            dbCmd.Parameters.AddWithValue("@user_id", tbUserID.Text);

            int queryUpdate = dbCmd.ExecuteNonQuery(); // to insert the data to database

            if (queryUpdate > 0)
            {
                MessageBox.Show("Admin Updated Successfully.");
                this.Close();
                _manageAccForm.HidePanel();
                _manageAccForm.LoadItems();
            }

            else
            {
                MessageBox.Show("Updated Failed.");
            }

            dbConn.Close();
        }
    }
}
