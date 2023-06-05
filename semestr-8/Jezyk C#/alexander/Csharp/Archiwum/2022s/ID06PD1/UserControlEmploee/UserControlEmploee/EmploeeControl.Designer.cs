namespace UserControlEmploee
{
    partial class EmploeeControl
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
            this.PnPicture = new System.Windows.Forms.Panel();
            this.PbPicture = new System.Windows.Forms.PictureBox();
            this.PnData = new System.Windows.Forms.Panel();
            this.TbSurname = new System.Windows.Forms.TextBox();
            this.TbName = new System.Windows.Forms.TextBox();
            this.DlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.PnPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbPicture)).BeginInit();
            this.PnData.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnPicture
            // 
            this.PnPicture.BackColor = System.Drawing.SystemColors.Control;
            this.PnPicture.Controls.Add(this.PbPicture);
            this.PnPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnPicture.Location = new System.Drawing.Point(0, 0);
            this.PnPicture.Name = "PnPicture";
            this.PnPicture.Padding = new System.Windows.Forms.Padding(4);
            this.PnPicture.Size = new System.Drawing.Size(98, 108);
            this.PnPicture.TabIndex = 0;
            // 
            // PbPicture
            // 
            this.PbPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbPicture.Location = new System.Drawing.Point(4, 4);
            this.PbPicture.Name = "PbPicture";
            this.PbPicture.Size = new System.Drawing.Size(90, 100);
            this.PbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbPicture.TabIndex = 0;
            this.PbPicture.TabStop = false;
            this.PbPicture.DoubleClick += new System.EventHandler(this.PbPicture_DoubleClick);
            // 
            // PnData
            // 
            this.PnData.BackColor = System.Drawing.SystemColors.Control;
            this.PnData.Controls.Add(this.TbSurname);
            this.PnData.Controls.Add(this.TbName);
            this.PnData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnData.Location = new System.Drawing.Point(98, 0);
            this.PnData.Name = "PnData";
            this.PnData.Padding = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.PnData.Size = new System.Drawing.Size(252, 108);
            this.PnData.TabIndex = 1;
            // 
            // TbSurname
            // 
            this.TbSurname.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TbSurname.Location = new System.Drawing.Point(0, 72);
            this.TbSurname.Name = "TbSurname";
            this.TbSurname.Size = new System.Drawing.Size(248, 32);
            this.TbSurname.TabIndex = 1;
            // 
            // TbName
            // 
            this.TbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TbName.Location = new System.Drawing.Point(0, 4);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(248, 32);
            this.TbName.TabIndex = 0;
            // 
            // DlgOpen
            // 
            this.DlgOpen.DefaultExt = "jpg";
            this.DlgOpen.FileName = "*.bmp";
            this.DlgOpen.Filter = "BMP files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg|All images (*.*)|*.*";
            this.DlgOpen.RestoreDirectory = true;
            this.DlgOpen.Title = "Select Image";
            // 
            // EmploeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.PnData);
            this.Controls.Add(this.PnPicture);
            this.Name = "EmploeeControl";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.Size = new System.Drawing.Size(350, 110);
            this.Resize += new System.EventHandler(this.EmploeeControl_Resize);
            this.PnPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbPicture)).EndInit();
            this.PnData.ResumeLayout(false);
            this.PnData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnPicture;
        private System.Windows.Forms.PictureBox PbPicture;
        private System.Windows.Forms.Panel PnData;
        private System.Windows.Forms.TextBox TbSurname;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.OpenFileDialog DlgOpen;
    }
}
