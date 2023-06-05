namespace UseFrame
{
    partial class EmployeeFrame
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picEmployeeImg = new System.Windows.Forms.PictureBox();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.lbEmployeePhone = new System.Windows.Forms.Label();
            this.integerBox1 = new SpecialBox.IntegerBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployeeImg)).BeginInit();
            this.SuspendLayout();
            // 
            // picEmployeeImg
            // 
            this.picEmployeeImg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picEmployeeImg.Location = new System.Drawing.Point(3, 3);
            this.picEmployeeImg.Name = "picEmployeeImg";
            this.picEmployeeImg.Size = new System.Drawing.Size(104, 105);
            this.picEmployeeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmployeeImg.TabIndex = 0;
            this.picEmployeeImg.TabStop = false;
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbEmployeeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbEmployeeName.Location = new System.Drawing.Point(113, 3);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(133, 20);
            this.lbEmployeeName.TabIndex = 1;
            this.lbEmployeeName.Text = "EmployeeName";
            // 
            // lbEmployeePhone
            // 
            this.lbEmployeePhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEmployeePhone.AutoSize = true;
            this.lbEmployeePhone.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbEmployeePhone.Location = new System.Drawing.Point(325, 94);
            this.lbEmployeePhone.Name = "lbEmployeePhone";
            this.lbEmployeePhone.Size = new System.Drawing.Size(98, 14);
            this.lbEmployeePhone.TabIndex = 2;
            this.lbEmployeePhone.Text = "EmployeePhone";
            this.lbEmployeePhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // integerBox1
            // 
            this.integerBox1.Location = new System.Drawing.Point(168, 54);
            this.integerBox1.Name = "integerBox1";
            this.integerBox1.Size = new System.Drawing.Size(100, 20);
            this.integerBox1.TabIndex = 3;
            this.integerBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.integerBox1.Value = 0;
            // 
            // EmployeeFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.integerBox1);
            this.Controls.Add(this.lbEmployeePhone);
            this.Controls.Add(this.lbEmployeeName);
            this.Controls.Add(this.picEmployeeImg);
            this.Name = "EmployeeFrame";
            this.Size = new System.Drawing.Size(426, 111);
            ((System.ComponentModel.ISupportInitialize)(this.picEmployeeImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picEmployeeImg;
        private System.Windows.Forms.Label lbEmployeeName;
        private System.Windows.Forms.Label lbEmployeePhone;
        private SpecialBox.IntegerBox integerBox1;
    }
}
