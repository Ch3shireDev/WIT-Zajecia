namespace Test008
{
    partial class Form1
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
            this.integerBox2 = new SpecialBox.IntegerBox();
            this.integerBox1 = new SpecialBox.IntegerBox();
            this.SuspendLayout();
            // 
            // integerBox2
            // 
            this.integerBox2.Location = new System.Drawing.Point(58, 88);
            this.integerBox2.Name = "integerBox2";
            this.integerBox2.Size = new System.Drawing.Size(100, 20);
            this.integerBox2.TabIndex = 2;
            this.integerBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.integerBox2.Value = 666;
            // 
            // integerBox1
            // 
            this.integerBox1.Location = new System.Drawing.Point(58, 43);
            this.integerBox1.Name = "integerBox1";
            this.integerBox1.Size = new System.Drawing.Size(100, 20);
            this.integerBox1.TabIndex = 1;
            this.integerBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.integerBox1.Value = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.integerBox2);
            this.Controls.Add(this.integerBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SpecialBox.IntegerBox integerBox1;
        private SpecialBox.IntegerBox integerBox2;
    }
}

