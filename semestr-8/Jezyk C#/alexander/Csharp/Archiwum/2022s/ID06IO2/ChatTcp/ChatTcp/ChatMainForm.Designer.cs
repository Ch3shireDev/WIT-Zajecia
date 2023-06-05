namespace ChatTcp
{
    partial class ChatMainForm
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
            this.BtnClient = new System.Windows.Forms.Button();
            this.BtnServer = new System.Windows.Forms.Button();
            this.TbLog = new System.Windows.Forms.TextBox();
            this.TbMessage = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnClient
            // 
            this.BtnClient.Location = new System.Drawing.Point(13, 13);
            this.BtnClient.Name = "BtnClient";
            this.BtnClient.Size = new System.Drawing.Size(75, 23);
            this.BtnClient.TabIndex = 0;
            this.BtnClient.Text = "Client";
            this.BtnClient.UseVisualStyleBackColor = true;
            this.BtnClient.Click += new System.EventHandler(this.BtnClient_Click);
            // 
            // BtnServer
            // 
            this.BtnServer.Location = new System.Drawing.Point(94, 13);
            this.BtnServer.Name = "BtnServer";
            this.BtnServer.Size = new System.Drawing.Size(75, 23);
            this.BtnServer.TabIndex = 1;
            this.BtnServer.Text = "Server";
            this.BtnServer.UseVisualStyleBackColor = true;
            this.BtnServer.Click += new System.EventHandler(this.BtnServer_Click);
            // 
            // TbLog
            // 
            this.TbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbLog.Location = new System.Drawing.Point(12, 42);
            this.TbLog.Multiline = true;
            this.TbLog.Name = "TbLog";
            this.TbLog.Size = new System.Drawing.Size(732, 291);
            this.TbLog.TabIndex = 2;
            // 
            // TbMessage
            // 
            this.TbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbMessage.Location = new System.Drawing.Point(13, 339);
            this.TbMessage.Name = "TbMessage";
            this.TbMessage.Size = new System.Drawing.Size(650, 20);
            this.TbMessage.TabIndex = 3;
            // 
            // BtnSend
            // 
            this.BtnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSend.Location = new System.Drawing.Point(669, 339);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 4;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 371);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.TbMessage);
            this.Controls.Add(this.TbLog);
            this.Controls.Add(this.BtnServer);
            this.Controls.Add(this.BtnClient);
            this.Name = "Form1";
            this.Text = "Chat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatMainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClient;
        private System.Windows.Forms.Button BtnServer;
        private System.Windows.Forms.TextBox TbLog;
        private System.Windows.Forms.TextBox TbMessage;
        private System.Windows.Forms.Button BtnSend;
    }
}

