namespace MySqlTest
{
    partial class RecordEdit
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
            this.edName = new System.Windows.Forms.TextBox();
            this.edSurname = new System.Windows.Forms.TextBox();
            this.edPhones = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edName
            // 
            this.edName.Location = new System.Drawing.Point(12, 26);
            this.edName.Name = "edName";
            this.edName.Size = new System.Drawing.Size(100, 20);
            this.edName.TabIndex = 0;
            // 
            // edSurname
            // 
            this.edSurname.Location = new System.Drawing.Point(12, 72);
            this.edSurname.Name = "edSurname";
            this.edSurname.Size = new System.Drawing.Size(100, 20);
            this.edSurname.TabIndex = 1;
            // 
            // edPhones
            // 
            this.edPhones.Location = new System.Drawing.Point(12, 124);
            this.edPhones.Multiline = true;
            this.edPhones.Name = "edPhones";
            this.edPhones.Size = new System.Drawing.Size(304, 93);
            this.edPhones.TabIndex = 2;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(12, 234);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnAccept
            // 
            this.BtnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAccept.Location = new System.Drawing.Point(241, 234);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(75, 23);
            this.BtnAccept.TabIndex = 4;
            this.BtnAccept.Text = "Accept";
            this.BtnAccept.UseVisualStyleBackColor = true;
            // 
            // RecordEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 268);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.edPhones);
            this.Controls.Add(this.edSurname);
            this.Controls.Add(this.edName);
            this.Name = "RecordEdit";
            this.Text = "RecordEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edName;
        private System.Windows.Forms.TextBox edSurname;
        private System.Windows.Forms.TextBox edPhones;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAccept;
    }
}