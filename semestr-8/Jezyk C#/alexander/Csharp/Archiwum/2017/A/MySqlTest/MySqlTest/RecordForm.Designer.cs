namespace MySqlTest
{
    partial class RecordForm
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbPhones = new System.Windows.Forms.Label();
            this.BtnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edName
            // 
            this.edName.Location = new System.Drawing.Point(12, 24);
            this.edName.Name = "edName";
            this.edName.Size = new System.Drawing.Size(100, 20);
            this.edName.TabIndex = 0;
            // 
            // edSurname
            // 
            this.edSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edSurname.Location = new System.Drawing.Point(273, 24);
            this.edSurname.Name = "edSurname";
            this.edSurname.Size = new System.Drawing.Size(100, 20);
            this.edSurname.TabIndex = 1;
            // 
            // edPhones
            // 
            this.edPhones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edPhones.Location = new System.Drawing.Point(12, 76);
            this.edPhones.Multiline = true;
            this.edPhones.Name = "edPhones";
            this.edPhones.Size = new System.Drawing.Size(361, 136);
            this.edPhones.TabIndex = 2;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 8);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "&Name";
            // 
            // lbSurname
            // 
            this.lbSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(270, 8);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(49, 13);
            this.lbSurname.TabIndex = 4;
            this.lbSurname.Text = "&Surname";
            // 
            // lbPhones
            // 
            this.lbPhones.AutoSize = true;
            this.lbPhones.Location = new System.Drawing.Point(12, 60);
            this.lbPhones.Name = "lbPhones";
            this.lbPhones.Size = new System.Drawing.Size(43, 13);
            this.lbPhones.TabIndex = 5;
            this.lbPhones.Text = "&Phones";
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.Location = new System.Drawing.Point(12, 218);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 6;
            this.BtnOk.Text = "Accept";
            this.BtnOk.UseVisualStyleBackColor = true;
            // 
            // RecordForm
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 253);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.lbPhones);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.edPhones);
            this.Controls.Add(this.edSurname);
            this.Controls.Add(this.edName);
            this.Name = "RecordForm";
            this.Text = "RecordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbPhones;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.TextBox edName;
        private System.Windows.Forms.TextBox edSurname;
        private System.Windows.Forms.TextBox edPhones;
    }
}