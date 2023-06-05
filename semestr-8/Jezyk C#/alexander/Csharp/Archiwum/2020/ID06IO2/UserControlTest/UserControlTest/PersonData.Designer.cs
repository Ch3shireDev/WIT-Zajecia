namespace UserControlTest
{
    partial class PersonData
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
            this.EdSurname = new System.Windows.Forms.TextBox();
            this.EdName = new System.Windows.Forms.TextBox();
            this.EdPicture = new System.Windows.Forms.PictureBox();
            this.DlgOpen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.EdPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // EdSurname
            // 
            this.EdSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdSurname.Location = new System.Drawing.Point(110, 3);
            this.EdSurname.Name = "EdSurname";
            this.EdSurname.Size = new System.Drawing.Size(305, 26);
            this.EdSurname.TabIndex = 0;
            // 
            // EdName
            // 
            this.EdName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdName.Location = new System.Drawing.Point(107, 62);
            this.EdName.Name = "EdName";
            this.EdName.Size = new System.Drawing.Size(308, 26);
            this.EdName.TabIndex = 1;
            // 
            // EdPicture
            // 
            this.EdPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EdPicture.BackColor = System.Drawing.SystemColors.Control;
            this.EdPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EdPicture.Location = new System.Drawing.Point(3, 3);
            this.EdPicture.Name = "EdPicture";
            this.EdPicture.Size = new System.Drawing.Size(101, 85);
            this.EdPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EdPicture.TabIndex = 2;
            this.EdPicture.TabStop = false;
            this.EdPicture.DoubleClick += new System.EventHandler(this.EdPicture_DoubleClick);
            // 
            // DlgOpen
            // 
            this.DlgOpen.DefaultExt = "*.bmp";
            this.DlgOpen.FileName = "Data*";
            this.DlgOpen.Filter = "Bitmap file *.bmp|*.bmp|All files *.*|*.*";
            this.DlgOpen.InitialDirectory = "P:\\Barski\\Csharp";
            this.DlgOpen.Title = "Wskaź Obrazek";
            // 
            // PersonData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EdPicture);
            this.Controls.Add(this.EdName);
            this.Controls.Add(this.EdSurname);
            this.Size = new System.Drawing.Size(418, 91);
            this.Resize += new System.EventHandler(this.PersonData_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.EdPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EdSurname;
        private System.Windows.Forms.TextBox EdName;
        private System.Windows.Forms.PictureBox EdPicture;
        private System.Windows.Forms.OpenFileDialog DlgOpen;
    }
}
