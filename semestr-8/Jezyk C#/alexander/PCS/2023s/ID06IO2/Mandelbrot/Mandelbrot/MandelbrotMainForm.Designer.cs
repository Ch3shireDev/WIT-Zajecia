namespace Mandelbrot
{
    partial class MandelbrotMainForm
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
            this.PnControlHeader = new System.Windows.Forms.Panel();
            this.TbZoom = new System.Windows.Forms.TextBox();
            this.LblZoom = new System.Windows.Forms.Label();
            this.TbY = new System.Windows.Forms.TextBox();
            this.LblY = new System.Windows.Forms.Label();
            this.TbX = new System.Windows.Forms.TextBox();
            this.LblX = new System.Windows.Forms.Label();
            this.PbImage = new System.Windows.Forms.PictureBox();
            this.PnControlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PnControlHeader
            // 
            this.PnControlHeader.Controls.Add(this.TbZoom);
            this.PnControlHeader.Controls.Add(this.LblZoom);
            this.PnControlHeader.Controls.Add(this.TbY);
            this.PnControlHeader.Controls.Add(this.LblY);
            this.PnControlHeader.Controls.Add(this.TbX);
            this.PnControlHeader.Controls.Add(this.LblX);
            this.PnControlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnControlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnControlHeader.Name = "PnControlHeader";
            this.PnControlHeader.Padding = new System.Windows.Forms.Padding(4);
            this.PnControlHeader.Size = new System.Drawing.Size(584, 28);
            this.PnControlHeader.TabIndex = 0;
            // 
            // TbZoom
            // 
            this.TbZoom.Dock = System.Windows.Forms.DockStyle.Left;
            this.TbZoom.Location = new System.Drawing.Point(430, 4);
            this.TbZoom.Name = "TbZoom";
            this.TbZoom.Size = new System.Drawing.Size(150, 20);
            this.TbZoom.TabIndex = 5;
            this.TbZoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbZoom.TextChanged += new System.EventHandler(this.TbParameters_TextChanged);
            // 
            // LblZoom
            // 
            this.LblZoom.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblZoom.Location = new System.Drawing.Point(388, 4);
            this.LblZoom.Name = "LblZoom";
            this.LblZoom.Size = new System.Drawing.Size(42, 20);
            this.LblZoom.TabIndex = 4;
            this.LblZoom.Text = "Zoom:";
            this.LblZoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbY
            // 
            this.TbY.Dock = System.Windows.Forms.DockStyle.Left;
            this.TbY.Location = new System.Drawing.Point(238, 4);
            this.TbY.Name = "TbY";
            this.TbY.Size = new System.Drawing.Size(150, 20);
            this.TbY.TabIndex = 3;
            this.TbY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbY.TextChanged += new System.EventHandler(this.TbParameters_TextChanged);
            // 
            // LblY
            // 
            this.LblY.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblY.Location = new System.Drawing.Point(196, 4);
            this.LblY.Name = "LblY";
            this.LblY.Size = new System.Drawing.Size(42, 20);
            this.LblY.TabIndex = 2;
            this.LblY.Text = "Y:";
            this.LblY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbX
            // 
            this.TbX.Dock = System.Windows.Forms.DockStyle.Left;
            this.TbX.Location = new System.Drawing.Point(46, 4);
            this.TbX.Name = "TbX";
            this.TbX.Size = new System.Drawing.Size(150, 20);
            this.TbX.TabIndex = 1;
            this.TbX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbX.TextChanged += new System.EventHandler(this.TbParameters_TextChanged);
            // 
            // LblX
            // 
            this.LblX.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblX.Location = new System.Drawing.Point(4, 4);
            this.LblX.Name = "LblX";
            this.LblX.Size = new System.Drawing.Size(42, 20);
            this.LblX.TabIndex = 0;
            this.LblX.Text = "X:";
            this.LblX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PbImage
            // 
            this.PbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbImage.Location = new System.Drawing.Point(0, 28);
            this.PbImage.Name = "PbImage";
            this.PbImage.Size = new System.Drawing.Size(584, 383);
            this.PbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbImage.TabIndex = 1;
            this.PbImage.TabStop = false;
            this.PbImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbImage_MouseDown);
            this.PbImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbImage_MouseMove);
            this.PbImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbImage_MouseUp);
            // 
            // MandelbrotMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.PbImage);
            this.Controls.Add(this.PnControlHeader);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "MandelbrotMainForm";
            this.Text = "Fraktale Mandelbrotta";
            this.Resize += new System.EventHandler(this.MandelbrotMainForm_Resize);
            this.PnControlHeader.ResumeLayout(false);
            this.PnControlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnControlHeader;
        private System.Windows.Forms.TextBox TbZoom;
        private System.Windows.Forms.Label LblZoom;
        private System.Windows.Forms.TextBox TbY;
        private System.Windows.Forms.Label LblY;
        private System.Windows.Forms.TextBox TbX;
        private System.Windows.Forms.Label LblX;
        private System.Windows.Forms.PictureBox PbImage;
    }
}

