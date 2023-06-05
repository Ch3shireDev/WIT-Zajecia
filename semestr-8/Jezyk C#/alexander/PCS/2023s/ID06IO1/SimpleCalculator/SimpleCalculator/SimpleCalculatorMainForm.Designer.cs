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
            this.TbValueB = new System.Windows.Forms.TextBox();
            this.CbOperation = new System.Windows.Forms.ComboBox();
            this.TbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TbValueA
            // 
            this.TbValueA.Location = new System.Drawing.Point(12, 12);
            this.TbValueA.Name = "TbValueA";
            this.TbValueA.Size = new System.Drawing.Size(100, 20);
            this.TbValueA.TabIndex = 0;
            this.TbValueA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbValueA.TextChanged += new System.EventHandler(this.CbOperation_SelectedIndexChanged);
            // 
            // TbValueB
            // 
            this.TbValueB.Location = new System.Drawing.Point(197, 12);
            this.TbValueB.Name = "TbValueB";
            this.TbValueB.Size = new System.Drawing.Size(100, 20);
            this.TbValueB.TabIndex = 1;
            this.TbValueB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbValueB.TextChanged += new System.EventHandler(this.CbOperation_SelectedIndexChanged);
            // 
            // CbOperation
            // 
            this.CbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbOperation.FormattingEnabled = true;
            this.CbOperation.Location = new System.Drawing.Point(118, 12);
            this.CbOperation.Name = "CbOperation";
            this.CbOperation.Size = new System.Drawing.Size(73, 21);
            this.CbOperation.TabIndex = 2;
            this.CbOperation.SelectedIndexChanged += new System.EventHandler(this.CbOperation_SelectedIndexChanged);
            // 
            // TbResult
            // 
            this.TbResult.Enabled = false;
            this.TbResult.Location = new System.Drawing.Point(303, 12);
            this.TbResult.Name = "TbResult";
            this.TbResult.ReadOnly = true;
            this.TbResult.Size = new System.Drawing.Size(100, 20);
            this.TbResult.TabIndex = 3;
            this.TbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SimpleCalculatorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 46);
            this.Controls.Add(this.TbResult);
            this.Controls.Add(this.CbOperation);
            this.Controls.Add(this.TbValueB);
            this.Controls.Add(this.TbValueA);
            this.Name = "SimpleCalculatorMainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbValueA;
        private System.Windows.Forms.TextBox TbValueB;
        private System.Windows.Forms.ComboBox CbOperation;
        private System.Windows.Forms.TextBox TbResult;
    }
}

