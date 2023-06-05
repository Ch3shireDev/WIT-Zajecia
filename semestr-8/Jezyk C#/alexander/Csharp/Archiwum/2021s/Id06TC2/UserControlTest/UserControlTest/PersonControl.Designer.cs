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
            this.PbImage = new System.Windows.Forms.PictureBox();
            this.PnButtons = new System.Windows.Forms.Panel();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.PnProperties = new System.Windows.Forms.Panel();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtGivenname = new System.Windows.Forms.TextBox();
            this.DlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.PnImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).BeginInit();
            this.PnButtons.SuspendLayout();
            this.PnProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnImage
            // 
            this.PnImage.BackColor = System.Drawing.SystemColors.Control;
            this.PnImage.Controls.Add(this.PbImage);
            this.PnImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnImage.Location = new System.Drawing.Point(0, 0);
            this.PnImage.Name = "PnImage";
            this.PnImage.Padding = new System.Windows.Forms.Padding(4);
            this.PnImage.Size = new System.Drawing.Size(89, 62);
            this.PnImage.TabIndex = 0;
            // 
            // PbImage
            // 
            this.PbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbImage.Location = new System.Drawing.Point(4, 4);
            this.PbImage.Name = "PbImage";
            this.PbImage.Size = new System.Drawing.Size(81, 54);
            this.PbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbImage.TabIndex = 0;
            this.PbImage.TabStop = false;
            this.PbImage.DoubleClick += new System.EventHandler(this.PbImage_DoubleClick);
            // 
            // PnButtons
            // 
            this.PnButtons.BackColor = System.Drawing.SystemColors.Control;
            this.PnButtons.Controls.Add(this.BtnDelete);
            this.PnButtons.Controls.Add(this.BtnEdit);
            this.PnButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnButtons.Location = new System.Drawing.Point(382, 0);
            this.PnButtons.Name = "PnButtons";
            this.PnButtons.Padding = new System.Windows.Forms.Padding(4);
            this.PnButtons.Size = new System.Drawing.Size(89, 62);
            this.PnButtons.TabIndex = 1;
            this.PnButtons.Visible = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDelete.Location = new System.Drawing.Point(7, 32);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(7, 7);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 0;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // PnProperties
            // 
            this.PnProperties.BackColor = System.Drawing.SystemColors.Control;
            this.PnProperties.Controls.Add(this.TxtSurname);
            this.PnProperties.Controls.Add(this.TxtGivenname);
            this.PnProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnProperties.Location = new System.Drawing.Point(89, 0);
            this.PnProperties.Name = "PnProperties";
            this.PnProperties.Padding = new System.Windows.Forms.Padding(4);
            this.PnProperties.Size = new System.Drawing.Size(293, 62);
            this.PnProperties.TabIndex = 2;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxtSurname.Location = new System.Drawing.Point(4, 38);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(285, 20);
            this.TxtSurname.TabIndex = 1;
            // 
            // TxtGivenname
            // 
            this.TxtGivenname.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtGivenname.Location = new System.Drawing.Point(4, 4);
            this.TxtGivenname.Name = "TxtGivenname";
            this.TxtGivenname.Size = new System.Drawing.Size(285, 20);
            this.TxtGivenname.TabIndex = 0;
            // 
            // DlgOpen
            // 
            this.DlgOpen.FileName = "DataPic*.bmp";
            this.DlgOpen.Filter = "Bitmap Files|*.bmp|Other grphics files|*.jpg,*.png";
            this.DlgOpen.Title = "Choose image ...";
            // 
            // PersonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.PnProperties);
            this.Controls.Add(this.PnButtons);
            this.Controls.Add(this.PnImage);
            this.Name = "PersonControl";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Size = new System.Drawing.Size(471, 66);
            this.Resize += new System.EventHandler(this.PersonControl_Resize);
            this.PnImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).EndInit();
            this.PnButtons.ResumeLayout(false);
            this.PnProperties.ResumeLayout(false);
            this.PnProperties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnImage;
        private System.Windows.Forms.PictureBox PbImage;
        private System.Windows.Forms.Panel PnButtons;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Panel PnProperties;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtGivenname;
        private System.Windows.Forms.OpenFileDialog DlgOpen;
    }
}
