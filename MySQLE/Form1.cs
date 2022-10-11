using MySql.Data.MySqlClient;

namespace MySQLE
{
    public partial class Form1 : Form
    {

        public MySqlConnection sqlCon = null;
        public string errorMessage = "";

        public Form1()
        {
            InitializeComponent();
            
        }

        public bool connect(string server,string database, string username,string password)
        {
            try
            {
                string conString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";
                sqlCon = new MySqlConnection(conString);
                sqlCon.Open();
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connect(server.Text, database.Text, username.Text, password.Text) == true)
            {
                Form2 databaseView = new Form2(sqlCon, database.Text);
                databaseView.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Connection failed MySQLConnector: " + errorMessage);
            }
           
        }
    }
}