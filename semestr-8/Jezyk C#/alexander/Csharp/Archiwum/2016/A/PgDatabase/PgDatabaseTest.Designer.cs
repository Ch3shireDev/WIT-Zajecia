namespace PgDatabase
{
    partial class PgDatabaseTest
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
            this.lbHost = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lbDatabase = new System.Windows.Forms.Label();
            this.Viewer = new System.Windows.Forms.DataGridView();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Viewer)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHost
            // 
            this.lbHost.AutoSize = true;
            this.lbHost.Location = new System.Drawing.Point(9, 9);
            this.lbHost.Name = "lbHost";
            this.lbHost.Size = new System.Drawing.Size(38, 13);
            this.lbHost.TabIndex = 0;
            this.lbHost.Text = "Server";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(12, 25);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(69, 20);
            this.txtHost.TabIndex = 1;
            this.txtHost.Text = "direct.wsisiz.edu.pl";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(87, 25);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(69, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "5432";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(84, 9);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(26, 13);
            this.lbPort.TabIndex = 2;
            this.lbPort.Text = "Port";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(162, 25);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(69, 20);
            this.txtUser.TabIndex = 5;
            this.txtUser.Text = "alex";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(159, 9);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(62, 13);
            this.lbUser.TabIndex = 4;
            this.lbUser.Text = "Użytkownik";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(237, 25);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(69, 20);
            this.txtPass.TabIndex = 7;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(234, 9);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(36, 13);
            this.lbPass.TabIndex = 6;
            this.lbPass.Text = "Hasło";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(312, 25);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(69, 20);
            this.txtDatabase.TabIndex = 9;
            this.txtDatabase.Text = "alex";
            // 
            // lbDatabase
            // 
            this.lbDatabase.AutoSize = true;
            this.lbDatabase.Location = new System.Drawing.Point(309, 9);
            this.lbDatabase.Name = "lbDatabase";
            this.lbDatabase.Size = new System.Drawing.Size(31, 13);
            this.lbDatabase.TabIndex = 8;
            this.lbDatabase.Text = "Baza";
            // 
            // Viewer
            // 
            this.Viewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Viewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Viewer.Location = new System.Drawing.Point(12, 51);
            this.Viewer.MultiSelect = false;
            this.Viewer.Name = "Viewer";
            this.Viewer.ReadOnly = true;
            this.Viewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Viewer.Size = new System.Drawing.Size(521, 227);
            this.Viewer.TabIndex = 10;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(458, 22);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Połącz";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(12, 284);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // PgDatabaseTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 317);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.Viewer);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.lbDatabase);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.lbHost);
            this.Name = "PgDatabaseTest";
            this.Text = "Postgres database test ...";
            ((System.ComponentModel.ISupportInitialize)(this.Viewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHost;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lbDatabase;
        private System.Windows.Forms.DataGridView Viewer;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnAdd;
    }
}

