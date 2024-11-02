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

    public partial class Home_Admin_ : Form
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

        public Home_Admin_()
        {
            InitializeComponent();
            loadHome();
        }

        public void loadHome()
        {
            dbConn.Open();

            String dbQuery = "SELECT first_name FROM admin WHERE user_id = " + OJTSession.userID;

            MySqlCommand dbCmd = new MySqlCommand(dbQuery, dbConn);

            MySqlDataReader dataReader = dbCmd.ExecuteReader();

            if (dataReader.Read())
            {
                String firstName = dataReader.GetString("first_name");

                welcomeLabel.Text = "Welcome " + firstName + "!";
                dbConn.Close();
            }
        }
    }
}
