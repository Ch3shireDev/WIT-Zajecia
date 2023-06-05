namespace Chat
{
    partial class Chat
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
            this.EdHost = new System.Windows.Forms.TextBox();
            this.EdPort = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.Footer = new System.Windows.Forms.Panel();
            this.Log = new System.Windows.Forms.TextBox();
            this.EdSendText = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Controls.Add(this.BtnConnect);
            this.Header.Controls.Add(this.EdPort);
            this.Header.Controls.Add(this.EdHost);
            this.Header.Controls.Add(this.BtnServer);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(505, 42);
            this.Header.TabIndex = 0;
            // 
            // BtnServer
            // 
            this.BtnServer.AutoSize = true;
            this.BtnServer.Location = new System.Drawing.Point(12, 12);
            this.BtnServer.Name = "BtnServer";
            this.BtnServer.Size = new System.Drawing.Size(59, 17);
            this.BtnServer.TabIndex = 0;
            this.BtnServer.Text = "Serwer";
            this.BtnServer.UseVisualStyleBackColor = true;
            // 
            // EdHost
            // 
            this.EdHost.Location = new System.Drawing.Point(77, 10);
            this.EdHost.Name = "EdHost";
            this.EdHost.Size = new System.Drawing.Size(130, 20);
            this.EdHost.TabIndex = 1;
            this.EdHost.Text = "localhost";
            // 
            // EdPort
            // 
            this.EdPort.Location = new System.Drawing.Point(213, 10);
            this.EdPort.Name = "EdPort";
            this.EdPort.Size = new System.Drawing.Size(46, 20);
            this.EdPort.TabIndex = 2;
            this.EdPort.Text = "8888";
            this.EdPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConnect.Location = new System.Drawing.Point(418, 8);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 23);
            this.BtnConnect.TabIndex = 3;
            this.BtnConnect.Text = "Połącz";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.BtnSend);
            this.Footer.Controls.Add(this.EdSendText);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 216);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(505, 46);
            this.Footer.TabIndex = 2;
            // 
            // Log
            // 
            this.Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Log.Location = new System.Drawing.Point(0, 42);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Log.Size = new System.Drawing.Size(505, 174);
            this.Log.TabIndex = 3;
            // 
            // EdSendText
            // 
            this.EdSendText.Enabled = false;
            this.EdSendText.Location = new System.Drawing.Point(12, 13);
            this.EdSendText.Name = "EdSendText";
            this.EdSendText.Size = new System.Drawing.Size(400, 20);
            this.EdSendText.TabIndex = 0;
            // 
            // BtnSend
            // 
            this.BtnSend.Enabled = false;
            this.BtnSend.Location = new System.Drawing.Point(418, 11);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 1;
            this.BtnSend.Text = "Wyślij";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // Chat
            // 
            this.AcceptButton = this.BtnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 262);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.Header);
            this.Name = "Chat";
            this.Text = "Simple chat ...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chat_FormClosing);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.TextBox EdPort;
        private System.Windows.Forms.TextBox EdHost;
        private System.Windows.Forms.CheckBox BtnServer;
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.TextBox EdSendText;
    }
}

