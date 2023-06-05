namespace Server
{
    partial class Server
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
            this.Emax = new System.Windows.Forms.TextBox();
            this.Box = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(101, 12);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(75, 23);
            this.BtnRun.TabIndex = 0;
            this.BtnRun.Text = "&Run";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // Emax
            // 
            this.Emax.Location = new System.Drawing.Point(13, 12);
            this.Emax.Name = "Emax";
            this.Emax.Size = new System.Drawing.Size(60, 20);
            this.Emax.TabIndex = 1;
            this.Emax.Text = "5000";
            this.Emax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Emax.TextChanged += new System.EventHandler(this.Emax_TextChanged);
            // 
            // Box
            // 
            this.Box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Box.AutoScroll = true;
            this.Box.AutoScrollMinSize = new System.Drawing.Size(0, 252);
            this.Box.Location = new System.Drawing.Point(0, 41);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(837, 251);
            this.Box.TabIndex = 2;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 292);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.Emax);
            this.Controls.Add(this.BtnRun);
            this.Name = "Server";
            this.Text = "Server ...";
            this.Resize += new System.EventHandler(this.Server_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Emax;
        public System.Windows.Forms.Button BtnRun;
        public System.Windows.Forms.Panel Box;
    }
}

