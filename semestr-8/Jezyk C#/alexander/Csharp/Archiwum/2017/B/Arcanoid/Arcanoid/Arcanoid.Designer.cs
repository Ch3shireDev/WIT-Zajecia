namespace Arcanoid
{
    partial class Arcanoid
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
            this.components = new System.ComponentModel.Container();
            this.Ticker = new System.Windows.Forms.Timer(this.components);
            this.Box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Ticker
            // 
            this.Ticker.Enabled = true;
            this.Ticker.Interval = 20;
            this.Ticker.Tick += new System.EventHandler(this.Ticker_Tick);
            // 
            // Box
            // 
            this.Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box.Location = new System.Drawing.Point(0, 0);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(670, 445);
            this.Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Box.TabIndex = 0;
            this.Box.TabStop = false;
            this.Box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Box_MouseClick);
            this.Box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Box_MouseMove);
            // 
            // Arcanoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 445);
            this.Controls.Add(this.Box);
            this.Name = "Arcanoid";
            this.Text = "Arcanoid";
            this.Resize += new System.EventHandler(this.Arcanoid_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Ticker;
        private System.Windows.Forms.PictureBox Box;
    }
}

