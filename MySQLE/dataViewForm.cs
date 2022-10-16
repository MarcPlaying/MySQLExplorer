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
    public partial class dataViewForm : Form
    {
        public MySqlConnection sqlConn;
        public MySqlDataAdapter sqlDA = new MySqlDataAdapter();
        public Form1 formOne;

        public dataViewForm(MySqlConnection sqlConn, string databaseName, Form1 form)
        {
            this.formOne = form;
            this.sqlConn = sqlConn;
            InitializeComponent();
            this.Text = "MySQLExplorer: Connected on " + databaseName;
            databaseView.ImageList = tableIconList;
            
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
                tableView.DefaultCellStyle.Font = new Font("Calibri", 8, FontStyle.Regular);
                tableView.DataSource = DS.Tables[0];
            }
            catch(Exception)
            {

            }
        }

        private void tableView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)tableView.DataSource).GetChanges();

            if (changes != null)
            {
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(sqlDA);
                sqlDA.UpdateCommand = mcb.GetUpdateCommand();
                sqlDA.Update(changes);
                ((DataTable)tableView.DataSource).AcceptChanges();
            }
        }

        private void dataViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConn.Close();
            sqlDA.Dispose();
            formOne.Show();
            this.Hide();
        }

        private void printMenu_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if(e.Graphics != null) { 
                Bitmap bm = new Bitmap(this.tableView.Width, this.tableView.Height);
                tableView.DrawToBitmap(bm, new Rectangle(0, 0, this.tableView.Width, this.tableView.Height));
                e.Graphics.DrawImage(bm, 0, 0);
                
            }
        }

        private void sqlExportMenu_Click(object sender, EventArgs e)
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

        private void zoomInMenu_Click(object sender, EventArgs e)
        {
            zoomTable(3);
        }

        private void zoomOutMenu_Click(object sender, EventArgs e)
        {
            zoomTable(-3);
        }

        public void zoomTable(int zoom)
        {
            float fontSize = tableView.DefaultCellStyle.Font.Size;
            if (fontSize == 1 && zoom < 0) return;
            tableView.DefaultCellStyle.Font = new Font("Calibri", fontSize + (zoom/3), FontStyle.Regular);
            foreach (DataGridViewRow row in tableView.Rows)
            {
                row.Height = row.Height +zoom;
            }
            foreach (DataGridViewColumn coll in tableView.Columns)
            {
                coll.Width = coll.Width +zoom;
            }
        }

    }

}
