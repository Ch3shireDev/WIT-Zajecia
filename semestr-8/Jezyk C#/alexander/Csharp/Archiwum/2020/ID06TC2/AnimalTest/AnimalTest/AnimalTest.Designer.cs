namespace AnimalTestNamespace
{
    partial class AnimalTest
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
            this.EdLog = new System.Windows.Forms.TextBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.CbNames = new System.Windows.Forms.ComboBox();
            this.EdName = new System.Windows.Forms.TextBox();
            this.BtnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EdLog
            // 
            this.EdLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdLog.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdLog.Location = new System.Drawing.Point(13, 49);
            this.EdLog.Multiline = true;
            this.EdLog.Name = "EdLog";
            this.EdLog.Size = new System.Drawing.Size(640, 278);
            this.EdLog.TabIndex = 0;
            // 
            // BtnStart
            // 
            this.BtnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStart.Location = new System.Drawing.Point(578, 338);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // CbNames
            // 
            this.CbNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbNames.FormattingEnabled = true;
            this.CbNames.Location = new System.Drawing.Point(13, 13);
            this.CbNames.Name = "CbNames";
            this.CbNames.Size = new System.Drawing.Size(121, 21);
            this.CbNames.TabIndex = 2;
            // 
            // EdName
            // 
            this.EdName.Location = new System.Drawing.Point(141, 13);
            this.EdName.Name = "EdName";
            this.EdName.Size = new System.Drawing.Size(100, 20);
            this.EdName.TabIndex = 3;
            this.EdName.Text = "Puszek";
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(248, 13);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(75, 23);
            this.BtnShow.TabIndex = 4;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // AnimalTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 373);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.EdName);
            this.Controls.Add(this.CbNames);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.EdLog);
            this.Name = "AnimalTest";
            this.Text = "Point";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EdLog;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.ComboBox CbNames;
        private System.Windows.Forms.TextBox EdName;
        private System.Windows.Forms.Button BtnShow;
    }
}

