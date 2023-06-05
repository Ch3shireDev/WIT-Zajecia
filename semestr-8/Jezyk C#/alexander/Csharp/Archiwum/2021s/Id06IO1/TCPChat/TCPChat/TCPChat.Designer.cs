namespace TCPChat
{
    partial class TCPChat
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
            this.TxtHost = new System.Windows.Forms.TextBox();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.ChkServer = new System.Windows.Forms.CheckBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.TxtMessage = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtHost
            // 
            this.TxtHost.Location = new System.Drawing.Point(76, 10);
            this.TxtHost.Name = "TxtHost";
            this.TxtHost.Size = new System.Drawing.Size(159, 20);
            this.TxtHost.TabIndex = 0;
            this.TxtHost.Text = "localhost";
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(241, 10);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(100, 20);
            this.TxtPort.TabIndex = 1;
            this.TxtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPort.TextChanged += new System.EventHandler(this.TxtPort_TextChanged);
            // 
            // ChkServer
            // 
            this.ChkServer.AutoSize = true;
            this.ChkServer.Location = new System.Drawing.Point(13, 12);
            this.ChkServer.Name = "ChkServer";
            this.ChkServer.Size = new System.Drawing.Size(57, 17);
            this.ChkServer.TabIndex = 2;
            this.ChkServer.Text = "Server";
            this.ChkServer.UseVisualStyleBackColor = true;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConnect.Location = new System.Drawing.Point(669, 8);
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
            this.TxtLog.Location = new System.Drawing.Point(12, 38);
            this.TxtLog.Multiline = true;
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.Size = new System.Drawing.Size(732, 285);
            this.TxtLog.TabIndex = 4;
            // 
            // TxtMessage
            // 
            this.TxtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMessage.Location = new System.Drawing.Point(12, 331);
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.Size = new System.Drawing.Size(651, 20);
            this.TxtMessage.TabIndex = 5;
            // 
            // BtnSend
            // 
            this.BtnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSend.Location = new System.Drawing.Point(669, 329);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 6;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // TCPChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 363);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.TxtMessage);
            this.Controls.Add(this.TxtLog);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.ChkServer);
            this.Controls.Add(this.TxtPort);
            this.Controls.Add(this.TxtHost);
            this.Name = "TCPChat";
            this.Text = "TCP Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtHost;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.CheckBox ChkServer;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.TextBox TxtLog;
        private System.Windows.Forms.TextBox TxtMessage;
        private System.Windows.Forms.Button BtnSend;
    }
}

