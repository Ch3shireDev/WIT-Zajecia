namespace MatrixOperation
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
            this.SpLeft = new System.Windows.Forms.SplitContainer();
            this.SpRight = new System.Windows.Forms.SplitContainer();
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.PnlMatrixA = new System.Windows.Forms.Panel();
            this.PnlMatrixB = new System.Windows.Forms.Panel();
            this.PnlMatrixResult = new System.Windows.Forms.Panel();
            this.TbMatrixB = new System.Windows.Forms.TextBox();
            this.TbMatrixA = new System.Windows.Forms.TextBox();
            this.TbMatrixResult = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ScVertical)).BeginInit();
            this.ScVertical.Panel1.SuspendLayout();
            this.ScVertical.Panel2.SuspendLayout();
            this.ScVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpLeft)).BeginInit();
            this.SpLeft.Panel1.SuspendLayout();
            this.SpLeft.Panel2.SuspendLayout();
            this.SpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpRight)).BeginInit();
            this.SpRight.Panel1.SuspendLayout();
            this.SpRight.Panel2.SuspendLayout();
            this.SpRight.SuspendLayout();
            this.PnlButtons.SuspendLayout();
            this.PnlMatrixA.SuspendLayout();
            this.PnlMatrixB.SuspendLayout();
            this.PnlMatrixResult.SuspendLayout();
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
            this.ScVertical.Panel1.Controls.Add(this.SpLeft);
            // 
            // ScVertical.Panel2
            // 
            this.ScVertical.Panel2.Controls.Add(this.SpRight);
            this.ScVertical.Size = new System.Drawing.Size(735, 422);
            this.ScVertical.SplitterDistance = 350;
            this.ScVertical.SplitterWidth = 8;
            this.ScVertical.TabIndex = 0;
            // 
            // SpLeft
            // 
            this.SpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpLeft.Location = new System.Drawing.Point(0, 0);
            this.SpLeft.Name = "SpLeft";
            this.SpLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SpLeft.Panel1
            // 
            this.SpLeft.Panel1.Controls.Add(this.PnlButtons);
            // 
            // SpLeft.Panel2
            // 
            this.SpLeft.Panel2.Controls.Add(this.PnlMatrixA);
            this.SpLeft.Size = new System.Drawing.Size(350, 422);
            this.SpLeft.SplitterDistance = 190;
            this.SpLeft.SplitterWidth = 8;
            this.SpLeft.TabIndex = 1;
            this.SpLeft.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.SpLeft_SplitterMoved);
            // 
            // SpRight
            // 
            this.SpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpRight.Location = new System.Drawing.Point(0, 0);
            this.SpRight.Name = "SpRight";
            this.SpRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SpRight.Panel1
            // 
            this.SpRight.Panel1.Controls.Add(this.PnlMatrixB);
            // 
            // SpRight.Panel2
            // 
            this.SpRight.Panel2.Controls.Add(this.PnlMatrixResult);
            this.SpRight.Size = new System.Drawing.Size(377, 422);
            this.SpRight.SplitterDistance = 190;
            this.SpRight.SplitterWidth = 8;
            this.SpRight.TabIndex = 2;
            this.SpRight.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.SpRight_SplitterMoved);
            // 
            // PnlButtons
            // 
            this.PnlButtons.Controls.Add(this.BtnAdd);
            this.PnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlButtons.Location = new System.Drawing.Point(0, 0);
            this.PnlButtons.Name = "PnlButtons";
            this.PnlButtons.Padding = new System.Windows.Forms.Padding(2);
            this.PnlButtons.Size = new System.Drawing.Size(350, 190);
            this.PnlButtons.TabIndex = 0;
            // 
            // PnlMatrixA
            // 
            this.PnlMatrixA.Controls.Add(this.TbMatrixA);
            this.PnlMatrixA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMatrixA.Location = new System.Drawing.Point(0, 0);
            this.PnlMatrixA.Name = "PnlMatrixA";
            this.PnlMatrixA.Padding = new System.Windows.Forms.Padding(2);
            this.PnlMatrixA.Size = new System.Drawing.Size(350, 224);
            this.PnlMatrixA.TabIndex = 1;
            // 
            // PnlMatrixB
            // 
            this.PnlMatrixB.Controls.Add(this.TbMatrixB);
            this.PnlMatrixB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMatrixB.Location = new System.Drawing.Point(0, 0);
            this.PnlMatrixB.Name = "PnlMatrixB";
            this.PnlMatrixB.Padding = new System.Windows.Forms.Padding(2);
            this.PnlMatrixB.Size = new System.Drawing.Size(377, 190);
            this.PnlMatrixB.TabIndex = 1;
            // 
            // PnlMatrixResult
            // 
            this.PnlMatrixResult.Controls.Add(this.TbMatrixResult);
            this.PnlMatrixResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMatrixResult.Location = new System.Drawing.Point(0, 0);
            this.PnlMatrixResult.Name = "PnlMatrixResult";
            this.PnlMatrixResult.Padding = new System.Windows.Forms.Padding(2);
            this.PnlMatrixResult.Size = new System.Drawing.Size(377, 224);
            this.PnlMatrixResult.TabIndex = 1;
            // 
            // TbMatrixB
            // 
            this.TbMatrixB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbMatrixB.Location = new System.Drawing.Point(2, 2);
            this.TbMatrixB.Multiline = true;
            this.TbMatrixB.Name = "TbMatrixB";
            this.TbMatrixB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbMatrixB.Size = new System.Drawing.Size(373, 186);
            this.TbMatrixB.TabIndex = 0;
            this.TbMatrixB.WordWrap = false;
            // 
            // TbMatrixA
            // 
            this.TbMatrixA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbMatrixA.Location = new System.Drawing.Point(2, 2);
            this.TbMatrixA.Multiline = true;
            this.TbMatrixA.Name = "TbMatrixA";
            this.TbMatrixA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbMatrixA.Size = new System.Drawing.Size(346, 220);
            this.TbMatrixA.TabIndex = 1;
            this.TbMatrixA.WordWrap = false;
            // 
            // TbMatrixResult
            // 
            this.TbMatrixResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbMatrixResult.Location = new System.Drawing.Point(2, 2);
            this.TbMatrixResult.Multiline = true;
            this.TbMatrixResult.Name = "TbMatrixResult";
            this.TbMatrixResult.ReadOnly = true;
            this.TbMatrixResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbMatrixResult.Size = new System.Drawing.Size(373, 220);
            this.TbMatrixResult.TabIndex = 1;
            this.TbMatrixResult.WordWrap = false;
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
            // MatrixOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 422);
            this.Controls.Add(this.ScVertical);
            this.Name = "MatrixOperationForm";
            this.Text = "Matrix Operation";
            this.ScVertical.Panel1.ResumeLayout(false);
            this.ScVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScVertical)).EndInit();
            this.ScVertical.ResumeLayout(false);
            this.SpLeft.Panel1.ResumeLayout(false);
            this.SpLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpLeft)).EndInit();
            this.SpLeft.ResumeLayout(false);
            this.SpRight.Panel1.ResumeLayout(false);
            this.SpRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpRight)).EndInit();
            this.SpRight.ResumeLayout(false);
            this.PnlButtons.ResumeLayout(false);
            this.PnlMatrixA.ResumeLayout(false);
            this.PnlMatrixA.PerformLayout();
            this.PnlMatrixB.ResumeLayout(false);
            this.PnlMatrixB.PerformLayout();
            this.PnlMatrixResult.ResumeLayout(false);
            this.PnlMatrixResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer ScVertical;
        private System.Windows.Forms.SplitContainer SpLeft;
        private System.Windows.Forms.Panel PnlButtons;
        private System.Windows.Forms.Panel PnlMatrixA;
        private System.Windows.Forms.TextBox TbMatrixA;
        private System.Windows.Forms.SplitContainer SpRight;
        private System.Windows.Forms.Panel PnlMatrixB;
        private System.Windows.Forms.TextBox TbMatrixB;
        private System.Windows.Forms.Panel PnlMatrixResult;
        private System.Windows.Forms.TextBox TbMatrixResult;
        private System.Windows.Forms.Button BtnAdd;
    }
}

