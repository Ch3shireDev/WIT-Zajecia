namespace UserFrameTestSpace
{
    partial class PersonEdit
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
            this.Footer = new System.Windows.Forms.Panel();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.Client = new System.Windows.Forms.Panel();
            this.FrameBox = new PersonFrame();
            this.DlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.Footer.SuspendLayout();
            this.Client.SuspendLayout();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.BtnAccept);
            this.Footer.Controls.Add(this.BtnCancel);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 197);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(445, 49);
            this.Footer.TabIndex = 1;
            // 
            // BtnAccept
            // 
            this.BtnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAccept.Location = new System.Drawing.Point(358, 13);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(75, 23);
            this.BtnAccept.TabIndex = 1;
            this.BtnAccept.Text = "Akceptuj";
            this.BtnAccept.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(13, 13);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Rezygnuj";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // Client
            // 
            this.Client.Controls.Add(this.FrameBox);
            this.Client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Client.Location = new System.Drawing.Point(0, 0);
            this.Client.Name = "Client";
            this.Client.Padding = new System.Windows.Forms.Padding(8);
            this.Client.Size = new System.Drawing.Size(445, 197);
            this.Client.TabIndex = 2;
            // 
            // FrameBox
            // 
            this.FrameBox.AnPerson = null;
            this.FrameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FrameBox.Location = new System.Drawing.Point(8, 8);
            this.FrameBox.Name = "FrameBox";
            this.FrameBox.ReadOnly = true;
            this.FrameBox.Size = new System.Drawing.Size(429, 181);
            this.FrameBox.TabIndex = 0;
            // 
            // DlgOpen
            // 
            this.DlgOpen.DefaultExt = "jpg";
            this.DlgOpen.Filter = "BMP files (*.bmp)|*.bmp|JPEG files (*.jpg)|*.jpg";
            this.DlgOpen.Title = "Wskaż zdjęcie ...";
            // 
            // PersonEdit
            // 
            this.AcceptButton = this.BtnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(445, 246);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.Footer);
            this.Name = "PersonEdit";
            this.Text = "Person Edit ...";
            this.Footer.ResumeLayout(false);
            this.Client.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Panel Client;
        private System.Windows.Forms.OpenFileDialog DlgOpen;
        private PersonFrame FrameBox;
    }
}