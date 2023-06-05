namespace SimpleCalculator
{
    partial class SimpleCalculatorForm
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
            this.TbValueB = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.TbResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TbValueA
            // 
            this.TbValueA.Location = new System.Drawing.Point(12, 12);
            this.TbValueA.Name = "TbValueA";
            this.TbValueA.Size = new System.Drawing.Size(100, 20);
            this.TbValueA.TabIndex = 0;
            this.TbValueA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // TbValueB
            // 
            this.TbValueB.Location = new System.Drawing.Point(180, 12);
            this.TbValueB.Name = "TbValueB";
            this.TbValueB.Size = new System.Drawing.Size(100, 20);
            this.TbValueB.TabIndex = 2;
            this.TbValueB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCalculate.Location = new System.Drawing.Point(393, 10);
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
            this.TbResults.Location = new System.Drawing.Point(12, 39);
            this.TbResults.Multiline = true;
            this.TbResults.Name = "TbResults";
            this.TbResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbResults.Size = new System.Drawing.Size(456, 210);
            this.TbResults.TabIndex = 4;
            this.TbResults.WordWrap = false;
            // 
            // SimpleCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 261);
            this.Controls.Add(this.TbResults);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.TbValueB);
            this.Controls.Add(this.CbOperation);
            this.Controls.Add(this.TbValueA);
            this.Name = "SimpleCalculatorForm";
            this.Text = "Prosty kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbValueA;
        private System.Windows.Forms.ComboBox CbOperation;
        private System.Windows.Forms.TextBox TbValueB;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.TextBox TbResults;
    }
}

