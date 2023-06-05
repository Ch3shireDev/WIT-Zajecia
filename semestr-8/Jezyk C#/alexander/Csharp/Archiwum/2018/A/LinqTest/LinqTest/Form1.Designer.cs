namespace LinqTest
{
    partial class LingTest
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
            this.TestList = new System.Windows.Forms.ComboBox();
            this.Log = new System.Windows.Forms.TextBox();
            this.BtnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestList
            // 
            this.TestList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TestList.FormattingEnabled = true;
            this.TestList.Location = new System.Drawing.Point(12, 12);
            this.TestList.Name = "TestList";
            this.TestList.Size = new System.Drawing.Size(165, 21);
            this.TestList.TabIndex = 0;
            // 
            // Log
            // 
            this.Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Log.Location = new System.Drawing.Point(12, 39);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Log.Size = new System.Drawing.Size(743, 335);
            this.Log.TabIndex = 1;
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(183, 10);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(75, 23);
            this.BtnRun.TabIndex = 2;
            this.BtnRun.Text = "Wykonaj";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // LingTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 386);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.TestList);
            this.Name = "LingTest";
            this.Text = "Linq Test ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TestList;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.Button BtnRun;
    }
}

