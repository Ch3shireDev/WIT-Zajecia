namespace IntegerBoxTest
{
    partial class IntegerBoxTest
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.integerBox1 = new IntegerBoxTest.IntegerBox();
            this.SuspendLayout();
            // 
            // integerBox1
            // 
            this.integerBox1.Location = new System.Drawing.Point(225, 89);
            this.integerBox1.Name = "integerBox1";
            this.integerBox1.Size = new System.Drawing.Size(125, 20);
            this.integerBox1.TabIndex = 0;
            this.integerBox1.Text = "365";
            this.integerBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.integerBox1.Value = ((long)(365));
            // 
            // IntegerBoxTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.integerBox1);
            this.Name = "IntegerBoxTest";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private IntegerBox integerBox1;
    }
}

