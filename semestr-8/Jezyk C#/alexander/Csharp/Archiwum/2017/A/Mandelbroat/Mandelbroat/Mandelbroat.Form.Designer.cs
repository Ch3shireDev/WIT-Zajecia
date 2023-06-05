namespace Mandelbroat
{
    partial class MandelbroatForm
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
            this.EdY = new System.Windows.Forms.TextBox();
            this.LbY = new System.Windows.Forms.Label();
            this.EdX = new System.Windows.Forms.TextBox();
            this.LbX = new System.Windows.Forms.Label();
            this.Box = new System.Windows.Forms.PictureBox();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
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
            this.Header.Size = new System.Drawing.Size(496, 32);
            this.Header.TabIndex = 0;
            // 
            // EdZoom
            // 
            this.EdZoom.Location = new System.Drawing.Point(333, 6);
            this.EdZoom.Name = "EdZoom";
            this.EdZoom.Size = new System.Drawing.Size(112, 20);
            this.EdZoom.TabIndex = 5;
            this.EdZoom.Text = "1";
            this.EdZoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EdZoom.TextChanged += new System.EventHandler(this.EdData_TextChanged);
            // 
            // LbZoom
            // 
            this.LbZoom.AutoSize = true;
            this.LbZoom.Location = new System.Drawing.Point(293, 9);
            this.LbZoom.Name = "LbZoom";
            this.LbZoom.Size = new System.Drawing.Size(34, 13);
            this.LbZoom.TabIndex = 4;
            this.LbZoom.Text = "Zoom";
            // 
            // EdY
            // 
            this.EdY.Location = new System.Drawing.Point(173, 6);
            this.EdY.Name = "EdY";
            this.EdY.Size = new System.Drawing.Size(112, 20);
            this.EdY.TabIndex = 3;
            this.EdY.Text = "-2";
            this.EdY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EdY.TextChanged += new System.EventHandler(this.EdData_TextChanged);
            // 
            // LbY
            // 
            this.LbY.AutoSize = true;
            this.LbY.Location = new System.Drawing.Point(153, 9);
            this.LbY.Name = "LbY";
            this.LbY.Size = new System.Drawing.Size(14, 13);
            this.LbY.TabIndex = 2;
            this.LbY.Text = "Y";
            // 
            // EdX
            // 
            this.EdX.Location = new System.Drawing.Point(32, 6);
            this.EdX.Name = "EdX";
            this.EdX.Size = new System.Drawing.Size(112, 20);
            this.EdX.TabIndex = 1;
            this.EdX.Text = "-2";
            this.EdX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EdX.TextChanged += new System.EventHandler(this.EdData_TextChanged);
            // 
            // LbX
            // 
            this.LbX.AutoSize = true;
            this.LbX.Location = new System.Drawing.Point(12, 9);
            this.LbX.Name = "LbX";
            this.LbX.Size = new System.Drawing.Size(14, 13);
            this.LbX.TabIndex = 0;
            this.LbX.Text = "X";
            // 
            // Box
            // 
            this.Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box.Location = new System.Drawing.Point(0, 32);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(496, 372);
            this.Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Box.TabIndex = 1;
            this.Box.TabStop = false;
            this.Box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Box_MouseDown);
            // 
            // MandelbroatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 404);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.Header);
            this.Name = "MandelbroatForm";
            this.Text = "Fraktale Mandelbrot\'a ...";
            this.Resize += new System.EventHandler(this.MandelbroatForm_Resize);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
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
        private System.Windows.Forms.PictureBox Box;
    }
}

