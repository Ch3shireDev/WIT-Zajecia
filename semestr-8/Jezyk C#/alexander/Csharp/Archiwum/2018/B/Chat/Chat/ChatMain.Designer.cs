namespace Chat
{
    partial class ChatMain
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
            this.Header = new System.Windows.Forms.Panel();
            this.EdName = new System.Windows.Forms.TextBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.EdPort = new System.Windows.Forms.TextBox();
            this.EdHost = new System.Windows.Forms.TextBox();
            this.BtnServer = new System.Windows.Forms.CheckBox();
            this.Footer = new System.Windows.Forms.Panel();
            this.BtnSend = new System.Windows.Forms.Button();
            this.EdSendText = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Log = new System.Windows.Forms.TextBox();
            this.Header.SuspendLayout();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Controls.Add(this.EdName);
            this.Header.Controls.Add(this.BtnStart);
            this.Header.Controls.Add(this.EdPort);
            this.Header.Controls.Add(this.EdHost);
            this.Header.Controls.Add(this.BtnServer);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(520, 44);
            this.Header.TabIndex = 0;
            // 
            // EdName
            // 
            this.EdName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EdName.Location = new System.Drawing.Point(361, 10);
            this.EdName.Name = "EdName";
            this.EdName.Size = new System.Drawing.Size(70, 20);
            this.EdName.TabIndex = 4;
            this.EdName.Text = "Ja";
            this.EdName.TextChanged += new System.EventHandler(this.EdName_TextChanged);
            // 
            // BtnStart
            // 
            this.BtnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStart.Location = new System.Drawing.Point(437, 8);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 3;
            this.BtnStart.Text = "Połącz";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // EdPort
            // 
            this.EdPort.Location = new System.Drawing.Point(216, 10);
            this.EdPort.Name = "EdPort";
            this.EdPort.Size = new System.Drawing.Size(41, 20);
            this.EdPort.TabIndex = 2;
            this.EdPort.Text = "8888";
            this.EdPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EdPort.TextChanged += new System.EventHandler(this.EdPort_TextChanged);
            // 
            // EdHost
            // 
            this.EdHost.Location = new System.Drawing.Point(77, 10);
            this.EdHost.Name = "EdHost";
            this.EdHost.Size = new System.Drawing.Size(123, 20);
            this.EdHost.TabIndex = 1;
            this.EdHost.Text = "localhost";
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
            this.BtnServer.CheckedChanged += new System.EventHandler(this.BtnServer_CheckedChanged);
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.BtnSend);
            this.Footer.Controls.Add(this.EdSendText);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 243);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(520, 34);
            this.Footer.TabIndex = 1;
            // 
            // BtnSend
            // 
            this.BtnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSend.Enabled = false;
            this.BtnSend.Location = new System.Drawing.Point(437, 4);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 4;
            this.BtnSend.Text = "Wyślij";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // EdSendText
            // 
            this.EdSendText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdSendText.Enabled = false;
            this.EdSendText.Location = new System.Drawing.Point(12, 6);
            this.EdSendText.Name = "EdSendText";
            this.EdSendText.Size = new System.Drawing.Size(419, 20);
            this.EdSendText.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Log
            // 
            this.Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Log.Location = new System.Drawing.Point(0, 44);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Log.Size = new System.Drawing.Size(520, 199);
            this.Log.TabIndex = 3;
            // 
            // ChatMain
            // 
            this.AcceptButton = this.BtnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 277);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.Header);
            this.Name = "ChatMain";
            this.Text = "Prosty chat ...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatMain_FormClosing);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.TextBox EdPort;
        private System.Windows.Forms.TextBox EdHost;
        private System.Windows.Forms.CheckBox BtnServer;
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.TextBox EdSendText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.TextBox EdName;
    }
}

