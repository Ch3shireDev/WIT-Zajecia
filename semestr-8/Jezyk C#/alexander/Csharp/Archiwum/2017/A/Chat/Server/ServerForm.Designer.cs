namespace Server
{
    partial class ServerForm
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
            this.BtnConnect = new System.Windows.Forms.Button();
            this.EdLog = new System.Windows.Forms.TextBox();
            this.EdPort = new System.Windows.Forms.TextBox();
            this.LbPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnConnect
            // 
            this.BtnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConnect.Location = new System.Drawing.Point(374, 12);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 23);
            this.BtnConnect.TabIndex = 11;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // EdLog
            // 
            this.EdLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdLog.Location = new System.Drawing.Point(12, 57);
            this.EdLog.Multiline = true;
            this.EdLog.Name = "EdLog";
            this.EdLog.ReadOnly = true;
            this.EdLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EdLog.Size = new System.Drawing.Size(437, 211);
            this.EdLog.TabIndex = 10;
            // 
            // EdPort
            // 
            this.EdPort.Location = new System.Drawing.Point(12, 31);
            this.EdPort.Name = "EdPort";
            this.EdPort.Size = new System.Drawing.Size(55, 20);
            this.EdPort.TabIndex = 9;
            this.EdPort.Text = "8888";
            this.EdPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EdPort.TextChanged += new System.EventHandler(this.EdPort_TextChanged);
            // 
            // LbPort
            // 
            this.LbPort.AutoSize = true;
            this.LbPort.Location = new System.Drawing.Point(9, 14);
            this.LbPort.Name = "LbPort";
            this.LbPort.Size = new System.Drawing.Size(26, 13);
            this.LbPort.TabIndex = 8;
            this.LbPort.Text = "&Port";
            this.LbPort.Click += new System.EventHandler(this.LbPort_Click);
            // 
            // ServerForm
            // 
            this.AcceptButton = this.BtnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 280);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.EdLog);
            this.Controls.Add(this.EdPort);
            this.Controls.Add(this.LbPort);
            this.Name = "ServerForm";
            this.Text = "Chat Server ...";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServerForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.TextBox EdLog;
        private System.Windows.Forms.TextBox EdPort;
        private System.Windows.Forms.Label LbPort;
    }
}

