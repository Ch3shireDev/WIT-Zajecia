namespace Test019
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
            this.Count = new System.Windows.Forms.TextBox();
            this.Value = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.bw1 = new System.ComponentModel.BackgroundWorker();
            this.bw2 = new System.ComponentModel.BackgroundWorker();
            this.bw3 = new System.ComponentModel.BackgroundWorker();
            this.bw4 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(98, 23);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(100, 20);
            this.Count.TabIndex = 0;
            this.Count.Text = "1000000000";
            this.Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(98, 78);
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Size = new System.Drawing.Size(149, 20);
            this.Value.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(98, 49);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "&Calc";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // bw1
            // 
            this.bw1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw1_DoWork);
            this.bw1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // bw2
            // 
            this.bw2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw2_DoWork);
            this.bw2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // bw3
            // 
            this.bw3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw3_DoWork);
            this.bw3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // bw4
            // 
            this.bw4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw4_DoWork);
            this.bw4.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.Count);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Button btnRun;
        private System.ComponentModel.BackgroundWorker bw1;
        private System.ComponentModel.BackgroundWorker bw2;
        private System.ComponentModel.BackgroundWorker bw3;
        private System.ComponentModel.BackgroundWorker bw4;
    }
}

