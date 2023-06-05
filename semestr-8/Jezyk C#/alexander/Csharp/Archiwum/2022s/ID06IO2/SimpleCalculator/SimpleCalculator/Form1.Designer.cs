namespace SimpleCalculator
{
    partial class Form1
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
            this.TbValueA = new System.Windows.Forms.TextBox();
            this.TbValueB = new System.Windows.Forms.TextBox();
            this.TbResult = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbValueA
            // 
            this.TbValueA.Location = new System.Drawing.Point(12, 12);
            this.TbValueA.Name = "TbValueA";
            this.TbValueA.Size = new System.Drawing.Size(100, 20);
            this.TbValueA.TabIndex = 0;
            this.TbValueA.Text = "0";
            this.TbValueA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TbValueB
            // 
            this.TbValueB.Location = new System.Drawing.Point(12, 38);
            this.TbValueB.Name = "TbValueB";
            this.TbValueB.Size = new System.Drawing.Size(100, 20);
            this.TbValueB.TabIndex = 1;
            this.TbValueB.Text = "0";
            this.TbValueB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TbResult
            // 
            this.TbResult.Location = new System.Drawing.Point(12, 93);
            this.TbResult.Name = "TbResult";
            this.TbResult.Size = new System.Drawing.Size(100, 20);
            this.TbResult.TabIndex = 2;
            this.TbResult.Text = "0";
            this.TbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(12, 64);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 3;
            this.BtnCalculate.Text = "Policz";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 262);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.TbResult);
            this.Controls.Add(this.TbValueB);
            this.Controls.Add(this.TbValueA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbValueA;
        private System.Windows.Forms.TextBox TbValueB;
        private System.Windows.Forms.TextBox TbResult;
        private System.Windows.Forms.Button BtnCalculate;
    }
}

