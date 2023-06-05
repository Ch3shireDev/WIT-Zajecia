namespace IntegerEditTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.integerBox1 = new SpecialLibrary.IntegerBox();
            this.ellipseButton1 = new SpecialLibrary.EllipseButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 124);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // integerBox1
            // 
            this.integerBox1.Location = new System.Drawing.Point(150, 130);
            this.integerBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.integerBox1.Name = "integerBox1";
            this.integerBox1.Size = new System.Drawing.Size(164, 28);
            this.integerBox1.TabIndex = 0;
            this.integerBox1.Text = "12365";
            this.integerBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.integerBox1.Value = ((long)(12365));
            // 
            // ellipseButton1
            // 
            this.ellipseButton1.BackColorTo = System.Drawing.Color.DimGray;
            this.ellipseButton1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ellipseButton1.GradientStep = ((uint)(128u));
            this.ellipseButton1.HoverColor = System.Drawing.SystemColors.ControlLightLight;
            this.ellipseButton1.HoverColorTo = System.Drawing.SystemColors.ControlDark;
            this.ellipseButton1.Location = new System.Drawing.Point(207, 230);
            this.ellipseButton1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ellipseButton1.Name = "ellipseButton1";
            this.ellipseButton1.Size = new System.Drawing.Size(347, 157);
            this.ellipseButton1.TabIndex = 1;
            this.ellipseButton1.Text = "lxxxxxxxxxxxxxxl";
            this.ellipseButton1.UseVisualStyleBackColor = true;
            this.ellipseButton1.Click += new System.EventHandler(this.ellipseButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ellipseButton1);
            this.Controls.Add(this.integerBox1);
            this.Font = new System.Drawing.Font("Arial", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SpecialLibrary.IntegerBox integerBox1;
        private SpecialLibrary.EllipseButton ellipseButton1;
        private System.Windows.Forms.Button button1;
    }
}

