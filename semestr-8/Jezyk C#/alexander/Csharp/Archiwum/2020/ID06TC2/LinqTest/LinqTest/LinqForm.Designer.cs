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
            this.EdLog = new System.Windows.Forms.TextBox();
            this.BtnCall = new System.Windows.Forms.Button();
            this.LbMethods = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // EdLog
            // 
            this.EdLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdLog.Location = new System.Drawing.Point(138, 8);
            this.EdLog.Multiline = true;
            this.EdLog.Name = "EdLog";
            this.EdLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EdLog.Size = new System.Drawing.Size(611, 306);
            this.EdLog.TabIndex = 5;
            this.EdLog.WordWrap = false;
            // 
            // BtnCall
            // 
            this.BtnCall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCall.Location = new System.Drawing.Point(12, 291);
            this.BtnCall.Name = "BtnCall";
            this.BtnCall.Size = new System.Drawing.Size(120, 23);
            this.BtnCall.TabIndex = 4;
            this.BtnCall.Text = "Call";
            this.BtnCall.UseVisualStyleBackColor = true;
            this.BtnCall.Click += new System.EventHandler(this.BtnCall_Click);
            // 
            // LbMethods
            // 
            this.LbMethods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbMethods.FormattingEnabled = true;
            this.LbMethods.Location = new System.Drawing.Point(12, 8);
            this.LbMethods.Name = "LbMethods";
            this.LbMethods.Size = new System.Drawing.Size(120, 277);
            this.LbMethods.TabIndex = 3;
            // 
            // LinqForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 326);
            this.Controls.Add(this.EdLog);
            this.Controls.Add(this.BtnCall);
            this.Controls.Add(this.LbMethods);
            this.Name = "LinqForm";
            this.Text = "Linq";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EdLog;
        private System.Windows.Forms.Button BtnCall;
        private System.Windows.Forms.ListBox LbMethods;
    }
}

