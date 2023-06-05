namespace UserControlTest
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
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.Box = new System.Windows.Forms.Panel();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.BtnDelete);
            this.Footer.Controls.Add(this.BtnNew);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 385);
            this.Footer.Name = "Footer";
            this.Footer.Padding = new System.Windows.Forms.Padding(4);
            this.Footer.Size = new System.Drawing.Size(409, 31);
            this.Footer.TabIndex = 0;
            // 
            // BtnDelete
            // 
            this.BtnDelete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnDelete.Location = new System.Drawing.Point(330, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            this.BtnNew.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnNew.Location = new System.Drawing.Point(4, 4);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 0;
            this.BtnNew.Text = "New";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // Box
            // 
            this.Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box.Location = new System.Drawing.Point(0, 0);
            this.Box.Name = "Box";
            this.Box.Padding = new System.Windows.Forms.Padding(4);
            this.Box.Size = new System.Drawing.Size(409, 385);
            this.Box.TabIndex = 1;
            // 
            // UserControlTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 416);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.Footer);
            this.Name = "UserControlTest";
            this.Text = "Lista pracowników";
            this.Footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Panel Box;
    }
}

