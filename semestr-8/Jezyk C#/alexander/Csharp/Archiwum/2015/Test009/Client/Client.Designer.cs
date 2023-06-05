namespace Client
{
    partial class Client
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
            this.Port = new System.Windows.Forms.TextBox();
            this.Host = new System.Windows.Forms.TextBox();
            this.ToSend = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(150, 12);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(92, 23);
            this.BtnConnect.TabIndex = 3;
            this.BtnConnect.Text = "Połącz";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(102, 12);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(42, 20);
            this.Port.TabIndex = 2;
            this.Port.Text = "8001";
            this.Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(12, 12);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(84, 20);
            this.Host.TabIndex = 4;
            this.Host.Text = "localhost";
            // 
            // ToSend
            // 
            this.ToSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToSend.Location = new System.Drawing.Point(12, 38);
            this.ToSend.Name = "ToSend";
            this.ToSend.ReadOnly = true;
            this.ToSend.Size = new System.Drawing.Size(244, 20);
            this.ToSend.TabIndex = 5;
            // 
            // BtnSend
            // 
            this.BtnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSend.Location = new System.Drawing.Point(262, 38);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 6;
            this.BtnSend.Text = "Wyślij";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // LogBox
            // 
            this.LogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogBox.Location = new System.Drawing.Point(12, 67);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(325, 183);
            this.LogBox.TabIndex = 7;
            // 
            // Client
            // 
            this.AcceptButton = this.BtnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 262);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.ToSend);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.Port);
            this.Name = "Client";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.TextBox ToSend;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.TextBox LogBox;
    }
}

