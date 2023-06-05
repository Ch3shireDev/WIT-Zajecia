namespace MatrixCalc
{
    partial class MatrixCalcForm
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
            this.EdVar = new System.Windows.Forms.TextBox();
            this.EdMatrix = new System.Windows.Forms.TextBox();
            this.EdRusult = new System.Windows.Forms.TextBox();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EdVar
            // 
            this.EdVar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdVar.Location = new System.Drawing.Point(12, 12);
            this.EdVar.Name = "EdVar";
            this.EdVar.Size = new System.Drawing.Size(541, 20);
            this.EdVar.TabIndex = 0;
            this.EdVar.Text = "4,62\t6,47\t5,68\t8,5";
            // 
            // EdMatrix
            // 
            this.EdMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdMatrix.Location = new System.Drawing.Point(12, 38);
            this.EdMatrix.Multiline = true;
            this.EdMatrix.Name = "EdMatrix";
            this.EdMatrix.Size = new System.Drawing.Size(541, 267);
            this.EdMatrix.TabIndex = 1;
            this.EdMatrix.Text = "4,75\t5,55\t5,24\t2,51\r\n" +
"8,16\t2,59\t7,19\t6,96\r\n" +
"5,23\t9,47\t1,35\t6,48\r\n" +
"5,08\t2,62\t9,71\t3,54"
;
            // 
            // EdRusult
            // 
            this.EdRusult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdRusult.Location = new System.Drawing.Point(559, 38);
            this.EdRusult.Multiline = true;
            this.EdRusult.Name = "EdRusult";
            this.EdRusult.Size = new System.Drawing.Size(100, 267);
            this.EdRusult.TabIndex = 2;
            // 
            // BtnCalc
            // 
            this.BtnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCalc.Location = new System.Drawing.Point(584, 311);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtnCalc.TabIndex = 3;
            this.BtnCalc.Text = "Calc";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // MatrixCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 346);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.EdRusult);
            this.Controls.Add(this.EdMatrix);
            this.Controls.Add(this.EdVar);
            this.Name = "MatrixCalcForm";
            this.Text = "Matrix Calc ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EdVar;
        private System.Windows.Forms.TextBox EdMatrix;
        private System.Windows.Forms.TextBox EdRusult;
        private System.Windows.Forms.Button BtnCalc;
    }
}

