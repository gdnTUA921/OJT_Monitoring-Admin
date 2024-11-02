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

    public partial class UpdateSupervisor : Form
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

        public UpdateSupervisor(managingAcc manageAccForm)
        {
            InitializeComponent();
            _manageAccForm = manageAccForm;
        }

        public void loadItems()
        {
            dbConn.Open();

            string dbQuery = "SELECT supervisor_id, last_name, first_name, contact_number, company FROM supervisors WHERE user_id = @user_id"; // actual SQL
            MySqlCommand dbCmd = new MySqlCommand(dbQuery, dbConn); // commands from c# to MySQL

            dbCmd.Parameters.AddWithValue("@user_id", tbUserID.Text);
            MySqlDataReader dbReader = dbCmd.ExecuteReader(); // to fetch the data from database

            if (dbReader.Read())
            {
                int supId = dbReader.GetInt32(dbReader.GetOrdinal("supervisor_id"));
                String lastName = dbReader.GetString("last_name");
                String firstName = dbReader.GetString("first_name");
                String contactNum = dbReader.GetString("contact_number");
                String company = dbReader.GetString("company");

                tbSupID.Text = supId.ToString();
                tbSupLastName.Text = lastName;
                tbSupFirstName.Text = firstName;
                tbContactNo.Text = contactNum;
                tbCompany.Text = company;
            }

            else
            {
                MessageBox.Show("Invalid.");
            }

            dbConn.Close();
        }

        private void UpdateSupervisor_Load(object sender, EventArgs e)
        {
            loadItems();
        }

        private void btnUpdateSupervisor_Click(object sender, EventArgs e)
        {
            dbConn.Open();

            string dbQuery = "UPDATE supervisors SET supervisor_id = @supervisor_id, last_name = @last_name, first_name = @first_name, contact_number = @contact_num, company = @company WHERE user_id = @user_id"; // actual SQL
            MySqlCommand dbCmd = new MySqlCommand(dbQuery, dbConn); // commands from c# to MySQL

            dbCmd.Parameters.AddWithValue("@supervisor_id", tbSupID.Text);
            dbCmd.Parameters.AddWithValue("@last_name", tbSupLastName.Text);
            dbCmd.Parameters.AddWithValue("@first_name", tbSupFirstName.Text);
            dbCmd.Parameters.AddWithValue("@contact_num", tbContactNo.Text);
            dbCmd.Parameters.AddWithValue("@company", tbCompany.Text);
            dbCmd.Parameters.AddWithValue("@user_id", tbUserID.Text);

            int queryUpdate = dbCmd.ExecuteNonQuery(); // to insert the data to database

            if (queryUpdate > 0)
            {
                MessageBox.Show("Supervisor Updated Successfully.");
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
