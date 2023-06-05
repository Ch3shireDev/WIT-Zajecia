namespace Frac
{
    partial class Frac
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
            this.EYmax = new System.Windows.Forms.TextBox();
            this.EXmax = new System.Windows.Forms.TextBox();
            this.EYmin = new System.Windows.Forms.TextBox();
            this.EXmin = new System.Windows.Forms.TextBox();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.Work = new System.ComponentModel.BackgroundWorker();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
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
            // EYmax
            // 
            this.EYmax.Location = new System.Drawing.Point(321, 13);
            this.EYmax.Name = "EYmax";
            this.EYmax.Size = new System.Drawing.Size(100, 20);
            this.EYmax.TabIndex = 3;
            this.EYmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EYmax.TextChanged += new System.EventHandler(this.EVal_TextChanged);
            // 
            // EXmax
            // 
            this.EXmax.Location = new System.Drawing.Point(215, 13);
            this.EXmax.Name = "EXmax";
            this.EXmax.Size = new System.Drawing.Size(100, 20);
            this.EXmax.TabIndex = 2;
            this.EXmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EXmax.TextChanged += new System.EventHandler(this.EVal_TextChanged);
            // 
            // EYmin
            // 
            this.EYmin.Location = new System.Drawing.Point(109, 13);
            this.EYmin.Name = "EYmin";
            this.EYmin.Size = new System.Drawing.Size(100, 20);
            this.EYmin.TabIndex = 1;
            this.EYmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EYmin.TextChanged += new System.EventHandler(this.EVal_TextChanged);
            // 
            // EXmin
            // 
            this.EXmin.Location = new System.Drawing.Point(3, 13);
            this.EXmin.Name = "EXmin";
            this.EXmin.Size = new System.Drawing.Size(100, 20);
            this.EXmin.TabIndex = 0;
            this.EXmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EXmin.TextChanged += new System.EventHandler(this.EVal_TextChanged);
            // 
            // Pic
            // 
            this.Pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pic.Location = new System.Drawing.Point(0, 39);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(717, 326);
            this.Pic.TabIndex = 1;
            this.Pic.TabStop = false;
            this.Pic.Click += new System.EventHandler(this.Pic_Click);
            this.Pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseDown);
            // 
            // Work
            // 
            this.Work.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Work_DoWork);
            this.Work.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Work_RunWorkerCompleted);
            // 
            // Frac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 365);
            this.Controls.Add(this.Pic);
            this.Controls.Add(this.Header);
            this.Name = "Frac";
            this.Text = "MandelBrott";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frac_FormClosing);
            this.Resize += new System.EventHandler(this.Frac_Resize);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox Pic;
        private System.ComponentModel.BackgroundWorker Work;
        private System.Windows.Forms.TextBox EYmax;
        private System.Windows.Forms.TextBox EXmax;
        private System.Windows.Forms.TextBox EYmin;
        private System.Windows.Forms.TextBox EXmin;
    }
}

