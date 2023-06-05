namespace MandelbrotTest
{
    partial class MandelbrotForm
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
            this.CbUse = new System.Windows.Forms.ComboBox();
            this.LbUse = new System.Windows.Forms.Label();
            this.EdZoom = new System.Windows.Forms.TextBox();
            this.LbZoom = new System.Windows.Forms.Label();
            this.EdIm = new System.Windows.Forms.TextBox();
            this.LbIm = new System.Windows.Forms.Label();
            this.EdRe = new System.Windows.Forms.TextBox();
            this.LbRe = new System.Windows.Forms.Label();
            this.Box = new System.Windows.Forms.PictureBox();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.Control;
            this.Header.Controls.Add(this.CbUse);
            this.Header.Controls.Add(this.LbUse);
            this.Header.Controls.Add(this.EdZoom);
            this.Header.Controls.Add(this.LbZoom);
            this.Header.Controls.Add(this.EdIm);
            this.Header.Controls.Add(this.LbIm);
            this.Header.Controls.Add(this.EdRe);
            this.Header.Controls.Add(this.LbRe);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Padding = new System.Windows.Forms.Padding(4);
            this.Header.Size = new System.Drawing.Size(907, 28);
            this.Header.TabIndex = 0;
            // 
            // CbUse
            // 
            this.CbUse.Dock = System.Windows.Forms.DockStyle.Left;
            this.CbUse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbUse.FormattingEnabled = true;
            this.CbUse.Location = new System.Drawing.Point(662, 4);
            this.CbUse.Name = "CbUse";
            this.CbUse.Size = new System.Drawing.Size(121, 21);
            this.CbUse.TabIndex = 8;
            this.CbUse.SelectedIndexChanged += new System.EventHandler(this.CbUse_SelectedIndexChanged);
            // 
            // LbUse
            // 
            this.LbUse.Dock = System.Windows.Forms.DockStyle.Left;
            this.LbUse.Location = new System.Drawing.Point(584, 4);
            this.LbUse.Name = "LbUse";
            this.LbUse.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.LbUse.Size = new System.Drawing.Size(78, 20);
            this.LbUse.TabIndex = 7;
            this.LbUse.Text = "Use thread:";
            this.LbUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EdZoom
            // 
            this.EdZoom.Dock = System.Windows.Forms.DockStyle.Left;
            this.EdZoom.Location = new System.Drawing.Point(434, 4);
            this.EdZoom.Name = "EdZoom";
            this.EdZoom.Size = new System.Drawing.Size(150, 20);
            this.EdZoom.TabIndex = 5;
            this.EdZoom.TextChanged += new System.EventHandler(this.EdValues_TextChanged);
            // 
            // LbZoom
            // 
            this.LbZoom.Dock = System.Windows.Forms.DockStyle.Left;
            this.LbZoom.Location = new System.Drawing.Point(381, 4);
            this.LbZoom.Name = "LbZoom";
            this.LbZoom.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.LbZoom.Size = new System.Drawing.Size(53, 20);
            this.LbZoom.TabIndex = 4;
            this.LbZoom.Text = "Zoom:";
            this.LbZoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EdIm
            // 
            this.EdIm.Dock = System.Windows.Forms.DockStyle.Left;
            this.EdIm.Location = new System.Drawing.Point(231, 4);
            this.EdIm.Name = "EdIm";
            this.EdIm.Size = new System.Drawing.Size(150, 20);
            this.EdIm.TabIndex = 3;
            this.EdIm.TextChanged += new System.EventHandler(this.EdValues_TextChanged);
            // 
            // LbIm
            // 
            this.LbIm.Dock = System.Windows.Forms.DockStyle.Left;
            this.LbIm.Location = new System.Drawing.Point(194, 4);
            this.LbIm.Name = "LbIm";
            this.LbIm.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.LbIm.Size = new System.Drawing.Size(37, 20);
            this.LbIm.TabIndex = 2;
            this.LbIm.Text = "Im:";
            this.LbIm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EdRe
            // 
            this.EdRe.Dock = System.Windows.Forms.DockStyle.Left;
            this.EdRe.Location = new System.Drawing.Point(44, 4);
            this.EdRe.Name = "EdRe";
            this.EdRe.Size = new System.Drawing.Size(150, 20);
            this.EdRe.TabIndex = 1;
            this.EdRe.TextChanged += new System.EventHandler(this.EdValues_TextChanged);
            // 
            // LbRe
            // 
            this.LbRe.Dock = System.Windows.Forms.DockStyle.Left;
            this.LbRe.Location = new System.Drawing.Point(4, 4);
            this.LbRe.Name = "LbRe";
            this.LbRe.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.LbRe.Size = new System.Drawing.Size(40, 20);
            this.LbRe.TabIndex = 0;
            this.LbRe.Text = "Re:";
            this.LbRe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Box
            // 
            this.Box.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box.Location = new System.Drawing.Point(0, 28);
            this.Box.Margin = new System.Windows.Forms.Padding(0);
            this.Box.Name = "Box";
            this.Box.Padding = new System.Windows.Forms.Padding(2);
            this.Box.Size = new System.Drawing.Size(907, 448);
            this.Box.TabIndex = 1;
            this.Box.TabStop = false;
            this.Box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Box_MouseDown);
            this.Box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Box_MouseMove);
            this.Box.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Box_MouseUp);
            this.Box.Resize += new System.EventHandler(this.Box_Resize);
            // 
            // MandelbrotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(907, 476);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.Header);
            this.Name = "MandelbrotForm";
            this.Text = "Fraktale Mandelbrota ...";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.TextBox EdZoom;
        private System.Windows.Forms.Label LbZoom;
        private System.Windows.Forms.TextBox EdIm;
        private System.Windows.Forms.Label LbIm;
        private System.Windows.Forms.TextBox EdRe;
        private System.Windows.Forms.Label LbRe;
        private System.Windows.Forms.PictureBox Box;
        private System.Windows.Forms.ComboBox CbUse;
        private System.Windows.Forms.Label LbUse;
    }
}

