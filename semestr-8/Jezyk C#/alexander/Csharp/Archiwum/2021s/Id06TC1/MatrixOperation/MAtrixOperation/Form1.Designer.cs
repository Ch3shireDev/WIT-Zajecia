namespace MAtrixOperation
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
            this.SpliterVertical = new System.Windows.Forms.SplitContainer();
            this.SpliterLeft = new System.Windows.Forms.SplitContainer();
            this.BtnSolve = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.SpliterRight = new System.Windows.Forms.SplitContainer();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.TxtC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SpliterVertical)).BeginInit();
            this.SpliterVertical.Panel1.SuspendLayout();
            this.SpliterVertical.Panel2.SuspendLayout();
            this.SpliterVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpliterLeft)).BeginInit();
            this.SpliterLeft.Panel1.SuspendLayout();
            this.SpliterLeft.Panel2.SuspendLayout();
            this.SpliterLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpliterRight)).BeginInit();
            this.SpliterRight.Panel1.SuspendLayout();
            this.SpliterRight.Panel2.SuspendLayout();
            this.SpliterRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpliterVertical
            // 
            this.SpliterVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpliterVertical.Location = new System.Drawing.Point(0, 0);
            this.SpliterVertical.Name = "SpliterVertical";
            // 
            // SpliterVertical.Panel1
            // 
            this.SpliterVertical.Panel1.Controls.Add(this.SpliterLeft);
            // 
            // SpliterVertical.Panel2
            // 
            this.SpliterVertical.Panel2.Controls.Add(this.SpliterRight);
            this.SpliterVertical.Size = new System.Drawing.Size(691, 373);
            this.SpliterVertical.SplitterDistance = 348;
            this.SpliterVertical.TabIndex = 0;
            // 
            // SpliterLeft
            // 
            this.SpliterLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpliterLeft.Location = new System.Drawing.Point(0, 0);
            this.SpliterLeft.Name = "SpliterLeft";
            this.SpliterLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SpliterLeft.Panel1
            // 
            this.SpliterLeft.Panel1.Controls.Add(this.BtnSolve);
            this.SpliterLeft.Panel1.Controls.Add(this.BtnSub);
            this.SpliterLeft.Panel1.Controls.Add(this.BtnMul);
            this.SpliterLeft.Panel1.Controls.Add(this.BtnAdd);
            // 
            // SpliterLeft.Panel2
            // 
            this.SpliterLeft.Panel2.Controls.Add(this.TxtA);
            this.SpliterLeft.Size = new System.Drawing.Size(348, 373);
            this.SpliterLeft.SplitterDistance = 179;
            this.SpliterLeft.TabIndex = 0;
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
            this.BtnSub.Click += new System.EventHandler(this.BtnSub_Click);
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
            // TxtA
            // 
            this.TxtA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtA.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtA.Location = new System.Drawing.Point(0, 0);
            this.TxtA.Multiline = true;
            this.TxtA.Name = "TxtA";
            this.TxtA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtA.Size = new System.Drawing.Size(348, 190);
            this.TxtA.TabIndex = 1;
            this.TxtA.Text = "80\t60\t28\t\r\n54\t13\t38\t\r\n18\t88\t60\t\r\n";
            this.TxtA.WordWrap = false;
            // 
            // SpliterRight
            // 
            this.SpliterRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpliterRight.Location = new System.Drawing.Point(0, 0);
            this.SpliterRight.Name = "SpliterRight";
            this.SpliterRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SpliterRight.Panel1
            // 
            this.SpliterRight.Panel1.Controls.Add(this.TxtB);
            // 
            // SpliterRight.Panel2
            // 
            this.SpliterRight.Panel2.Controls.Add(this.TxtC);
            this.SpliterRight.Size = new System.Drawing.Size(339, 373);
            this.SpliterRight.SplitterDistance = 179;
            this.SpliterRight.TabIndex = 1;
            // 
            // TxtB
            // 
            this.TxtB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtB.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtB.Location = new System.Drawing.Point(0, 0);
            this.TxtB.Multiline = true;
            this.TxtB.Name = "TxtB";
            this.TxtB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtB.Size = new System.Drawing.Size(339, 179);
            this.TxtB.TabIndex = 0;
            this.TxtB.Text = "39\t15\t85\t4\t\r\n90\t90\t70\t6\t\r\n51\t57\t72\t81\t\r\n\r\n";
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
            this.TxtC.Size = new System.Drawing.Size(339, 190);
            this.TxtC.TabIndex = 1;
            this.TxtC.Text = "9948\t8196\t13016\t2948\t\r\n5214\t4146\t8236\t3372\t\r\n11682\t11610\t12010\t5460\t\r\n";
            this.TxtC.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 373);
            this.Controls.Add(this.SpliterVertical);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SpliterVertical.Panel1.ResumeLayout(false);
            this.SpliterVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpliterVertical)).EndInit();
            this.SpliterVertical.ResumeLayout(false);
            this.SpliterLeft.Panel1.ResumeLayout(false);
            this.SpliterLeft.Panel2.ResumeLayout(false);
            this.SpliterLeft.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpliterLeft)).EndInit();
            this.SpliterLeft.ResumeLayout(false);
            this.SpliterRight.Panel1.ResumeLayout(false);
            this.SpliterRight.Panel1.PerformLayout();
            this.SpliterRight.Panel2.ResumeLayout(false);
            this.SpliterRight.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpliterRight)).EndInit();
            this.SpliterRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SpliterVertical;
        private System.Windows.Forms.SplitContainer SpliterLeft;
        private System.Windows.Forms.Button BtnSolve;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.SplitContainer SpliterRight;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.TextBox TxtC;
    }
}

