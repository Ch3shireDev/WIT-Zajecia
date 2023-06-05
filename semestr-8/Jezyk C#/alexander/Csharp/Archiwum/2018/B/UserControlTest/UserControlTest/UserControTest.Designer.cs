namespace UserControlTestNamespace
{
    partial class UserControlTest
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
            this.BtnNew = new System.Windows.Forms.Button();
            this.Client = new System.Windows.Forms.Panel();
            this.Box = new System.Windows.Forms.Panel();
            this.Footer.SuspendLayout();
            this.Client.SuspendLayout();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.BtnNew);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 357);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(644, 37);
            this.Footer.TabIndex = 1;
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(8, 8);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "Dodaj";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // Client
            // 
            this.Client.Controls.Add(this.Box);
            this.Client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Client.Location = new System.Drawing.Point(0, 0);
            this.Client.Name = "Client";
            this.Client.Padding = new System.Windows.Forms.Padding(8);
            this.Client.Size = new System.Drawing.Size(644, 357);
            this.Client.TabIndex = 2;
            // 
            // Box
            // 
            this.Box.AutoScroll = true;
            this.Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box.Location = new System.Drawing.Point(8, 8);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(628, 341);
            this.Box.TabIndex = 0;
            // 
            // UserControlTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 394);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.Footer);
            this.Name = "UserControlTest";
            this.Text = "User Control Test ...";
            this.Footer.ResumeLayout(false);
            this.Client.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Panel Client;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Panel Box;
    }
}

