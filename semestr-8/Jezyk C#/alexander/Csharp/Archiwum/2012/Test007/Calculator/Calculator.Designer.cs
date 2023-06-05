namespace Calculator
{
    partial class Calculator
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
            this.Equ = new System.Windows.Forms.TextBox();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.OnpHow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Equ
            // 
            this.Equ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Equ.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Equ.Location = new System.Drawing.Point(3, 3);
            this.Equ.Multiline = true;
            this.Equ.Name = "Equ";
            this.Equ.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Equ.Size = new System.Drawing.Size(477, 210);
            this.Equ.TabIndex = 0;
            this.Equ.Text = "(3-9)*(1+2)^-3";
            // 
            // BtnCalc
            // 
            this.BtnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCalc.Location = new System.Drawing.Point(3, 219);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 26);
            this.BtnCalc.TabIndex = 1;
            this.BtnCalc.Text = "Licz";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // Result
            // 
            this.Result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Result.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Result.Location = new System.Drawing.Point(84, 219);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(536, 26);
            this.Result.TabIndex = 2;
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OnpHow
            // 
            this.OnpHow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.OnpHow.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OnpHow.Location = new System.Drawing.Point(486, 3);
            this.OnpHow.Multiline = true;
            this.OnpHow.Name = "OnpHow";
            this.OnpHow.ReadOnly = true;
            this.OnpHow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OnpHow.Size = new System.Drawing.Size(134, 210);
            this.OnpHow.TabIndex = 3;
            this.OnpHow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OnpHow.WordWrap = false;
            // 
            // Calculator
            // 
            this.AcceptButton = this.BtnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 251);
            this.Controls.Add(this.OnpHow);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.Equ);
            this.Name = "Calculator";
            this.Text = "Kalkulator ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Equ;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.TextBox OnpHow;
    }
}

