namespace LingTest
{
    partial class LinqMainForm
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
            this.CbMethods = new System.Windows.Forms.ComboBox();
            this.BtnExecute = new System.Windows.Forms.Button();
            this.TbLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CbMethods
            // 
            this.CbMethods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMethods.FormattingEnabled = true;
            this.CbMethods.Location = new System.Drawing.Point(12, 12);
            this.CbMethods.Name = "CbMethods";
            this.CbMethods.Size = new System.Drawing.Size(121, 21);
            this.CbMethods.TabIndex = 0;
            // 
            // BtnExecute
            // 
            this.BtnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExecute.Location = new System.Drawing.Point(662, 10);
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(75, 23);
            this.BtnExecute.TabIndex = 1;
            this.BtnExecute.Text = "Execute";
            this.BtnExecute.UseVisualStyleBackColor = true;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // TbLog
            // 
            this.TbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbLog.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TbLog.Location = new System.Drawing.Point(12, 39);
            this.TbLog.Multiline = true;
            this.TbLog.Name = "TbLog";
            this.TbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbLog.Size = new System.Drawing.Size(725, 344);
            this.TbLog.TabIndex = 2;
            this.TbLog.WordWrap = false;
            // 
            // LinqMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 395);
            this.Controls.Add(this.TbLog);
            this.Controls.Add(this.BtnExecute);
            this.Controls.Add(this.CbMethods);
            this.Name = "LinqMainForm";
            this.Text = "Linq";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbMethods;
        private System.Windows.Forms.Button BtnExecute;
        private System.Windows.Forms.TextBox TbLog;
    }
}

