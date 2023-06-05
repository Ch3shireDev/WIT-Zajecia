namespace Steganography
{
    partial class SteganographyMain
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
            this.BmpBox = new System.Windows.Forms.PictureBox();
            this.TxtBox = new System.Windows.Forms.TextBox();
            this.DlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.DlgSave = new System.Windows.Forms.SaveFileDialog();
            this.BtnOpenBmp = new System.Windows.Forms.Button();
            this.BtnSaveBmp = new System.Windows.Forms.Button();
            this.BtnSaveTxt = new System.Windows.Forms.Button();
            this.BtnOpenTxt = new System.Windows.Forms.Button();
            this.BtnEncode = new System.Windows.Forms.Button();
            this.BtnDecode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BmpBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BmpBox
            // 
            this.BmpBox.Location = new System.Drawing.Point(12, 12);
            this.BmpBox.Name = "BmpBox";
            this.BmpBox.Size = new System.Drawing.Size(204, 228);
            this.BmpBox.TabIndex = 0;
            this.BmpBox.TabStop = false;
            // 
            // TxtBox
            // 
            this.TxtBox.Location = new System.Drawing.Point(266, 12);
            this.TxtBox.Multiline = true;
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.Size = new System.Drawing.Size(204, 228);
            this.TxtBox.TabIndex = 1;
            // 
            // DlgOpen
            // 
            this.DlgOpen.RestoreDirectory = true;
            this.DlgOpen.ShowReadOnly = true;
            // 
            // BtnOpenBmp
            // 
            this.BtnOpenBmp.Location = new System.Drawing.Point(12, 249);
            this.BtnOpenBmp.Name = "BtnOpenBmp";
            this.BtnOpenBmp.Size = new System.Drawing.Size(75, 23);
            this.BtnOpenBmp.TabIndex = 2;
            this.BtnOpenBmp.Text = "Open";
            this.BtnOpenBmp.UseVisualStyleBackColor = true;
            this.BtnOpenBmp.Click += new System.EventHandler(this.BtnOpenBmp_Click);
            // 
            // BtnSaveBmp
            // 
            this.BtnSaveBmp.Location = new System.Drawing.Point(141, 249);
            this.BtnSaveBmp.Name = "BtnSaveBmp";
            this.BtnSaveBmp.Size = new System.Drawing.Size(75, 23);
            this.BtnSaveBmp.TabIndex = 3;
            this.BtnSaveBmp.Text = "Save";
            this.BtnSaveBmp.UseVisualStyleBackColor = true;
            this.BtnSaveBmp.Click += new System.EventHandler(this.BtnSaveBmp_Click);
            // 
            // BtnSaveTxt
            // 
            this.BtnSaveTxt.Location = new System.Drawing.Point(395, 249);
            this.BtnSaveTxt.Name = "BtnSaveTxt";
            this.BtnSaveTxt.Size = new System.Drawing.Size(75, 23);
            this.BtnSaveTxt.TabIndex = 5;
            this.BtnSaveTxt.Text = "Save";
            this.BtnSaveTxt.UseVisualStyleBackColor = true;
            this.BtnSaveTxt.Click += new System.EventHandler(this.BtnSaveTxt_Click);
            // 
            // BtnOpenTxt
            // 
            this.BtnOpenTxt.Location = new System.Drawing.Point(266, 249);
            this.BtnOpenTxt.Name = "BtnOpenTxt";
            this.BtnOpenTxt.Size = new System.Drawing.Size(75, 23);
            this.BtnOpenTxt.TabIndex = 4;
            this.BtnOpenTxt.Text = "Open";
            this.BtnOpenTxt.UseVisualStyleBackColor = true;
            this.BtnOpenTxt.Click += new System.EventHandler(this.BtnOpenTxt_Click);
            // 
            // BtnEncode
            // 
            this.BtnEncode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnEncode.Location = new System.Drawing.Point(222, 38);
            this.BtnEncode.Name = "BtnEncode";
            this.BtnEncode.Size = new System.Drawing.Size(38, 30);
            this.BtnEncode.TabIndex = 6;
            this.BtnEncode.Text = "◄";
            this.BtnEncode.UseVisualStyleBackColor = true;
            this.BtnEncode.Click += new System.EventHandler(this.BtnEncode_Click);
            // 
            // BtnDecode
            // 
            this.BtnDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDecode.Location = new System.Drawing.Point(222, 187);
            this.BtnDecode.Name = "BtnDecode";
            this.BtnDecode.Size = new System.Drawing.Size(38, 30);
            this.BtnDecode.TabIndex = 7;
            this.BtnDecode.Text = "►";
            this.BtnDecode.UseVisualStyleBackColor = true;
            this.BtnDecode.Click += new System.EventHandler(this.BtnDecode_Click);
            // 
            // SteganographyMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 284);
            this.Controls.Add(this.BtnDecode);
            this.Controls.Add(this.BtnEncode);
            this.Controls.Add(this.BtnSaveTxt);
            this.Controls.Add(this.BtnOpenTxt);
            this.Controls.Add(this.BtnSaveBmp);
            this.Controls.Add(this.BtnOpenBmp);
            this.Controls.Add(this.TxtBox);
            this.Controls.Add(this.BmpBox);
            this.Name = "SteganographyMain";
            this.Text = "Steganography";
            ((System.ComponentModel.ISupportInitialize)(this.BmpBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BmpBox;
        private System.Windows.Forms.TextBox TxtBox;
        private System.Windows.Forms.OpenFileDialog DlgOpen;
        private System.Windows.Forms.SaveFileDialog DlgSave;
        private System.Windows.Forms.Button BtnOpenBmp;
        private System.Windows.Forms.Button BtnSaveBmp;
        private System.Windows.Forms.Button BtnSaveTxt;
        private System.Windows.Forms.Button BtnOpenTxt;
        private System.Windows.Forms.Button BtnEncode;
        private System.Windows.Forms.Button BtnDecode;
    }
}

