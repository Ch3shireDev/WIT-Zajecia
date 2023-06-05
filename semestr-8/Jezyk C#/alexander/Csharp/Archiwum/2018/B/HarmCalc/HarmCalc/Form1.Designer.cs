namespace HarmCalc
{
    partial class HarmCalc
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
            this.BtnCalc = new System.Windows.Forms.Button();
            this.LbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EdCount
            // 
            this.EdCount.Location = new System.Drawing.Point(12, 12);
            this.EdCount.Name = "EdCount";
            this.EdCount.Size = new System.Drawing.Size(100, 20);
            this.EdCount.TabIndex = 0;
            this.EdCount.Text = "10000000";
            this.EdCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(118, 10);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtnCalc.TabIndex = 1;
            this.BtnCalc.Text = "Calculate";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // LbResult
            // 
            this.LbResult.AutoSize = true;
            this.LbResult.Location = new System.Drawing.Point(12, 46);
            this.LbResult.Name = "LbResult";
            this.LbResult.Size = new System.Drawing.Size(42, 13);
            this.LbResult.TabIndex = 2;
            this.LbResult.Text = "Wyniki:";
            // 
            // HarmCalc
            // 
            this.AcceptButton = this.BtnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 170);
            this.Controls.Add(this.LbResult);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.EdCount);
            this.Name = "HarmCalc";
            this.Text = "Calculate Sum of Harmonic sequence ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EdCount;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Label LbResult;
    }
}

