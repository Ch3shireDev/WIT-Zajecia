namespace test022
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
            this.PCount = new System.Windows.Forms.NumericUpDown();
            this.KCount = new System.Windows.Forms.NumericUpDown();
            this.Box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KCount)).BeginInit();
            this.SuspendLayout();
            // 
            // PCount
            // 
            this.PCount.Location = new System.Drawing.Point(12, 12);
            this.PCount.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.PCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PCount.Name = "PCount";
            this.PCount.Size = new System.Drawing.Size(40, 20);
            this.PCount.TabIndex = 0;
            this.PCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PCount.ValueChanged += new System.EventHandler(this.PCount_ValueChanged);
            // 
            // KCount
            // 
            this.KCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KCount.Location = new System.Drawing.Point(218, 12);
            this.KCount.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.KCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.KCount.Name = "KCount";
            this.KCount.Size = new System.Drawing.Size(40, 20);
            this.KCount.TabIndex = 1;
            this.KCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.KCount.ValueChanged += new System.EventHandler(this.KCount_ValueChanged);
            // 
            // Box
            // 
            this.Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Box.Location = new System.Drawing.Point(12, 49);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(246, 20);
            this.Box.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 81);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.KCount);
            this.Controls.Add(this.PCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown PCount;
        private System.Windows.Forms.NumericUpDown KCount;
        private System.Windows.Forms.TextBox Box;
    }
}

