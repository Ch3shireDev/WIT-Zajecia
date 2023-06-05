namespace Test004
{
    partial class MainForm
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
            this.AddBox = new System.Windows.Forms.TextBox();
            this.CntBox = new System.Windows.Forms.TextBox();
            this.SubBox = new System.Windows.Forms.TextBox();
            this.MaxBox = new System.Windows.Forms.TextBox();
            this.AvgBox = new System.Windows.Forms.TextBox();
            this.MinBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddBox
            // 
            this.AddBox.Location = new System.Drawing.Point(23, 18);
            this.AddBox.Name = "AddBox";
            this.AddBox.ReadOnly = true;
            this.AddBox.Size = new System.Drawing.Size(77, 20);
            this.AddBox.TabIndex = 0;
            this.AddBox.TabStop = false;
            this.AddBox.Text = "0";
            this.AddBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CntBox
            // 
            this.CntBox.Location = new System.Drawing.Point(121, 18);
            this.CntBox.Name = "CntBox";
            this.CntBox.ReadOnly = true;
            this.CntBox.Size = new System.Drawing.Size(77, 20);
            this.CntBox.TabIndex = 1;
            this.CntBox.TabStop = false;
            this.CntBox.Text = "0";
            this.CntBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SubBox
            // 
            this.SubBox.Location = new System.Drawing.Point(216, 18);
            this.SubBox.Name = "SubBox";
            this.SubBox.ReadOnly = true;
            this.SubBox.Size = new System.Drawing.Size(77, 20);
            this.SubBox.TabIndex = 2;
            this.SubBox.TabStop = false;
            this.SubBox.Text = "0";
            this.SubBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MaxBox
            // 
            this.MaxBox.Location = new System.Drawing.Point(216, 73);
            this.MaxBox.Name = "MaxBox";
            this.MaxBox.ReadOnly = true;
            this.MaxBox.Size = new System.Drawing.Size(77, 20);
            this.MaxBox.TabIndex = 5;
            this.MaxBox.TabStop = false;
            this.MaxBox.Text = "0.00";
            this.MaxBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AvgBox
            // 
            this.AvgBox.Location = new System.Drawing.Point(121, 73);
            this.AvgBox.Name = "AvgBox";
            this.AvgBox.ReadOnly = true;
            this.AvgBox.Size = new System.Drawing.Size(77, 20);
            this.AvgBox.TabIndex = 4;
            this.AvgBox.TabStop = false;
            this.AvgBox.Text = "0.00";
            this.AvgBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MinBox
            // 
            this.MinBox.Location = new System.Drawing.Point(23, 73);
            this.MinBox.Name = "MinBox";
            this.MinBox.ReadOnly = true;
            this.MinBox.Size = new System.Drawing.Size(77, 20);
            this.MinBox.TabIndex = 3;
            this.MinBox.TabStop = false;
            this.MinBox.Text = "0.00";
            this.MinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 116);
            this.Controls.Add(this.MaxBox);
            this.Controls.Add(this.AvgBox);
            this.Controls.Add(this.MinBox);
            this.Controls.Add(this.SubBox);
            this.Controls.Add(this.CntBox);
            this.Controls.Add(this.AddBox);
            this.Name = "MainForm";
            this.Text = "Czytelnik - Pisarz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddBox;
        private System.Windows.Forms.TextBox CntBox;
        private System.Windows.Forms.TextBox SubBox;
        private System.Windows.Forms.TextBox MaxBox;
        private System.Windows.Forms.TextBox AvgBox;
        private System.Windows.Forms.TextBox MinBox;
    }
}

