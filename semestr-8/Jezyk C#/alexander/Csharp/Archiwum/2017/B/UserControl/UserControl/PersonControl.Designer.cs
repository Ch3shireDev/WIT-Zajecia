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
            this.Image = new System.Windows.Forms.PictureBox();
            this.LbSurname = new System.Windows.Forms.Label();
            this.EdSurname = new System.Windows.Forms.TextBox();
            this.EdName = new System.Windows.Forms.TextBox();
            this.LbName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Image
            // 
            this.Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Image.Dock = System.Windows.Forms.DockStyle.Left;
            this.Image.Location = new System.Drawing.Point(3, 3);
            this.Image.Name = "Image";
            this.Image.Padding = new System.Windows.Forms.Padding(3);
            this.Image.Size = new System.Drawing.Size(80, 100);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image.TabIndex = 0;
            this.Image.TabStop = false;
            this.Image.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Image_MouseDoubleClick);
            // 
            // LbSurname
            // 
            this.LbSurname.AutoSize = true;
            this.LbSurname.Location = new System.Drawing.Point(95, 3);
            this.LbSurname.Name = "LbSurname";
            this.LbSurname.Size = new System.Drawing.Size(49, 13);
            this.LbSurname.TabIndex = 1;
            this.LbSurname.Text = "&Surname";
            // 
            // EdSurname
            // 
            this.EdSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdSurname.Location = new System.Drawing.Point(95, 19);
            this.EdSurname.Name = "EdSurname";
            this.EdSurname.Size = new System.Drawing.Size(322, 20);
            this.EdSurname.TabIndex = 2;
            // 
            // EdName
            // 
            this.EdName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdName.Location = new System.Drawing.Point(95, 80);
            this.EdName.Name = "EdName";
            this.EdName.Size = new System.Drawing.Size(322, 20);
            this.EdName.TabIndex = 4;
            // 
            // LbName
            // 
            this.LbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LbName.AutoSize = true;
            this.LbName.Location = new System.Drawing.Point(95, 64);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(35, 13);
            this.LbName.TabIndex = 3;
            this.LbName.Text = "&Name";
            // 
            // PersonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EdName);
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.EdSurname);
            this.Controls.Add(this.LbSurname);
            this.Controls.Add(this.Image);
            this.Name = "PersonControl";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(423, 106);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.Label LbSurname;
        private System.Windows.Forms.TextBox EdSurname;
        private System.Windows.Forms.TextBox EdName;
        private System.Windows.Forms.Label LbName;
    }
}
