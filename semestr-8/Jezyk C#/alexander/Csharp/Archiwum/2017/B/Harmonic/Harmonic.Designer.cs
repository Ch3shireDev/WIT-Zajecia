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
            this.ECount = new System.Windows.Forms.TextBox();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.EResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ECount
            // 
            this.ECount.Location = new System.Drawing.Point(13, 13);
            this.ECount.Name = "ECount";
            this.ECount.Size = new System.Drawing.Size(74, 20);
            this.ECount.TabIndex = 0;
            this.ECount.Text = "10000000";
            this.ECount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ECount.TextChanged += new System.EventHandler(this.ECount_TextChanged);
            // 
            // BtnCalc
            // 
            this.BtnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCalc.Enabled = false;
            this.BtnCalc.Location = new System.Drawing.Point(216, 10);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtnCalc.TabIndex = 1;
            this.BtnCalc.Text = "&Calc";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // EResult
            // 
            this.EResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EResult.Location = new System.Drawing.Point(12, 39);
            this.EResult.Multiline = true;
            this.EResult.Name = "EResult";
            this.EResult.ReadOnly = true;
            this.EResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EResult.Size = new System.Drawing.Size(279, 192);
            this.EResult.TabIndex = 2;
            this.EResult.WordWrap = false;
            // 
            // Harmonic
            // 
            this.AcceptButton = this.BtnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 243);
            this.Controls.Add(this.EResult);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.ECount);
            this.Name = "Harmonic";
            this.Text = "Harmonic ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ECount;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.TextBox EResult;
    }
}

