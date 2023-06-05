namespace GetPutCalc
{
    partial class GetPutCalc
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
            this.EMin = new System.Windows.Forms.TextBox();
            this.EAvg = new System.Windows.Forms.TextBox();
            this.EMax = new System.Windows.Forms.TextBox();
            this.BtnPut = new System.Windows.Forms.Button();
            this.BtnGet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ECount
            // 
            this.ECount.Location = new System.Drawing.Point(32, 19);
            this.ECount.Name = "ECount";
            this.ECount.ReadOnly = true;
            this.ECount.Size = new System.Drawing.Size(100, 20);
            this.ECount.TabIndex = 0;
            this.ECount.TabStop = false;
            this.ECount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EMin
            // 
            this.EMin.Location = new System.Drawing.Point(161, 19);
            this.EMin.Name = "EMin";
            this.EMin.ReadOnly = true;
            this.EMin.Size = new System.Drawing.Size(100, 20);
            this.EMin.TabIndex = 1;
            this.EMin.TabStop = false;
            this.EMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EAvg
            // 
            this.EAvg.Location = new System.Drawing.Point(297, 19);
            this.EAvg.Name = "EAvg";
            this.EAvg.ReadOnly = true;
            this.EAvg.Size = new System.Drawing.Size(100, 20);
            this.EAvg.TabIndex = 2;
            this.EAvg.TabStop = false;
            this.EAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EMax
            // 
            this.EMax.Location = new System.Drawing.Point(431, 19);
            this.EMax.Name = "EMax";
            this.EMax.ReadOnly = true;
            this.EMax.Size = new System.Drawing.Size(100, 20);
            this.EMax.TabIndex = 3;
            this.EMax.TabStop = false;
            this.EMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnPut
            // 
            this.BtnPut.Location = new System.Drawing.Point(161, 84);
            this.BtnPut.Name = "BtnPut";
            this.BtnPut.Size = new System.Drawing.Size(75, 23);
            this.BtnPut.TabIndex = 4;
            this.BtnPut.Text = "&Put";
            this.BtnPut.UseVisualStyleBackColor = true;
            this.BtnPut.Click += new System.EventHandler(this.BtnPut_Click);
            // 
            // BtnGet
            // 
            this.BtnGet.Location = new System.Drawing.Point(322, 84);
            this.BtnGet.Name = "BtnGet";
            this.BtnGet.Size = new System.Drawing.Size(75, 23);
            this.BtnGet.TabIndex = 5;
            this.BtnGet.Text = "&Get";
            this.BtnGet.UseVisualStyleBackColor = true;
            this.BtnGet.Click += new System.EventHandler(this.BtnGet_Click);
            // 
            // GetPutCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 161);
            this.Controls.Add(this.BtnGet);
            this.Controls.Add(this.BtnPut);
            this.Controls.Add(this.EMax);
            this.Controls.Add(this.EAvg);
            this.Controls.Add(this.EMin);
            this.Controls.Add(this.ECount);
            this.Name = "GetPutCalc";
            this.Text = "Obliczenia";
            this.Load += new System.EventHandler(this.GetPutCalc_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GetPutCalc_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ECount;
        private System.Windows.Forms.TextBox EMin;
        private System.Windows.Forms.TextBox EAvg;
        private System.Windows.Forms.TextBox EMax;
        private System.Windows.Forms.Button BtnPut;
        private System.Windows.Forms.Button BtnGet;
    }
}

