namespace Harmonic
{
    partial class HarmonicSumForm
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
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnSimple = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnThread = new System.Windows.Forms.Button();
            this.btnMultiThread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(12, 12);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 0;
            this.txtCount.Text = "1000000000";
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            // 
            // btnSimple
            // 
            this.btnSimple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimple.Location = new System.Drawing.Point(540, 10);
            this.btnSimple.Name = "btnSimple";
            this.btnSimple.Size = new System.Drawing.Size(75, 23);
            this.btnSimple.TabIndex = 1;
            this.btnSimple.Text = "Simple";
            this.btnSimple.UseVisualStyleBackColor = true;
            this.btnSimple.Click += new System.EventHandler(this.btnSimple_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 38);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(603, 212);
            this.txtLog.TabIndex = 2;
            // 
            // btnThread
            // 
            this.btnThread.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThread.Location = new System.Drawing.Point(459, 10);
            this.btnThread.Name = "btnThread";
            this.btnThread.Size = new System.Drawing.Size(75, 23);
            this.btnThread.TabIndex = 3;
            this.btnThread.Text = "One Thread";
            this.btnThread.UseVisualStyleBackColor = true;
            this.btnThread.Click += new System.EventHandler(this.btnThread_Click);
            // 
            // btnMultiThread
            // 
            this.btnMultiThread.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMultiThread.Location = new System.Drawing.Point(378, 9);
            this.btnMultiThread.Name = "btnMultiThread";
            this.btnMultiThread.Size = new System.Drawing.Size(75, 23);
            this.btnMultiThread.TabIndex = 4;
            this.btnMultiThread.Text = "Multi";
            this.btnMultiThread.UseVisualStyleBackColor = true;
            this.btnMultiThread.Click += new System.EventHandler(this.btnMultiThread_Click);
            // 
            // HarmonicSumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 262);
            this.Controls.Add(this.btnMultiThread);
            this.Controls.Add(this.btnThread);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnSimple);
            this.Controls.Add(this.txtCount);
            this.Name = "HarmonicSumForm";
            this.Text = "Harmonic Sum Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnSimple;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnThread;
        private System.Windows.Forms.Button btnMultiThread;
    }
}

