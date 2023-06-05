namespace SyncServer
{
    partial class SyncServer
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
            this.BtnRun = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.TextBox();
            this.Suma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(12, 12);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(75, 23);
            this.BtnRun.TabIndex = 0;
            this.BtnRun.Text = "&Start";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // Log
            // 
            this.Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Log.Location = new System.Drawing.Point(12, 41);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Log.Size = new System.Drawing.Size(527, 139);
            this.Log.TabIndex = 1;
            // 
            // Suma
            // 
            this.Suma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Suma.Location = new System.Drawing.Point(420, 12);
            this.Suma.Name = "Suma";
            this.Suma.ReadOnly = true;
            this.Suma.Size = new System.Drawing.Size(119, 20);
            this.Suma.TabIndex = 4;
            this.Suma.Text = "0.00";
            this.Suma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SyncServer
            // 
            this.AcceptButton = this.BtnRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 192);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.BtnRun);
            this.Name = "SyncServer";
            this.Text = "Server ...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SyncServer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRun;
        public System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.TextBox Suma;
    }
}

