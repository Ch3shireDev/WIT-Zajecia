namespace Threads
{
    partial class CharmonicSequence
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
            this.EdCount = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.EdLog = new System.Windows.Forms.TextBox();
            this.BTnThreadCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EdCount
            // 
            this.EdCount.Location = new System.Drawing.Point(12, 12);
            this.EdCount.Name = "EdCount";
            this.EdCount.Size = new System.Drawing.Size(100, 20);
            this.EdCount.TabIndex = 0;
            this.EdCount.Text = "100000000";
            this.EdCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EdCount.TextChanged += new System.EventHandler(this.EdCount_TextChanged);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCalculate.Location = new System.Drawing.Point(496, 12);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 1;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // EdLog
            // 
            this.EdLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdLog.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdLog.Location = new System.Drawing.Point(12, 38);
            this.EdLog.Multiline = true;
            this.EdLog.Name = "EdLog";
            this.EdLog.Size = new System.Drawing.Size(559, 275);
            this.EdLog.TabIndex = 2;
            // 
            // BTnThreadCalculate
            // 
            this.BTnThreadCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTnThreadCalculate.Location = new System.Drawing.Point(379, 12);
            this.BTnThreadCalculate.Name = "BTnThreadCalculate";
            this.BTnThreadCalculate.Size = new System.Drawing.Size(111, 23);
            this.BTnThreadCalculate.TabIndex = 3;
            this.BTnThreadCalculate.Text = "Thread Calculate";
            this.BTnThreadCalculate.UseVisualStyleBackColor = true;
            this.BTnThreadCalculate.Click += new System.EventHandler(this.BTnThreadCalculate_Click);
            // 
            // CharmonicSequence
            // 
            this.AcceptButton = this.BtnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 325);
            this.Controls.Add(this.BTnThreadCalculate);
            this.Controls.Add(this.EdLog);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.EdCount);
            this.Name = "CharmonicSequence";
            this.Text = "Harmonic sequence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EdCount;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.TextBox EdLog;
        private System.Windows.Forms.Button BTnThreadCalculate;
    }
}

