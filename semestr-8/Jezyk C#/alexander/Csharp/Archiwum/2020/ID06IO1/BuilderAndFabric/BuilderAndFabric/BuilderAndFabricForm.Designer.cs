namespace BuilderAndFabric
{
    partial class BuilderAndFabricForm
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
            this.SuspendLayout();
            // 
            // EdLog
            // 
            this.EdLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdLog.Location = new System.Drawing.Point(12, 39);
            this.EdLog.Multiline = true;
            this.EdLog.Name = "EdLog";
            this.EdLog.Size = new System.Drawing.Size(769, 322);
            this.EdLog.TabIndex = 0;
            // 
            // BtnStart
            // 
            this.BtnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStart.Location = new System.Drawing.Point(706, 367);
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
            this.CbNames.Location = new System.Drawing.Point(12, 12);
            this.CbNames.Name = "CbNames";
            this.CbNames.Size = new System.Drawing.Size(121, 21);
            this.CbNames.TabIndex = 2;
            // 
            // EdName
            // 
            this.EdName.Location = new System.Drawing.Point(140, 12);
            this.EdName.Name = "EdName";
            this.EdName.Size = new System.Drawing.Size(100, 20);
            this.EdName.TabIndex = 3;
            // 
            // BuilderAndFabricForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 402);
            this.Controls.Add(this.EdName);
            this.Controls.Add(this.CbNames);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.EdLog);
            this.Name = "BuilderAndFabricForm";
            this.Text = "BuilderAndFabricForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EdLog;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.ComboBox CbNames;
        private System.Windows.Forms.TextBox EdName;
    }
}