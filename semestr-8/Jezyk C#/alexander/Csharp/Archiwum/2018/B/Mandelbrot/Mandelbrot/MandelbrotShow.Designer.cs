namespace Mandelbrot
{
    partial class MandelbrotShow
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
            this.Header = new System.Windows.Forms.Panel();
            this.EdZoom = new System.Windows.Forms.TextBox();
            this.LbZoom = new System.Windows.Forms.Label();
            this.EdTp = new System.Windows.Forms.TextBox();
            this.LbTp = new System.Windows.Forms.Label();
            this.EdLf = new System.Windows.Forms.TextBox();
            this.LbLf = new System.Windows.Forms.Label();
            this.Box = new System.Windows.Forms.PictureBox();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Controls.Add(this.EdZoom);
            this.Header.Controls.Add(this.LbZoom);
            this.Header.Controls.Add(this.EdTp);
            this.Header.Controls.Add(this.LbTp);
            this.Header.Controls.Add(this.EdLf);
            this.Header.Controls.Add(this.LbLf);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(664, 33);
            this.Header.TabIndex = 0;
            // 
            // EdZoom
            // 
            this.EdZoom.Location = new System.Drawing.Point(441, 6);
            this.EdZoom.Name = "EdZoom";
            this.EdZoom.Size = new System.Drawing.Size(150, 20);
            this.EdZoom.TabIndex = 5;
            this.EdZoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EdZoom.TextChanged += new System.EventHandler(this.EdScale_TextChanged);
            // 
            // LbZoom
            // 
            this.LbZoom.AutoSize = true;
            this.LbZoom.Location = new System.Drawing.Point(398, 9);
            this.LbZoom.Name = "LbZoom";
            this.LbZoom.Size = new System.Drawing.Size(37, 13);
            this.LbZoom.TabIndex = 4;
            this.LbZoom.Text = "Scala:";
            // 
            // EdTp
            // 
            this.EdTp.Location = new System.Drawing.Point(227, 6);
            this.EdTp.Name = "EdTp";
            this.EdTp.Size = new System.Drawing.Size(150, 20);
            this.EdTp.TabIndex = 3;
            this.EdTp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EdTp.TextChanged += new System.EventHandler(this.EdY_TextChanged);
            // 
            // LbTp
            // 
            this.LbTp.AutoSize = true;
            this.LbTp.Location = new System.Drawing.Point(204, 9);
            this.LbTp.Name = "LbTp";
            this.LbTp.Size = new System.Drawing.Size(17, 13);
            this.LbTp.TabIndex = 2;
            this.LbTp.Text = "Y:";
            // 
            // EdLf
            // 
            this.EdLf.Location = new System.Drawing.Point(35, 6);
            this.EdLf.Name = "EdLf";
            this.EdLf.Size = new System.Drawing.Size(150, 20);
            this.EdLf.TabIndex = 1;
            this.EdLf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EdLf.TextChanged += new System.EventHandler(this.EdX_TextChanged);
            // 
            // LbLf
            // 
            this.LbLf.AutoSize = true;
            this.LbLf.Location = new System.Drawing.Point(12, 9);
            this.LbLf.Name = "LbLf";
            this.LbLf.Size = new System.Drawing.Size(17, 13);
            this.LbLf.TabIndex = 0;
            this.LbLf.Text = "X:";
            // 
            // Box
            // 
            this.Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box.Location = new System.Drawing.Point(0, 33);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(664, 332);
            this.Box.TabIndex = 1;
            this.Box.TabStop = false;
            this.Box.Paint += new System.Windows.Forms.PaintEventHandler(this.Box_Paint);
            this.Box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Box_MouseDown);
            this.Box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Box_MouseMove);
            this.Box.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Box_MouseUp);
            // 
            // MandelbrotShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 365);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.Header);
            this.Name = "MandelbrotShow";
            this.Text = "Fraktal Mandelbrota ...";
            this.Resize += new System.EventHandler(this.MandelbrotShow_Resize);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.TextBox EdZoom;
        private System.Windows.Forms.Label LbZoom;
        private System.Windows.Forms.TextBox EdTp;
        private System.Windows.Forms.Label LbTp;
        private System.Windows.Forms.TextBox EdLf;
        private System.Windows.Forms.Label LbLf;
        private System.Windows.Forms.PictureBox Box;
    }
}

