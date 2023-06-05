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
            this.EPort = new System.Windows.Forms.TextBox();
            this.LPort = new System.Windows.Forms.Label();
            this.ELog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(52, 12);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(84, 36);
            this.BtnConnect.TabIndex = 11;
            this.BtnConnect.Text = "Połącz";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // EPort
            // 
            this.EPort.Location = new System.Drawing.Point(10, 28);
            this.EPort.Name = "EPort";
            this.EPort.Size = new System.Drawing.Size(36, 20);
            this.EPort.TabIndex = 10;
            this.EPort.Text = "8083";
            this.EPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LPort
            // 
            this.LPort.AutoSize = true;
            this.LPort.Location = new System.Drawing.Point(10, 12);
            this.LPort.Name = "LPort";
            this.LPort.Size = new System.Drawing.Size(26, 13);
            this.LPort.TabIndex = 9;
            this.LPort.Text = "&Port";
            // 
            // ELog
            // 
            this.ELog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ELog.Location = new System.Drawing.Point(10, 54);
            this.ELog.Multiline = true;
            this.ELog.Name = "ELog";
            this.ELog.ReadOnly = true;
            this.ELog.Size = new System.Drawing.Size(314, 251);
            this.ELog.TabIndex = 12;
            // 
            // ServerForm
            // 
            this.AcceptButton = this.BtnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 317);
            this.Controls.Add(this.ELog);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.EPort);
            this.Controls.Add(this.LPort);
            this.Name = "ServerForm";
            this.Text = "Server ...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.TextBox EPort;
        private System.Windows.Forms.Label LPort;
        private System.Windows.Forms.TextBox ELog;
    }
}

