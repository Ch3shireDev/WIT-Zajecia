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
            this.EHost = new System.Windows.Forms.TextBox();
            this.LHost = new System.Windows.Forms.Label();
            this.EPort = new System.Windows.Forms.TextBox();
            this.LPort = new System.Windows.Forms.Label();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.EQuestion = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.EAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EHost
            // 
            this.EHost.Location = new System.Drawing.Point(12, 25);
            this.EHost.Name = "EHost";
            this.EHost.Size = new System.Drawing.Size(100, 20);
            this.EHost.TabIndex = 5;
            this.EHost.Text = "localhost";
            // 
            // LHost
            // 
            this.LHost.AutoSize = true;
            this.LHost.Location = new System.Drawing.Point(12, 9);
            this.LHost.Name = "LHost";
            this.LHost.Size = new System.Drawing.Size(40, 13);
            this.LHost.TabIndex = 4;
            this.LHost.Text = "&Serwer";
            // 
            // EPort
            // 
            this.EPort.Location = new System.Drawing.Point(118, 25);
            this.EPort.Name = "EPort";
            this.EPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EPort.Size = new System.Drawing.Size(36, 20);
            this.EPort.TabIndex = 7;
            this.EPort.Text = "8083";
            this.EPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LPort
            // 
            this.LPort.AutoSize = true;
            this.LPort.Location = new System.Drawing.Point(118, 9);
            this.LPort.Name = "LPort";
            this.LPort.Size = new System.Drawing.Size(26, 13);
            this.LPort.TabIndex = 6;
            this.LPort.Text = "&Port";
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(160, 9);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(84, 36);
            this.BtnConnect.TabIndex = 8;
            this.BtnConnect.Text = "Połącz";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // EQuestion
            // 
            this.EQuestion.Location = new System.Drawing.Point(12, 67);
            this.EQuestion.Name = "EQuestion";
            this.EQuestion.Size = new System.Drawing.Size(142, 20);
            this.EQuestion.TabIndex = 9;
            this.EQuestion.Text = "100";
            this.EQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnSend
            // 
            this.BtnSend.Enabled = false;
            this.BtnSend.Location = new System.Drawing.Point(160, 64);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(84, 23);
            this.BtnSend.TabIndex = 10;
            this.BtnSend.Text = "Wyślij";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // EAnswer
            // 
            this.EAnswer.Location = new System.Drawing.Point(12, 93);
            this.EAnswer.Name = "EAnswer";
            this.EAnswer.ReadOnly = true;
            this.EAnswer.Size = new System.Drawing.Size(229, 20);
            this.EAnswer.TabIndex = 11;
            // 
            // ClientForm
            // 
            this.AcceptButton = this.BtnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 119);
            this.Controls.Add(this.EAnswer);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.EQuestion);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.EPort);
            this.Controls.Add(this.LPort);
            this.Controls.Add(this.EHost);
            this.Controls.Add(this.LHost);
            this.Name = "ClientForm";
            this.Text = "Client ...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EHost;
        private System.Windows.Forms.Label LHost;
        private System.Windows.Forms.TextBox EPort;
        private System.Windows.Forms.Label LPort;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.TextBox EQuestion;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.TextBox EAnswer;
    }
}

