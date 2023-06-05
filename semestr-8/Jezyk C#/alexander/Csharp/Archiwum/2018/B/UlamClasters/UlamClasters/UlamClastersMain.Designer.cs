namespace UlamClasters
{
    partial class UlamClastersMain
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
            this.EdCount = new System.Windows.Forms.TextBox();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.Scroll = new System.Windows.Forms.Panel();
            this.Box = new System.Windows.Forms.PictureBox();
            this.Scroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
            this.SuspendLayout();
            // 
            // EdCount
            // 
            this.EdCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EdCount.Location = new System.Drawing.Point(515, 12);
            this.EdCount.Name = "EdCount";
            this.EdCount.Size = new System.Drawing.Size(100, 20);
            this.EdCount.TabIndex = 1;
            this.EdCount.Text = "1024";
            this.EdCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnDraw
            // 
            this.BtnDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDraw.Location = new System.Drawing.Point(515, 38);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(100, 23);
            this.BtnDraw.TabIndex = 2;
            this.BtnDraw.Text = "Rysuj";
            this.BtnDraw.UseVisualStyleBackColor = true;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // Scroll
            // 
            this.Scroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scroll.AutoScroll = true;
            this.Scroll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Scroll.Controls.Add(this.Box);
            this.Scroll.Location = new System.Drawing.Point(12, 12);
            this.Scroll.Name = "Scroll";
            this.Scroll.Padding = new System.Windows.Forms.Padding(4);
            this.Scroll.Size = new System.Drawing.Size(488, 386);
            this.Scroll.TabIndex = 3;
            // 
            // Box
            // 
            this.Box.Location = new System.Drawing.Point(0, 0);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(146, 100);
            this.Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Box.TabIndex = 3;
            this.Box.TabStop = false;
            // 
            // UlamClastersMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 410);
            this.Controls.Add(this.Scroll);
            this.Controls.Add(this.BtnDraw);
            this.Controls.Add(this.EdCount);
            this.Name = "UlamClastersMain";
            this.Text = "Klastery Ulama ...";
            this.Scroll.ResumeLayout(false);
            this.Scroll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EdCount;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.Panel Scroll;
        private System.Windows.Forms.PictureBox Box;
    }
}

