namespace Decorator
{
    partial class DecoratorForm
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
            this.CbModels = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.CklDecorators = new System.Windows.Forms.CheckedListBox();
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CbModels
            // 
            this.CbModels.FormattingEnabled = true;
            this.CbModels.Location = new System.Drawing.Point(12, 12);
            this.CbModels.Name = "CbModels";
            this.CbModels.Size = new System.Drawing.Size(121, 21);
            this.CbModels.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAdd.Location = new System.Drawing.Point(12, 328);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(121, 23);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // CklDecorators
            // 
            this.CklDecorators.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CklDecorators.FormattingEnabled = true;
            this.CklDecorators.Location = new System.Drawing.Point(13, 39);
            this.CklDecorators.Name = "CklDecorators";
            this.CklDecorators.Size = new System.Drawing.Size(120, 274);
            this.CklDecorators.TabIndex = 2;
            // 
            // TxtLog
            // 
            this.TxtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtLog.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtLog.Location = new System.Drawing.Point(139, 12);
            this.TxtLog.Multiline = true;
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.Size = new System.Drawing.Size(498, 339);
            this.TxtLog.TabIndex = 3;
            // 
            // DecoratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 363);
            this.Controls.Add(this.TxtLog);
            this.Controls.Add(this.CklDecorators);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CbModels);
            this.Name = "DecoratorForm";
            this.Text = "Decorator - Car price list";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbModels;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.CheckedListBox CklDecorators;
        private System.Windows.Forms.TextBox TxtLog;
    }
}

