namespace DecoratorTest
{
    partial class DecoratorForm
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
            this.CbKind = new System.Windows.Forms.ComboBox();
            this.CbDecorators = new System.Windows.Forms.CheckedListBox();
            this.BtnShow = new System.Windows.Forms.Button();
            this.EdLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CbKind
            // 
            this.CbKind.FormattingEnabled = true;
            this.CbKind.Location = new System.Drawing.Point(12, 12);
            this.CbKind.Name = "CbKind";
            this.CbKind.Size = new System.Drawing.Size(121, 21);
            this.CbKind.TabIndex = 0;
            // 
            // CbDecorators
            // 
            this.CbDecorators.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CbDecorators.FormattingEnabled = true;
            this.CbDecorators.Location = new System.Drawing.Point(13, 39);
            this.CbDecorators.Name = "CbDecorators";
            this.CbDecorators.Size = new System.Drawing.Size(120, 274);
            this.CbDecorators.TabIndex = 1;
            // 
            // BtnShow
            // 
            this.BtnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnShow.Location = new System.Drawing.Point(12, 319);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(121, 23);
            this.BtnShow.TabIndex = 2;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // EdLog
            // 
            this.EdLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdLog.Location = new System.Drawing.Point(139, 12);
            this.EdLog.Multiline = true;
            this.EdLog.Name = "EdLog";
            this.EdLog.Size = new System.Drawing.Size(449, 330);
            this.EdLog.TabIndex = 3;
            // 
            // DecoratorForm
            // 
            this.AcceptButton = this.BtnShow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 349);
            this.Controls.Add(this.EdLog);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.CbDecorators);
            this.Controls.Add(this.CbKind);
            this.Name = "DecoratorForm";
            this.Text = "Car + Decorators";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbKind;
        private System.Windows.Forms.CheckedListBox CbDecorators;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.TextBox EdLog;
    }
}

