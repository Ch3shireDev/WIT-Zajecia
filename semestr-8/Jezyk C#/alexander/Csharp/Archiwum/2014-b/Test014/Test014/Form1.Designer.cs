namespace Test014
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
            this.Operation = new System.Windows.Forms.ComboBox();
            this.ValueB = new System.Windows.Forms.TextBox();
            this.ResultValue = new System.Windows.Forms.TextBox();
            this.LabelA = new System.Windows.Forms.Label();
            this.LabelOp = new System.Windows.Forms.Label();
            this.LabelB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ValueA
            // 
            this.ValueA.Location = new System.Drawing.Point(32, 36);
            this.ValueA.Name = "ValueA";
            this.ValueA.Size = new System.Drawing.Size(100, 20);
            this.ValueA.TabIndex = 0;
            this.ValueA.Text = "0";
            this.ValueA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ValueA.TextChanged += new System.EventHandler(this.Operation_SelectedIndexChanged);
            // 
            // Operation
            // 
            this.Operation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Operation.FormattingEnabled = true;
            this.Operation.Location = new System.Drawing.Point(138, 35);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(102, 21);
            this.Operation.TabIndex = 1;
            this.Operation.SelectedIndexChanged += new System.EventHandler(this.Operation_SelectedIndexChanged);
            // 
            // ValueB
            // 
            this.ValueB.Location = new System.Drawing.Point(246, 36);
            this.ValueB.Name = "ValueB";
            this.ValueB.Size = new System.Drawing.Size(100, 20);
            this.ValueB.TabIndex = 2;
            this.ValueB.Text = "0";
            this.ValueB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ValueB.TextChanged += new System.EventHandler(this.Operation_SelectedIndexChanged);
            // 
            // ResultValue
            // 
            this.ResultValue.Location = new System.Drawing.Point(32, 62);
            this.ResultValue.Name = "ResultValue";
            this.ResultValue.ReadOnly = true;
            this.ResultValue.Size = new System.Drawing.Size(314, 20);
            this.ResultValue.TabIndex = 3;
            this.ResultValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelA
            // 
            this.LabelA.AutoSize = true;
            this.LabelA.Location = new System.Drawing.Point(29, 20);
            this.LabelA.Name = "LabelA";
            this.LabelA.Size = new System.Drawing.Size(48, 13);
            this.LabelA.TabIndex = 4;
            this.LabelA.Text = "Liczba &A";
            // 
            // LabelOp
            // 
            this.LabelOp.AutoSize = true;
            this.LabelOp.Location = new System.Drawing.Point(135, 20);
            this.LabelOp.Name = "LabelOp";
            this.LabelOp.Size = new System.Drawing.Size(50, 13);
            this.LabelOp.TabIndex = 5;
            this.LabelOp.Text = "&Operacja";
            // 
            // LabelB
            // 
            this.LabelB.AutoSize = true;
            this.LabelB.Location = new System.Drawing.Point(246, 20);
            this.LabelB.Name = "LabelB";
            this.LabelB.Size = new System.Drawing.Size(48, 13);
            this.LabelB.TabIndex = 6;
            this.LabelB.Text = "Liczba &B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 109);
            this.Controls.Add(this.LabelB);
            this.Controls.Add(this.LabelOp);
            this.Controls.Add(this.LabelA);
            this.Controls.Add(this.ResultValue);
            this.Controls.Add(this.ValueB);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.ValueA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ValueA;
        private System.Windows.Forms.ComboBox Operation;
        private System.Windows.Forms.TextBox ValueB;
        private System.Windows.Forms.TextBox ResultValue;
        private System.Windows.Forms.Label LabelA;
        private System.Windows.Forms.Label LabelOp;
        private System.Windows.Forms.Label LabelB;
    }
}

