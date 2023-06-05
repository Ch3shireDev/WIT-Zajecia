namespace MatrixCalcTest
{
    partial class MatrixCalcForm
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
            this.VerticalSplit = new System.Windows.Forms.SplitContainer();
            this.LeftSplit = new System.Windows.Forms.SplitContainer();
            this.RightSplit = new System.Windows.Forms.SplitContainer();
            this.EdMatrixA = new System.Windows.Forms.TextBox();
            this.EdMatrixB = new System.Windows.Forms.TextBox();
            this.EdMatrixC = new System.Windows.Forms.TextBox();
            this.BtnTest = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.BtnGaus = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalSplit)).BeginInit();
            this.VerticalSplit.Panel1.SuspendLayout();
            this.VerticalSplit.Panel2.SuspendLayout();
            this.VerticalSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftSplit)).BeginInit();
            this.LeftSplit.Panel1.SuspendLayout();
            this.LeftSplit.Panel2.SuspendLayout();
            this.LeftSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightSplit)).BeginInit();
            this.RightSplit.Panel1.SuspendLayout();
            this.RightSplit.Panel2.SuspendLayout();
            this.RightSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // VerticalSplit
            // 
            this.VerticalSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VerticalSplit.Location = new System.Drawing.Point(0, 0);
            this.VerticalSplit.Name = "VerticalSplit";
            // 
            // VerticalSplit.Panel1
            // 
            this.VerticalSplit.Panel1.Controls.Add(this.LeftSplit);
            // 
            // VerticalSplit.Panel2
            // 
            this.VerticalSplit.Panel2.Controls.Add(this.RightSplit);
            this.VerticalSplit.Size = new System.Drawing.Size(692, 390);
            this.VerticalSplit.SplitterDistance = 318;
            this.VerticalSplit.TabIndex = 0;
            // 
            // LeftSplit
            // 
            this.LeftSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftSplit.Location = new System.Drawing.Point(0, 0);
            this.LeftSplit.Name = "LeftSplit";
            this.LeftSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // LeftSplit.Panel1
            // 
            this.LeftSplit.Panel1.Controls.Add(this.BtnSub);
            this.LeftSplit.Panel1.Controls.Add(this.BtnAdd);
            this.LeftSplit.Panel1.Controls.Add(this.BtnGaus);
            this.LeftSplit.Panel1.Controls.Add(this.BtnMultiply);
            this.LeftSplit.Panel1.Controls.Add(this.BtnTest);
            // 
            // LeftSplit.Panel2
            // 
            this.LeftSplit.Panel2.Controls.Add(this.EdMatrixA);
            this.LeftSplit.Size = new System.Drawing.Size(318, 390);
            this.LeftSplit.SplitterDistance = 222;
            this.LeftSplit.TabIndex = 0;
            this.LeftSplit.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.LeftSplit_SplitterMoved);
            // 
            // RightSplit
            // 
            this.RightSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightSplit.Location = new System.Drawing.Point(0, 0);
            this.RightSplit.Name = "RightSplit";
            this.RightSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // RightSplit.Panel1
            // 
            this.RightSplit.Panel1.Controls.Add(this.EdMatrixB);
            // 
            // RightSplit.Panel2
            // 
            this.RightSplit.Panel2.Controls.Add(this.EdMatrixC);
            this.RightSplit.Size = new System.Drawing.Size(370, 390);
            this.RightSplit.SplitterDistance = 222;
            this.RightSplit.TabIndex = 1;
            this.RightSplit.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.RightSplit_SplitterMoved);
            // 
            // EdMatrixA
            // 
            this.EdMatrixA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EdMatrixA.Location = new System.Drawing.Point(0, 0);
            this.EdMatrixA.Multiline = true;
            this.EdMatrixA.Name = "EdMatrixA";
            this.EdMatrixA.Size = new System.Drawing.Size(318, 164);
            this.EdMatrixA.TabIndex = 0;
            // 
            // EdMatrixB
            // 
            this.EdMatrixB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EdMatrixB.Location = new System.Drawing.Point(0, 0);
            this.EdMatrixB.Multiline = true;
            this.EdMatrixB.Name = "EdMatrixB";
            this.EdMatrixB.Size = new System.Drawing.Size(370, 222);
            this.EdMatrixB.TabIndex = 1;
            // 
            // EdMatrixC
            // 
            this.EdMatrixC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EdMatrixC.Location = new System.Drawing.Point(0, 0);
            this.EdMatrixC.Multiline = true;
            this.EdMatrixC.Name = "EdMatrixC";
            this.EdMatrixC.Size = new System.Drawing.Size(370, 164);
            this.EdMatrixC.TabIndex = 2;
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(12, 12);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(75, 23);
            this.BtnTest.TabIndex = 0;
            this.BtnTest.Text = "Test";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.Location = new System.Drawing.Point(12, 41);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(75, 23);
            this.BtnMultiply.TabIndex = 1;
            this.BtnMultiply.Text = "Multiply";
            this.BtnMultiply.UseVisualStyleBackColor = true;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // BtnGaus
            // 
            this.BtnGaus.Location = new System.Drawing.Point(12, 70);
            this.BtnGaus.Name = "BtnGaus";
            this.BtnGaus.Size = new System.Drawing.Size(75, 23);
            this.BtnGaus.TabIndex = 2;
            this.BtnGaus.Text = "Gaus";
            this.BtnGaus.UseVisualStyleBackColor = true;
            this.BtnGaus.Click += new System.EventHandler(this.BtnGaus_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(93, 41);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.Location = new System.Drawing.Point(174, 41);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(75, 23);
            this.BtnSub.TabIndex = 4;
            this.BtnSub.Text = "BtnSub";
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // MatrixCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 390);
            this.Controls.Add(this.VerticalSplit);
            this.Name = "MatrixCalcForm";
            this.Text = "Matrix Calc";
            this.VerticalSplit.Panel1.ResumeLayout(false);
            this.VerticalSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VerticalSplit)).EndInit();
            this.VerticalSplit.ResumeLayout(false);
            this.LeftSplit.Panel1.ResumeLayout(false);
            this.LeftSplit.Panel2.ResumeLayout(false);
            this.LeftSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftSplit)).EndInit();
            this.LeftSplit.ResumeLayout(false);
            this.RightSplit.Panel1.ResumeLayout(false);
            this.RightSplit.Panel1.PerformLayout();
            this.RightSplit.Panel2.ResumeLayout(false);
            this.RightSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightSplit)).EndInit();
            this.RightSplit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer VerticalSplit;
        private System.Windows.Forms.SplitContainer LeftSplit;
        private System.Windows.Forms.TextBox EdMatrixA;
        private System.Windows.Forms.SplitContainer RightSplit;
        private System.Windows.Forms.TextBox EdMatrixB;
        private System.Windows.Forms.TextBox EdMatrixC;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnGaus;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button BtnTest;
    }
}

