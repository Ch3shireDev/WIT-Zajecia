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
            this.PnlFooter = new System.Windows.Forms.Panel();
            this.PnlPersonList = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.PnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlFooter
            // 
            this.PnlFooter.Controls.Add(this.BtnAdd);
            this.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFooter.Location = new System.Drawing.Point(0, 346);
            this.PnlFooter.Name = "PnlFooter";
            this.PnlFooter.Size = new System.Drawing.Size(482, 36);
            this.PnlFooter.TabIndex = 1;
            // 
            // PnlPersonList
            // 
            this.PnlPersonList.AutoScroll = true;
            this.PnlPersonList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPersonList.Location = new System.Drawing.Point(0, 0);
            this.PnlPersonList.Name = "PnlPersonList";
            this.PnlPersonList.Size = new System.Drawing.Size(482, 346);
            this.PnlPersonList.TabIndex = 2;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 6);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // UserControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 382);
            this.Controls.Add(this.PnlPersonList);
            this.Controls.Add(this.PnlFooter);
            this.Name = "UserControlForm";
            this.Text = "Form1";
            this.PnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlFooter;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Panel PnlPersonList;
    }
}

