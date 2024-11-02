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
    using OJT_Monitoring;
    using Org.BouncyCastle.Crypto.Engines;
    using System.Data;
    using System.Data.Common;

    public partial class UpdateStudent : Form
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

        public UpdateStudent(managingAcc manageAccForm)
        {
            InitializeComponent();
            _manageAccForm = manageAccForm;
        }

        public void loadItems()
        {
            dbConn.Open();

            string dbQuery = "SELECT student_number, last_name, first_name, contact_number, supervisor_id FROM students WHERE user_id = @user_id"; // actual SQL
            MySqlCommand dbCmd = new MySqlCommand(dbQuery, dbConn); // commands from c# to MySQL

            dbCmd.Parameters.AddWithValue("@user_id", tbUserID.Text);
            MySqlDataReader dbReader = dbCmd.ExecuteReader(); // to fetch the data from database

            if (dbReader.Read())
            {
                int studNum = dbReader.GetInt32(dbReader.GetOrdinal("student_number"));
                String lastName = dbReader.GetString("last_name");
                String firstName = dbReader.GetString("first_name");
                String contactNum = dbReader.GetString("contact_number");

                // Check for NULL value in supervisor_id
                if (!dbReader.IsDBNull(dbReader.GetOrdinal("supervisor_id")))
                {
                    int supervisorID = dbReader.GetInt32(dbReader.GetOrdinal("supervisor_id"));
                    tbSupervisorID.Text = supervisorID.ToString();
                }
                else
                {
                    // Handle NULL supervisor ID, e.g., display a placeholder
                    tbSupervisorID.PlaceholderText = "No supervisor";
                }

                tbStudentID.Text = studNum.ToString();
                tbLastName.Text = lastName;
                tbFirstName.Text = firstName;
                tbContactNo.Text = contactNum;
            }

            else
            {
                MessageBox.Show("Invalid.");
            }

            dbConn.Close();
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            loadItems();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            dbConn.Open();

            string dbQuery = "UPDATE students SET student_number = @student_id, last_name = @last_name, first_name = @first_name, contact_number = @contact_num, supervisor_id = @supervisor_id WHERE user_id = @user_id"; // actual SQL
            MySqlCommand dbCmd = new MySqlCommand(dbQuery, dbConn); // commands from c# to MySQL

            dbCmd.Parameters.AddWithValue("@student_id", tbStudentID.Text);
            dbCmd.Parameters.AddWithValue("@last_name", tbLastName.Text);
            dbCmd.Parameters.AddWithValue("@first_name", tbFirstName.Text);
            dbCmd.Parameters.AddWithValue("@contact_num", tbContactNo.Text);
            dbCmd.Parameters.AddWithValue("@supervisor_id", tbSupervisorID.Text);
            dbCmd.Parameters.AddWithValue("@user_id", tbUserID.Text);
           
            int queryUpdate = dbCmd.ExecuteNonQuery(); // to insert the data to database

            if (queryUpdate > 0) {

                MessageBox.Show("Student Updated Successfully.");
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
