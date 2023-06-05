namespace TcpChat
{
    partial class TcpChatForm
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
            this.EdHost = new System.Windows.Forms.TextBox();
            this.EdPort = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.CbServer = new System.Windows.Forms.CheckBox();
            this.EdLog = new System.Windows.Forms.TextBox();
            this.EdMessage = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EdHost
            // 
            this.EdHost.Location = new System.Drawing.Point(12, 12);
            this.EdHost.Name = "EdHost";
            this.EdHost.Size = new System.Drawing.Size(160, 20);
            this.EdHost.TabIndex = 0;
            this.EdHost.Text = "localhost";
            // 
            // EdPort
            // 
            this.EdPort.Location = new System.Drawing.Point(178, 12);
            this.EdPort.Name = "EdPort";
            this.EdPort.Size = new System.Drawing.Size(67, 20);
            this.EdPort.TabIndex = 1;
            this.EdPort.Text = "6688";
            this.EdPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConnect.Location = new System.Drawing.Point(601, 10);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 23);
            this.BtnConnect.TabIndex = 2;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // CbServer
            // 
            this.CbServer.AutoSize = true;
            this.CbServer.Location = new System.Drawing.Point(251, 12);
            this.CbServer.Name = "CbServer";
            this.CbServer.Size = new System.Drawing.Size(57, 17);
            this.CbServer.TabIndex = 3;
            this.CbServer.Text = "Server";
            this.CbServer.UseVisualStyleBackColor = true;
            // 
            // EdLog
            // 
            this.EdLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdLog.Location = new System.Drawing.Point(12, 38);
            this.EdLog.Multiline = true;
            this.EdLog.Name = "EdLog";
            this.EdLog.Size = new System.Drawing.Size(664, 297);
            this.EdLog.TabIndex = 4;
            // 
            // EdMessage
            // 
            this.EdMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdMessage.Location = new System.Drawing.Point(12, 344);
            this.EdMessage.Name = "EdMessage";
            this.EdMessage.Size = new System.Drawing.Size(583, 20);
            this.EdMessage.TabIndex = 5;
            // 
            // BtnSend
            // 
            this.BtnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSend.Location = new System.Drawing.Point(601, 341);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 6;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // TcpChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 376);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.EdMessage);
            this.Controls.Add(this.EdLog);
            this.Controls.Add(this.CbServer);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.EdPort);
            this.Controls.Add(this.EdHost);
            this.Name = "TcpChatForm";
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TcpChatForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EdHost;
        private System.Windows.Forms.TextBox EdPort;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.CheckBox CbServer;
        private System.Windows.Forms.TextBox EdLog;
        private System.Windows.Forms.TextBox EdMessage;
        private System.Windows.Forms.Button BtnSend;
    }
}

