namespace Test004
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
            this.ValueA = new System.Windows.Forms.TextBox();
            this.ValueB = new System.Windows.Forms.TextBox();
            this.ResultAdd = new System.Windows.Forms.TextBox();
            this.CaptionA = new System.Windows.Forms.Label();
            this.CaptionB = new System.Windows.Forms.Label();
            this.CaptionAdd = new System.Windows.Forms.Label();
            this.CaptionSub = new System.Windows.Forms.Label();
            this.ResultSub = new System.Windows.Forms.TextBox();
            this.CaptionMul = new System.Windows.Forms.Label();
            this.ResultMul = new System.Windows.Forms.TextBox();
            this.CaptionDiv = new System.Windows.Forms.Label();
            this.ResultDiv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ValueA
            // 
            this.ValueA.Location = new System.Drawing.Point(8, 25);
            this.ValueA.Name = "ValueA";
            this.ValueA.Size = new System.Drawing.Size(100, 20);
            this.ValueA.TabIndex = 1;
            this.ValueA.Text = "0";
            this.ValueA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ValueA.TextChanged += new System.EventHandler(this.ValueChange);
            this.ValueA.Enter += new System.EventHandler(this.ValueEnter);
            // 
            // ValueB
            // 
            this.ValueB.Location = new System.Drawing.Point(114, 25);
            this.ValueB.Name = "ValueB";
            this.ValueB.Size = new System.Drawing.Size(100, 20);
            this.ValueB.TabIndex = 2;
            this.ValueB.Text = "0";
            this.ValueB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ValueB.TextChanged += new System.EventHandler(this.ValueChange);
            this.ValueB.Enter += new System.EventHandler(this.ValueEnter);
            // 
            // ResultAdd
            // 
            this.ResultAdd.Location = new System.Drawing.Point(31, 51);
            this.ResultAdd.Name = "ResultAdd";
            this.ResultAdd.ReadOnly = true;
            this.ResultAdd.Size = new System.Drawing.Size(108, 20);
            this.ResultAdd.TabIndex = 0;
            this.ResultAdd.TabStop = false;
            this.ResultAdd.Tag = "0";
            this.ResultAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CaptionA
            // 
            this.CaptionA.AutoSize = true;
            this.CaptionA.Location = new System.Drawing.Point(5, 9);
            this.CaptionA.Name = "CaptionA";
            this.CaptionA.Size = new System.Drawing.Size(14, 13);
            this.CaptionA.TabIndex = 3;
            this.CaptionA.Text = "&A";
            // 
            // CaptionB
            // 
            this.CaptionB.AutoSize = true;
            this.CaptionB.Location = new System.Drawing.Point(111, 9);
            this.CaptionB.Name = "CaptionB";
            this.CaptionB.Size = new System.Drawing.Size(14, 13);
            this.CaptionB.TabIndex = 4;
            this.CaptionB.Text = "&B";
            // 
            // CaptionAdd
            // 
            this.CaptionAdd.AutoSize = true;
            this.CaptionAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CaptionAdd.Location = new System.Drawing.Point(12, 54);
            this.CaptionAdd.Name = "CaptionAdd";
            this.CaptionAdd.Size = new System.Drawing.Size(18, 20);
            this.CaptionAdd.TabIndex = 5;
            this.CaptionAdd.Tag = "0";
            this.CaptionAdd.Text = "+";
            this.CaptionAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CaptionAdd.Click += new System.EventHandler(this.CaptionClick);
            // 
            // CaptionSub
            // 
            this.CaptionSub.AutoSize = true;
            this.CaptionSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CaptionSub.Location = new System.Drawing.Point(12, 80);
            this.CaptionSub.Name = "CaptionSub";
            this.CaptionSub.Size = new System.Drawing.Size(18, 20);
            this.CaptionSub.TabIndex = 7;
            this.CaptionSub.Tag = "1";
            this.CaptionSub.Text = "~";
            this.CaptionSub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CaptionSub.Click += new System.EventHandler(this.CaptionClick);
            // 
            // ResultSub
            // 
            this.ResultSub.Location = new System.Drawing.Point(31, 77);
            this.ResultSub.Name = "ResultSub";
            this.ResultSub.ReadOnly = true;
            this.ResultSub.Size = new System.Drawing.Size(108, 20);
            this.ResultSub.TabIndex = 6;
            this.ResultSub.TabStop = false;
            this.ResultSub.Tag = "1";
            this.ResultSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CaptionMul
            // 
            this.CaptionMul.AutoSize = true;
            this.CaptionMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CaptionMul.Location = new System.Drawing.Point(12, 106);
            this.CaptionMul.Name = "CaptionMul";
            this.CaptionMul.Size = new System.Drawing.Size(15, 20);
            this.CaptionMul.TabIndex = 9;
            this.CaptionMul.Tag = "2";
            this.CaptionMul.Text = "*";
            this.CaptionMul.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CaptionMul.Click += new System.EventHandler(this.CaptionClick);
            // 
            // ResultMul
            // 
            this.ResultMul.Location = new System.Drawing.Point(31, 103);
            this.ResultMul.Name = "ResultMul";
            this.ResultMul.ReadOnly = true;
            this.ResultMul.Size = new System.Drawing.Size(108, 20);
            this.ResultMul.TabIndex = 8;
            this.ResultMul.TabStop = false;
            this.ResultMul.Tag = "2";
            this.ResultMul.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CaptionDiv
            // 
            this.CaptionDiv.AutoSize = true;
            this.CaptionDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CaptionDiv.Location = new System.Drawing.Point(12, 132);
            this.CaptionDiv.Name = "CaptionDiv";
            this.CaptionDiv.Size = new System.Drawing.Size(13, 20);
            this.CaptionDiv.TabIndex = 11;
            this.CaptionDiv.Tag = "3";
            this.CaptionDiv.Text = "/";
            this.CaptionDiv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CaptionDiv.Click += new System.EventHandler(this.CaptionClick);
            // 
            // ResultDiv
            // 
            this.ResultDiv.Location = new System.Drawing.Point(31, 129);
            this.ResultDiv.Name = "ResultDiv";
            this.ResultDiv.ReadOnly = true;
            this.ResultDiv.Size = new System.Drawing.Size(108, 20);
            this.ResultDiv.TabIndex = 10;
            this.ResultDiv.TabStop = false;
            this.ResultDiv.Tag = "3";
            this.ResultDiv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 262);
            this.Controls.Add(this.CaptionDiv);
            this.Controls.Add(this.ResultDiv);
            this.Controls.Add(this.CaptionMul);
            this.Controls.Add(this.ResultMul);
            this.Controls.Add(this.CaptionSub);
            this.Controls.Add(this.ResultSub);
            this.Controls.Add(this.CaptionAdd);
            this.Controls.Add(this.CaptionB);
            this.Controls.Add(this.CaptionA);
            this.Controls.Add(this.ResultAdd);
            this.Controls.Add(this.ValueB);
            this.Controls.Add(this.ValueA);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ValueA;
        private System.Windows.Forms.TextBox ValueB;
        private System.Windows.Forms.TextBox ResultAdd;
        private System.Windows.Forms.Label CaptionA;
        private System.Windows.Forms.Label CaptionB;
        private System.Windows.Forms.Label CaptionAdd;
        private System.Windows.Forms.Label CaptionSub;
        private System.Windows.Forms.TextBox ResultSub;
        private System.Windows.Forms.Label CaptionMul;
        private System.Windows.Forms.TextBox ResultMul;
        private System.Windows.Forms.Label CaptionDiv;
        private System.Windows.Forms.TextBox ResultDiv;
    }
}

