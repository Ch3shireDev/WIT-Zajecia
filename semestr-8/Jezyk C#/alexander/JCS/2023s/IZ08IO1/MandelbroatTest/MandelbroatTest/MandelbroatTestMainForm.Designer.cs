namespace MandelbroatTest
{
    partial class MandelbroatTestMainForm
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
            this.PnHeader = new System.Windows.Forms.Panel();
            this.LblX = new System.Windows.Forms.Label();
            this.TbX = new System.Windows.Forms.TextBox();
            this.TbY = new System.Windows.Forms.TextBox();
            this.LblY = new System.Windows.Forms.Label();
            this.TbZoom = new System.Windows.Forms.TextBox();
            this.LblZoom = new System.Windows.Forms.Label();
            this.PbImage = new System.Windows.Forms.PictureBox();
            this.PnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PnHeader
            // 
            this.PnHeader.Controls.Add(this.TbZoom);
            this.PnHeader.Controls.Add(this.LblZoom);
            this.PnHeader.Controls.Add(this.TbY);
            this.PnHeader.Controls.Add(this.LblY);
            this.PnHeader.Controls.Add(this.TbX);
            this.PnHeader.Controls.Add(this.LblX);
            this.PnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnHeader.Location = new System.Drawing.Point(0, 0);
            this.PnHeader.Name = "PnHeader";
            this.PnHeader.Padding = new System.Windows.Forms.Padding(4);
            this.PnHeader.Size = new System.Drawing.Size(918, 28);
            this.PnHeader.TabIndex = 0;
            // 
            // LblX
            // 
            this.LblX.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblX.Location = new System.Drawing.Point(4, 4);
            this.LblX.Name = "LblX";
            this.LblX.Size = new System.Drawing.Size(52, 20);
            this.LblX.TabIndex = 0;
            this.LblX.Text = "X:";
            this.LblX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbX
            // 
            this.TbX.Dock = System.Windows.Forms.DockStyle.Left;
            this.TbX.Location = new System.Drawing.Point(56, 4);
            this.TbX.Name = "TbX";
            this.TbX.Size = new System.Drawing.Size(172, 20);
            this.TbX.TabIndex = 1;
            this.TbX.Text = "-2";
            this.TbX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbX.TextChanged += new System.EventHandler(this.TbXYZoom_TextChanged);
            // 
            // TbY
            // 
            this.TbY.Dock = System.Windows.Forms.DockStyle.Left;
            this.TbY.Location = new System.Drawing.Point(280, 4);
            this.TbY.Name = "TbY";
            this.TbY.Size = new System.Drawing.Size(172, 20);
            this.TbY.TabIndex = 3;
            this.TbY.Text = "1";
            this.TbY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbY.TextChanged += new System.EventHandler(this.TbXYZoom_TextChanged);
            // 
            // LblY
            // 
            this.LblY.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblY.Location = new System.Drawing.Point(228, 4);
            this.LblY.Name = "LblY";
            this.LblY.Size = new System.Drawing.Size(52, 20);
            this.LblY.TabIndex = 2;
            this.LblY.Text = "Y:";
            this.LblY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbZoom
            // 
            this.TbZoom.Dock = System.Windows.Forms.DockStyle.Left;
            this.TbZoom.Location = new System.Drawing.Point(504, 4);
            this.TbZoom.Name = "TbZoom";
            this.TbZoom.Size = new System.Drawing.Size(172, 20);
            this.TbZoom.TabIndex = 5;
            this.TbZoom.Text = "1";
            this.TbZoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbZoom.TextChanged += new System.EventHandler(this.TbXYZoom_TextChanged);
            // 
            // LblZoom
            // 
            this.LblZoom.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblZoom.Location = new System.Drawing.Point(452, 4);
            this.LblZoom.Name = "LblZoom";
            this.LblZoom.Size = new System.Drawing.Size(52, 20);
            this.LblZoom.TabIndex = 4;
            this.LblZoom.Text = "zoom:";
            this.LblZoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PbImage
            // 
            this.PbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbImage.Location = new System.Drawing.Point(0, 28);
            this.PbImage.Name = "PbImage";
            this.PbImage.Size = new System.Drawing.Size(918, 411);
            this.PbImage.TabIndex = 1;
            this.PbImage.TabStop = false;
            // 
            // MandelbroatTestMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 439);
            this.Controls.Add(this.PbImage);
            this.Controls.Add(this.PnHeader);
            this.Name = "MandelbroatTestMainForm";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.MandelbroatTestMainForm_Resize);
            this.PnHeader.ResumeLayout(false);
            this.PnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnHeader;
        private System.Windows.Forms.TextBox TbZoom;
        private System.Windows.Forms.Label LblZoom;
        private System.Windows.Forms.TextBox TbY;
        private System.Windows.Forms.Label LblY;
        private System.Windows.Forms.TextBox TbX;
        private System.Windows.Forms.Label LblX;
        private System.Windows.Forms.PictureBox PbImage;
    }
}

