namespace ThreadsCrib
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
            this.BtnWorker = new System.Windows.Forms.Button();
            this.Thread = new System.Windows.Forms.Button();
            this.EdLog = new System.Windows.Forms.TextBox();
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // BtnWorker
            // 
            this.BtnWorker.Location = new System.Drawing.Point(12, 12);
            this.BtnWorker.Name = "BtnWorker";
            this.BtnWorker.Size = new System.Drawing.Size(75, 23);
            this.BtnWorker.TabIndex = 0;
            this.BtnWorker.Text = "Worker";
            this.BtnWorker.UseVisualStyleBackColor = true;
            this.BtnWorker.Click += new System.EventHandler(this.BtnWorker_Click);
            // 
            // Thread
            // 
            this.Thread.Location = new System.Drawing.Point(102, 12);
            this.Thread.Name = "Thread";
            this.Thread.Size = new System.Drawing.Size(75, 23);
            this.Thread.TabIndex = 1;
            this.Thread.Text = "Thread";
            this.Thread.UseVisualStyleBackColor = true;
            this.Thread.Click += new System.EventHandler(this.Thread_Click);
            // 
            // EdLog
            // 
            this.EdLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdLog.Location = new System.Drawing.Point(12, 41);
            this.EdLog.Multiline = true;
            this.EdLog.Name = "EdLog";
            this.EdLog.ReadOnly = true;
            this.EdLog.Size = new System.Drawing.Size(678, 365);
            this.EdLog.TabIndex = 3;
            // 
            // bw
            // 
            this.bw.WorkerSupportsCancellation = true;
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_ProgressChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 418);
            this.Controls.Add(this.EdLog);
            this.Controls.Add(this.Thread);
            this.Controls.Add(this.BtnWorker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnWorker;
        private System.Windows.Forms.Button Thread;
        private System.Windows.Forms.TextBox EdLog;
        private System.ComponentModel.BackgroundWorker bw;
    }
}

