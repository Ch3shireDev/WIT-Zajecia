namespace Arcanoid
{
    partial class Arcanoid
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
            this.PnStatus = new System.Windows.Forms.Panel();
            this.PnImage = new System.Windows.Forms.Panel();
            this.PbImage = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.PnImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PnStatus
            // 
            this.PnStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnStatus.Location = new System.Drawing.Point(0, 0);
            this.PnStatus.Name = "PnStatus";
            this.PnStatus.Size = new System.Drawing.Size(1097, 47);
            this.PnStatus.TabIndex = 0;
            // 
            // PnImage
            // 
            this.PnImage.Controls.Add(this.PbImage);
            this.PnImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnImage.Location = new System.Drawing.Point(0, 47);
            this.PnImage.Name = "PnImage";
            this.PnImage.Padding = new System.Windows.Forms.Padding(4);
            this.PnImage.Size = new System.Drawing.Size(1097, 569);
            this.PnImage.TabIndex = 1;
            this.PnImage.Resize += new System.EventHandler(this.PnImage_Resize);
            // 
            // PbImage
            // 
            this.PbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbImage.Location = new System.Drawing.Point(4, 4);
            this.PbImage.Name = "PbImage";
            this.PbImage.Size = new System.Drawing.Size(1089, 561);
            this.PbImage.TabIndex = 0;
            this.PbImage.TabStop = false;
            this.PbImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbImage_MouseDown);
            this.PbImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbImage_MouseMove);
            // 
            // Timer
            // 
            this.Timer.Interval = 20;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Arcanoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 616);
            this.Controls.Add(this.PnImage);
            this.Controls.Add(this.PnStatus);
            this.Name = "Arcanoid";
            this.Text = "Form1";
            this.PnImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnStatus;
        private System.Windows.Forms.Panel PnImage;
        private System.Windows.Forms.PictureBox PbImage;
        private System.Windows.Forms.Timer Timer;
    }
}

