namespace ClientServer
{
    partial class AClient
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
            this.Log = new System.Windows.Forms.TextBox();
            this.Host = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.CheckBox();
            this.Line = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Log
            // 
            this.Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Log.Location = new System.Drawing.Point(12, 38);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Log.Size = new System.Drawing.Size(686, 242);
            this.Log.TabIndex = 1;
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(12, 12);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(191, 20);
            this.Host.TabIndex = 2;
            this.Host.Text = "localhost";
            // 
            // BtnConnect
            // 
            this.BtnConnect.AutoSize = true;
            this.BtnConnect.Location = new System.Drawing.Point(209, 15);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(60, 17);
            this.BtnConnect.TabIndex = 3;
            this.BtnConnect.Text = "Po³¹cz";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.CheckedChanged += new System.EventHandler(this.BtnConnect_CheckedChanged);
            // 
            // Line
            // 
            this.Line.Location = new System.Drawing.Point(12, 284);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(602, 20);
            this.Line.TabIndex = 4;
            // 
            // BtnSend
            // 
            this.BtnSend.Enabled = false;
            this.BtnSend.Location = new System.Drawing.Point(623, 282);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 5;
            this.BtnSend.Text = "Wyœlij";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // AClient
            // 
            this.AcceptButton = this.BtnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 309);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.Log);
            this.Name = "AClient";
            this.Text = "Client ...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AClient_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.CheckBox BtnConnect;
        private System.Windows.Forms.TextBox Line;
        private System.Windows.Forms.Button BtnSend;
    }
}

