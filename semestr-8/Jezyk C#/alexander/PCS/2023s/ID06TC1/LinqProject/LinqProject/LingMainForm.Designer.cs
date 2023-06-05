namespace LinqProject
{
    partial class LingMainForm
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
            this.CbMethod = new System.Windows.Forms.ComboBox();
            this.BtnGo = new System.Windows.Forms.Button();
            this.TbLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CbMethod
            // 
            this.CbMethod.FormattingEnabled = true;
            this.CbMethod.Location = new System.Drawing.Point(12, 12);
            this.CbMethod.Name = "CbMethod";
            this.CbMethod.Size = new System.Drawing.Size(121, 21);
            this.CbMethod.TabIndex = 0;
            // 
            // BtnGo
            // 
            this.BtnGo.Location = new System.Drawing.Point(139, 10);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(75, 23);
            this.BtnGo.TabIndex = 1;
            this.BtnGo.Text = "Go";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // TbLog
            // 
            this.TbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbLog.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TbLog.Location = new System.Drawing.Point(12, 39);
            this.TbLog.Multiline = true;
            this.TbLog.Name = "TbLog";
            this.TbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbLog.Size = new System.Drawing.Size(1005, 456);
            this.TbLog.TabIndex = 2;
            this.TbLog.WordWrap = false;
            // 
            // LingMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 507);
            this.Controls.Add(this.TbLog);
            this.Controls.Add(this.BtnGo);
            this.Controls.Add(this.CbMethod);
            this.Name = "LingMainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbMethod;
        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.TextBox TbLog;
    }
}

