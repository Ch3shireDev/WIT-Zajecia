namespace z012
{
    partial class TestForm
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
            this.Operation = new System.Windows.Forms.ComboBox();
            this.ValueB = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ValueA
            // 
            this.ValueA.Location = new System.Drawing.Point(12, 12);
            this.ValueA.Name = "ValueA";
            this.ValueA.Size = new System.Drawing.Size(100, 20);
            this.ValueA.TabIndex = 1;
            this.ValueA.Text = "0";
            this.ValueA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ValueA.TextChanged += new System.EventHandler(this.Operation_SelectedIndexChanged);
            // 
            // Operation
            // 
            this.Operation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Operation.FormattingEnabled = true;
            this.Operation.Items.AddRange(new object[] {
            "Dodaj",
            "Odejmij",
            "Mnóż",
            "Dziel"});
            this.Operation.Location = new System.Drawing.Point(118, 11);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(121, 21);
            this.Operation.TabIndex = 2;
            this.Operation.SelectedIndexChanged += new System.EventHandler(this.Operation_SelectedIndexChanged);
            // 
            // ValueB
            // 
            this.ValueB.Location = new System.Drawing.Point(245, 12);
            this.ValueB.Name = "ValueB";
            this.ValueB.Size = new System.Drawing.Size(100, 20);
            this.ValueB.TabIndex = 3;
            this.ValueB.Text = "0";
            this.ValueB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ValueB.TextChanged += new System.EventHandler(this.Operation_SelectedIndexChanged);
            // 
            // Result
            // 
            this.Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Result.Location = new System.Drawing.Point(351, 12);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(193, 20);
            this.Result.TabIndex = 4;
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 44);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ValueB);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.ValueA);
            this.Name = "TestForm";
            this.Text = "Formatka testowa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ValueA;
        private System.Windows.Forms.ComboBox Operation;
        private System.Windows.Forms.TextBox ValueB;
        private System.Windows.Forms.TextBox Result;

    }
}

