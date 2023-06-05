namespace ChatClient
{
    partial class ChatClientServer
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
            this.Header = new System.Windows.Forms.Panel();
            this.BtnServer = new System.Windows.Forms.CheckBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.EdPort = new System.Windows.Forms.TextBox();
            this.EdHost = new System.Windows.Forms.TextBox();
            this.Footer = new System.Windows.Forms.Panel();
            this.BtnSend = new System.Windows.Forms.Button();
            this.EdMessage = new System.Windows.Forms.TextBox();
            this.EdLog = new System.Windows.Forms.TextBox();
            this.Header.SuspendLayout();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Controls.Add(this.BtnServer);
            this.Header.Controls.Add(this.BtnConnect);
            this.Header.Controls.Add(this.EdPort);
            this.Header.Controls.Add(this.EdHost);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(567, 43);
            this.Header.TabIndex = 7;
            // 
            // BtnServer
            // 
            this.BtnServer.AutoSize = true;
            this.BtnServer.Location = new System.Drawing.Point(12, 13);
            this.BtnServer.Name = "BtnServer";
            this.BtnServer.Size = new System.Drawing.Size(83, 17);
            this.BtnServer.TabIndex = 10;
            this.BtnServer.Text = "Jako serwer";
            this.BtnServer.UseVisualStyleBackColor = true;
            this.BtnServer.CheckedChanged += new System.EventHandler(this.BtnServer_CheckedChanged);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConnect.Location = new System.Drawing.Point(480, 10);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 23);
            this.BtnConnect.TabIndex = 9;
            this.BtnConnect.Text = "Połącz";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // EdPort
            // 
            this.EdPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EdPort.Location = new System.Drawing.Point(382, 11);
            this.EdPort.Name = "EdPort";
            this.EdPort.Size = new System.Drawing.Size(81, 20);
            this.EdPort.TabIndex = 8;
            this.EdPort.Text = "5555";
            this.EdPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EdHost
            // 
            this.EdHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdHost.Location = new System.Drawing.Point(101, 11);
            this.EdHost.Name = "EdHost";
            this.EdHost.Size = new System.Drawing.Size(269, 20);
            this.EdHost.TabIndex = 7;
            this.EdHost.Text = "localhost";
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.BtnSend);
            this.Footer.Controls.Add(this.EdMessage);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 288);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(567, 51);
            this.Footer.TabIndex = 8;
            // 
            // BtnSend
            // 
            this.BtnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSend.Enabled = false;
            this.BtnSend.Location = new System.Drawing.Point(479, 15);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 7;
            this.BtnSend.Text = "Wyślij";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // EdMessage
            // 
            this.EdMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdMessage.Enabled = false;
            this.EdMessage.Location = new System.Drawing.Point(12, 16);
            this.EdMessage.Name = "EdMessage";
            this.EdMessage.Size = new System.Drawing.Size(451, 20);
            this.EdMessage.TabIndex = 6;
            // 
            // EdLog
            // 
            this.EdLog.BackColor = System.Drawing.SystemColors.ControlDark;
            this.EdLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EdLog.Location = new System.Drawing.Point(0, 43);
            this.EdLog.Multiline = true;
            this.EdLog.Name = "EdLog";
            this.EdLog.ReadOnly = true;
            this.EdLog.Size = new System.Drawing.Size(567, 245);
            this.EdLog.TabIndex = 9;
            // 
            // ChatClientServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 339);
            this.Controls.Add(this.EdLog);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.Header);
            this.Name = "ChatClientServer";
            this.Text = "Chat klient ...";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatClientServer_FormClosed);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.CheckBox BtnServer;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.TextBox EdPort;
        private System.Windows.Forms.TextBox EdHost;
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.TextBox EdMessage;
        private System.Windows.Forms.TextBox EdLog;
    }
}

