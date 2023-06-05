namespace Decorator
{
    partial class Form1
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
            this.CbCars = new System.Windows.Forms.ComboBox();
            this.ChkDecorators = new System.Windows.Forms.CheckedListBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CbCars
            // 
            this.CbCars.FormattingEnabled = true;
            this.CbCars.Location = new System.Drawing.Point(12, 12);
            this.CbCars.Name = "CbCars";
            this.CbCars.Size = new System.Drawing.Size(121, 21);
            this.CbCars.TabIndex = 0;
            // 
            // ChkDecorators
            // 
            this.ChkDecorators.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ChkDecorators.FormattingEnabled = true;
            this.ChkDecorators.Location = new System.Drawing.Point(13, 39);
            this.ChkDecorators.Name = "ChkDecorators";
            this.ChkDecorators.Size = new System.Drawing.Size(120, 319);
            this.ChkDecorators.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAdd.Location = new System.Drawing.Point(12, 375);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(120, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtLog
            // 
            this.TxtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtLog.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtLog.Location = new System.Drawing.Point(139, 13);
            this.TxtLog.Multiline = true;
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.Size = new System.Drawing.Size(633, 385);
            this.TxtLog.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 410);
            this.Controls.Add(this.TxtLog);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.ChkDecorators);
            this.Controls.Add(this.CbCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbCars;
        private System.Windows.Forms.CheckedListBox ChkDecorators;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtLog;
    }
}

