namespace HarmCalcSimple
{
    partial class HarmCalcSimple
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
            this.LbValue = new System.Windows.Forms.Label();
            this.EValue = new System.Windows.Forms.TextBox();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.EResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LbValue
            // 
            this.LbValue.AutoSize = true;
            this.LbValue.Location = new System.Drawing.Point(9, 15);
            this.LbValue.Name = "LbValue";
            this.LbValue.Size = new System.Drawing.Size(18, 13);
            this.LbValue.TabIndex = 0;
            this.LbValue.Text = "N:";
            // 
            // EValue
            // 
            this.EValue.Location = new System.Drawing.Point(33, 12);
            this.EValue.Name = "EValue";
            this.EValue.Size = new System.Drawing.Size(84, 20);
            this.EValue.TabIndex = 1;
            this.EValue.Text = "10000000000";
            this.EValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EValue.TextChanged += new System.EventHandler(this.EValue_TextChanged);
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(123, 10);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtnCalc.TabIndex = 2;
            this.BtnCalc.Text = "Licz";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // EResult
            // 
            this.EResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EResult.Location = new System.Drawing.Point(12, 38);
            this.EResult.Multiline = true;
            this.EResult.Name = "EResult";
            this.EResult.Size = new System.Drawing.Size(466, 370);
            this.EResult.TabIndex = 3;
            // 
            // HarmCalcSimple
            // 
            this.AcceptButton = this.BtnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 420);
            this.Controls.Add(this.EResult);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.EValue);
            this.Controls.Add(this.LbValue);
            this.Name = "HarmCalcSimple";
            this.Text = "Ciąg harmoniczny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbValue;
        private System.Windows.Forms.TextBox EValue;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.TextBox EResult;
    }
}

