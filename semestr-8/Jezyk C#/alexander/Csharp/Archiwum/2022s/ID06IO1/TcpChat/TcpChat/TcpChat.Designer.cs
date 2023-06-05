namespace TcpChat
{
    partial class TcpChat
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
            this.CkbServer = new System.Windows.Forms.CheckBox();
            this.TbHost = new System.Windows.Forms.TextBox();
            this.TbPort = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.TbLog = new System.Windows.Forms.TextBox();
            this.TbMessage = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.BtnDone = new System.Windows.Forms.Button();
            this.TimeChecker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CkbServer
            // 
            this.CkbServer.AutoSize = true;
            this.CkbServer.Location = new System.Drawing.Point(12, 12);
            this.CkbServer.Name = "CkbServer";
            this.CkbServer.Size = new System.Drawing.Size(57, 17);
            this.CkbServer.TabIndex = 0;
            this.CkbServer.Text = "Server";
            this.CkbServer.UseVisualStyleBackColor = true;
            this.CkbServer.CheckedChanged += new System.EventHandler(this.CkbServer_CheckedChanged);
            // 
            // TbHost
            // 
            this.TbHost.Location = new System.Drawing.Point(75, 10);
            this.TbHost.Name = "TbHost";
            this.TbHost.Size = new System.Drawing.Size(149, 20);
            this.TbHost.TabIndex = 1;
            this.TbHost.Text = "localhost";
            // 
            // TbPort
            // 
            this.TbPort.Location = new System.Drawing.Point(230, 10);
            this.TbPort.Name = "TbPort";
            this.TbPort.Size = new System.Drawing.Size(46, 20);
            this.TbPort.TabIndex = 2;
            this.TbPort.Text = "6688";
            this.TbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(282, 8);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 23);
            this.BtnConnect.TabIndex = 3;
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // TbLog
            // 
            this.TbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbLog.Location = new System.Drawing.Point(12, 36);
            this.TbLog.Multiline = true;
            this.TbLog.Name = "TbLog";
            this.TbLog.Size = new System.Drawing.Size(859, 348);
            this.TbLog.TabIndex = 4;
            // 
            // TbMessage
            // 
            this.TbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbMessage.Enabled = false;
            this.TbMessage.Location = new System.Drawing.Point(12, 392);
            this.TbMessage.Name = "TbMessage";
            this.TbMessage.Size = new System.Drawing.Size(778, 20);
            this.TbMessage.TabIndex = 5;
            // 
            // BtnSend
            // 
            this.BtnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSend.Enabled = false;
            this.BtnSend.Location = new System.Drawing.Point(796, 390);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 6;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // BtnDone
            // 
            this.BtnDone.Location = new System.Drawing.Point(796, 8);
            this.BtnDone.Name = "BtnDone";
            this.BtnDone.Size = new System.Drawing.Size(75, 23);
            this.BtnDone.TabIndex = 7;
            this.BtnDone.Text = "Done";
            this.BtnDone.UseVisualStyleBackColor = true;
            // 
            // TimeChecker
            // 
            this.TimeChecker.Interval = 1000;
            // 
            // TcpChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 422);
            this.Controls.Add(this.BtnDone);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.TbMessage);
            this.Controls.Add(this.TbLog);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.TbPort);
            this.Controls.Add(this.TbHost);
            this.Controls.Add(this.CkbServer);
            this.Name = "TcpChat";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TcpChat_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CkbServer;
        private System.Windows.Forms.TextBox TbHost;
        private System.Windows.Forms.TextBox TbPort;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.TextBox TbLog;
        private System.Windows.Forms.TextBox TbMessage;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Button BtnDone;
        private System.Windows.Forms.Timer TimeChecker;
    }
}

