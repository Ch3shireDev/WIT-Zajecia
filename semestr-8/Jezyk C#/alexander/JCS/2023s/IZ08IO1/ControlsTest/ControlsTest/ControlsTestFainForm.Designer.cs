namespace ControlsTest
{
    partial class ControlsTestFainForm
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
            this.TbCount = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.LblCount = new System.Windows.Forms.Label();
            this.TbResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TbCount
            // 
            this.TbCount.Location = new System.Drawing.Point(50, 12);
            this.TbCount.Name = "TbCount";
            this.TbCount.Size = new System.Drawing.Size(100, 20);
            this.TbCount.TabIndex = 0;
            this.TbCount.TextChanged += new System.EventHandler(this.TbCount_TextChanged);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCalculate.Location = new System.Drawing.Point(813, 10);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 1;
            this.BtnCalculate.Text = "Policz";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Location = new System.Drawing.Point(12, 15);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(32, 13);
            this.LblCount.TabIndex = 2;
            this.LblCount.Text = "Ilość:";
            // 
            // TbResults
            // 
            this.TbResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbResults.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TbResults.Location = new System.Drawing.Point(15, 38);
            this.TbResults.Multiline = true;
            this.TbResults.Name = "TbResults";
            this.TbResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbResults.Size = new System.Drawing.Size(873, 354);
            this.TbResults.TabIndex = 3;
            this.TbResults.WordWrap = false;
            // 
            // ControlsTestFainForm
            // 
            this.AcceptButton = this.BtnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 404);
            this.Controls.Add(this.TbResults);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.TbCount);
            this.Name = "ControlsTestFainForm";
            this.Text = "Suma elementów ciągu harmonicznego";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbCount;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.TextBox TbResults;
    }
}

