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
            this.PnButtons = new System.Windows.Forms.Panel();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtGivenname = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.PbImage = new System.Windows.Forms.PictureBox();
            this.DlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.PnImage.SuspendLayout();
            this.PnButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).BeginInit();
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
            this.PnImage.Size = new System.Drawing.Size(125, 78);
            this.PnImage.TabIndex = 0;
            // 
            // PnButtons
            // 
            this.PnButtons.BackColor = System.Drawing.SystemColors.Control;
            this.PnButtons.Controls.Add(this.BtnDelete);
            this.PnButtons.Controls.Add(this.BtnEdit);
            this.PnButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnButtons.Location = new System.Drawing.Point(374, 0);
            this.PnButtons.Name = "PnButtons";
            this.PnButtons.Padding = new System.Windows.Forms.Padding(4);
            this.PnButtons.Size = new System.Drawing.Size(92, 78);
            this.PnButtons.TabIndex = 1;
            this.PnButtons.Visible = false;
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
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDelete.Location = new System.Drawing.Point(7, 48);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.TxtSurname);
            this.panel1.Controls.Add(this.TxtGivenname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(125, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(249, 78);
            this.panel1.TabIndex = 2;
            // 
            // TxtGivenname
            // 
            this.TxtGivenname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtGivenname.Location = new System.Drawing.Point(7, 7);
            this.TxtGivenname.Name = "TxtGivenname";
            this.TxtGivenname.Size = new System.Drawing.Size(235, 20);
            this.TxtGivenname.TabIndex = 0;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSurname.Location = new System.Drawing.Point(6, 48);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(236, 20);
            this.TxtSurname.TabIndex = 1;
            // 
            // PbImage
            // 
            this.PbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbImage.Location = new System.Drawing.Point(4, 4);
            this.PbImage.Name = "PbImage";
            this.PbImage.Size = new System.Drawing.Size(117, 70);
            this.PbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbImage.TabIndex = 0;
            this.PbImage.TabStop = false;
            this.PbImage.DoubleClick += new System.EventHandler(this.PbImage_DoubleClick);
            // 
            // DlgOpen
            // 
            this.DlgOpen.FileName = "DataPic*.bmp";
            this.DlgOpen.Filter = "Bitmap image|*.bmp|Other image|*.gif,*.jpg,*.png";
            this.DlgOpen.Title = "Choose image ...";
            // 
            // PersonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnButtons);
            this.Controls.Add(this.PnImage);
            this.Name = "PersonControl";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Size = new System.Drawing.Size(466, 82);
            this.Resize += new System.EventHandler(this.PersonControl_Resize);
            this.PnImage.ResumeLayout(false);
            this.PnButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnImage;
        private System.Windows.Forms.Panel PnButtons;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtGivenname;
        private System.Windows.Forms.PictureBox PbImage;
        private System.Windows.Forms.OpenFileDialog DlgOpen;
    }
}
