namespace Builder
{
    partial class BuilderForm
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
            this.EdId = new System.Windows.Forms.TextBox();
            this.EdDelimmetr = new System.Windows.Forms.TextBox();
            this.EdIfEmpty = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.EdLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EdId
            // 
            this.EdId.Location = new System.Drawing.Point(13, 13);
            this.EdId.Name = "EdId";
            this.EdId.Size = new System.Drawing.Size(100, 20);
            this.EdId.TabIndex = 0;
            // 
            // EdDelimmetr
            // 
            this.EdDelimmetr.Location = new System.Drawing.Point(119, 12);
            this.EdDelimmetr.Name = "EdDelimmetr";
            this.EdDelimmetr.Size = new System.Drawing.Size(100, 20);
            this.EdDelimmetr.TabIndex = 1;
            this.EdDelimmetr.Text = ", ";
            this.EdDelimmetr.TextChanged += new System.EventHandler(this.EdDelimmetr_TextChanged);
            // 
            // EdIfEmpty
            // 
            this.EdIfEmpty.Location = new System.Drawing.Point(225, 12);
            this.EdIfEmpty.Name = "EdIfEmpty";
            this.EdIfEmpty.Size = new System.Drawing.Size(100, 20);
            this.EdIfEmpty.TabIndex = 2;
            this.EdIfEmpty.Text = "null";
            this.EdIfEmpty.TextChanged += new System.EventHandler(this.EdDelimmetr_TextChanged);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.Location = new System.Drawing.Point(681, 12);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Location = new System.Drawing.Point(600, 12);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // EdLog
            // 
            this.EdLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdLog.Location = new System.Drawing.Point(12, 39);
            this.EdLog.Multiline = true;
            this.EdLog.Name = "EdLog";
            this.EdLog.Size = new System.Drawing.Size(744, 356);
            this.EdLog.TabIndex = 5;
            // 
            // BuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 407);
            this.Controls.Add(this.EdLog);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.EdIfEmpty);
            this.Controls.Add(this.EdDelimmetr);
            this.Controls.Add(this.EdId);
            this.Name = "BuilderForm";
            this.Text = "Builder Test Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EdId;
        private System.Windows.Forms.TextBox EdDelimmetr;
        private System.Windows.Forms.TextBox EdIfEmpty;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox EdLog;
    }
}

