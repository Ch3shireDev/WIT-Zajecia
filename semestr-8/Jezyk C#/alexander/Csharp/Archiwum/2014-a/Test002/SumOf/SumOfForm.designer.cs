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
            this.BtnCalc = new System.Windows.Forms.Button();
            this.ResultValue = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ProgrssLabel = new System.Windows.Forms.Label();
            this.ProgressBox = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CountValue
            // 
            this.CountValue.Location = new System.Drawing.Point(12, 21);
            this.CountValue.Name = "CountValue";
            this.CountValue.Size = new System.Drawing.Size(100, 20);
            this.CountValue.TabIndex = 1;
            this.CountValue.Text = "100000000";
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
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(118, 21);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(87, 20);
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
            this.ResultValue.Location = new System.Drawing.Point(356, 65);
            this.ResultValue.Multiline = true;
            this.ResultValue.Name = "ResultValue";
            this.ResultValue.ReadOnly = true;
            this.ResultValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultValue.Size = new System.Drawing.Size(324, 242);
            this.ResultValue.TabIndex = 5;
            this.ResultValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(353, 49);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(37, 13);
            this.ResultLabel.TabIndex = 6;
            this.ResultLabel.Text = "&Result";
            // 
            // ProgrssLabel
            // 
            this.ProgrssLabel.AutoSize = true;
            this.ProgrssLabel.Location = new System.Drawing.Point(9, 49);
            this.ProgrssLabel.Name = "ProgrssLabel";
            this.ProgrssLabel.Size = new System.Drawing.Size(48, 13);
            this.ProgrssLabel.TabIndex = 7;
            this.ProgrssLabel.Text = "Progress";
            // 
            // ProgressBox
            // 
            this.ProgressBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ProgressBox.AutoScroll = true;
            this.ProgressBox.Location = new System.Drawing.Point(12, 65);
            this.ProgressBox.Name = "ProgressBox";
            this.ProgressBox.Size = new System.Drawing.Size(338, 242);
            this.ProgressBox.TabIndex = 8;
            // 
            // SumForm
            // 
            this.AcceptButton = this.BtnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 319);
            this.Controls.Add(this.ProgressBox);
            this.Controls.Add(this.ProgrssLabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ResultValue);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.CountValue);
            this.Name = "SumForm";
            this.Text = "Sum of harmonic ...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SumForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CountValue;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.TextBox ResultValue;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label ProgrssLabel;
        private System.Windows.Forms.Panel ProgressBox;
    }
}

