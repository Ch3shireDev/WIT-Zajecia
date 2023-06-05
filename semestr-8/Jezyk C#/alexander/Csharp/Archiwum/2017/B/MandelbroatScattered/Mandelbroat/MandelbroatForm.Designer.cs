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
            this.Box = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.Panel();
            this.BtnServers = new System.Windows.Forms.Button();
            this.EdZoom = new System.Windows.Forms.TextBox();
            this.LbZoom = new System.Windows.Forms.Label();
            this.EdTp = new System.Windows.Forms.TextBox();
            this.LbTp = new System.Windows.Forms.Label();
            this.EdLf = new System.Windows.Forms.TextBox();
            this.LbLf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box.Location = new System.Drawing.Point(0, 32);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(600, 458);
            this.Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Box.TabIndex = 3;
            this.Box.TabStop = false;
            this.Box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Box_MouseDown);
            // 
            // Header
            // 
            this.Header.Controls.Add(this.BtnServers);
            this.Header.Controls.Add(this.EdZoom);
            this.Header.Controls.Add(this.LbZoom);
            this.Header.Controls.Add(this.EdTp);
            this.Header.Controls.Add(this.LbTp);
            this.Header.Controls.Add(this.EdLf);
            this.Header.Controls.Add(this.LbLf);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(600, 32);
            this.Header.TabIndex = 2;
            // 
            // BtnServers
            // 
            this.BtnServers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnServers.Location = new System.Drawing.Point(513, 3);
            this.BtnServers.Name = "BtnServers";
            this.BtnServers.Size = new System.Drawing.Size(75, 23);
            this.BtnServers.TabIndex = 6;
            this.BtnServers.Text = "Servers";
            this.BtnServers.UseVisualStyleBackColor = true;
            this.BtnServers.Click += new System.EventHandler(this.BtnServers_Click);
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
            // EdTp
            // 
            this.EdTp.Location = new System.Drawing.Point(173, 6);
            this.EdTp.Name = "EdTp";
            this.EdTp.Size = new System.Drawing.Size(112, 20);
            this.EdTp.TabIndex = 3;
            this.EdTp.Text = "1";
            this.EdTp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EdTp.TextChanged += new System.EventHandler(this.EdData_TextChanged);
            // 
            // LbTp
            // 
            this.LbTp.AutoSize = true;
            this.LbTp.Location = new System.Drawing.Point(153, 9);
            this.LbTp.Name = "LbTp";
            this.LbTp.Size = new System.Drawing.Size(14, 13);
            this.LbTp.TabIndex = 2;
            this.LbTp.Text = "Y";
            // 
            // EdLf
            // 
            this.EdLf.Location = new System.Drawing.Point(32, 6);
            this.EdLf.Name = "EdLf";
            this.EdLf.Size = new System.Drawing.Size(112, 20);
            this.EdLf.TabIndex = 1;
            this.EdLf.Text = "-2";
            this.EdLf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EdLf.TextChanged += new System.EventHandler(this.EdData_TextChanged);
            // 
            // LbLf
            // 
            this.LbLf.AutoSize = true;
            this.LbLf.Location = new System.Drawing.Point(12, 9);
            this.LbLf.Name = "LbLf";
            this.LbLf.Size = new System.Drawing.Size(14, 13);
            this.LbLf.TabIndex = 0;
            this.LbLf.Text = "X";
            // 
            // MandelbroatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 490);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.Header);
            this.Name = "MandelbroatForm";
            this.Text = "Fraktale Mandelbrota ...";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MandelbroatForm_FormClosed);
            this.Resize += new System.EventHandler(this.MandelbroatForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Box;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.TextBox EdZoom;
        private System.Windows.Forms.Label LbZoom;
        private System.Windows.Forms.TextBox EdTp;
        private System.Windows.Forms.Label LbTp;
        private System.Windows.Forms.TextBox EdLf;
        private System.Windows.Forms.Label LbLf;
        private System.Windows.Forms.Button BtnServers;
    }
}

