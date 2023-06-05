namespace HarmCalcTest
{
    partial class HarmCalcForm
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
            this.EdLog = new System.Windows.Forms.TextBox();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.BtnThreadCalc = new System.Windows.Forms.Button();
            this.BtnMultiThreadCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EdCount
            // 
            this.EdCount.Location = new System.Drawing.Point(12, 12);
            this.EdCount.Name = "EdCount";
            this.EdCount.Size = new System.Drawing.Size(157, 20);
            this.EdCount.TabIndex = 0;
            this.EdCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EdCount.TextChanged += new System.EventHandler(this.EdCount_TextChanged);
            // 
            // EdLog
            // 
            this.EdLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdLog.Font = new System.Drawing.Font("Lucida Console", 8.25F);
            this.EdLog.Location = new System.Drawing.Point(12, 38);
            this.EdLog.Multiline = true;
            this.EdLog.Name = "EdLog";
            this.EdLog.Size = new System.Drawing.Size(776, 333);
            this.EdLog.TabIndex = 1;
            // 
            // BtnCalc
            // 
            this.BtnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCalc.Location = new System.Drawing.Point(713, 10);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtnCalc.TabIndex = 2;
            this.BtnCalc.Text = "Calc";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // BtnThreadCalc
            // 
            this.BtnThreadCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnThreadCalc.Location = new System.Drawing.Point(588, 10);
            this.BtnThreadCalc.Name = "BtnThreadCalc";
            this.BtnThreadCalc.Size = new System.Drawing.Size(119, 23);
            this.BtnThreadCalc.TabIndex = 3;
            this.BtnThreadCalc.Text = "Thread Calc";
            this.BtnThreadCalc.UseVisualStyleBackColor = true;
            this.BtnThreadCalc.Click += new System.EventHandler(this.BtnThreadCalc_Click);
            // 
            // BtnMultiThreadCalc
            // 
            this.BtnMultiThreadCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMultiThreadCalc.Location = new System.Drawing.Point(411, 10);
            this.BtnMultiThreadCalc.Name = "BtnMultiThreadCalc";
            this.BtnMultiThreadCalc.Size = new System.Drawing.Size(171, 23);
            this.BtnMultiThreadCalc.TabIndex = 4;
            this.BtnMultiThreadCalc.Text = "Multi Thread Calc";
            this.BtnMultiThreadCalc.UseVisualStyleBackColor = true;
            this.BtnMultiThreadCalc.Click += new System.EventHandler(this.BtnMultiThreadCalc_Click);
            // 
            // HarmCalcForm
            // 
            this.AcceptButton = this.BtnMultiThreadCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 383);
            this.Controls.Add(this.BtnMultiThreadCalc);
            this.Controls.Add(this.BtnThreadCalc);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.EdLog);
            this.Controls.Add(this.EdCount);
            this.Name = "HarmCalcForm";
            this.Text = "Harmonic Sequence sum ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EdCount;
        private System.Windows.Forms.TextBox EdLog;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Button BtnThreadCalc;
        private System.Windows.Forms.Button BtnMultiThreadCalc;
    }
}

