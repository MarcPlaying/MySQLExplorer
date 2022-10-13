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
        public MySqlDataAdapter sqlDA = new MySqlDataAdapter();
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
            TreeNode newNode = new TreeNode();
            newNode.Name = "nodeNewTable";
            newNode.Text = "New";
            newNode.ImageIndex = 2;
            newNode.SelectedImageIndex = 2;
            node.Nodes.Add(newNode);
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
            if(e.Node.Text == "New")
            {
                newTablePanel.Visible = true;
                return;
            }else if(newTablePanel.Visible == true && e.Node.Text != "New") {
                newTablePanel.Visible = false;
            }
            try
            {
                sqlDA = new MySqlDataAdapter("select * from " + e.Node.Text, sqlConn);
                DataSet DS = new DataSet();
                sqlDA.Fill(DS);
                dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 8, FontStyle.Regular);
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
            sqlConn.Close();
            sqlDA.Dispose();
            formOne.Show();
            this.Hide();
        }

        private void d(object sender, EventArgs e)
        {

        }

        private void dsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if(e.Graphics != null) { 
                Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
                dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
                e.Graphics.DrawImage(bm, 0, 0);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float fontSize = dataGridView1.DefaultCellStyle.Font.Size;
            dataGridView1.DefaultCellStyle.Font = new Font("Calibri", fontSize + 1, FontStyle.Regular);
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = row.Height + 3;
            }
            foreach(DataGridViewColumn coll in dataGridView1.Columns)
            {
                coll.Width = coll.Width + 3;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float fontSize = dataGridView1.DefaultCellStyle.Font.Size;
            if (fontSize == 1) return;
            dataGridView1.DefaultCellStyle.Font = new Font("Calibri", fontSize - 1, FontStyle.Regular);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = row.Height - 3;
            }
            foreach (DataGridViewColumn coll in dataGridView1.Columns)
            {
                coll.Width = coll.Width - 3;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlSaveDialog.Filter = "SQL File|*.sql|All Files|*.*";
            sqlSaveDialog.Title = "Backup your Database";
            sqlSaveDialog.ShowDialog();
            if (sqlSaveDialog.FileName != "")
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = sqlConn;
                        mb.ExportToFile(sqlSaveDialog.FileName);
                    }
                }
            }
               
            
        }
    }

}
