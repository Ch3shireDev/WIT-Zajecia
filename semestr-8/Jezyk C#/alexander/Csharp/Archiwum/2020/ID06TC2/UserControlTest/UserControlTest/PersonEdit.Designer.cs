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
            UserControlTest.Person person1 = new UserControlTest.Person();
            this.PnlFooter = new System.Windows.Forms.Panel();
            this.PnlClient = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.UcPerson = new UserControlTest.PersonControl();
            this.PnlFooter.SuspendLayout();
            this.PnlClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlFooter
            // 
            this.PnlFooter.Controls.Add(this.BtnAccept);
            this.PnlFooter.Controls.Add(this.BtnCancel);
            this.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFooter.Location = new System.Drawing.Point(0, 212);
            this.PnlFooter.Name = "PnlFooter";
            this.PnlFooter.Size = new System.Drawing.Size(506, 50);
            this.PnlFooter.TabIndex = 0;
            // 
            // PnlClient
            // 
            this.PnlClient.Controls.Add(this.UcPerson);
            this.PnlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlClient.Location = new System.Drawing.Point(0, 0);
            this.PnlClient.Name = "PnlClient";
            this.PnlClient.Padding = new System.Windows.Forms.Padding(8);
            this.PnlClient.Size = new System.Drawing.Size(506, 212);
            this.PnlClient.TabIndex = 1;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(12, 15);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnAccept
            // 
            this.BtnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAccept.Location = new System.Drawing.Point(419, 15);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(75, 23);
            this.BtnAccept.TabIndex = 1;
            this.BtnAccept.Text = "Accept";
            this.BtnAccept.UseVisualStyleBackColor = true;
            // 
            // UcPerson
            // 
            this.UcPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcPerson.Location = new System.Drawing.Point(8, 8);
            this.UcPerson.Name = "UcPerson";
            person1.Givename = null;
            person1.Picture = null;
            person1.Surname = null;
            this.UcPerson.Person = person1;
            this.UcPerson.Size = new System.Drawing.Size(490, 196);
            this.UcPerson.TabIndex = 0;
            // 
            // PersonEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 262);
            this.Controls.Add(this.PnlClient);
            this.Controls.Add(this.PnlFooter);
            this.Name = "PersonEdit";
            this.Text = "PersonEdit";
            this.PnlFooter.ResumeLayout(false);
            this.PnlClient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlFooter;
        private System.Windows.Forms.Panel PnlClient;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnCancel;
        private PersonControl UcPerson;
    }
}