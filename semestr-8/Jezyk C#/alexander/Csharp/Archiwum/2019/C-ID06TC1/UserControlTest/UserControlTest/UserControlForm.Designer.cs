namespace UserControlTest
{
    partial class UserControlForm
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
            this.ScrollBox = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.BtnAdd);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 357);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(515, 36);
            this.Footer.TabIndex = 0;
            // 
            // ScrollBox
            // 
            this.ScrollBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScrollBox.Location = new System.Drawing.Point(0, 0);
            this.ScrollBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.ScrollBox.Name = "ScrollBox";
            this.ScrollBox.Size = new System.Drawing.Size(515, 357);
            this.ScrollBox.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 6);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // UserControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 393);
            this.Controls.Add(this.ScrollBox);
            this.Controls.Add(this.Footer);
            this.Name = "UserControlForm";
            this.Text = "User Control Test ...";
            this.Footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Panel ScrollBox;
        private System.Windows.Forms.Button BtnAdd;
    }
}

