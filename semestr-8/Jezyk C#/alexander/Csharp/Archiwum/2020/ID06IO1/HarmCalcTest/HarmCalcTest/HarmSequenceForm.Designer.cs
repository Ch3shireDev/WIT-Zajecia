namespace HarmCalcTest
{
    partial class HarmSequenceForm
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
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.EdLog = new System.Windows.Forms.TextBox();
            this.BtnMultiThreadCalculate = new System.Windows.Forms.Button();
            this.BtnMultiLockCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EdCount
            // 
            this.EdCount.Location = new System.Drawing.Point(12, 12);
            this.EdCount.Name = "EdCount";
            this.EdCount.Size = new System.Drawing.Size(182, 20);
            this.EdCount.TabIndex = 0;
            this.EdCount.TextChanged += new System.EventHandler(this.EdCount_TextChanged);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCalculate.Location = new System.Drawing.Point(511, 10);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 1;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // EdLog
            // 
            this.EdLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdLog.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdLog.Location = new System.Drawing.Point(12, 38);
            this.EdLog.Multiline = true;
            this.EdLog.Name = "EdLog";
            this.EdLog.Size = new System.Drawing.Size(574, 227);
            this.EdLog.TabIndex = 2;
            // 
            // BtnMultiThreadCalculate
            // 
            this.BtnMultiThreadCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMultiThreadCalculate.Location = new System.Drawing.Point(373, 10);
            this.BtnMultiThreadCalculate.Name = "BtnMultiThreadCalculate";
            this.BtnMultiThreadCalculate.Size = new System.Drawing.Size(132, 23);
            this.BtnMultiThreadCalculate.TabIndex = 3;
            this.BtnMultiThreadCalculate.Text = "MultiThread Calculate";
            this.BtnMultiThreadCalculate.UseVisualStyleBackColor = true;
            this.BtnMultiThreadCalculate.Click += new System.EventHandler(this.BtnMultiThreadCalculate_Click);
            // 
            // BtnMultiLockCalculate
            // 
            this.BtnMultiLockCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMultiLockCalculate.Location = new System.Drawing.Point(211, 10);
            this.BtnMultiLockCalculate.Name = "BtnMultiLockCalculate";
            this.BtnMultiLockCalculate.Size = new System.Drawing.Size(156, 23);
            this.BtnMultiLockCalculate.TabIndex = 4;
            this.BtnMultiLockCalculate.Text = "button1Multi Lock Callculate";
            this.BtnMultiLockCalculate.UseVisualStyleBackColor = true;
            this.BtnMultiLockCalculate.Click += new System.EventHandler(this.BtnMultiLockCalculate_Click);
            // 
            // HarmSequenceForm
            // 
            this.AcceptButton = this.BtnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 277);
            this.Controls.Add(this.BtnMultiLockCalculate);
            this.Controls.Add(this.BtnMultiThreadCalculate);
            this.Controls.Add(this.EdLog);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.EdCount);
            this.Name = "HarmSequenceForm";
            this.Text = "Harm Sequence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EdCount;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.TextBox EdLog;
        private System.Windows.Forms.Button BtnMultiThreadCalculate;
        private System.Windows.Forms.Button BtnMultiLockCalculate;
    }
}

