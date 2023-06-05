namespace TableConvert
{
    partial class TableConvertForm
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
            this.PTop = new System.Windows.Forms.Panel();
            this.EdParams = new System.Windows.Forms.TextBox();
            this.SpTopVert = new System.Windows.Forms.Splitter();
            this.PButtons = new System.Windows.Forms.Panel();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.SpHorz = new System.Windows.Forms.Splitter();
            this.PBottom = new System.Windows.Forms.Panel();
            this.EdResult = new System.Windows.Forms.TextBox();
            this.SpBottomVert = new System.Windows.Forms.Splitter();
            this.EdMatrix = new System.Windows.Forms.TextBox();
            this.PTop.SuspendLayout();
            this.PButtons.SuspendLayout();
            this.PBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // PTop
            // 
            this.PTop.Controls.Add(this.EdParams);
            this.PTop.Controls.Add(this.SpTopVert);
            this.PTop.Controls.Add(this.PButtons);
            this.PTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PTop.Location = new System.Drawing.Point(0, 0);
            this.PTop.Name = "PTop";
            this.PTop.Size = new System.Drawing.Size(557, 100);
            this.PTop.TabIndex = 6;
            // 
            // EdParams
            // 
            this.EdParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EdParams.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.EdParams.Location = new System.Drawing.Point(397, 0);
            this.EdParams.Multiline = true;
            this.EdParams.Name = "EdParams";
            this.EdParams.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EdParams.Size = new System.Drawing.Size(160, 100);
            this.EdParams.TabIndex = 9;
            this.EdParams.Text = "0,55\r\n5,92\r\n2,42\r\n9,5";
            this.EdParams.WordWrap = false;
            // 
            // SpTopVert
            // 
            this.SpTopVert.Location = new System.Drawing.Point(392, 0);
            this.SpTopVert.Name = "SpTopVert";
            this.SpTopVert.Size = new System.Drawing.Size(5, 100);
            this.SpTopVert.TabIndex = 8;
            this.SpTopVert.TabStop = false;
            // 
            // PButtons
            // 
            this.PButtons.Controls.Add(this.BtnConvert);
            this.PButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.PButtons.Location = new System.Drawing.Point(0, 0);
            this.PButtons.Name = "PButtons";
            this.PButtons.Size = new System.Drawing.Size(392, 100);
            this.PButtons.TabIndex = 6;
            this.PButtons.Resize += new System.EventHandler(this.PButtons_Resize);
            // 
            // BtnConvert
            // 
            this.BtnConvert.Location = new System.Drawing.Point(12, 12);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(75, 23);
            this.BtnConvert.TabIndex = 2;
            this.BtnConvert.Text = "Convert";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // SpHorz
            // 
            this.SpHorz.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.SpHorz.Dock = System.Windows.Forms.DockStyle.Top;
            this.SpHorz.Location = new System.Drawing.Point(0, 100);
            this.SpHorz.Name = "SpHorz";
            this.SpHorz.Size = new System.Drawing.Size(557, 5);
            this.SpHorz.TabIndex = 7;
            this.SpHorz.TabStop = false;
            // 
            // PBottom
            // 
            this.PBottom.Controls.Add(this.EdResult);
            this.PBottom.Controls.Add(this.SpBottomVert);
            this.PBottom.Controls.Add(this.EdMatrix);
            this.PBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBottom.Location = new System.Drawing.Point(0, 105);
            this.PBottom.Name = "PBottom";
            this.PBottom.Size = new System.Drawing.Size(557, 246);
            this.PBottom.TabIndex = 8;
            // 
            // EdResult
            // 
            this.EdResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EdResult.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.EdResult.Location = new System.Drawing.Point(397, 0);
            this.EdResult.Multiline = true;
            this.EdResult.Name = "EdResult";
            this.EdResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EdResult.Size = new System.Drawing.Size(160, 246);
            this.EdResult.TabIndex = 10;
            this.EdResult.WordWrap = false;
            // 
            // SpBottomVert
            // 
            this.SpBottomVert.Location = new System.Drawing.Point(392, 0);
            this.SpBottomVert.Name = "SpBottomVert";
            this.SpBottomVert.Size = new System.Drawing.Size(5, 246);
            this.SpBottomVert.TabIndex = 9;
            this.SpBottomVert.TabStop = false;
            // 
            // EdMatrix
            // 
            this.EdMatrix.Dock = System.Windows.Forms.DockStyle.Left;
            this.EdMatrix.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdMatrix.Location = new System.Drawing.Point(0, 0);
            this.EdMatrix.Multiline = true;
            this.EdMatrix.Name = "EdMatrix";
            this.EdMatrix.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EdMatrix.Size = new System.Drawing.Size(392, 246);
            this.EdMatrix.TabIndex = 1;
            this.EdMatrix.Text = "5,93\t1,23\t9,01\t8,36\r\n6,61\t9,72\t3,9\t6,13\r\n2,19\t4,62\t9,17\t9,84\r\n2,35\t0,95\t8,04\t7,57" +
    "";
            this.EdMatrix.WordWrap = false;
            this.EdMatrix.Resize += new System.EventHandler(this.EdMatrix_Resize);
            // 
            // TableConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 351);
            this.Controls.Add(this.PBottom);
            this.Controls.Add(this.SpHorz);
            this.Controls.Add(this.PTop);
            this.Name = "TableConvertForm";
            this.Text = "Table Conversion ...";
            this.PTop.ResumeLayout(false);
            this.PTop.PerformLayout();
            this.PButtons.ResumeLayout(false);
            this.PBottom.ResumeLayout(false);
            this.PBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PTop;
        private System.Windows.Forms.TextBox EdParams;
        private System.Windows.Forms.Splitter SpTopVert;
        private System.Windows.Forms.Panel PButtons;
        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.Splitter SpHorz;
        private System.Windows.Forms.Panel PBottom;
        private System.Windows.Forms.TextBox EdResult;
        private System.Windows.Forms.Splitter SpBottomVert;
        private System.Windows.Forms.TextBox EdMatrix;
    }
}

