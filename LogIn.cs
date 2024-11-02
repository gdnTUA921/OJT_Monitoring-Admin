namespace OJT_Monitoring
{
    using MySql.Data.MySqlClient; // Do not forget this part
    using Org.BouncyCastle.Crypto.Engines;
    using System.Data;
    using System.Data.Common;

    public partial class LogIn : Form
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

        public LogIn()
        {
            InitializeComponent();
        }

        private void clearItems()
        {
            logInEmail.Clear();
            logInpassword.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (logInpassword.PasswordChar == '•')
            {
                logInpassword.PasswordChar = '\0';
                pictureBox2.BringToFront();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (logInpassword.PasswordChar == '\0')
            {
                logInpassword.PasswordChar = '•';
                pictureBox3.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dbConn.Open();

                string dbQuery = "SELECT * FROM users WHERE user_email = @user_email AND password = @password"; // actual SQL
                MySqlCommand dbCmd = new MySqlCommand(dbQuery, dbConn); // commands from c# to MySQL

                dbCmd.Parameters.AddWithValue("@user_email", logInEmail.Text);
                dbCmd.Parameters.AddWithValue("@password", logInpassword.Text);
                MySqlDataReader dbReader = dbCmd.ExecuteReader(); // to fetch the data from database

                if (dbReader.Read())
                {
                    int userID = dbReader.GetInt32("user_id");
                    String userEmail = dbReader.GetString("user_email");
                    String password = dbReader.GetString("password");
                    String accountType = dbReader.GetString("account_type");

                    if (accountType == "admin")
                    {
                        MessageBox.Show("Login Successfully");
                        this.Hide();
                        OJTSession.userEmail = userEmail;
                        OJTSession.userID = userID;
                        OJTSession.accType = accountType;

                        MainAdmin form2 = new MainAdmin();
                        form2.ShowDialog();

                        this.Close();
                    }

                    if (accountType == "supervisor")
                    {

                        //Dito nalang iconnect yung kay Paul


                       /* MessageBox.Show("Login Succcessfully");
                        this.Hide();
                        string LoggedUsername = logInEmail.Text;

                       AccountSettings_Admin form3 = new AccountSettings_Admin();
                        form3.Show();*/
                    }
                }

                else
                {
                    MessageBox.Show("Invalid.");
                    clearItems();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

            dbConn.Close();
        }
    }
}