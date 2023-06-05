namespace HarmSer
{
    partial class HarmSerMain
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
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lbCount = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.Viewer = new System.Windows.Forms.DataGridView();
            this.btnSingle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Viewer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(12, 24);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(75, 20);
            this.txtCount.TabIndex = 0;
            this.txtCount.Text = "100000000";
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCount_KeyDown);
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(12, 8);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(57, 13);
            this.lbCount.TabIndex = 1;
            this.lbCount.Text = "Ilość elem.";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 50);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Oblicz";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Viewer
            // 
            this.Viewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Viewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Viewer.Location = new System.Drawing.Point(93, 8);
            this.Viewer.Name = "Viewer";
            this.Viewer.Size = new System.Drawing.Size(290, 253);
            this.Viewer.TabIndex = 3;
            // 
            // btnSingle
            // 
            this.btnSingle.Location = new System.Drawing.Point(12, 79);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(75, 23);
            this.btnSingle.TabIndex = 4;
            this.btnSingle.Text = "Oblicz 0";
            this.btnSingle.UseVisualStyleBackColor = true;
            this.btnSingle.Click += new System.EventHandler(this.btnSingle_Click);
            // 
            // HarmSerMain
            // 
            this.AcceptButton = this.btnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 266);
            this.Controls.Add(this.btnSingle);
            this.Controls.Add(this.Viewer);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.txtCount);
            this.Name = "HarmSerMain";
            this.Text = "Ciąg harmoniczny ...";
            ((System.ComponentModel.ISupportInitialize)(this.Viewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.DataGridView Viewer;
        private System.Windows.Forms.Button btnSingle;
    }
}

