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
            if(!Directory.Exists("MySQLE_Files"))
            {
                Directory.CreateDirectory("MySQLE_Files");
            }
            foreach(FileInfo f in new DirectoryInfo("MySQLE_Files").GetFiles())
            {
                if(f.Name.EndsWith(".sess"))
                {
                    string file = File.ReadAllText(f.FullName);
                    string[] file2 = file.Split(";");
                    comboBox1.Items.Add(file2[1] + "@" + file2[0]);
                }
            }
            
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
                Form2 databaseView = new Form2(sqlCon, database.Text,this);
                databaseView.Show();
                this.Hide();
                DialogResult dialogResult = MessageBox.Show("Do you want to save this session? NOTE: Saving is not secure", "Save session?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string pw = "EADASDJLH";
                    string newpw = StringCipher.Encrypt(password.Text);
                    string conString = server.Text + ";" + database.Text + ";" + username.Text + ";" + newpw;
                    File.WriteAllText("MySQLE_Files\\"+server.Text+".sess", conString);
                }
            }
            else
            {
                MessageBox.Show("Connection failed MySQLConnector: " + errorMessage);
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? connectS = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            if (connectS != null)
            {
                
                string[] connectSplit = connectS.Split('@');
                string session = connectSplit[1] + ".sess";
                string[] sessionString = File.ReadAllText("MySQLE_Files\\" + session).Split(";");
                if (connect(sessionString[0], sessionString[1], sessionString[2], StringCipher.Decrypt(sessionString[3])) == true)
                {
                    Form2 databaseView = new Form2(sqlCon, sessionString[1],this);
                    databaseView.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Connection failed MySQLConnector: " + errorMessage);
                }
            }
             
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}