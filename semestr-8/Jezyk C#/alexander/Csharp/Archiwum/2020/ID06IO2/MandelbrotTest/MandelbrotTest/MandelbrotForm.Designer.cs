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
            this.components = new System.ComponentModel.Container();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.EdZoom = new System.Windows.Forms.TextBox();
            this.EdY = new System.Windows.Forms.TextBox();
            this.EdX = new System.Windows.Forms.TextBox();
            this.PnlClient = new System.Windows.Forms.Panel();
            this.PicManbelbroat = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PnlHeader.SuspendLayout();
            this.PnlClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicManbelbroat)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlHeader
            // 
            this.PnlHeader.Controls.Add(this.EdZoom);
            this.PnlHeader.Controls.Add(this.EdY);
            this.PnlHeader.Controls.Add(this.EdX);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(705, 44);
            this.PnlHeader.TabIndex = 0;
            // 
            // EdZoom
            // 
            this.EdZoom.Location = new System.Drawing.Point(296, 12);
            this.EdZoom.Name = "EdZoom";
            this.EdZoom.Size = new System.Drawing.Size(136, 20);
            this.EdZoom.TabIndex = 2;
            this.EdZoom.TextChanged += new System.EventHandler(this.Ed_TextChanged);
            // 
            // EdY
            // 
            this.EdY.Location = new System.Drawing.Point(154, 12);
            this.EdY.Name = "EdY";
            this.EdY.Size = new System.Drawing.Size(136, 20);
            this.EdY.TabIndex = 1;
            this.EdY.TextChanged += new System.EventHandler(this.Ed_TextChanged);
            // 
            // EdX
            // 
            this.EdX.Location = new System.Drawing.Point(12, 12);
            this.EdX.Name = "EdX";
            this.EdX.Size = new System.Drawing.Size(136, 20);
            this.EdX.TabIndex = 0;
            this.EdX.TextChanged += new System.EventHandler(this.Ed_TextChanged);
            // 
            // PnlClient
            // 
            this.PnlClient.Controls.Add(this.PicManbelbroat);
            this.PnlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlClient.Location = new System.Drawing.Point(0, 44);
            this.PnlClient.Name = "PnlClient";
            this.PnlClient.Size = new System.Drawing.Size(705, 325);
            this.PnlClient.TabIndex = 1;
            this.PnlClient.Resize += new System.EventHandler(this.PnlClient_Resize);
            // 
            // PicManbelbroat
            // 
            this.PicManbelbroat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicManbelbroat.Location = new System.Drawing.Point(0, 0);
            this.PicManbelbroat.Name = "PicManbelbroat";
            this.PicManbelbroat.Size = new System.Drawing.Size(705, 325);
            this.PicManbelbroat.TabIndex = 0;
            this.PicManbelbroat.TabStop = false;
            this.PicManbelbroat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicManbelbroat_MouseDown);
            this.PicManbelbroat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicManbelbroat_MouseMove);
            this.PicManbelbroat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicManbelbroat_MouseUp);
            // 
            // MandelbrotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 369);
            this.Controls.Add(this.PnlClient);
            this.Controls.Add(this.PnlHeader);
            this.Name = "MandelbrotForm";
            this.Text = "Fraktale Mandelbrota";
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            this.PnlClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicManbelbroat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.TextBox EdZoom;
        private System.Windows.Forms.TextBox EdY;
        private System.Windows.Forms.TextBox EdX;
        private System.Windows.Forms.Panel PnlClient;
        private System.Windows.Forms.PictureBox PicManbelbroat;
        private System.Windows.Forms.Timer timer1;
    }
}

