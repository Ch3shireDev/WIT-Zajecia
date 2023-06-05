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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.EdLog = new System.Windows.Forms.TextBox();
            this.EdDelimeter = new System.Windows.Forms.TextBox();
            this.EdIfEmpty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EdId
            // 
            this.EdId.Location = new System.Drawing.Point(12, 12);
            this.EdId.Name = "EdId";
            this.EdId.Size = new System.Drawing.Size(138, 20);
            this.EdId.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Location = new System.Drawing.Point(628, 9);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // EdLog
            // 
            this.EdLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdLog.Location = new System.Drawing.Point(12, 38);
            this.EdLog.Multiline = true;
            this.EdLog.Name = "EdLog";
            this.EdLog.Size = new System.Drawing.Size(691, 295);
            this.EdLog.TabIndex = 2;
            // 
            // EdDelimeter
            // 
            this.EdDelimeter.Location = new System.Drawing.Point(156, 12);
            this.EdDelimeter.Name = "EdDelimeter";
            this.EdDelimeter.Size = new System.Drawing.Size(79, 20);
            this.EdDelimeter.TabIndex = 3;
            this.EdDelimeter.Text = ", ";
            this.EdDelimeter.TextChanged += new System.EventHandler(this.EdDelimeter_TextChanged);
            // 
            // EdIfEmpty
            // 
            this.EdIfEmpty.Location = new System.Drawing.Point(241, 12);
            this.EdIfEmpty.Name = "EdIfEmpty";
            this.EdIfEmpty.Size = new System.Drawing.Size(79, 20);
            this.EdIfEmpty.TabIndex = 4;
            this.EdIfEmpty.Text = "null";
            this.EdIfEmpty.TextChanged += new System.EventHandler(this.EdIfEmpty_TextChanged);
            // 
            // BuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 345);
            this.Controls.Add(this.EdIfEmpty);
            this.Controls.Add(this.EdDelimeter);
            this.Controls.Add(this.EdLog);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.EdId);
            this.Name = "BuilderForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EdId;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox EdLog;
        private System.Windows.Forms.TextBox EdDelimeter;
        private System.Windows.Forms.TextBox EdIfEmpty;
    }
}

