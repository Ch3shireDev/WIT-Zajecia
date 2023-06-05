namespace MatrixMultiply
{
    partial class MatrixMultiplyForm
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
            this.Vertical = new System.Windows.Forms.SplitContainer();
            this.Horizontal = new System.Windows.Forms.SplitContainer();
            this.EdMatrixA = new System.Windows.Forms.TextBox();
            this.EdMatrixB = new System.Windows.Forms.TextBox();
            this.EdResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Vertical)).BeginInit();
            this.Vertical.Panel1.SuspendLayout();
            this.Vertical.Panel2.SuspendLayout();
            this.Vertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Horizontal)).BeginInit();
            this.Horizontal.Panel1.SuspendLayout();
            this.Horizontal.Panel2.SuspendLayout();
            this.Horizontal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Vertical
            // 
            this.Vertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vertical.Location = new System.Drawing.Point(0, 0);
            this.Vertical.Name = "Vertical";
            this.Vertical.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Vertical.Panel1
            // 
            this.Vertical.Panel1.Controls.Add(this.Horizontal);
            // 
            // Vertical.Panel2
            // 
            this.Vertical.Panel2.Controls.Add(this.EdResult);
            this.Vertical.Size = new System.Drawing.Size(707, 468);
            this.Vertical.SplitterDistance = 235;
            this.Vertical.TabIndex = 0;
            // 
            // Horizontal
            // 
            this.Horizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Horizontal.Location = new System.Drawing.Point(0, 0);
            this.Horizontal.Name = "Horizontal";
            // 
            // Horizontal.Panel1
            // 
            this.Horizontal.Panel1.Controls.Add(this.EdMatrixA);
            // 
            // Horizontal.Panel2
            // 
            this.Horizontal.Panel2.Controls.Add(this.EdMatrixB);
            this.Horizontal.Size = new System.Drawing.Size(707, 235);
            this.Horizontal.SplitterDistance = 358;
            this.Horizontal.TabIndex = 0;
            // 
            // EdMatrixA
            // 
            this.EdMatrixA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EdMatrixA.Location = new System.Drawing.Point(0, 0);
            this.EdMatrixA.Multiline = true;
            this.EdMatrixA.Name = "EdMatrixA";
            this.EdMatrixA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EdMatrixA.Size = new System.Drawing.Size(358, 235);
            this.EdMatrixA.TabIndex = 0;
            this.EdMatrixA.TextChanged += new System.EventHandler(this.EdMatrixes_TextChanged);
            // 
            // EdMatrixB
            // 
            this.EdMatrixB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EdMatrixB.Location = new System.Drawing.Point(0, 0);
            this.EdMatrixB.Multiline = true;
            this.EdMatrixB.Name = "EdMatrixB";
            this.EdMatrixB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EdMatrixB.Size = new System.Drawing.Size(345, 235);
            this.EdMatrixB.TabIndex = 1;
            this.EdMatrixB.TextChanged += new System.EventHandler(this.EdMatrixes_TextChanged);
            // 
            // EdResult
            // 
            this.EdResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EdResult.Location = new System.Drawing.Point(0, 0);
            this.EdResult.Multiline = true;
            this.EdResult.Name = "EdResult";
            this.EdResult.ReadOnly = true;
            this.EdResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EdResult.Size = new System.Drawing.Size(707, 229);
            this.EdResult.TabIndex = 1;
            // 
            // MatrixMultiplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 468);
            this.Controls.Add(this.Vertical);
            this.Name = "MatrixMultiplyForm";
            this.Text = "Matrix Multiply ...";
            this.Vertical.Panel1.ResumeLayout(false);
            this.Vertical.Panel2.ResumeLayout(false);
            this.Vertical.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vertical)).EndInit();
            this.Vertical.ResumeLayout(false);
            this.Horizontal.Panel1.ResumeLayout(false);
            this.Horizontal.Panel1.PerformLayout();
            this.Horizontal.Panel2.ResumeLayout(false);
            this.Horizontal.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Horizontal)).EndInit();
            this.Horizontal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Vertical;
        private System.Windows.Forms.SplitContainer Horizontal;
        private System.Windows.Forms.TextBox EdMatrixA;
        private System.Windows.Forms.TextBox EdMatrixB;
        private System.Windows.Forms.TextBox EdResult;
    }
}

