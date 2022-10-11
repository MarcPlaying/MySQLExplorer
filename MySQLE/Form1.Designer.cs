namespace MySQLE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.server = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.database = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MySQLE.Properties.Resources.Logo_White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 267);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Visible = false;
            // 
            // server
            // 
            this.server.AutoCompleteCustomSource.AddRange(new string[] {
            "localhost"});
            this.server.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.server.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.server.Location = new System.Drawing.Point(12, 296);
            this.server.Name = "server";
            this.server.PlaceholderText = "Server";
            this.server.Size = new System.Drawing.Size(291, 23);
            this.server.TabIndex = 2;
            // 
            // username
            // 
            this.username.AutoCompleteCustomSource.AddRange(new string[] {
            "root"});
            this.username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.username.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.username.Location = new System.Drawing.Point(12, 325);
            this.username.Name = "username";
            this.username.PlaceholderText = "Username";
            this.username.Size = new System.Drawing.Size(291, 23);
            this.username.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(12, 354);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.PlaceholderText = "Password";
            this.password.Size = new System.Drawing.Size(291, 23);
            this.password.TabIndex = 4;
            // 
            // database
            // 
            this.database.Location = new System.Drawing.Point(12, 383);
            this.database.Name = "database";
            this.database.PlaceholderText = "Database";
            this.database.Size = new System.Drawing.Size(291, 23);
            this.database.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.database);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.server);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MySQLExplorer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private TextBox server;
        private TextBox username;
        private TextBox password;
        private TextBox database;
        private Button button1;
    }
}