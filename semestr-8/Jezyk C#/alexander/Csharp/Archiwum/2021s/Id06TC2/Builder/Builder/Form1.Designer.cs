namespace Builder
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
            this.textId = new System.Windows.Forms.TextBox();
            this.textDelimetr = new System.Windows.Forms.TextBox();
            this.textIfEmpty = new System.Windows.Forms.TextBox();
            this.textLog = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(12, 12);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 0;
            // 
            // textDelimetr
            // 
            this.textDelimetr.Location = new System.Drawing.Point(118, 12);
            this.textDelimetr.Name = "textDelimetr";
            this.textDelimetr.Size = new System.Drawing.Size(100, 20);
            this.textDelimetr.TabIndex = 1;
            this.textDelimetr.Text = ", ";
            this.textDelimetr.TextChanged += new System.EventHandler(this.textDelimetrIfEmpty_TextChanged);
            // 
            // textIfEmpty
            // 
            this.textIfEmpty.Location = new System.Drawing.Point(224, 12);
            this.textIfEmpty.Name = "textIfEmpty";
            this.textIfEmpty.Size = new System.Drawing.Size(100, 20);
            this.textIfEmpty.TabIndex = 2;
            this.textIfEmpty.Text = "null";
            this.textIfEmpty.TextChanged += new System.EventHandler(this.textDelimetrIfEmpty_TextChanged);
            // 
            // textLog
            // 
            this.textLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textLog.Location = new System.Drawing.Point(12, 38);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.Size = new System.Drawing.Size(1005, 430);
            this.textLog.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(942, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAppend
            // 
            this.btnAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppend.Location = new System.Drawing.Point(861, 10);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(75, 23);
            this.btnAppend.TabIndex = 5;
            this.btnAppend.Text = "Append";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 480);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.textIfEmpty);
            this.Controls.Add(this.textDelimetr);
            this.Controls.Add(this.textId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textDelimetr;
        private System.Windows.Forms.TextBox textIfEmpty;
        private System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAppend;
    }
}

