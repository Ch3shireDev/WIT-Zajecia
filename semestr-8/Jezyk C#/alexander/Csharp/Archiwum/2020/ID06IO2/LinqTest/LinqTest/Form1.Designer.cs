namespace LinqTest
{
    partial class LinqForm
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
            this.LbMethod = new System.Windows.Forms.ListBox();
            this.BtnRun = new System.Windows.Forms.Button();
            this.EdLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LbMethod
            // 
            this.LbMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbMethod.FormattingEnabled = true;
            this.LbMethod.Location = new System.Drawing.Point(12, 12);
            this.LbMethod.Name = "LbMethod";
            this.LbMethod.Size = new System.Drawing.Size(120, 342);
            this.LbMethod.TabIndex = 0;
            // 
            // BtnRun
            // 
            this.BtnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnRun.Location = new System.Drawing.Point(12, 361);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(120, 23);
            this.BtnRun.TabIndex = 1;
            this.BtnRun.Text = "Run";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // EdLog
            // 
            this.EdLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdLog.Location = new System.Drawing.Point(138, 12);
            this.EdLog.Multiline = true;
            this.EdLog.Name = "EdLog";
            this.EdLog.Size = new System.Drawing.Size(659, 372);
            this.EdLog.TabIndex = 2;
            // 
            // LinqForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 396);
            this.Controls.Add(this.EdLog);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.LbMethod);
            this.Name = "LinqForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbMethod;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.TextBox EdLog;
    }
}

