namespace Arcanoid
{
    partial class AracanoidMain
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
            this.Box = new System.Windows.Forms.PictureBox();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box.Location = new System.Drawing.Point(0, 0);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(284, 262);
            this.Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Box.TabIndex = 0;
            this.Box.TabStop = false;
            this.Box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Box_MouseClick);
            this.Box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Box_MouseMove);
            // 
            // bw
            // 
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            // 
            // AracanoidMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AracanoidMain";
            this.Text = "Arcanoid";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AracanoidMain_FormClosing);
            this.Resize += new System.EventHandler(this.AracanoidMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Box;
        private System.ComponentModel.BackgroundWorker bw;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

