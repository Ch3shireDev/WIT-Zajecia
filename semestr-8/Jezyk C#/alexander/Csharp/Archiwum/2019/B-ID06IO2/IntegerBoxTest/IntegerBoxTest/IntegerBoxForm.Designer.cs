namespace IntegerBoxTest
{
    partial class IntegerBoxForm
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.integerBox1 = new IntegerBoxTest.IntegerBox(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 116);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // integerBox1
            // 
            this.integerBox1.Location = new System.Drawing.Point(66, 49);
            this.integerBox1.Name = "integerBox1";
            this.integerBox1.Size = new System.Drawing.Size(100, 20);
            this.integerBox1.TabIndex = 0;
            this.integerBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.integerBox1.Value = 103;
            // 
            // IntegerBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.integerBox1);
            this.Name = "IntegerBoxForm";
            this.Text = "IntegerBoxForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IntegerBox integerBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}