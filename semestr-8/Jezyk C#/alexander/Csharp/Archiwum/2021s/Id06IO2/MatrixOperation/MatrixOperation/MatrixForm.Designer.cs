namespace MatrixOperation
{
    partial class MatrixForm
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
            this.SplitHorizontal = new System.Windows.Forms.SplitContainer();
            this.splitLeft = new System.Windows.Forms.SplitContainer();
            this.BtnSolve = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.MatrixA = new System.Windows.Forms.TextBox();
            this.splitRight = new System.Windows.Forms.SplitContainer();
            this.MatrixB = new System.Windows.Forms.TextBox();
            this.MatrixC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SplitHorizontal)).BeginInit();
            this.SplitHorizontal.Panel1.SuspendLayout();
            this.SplitHorizontal.Panel2.SuspendLayout();
            this.SplitHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).BeginInit();
            this.splitLeft.Panel1.SuspendLayout();
            this.splitLeft.Panel2.SuspendLayout();
            this.splitLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).BeginInit();
            this.splitRight.Panel1.SuspendLayout();
            this.splitRight.Panel2.SuspendLayout();
            this.splitRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitHorizontal
            // 
            this.SplitHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitHorizontal.Location = new System.Drawing.Point(0, 0);
            this.SplitHorizontal.Name = "SplitHorizontal";
            // 
            // SplitHorizontal.Panel1
            // 
            this.SplitHorizontal.Panel1.Controls.Add(this.splitLeft);
            // 
            // SplitHorizontal.Panel2
            // 
            this.SplitHorizontal.Panel2.Controls.Add(this.splitRight);
            this.SplitHorizontal.Size = new System.Drawing.Size(760, 349);
            this.SplitHorizontal.SplitterDistance = 380;
            this.SplitHorizontal.TabIndex = 0;
            // 
            // splitLeft
            // 
            this.splitLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLeft.Location = new System.Drawing.Point(0, 0);
            this.splitLeft.Name = "splitLeft";
            this.splitLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitLeft.Panel1
            // 
            this.splitLeft.Panel1.Controls.Add(this.BtnSolve);
            this.splitLeft.Panel1.Controls.Add(this.BtnSub);
            this.splitLeft.Panel1.Controls.Add(this.BtnMul);
            this.splitLeft.Panel1.Controls.Add(this.BtnAdd);
            // 
            // splitLeft.Panel2
            // 
            this.splitLeft.Panel2.Controls.Add(this.MatrixA);
            this.splitLeft.Size = new System.Drawing.Size(380, 349);
            this.splitLeft.SplitterDistance = 170;
            this.splitLeft.TabIndex = 0;
            // 
            // BtnSolve
            // 
            this.BtnSolve.Location = new System.Drawing.Point(93, 41);
            this.BtnSolve.Name = "BtnSolve";
            this.BtnSolve.Size = new System.Drawing.Size(75, 23);
            this.BtnSolve.TabIndex = 3;
            this.BtnSolve.Text = "Solve";
            this.BtnSolve.UseVisualStyleBackColor = true;
            this.BtnSolve.Click += new System.EventHandler(this.BtnSolve_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.Location = new System.Drawing.Point(12, 41);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(75, 23);
            this.BtnSub.TabIndex = 2;
            this.BtnSub.Text = "Sub";
            this.BtnSub.UseVisualStyleBackColor = true;
            // 
            // BtnMul
            // 
            this.BtnMul.Location = new System.Drawing.Point(93, 12);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(75, 23);
            this.BtnMul.TabIndex = 1;
            this.BtnMul.Text = "Mul";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.BtnMul_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 12);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // MatrixA
            // 
            this.MatrixA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatrixA.Location = new System.Drawing.Point(0, 0);
            this.MatrixA.Multiline = true;
            this.MatrixA.Name = "MatrixA";
            this.MatrixA.Size = new System.Drawing.Size(380, 175);
            this.MatrixA.TabIndex = 1;
            // 
            // splitRight
            // 
            this.splitRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRight.Location = new System.Drawing.Point(0, 0);
            this.splitRight.Name = "splitRight";
            this.splitRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitRight.Panel1
            // 
            this.splitRight.Panel1.Controls.Add(this.MatrixB);
            // 
            // splitRight.Panel2
            // 
            this.splitRight.Panel2.Controls.Add(this.MatrixC);
            this.splitRight.Size = new System.Drawing.Size(376, 349);
            this.splitRight.SplitterDistance = 170;
            this.splitRight.TabIndex = 0;
            // 
            // MatrixB
            // 
            this.MatrixB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatrixB.Location = new System.Drawing.Point(0, 0);
            this.MatrixB.Multiline = true;
            this.MatrixB.Name = "MatrixB";
            this.MatrixB.Size = new System.Drawing.Size(376, 170);
            this.MatrixB.TabIndex = 2;
            // 
            // MatrixC
            // 
            this.MatrixC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatrixC.Location = new System.Drawing.Point(0, 0);
            this.MatrixC.Multiline = true;
            this.MatrixC.Name = "MatrixC";
            this.MatrixC.Size = new System.Drawing.Size(376, 175);
            this.MatrixC.TabIndex = 3;
            // 
            // MatrixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 349);
            this.Controls.Add(this.SplitHorizontal);
            this.Name = "MatrixForm";
            this.Text = "Matrix Operation";
            this.SplitHorizontal.Panel1.ResumeLayout(false);
            this.SplitHorizontal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitHorizontal)).EndInit();
            this.SplitHorizontal.ResumeLayout(false);
            this.splitLeft.Panel1.ResumeLayout(false);
            this.splitLeft.Panel2.ResumeLayout(false);
            this.splitLeft.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).EndInit();
            this.splitLeft.ResumeLayout(false);
            this.splitRight.Panel1.ResumeLayout(false);
            this.splitRight.Panel1.PerformLayout();
            this.splitRight.Panel2.ResumeLayout(false);
            this.splitRight.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).EndInit();
            this.splitRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitHorizontal;
        private System.Windows.Forms.SplitContainer splitLeft;
        private System.Windows.Forms.Button BtnSolve;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox MatrixA;
        private System.Windows.Forms.SplitContainer splitRight;
        private System.Windows.Forms.TextBox MatrixB;
        private System.Windows.Forms.TextBox MatrixC;
    }
}

