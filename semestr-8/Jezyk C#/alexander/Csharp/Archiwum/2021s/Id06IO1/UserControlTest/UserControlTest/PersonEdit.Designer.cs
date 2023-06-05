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
            this.PnButtons = new System.Windows.Forms.Panel();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.personControl = new UserControlTest.PersonControl();
            this.PnButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnButtons
            // 
            this.PnButtons.Controls.Add(this.BtnAccept);
            this.PnButtons.Controls.Add(this.BtnCancel);
            this.PnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnButtons.Location = new System.Drawing.Point(0, 164);
            this.PnButtons.Name = "PnButtons";
            this.PnButtons.Size = new System.Drawing.Size(567, 46);
            this.PnButtons.TabIndex = 0;
            // 
            // BtnAccept
            // 
            this.BtnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAccept.Location = new System.Drawing.Point(480, 11);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(75, 23);
            this.BtnAccept.TabIndex = 1;
            this.BtnAccept.Text = "Accept";
            this.BtnAccept.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(12, 11);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // personControl
            // 
            this.personControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.personControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personControl.Location = new System.Drawing.Point(0, 0);
            this.personControl.Name = "personControl";
            this.personControl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.personControl.Size = new System.Drawing.Size(567, 164);
            this.personControl.TabIndex = 1;
            // 
            // PersonEdit
            // 
            this.AcceptButton = this.BtnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(567, 210);
            this.Controls.Add(this.personControl);
            this.Controls.Add(this.PnButtons);
            this.Name = "PersonEdit";
            this.Text = "PersonEdit";
            this.PnButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnButtons;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnCancel;
        private PersonControl personControl;
    }
}