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
            this.ImgPicture = new System.Windows.Forms.PictureBox();
            this.PnlClient = new System.Windows.Forms.Panel();
            this.EdGivename = new System.Windows.Forms.TextBox();
            this.EdSurname = new System.Windows.Forms.TextBox();
            this.DlgOpen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPicture)).BeginInit();
            this.PnlClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImgPicture
            // 
            this.ImgPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.ImgPicture.Location = new System.Drawing.Point(0, 0);
            this.ImgPicture.Name = "ImgPicture";
            this.ImgPicture.Size = new System.Drawing.Size(100, 83);
            this.ImgPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgPicture.TabIndex = 0;
            this.ImgPicture.TabStop = false;
            this.ImgPicture.DoubleClick += new System.EventHandler(this.ImgPicture_DoubleClick);
            // 
            // PnlClient
            // 
            this.PnlClient.Controls.Add(this.EdSurname);
            this.PnlClient.Controls.Add(this.EdGivename);
            this.PnlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlClient.Location = new System.Drawing.Point(100, 0);
            this.PnlClient.Name = "PnlClient";
            this.PnlClient.Padding = new System.Windows.Forms.Padding(8);
            this.PnlClient.Size = new System.Drawing.Size(295, 83);
            this.PnlClient.TabIndex = 1;
            // 
            // EdGivename
            // 
            this.EdGivename.Dock = System.Windows.Forms.DockStyle.Top;
            this.EdGivename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdGivename.Location = new System.Drawing.Point(8, 8);
            this.EdGivename.Name = "EdGivename";
            this.EdGivename.Size = new System.Drawing.Size(279, 29);
            this.EdGivename.TabIndex = 0;
            // 
            // EdSurname
            // 
            this.EdSurname.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EdSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdSurname.Location = new System.Drawing.Point(8, 46);
            this.EdSurname.Name = "EdSurname";
            this.EdSurname.Size = new System.Drawing.Size(279, 29);
            this.EdSurname.TabIndex = 1;
            // 
            // DlgOpen
            // 
            this.DlgOpen.FileName = "DataPic*.bmp";
            this.DlgOpen.Filter = "BMP files (*.bmp)|*.bmp|All images (*.bmp;*.jpg)|*.bmp;*.jpg";
            this.DlgOpen.InitialDirectory = "P:\\Barski\\Csharp";
            this.DlgOpen.Title = "Please select picture";
            // 
            // PersonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.PnlClient);
            this.Controls.Add(this.ImgPicture);
            this.Name = "PersonControl";
            this.Size = new System.Drawing.Size(395, 83);
            this.Resize += new System.EventHandler(this.PersonControl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ImgPicture)).EndInit();
            this.PnlClient.ResumeLayout(false);
            this.PnlClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgPicture;
        private System.Windows.Forms.Panel PnlClient;
        private System.Windows.Forms.TextBox EdSurname;
        private System.Windows.Forms.TextBox EdGivename;
        private System.Windows.Forms.OpenFileDialog DlgOpen;
    }
}
