namespace UserControlTestNamespace
{
    partial class PersonFrame
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
            this.Footer = new System.Windows.Forms.Panel();
            this.ImageArea = new System.Windows.Forms.Panel();
            this.ImgFace = new System.Windows.Forms.PictureBox();
            this.Client = new System.Windows.Forms.Panel();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.ImageArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFace)).BeginInit();
            this.Client.SuspendLayout();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Footer.Location = new System.Drawing.Point(0, 200);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(552, 3);
            this.Footer.TabIndex = 0;
            this.Footer.DoubleClick += new System.EventHandler(this.Frame_DoubleClick);
            // 
            // ImageArea
            // 
            this.ImageArea.Controls.Add(this.ImgFace);
            this.ImageArea.Dock = System.Windows.Forms.DockStyle.Left;
            this.ImageArea.Location = new System.Drawing.Point(0, 0);
            this.ImageArea.Name = "ImageArea";
            this.ImageArea.Padding = new System.Windows.Forms.Padding(8);
            this.ImageArea.Size = new System.Drawing.Size(156, 200);
            this.ImageArea.TabIndex = 1;
            this.ImageArea.DoubleClick += new System.EventHandler(this.Frame_DoubleClick);
            // 
            // ImgFace
            // 
            this.ImgFace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgFace.Location = new System.Drawing.Point(8, 8);
            this.ImgFace.Name = "ImgFace";
            this.ImgFace.Size = new System.Drawing.Size(140, 184);
            this.ImgFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgFace.TabIndex = 0;
            this.ImgFace.TabStop = false;
            this.ImgFace.Click += new System.EventHandler(this.Face_Click);
            this.ImgFace.DoubleClick += new System.EventHandler(this.Frame_DoubleClick);
            // 
            // Client
            // 
            this.Client.Controls.Add(this.Lastname);
            this.Client.Controls.Add(this.Firstname);
            this.Client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Client.Location = new System.Drawing.Point(156, 0);
            this.Client.Name = "Client";
            this.Client.Padding = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.Client.Size = new System.Drawing.Size(396, 200);
            this.Client.TabIndex = 2;
            this.Client.DoubleClick += new System.EventHandler(this.Frame_DoubleClick);
            // 
            // Lastname
            // 
            this.Lastname.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lastname.Location = new System.Drawing.Point(0, 163);
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            this.Lastname.Size = new System.Drawing.Size(388, 29);
            this.Lastname.TabIndex = 5;
            this.Lastname.DoubleClick += new System.EventHandler(this.Frame_DoubleClick);
            // 
            // Firstname
            // 
            this.Firstname.Dock = System.Windows.Forms.DockStyle.Top;
            this.Firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Firstname.Location = new System.Drawing.Point(0, 8);
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            this.Firstname.Size = new System.Drawing.Size(388, 29);
            this.Firstname.TabIndex = 4;
            this.Firstname.DoubleClick += new System.EventHandler(this.Frame_DoubleClick);
            // 
            // PersonFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Client);
            this.Controls.Add(this.ImageArea);
            this.Controls.Add(this.Footer);
            this.Name = "PersonFrame";
            this.Size = new System.Drawing.Size(552, 203);
            this.DoubleClick += new System.EventHandler(this.Frame_DoubleClick);
            this.ImageArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgFace)).EndInit();
            this.Client.ResumeLayout(false);
            this.Client.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Panel ImageArea;
        private System.Windows.Forms.PictureBox ImgFace;
        private System.Windows.Forms.Panel Client;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.TextBox Firstname;
    }
}
