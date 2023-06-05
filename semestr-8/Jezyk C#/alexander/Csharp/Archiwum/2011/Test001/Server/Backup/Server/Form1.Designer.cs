namespace Server
{
    partial class ServerMain
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
            this.Progres1 = new System.Windows.Forms.ProgressBar();
            this.Progres2 = new System.Windows.Forms.ProgressBar();
            this.Progres3 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(236, 13);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(75, 23);
            this.BtnRun.TabIndex = 0;
            this.BtnRun.Text = "&Run";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // Progres1
            // 
            this.Progres1.Location = new System.Drawing.Point(12, 57);
            this.Progres1.Name = "Progres1";
            this.Progres1.Size = new System.Drawing.Size(678, 23);
            this.Progres1.TabIndex = 1;
            // 
            // Progres2
            // 
            this.Progres2.Location = new System.Drawing.Point(12, 86);
            this.Progres2.Name = "Progres2";
            this.Progres2.Size = new System.Drawing.Size(678, 23);
            this.Progres2.TabIndex = 2;
            // 
            // Progres3
            // 
            this.Progres3.Location = new System.Drawing.Point(12, 115);
            this.Progres3.Name = "Progres3";
            this.Progres3.Size = new System.Drawing.Size(678, 23);
            this.Progres3.TabIndex = 3;
            // 
            // ServerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 155);
            this.Controls.Add(this.Progres3);
            this.Controls.Add(this.Progres2);
            this.Controls.Add(this.Progres1);
            this.Controls.Add(this.BtnRun);
            this.Name = "ServerMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar Progres1;
        private System.Windows.Forms.ProgressBar Progres2;
        private System.Windows.Forms.ProgressBar Progres3;
        public System.Windows.Forms.Button BtnRun;
    }
}

