namespace PointTest
{
    partial class PointTest
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
            this.BtnStart = new System.Windows.Forms.Button();
            this.EdLog = new System.Windows.Forms.TextBox();
            this.CbNames = new System.Windows.Forms.ComboBox();
            this.BtnShow = new System.Windows.Forms.Button();
            this.EdName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(13, 13);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // EdLog
            // 
            this.EdLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdLog.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdLog.Location = new System.Drawing.Point(13, 42);
            this.EdLog.Multiline = true;
            this.EdLog.Name = "EdLog";
            this.EdLog.Size = new System.Drawing.Size(557, 235);
            this.EdLog.TabIndex = 1;
            // 
            // CbNames
            // 
            this.CbNames.FormattingEnabled = true;
            this.CbNames.Location = new System.Drawing.Point(94, 15);
            this.CbNames.Name = "CbNames";
            this.CbNames.Size = new System.Drawing.Size(109, 21);
            this.CbNames.TabIndex = 2;
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(305, 13);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(75, 23);
            this.BtnShow.TabIndex = 3;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // EdName
            // 
            this.EdName.Location = new System.Drawing.Point(209, 15);
            this.EdName.Name = "EdName";
            this.EdName.Size = new System.Drawing.Size(90, 20);
            this.EdName.TabIndex = 4;
            this.EdName.Text = "Fellow";
            // 
            // PointTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 289);
            this.Controls.Add(this.EdName);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.CbNames);
            this.Controls.Add(this.EdLog);
            this.Controls.Add(this.BtnStart);
            this.Name = "PointTest";
            this.Text = "Test of Point";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.TextBox EdLog;
        private System.Windows.Forms.ComboBox CbNames;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.TextBox EdName;
    }
}

