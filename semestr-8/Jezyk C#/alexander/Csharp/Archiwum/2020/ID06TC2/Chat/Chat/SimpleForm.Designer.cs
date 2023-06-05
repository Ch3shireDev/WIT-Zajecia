namespace Chat
{
    partial class SimpleForm
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
            this.BtnSum = new System.Windows.Forms.Button();
            this.EdA = new System.Windows.Forms.TextBox();
            this.EdB = new System.Windows.Forms.TextBox();
            this.EdC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSum
            // 
            this.BtnSum.Location = new System.Drawing.Point(12, 90);
            this.BtnSum.Name = "BtnSum";
            this.BtnSum.Size = new System.Drawing.Size(75, 23);
            this.BtnSum.TabIndex = 0;
            this.BtnSum.Text = "Sumuj";
            this.BtnSum.UseVisualStyleBackColor = true;
            this.BtnSum.Click += new System.EventHandler(this.button1_Click);
            // 
            // EdA
            // 
            this.EdA.Location = new System.Drawing.Point(12, 12);
            this.EdA.Name = "EdA";
            this.EdA.Size = new System.Drawing.Size(100, 20);
            this.EdA.TabIndex = 1;
            // 
            // EdB
            // 
            this.EdB.Location = new System.Drawing.Point(12, 38);
            this.EdB.Name = "EdB";
            this.EdB.Size = new System.Drawing.Size(100, 20);
            this.EdB.TabIndex = 2;
            // 
            // EdC
            // 
            this.EdC.Location = new System.Drawing.Point(12, 64);
            this.EdC.Name = "EdC";
            this.EdC.Size = new System.Drawing.Size(100, 20);
            this.EdC.TabIndex = 3;
            // 
            // SimpleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 262);
            this.Controls.Add(this.EdC);
            this.Controls.Add(this.EdB);
            this.Controls.Add(this.EdA);
            this.Controls.Add(this.BtnSum);
            this.Name = "SimpleForm";
            this.Text = "SimpleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSum;
        private System.Windows.Forms.TextBox EdA;
        private System.Windows.Forms.TextBox EdB;
        private System.Windows.Forms.TextBox EdC;
    }
}