namespace Test011
{
    partial class MandelBrottClientServer
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
            this.Header = new System.Windows.Forms.Panel();
            this.BtnHosts = new System.Windows.Forms.Button();
            this.CPort = new System.Windows.Forms.Label();
            this.EYmax = new System.Windows.Forms.TextBox();
            this.EXmax = new System.Windows.Forms.TextBox();
            this.EYmin = new System.Windows.Forms.TextBox();
            this.EXmin = new System.Windows.Forms.TextBox();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.Box = new System.Windows.Forms.Panel();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.Controls.Add(this.BtnHosts);
            this.Header.Controls.Add(this.CPort);
            this.Header.Controls.Add(this.EYmax);
            this.Header.Controls.Add(this.EXmax);
            this.Header.Controls.Add(this.EYmin);
            this.Header.Controls.Add(this.EXmin);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(717, 39);
            this.Header.TabIndex = 0;
            // 
            // BtnHosts
            // 
            this.BtnHosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnHosts.Location = new System.Drawing.Point(571, 8);
            this.BtnHosts.Name = "BtnHosts";
            this.BtnHosts.Size = new System.Drawing.Size(75, 23);
            this.BtnHosts.TabIndex = 5;
            this.BtnHosts.Text = "Servery";
            this.BtnHosts.UseVisualStyleBackColor = true;
            this.BtnHosts.Click += new System.EventHandler(this.BtnHosts_Click);
            // 
            // CPort
            // 
            this.CPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CPort.AutoSize = true;
            this.CPort.Location = new System.Drawing.Point(652, 13);
            this.CPort.Name = "CPort";
            this.CPort.Size = new System.Drawing.Size(53, 13);
            this.CPort.TabIndex = 4;
            this.CPort.Tag = "";
            this.CPort.Text = "Port 8000";
            // 
            // EYmax
            // 
            this.EYmax.Location = new System.Drawing.Point(326, 13);
            this.EYmax.Name = "EYmax";
            this.EYmax.Size = new System.Drawing.Size(100, 20);
            this.EYmax.TabIndex = 3;
            this.EYmax.Text = "0,552100000";
            this.EYmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EYmax.TextChanged += new System.EventHandler(this.EValue_TextChanged);
            this.EYmax.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EValue_KeySaveAction);
            this.EYmax.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EValue_MouseSaveAction);
            // 
            // EXmax
            // 
            this.EXmax.Location = new System.Drawing.Point(114, 13);
            this.EXmax.Name = "EXmax";
            this.EXmax.Size = new System.Drawing.Size(100, 20);
            this.EXmax.TabIndex = 2;
            this.EXmax.Text = "0,217500";
            this.EXmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EXmax.TextChanged += new System.EventHandler(this.EValue_TextChanged);
            this.EXmax.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EValue_KeySaveAction);
            this.EXmax.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EValue_MouseSaveAction);
            // 
            // EYmin
            // 
            this.EYmin.Location = new System.Drawing.Point(220, 13);
            this.EYmin.Name = "EYmin";
            this.EYmin.Size = new System.Drawing.Size(100, 20);
            this.EYmin.TabIndex = 1;
            this.EYmin.Text = "0,541000000";
            this.EYmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EYmin.TextChanged += new System.EventHandler(this.EValue_TextChanged);
            this.EYmin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EValue_KeySaveAction);
            this.EYmin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EValue_MouseSaveAction);
            // 
            // EXmin
            // 
            this.EXmin.Location = new System.Drawing.Point(8, 13);
            this.EXmin.Name = "EXmin";
            this.EXmin.Size = new System.Drawing.Size(100, 20);
            this.EXmin.TabIndex = 0;
            this.EXmin.Text = "0,201600";
            this.EXmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EXmin.TextChanged += new System.EventHandler(this.EValue_TextChanged);
            this.EXmin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EValue_KeySaveAction);
            this.EXmin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EValue_MouseSaveAction);
            // 
            // Clock
            // 
            this.Clock.Interval = 200;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // Box
            // 
            this.Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box.Location = new System.Drawing.Point(0, 39);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(717, 326);
            this.Box.TabIndex = 2;
            this.Box.Paint += new System.Windows.Forms.PaintEventHandler(this.Box_Paint);
            this.Box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Box_MouseDown);
            this.Box.Resize += new System.EventHandler(this.Box_Resize);
            // 
            // MandelBrottClientServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 365);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.Header);
            this.Name = "MandelBrottClientServer";
            this.Text = "MandelBrott";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MandelBrottServer_FormClosing);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.TextBox EYmax;
        private System.Windows.Forms.TextBox EXmax;
        private System.Windows.Forms.TextBox EYmin;
        private System.Windows.Forms.TextBox EXmin;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Panel Box;
        private System.Windows.Forms.Label CPort;
        private System.Windows.Forms.Button BtnHosts;
    }
}

