namespace TcpChat
{
    partial class TCPchat
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
            this.ChkServer = new System.Windows.Forms.CheckBox();
            this.TxtHost = new System.Windows.Forms.TextBox();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.TxtMessage = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChkServer
            // 
            this.ChkServer.AutoSize = true;
            this.ChkServer.Location = new System.Drawing.Point(12, 14);
            this.ChkServer.Name = "ChkServer";
            this.ChkServer.Size = new System.Drawing.Size(57, 17);
            this.ChkServer.TabIndex = 0;
            this.ChkServer.Text = "Server";
            this.ChkServer.UseVisualStyleBackColor = true;
            // 
            // TxtHost
            // 
            this.TxtHost.Location = new System.Drawing.Point(75, 11);
            this.TxtHost.Name = "TxtHost";
            this.TxtHost.Size = new System.Drawing.Size(148, 20);
            this.TxtHost.TabIndex = 1;
            this.TxtHost.Text = "localhost";
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(229, 12);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(65, 20);
            this.TxtPort.TabIndex = 2;
            this.TxtPort.TextChanged += new System.EventHandler(this.TxtPort_TextChanged);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConnect.Location = new System.Drawing.Point(562, 10);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 23);
            this.BtnConnect.TabIndex = 3;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // TxtLog
            // 
            this.TxtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtLog.Location = new System.Drawing.Point(12, 39);
            this.TxtLog.Multiline = true;
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.Size = new System.Drawing.Size(625, 216);
            this.TxtLog.TabIndex = 4;
            // 
            // TxtMessage
            // 
            this.TxtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMessage.Location = new System.Drawing.Point(12, 263);
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.Size = new System.Drawing.Size(544, 20);
            this.TxtMessage.TabIndex = 5;
            this.TxtMessage.TextChanged += new System.EventHandler(this.TxtMessage_TextChanged);
            // 
            // BtnSend
            // 
            this.BtnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSend.Location = new System.Drawing.Point(562, 261);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 6;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // TCPchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 293);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.TxtMessage);
            this.Controls.Add(this.TxtLog);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.TxtPort);
            this.Controls.Add(this.TxtHost);
            this.Controls.Add(this.ChkServer);
            this.Name = "TCPchat";
            this.Text = "TCP chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TCPchat_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkServer;
        private System.Windows.Forms.TextBox TxtHost;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.TextBox TxtLog;
        private System.Windows.Forms.TextBox TxtMessage;
        private System.Windows.Forms.Button BtnSend;
    }
}

