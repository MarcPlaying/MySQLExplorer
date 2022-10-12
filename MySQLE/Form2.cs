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

namespace MySQLE
{
    public partial class Form2 : Form
    {
        public MySqlConnection sqlConn;
        public MySqlDataAdapter sqlDA;
        public Form1 formOne;

        public Form2(MySqlConnection sqlConn, string databaseName, Form1 form)
        {
            this.formOne = form;
            this.sqlConn = sqlConn;
            InitializeComponent();
            this.Text = "MySQLExplorer: Connected on " + databaseName;
            databaseView.ImageList = imageList1;
            
            TreeNode node = new TreeNode();
            node.Text = databaseName;
            node.Name = "node" + databaseName;
            node.ImageIndex = 0;
            databaseView.Nodes.Add(node);
            foreach (string table in GetTableNames(sqlConn))
            {
                TreeNode tableNode = new TreeNode();
                tableNode.Name = "node" + table;
                tableNode.Text = table;
                tableNode.ImageIndex = 1;
                tableNode.SelectedImageIndex = 1;
                node.Nodes.Add(tableNode);
            }

        }

        public static List<string> GetTableNames(MySqlConnection connection)
        {
#pragma warning disable CS8619 // Die NULL-Zulässigkeit von Verweistypen im Wert entspricht nicht dem Zieltyp.
            return connection.GetSchema("Tables").AsEnumerable().Select(s => s[2].ToString()).ToList();
#pragma warning restore CS8619 // Die NULL-Zulässigkeit von Verweistypen im Wert entspricht nicht dem Zieltyp.
        }

        private void databaseView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                sqlDA = new MySqlDataAdapter("select * from " + e.Node.Text, sqlConn);
                DataSet DS = new DataSet();
                sqlDA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
            catch(Exception)
            {

            }
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)dataGridView1.DataSource).GetChanges();

            if (changes != null)
            {
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(sqlDA);
                sqlDA.UpdateCommand = mcb.GetUpdateCommand();
                sqlDA.Update(changes);
                ((DataTable)dataGridView1.DataSource).AcceptChanges();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            formOne.Show();
            this.Hide();
        }
    }

}
