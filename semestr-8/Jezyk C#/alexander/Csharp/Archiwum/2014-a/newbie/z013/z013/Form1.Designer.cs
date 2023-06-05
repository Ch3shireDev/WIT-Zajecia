namespace z013
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
            this.Panel = new System.Windows.Forms.Panel();
            this.Value = new System.Windows.Forms.TextBox();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnEq = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnPoint = new System.Windows.Forms.Button();
            this.BtnMul = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            this.Table.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.Value);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Padding = new System.Windows.Forms.Padding(4);
            this.Panel.Size = new System.Drawing.Size(284, 40);
            this.Panel.TabIndex = 1;
            // 
            // Value
            // 
            this.Value.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Value.Location = new System.Drawing.Point(4, 4);
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            this.Value.Size = new System.Drawing.Size(276, 27);
            this.Value.TabIndex = 0;
            this.Value.Text = "0";
            this.Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Value_KeyPress);
            // 
            // Table
            // 
            this.Table.ColumnCount = 4;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Table.Controls.Add(this.BtnDiv, 3, 3);
            this.Table.Controls.Add(this.BtnEq, 2, 3);
            this.Table.Controls.Add(this.Btn0, 1, 3);
            this.Table.Controls.Add(this.BtnPoint, 0, 3);
            this.Table.Controls.Add(this.BtnMul, 3, 2);
            this.Table.Controls.Add(this.Btn3, 2, 2);
            this.Table.Controls.Add(this.Btn2, 1, 2);
            this.Table.Controls.Add(this.Btn1, 0, 2);
            this.Table.Controls.Add(this.BtnSub, 3, 1);
            this.Table.Controls.Add(this.Btn6, 2, 1);
            this.Table.Controls.Add(this.Btn5, 1, 1);
            this.Table.Controls.Add(this.Btn4, 0, 1);
            this.Table.Controls.Add(this.BtnAdd, 3, 0);
            this.Table.Controls.Add(this.Btn9, 2, 0);
            this.Table.Controls.Add(this.Btn8, 1, 0);
            this.Table.Controls.Add(this.Btn7, 0, 0);
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Location = new System.Drawing.Point(0, 40);
            this.Table.Name = "Table";
            this.Table.RowCount = 4;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Table.Size = new System.Drawing.Size(284, 278);
            this.Table.TabIndex = 2;
            // 
            // BtnDiv
            // 
            this.BtnDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDiv.Location = new System.Drawing.Point(216, 210);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(65, 65);
            this.BtnDiv.TabIndex = 15;
            this.BtnDiv.Tag = "";
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnOpr_Click);
            // 
            // BtnEq
            // 
            this.BtnEq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEq.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnEq.Location = new System.Drawing.Point(145, 210);
            this.BtnEq.Name = "BtnEq";
            this.BtnEq.Size = new System.Drawing.Size(65, 65);
            this.BtnEq.TabIndex = 14;
            this.BtnEq.Tag = "";
            this.BtnEq.Text = "=";
            this.BtnEq.UseVisualStyleBackColor = true;
            this.BtnEq.Click += new System.EventHandler(this.BtnOpr_Click);
            // 
            // Btn0
            // 
            this.Btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn0.Location = new System.Drawing.Point(74, 210);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(65, 65);
            this.Btn0.TabIndex = 13;
            this.Btn0.Tag = "";
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Digit_Click);
            // 
            // BtnPoint
            // 
            this.BtnPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnPoint.Location = new System.Drawing.Point(3, 210);
            this.BtnPoint.Name = "BtnPoint";
            this.BtnPoint.Size = new System.Drawing.Size(65, 65);
            this.BtnPoint.TabIndex = 12;
            this.BtnPoint.Tag = "";
            this.BtnPoint.Text = ".";
            this.BtnPoint.UseVisualStyleBackColor = true;
            this.BtnPoint.Click += new System.EventHandler(this.BtnPoint_Click);
            // 
            // BtnMul
            // 
            this.BtnMul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnMul.Location = new System.Drawing.Point(216, 141);
            this.BtnMul.Name = "BtnMul";
            this.BtnMul.Size = new System.Drawing.Size(65, 63);
            this.BtnMul.TabIndex = 11;
            this.BtnMul.Tag = "";
            this.BtnMul.Text = "*";
            this.BtnMul.UseVisualStyleBackColor = true;
            this.BtnMul.Click += new System.EventHandler(this.BtnOpr_Click);
            // 
            // Btn3
            // 
            this.Btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn3.Location = new System.Drawing.Point(145, 141);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(65, 63);
            this.Btn3.TabIndex = 10;
            this.Btn3.Tag = "";
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Btn2
            // 
            this.Btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn2.Location = new System.Drawing.Point(74, 141);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(65, 63);
            this.Btn2.TabIndex = 9;
            this.Btn2.Tag = "";
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Btn1
            // 
            this.Btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn1.Location = new System.Drawing.Point(3, 141);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(65, 63);
            this.Btn1.TabIndex = 8;
            this.Btn1.Tag = "";
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Digit_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnSub.Location = new System.Drawing.Point(216, 72);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(65, 63);
            this.BtnSub.TabIndex = 7;
            this.BtnSub.Tag = "";
            this.BtnSub.Text = "-";
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.Click += new System.EventHandler(this.BtnOpr_Click);
            // 
            // Btn6
            // 
            this.Btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn6.Location = new System.Drawing.Point(145, 72);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(65, 63);
            this.Btn6.TabIndex = 6;
            this.Btn6.Tag = "";
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Btn5
            // 
            this.Btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn5.Location = new System.Drawing.Point(74, 72);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(65, 63);
            this.Btn5.TabIndex = 5;
            this.Btn5.Tag = "";
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Btn4
            // 
            this.Btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn4.Location = new System.Drawing.Point(3, 72);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(65, 63);
            this.Btn4.TabIndex = 4;
            this.Btn4.Tag = "";
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Digit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAdd.Location = new System.Drawing.Point(216, 3);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(65, 63);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnOpr_Click);
            // 
            // Btn9
            // 
            this.Btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn9.Location = new System.Drawing.Point(145, 3);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(65, 63);
            this.Btn9.TabIndex = 2;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Btn8
            // 
            this.Btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn8.Location = new System.Drawing.Point(74, 3);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(65, 63);
            this.Btn8.TabIndex = 1;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Btn7
            // 
            this.Btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Btn7.Location = new System.Drawing.Point(3, 3);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(65, 63);
            this.Btn7.TabIndex = 0;
            this.Btn7.Tag = "";
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 318);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.Table.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.TableLayoutPanel Table;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnEq;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnPoint;
        private System.Windows.Forms.Button BtnMul;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
    }
}

