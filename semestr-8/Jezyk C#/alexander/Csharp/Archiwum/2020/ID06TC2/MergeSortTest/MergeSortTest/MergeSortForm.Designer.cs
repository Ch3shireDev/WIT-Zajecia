namespace MergeSortTest
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
            this.Generate = new System.Windows.Forms.Button();
            this.BtnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EdSource
            // 
            this.EdSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EdSource.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.EdSource.Location = new System.Drawing.Point(12, 12);
            this.EdSource.Multiline = true;
            this.EdSource.Name = "EdSource";
            this.EdSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EdSource.Size = new System.Drawing.Size(164, 317);
            this.EdSource.TabIndex = 0;
            this.EdSource.Text = resources.GetString("EdSource.Text");
            this.EdSource.WordWrap = false;
            // 
            // EdResult
            // 
            this.EdResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdResult.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.EdResult.Location = new System.Drawing.Point(440, 12);
            this.EdResult.Multiline = true;
            this.EdResult.Name = "EdResult";
            this.EdResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EdResult.Size = new System.Drawing.Size(164, 317);
            this.EdResult.TabIndex = 1;
            this.EdResult.WordWrap = false;
            // 
            // Generate
            // 
            this.Generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Generate.Location = new System.Drawing.Point(12, 335);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 23);
            this.Generate.TabIndex = 2;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // BtnSort
            // 
            this.BtnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSort.Location = new System.Drawing.Point(529, 335);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(75, 23);
            this.BtnSort.TabIndex = 3;
            this.BtnSort.Text = "Sort";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // MergeSortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 370);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.EdResult);
            this.Controls.Add(this.EdSource);
            this.Name = "MergeSortForm";
            this.Text = "Merge Sort ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EdSource;
        private System.Windows.Forms.TextBox EdResult;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button BtnSort;
    }
}

