namespace Test010
{
    partial class Form1
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
            this.Password = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.DataGridView();
            this.FldName = new System.Windows.Forms.TextBox();
            this.FldSurname = new System.Windows.Forms.TextBox();
            this.FldPhones = new System.Windows.Forms.TextBox();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.View)).BeginInit();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(12, 12);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '#';
            this.Password.Size = new System.Drawing.Size(129, 20);
            this.Password.TabIndex = 0;
            this.Password.UseSystemPasswordChar = true;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(147, 9);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 23);
            this.BtnConnect.TabIndex = 1;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // View
            // 
            this.View.AllowUserToAddRows = false;
            this.View.AllowUserToDeleteRows = false;
            this.View.AllowUserToResizeRows = false;
            this.View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View.Location = new System.Drawing.Point(12, 38);
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Size = new System.Drawing.Size(594, 245);
            this.View.TabIndex = 2;
            // 
            // FldName
            // 
            this.FldName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FldName.Location = new System.Drawing.Point(12, 289);
            this.FldName.Name = "FldName";
            this.FldName.Size = new System.Drawing.Size(100, 20);
            this.FldName.TabIndex = 3;
            // 
            // FldSurname
            // 
            this.FldSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FldSurname.Location = new System.Drawing.Point(118, 289);
            this.FldSurname.Name = "FldSurname";
            this.FldSurname.Size = new System.Drawing.Size(100, 20);
            this.FldSurname.TabIndex = 4;
            // 
            // FldPhones
            // 
            this.FldPhones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FldPhones.Location = new System.Drawing.Point(228, 289);
            this.FldPhones.Name = "FldPhones";
            this.FldPhones.Size = new System.Drawing.Size(297, 20);
            this.FldPhones.TabIndex = 5;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInsert.Location = new System.Drawing.Point(531, 289);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 23);
            this.BtnInsert.TabIndex = 6;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(12, 316);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "button1";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 351);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.FldPhones);
            this.Controls.Add(this.FldSurname);
            this.Controls.Add(this.FldName);
            this.Controls.Add(this.View);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.Password);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.DataGridView View;
        private System.Windows.Forms.TextBox FldName;
        private System.Windows.Forms.TextBox FldSurname;
        private System.Windows.Forms.TextBox FldPhones;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnDelete;
    }
}

