namespace Test013
{
    partial class Test013
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
            this.AValue = new System.Windows.Forms.TextBox();
            this.BValue = new System.Windows.Forms.TextBox();
            this.ResultValue = new System.Windows.Forms.TextBox();
            this.Operation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AValue
            // 
            this.AValue.Location = new System.Drawing.Point(12, 12);
            this.AValue.Name = "AValue";
            this.AValue.Size = new System.Drawing.Size(100, 20);
            this.AValue.TabIndex = 1;
            this.AValue.Text = "42";
            this.AValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AValue.TextChanged += new System.EventHandler(this.ABValue_TextChanged);
            this.AValue.Enter += new System.EventHandler(this.ABValue_Enter);
            // 
            // BValue
            // 
            this.BValue.Location = new System.Drawing.Point(12, 38);
            this.BValue.Name = "BValue";
            this.BValue.Size = new System.Drawing.Size(100, 20);
            this.BValue.TabIndex = 2;
            this.BValue.Text = "42";
            this.BValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BValue.TextChanged += new System.EventHandler(this.ABValue_TextChanged);
            this.BValue.Enter += new System.EventHandler(this.ABValue_Enter);
            // 
            // ResultValue
            // 
            this.ResultValue.Location = new System.Drawing.Point(12, 64);
            this.ResultValue.Name = "ResultValue";
            this.ResultValue.ReadOnly = true;
            this.ResultValue.Size = new System.Drawing.Size(100, 20);
            this.ResultValue.TabIndex = 4;
            this.ResultValue.TabStop = false;
            this.ResultValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Operation
            // 
            this.Operation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Operation.FormattingEnabled = true;
            this.Operation.Items.AddRange(new object[] {
            "Add",
            "Sub",
            "Mul",
            "Div"});
            this.Operation.Location = new System.Drawing.Point(118, 25);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(60, 21);
            this.Operation.TabIndex = 2;
            this.Operation.SelectedIndexChanged += new System.EventHandler(this.Operation_SelectedIndexChanged);
            // 
            // Test013
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.ResultValue);
            this.Controls.Add(this.BValue);
            this.Controls.Add(this.AValue);
            this.Name = "Test013";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AValue;
        private System.Windows.Forms.TextBox BValue;
        private System.Windows.Forms.TextBox ResultValue;
        private System.Windows.Forms.ComboBox Operation;
    }
}

