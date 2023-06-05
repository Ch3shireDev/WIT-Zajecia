namespace UserControlTest
{
    partial class PersonControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlPicture = new System.Windows.Forms.Panel();
            this.PnlClient = new System.Windows.Forms.Panel();
            this.ImgPicture = new System.Windows.Forms.PictureBox();
            this.EdGivename = new System.Windows.Forms.TextBox();
            this.EdSurname = new System.Windows.Forms.TextBox();
            this.DlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.PnlPicture.SuspendLayout();
            this.PnlClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlPicture
            // 
            this.PnlPicture.Controls.Add(this.ImgPicture);
            this.PnlPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlPicture.Location = new System.Drawing.Point(0, 0);
            this.PnlPicture.Name = "PnlPicture";
            this.PnlPicture.Padding = new System.Windows.Forms.Padding(4);
            this.PnlPicture.Size = new System.Drawing.Size(106, 94);
            this.PnlPicture.TabIndex = 0;
            // 
            // PnlClient
            // 
            this.PnlClient.Controls.Add(this.EdSurname);
            this.PnlClient.Controls.Add(this.EdGivename);
            this.PnlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlClient.Location = new System.Drawing.Point(106, 0);
            this.PnlClient.Name = "PnlClient";
            this.PnlClient.Padding = new System.Windows.Forms.Padding(4);
            this.PnlClient.Size = new System.Drawing.Size(357, 94);
            this.PnlClient.TabIndex = 1;
            // 
            // ImgPicture
            // 
            this.ImgPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgPicture.Location = new System.Drawing.Point(4, 4);
            this.ImgPicture.Name = "ImgPicture";
            this.ImgPicture.Size = new System.Drawing.Size(98, 86);
            this.ImgPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgPicture.TabIndex = 0;
            this.ImgPicture.TabStop = false;
            this.ImgPicture.Click += new System.EventHandler(this.ImgPicture_Click);
            this.ImgPicture.DoubleClick += new System.EventHandler(this.ImgPicture_DoubleClick);
            // 
            // EdGivename
            // 
            this.EdGivename.Dock = System.Windows.Forms.DockStyle.Top;
            this.EdGivename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdGivename.Location = new System.Drawing.Point(4, 4);
            this.EdGivename.Name = "EdGivename";
            this.EdGivename.Size = new System.Drawing.Size(349, 26);
            this.EdGivename.TabIndex = 0;
            // 
            // EdSurname
            // 
            this.EdSurname.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EdSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdSurname.Location = new System.Drawing.Point(4, 64);
            this.EdSurname.Name = "EdSurname";
            this.EdSurname.Size = new System.Drawing.Size(349, 26);
            this.EdSurname.TabIndex = 1;
            // 
            // DlgOpen
            // 
            this.DlgOpen.FileName = "DataPic*.bmp";
            this.DlgOpen.Filter = "Bitmap files (*.bmp)|*.bmp|All images|*.bmp;*.jpg;*.png";
            this.DlgOpen.InitialDirectory = "P:\\Barski\\Csharp";
            this.DlgOpen.Title = "Select person picture";
            // 
            // PersonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlClient);
            this.Controls.Add(this.PnlPicture);
            this.Name = "PersonControl";
            this.Size = new System.Drawing.Size(463, 94);
            this.Resize += new System.EventHandler(this.PersonControl_Resize);
            this.PnlPicture.ResumeLayout(false);
            this.PnlClient.ResumeLayout(false);
            this.PnlClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPicture;
        private System.Windows.Forms.PictureBox ImgPicture;
        private System.Windows.Forms.Panel PnlClient;
        private System.Windows.Forms.TextBox EdSurname;
        private System.Windows.Forms.TextBox EdGivename;
        private System.Windows.Forms.OpenFileDialog DlgOpen;
    }
}
