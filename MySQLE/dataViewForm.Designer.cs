namespace MySQLE
{
    partial class dataViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dataViewForm));
            this.databaseView = new System.Windows.Forms.TreeView();
            this.tableIconList = new System.Windows.Forms.ImageList(this.components);
            this.tableView = new System.Windows.Forms.DataGridView();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.dataTabControl = new System.Windows.Forms.TabControl();
            this.dataViewTabPage = new System.Windows.Forms.TabPage();
            this.newTablePanel = new System.Windows.Forms.Panel();
            this.newTableRichBox = new System.Windows.Forms.RichTextBox();
            this.executeQueryButton = new System.Windows.Forms.Button();
            this.clearColumnButton = new System.Windows.Forms.Button();
            this.addColumnButton = new System.Windows.Forms.Button();
            this.autoIncCheckBox = new System.Windows.Forms.CheckBox();
            this.newKeyChoseBox = new System.Windows.Forms.ComboBox();
            this.newStandardTextBox = new System.Windows.Forms.TextBox();
            this.newLengthTextBox = new System.Windows.Forms.TextBox();
            this.newTypeChoseBox = new System.Windows.Forms.ComboBox();
            this.newNameTextBox = new System.Windows.Forms.TextBox();
            this.executeViewTabControll = new System.Windows.Forms.TabPage();
            this.buttonIcons = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.printMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.sqlSaveDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.dataTabControl.SuspendLayout();
            this.dataViewTabPage.SuspendLayout();
            this.newTablePanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // databaseView
            // 
            this.databaseView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.databaseView.Cursor = System.Windows.Forms.Cursors.Default;
            this.databaseView.ImageIndex = 0;
            this.databaseView.ImageList = this.tableIconList;
            this.databaseView.Location = new System.Drawing.Point(8, 108);
            this.databaseView.Name = "databaseView";
            this.databaseView.SelectedImageIndex = 0;
            this.databaseView.Size = new System.Drawing.Size(212, 488);
            this.databaseView.TabIndex = 0;
            this.databaseView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.databaseView_AfterSelect);
            // 
            // tableIconList
            // 
            this.tableIconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.tableIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tableIconList.ImageStream")));
            this.tableIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.tableIconList.Images.SetKeyName(0, "data.png");
            this.tableIconList.Images.SetKeyName(1, "table2.png");
            this.tableIconList.Images.SetKeyName(2, "table2_add.png");
            // 
            // tableView
            // 
            this.tableView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableView.Location = new System.Drawing.Point(3, 3);
            this.tableView.Name = "tableView";
            this.tableView.RowTemplate.Height = 25;
            this.tableView.Size = new System.Drawing.Size(846, 543);
            this.tableView.TabIndex = 1;
            this.tableView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableView_RowValidated);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::MySQLE.Properties.Resources.Unbenannt;
            this.logoPictureBox.Location = new System.Drawing.Point(8, 23);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(212, 79);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 2;
            this.logoPictureBox.TabStop = false;
            // 
            // dataTabControl
            // 
            this.dataTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTabControl.Controls.Add(this.dataViewTabPage);
            this.dataTabControl.Controls.Add(this.executeViewTabControll);
            this.dataTabControl.Location = new System.Drawing.Point(226, 27);
            this.dataTabControl.Name = "dataTabControl";
            this.dataTabControl.SelectedIndex = 0;
            this.dataTabControl.Size = new System.Drawing.Size(860, 577);
            this.dataTabControl.TabIndex = 3;
            // 
            // dataViewTabPage
            // 
            this.dataViewTabPage.Controls.Add(this.newTablePanel);
            this.dataViewTabPage.Controls.Add(this.tableView);
            this.dataViewTabPage.Location = new System.Drawing.Point(4, 24);
            this.dataViewTabPage.Name = "dataViewTabPage";
            this.dataViewTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataViewTabPage.Size = new System.Drawing.Size(852, 549);
            this.dataViewTabPage.TabIndex = 0;
            this.dataViewTabPage.Text = "DataView&Edit";
            this.dataViewTabPage.UseVisualStyleBackColor = true;
            // 
            // newTablePanel
            // 
            this.newTablePanel.Controls.Add(this.newTableRichBox);
            this.newTablePanel.Controls.Add(this.executeQueryButton);
            this.newTablePanel.Controls.Add(this.clearColumnButton);
            this.newTablePanel.Controls.Add(this.addColumnButton);
            this.newTablePanel.Controls.Add(this.autoIncCheckBox);
            this.newTablePanel.Controls.Add(this.newKeyChoseBox);
            this.newTablePanel.Controls.Add(this.newStandardTextBox);
            this.newTablePanel.Controls.Add(this.newLengthTextBox);
            this.newTablePanel.Controls.Add(this.newTypeChoseBox);
            this.newTablePanel.Controls.Add(this.newNameTextBox);
            this.newTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newTablePanel.Location = new System.Drawing.Point(3, 3);
            this.newTablePanel.Name = "newTablePanel";
            this.newTablePanel.Size = new System.Drawing.Size(846, 543);
            this.newTablePanel.TabIndex = 4;
            this.newTablePanel.Visible = false;
            // 
            // newTableRichBox
            // 
            this.newTableRichBox.Location = new System.Drawing.Point(160, 81);
            this.newTableRichBox.Name = "newTableRichBox";
            this.newTableRichBox.Size = new System.Drawing.Size(524, 254);
            this.newTableRichBox.TabIndex = 9;
            this.newTableRichBox.Text = "";
            // 
            // executeQueryButton
            // 
            this.executeQueryButton.Location = new System.Drawing.Point(559, 341);
            this.executeQueryButton.Name = "executeQueryButton";
            this.executeQueryButton.Size = new System.Drawing.Size(125, 23);
            this.executeQueryButton.TabIndex = 8;
            this.executeQueryButton.Text = "Execute Query";
            this.executeQueryButton.UseVisualStyleBackColor = true;
            // 
            // clearColumnButton
            // 
            this.clearColumnButton.Location = new System.Drawing.Point(451, 48);
            this.clearColumnButton.Name = "clearColumnButton";
            this.clearColumnButton.Size = new System.Drawing.Size(125, 23);
            this.clearColumnButton.TabIndex = 7;
            this.clearColumnButton.Text = "Clear All Collumns";
            this.clearColumnButton.UseVisualStyleBackColor = true;
            // 
            // addColumnButton
            // 
            this.addColumnButton.Location = new System.Drawing.Point(582, 48);
            this.addColumnButton.Name = "addColumnButton";
            this.addColumnButton.Size = new System.Drawing.Size(102, 23);
            this.addColumnButton.TabIndex = 6;
            this.addColumnButton.Text = "Add Column";
            this.addColumnButton.UseVisualStyleBackColor = true;
            // 
            // autoIncCheckBox
            // 
            this.autoIncCheckBox.AutoSize = true;
            this.autoIncCheckBox.Location = new System.Drawing.Point(647, 21);
            this.autoIncCheckBox.Name = "autoIncCheckBox";
            this.autoIncCheckBox.Size = new System.Drawing.Size(37, 19);
            this.autoIncCheckBox.TabIndex = 5;
            this.autoIncCheckBox.Text = "AI";
            this.autoIncCheckBox.UseVisualStyleBackColor = true;
            // 
            // newKeyChoseBox
            // 
            this.newKeyChoseBox.FormattingEnabled = true;
            this.newKeyChoseBox.Items.AddRange(new object[] {
            "PRIMARY",
            "UNIQUE",
            "INDEX",
            "FULLTEXT",
            "SPATIAL"});
            this.newKeyChoseBox.Location = new System.Drawing.Point(544, 19);
            this.newKeyChoseBox.Name = "newKeyChoseBox";
            this.newKeyChoseBox.Size = new System.Drawing.Size(97, 23);
            this.newKeyChoseBox.TabIndex = 4;
            // 
            // newStandardTextBox
            // 
            this.newStandardTextBox.Location = new System.Drawing.Point(465, 19);
            this.newStandardTextBox.Name = "newStandardTextBox";
            this.newStandardTextBox.PlaceholderText = "Standart";
            this.newStandardTextBox.Size = new System.Drawing.Size(73, 23);
            this.newStandardTextBox.TabIndex = 3;
            // 
            // newLengthTextBox
            // 
            this.newLengthTextBox.Location = new System.Drawing.Point(393, 19);
            this.newLengthTextBox.Name = "newLengthTextBox";
            this.newLengthTextBox.PlaceholderText = "Length";
            this.newLengthTextBox.Size = new System.Drawing.Size(66, 23);
            this.newLengthTextBox.TabIndex = 2;
            // 
            // newTypeChoseBox
            // 
            this.newTypeChoseBox.FormattingEnabled = true;
            this.newTypeChoseBox.Items.AddRange(new object[] {
            "INT",
            "VARCHAR",
            "TEXT",
            "BOOLEAN",
            "FLOAT",
            "BIGINT",
            "CHAR"});
            this.newTypeChoseBox.Location = new System.Drawing.Point(266, 19);
            this.newTypeChoseBox.Name = "newTypeChoseBox";
            this.newTypeChoseBox.Size = new System.Drawing.Size(121, 23);
            this.newTypeChoseBox.TabIndex = 1;
            // 
            // newNameTextBox
            // 
            this.newNameTextBox.Location = new System.Drawing.Point(160, 19);
            this.newNameTextBox.Name = "newNameTextBox";
            this.newNameTextBox.PlaceholderText = "Name";
            this.newNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.newNameTextBox.TabIndex = 0;
            // 
            // executeViewTabControll
            // 
            this.executeViewTabControll.Location = new System.Drawing.Point(4, 24);
            this.executeViewTabControll.Name = "executeViewTabControll";
            this.executeViewTabControll.Padding = new System.Windows.Forms.Padding(3);
            this.executeViewTabControll.Size = new System.Drawing.Size(852, 549);
            this.executeViewTabControll.TabIndex = 1;
            this.executeViewTabControll.Text = "Execute";
            this.executeViewTabControll.UseVisualStyleBackColor = true;
            // 
            // buttonIcons
            // 
            this.buttonIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.buttonIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonIcons.ImageStream")));
            this.buttonIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonIcons.Images.SetKeyName(0, "Zoom-In-icon.png");
            this.buttonIcons.Images.SetKeyName(1, "Zoom-Out-icon.png");
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStrip,
            this.exportToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1086, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStrip
            // 
            this.fileToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printMenu,
            this.zoomInMenu,
            this.zoomOutMenu});
            this.fileToolStrip.Name = "fileToolStrip";
            this.fileToolStrip.Size = new System.Drawing.Size(37, 20);
            this.fileToolStrip.Text = "File";
            // 
            // printMenu
            // 
            this.printMenu.Image = global::MySQLE.Properties.Resources.print_calculator;
            this.printMenu.Name = "printMenu";
            this.printMenu.Size = new System.Drawing.Size(180, 22);
            this.printMenu.Text = "Print";
            this.printMenu.Click += new System.EventHandler(this.printMenu_Click);
            // 
            // zoomInMenu
            // 
            this.zoomInMenu.Image = global::MySQLE.Properties.Resources.Zoom_In_icon;
            this.zoomInMenu.Name = "zoomInMenu";
            this.zoomInMenu.Size = new System.Drawing.Size(180, 22);
            this.zoomInMenu.Text = "Zoom In";
            this.zoomInMenu.Click += new System.EventHandler(this.zoomInMenu_Click);
            // 
            // zoomOutMenu
            // 
            this.zoomOutMenu.Image = global::MySQLE.Properties.Resources.Zoom_Out_icon;
            this.zoomOutMenu.Name = "zoomOutMenu";
            this.zoomOutMenu.Size = new System.Drawing.Size(180, 22);
            this.zoomOutMenu.Text = "Zoom Out";
            this.zoomOutMenu.Click += new System.EventHandler(this.zoomOutMenu_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sqlToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // sqlToolStripMenuItem
            // 
            this.sqlToolStripMenuItem.Image = global::MySQLE.Properties.Resources.data_floppy_disk;
            this.sqlToolStripMenuItem.Name = "sqlToolStripMenuItem";
            this.sqlToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.sqlToolStripMenuItem.Text = ".sql";
            this.sqlToolStripMenuItem.Click += new System.EventHandler(this.sqlExportMenu_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // dataViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 606);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.databaseView);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.dataTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "dataViewForm";
            this.Text = "dataViewForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dataViewForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.dataTabControl.ResumeLayout(false);
            this.dataViewTabPage.ResumeLayout(false);
            this.newTablePanel.ResumeLayout(false);
            this.newTablePanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView databaseView;
        private ImageList tableIconList;
        private DataGridView tableView;
        private PictureBox logoPictureBox;
        private TabControl dataTabControl;
        private TabPage dataViewTabPage;
        private TabPage executeViewTabControll;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStrip;
        private ToolStripMenuItem printMenu;
        private System.Drawing.Printing.PrintDocument printDocument;
        private ImageList buttonIcons;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem sqlToolStripMenuItem;
        private SaveFileDialog sqlSaveDialog;
        private Panel newTablePanel;
        private TextBox newNameTextBox;
        private ComboBox newTypeChoseBox;
        private RichTextBox newTableRichBox;
        private Button executeQueryButton;
        private Button clearColumnButton;
        private Button addColumnButton;
        private CheckBox autoIncCheckBox;
        private ComboBox newKeyChoseBox;
        private TextBox newStandardTextBox;
        private TextBox newLengthTextBox;
        private ToolStripMenuItem zoomInMenu;
        private ToolStripMenuItem zoomOutMenu;
    }
}