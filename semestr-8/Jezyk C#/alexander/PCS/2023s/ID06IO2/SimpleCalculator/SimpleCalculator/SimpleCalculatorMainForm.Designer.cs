namespace SimpleCalculator
{
    partial class SimpleCalculatorMainForm
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
            this.TbOperandA = new System.Windows.Forms.TextBox();
            this.CbOperation = new System.Windows.Forms.ComboBox();
            this.TbOperandB = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.TbResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TbOperandA
            // 
            this.TbOperandA.Location = new System.Drawing.Point(12, 12);
            this.TbOperandA.Name = "TbOperandA";
            this.TbOperandA.Size = new System.Drawing.Size(100, 20);
            this.TbOperandA.TabIndex = 0;
            this.TbOperandA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CbOperation
            // 
            this.CbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbOperation.FormattingEnabled = true;
            this.CbOperation.Location = new System.Drawing.Point(118, 12);
            this.CbOperation.Name = "CbOperation";
            this.CbOperation.Size = new System.Drawing.Size(121, 21);
            this.CbOperation.TabIndex = 1;
            // 
            // TbOperandB
            // 
            this.TbOperandB.Location = new System.Drawing.Point(245, 13);
            this.TbOperandB.Name = "TbOperandB";
            this.TbOperandB.Size = new System.Drawing.Size(100, 20);
            this.TbOperandB.TabIndex = 2;
            this.TbOperandB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCalculate.Location = new System.Drawing.Point(521, 10);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 3;
            this.BtnCalculate.Text = "Oblicz";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // TbResults
            // 
            this.TbResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbResults.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TbResults.Location = new System.Drawing.Point(12, 38);
            this.TbResults.Multiline = true;
            this.TbResults.Name = "TbResults";
            this.TbResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbResults.Size = new System.Drawing.Size(584, 211);
            this.TbResults.TabIndex = 4;
            // 
            // SimpleCalculatorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 261);
            this.Controls.Add(this.TbResults);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.TbOperandB);
            this.Controls.Add(this.CbOperation);
            this.Controls.Add(this.TbOperandA);
            this.Name = "SimpleCalculatorMainForm";
            this.Text = "Prosty kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbOperandA;
        private System.Windows.Forms.ComboBox CbOperation;
        private System.Windows.Forms.TextBox TbOperandB;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.TextBox TbResults;
    }
}

