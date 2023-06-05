namespace BindingTest
{
    partial class BindingTestForm
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
            this.EdList = new System.Windows.Forms.ListBox();
            this.EdSum = new System.Windows.Forms.TextBox();
            this.EdPrice = new System.Windows.Forms.TextBox();
            this.EdTitle = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EdList
            // 
            this.EdList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdList.FormattingEnabled = true;
            this.EdList.Location = new System.Drawing.Point(12, 12);
            this.EdList.Name = "EdList";
            this.EdList.Size = new System.Drawing.Size(379, 199);
            this.EdList.TabIndex = 0;
            this.EdList.SelectedValueChanged += new System.EventHandler(this.EdList_SelectedValueChanged);
            // 
            // EdSum
            // 
            this.EdSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EdSum.Location = new System.Drawing.Point(12, 228);
            this.EdSum.Name = "EdSum";
            this.EdSum.ReadOnly = true;
            this.EdSum.Size = new System.Drawing.Size(48, 20);
            this.EdSum.TabIndex = 1;
            // 
            // EdPrice
            // 
            this.EdPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EdPrice.Location = new System.Drawing.Point(66, 228);
            this.EdPrice.Name = "EdPrice";
            this.EdPrice.Size = new System.Drawing.Size(48, 20);
            this.EdPrice.TabIndex = 2;
            // 
            // EdTitle
            // 
            this.EdTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdTitle.Location = new System.Drawing.Point(120, 228);
            this.EdTitle.Name = "EdTitle";
            this.EdTitle.Size = new System.Drawing.Size(190, 20);
            this.EdTitle.TabIndex = 3;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Location = new System.Drawing.Point(316, 228);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BindingTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 260);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.EdTitle);
            this.Controls.Add(this.EdPrice);
            this.Controls.Add(this.EdSum);
            this.Controls.Add(this.EdList);
            this.Name = "BindingTestForm";
            this.Text = "Binding - Shoping list";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EdList;
        private System.Windows.Forms.TextBox EdSum;
        private System.Windows.Forms.TextBox EdPrice;
        private System.Windows.Forms.TextBox EdTitle;
        private System.Windows.Forms.Button BtnAdd;
    }
}

