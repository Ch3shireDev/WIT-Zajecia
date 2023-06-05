namespace MergeSort
{
    partial class MergeSortForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MergeSortForm));
            this.EdSource = new System.Windows.Forms.TextBox();
            this.EdResult = new System.Windows.Forms.TextBox();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.BtnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EdSource
            // 
            this.EdSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EdSource.Location = new System.Drawing.Point(12, 12);
            this.EdSource.Multiline = true;
            this.EdSource.Name = "EdSource";
            this.EdSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EdSource.Size = new System.Drawing.Size(140, 304);
            this.EdSource.TabIndex = 0;
            this.EdSource.Text = resources.GetString("EdSource.Text");
            // 
            // EdResult
            // 
            this.EdResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdResult.Location = new System.Drawing.Point(267, 12);
            this.EdResult.Multiline = true;
            this.EdResult.Name = "EdResult";
            this.EdResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EdResult.Size = new System.Drawing.Size(140, 304);
            this.EdResult.TabIndex = 1;
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnGenerate.Location = new System.Drawing.Point(12, 322);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(140, 23);
            this.BtnGenerate.TabIndex = 2;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // BtnSort
            // 
            this.BtnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSort.Location = new System.Drawing.Point(267, 322);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(140, 23);
            this.BtnSort.TabIndex = 3;
            this.BtnSort.Text = "Sort";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // MergeSortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 357);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.EdResult);
            this.Controls.Add(this.EdSource);
            this.Name = "MergeSortForm";
            this.Text = "Merge Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EdSource;
        private System.Windows.Forms.TextBox EdResult;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Button BtnSort;
    }
}

