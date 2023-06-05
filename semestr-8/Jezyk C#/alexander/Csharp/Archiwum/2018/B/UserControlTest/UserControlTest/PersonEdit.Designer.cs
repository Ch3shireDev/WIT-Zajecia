namespace UserControlTestNamespace
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
            this.Frame = new UserControlTestNamespace.PersonFrame();
            this.BtnResign = new System.Windows.Forms.Button();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.DlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Frame
            // 
            this.Frame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Frame.AnPerson = null;
            this.Frame.Location = new System.Drawing.Point(0, 0);
            this.Frame.Name = "Frame";
            this.Frame.ReadOnly = true;
            this.Frame.Size = new System.Drawing.Size(540, 188);
            this.Frame.TabIndex = 1;
            // 
            // BtnResign
            // 
            this.BtnResign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnResign.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnResign.Location = new System.Drawing.Point(12, 202);
            this.BtnResign.Name = "BtnResign";
            this.BtnResign.Size = new System.Drawing.Size(75, 23);
            this.BtnResign.TabIndex = 2;
            this.BtnResign.Text = "Rezygnuj";
            this.BtnResign.UseVisualStyleBackColor = true;
            this.BtnResign.Click += new System.EventHandler(this.BtnResign_Click);
            // 
            // BtnAccept
            // 
            this.BtnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAccept.Location = new System.Drawing.Point(461, 202);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(75, 23);
            this.BtnAccept.TabIndex = 3;
            this.BtnAccept.Text = "Akceptuj";
            this.BtnAccept.UseVisualStyleBackColor = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // DlgOpen
            // 
            this.DlgOpen.DefaultExt = "bmp";
            this.DlgOpen.Filter = "Bitmapy (*.bmp)|*.bmp|JPEG (*.jpg)|*.jpg";
            this.DlgOpen.Title = "Wskaż zdjęcie ...";
            // 
            // PersonEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 237);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.BtnResign);
            this.Controls.Add(this.Frame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PersonEdit";
            this.Text = "Edycja osoby ...";
            this.ResumeLayout(false);

        }

        #endregion

        private PersonFrame Frame;
        private System.Windows.Forms.Button BtnResign;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.OpenFileDialog DlgOpen;
    }
}