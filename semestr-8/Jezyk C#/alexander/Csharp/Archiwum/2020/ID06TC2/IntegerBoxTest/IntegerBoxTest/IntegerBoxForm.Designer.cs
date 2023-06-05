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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.integerBox2 = new IntegerBoxLib.IntegerBox();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // integerBox2
            // 
            this.integerBox2.Location = new System.Drawing.Point(285, 148);
            this.integerBox2.Name = "integerBox2";
            this.integerBox2.Size = new System.Drawing.Size(100, 20);
            this.integerBox2.TabIndex = 1;
            this.integerBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.integerBox2.Value = ((long)(123));
            // 
            // IntegerBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 273);
            this.Controls.Add(this.integerBox2);
            this.Name = "IntegerBoxForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private IntegerBoxLib.IntegerBox integerBox2;
    }
}

