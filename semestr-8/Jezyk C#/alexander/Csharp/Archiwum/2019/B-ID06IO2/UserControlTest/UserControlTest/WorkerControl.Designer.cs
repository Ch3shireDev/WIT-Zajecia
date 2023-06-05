namespace UserControlTest
{
    partial class WorkerControl
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
            this.Picture = new System.Windows.Forms.PictureBox();
            this.Client = new System.Windows.Forms.Panel();
            this.EdSurname = new System.Windows.Forms.TextBox();
            this.EdName = new System.Windows.Forms.TextBox();
            this.DlgOpen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.Client.SuspendLayout();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.Dock = System.Windows.Forms.DockStyle.Left;
            this.Picture.Location = new System.Drawing.Point(8, 8);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(154, 155);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            this.Picture.DoubleClick += new System.EventHandler(this.Picture_DoubleClick);
            // 
            // Client
            // 
            this.Client.Controls.Add(this.EdSurname);
            this.Client.Controls.Add(this.EdName);
            this.Client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Client.Location = new System.Drawing.Point(162, 8);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(352, 155);
            this.Client.TabIndex = 3;
            this.Client.DoubleClick += new System.EventHandler(this.Client_DoubleClick);
            // 
            // EdSurname
            // 
            this.EdSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdSurname.Location = new System.Drawing.Point(5, 121);
            this.EdSurname.Name = "EdSurname";
            this.EdSurname.Size = new System.Drawing.Size(344, 26);
            this.EdSurname.TabIndex = 4;
            this.EdSurname.DoubleClick += new System.EventHandler(this.Client_DoubleClick);
            // 
            // EdName
            // 
            this.EdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdName.Location = new System.Drawing.Point(6, 15);
            this.EdName.Name = "EdName";
            this.EdName.Size = new System.Drawing.Size(148, 26);
            this.EdName.TabIndex = 3;
            this.EdName.DoubleClick += new System.EventHandler(this.Client_DoubleClick);
            // 
            // DlgOpen
            // 
            this.DlgOpen.FileName = "Picture.bmp";
            this.DlgOpen.Filter = "Pliki BMP (*.bmp)|*.bmp";
            this.DlgOpen.InitialDirectory = "P:\\Barski\\Csharp\\";
            this.DlgOpen.RestoreDirectory = true;
            this.DlgOpen.Title = "Wskaż zdjęcie pracownika ...";
            // 
            // WorkerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Client);
            this.Controls.Add(this.Picture);
            this.Name = "WorkerControl";
            this.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.Size = new System.Drawing.Size(522, 163);
            this.Resize += new System.EventHandler(this.WorkerControl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.Client.ResumeLayout(false);
            this.Client.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Panel Client;
        private System.Windows.Forms.TextBox EdSurname;
        private System.Windows.Forms.TextBox EdName;
        private System.Windows.Forms.OpenFileDialog DlgOpen;
    }
}
