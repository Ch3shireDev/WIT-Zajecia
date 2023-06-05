namespace SimpleCalculator
{
    partial class SimpleCalculatorMain
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
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.TbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TbValueA
            // 
            this.TbValueA.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TbValueA.Location = new System.Drawing.Point(12, 12);
            this.TbValueA.Name = "TbValueA";
            this.TbValueA.Size = new System.Drawing.Size(100, 18);
            this.TbValueA.TabIndex = 0;
            this.TbValueA.Text = "0";
            this.TbValueA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbValueA.TextChanged += new System.EventHandler(this.TbValueA_TextChanged);
            // 
            // TbValueB
            // 
            this.TbValueB.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TbValueB.Location = new System.Drawing.Point(12, 36);
            this.TbValueB.Name = "TbValueB";
            this.TbValueB.Size = new System.Drawing.Size(100, 18);
            this.TbValueB.TabIndex = 1;
            this.TbValueB.Text = "0";
            this.TbValueB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbValueB.TextChanged += new System.EventHandler(this.TbValueB_TextChanged);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(12, 60);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(100, 23);
            this.BtnCalculate.TabIndex = 2;
            this.BtnCalculate.Text = "=";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // TbResult
            // 
            this.TbResult.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TbResult.Location = new System.Drawing.Point(12, 89);
            this.TbResult.Name = "TbResult";
            this.TbResult.ReadOnly = true;
            this.TbResult.Size = new System.Drawing.Size(100, 18);
            this.TbResult.TabIndex = 3;
            this.TbResult.Text = "0";
            this.TbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SimpleCalculatorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.TbResult);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.TbValueB);
            this.Controls.Add(this.TbValueA);
            this.Name = "SimpleCalculatorMain";
            this.Text = "Simple Calculator ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbValueA;
        private System.Windows.Forms.TextBox TbValueB;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.TextBox TbResult;
    }
}

