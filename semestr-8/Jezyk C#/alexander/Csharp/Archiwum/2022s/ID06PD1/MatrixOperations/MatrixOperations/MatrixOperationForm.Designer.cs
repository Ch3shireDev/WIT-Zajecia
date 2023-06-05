namespace MatrixOperations
{
    partial class MatrixOperationForm
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
            this.ScVertical = new System.Windows.Forms.SplitContainer();
            this.ScLeft = new System.Windows.Forms.SplitContainer();
            this.ScRight = new System.Windows.Forms.SplitContainer();
            this.TbMatrixA = new System.Windows.Forms.TextBox();
            this.TbMatrixB = new System.Windows.Forms.TextBox();
            this.TbMatrixResult = new System.Windows.Forms.TextBox();
            this.TLButtons = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.BtnSolve = new System.Windows.Forms.Button();
            this.BtnInv = new System.Windows.Forms.Button();
            this.BtnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ScVertical)).BeginInit();
            this.ScVertical.Panel1.SuspendLayout();
            this.ScVertical.Panel2.SuspendLayout();
            this.ScVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScLeft)).BeginInit();
            this.ScLeft.Panel1.SuspendLayout();
            this.ScLeft.Panel2.SuspendLayout();
            this.ScLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScRight)).BeginInit();
            this.ScRight.Panel1.SuspendLayout();
            this.ScRight.Panel2.SuspendLayout();
            this.ScRight.SuspendLayout();
            this.TLButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScVertical
            // 
            this.ScVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScVertical.Location = new System.Drawing.Point(0, 0);
            this.ScVertical.Name = "ScVertical";
            // 
            // ScVertical.Panel1
            // 
            this.ScVertical.Panel1.Controls.Add(this.ScLeft);
            // 
            // ScVertical.Panel2
            // 
            this.ScVertical.Panel2.Controls.Add(this.ScRight);
            this.ScVertical.Size = new System.Drawing.Size(785, 426);
            this.ScVertical.SplitterDistance = 350;
            this.ScVertical.SplitterWidth = 8;
            this.ScVertical.TabIndex = 0;
            // 
            // ScLeft
            // 
            this.ScLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScLeft.Location = new System.Drawing.Point(0, 0);
            this.ScLeft.Name = "ScLeft";
            this.ScLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScLeft.Panel1
            // 
            this.ScLeft.Panel1.Controls.Add(this.TLButtons);
            this.ScLeft.Panel1.Padding = new System.Windows.Forms.Padding(2);
            // 
            // ScLeft.Panel2
            // 
            this.ScLeft.Panel2.Controls.Add(this.TbMatrixA);
            this.ScLeft.Panel2.Padding = new System.Windows.Forms.Padding(2);
            this.ScLeft.Size = new System.Drawing.Size(350, 426);
            this.ScLeft.SplitterDistance = 200;
            this.ScLeft.SplitterWidth = 8;
            this.ScLeft.TabIndex = 0;
            // 
            // ScRight
            // 
            this.ScRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScRight.Location = new System.Drawing.Point(0, 0);
            this.ScRight.Name = "ScRight";
            this.ScRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScRight.Panel1
            // 
            this.ScRight.Panel1.Controls.Add(this.TbMatrixB);
            this.ScRight.Panel1.Padding = new System.Windows.Forms.Padding(2);
            // 
            // ScRight.Panel2
            // 
            this.ScRight.Panel2.Controls.Add(this.TbMatrixResult);
            this.ScRight.Panel2.Padding = new System.Windows.Forms.Padding(2);
            this.ScRight.Size = new System.Drawing.Size(427, 426);
            this.ScRight.SplitterDistance = 200;
            this.ScRight.SplitterWidth = 8;
            this.ScRight.TabIndex = 0;
            // 
            // TbMatrixA
            // 
            this.TbMatrixA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbMatrixA.Location = new System.Drawing.Point(2, 2);
            this.TbMatrixA.Multiline = true;
            this.TbMatrixA.Name = "TbMatrixA";
            this.TbMatrixA.Size = new System.Drawing.Size(346, 214);
            this.TbMatrixA.TabIndex = 0;
            // 
            // TbMatrixB
            // 
            this.TbMatrixB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbMatrixB.Location = new System.Drawing.Point(2, 2);
            this.TbMatrixB.Multiline = true;
            this.TbMatrixB.Name = "TbMatrixB";
            this.TbMatrixB.Size = new System.Drawing.Size(423, 196);
            this.TbMatrixB.TabIndex = 1;
            // 
            // TbMatrixResult
            // 
            this.TbMatrixResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbMatrixResult.Location = new System.Drawing.Point(2, 2);
            this.TbMatrixResult.Multiline = true;
            this.TbMatrixResult.Name = "TbMatrixResult";
            this.TbMatrixResult.Size = new System.Drawing.Size(423, 214);
            this.TbMatrixResult.TabIndex = 1;
            // 
            // TLButtons
            // 
            this.TLButtons.ColumnCount = 2;
            this.TLButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLButtons.Controls.Add(this.BtnTest, 1, 2);
            this.TLButtons.Controls.Add(this.BtnInv, 0, 2);
            this.TLButtons.Controls.Add(this.BtnSolve, 1, 1);
            this.TLButtons.Controls.Add(this.BtnMul, 0, 1);
            this.TLButtons.Controls.Add(this.BtnSub, 1, 0);
            this.TLButtons.Controls.Add(this.BtnAdd, 0, 0);
            this.TLButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLButtons.Location = new System.Drawing.Point(2, 2);
            this.TLButtons.Name = "TLButtons";
            this.TLButtons.RowCount = 3;
            this.TLButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLButtons.Size = new System.Drawing.Size(346, 196);
            this.TLButtons.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdd.Location = new System.Drawing.Point(3, 3);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(167, 59);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnSub
            // 
            this.BtnSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSub.Location = new System.Drawing.Point(176, 3);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(167, 59);
            this.BtnSub.TabIndex = 1;
            this.BtnSub.Text = "Subtraction";
            this.BtnSub.UseVisualStyleBackColor = true;
            // 
            // BtnMul
            // 
            this.BtnMul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMul.Location = new System.Drawing.Point(3, 68);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(167, 59);
            this.BtnMul.TabIndex = 2;
            this.BtnMul.Text = "Multiplication";
            this.BtnMul.UseVisualStyleBackColor = true;
            // 
            // BtnSolve
            // 
            this.BtnSolve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSolve.Location = new System.Drawing.Point(176, 68);
            this.BtnSolve.Name = "BtnSolve";
            this.BtnSolve.Size = new System.Drawing.Size(167, 59);
            this.BtnSolve.TabIndex = 3;
            this.BtnSolve.Text = "Solve";
            this.BtnSolve.UseVisualStyleBackColor = true;
            // 
            // BtnInv
            // 
            this.BtnInv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnInv.Location = new System.Drawing.Point(3, 133);
            this.BtnInv.Name = "BtnInv";
            this.BtnInv.Size = new System.Drawing.Size(167, 60);
            this.BtnInv.TabIndex = 4;
            this.BtnInv.Text = "Inversion";
            this.BtnInv.UseVisualStyleBackColor = true;
            // 
            // BtnTest
            // 
            this.BtnTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnTest.Location = new System.Drawing.Point(176, 133);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(167, 60);
            this.BtnTest.TabIndex = 5;
            this.BtnTest.Text = "Test";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // MatrixOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 426);
            this.Controls.Add(this.ScVertical);
            this.Name = "MatrixOperationForm";
            this.Text = "Matrix operation";
            this.ScVertical.Panel1.ResumeLayout(false);
            this.ScVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScVertical)).EndInit();
            this.ScVertical.ResumeLayout(false);
            this.ScLeft.Panel1.ResumeLayout(false);
            this.ScLeft.Panel2.ResumeLayout(false);
            this.ScLeft.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScLeft)).EndInit();
            this.ScLeft.ResumeLayout(false);
            this.ScRight.Panel1.ResumeLayout(false);
            this.ScRight.Panel1.PerformLayout();
            this.ScRight.Panel2.ResumeLayout(false);
            this.ScRight.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScRight)).EndInit();
            this.ScRight.ResumeLayout(false);
            this.TLButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer ScVertical;
        private System.Windows.Forms.SplitContainer ScLeft;
        private System.Windows.Forms.TableLayoutPanel TLButtons;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.Button BtnInv;
        private System.Windows.Forms.Button BtnSolve;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TbMatrixA;
        private System.Windows.Forms.SplitContainer ScRight;
        private System.Windows.Forms.TextBox TbMatrixB;
        private System.Windows.Forms.TextBox TbMatrixResult;
    }
}

