namespace BindingTest
{
    partial class BindingTest
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
            this.EdLastnameA = new System.Windows.Forms.TextBox();
            this.EdFirstnameA = new System.Windows.Forms.TextBox();
            this.EdLastnameB = new System.Windows.Forms.TextBox();
            this.EdFirstnameB = new System.Windows.Forms.TextBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // EdLastnameA
            // 
            this.EdLastnameA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdLastnameA.Location = new System.Drawing.Point(106, 221);
            this.EdLastnameA.Name = "EdLastnameA";
            this.EdLastnameA.Size = new System.Drawing.Size(424, 20);
            this.EdLastnameA.TabIndex = 3;
            // 
            // EdFirstnameA
            // 
            this.EdFirstnameA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EdFirstnameA.Location = new System.Drawing.Point(12, 221);
            this.EdFirstnameA.Name = "EdFirstnameA";
            this.EdFirstnameA.Size = new System.Drawing.Size(88, 20);
            this.EdFirstnameA.TabIndex = 2;
            // 
            // EdLastnameB
            // 
            this.EdLastnameB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdLastnameB.Location = new System.Drawing.Point(106, 247);
            this.EdLastnameB.Name = "EdLastnameB";
            this.EdLastnameB.Size = new System.Drawing.Size(424, 20);
            this.EdLastnameB.TabIndex = 5;
            // 
            // EdFirstnameB
            // 
            this.EdFirstnameB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EdFirstnameB.Location = new System.Drawing.Point(12, 247);
            this.EdFirstnameB.Name = "EdFirstnameB";
            this.EdFirstnameB.Size = new System.Drawing.Size(88, 20);
            this.EdFirstnameB.TabIndex = 4;
            // 
            // ListBox
            // 
            this.ListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(12, 12);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(518, 199);
            this.ListBox.TabIndex = 6;
            // 
            // BindingTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 273);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.EdLastnameB);
            this.Controls.Add(this.EdFirstnameB);
            this.Controls.Add(this.EdLastnameA);
            this.Controls.Add(this.EdFirstnameA);
            this.Name = "BindingTest";
            this.Text = "Test bindowania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EdLastnameA;
        private System.Windows.Forms.TextBox EdFirstnameA;
        private System.Windows.Forms.TextBox EdLastnameB;
        private System.Windows.Forms.TextBox EdFirstnameB;
        private System.Windows.Forms.ListBox ListBox;
    }
}

