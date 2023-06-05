namespace Arcanoid
{
    partial class ArcanoidForm
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
            ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box.Location = new System.Drawing.Point(0, 0);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(796, 525);
            this.Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Box.TabIndex = 0;
            this.Box.TabStop = false;
            this.Box.Click += new System.EventHandler(this.Box_Click);
            this.Box.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.Box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Box_MouseMove);
            this.Box.Resize += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // ArcanoidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 525);
            this.Controls.Add(this.Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArcanoidForm";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Box;
    }
}

