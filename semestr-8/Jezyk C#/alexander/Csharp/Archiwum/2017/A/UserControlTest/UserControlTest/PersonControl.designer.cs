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
            this.LbName = new System.Windows.Forms.Label();
            this.EdName = new System.Windows.Forms.TextBox();
            this.EdPhone = new System.Windows.Forms.TextBox();
            this.LbPhone = new System.Windows.Forms.Label();
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
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Location = new System.Drawing.Point(95, 3);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(49, 13);
            this.LbName.TabIndex = 1;
            this.LbName.Text = "&Surname";
            // 
            // EdName
            // 
            this.EdName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdName.Location = new System.Drawing.Point(95, 19);
            this.EdName.Name = "EdName";
            this.EdName.Size = new System.Drawing.Size(247, 20);
            this.EdName.TabIndex = 2;
            // 
            // EdPhone
            // 
            this.EdPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdPhone.Location = new System.Drawing.Point(95, 80);
            this.EdPhone.Name = "EdPhone";
            this.EdPhone.Size = new System.Drawing.Size(247, 20);
            this.EdPhone.TabIndex = 4;
            // 
            // LbPhone
            // 
            this.LbPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LbPhone.AutoSize = true;
            this.LbPhone.Location = new System.Drawing.Point(95, 64);
            this.LbPhone.Name = "LbPhone";
            this.LbPhone.Size = new System.Drawing.Size(38, 13);
            this.LbPhone.TabIndex = 3;
            this.LbPhone.Text = "&Phone";
            // 
            // PersonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EdPhone);
            this.Controls.Add(this.LbPhone);
            this.Controls.Add(this.EdName);
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.Image);
            this.Name = "PersonControl";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(348, 106);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.TextBox EdName;
        private System.Windows.Forms.TextBox EdPhone;
        private System.Windows.Forms.Label LbPhone;
    }
}
