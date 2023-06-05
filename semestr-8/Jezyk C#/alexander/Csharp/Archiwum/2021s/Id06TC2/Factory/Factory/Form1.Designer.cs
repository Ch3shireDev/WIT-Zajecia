namespace Factory
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
            this.cbKind = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.BtnMake = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbKind
            // 
            this.cbKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKind.FormattingEnabled = true;
            this.cbKind.Location = new System.Drawing.Point(12, 12);
            this.cbKind.Name = "cbKind";
            this.cbKind.Size = new System.Drawing.Size(121, 21);
            this.cbKind.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // BtnMake
            // 
            this.BtnMake.Location = new System.Drawing.Point(245, 10);
            this.BtnMake.Name = "BtnMake";
            this.BtnMake.Size = new System.Drawing.Size(75, 23);
            this.BtnMake.TabIndex = 2;
            this.BtnMake.Text = "Make";
            this.BtnMake.UseVisualStyleBackColor = true;
            this.BtnMake.Click += new System.EventHandler(this.BtnMake_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 39);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(550, 211);
            this.txtLog.TabIndex = 3;
            this.txtLog.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 262);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.BtnMake);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbKind);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKind;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button BtnMake;
        private System.Windows.Forms.TextBox txtLog;
    }
}

