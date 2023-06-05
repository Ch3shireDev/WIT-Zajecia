namespace UserControlTest
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.Footer = new System.Windows.Forms.Panel();
            this.PersonBox = new PersonControl();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnCancel.Location = new System.Drawing.Point(4, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnAccept
            // 
            this.BtnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAccept.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnAccept.Location = new System.Drawing.Point(336, 4);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(75, 23);
            this.BtnAccept.TabIndex = 1;
            this.BtnAccept.Text = "Accept";
            this.BtnAccept.UseVisualStyleBackColor = true;
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.BtnAccept);
            this.Footer.Controls.Add(this.BtnCancel);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 120);
            this.Footer.Name = "Footer";
            this.Footer.Padding = new System.Windows.Forms.Padding(4);
            this.Footer.Size = new System.Drawing.Size(415, 31);
            this.Footer.TabIndex = 2;
            // 
            // PersonBox
            // 
            this.PersonBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PersonBox.Location = new System.Drawing.Point(0, 0);
            this.PersonBox.Name = "PersonBox";
            this.PersonBox.Padding = new System.Windows.Forms.Padding(3);
            this.PersonBox.Size = new System.Drawing.Size(415, 106);
            this.PersonBox.TabIndex = 3;
            // 
            // PersonEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 151);
            this.Controls.Add(this.PersonBox);
            this.Controls.Add(this.Footer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PersonEdit";
            this.Text = "Edycja danych osobowych ...";
            this.Footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Panel Footer;
        private PersonControl PersonBox;
    }
}