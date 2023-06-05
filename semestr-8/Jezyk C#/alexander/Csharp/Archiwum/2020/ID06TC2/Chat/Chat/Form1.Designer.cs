namespace Chat
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
            this.BtnServer = new System.Windows.Forms.Button();
            this.BtnClient = new System.Windows.Forms.Button();
            this.EdLog = new System.Windows.Forms.TextBox();
            this.EdMessage = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnServer
            // 
            this.BtnServer.Location = new System.Drawing.Point(12, 12);
            this.BtnServer.Name = "BtnServer";
            this.BtnServer.Size = new System.Drawing.Size(75, 23);
            this.BtnServer.TabIndex = 0;
            this.BtnServer.Text = "Server";
            this.BtnServer.UseVisualStyleBackColor = true;
            this.BtnServer.Click += new System.EventHandler(this.BtnServer_Click);
            // 
            // BtnClient
            // 
            this.BtnClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClient.Location = new System.Drawing.Point(501, 12);
            this.BtnClient.Name = "BtnClient";
            this.BtnClient.Size = new System.Drawing.Size(75, 23);
            this.BtnClient.TabIndex = 1;
            this.BtnClient.Text = "Client";
            this.BtnClient.UseVisualStyleBackColor = true;
            this.BtnClient.Click += new System.EventHandler(this.BtnClient_Click);
            // 
            // EdLog
            // 
            this.EdLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdLog.Location = new System.Drawing.Point(12, 41);
            this.EdLog.Multiline = true;
            this.EdLog.Name = "EdLog";
            this.EdLog.Size = new System.Drawing.Size(564, 361);
            this.EdLog.TabIndex = 2;
            // 
            // EdMessage
            // 
            this.EdMessage.Location = new System.Drawing.Point(148, 15);
            this.EdMessage.Name = "EdMessage";
            this.EdMessage.Size = new System.Drawing.Size(213, 20);
            this.EdMessage.TabIndex = 3;
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(392, 12);
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
            this.ClientSize = new System.Drawing.Size(588, 414);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.EdMessage);
            this.Controls.Add(this.EdLog);
            this.Controls.Add(this.BtnClient);
            this.Controls.Add(this.BtnServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnServer;
        private System.Windows.Forms.Button BtnClient;
        private System.Windows.Forms.TextBox EdLog;
        private System.Windows.Forms.TextBox EdMessage;
        private System.Windows.Forms.Button BtnSend;
    }
}

