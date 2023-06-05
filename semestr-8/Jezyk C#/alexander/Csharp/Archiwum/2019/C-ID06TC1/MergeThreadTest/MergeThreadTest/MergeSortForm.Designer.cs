namespace MergeThreadTest
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
            this.Righter = new System.Windows.Forms.Panel();
            this.BtnSort = new System.Windows.Forms.Button();
            this.Spliter = new System.Windows.Forms.SplitContainer();
            this.EdSrc = new System.Windows.Forms.TextBox();
            this.EdDst = new System.Windows.Forms.TextBox();
            this.Righter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Spliter)).BeginInit();
            this.Spliter.Panel1.SuspendLayout();
            this.Spliter.Panel2.SuspendLayout();
            this.Spliter.SuspendLayout();
            this.SuspendLayout();
            // 
            // Righter
            // 
            this.Righter.Controls.Add(this.BtnSort);
            this.Righter.Dock = System.Windows.Forms.DockStyle.Right;
            this.Righter.Location = new System.Drawing.Point(758, 0);
            this.Righter.Name = "Righter";
            this.Righter.Size = new System.Drawing.Size(95, 373);
            this.Righter.TabIndex = 0;
            // 
            // BtnSort
            // 
            this.BtnSort.Location = new System.Drawing.Point(7, 13);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(75, 23);
            this.BtnSort.TabIndex = 0;
            this.BtnSort.Text = "Sortuj";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // Spliter
            // 
            this.Spliter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spliter.Location = new System.Drawing.Point(0, 0);
            this.Spliter.Name = "Spliter";
            // 
            // Spliter.Panel1
            // 
            this.Spliter.Panel1.Controls.Add(this.EdSrc);
            this.Spliter.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // Spliter.Panel2
            // 
            this.Spliter.Panel2.Controls.Add(this.EdDst);
            this.Spliter.Size = new System.Drawing.Size(758, 373);
            this.Spliter.SplitterDistance = 367;
            this.Spliter.SplitterWidth = 6;
            this.Spliter.TabIndex = 1;
            // 
            // EdSrc
            // 
            this.EdSrc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EdSrc.Location = new System.Drawing.Point(0, 0);
            this.EdSrc.Multiline = true;
            this.EdSrc.Name = "EdSrc";
            this.EdSrc.Size = new System.Drawing.Size(367, 373);
            this.EdSrc.TabIndex = 0;
            // 
            // EdDst
            // 
            this.EdDst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EdDst.Location = new System.Drawing.Point(0, 0);
            this.EdDst.Multiline = true;
            this.EdDst.Name = "EdDst";
            this.EdDst.ReadOnly = true;
            this.EdDst.Size = new System.Drawing.Size(385, 373);
            this.EdDst.TabIndex = 1;
            // 
            // MergeSortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 373);
            this.Controls.Add(this.Spliter);
            this.Controls.Add(this.Righter);
            this.Name = "MergeSortForm";
            this.Text = "Merge Sorrt Test ...";
            this.Righter.ResumeLayout(false);
            this.Spliter.Panel1.ResumeLayout(false);
            this.Spliter.Panel1.PerformLayout();
            this.Spliter.Panel2.ResumeLayout(false);
            this.Spliter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Spliter)).EndInit();
            this.Spliter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Righter;
        private System.Windows.Forms.SplitContainer Spliter;
        private System.Windows.Forms.Button BtnSort;
        private System.Windows.Forms.TextBox EdSrc;
        private System.Windows.Forms.TextBox EdDst;
    }
}

