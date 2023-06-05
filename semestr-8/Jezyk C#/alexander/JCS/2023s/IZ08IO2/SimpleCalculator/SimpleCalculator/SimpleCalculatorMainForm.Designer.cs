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
            this.TbValueA = new System.Windows.Forms.TextBox();
            this.CbOperation = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TbValueB = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.TbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TbValueA
            // 
            this.TbValueA.Location = new System.Drawing.Point(12, 12);
            this.TbValueA.Name = "TbValueA";
            this.TbValueA.Size = new System.Drawing.Size(100, 20);
            this.TbValueA.TabIndex = 0;
            // 
            // CbOperation
            // 
            this.CbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbOperation.FormattingEnabled = true;
            this.CbOperation.Location = new System.Drawing.Point(118, 12);
            this.CbOperation.Name = "CbOperation";
            this.CbOperation.Size = new System.Drawing.Size(56, 21);
            this.CbOperation.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // TbValueB
            // 
            this.TbValueB.Location = new System.Drawing.Point(180, 13);
            this.TbValueB.Name = "TbValueB";
            this.TbValueB.Size = new System.Drawing.Size(100, 20);
            this.TbValueB.TabIndex = 2;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCalculate.Location = new System.Drawing.Point(568, 13);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 3;
            this.BtnCalculate.Text = "Oblicz";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // TbResult
            // 
            this.TbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbResult.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TbResult.Location = new System.Drawing.Point(12, 42);
            this.TbResult.Multiline = true;
            this.TbResult.Name = "TbResult";
            this.TbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbResult.Size = new System.Drawing.Size(631, 207);
            this.TbResult.TabIndex = 4;
            this.TbResult.WordWrap = false;
            // 
            // SimpleCalculatorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 261);
            this.Controls.Add(this.TbResult);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.TbValueB);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.CbOperation);
            this.Controls.Add(this.TbValueA);
            this.Name = "SimpleCalculatorMainForm";
            this.Text = "Prosty kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbValueA;
        private System.Windows.Forms.ComboBox CbOperation;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TbValueB;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.TextBox TbResult;
    }
}

