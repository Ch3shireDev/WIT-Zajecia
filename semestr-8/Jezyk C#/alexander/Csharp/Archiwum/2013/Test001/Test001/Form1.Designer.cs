namespace Test001
{
    partial class CalcForm
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
            this.OpA = new System.Windows.Forms.TextBox();
            this.Op = new System.Windows.Forms.ComboBox();
            this.OpB = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OpA
            // 
            this.OpA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpA.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpA.Location = new System.Drawing.Point(12, 12);
            this.OpA.Name = "OpA";
            this.OpA.Size = new System.Drawing.Size(170, 20);
            this.OpA.TabIndex = 1;
            this.OpA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OpA.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // Op
            // 
            this.Op.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Op.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Op.FormattingEnabled = true;
            this.Op.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.Op.Location = new System.Drawing.Point(188, 11);
            this.Op.Name = "Op";
            this.Op.Size = new System.Drawing.Size(39, 21);
            this.Op.TabIndex = 2;
            this.Op.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // OpB
            // 
            this.OpB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpB.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpB.Location = new System.Drawing.Point(233, 12);
            this.OpB.Name = "OpB";
            this.OpB.Size = new System.Drawing.Size(168, 20);
            this.OpB.TabIndex = 3;
            this.OpB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OpB.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Result.Location = new System.Drawing.Point(12, 38);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(389, 20);
            this.Result.TabIndex = 4;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 70);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.OpB);
            this.Controls.Add(this.Op);
            this.Controls.Add(this.OpA);
            this.MaximumSize = new System.Drawing.Size(99999, 108);
            this.MinimumSize = new System.Drawing.Size(431, 108);
            this.Name = "CalcForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OpA;
        private System.Windows.Forms.ComboBox Op;
        private System.Windows.Forms.TextBox OpB;
        private System.Windows.Forms.TextBox Result;

    }
}

