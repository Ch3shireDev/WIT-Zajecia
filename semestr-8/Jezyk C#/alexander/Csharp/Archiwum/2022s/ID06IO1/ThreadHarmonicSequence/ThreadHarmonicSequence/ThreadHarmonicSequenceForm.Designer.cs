namespace ThreadHarmonicSequence
{
    partial class ThreadHarmonicSequenceForm
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
            this.TbCount = new System.Windows.Forms.TextBox();
            this.BtnSimple = new System.Windows.Forms.Button();
            this.BtnThread = new System.Windows.Forms.Button();
            this.BtnParallel = new System.Windows.Forms.Button();
            this.TbLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TbCount
            // 
            this.TbCount.Location = new System.Drawing.Point(12, 12);
            this.TbCount.Name = "TbCount";
            this.TbCount.Size = new System.Drawing.Size(126, 20);
            this.TbCount.TabIndex = 0;
            this.TbCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbCount.TextChanged += new System.EventHandler(this.TbCount_TextChanged);
            // 
            // BtnSimple
            // 
            this.BtnSimple.Location = new System.Drawing.Point(144, 10);
            this.BtnSimple.Name = "BtnSimple";
            this.BtnSimple.Size = new System.Drawing.Size(75, 23);
            this.BtnSimple.TabIndex = 1;
            this.BtnSimple.Text = "Simple";
            this.BtnSimple.UseVisualStyleBackColor = true;
            this.BtnSimple.Click += new System.EventHandler(this.BtnSimple_Click);
            // 
            // BtnThread
            // 
            this.BtnThread.Location = new System.Drawing.Point(225, 10);
            this.BtnThread.Name = "BtnThread";
            this.BtnThread.Size = new System.Drawing.Size(75, 23);
            this.BtnThread.TabIndex = 2;
            this.BtnThread.Text = "Thread";
            this.BtnThread.UseVisualStyleBackColor = true;
            this.BtnThread.Click += new System.EventHandler(this.BtnThread_Click);
            // 
            // BtnParallel
            // 
            this.BtnParallel.Location = new System.Drawing.Point(306, 10);
            this.BtnParallel.Name = "BtnParallel";
            this.BtnParallel.Size = new System.Drawing.Size(75, 23);
            this.BtnParallel.TabIndex = 3;
            this.BtnParallel.Text = "Parallel";
            this.BtnParallel.UseVisualStyleBackColor = true;
            // 
            // TbLog
            // 
            this.TbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbLog.Location = new System.Drawing.Point(12, 38);
            this.TbLog.Multiline = true;
            this.TbLog.Name = "TbLog";
            this.TbLog.Size = new System.Drawing.Size(587, 212);
            this.TbLog.TabIndex = 4;
            // 
            // ThreadHarmonicSequenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 262);
            this.Controls.Add(this.TbLog);
            this.Controls.Add(this.BtnParallel);
            this.Controls.Add(this.BtnThread);
            this.Controls.Add(this.BtnSimple);
            this.Controls.Add(this.TbCount);
            this.Name = "ThreadHarmonicSequenceForm";
            this.Text = "Thread Harmonic Sequence Sum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbCount;
        private System.Windows.Forms.Button BtnSimple;
        private System.Windows.Forms.Button BtnThread;
        private System.Windows.Forms.Button BtnParallel;
        private System.Windows.Forms.TextBox TbLog;
    }
}

