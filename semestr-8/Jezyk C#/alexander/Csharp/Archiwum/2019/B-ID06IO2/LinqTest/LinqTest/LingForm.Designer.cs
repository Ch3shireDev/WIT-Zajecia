namespace LinqTest
{
    partial class LingForm
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
            this.BoxTest = new System.Windows.Forms.ComboBox();
            this.Log = new System.Windows.Forms.TextBox();
            this.BtnExecute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoxTest
            // 
            this.BoxTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxTest.FormattingEnabled = true;
            this.BoxTest.Location = new System.Drawing.Point(12, 12);
            this.BoxTest.Name = "BoxTest";
            this.BoxTest.Size = new System.Drawing.Size(121, 21);
            this.BoxTest.TabIndex = 0;
            // 
            // Log
            // 
            this.Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Log.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Log.Location = new System.Drawing.Point(12, 39);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(776, 420);
            this.Log.TabIndex = 1;
            // 
            // BtnExecute
            // 
            this.BtnExecute.Location = new System.Drawing.Point(139, 10);
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(75, 23);
            this.BtnExecute.TabIndex = 2;
            this.BtnExecute.Text = "Wykonaj";
            this.BtnExecute.UseVisualStyleBackColor = true;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnExecute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.BtnExecute);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.BoxTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BoxTest;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.Button BtnExecute;
    }
}

