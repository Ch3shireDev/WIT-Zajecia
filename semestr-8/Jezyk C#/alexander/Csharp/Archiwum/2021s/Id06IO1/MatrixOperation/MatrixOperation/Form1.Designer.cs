namespace MatrixOperation
{
    partial class Form1
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
            this.scVertical = new System.Windows.Forms.SplitContainer();
            this.SplitLeft = new System.Windows.Forms.SplitContainer();
            this.Buttons = new System.Windows.Forms.Panel();
            this.BtnMul = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.MatrixA = new System.Windows.Forms.TextBox();
            this.SplitRight = new System.Windows.Forms.SplitContainer();
            this.MatrixB = new System.Windows.Forms.TextBox();
            this.MatrixC = new System.Windows.Forms.TextBox();
            this.BtnSolve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scVertical)).BeginInit();
            this.scVertical.Panel1.SuspendLayout();
            this.scVertical.Panel2.SuspendLayout();
            this.scVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitLeft)).BeginInit();
            this.SplitLeft.Panel1.SuspendLayout();
            this.SplitLeft.Panel2.SuspendLayout();
            this.SplitLeft.SuspendLayout();
            this.Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitRight)).BeginInit();
            this.SplitRight.Panel1.SuspendLayout();
            this.SplitRight.Panel2.SuspendLayout();
            this.SplitRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // scVertical
            // 
            this.scVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scVertical.Location = new System.Drawing.Point(0, 0);
            this.scVertical.Name = "scVertical";
            // 
            // scVertical.Panel1
            // 
            this.scVertical.Panel1.Controls.Add(this.SplitLeft);
            // 
            // scVertical.Panel2
            // 
            this.scVertical.Panel2.Controls.Add(this.SplitRight);
            this.scVertical.Size = new System.Drawing.Size(1014, 262);
            this.scVertical.SplitterDistance = 504;
            this.scVertical.TabIndex = 0;
            // 
            // SplitLeft
            // 
            this.SplitLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitLeft.Location = new System.Drawing.Point(0, 0);
            this.SplitLeft.Name = "SplitLeft";
            this.SplitLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitLeft.Panel1
            // 
            this.SplitLeft.Panel1.Controls.Add(this.Buttons);
            // 
            // SplitLeft.Panel2
            // 
            this.SplitLeft.Panel2.Controls.Add(this.MatrixA);
            this.SplitLeft.Size = new System.Drawing.Size(504, 262);
            this.SplitLeft.SplitterDistance = 124;
            this.SplitLeft.TabIndex = 1;
            this.SplitLeft.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.SplitLeft_SplitterMoved);
            // 
            // Buttons
            // 
            this.Buttons.Controls.Add(this.BtnSolve);
            this.Buttons.Controls.Add(this.BtnMul);
            this.Buttons.Controls.Add(this.BtnAdd);
            this.Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Buttons.Location = new System.Drawing.Point(0, 0);
            this.Buttons.Name = "Buttons";
            this.Buttons.Size = new System.Drawing.Size(504, 124);
            this.Buttons.TabIndex = 0;
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
            this.MatrixA.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MatrixA.Location = new System.Drawing.Point(0, 0);
            this.MatrixA.Multiline = true;
            this.MatrixA.Name = "MatrixA";
            this.MatrixA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MatrixA.Size = new System.Drawing.Size(504, 134);
            this.MatrixA.TabIndex = 1;
            this.MatrixA.WordWrap = false;
            // 
            // SplitRight
            // 
            this.SplitRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitRight.Location = new System.Drawing.Point(0, 0);
            this.SplitRight.Name = "SplitRight";
            this.SplitRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitRight.Panel1
            // 
            this.SplitRight.Panel1.Controls.Add(this.MatrixB);
            // 
            // SplitRight.Panel2
            // 
            this.SplitRight.Panel2.Controls.Add(this.MatrixC);
            this.SplitRight.Size = new System.Drawing.Size(506, 262);
            this.SplitRight.SplitterDistance = 124;
            this.SplitRight.TabIndex = 1;
            this.SplitRight.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.SplitRight_SplitterMoved);
            // 
            // MatrixB
            // 
            this.MatrixB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatrixB.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MatrixB.Location = new System.Drawing.Point(0, 0);
            this.MatrixB.Multiline = true;
            this.MatrixB.Name = "MatrixB";
            this.MatrixB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MatrixB.Size = new System.Drawing.Size(506, 124);
            this.MatrixB.TabIndex = 0;
            this.MatrixB.WordWrap = false;
            // 
            // MatrixC
            // 
            this.MatrixC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatrixC.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MatrixC.Location = new System.Drawing.Point(0, 0);
            this.MatrixC.Multiline = true;
            this.MatrixC.Name = "MatrixC";
            this.MatrixC.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MatrixC.Size = new System.Drawing.Size(506, 134);
            this.MatrixC.TabIndex = 1;
            this.MatrixC.WordWrap = false;
            // 
            // BtnSolve
            // 
            this.BtnSolve.Location = new System.Drawing.Point(93, 41);
            this.BtnSolve.Name = "BtnSolve";
            this.BtnSolve.Size = new System.Drawing.Size(75, 23);
            this.BtnSolve.TabIndex = 2;
            this.BtnSolve.Text = "Solve";
            this.BtnSolve.UseVisualStyleBackColor = true;
            this.BtnSolve.Click += new System.EventHandler(this.BtnSolve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 262);
            this.Controls.Add(this.scVertical);
            this.Name = "Form1";
            this.Text = "Form1";
            this.scVertical.Panel1.ResumeLayout(false);
            this.scVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scVertical)).EndInit();
            this.scVertical.ResumeLayout(false);
            this.SplitLeft.Panel1.ResumeLayout(false);
            this.SplitLeft.Panel2.ResumeLayout(false);
            this.SplitLeft.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitLeft)).EndInit();
            this.SplitLeft.ResumeLayout(false);
            this.Buttons.ResumeLayout(false);
            this.SplitRight.Panel1.ResumeLayout(false);
            this.SplitRight.Panel1.PerformLayout();
            this.SplitRight.Panel2.ResumeLayout(false);
            this.SplitRight.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitRight)).EndInit();
            this.SplitRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scVertical;
        private System.Windows.Forms.SplitContainer SplitLeft;
        private System.Windows.Forms.Panel Buttons;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox MatrixA;
        private System.Windows.Forms.SplitContainer SplitRight;
        private System.Windows.Forms.TextBox MatrixB;
        private System.Windows.Forms.TextBox MatrixC;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button BtnSolve;
    }
}

