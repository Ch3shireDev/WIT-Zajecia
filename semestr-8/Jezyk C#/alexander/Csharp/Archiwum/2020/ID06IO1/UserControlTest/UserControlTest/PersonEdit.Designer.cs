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
            this.PnlFooter = new System.Windows.Forms.Panel();
            this.PnlClient = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.personControl = new UserControlTest.PersonControl();
            this.PnlFooter.SuspendLayout();
            this.PnlClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlFooter
            // 
            this.PnlFooter.Controls.Add(this.BtnAccept);
            this.PnlFooter.Controls.Add(this.BtnCancel);
            this.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFooter.Location = new System.Drawing.Point(0, 234);
            this.PnlFooter.Name = "PnlFooter";
            this.PnlFooter.Size = new System.Drawing.Size(654, 54);
            this.PnlFooter.TabIndex = 1;
            // 
            // PnlClient
            // 
            this.PnlClient.Controls.Add(this.personControl);
            this.PnlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlClient.Location = new System.Drawing.Point(0, 0);
            this.PnlClient.Margin = new System.Windows.Forms.Padding(4);
            this.PnlClient.Name = "PnlClient";
            this.PnlClient.Size = new System.Drawing.Size(654, 234);
            this.PnlClient.TabIndex = 2;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(12, 19);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnAccept
            // 
            this.BtnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAccept.Location = new System.Drawing.Point(567, 19);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(75, 23);
            this.BtnAccept.TabIndex = 1;
            this.BtnAccept.Text = "Accept";
            this.BtnAccept.UseVisualStyleBackColor = true;
            // 
            // personControl
            // 
            this.personControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.personControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personControl.Location = new System.Drawing.Point(0, 0);
            this.personControl.Name = "personControl";
            this.personControl.Person = null;
            this.personControl.Size = new System.Drawing.Size(654, 234);
            this.personControl.TabIndex = 0;
            // 
            // PersonEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 288);
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
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Panel PnlClient;
        private PersonControl personControl;
    }
}