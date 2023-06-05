namespace Client
{
    partial class ClientForm
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
            this.LbHost = new System.Windows.Forms.Label();
            this.EdHost = new System.Windows.Forms.TextBox();
            this.EdPort = new System.Windows.Forms.TextBox();
            this.LbPort = new System.Windows.Forms.Label();
            this.EdLog = new System.Windows.Forms.TextBox();
            this.EdMessage = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbHost
            // 
            this.LbHost.AutoSize = true;
            this.LbHost.Location = new System.Drawing.Point(12, 9);
            this.LbHost.Name = "LbHost";
            this.LbHost.Size = new System.Drawing.Size(29, 13);
            this.LbHost.TabIndex = 0;
            this.LbHost.Text = "&Host";
            this.LbHost.Click += new System.EventHandler(this.LbHost_Click);
            // 
            // EdHost
            // 
            this.EdHost.Location = new System.Drawing.Point(15, 26);
            this.EdHost.Name = "EdHost";
            this.EdHost.Size = new System.Drawing.Size(100, 20);
            this.EdHost.TabIndex = 1;
            this.EdHost.Text = "localhost";
            // 
            // EdPort
            // 
            this.EdPort.Location = new System.Drawing.Point(121, 26);
            this.EdPort.Name = "EdPort";
            this.EdPort.Size = new System.Drawing.Size(55, 20);
            this.EdPort.TabIndex = 3;
            this.EdPort.Text = "8888";
            this.EdPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EdPort.TextChanged += new System.EventHandler(this.EdPort_TextChanged);
            // 
            // LbPort
            // 
            this.LbPort.AutoSize = true;
            this.LbPort.Location = new System.Drawing.Point(118, 9);
            this.LbPort.Name = "LbPort";
            this.LbPort.Size = new System.Drawing.Size(26, 13);
            this.LbPort.TabIndex = 2;
            this.LbPort.Text = "Port";
            this.LbPort.Click += new System.EventHandler(this.LbPort_Click);
            // 
            // EdLog
            // 
            this.EdLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdLog.Location = new System.Drawing.Point(15, 53);
            this.EdLog.Multiline = true;
            this.EdLog.Name = "EdLog";
            this.EdLog.ReadOnly = true;
            this.EdLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EdLog.Size = new System.Drawing.Size(447, 146);
            this.EdLog.TabIndex = 4;
            // 
            // EdMessage
            // 
            this.EdMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdMessage.Location = new System.Drawing.Point(13, 214);
            this.EdMessage.Name = "EdMessage";
            this.EdMessage.ReadOnly = true;
            this.EdMessage.Size = new System.Drawing.Size(370, 20);
            this.EdMessage.TabIndex = 5;
            // 
            // BtnSend
            // 
            this.BtnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSend.Enabled = false;
            this.BtnSend.Location = new System.Drawing.Point(389, 214);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 6;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConnect.Location = new System.Drawing.Point(389, 9);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 23);
            this.BtnConnect.TabIndex = 7;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // ClientForm
            // 
            this.AcceptButton = this.BtnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 246);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.EdMessage);
            this.Controls.Add(this.EdLog);
            this.Controls.Add(this.EdPort);
            this.Controls.Add(this.LbPort);
            this.Controls.Add(this.EdHost);
            this.Controls.Add(this.LbHost);
            this.Name = "ClientForm";
            this.Text = "Chat klient ...";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbHost;
        private System.Windows.Forms.TextBox EdHost;
        private System.Windows.Forms.TextBox EdPort;
        private System.Windows.Forms.Label LbPort;
        private System.Windows.Forms.TextBox EdLog;
        private System.Windows.Forms.TextBox EdMessage;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Button BtnConnect;
    }
}

