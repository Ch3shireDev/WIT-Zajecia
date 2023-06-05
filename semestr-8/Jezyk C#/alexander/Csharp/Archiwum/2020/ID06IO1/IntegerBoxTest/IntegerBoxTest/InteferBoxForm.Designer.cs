namespace IntegerBoxTest
{
    partial class InteferBoxForm
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
            this.integerBox1 = new IntegerBox.IntegerBox();
            this.integerBox2 = new IntegerBox.IntegerBox();
            this.integerBox3 = new IntegerBox.IntegerBox();
            this.integerBox4 = new IntegerBox.IntegerBox();
            this.integerBox5 = new IntegerBox.IntegerBox();
            this.integerBox6 = new IntegerBox.IntegerBox();
            this.integerBox7 = new IntegerBox.IntegerBox();
            this.SuspendLayout();
            // 
            // integerBox1
            // 
            this.integerBox1.Location = new System.Drawing.Point(239, 90);
            this.integerBox1.Name = "integerBox1";
            this.integerBox1.Size = new System.Drawing.Size(235, 20);
            this.integerBox1.TabIndex = 0;
            this.integerBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.integerBox1.Value = ((long)(0));
            // 
            // integerBox2
            // 
            this.integerBox2.Location = new System.Drawing.Point(239, 116);
            this.integerBox2.Name = "integerBox2";
            this.integerBox2.Size = new System.Drawing.Size(235, 20);
            this.integerBox2.TabIndex = 1;
            this.integerBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.integerBox2.Value = ((long)(0));
            // 
            // integerBox3
            // 
            this.integerBox3.Location = new System.Drawing.Point(239, 142);
            this.integerBox3.Name = "integerBox3";
            this.integerBox3.Size = new System.Drawing.Size(235, 20);
            this.integerBox3.TabIndex = 2;
            this.integerBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.integerBox3.Value = ((long)(0));
            // 
            // integerBox4
            // 
            this.integerBox4.Location = new System.Drawing.Point(239, 270);
            this.integerBox4.Name = "integerBox4";
            this.integerBox4.Size = new System.Drawing.Size(235, 20);
            this.integerBox4.TabIndex = 5;
            this.integerBox4.Value = ((long)(123));
            // 
            // integerBox5
            // 
            this.integerBox5.Location = new System.Drawing.Point(239, 244);
            this.integerBox5.Name = "integerBox5";
            this.integerBox5.Size = new System.Drawing.Size(235, 20);
            this.integerBox5.TabIndex = 4;
            this.integerBox5.Value = ((long)(123));
            // 
            // integerBox6
            // 
            this.integerBox6.Location = new System.Drawing.Point(239, 218);
            this.integerBox6.Name = "integerBox6";
            this.integerBox6.Size = new System.Drawing.Size(235, 20);
            this.integerBox6.TabIndex = 3;
            this.integerBox6.Value = ((long)(23455));
            // 
            // integerBox7
            // 
            this.integerBox7.Location = new System.Drawing.Point(618, 182);
            this.integerBox7.Name = "integerBox7";
            this.integerBox7.Size = new System.Drawing.Size(100, 20);
            this.integerBox7.TabIndex = 6;
            this.integerBox7.Value = ((long)(0));
            // 
            // InteferBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.integerBox7);
            this.Controls.Add(this.integerBox4);
            this.Controls.Add(this.integerBox5);
            this.Controls.Add(this.integerBox6);
            this.Controls.Add(this.integerBox3);
            this.Controls.Add(this.integerBox2);
            this.Controls.Add(this.integerBox1);
            this.Name = "InteferBoxForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IntegerBox.IntegerBox integerBox1;
        private IntegerBox.IntegerBox integerBox2;
        private IntegerBox.IntegerBox integerBox3;
        private IntegerBox.IntegerBox integerBox4;
        private IntegerBox.IntegerBox integerBox5;
        private IntegerBox.IntegerBox integerBox6;
        private IntegerBox.IntegerBox integerBox7;
    }
}

