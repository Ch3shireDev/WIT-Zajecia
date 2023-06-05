namespace SumOf
{
    partial class SumForm
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
            this.CountValue = new System.Windows.Forms.TextBox();
            this.CountLabel = new System.Windows.Forms.Label();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.ResultValue = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CountValue
            // 
            this.CountValue.Location = new System.Drawing.Point(12, 21);
            this.CountValue.Name = "CountValue";
            this.CountValue.Size = new System.Drawing.Size(100, 20);
            this.CountValue.TabIndex = 1;
            this.CountValue.Text = "1000000";
            this.CountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CountValue.WordWrap = false;
            this.CountValue.TextChanged += new System.EventHandler(this.CountValue_TextChanged);
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Location = new System.Drawing.Point(9, 5);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(35, 13);
            this.CountLabel.TabIndex = 2;
            this.CountLabel.Text = "&Count";
            // 
            // Progress
            // 
            this.Progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Progress.Location = new System.Drawing.Point(12, 47);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(666, 23);
            this.Progress.TabIndex = 3;
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(118, 18);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtnCalc.TabIndex = 4;
            this.BtnCalc.Text = "Calculate";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // ResultValue
            // 
            this.ResultValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultValue.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResultValue.Location = new System.Drawing.Point(12, 93);
            this.ResultValue.Multiline = true;
            this.ResultValue.Name = "ResultValue";
            this.ResultValue.ReadOnly = true;
            this.ResultValue.Size = new System.Drawing.Size(666, 242);
            this.ResultValue.TabIndex = 5;
            this.ResultValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(12, 77);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(37, 13);
            this.ResultLabel.TabIndex = 6;
            this.ResultLabel.Text = "&Result";
            // 
            // SumForm
            // 
            this.AcceptButton = this.BtnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 347);
            this.Controls.Add(this.ResultValue);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.CountValue);
            this.Name = "SumForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CountValue;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.TextBox ResultValue;
        private System.Windows.Forms.Label ResultLabel;
    }
}

