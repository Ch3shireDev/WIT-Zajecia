namespace SyncClient
{
    partial class SyncClient
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
            this.GrpHost = new System.Windows.Forms.GroupBox();
            this.Host = new System.Windows.Forms.TextBox();
            this.BtnRun = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.TextBox();
            this.Suma = new System.Windows.Forms.TextBox();
            this.GrpHost.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpHost
            // 
            this.GrpHost.Controls.Add(this.Host);
            this.GrpHost.Location = new System.Drawing.Point(12, 12);
            this.GrpHost.Name = "GrpHost";
            this.GrpHost.Size = new System.Drawing.Size(200, 45);
            this.GrpHost.TabIndex = 0;
            this.GrpHost.TabStop = false;
            this.GrpHost.Text = "&Host";
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(6, 19);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(188, 20);
            this.Host.TabIndex = 0;
            this.Host.Text = "localhost";
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(218, 30);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(75, 22);
            this.BtnRun.TabIndex = 1;
            this.BtnRun.Text = "&Connect";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // Log
            // 
            this.Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Log.Location = new System.Drawing.Point(12, 63);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Log.Size = new System.Drawing.Size(419, 83);
            this.Log.TabIndex = 2;
            // 
            // Suma
            // 
            this.Suma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Suma.Location = new System.Drawing.Point(312, 31);
            this.Suma.Name = "Suma";
            this.Suma.ReadOnly = true;
            this.Suma.Size = new System.Drawing.Size(119, 20);
            this.Suma.TabIndex = 3;
            this.Suma.Text = "0.00";
            this.Suma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SyncClient
            // 
            this.AcceptButton = this.BtnRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 158);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.GrpHost);
            this.Name = "SyncClient";
            this.Text = "Client ...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SyncClient_FormClosing);
            this.GrpHost.ResumeLayout(false);
            this.GrpHost.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpHost;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.Button BtnRun;
        public System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.TextBox Suma;

    }
}

