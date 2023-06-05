namespace UlamClustersTest
{
    partial class UlamClusterForm
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
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.PnlClient = new System.Windows.Forms.Panel();
            this.PbImage = new System.Windows.Forms.PictureBox();
            this.EdCount = new System.Windows.Forms.TextBox();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.PnlHeader.SuspendLayout();
            this.PnlClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlHeader
            // 
            this.PnlHeader.Controls.Add(this.BtnDraw);
            this.PnlHeader.Controls.Add(this.EdCount);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(678, 42);
            this.PnlHeader.TabIndex = 0;
            // 
            // PnlClient
            // 
            this.PnlClient.AutoScroll = true;
            this.PnlClient.Controls.Add(this.PbImage);
            this.PnlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlClient.Location = new System.Drawing.Point(0, 42);
            this.PnlClient.Name = "PnlClient";
            this.PnlClient.Padding = new System.Windows.Forms.Padding(4);
            this.PnlClient.Size = new System.Drawing.Size(678, 343);
            this.PnlClient.TabIndex = 1;
            // 
            // PbImage
            // 
            this.PbImage.Location = new System.Drawing.Point(4, 4);
            this.PbImage.Name = "PbImage";
            this.PbImage.Size = new System.Drawing.Size(100, 50);
            this.PbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbImage.TabIndex = 0;
            this.PbImage.TabStop = false;
            // 
            // EdCount
            // 
            this.EdCount.Location = new System.Drawing.Point(12, 12);
            this.EdCount.Name = "EdCount";
            this.EdCount.Size = new System.Drawing.Size(100, 20);
            this.EdCount.TabIndex = 0;
            this.EdCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EdCount.TextChanged += new System.EventHandler(this.EdCount_TextChanged);
            // 
            // BtnDraw
            // 
            this.BtnDraw.Location = new System.Drawing.Point(591, 10);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(75, 23);
            this.BtnDraw.TabIndex = 1;
            this.BtnDraw.Text = "Draw";
            this.BtnDraw.UseVisualStyleBackColor = true;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // UlamClusterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 385);
            this.Controls.Add(this.PnlClient);
            this.Controls.Add(this.PnlHeader);
            this.Name = "UlamClusterForm";
            this.Text = "Ulam Clusters";
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            this.PnlClient.ResumeLayout(false);
            this.PnlClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.TextBox EdCount;
        private System.Windows.Forms.Panel PnlClient;
        private System.Windows.Forms.PictureBox PbImage;
    }
}

