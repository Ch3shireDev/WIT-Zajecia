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
            this.footer = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.Client = new System.Windows.Forms.Panel();
            this.footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.Controls.Add(this.BtnAdd);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 425);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(557, 37);
            this.footer.TabIndex = 1;
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
            // Client
            // 
            this.Client.AutoScroll = true;
            this.Client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Client.Location = new System.Drawing.Point(0, 0);
            this.Client.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(557, 425);
            this.Client.TabIndex = 2;
            // 
            // UserControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 462);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.footer);
            this.Name = "UserControlForm";
            this.Text = "Lista pracowników ...";
            this.footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Panel Client;
    }
}

