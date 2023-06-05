namespace Harmonic
{
    partial class Harmonic
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
            this.LbCount = new System.Windows.Forms.Label();
            this.EdCount = new System.Windows.Forms.TextBox();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LbCount
            // 
            this.LbCount.AutoSize = true;
            this.LbCount.Location = new System.Drawing.Point(12, 9);
            this.LbCount.Name = "LbCount";
            this.LbCount.Size = new System.Drawing.Size(35, 13);
            this.LbCount.TabIndex = 0;
            this.LbCount.Text = "&Count";
            // 
            // EdCount
            // 
            this.EdCount.Location = new System.Drawing.Point(12, 26);
            this.EdCount.Name = "EdCount";
            this.EdCount.Size = new System.Drawing.Size(75, 20);
            this.EdCount.TabIndex = 1;
            this.EdCount.Text = "1000000";
            this.EdCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EdCount.TextChanged += new System.EventHandler(this.EdCount_TextChanged);
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(12, 52);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtnCalc.TabIndex = 2;
            this.BtnCalc.Text = "Calc";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // Results
            // 
            this.Results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Results.Location = new System.Drawing.Point(93, 6);
            this.Results.Multiline = true;
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Results.Size = new System.Drawing.Size(236, 244);
            this.Results.TabIndex = 3;
            // 
            // Harmonic
            // 
            this.AcceptButton = this.BtnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 262);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.EdCount);
            this.Controls.Add(this.LbCount);
            this.Name = "Harmonic";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbCount;
        private System.Windows.Forms.TextBox EdCount;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.TextBox Results;
    }
}

