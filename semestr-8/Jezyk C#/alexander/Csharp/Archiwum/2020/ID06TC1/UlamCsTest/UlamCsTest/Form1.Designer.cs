namespace UlamCsTest
{
    partial class Form1
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
            this.PnlScroll = new System.Windows.Forms.Panel();
            this.PbUlam = new System.Windows.Forms.PictureBox();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.EdCount = new System.Windows.Forms.TextBox();
            this.PnlScroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbUlam)).BeginInit();
            this.PnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlScroll
            // 
            this.PnlScroll.AutoScroll = true;
            this.PnlScroll.Controls.Add(this.PbUlam);
            this.PnlScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlScroll.Location = new System.Drawing.Point(0, 44);
            this.PnlScroll.Name = "PnlScroll";
            this.PnlScroll.Padding = new System.Windows.Forms.Padding(4);
            this.PnlScroll.Size = new System.Drawing.Size(744, 433);
            this.PnlScroll.TabIndex = 3;
            // 
            // PbUlam
            // 
            this.PbUlam.Location = new System.Drawing.Point(4, 4);
            this.PbUlam.Name = "PbUlam";
            this.PbUlam.Size = new System.Drawing.Size(100, 50);
            this.PbUlam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbUlam.TabIndex = 0;
            this.PbUlam.TabStop = false;
            // 
            // PnlHeader
            // 
            this.PnlHeader.Controls.Add(this.BtnDraw);
            this.PnlHeader.Controls.Add(this.EdCount);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(744, 44);
            this.PnlHeader.TabIndex = 2;
            // 
            // BtnDraw
            // 
            this.BtnDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDraw.Location = new System.Drawing.Point(657, 10);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(75, 23);
            this.BtnDraw.TabIndex = 1;
            this.BtnDraw.Text = "Draw";
            this.BtnDraw.UseVisualStyleBackColor = true;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // EdCount
            // 
            this.EdCount.Location = new System.Drawing.Point(12, 12);
            this.EdCount.Name = "EdCount";
            this.EdCount.Size = new System.Drawing.Size(92, 20);
            this.EdCount.TabIndex = 0;
            this.EdCount.TextChanged += new System.EventHandler(this.EdCount_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 477);
            this.Controls.Add(this.PnlScroll);
            this.Controls.Add(this.PnlHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PnlScroll.ResumeLayout(false);
            this.PnlScroll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbUlam)).EndInit();
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PnlScroll;
        internal System.Windows.Forms.PictureBox PbUlam;
        internal System.Windows.Forms.Panel PnlHeader;
        internal System.Windows.Forms.Button BtnDraw;
        internal System.Windows.Forms.TextBox EdCount;
    }
}

