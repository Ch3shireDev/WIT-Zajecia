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
            this.Box = new System.Windows.Forms.Panel();
            this.LbX = new System.Windows.Forms.Label();
            this.EdX = new System.Windows.Forms.TextBox();
            this.EdY = new System.Windows.Forms.TextBox();
            this.LbY = new System.Windows.Forms.Label();
            this.EdZoom = new System.Windows.Forms.TextBox();
            this.LbZoom = new System.Windows.Forms.Label();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Controls.Add(this.EdZoom);
            this.Header.Controls.Add(this.LbZoom);
            this.Header.Controls.Add(this.EdY);
            this.Header.Controls.Add(this.LbY);
            this.Header.Controls.Add(this.EdX);
            this.Header.Controls.Add(this.LbX);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(769, 40);
            this.Header.TabIndex = 0;
            // 
            // Box
            // 
            this.Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box.Location = new System.Drawing.Point(0, 40);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(769, 524);
            this.Box.TabIndex = 1;
            this.Box.Paint += new System.Windows.Forms.PaintEventHandler(this.Box_Paint);
            this.Box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Box_MouseDown);
            this.Box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Box_MouseMove);
            this.Box.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Box_MouseUp);
            // 
            // LbX
            // 
            this.LbX.AutoSize = true;
            this.LbX.Location = new System.Drawing.Point(11, 15);
            this.LbX.Name = "LbX";
            this.LbX.Size = new System.Drawing.Size(17, 13);
            this.LbX.TabIndex = 0;
            this.LbX.Text = "X:";
            // 
            // EdX
            // 
            this.EdX.Location = new System.Drawing.Point(34, 12);
            this.EdX.Name = "EdX";
            this.EdX.Size = new System.Drawing.Size(196, 20);
            this.EdX.TabIndex = 1;
            this.EdX.Text = "-2";
            this.EdX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EdX.TextChanged += new System.EventHandler(this.EdX_TextChanged);
            // 
            // EdY
            // 
            this.EdY.Location = new System.Drawing.Point(280, 12);
            this.EdY.Name = "EdY";
            this.EdY.Size = new System.Drawing.Size(196, 20);
            this.EdY.TabIndex = 3;
            this.EdY.Text = "1";
            this.EdY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EdY.TextChanged += new System.EventHandler(this.EdY_TextChanged);
            // 
            // LbY
            // 
            this.LbY.AutoSize = true;
            this.LbY.Location = new System.Drawing.Point(257, 15);
            this.LbY.Name = "LbY";
            this.LbY.Size = new System.Drawing.Size(17, 13);
            this.LbY.TabIndex = 2;
            this.LbY.Text = "Y:";
            // 
            // EdZoom
            // 
            this.EdZoom.Location = new System.Drawing.Point(553, 12);
            this.EdZoom.Name = "EdZoom";
            this.EdZoom.Size = new System.Drawing.Size(196, 20);
            this.EdZoom.TabIndex = 5;
            this.EdZoom.Text = "1";
            this.EdZoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EdZoom.TextChanged += new System.EventHandler(this.EdZoom_TextChanged);
            // 
            // LbZoom
            // 
            this.LbZoom.AutoSize = true;
            this.LbZoom.Location = new System.Drawing.Point(510, 15);
            this.LbZoom.Name = "LbZoom";
            this.LbZoom.Size = new System.Drawing.Size(37, 13);
            this.LbZoom.TabIndex = 4;
            this.LbZoom.Text = "Zoom:";
            // 
            // MandelbrotShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 564);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.Header);
            this.Name = "MandelbrotShow";
            this.Text = "Mandelbrot image ...";
            this.Resize += new System.EventHandler(this.MandelbrotShow_Resize);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.TextBox EdZoom;
        private System.Windows.Forms.Label LbZoom;
        private System.Windows.Forms.TextBox EdY;
        private System.Windows.Forms.Label LbY;
        private System.Windows.Forms.TextBox EdX;
        private System.Windows.Forms.Label LbX;
        private System.Windows.Forms.Panel Box;
    }
}

