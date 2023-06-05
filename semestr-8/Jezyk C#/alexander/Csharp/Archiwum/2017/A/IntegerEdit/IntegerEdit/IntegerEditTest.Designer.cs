namespace IntegerEditTest
{
    partial class IntegerEditTest
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
            this.integerEdit1 = new IntegerEdit.IntegerEdit();
            this.SuspendLayout();
            // 
            // integerEdit1
            // 
            this.integerEdit1.Location = new System.Drawing.Point(61, 85);
            this.integerEdit1.Name = "integerEdit1";
            this.integerEdit1.Size = new System.Drawing.Size(100, 20);
            this.integerEdit1.TabIndex = 0;
            this.integerEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.integerEdit1.Value = ((long)(0));
            // 
            // IntegerEditTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.integerEdit1);
            this.Name = "IntegerEditTest";
            this.Text = "IntegerEdit Test ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IntegerEdit.IntegerEdit integerEdit1;
    }
}

