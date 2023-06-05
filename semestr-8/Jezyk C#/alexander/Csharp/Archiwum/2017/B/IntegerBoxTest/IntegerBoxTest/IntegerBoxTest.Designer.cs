namespace IntegerBoxTest
{
    partial class IntegerBoxTest
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
            this.integerBox1 = new IntegerBox.IntegerBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ellipseButton1 = new SpecialLibrary.EllipseButton();
            this.SuspendLayout();
            // 
            // integerBox1
            // 
            this.integerBox1.Location = new System.Drawing.Point(40, 40);
            this.integerBox1.Name = "integerBox1";
            this.integerBox1.Size = new System.Drawing.Size(100, 20);
            this.integerBox1.TabIndex = 0;
            this.integerBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.integerBox1.Value = ((long)(7567));
            this.integerBox1.TextChanged += new System.EventHandler(this.integerBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // ellipseButton1
            // 
            this.ellipseButton1.BackColorTo = System.Drawing.SystemColors.ControlDark;
            this.ellipseButton1.GradientStep = ((uint)(64u));
            this.ellipseButton1.HoverColor = System.Drawing.SystemColors.ControlLightLight;
            this.ellipseButton1.HoverColorTo = System.Drawing.SystemColors.ControlDark;
            this.ellipseButton1.Location = new System.Drawing.Point(127, 50);
            this.ellipseButton1.Name = "ellipseButton1";
            this.ellipseButton1.Size = new System.Drawing.Size(109, 69);
            this.ellipseButton1.TabIndex = 2;
            this.ellipseButton1.Text = "ellipseButton1";
            this.ellipseButton1.UseVisualStyleBackColor = true;
            // 
            // IntegerBoxTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ellipseButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.integerBox1);
            this.Name = "IntegerBoxTest";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IntegerBox.IntegerBox integerBox1;
        private System.Windows.Forms.TextBox textBox1;
        private SpecialLibrary.EllipseButton ellipseButton1;
    }
}

