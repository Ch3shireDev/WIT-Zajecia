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
            this.PnImage = new System.Windows.Forms.Panel();
            this.PbxImage = new System.Windows.Forms.PictureBox();
            this.PnClient = new System.Windows.Forms.Panel();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.PnImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImage)).BeginInit();
            this.PnClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnImage
            // 
            this.PnImage.BackColor = System.Drawing.SystemColors.Window;
            this.PnImage.Controls.Add(this.PbxImage);
            this.PnImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnImage.Location = new System.Drawing.Point(0, 0);
            this.PnImage.Name = "PnImage";
            this.PnImage.Padding = new System.Windows.Forms.Padding(4);
            this.PnImage.Size = new System.Drawing.Size(133, 129);
            this.PnImage.TabIndex = 0;
            // 
            // PbxImage
            // 
            this.PbxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbxImage.Location = new System.Drawing.Point(4, 4);
            this.PbxImage.Name = "PbxImage";
            this.PbxImage.Size = new System.Drawing.Size(125, 121);
            this.PbxImage.TabIndex = 0;
            this.PbxImage.TabStop = false;
            // 
            // PnClient
            // 
            this.PnClient.BackColor = System.Drawing.SystemColors.Window;
            this.PnClient.Controls.Add(this.TxtSurname);
            this.PnClient.Controls.Add(this.TxtName);
            this.PnClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnClient.Location = new System.Drawing.Point(133, 0);
            this.PnClient.Name = "PnClient";
            this.PnClient.Padding = new System.Windows.Forms.Padding(4);
            this.PnClient.Size = new System.Drawing.Size(327, 129);
            this.PnClient.TabIndex = 1;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxtSurname.Location = new System.Drawing.Point(4, 105);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(319, 20);
            this.TxtSurname.TabIndex = 1;
            // 
            // TxtName
            // 
            this.TxtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtName.Location = new System.Drawing.Point(4, 4);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(319, 20);
            this.TxtName.TabIndex = 0;
            // 
            // PersonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.PnClient);
            this.Controls.Add(this.PnImage);
            this.Name = "PersonControl";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Size = new System.Drawing.Size(460, 133);
            this.Resize += new System.EventHandler(this.PersonControl_Resize);
            this.PnImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxImage)).EndInit();
            this.PnClient.ResumeLayout(false);
            this.PnClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnImage;
        private System.Windows.Forms.Panel PnClient;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.PictureBox PbxImage;
    }
}
