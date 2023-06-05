namespace HarmCount
{
    partial class HarmCount
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
            this.BtnCount = new System.Windows.Forms.Button();
            this.LbResult = new System.Windows.Forms.Label();
            this.Counter = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // EdCount
            // 
            this.EdCount.Location = new System.Drawing.Point(13, 13);
            this.EdCount.Name = "EdCount";
            this.EdCount.Size = new System.Drawing.Size(100, 20);
            this.EdCount.TabIndex = 0;
            this.EdCount.Text = "1000000";
            this.EdCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnCount
            // 
            this.BtnCount.Location = new System.Drawing.Point(119, 11);
            this.BtnCount.Name = "BtnCount";
            this.BtnCount.Size = new System.Drawing.Size(75, 23);
            this.BtnCount.TabIndex = 1;
            this.BtnCount.Text = "Calc";
            this.BtnCount.UseVisualStyleBackColor = true;
            this.BtnCount.Click += new System.EventHandler(this.BtnCount_Click);
            // 
            // LbResult
            // 
            this.LbResult.AutoSize = true;
            this.LbResult.Location = new System.Drawing.Point(12, 36);
            this.LbResult.Name = "LbResult";
            this.LbResult.Size = new System.Drawing.Size(45, 13);
            this.LbResult.TabIndex = 2;
            this.LbResult.Text = "Results:";
            // 
            // Counter
            // 
            this.Counter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Counter_DoWork);
            // 
            // HarmCount
            // 
            this.AcceptButton = this.BtnCount;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 265);
            this.Controls.Add(this.LbResult);
            this.Controls.Add(this.BtnCount);
            this.Controls.Add(this.EdCount);
            this.Name = "HarmCount";
            this.Text = "Suma ciągu Harmonicznego ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EdCount;
        private System.Windows.Forms.Button BtnCount;
        private System.Windows.Forms.Label LbResult;
        private System.ComponentModel.BackgroundWorker Counter;
    }
}

