namespace TestLib
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
            this.components = new System.ComponentModel.Container();
            this.int32Box1 = new AddBox.Int32Box(this.components);
            this.SuspendLayout();
            // 
            // int32Box1
            // 
            this.int32Box1.Location = new System.Drawing.Point(202, 107);
            this.int32Box1.Name = "int32Box1";
            this.int32Box1.Size = new System.Drawing.Size(100, 20);
            this.int32Box1.TabIndex = 0;
            this.int32Box1.Text = "1263";
            this.int32Box1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.int32Box1.Value = 1263;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 266);
            this.Controls.Add(this.int32Box1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AddBox.Int32Box int32Box1;

    }
}

