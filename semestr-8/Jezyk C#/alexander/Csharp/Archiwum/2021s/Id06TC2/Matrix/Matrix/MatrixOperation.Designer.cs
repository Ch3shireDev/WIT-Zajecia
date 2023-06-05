namespace Matrix
{
    partial class MatrixOperation
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
            this.SplHorizontal = new System.Windows.Forms.SplitContainer();
            this.SplLeft = new System.Windows.Forms.SplitContainer();
            this.BtnSolve = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.SplRight = new System.Windows.Forms.SplitContainer();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.TxtC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SplHorizontal)).BeginInit();
            this.SplHorizontal.Panel1.SuspendLayout();
            this.SplHorizontal.Panel2.SuspendLayout();
            this.SplHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplLeft)).BeginInit();
            this.SplLeft.Panel1.SuspendLayout();
            this.SplLeft.Panel2.SuspendLayout();
            this.SplLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplRight)).BeginInit();
            this.SplRight.Panel1.SuspendLayout();
            this.SplRight.Panel2.SuspendLayout();
            this.SplRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplHorizontal
            // 
            this.SplHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplHorizontal.Location = new System.Drawing.Point(0, 0);
            this.SplHorizontal.Name = "SplHorizontal";
            // 
            // SplHorizontal.Panel1
            // 
            this.SplHorizontal.Panel1.Controls.Add(this.SplLeft);
            // 
            // SplHorizontal.Panel2
            // 
            this.SplHorizontal.Panel2.Controls.Add(this.SplRight);
            this.SplHorizontal.Size = new System.Drawing.Size(907, 368);
            this.SplHorizontal.SplitterDistance = 465;
            this.SplHorizontal.TabIndex = 0;
            // 
            // SplLeft
            // 
            this.SplLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplLeft.Location = new System.Drawing.Point(0, 0);
            this.SplLeft.Name = "SplLeft";
            this.SplLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplLeft.Panel1
            // 
            this.SplLeft.Panel1.Controls.Add(this.BtnSolve);
            this.SplLeft.Panel1.Controls.Add(this.BtnMul);
            this.SplLeft.Panel1.Controls.Add(this.BtnSub);
            this.SplLeft.Panel1.Controls.Add(this.BtnAdd);
            // 
            // SplLeft.Panel2
            // 
            this.SplLeft.Panel2.Controls.Add(this.TxtA);
            this.SplLeft.Size = new System.Drawing.Size(465, 368);
            this.SplLeft.SplitterDistance = 172;
            this.SplLeft.TabIndex = 0;
            this.SplLeft.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.SplLeft_SplitterMoved);
            // 
            // BtnSolve
            // 
            this.BtnSolve.Location = new System.Drawing.Point(93, 41);
            this.BtnSolve.Name = "BtnSolve";
            this.BtnSolve.Size = new System.Drawing.Size(75, 23);
            this.BtnSolve.TabIndex = 3;
            this.BtnSolve.Text = "Solve";
            this.BtnSolve.UseVisualStyleBackColor = true;
            // 
            // BtnMul
            // 
            this.BtnMul.Location = new System.Drawing.Point(93, 12);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(75, 23);
            this.BtnMul.TabIndex = 2;
            this.BtnMul.Text = "Mul";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.BtnMul_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.Location = new System.Drawing.Point(12, 41);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(75, 23);
            this.BtnSub.TabIndex = 1;
            this.BtnSub.Text = "Sub";
            this.BtnSub.UseVisualStyleBackColor = true;
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
            // TxtA
            // 
            this.TxtA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtA.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtA.Location = new System.Drawing.Point(0, 0);
            this.TxtA.Multiline = true;
            this.TxtA.Name = "TxtA";
            this.TxtA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtA.Size = new System.Drawing.Size(465, 192);
            this.TxtA.TabIndex = 0;
            this.TxtA.WordWrap = false;
            // 
            // SplRight
            // 
            this.SplRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplRight.Location = new System.Drawing.Point(0, 0);
            this.SplRight.Name = "SplRight";
            this.SplRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplRight.Panel1
            // 
            this.SplRight.Panel1.Controls.Add(this.TxtB);
            // 
            // SplRight.Panel2
            // 
            this.SplRight.Panel2.Controls.Add(this.TxtC);
            this.SplRight.Size = new System.Drawing.Size(438, 368);
            this.SplRight.SplitterDistance = 172;
            this.SplRight.TabIndex = 1;
            this.SplRight.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.SplRight_SplitterMoved);
            // 
            // TxtB
            // 
            this.TxtB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtB.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtB.Location = new System.Drawing.Point(0, 0);
            this.TxtB.Multiline = true;
            this.TxtB.Name = "TxtB";
            this.TxtB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtB.Size = new System.Drawing.Size(438, 172);
            this.TxtB.TabIndex = 1;
            this.TxtB.WordWrap = false;
            // 
            // TxtC
            // 
            this.TxtC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtC.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtC.Location = new System.Drawing.Point(0, 0);
            this.TxtC.Multiline = true;
            this.TxtC.Name = "TxtC";
            this.TxtC.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtC.Size = new System.Drawing.Size(438, 192);
            this.TxtC.TabIndex = 1;
            this.TxtC.WordWrap = false;
            // 
            // MatrixOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 368);
            this.Controls.Add(this.SplHorizontal);
            this.Name = "MatrixOperation";
            this.Text = "Form1";
            this.SplHorizontal.Panel1.ResumeLayout(false);
            this.SplHorizontal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplHorizontal)).EndInit();
            this.SplHorizontal.ResumeLayout(false);
            this.SplLeft.Panel1.ResumeLayout(false);
            this.SplLeft.Panel2.ResumeLayout(false);
            this.SplLeft.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplLeft)).EndInit();
            this.SplLeft.ResumeLayout(false);
            this.SplRight.Panel1.ResumeLayout(false);
            this.SplRight.Panel1.PerformLayout();
            this.SplRight.Panel2.ResumeLayout(false);
            this.SplRight.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplRight)).EndInit();
            this.SplRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplHorizontal;
        private System.Windows.Forms.SplitContainer SplLeft;
        private System.Windows.Forms.Button BtnSolve;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.SplitContainer SplRight;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.TextBox TxtC;
    }
}

