namespace BindingsTest
{
    partial class BindingsTest
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
            this.EdName = new System.Windows.Forms.TextBox();
            this.EdPrice = new System.Windows.Forms.TextBox();
            this.ProductList = new System.Windows.Forms.ListBox();
            this.BtnIns = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.EdSum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EdName
            // 
            this.EdName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdName.Enabled = false;
            this.EdName.Location = new System.Drawing.Point(66, 328);
            this.EdName.Name = "EdName";
            this.EdName.Size = new System.Drawing.Size(263, 20);
            this.EdName.TabIndex = 0;
            // 
            // EdPrice
            // 
            this.EdPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EdPrice.Enabled = false;
            this.EdPrice.Location = new System.Drawing.Point(335, 328);
            this.EdPrice.Name = "EdPrice";
            this.EdPrice.Size = new System.Drawing.Size(48, 20);
            this.EdPrice.TabIndex = 1;
            this.EdPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ProductList
            // 
            this.ProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductList.FormattingEnabled = true;
            this.ProductList.Location = new System.Drawing.Point(12, 12);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(545, 303);
            this.ProductList.TabIndex = 2;
            this.ProductList.SelectedValueChanged += new System.EventHandler(this.PersonList_SelectedValueChanged);
            // 
            // BtnAdd
            // 
            this.BtnIns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIns.Location = new System.Drawing.Point(401, 328);
            this.BtnIns.Name = "BtnAdd";
            this.BtnIns.Size = new System.Drawing.Size(75, 23);
            this.BtnIns.TabIndex = 3;
            this.BtnIns.Text = "Dodaj";
            this.BtnIns.UseVisualStyleBackColor = true;
            this.BtnIns.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRemove
            // 
            this.BtnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDel.Location = new System.Drawing.Point(482, 328);
            this.BtnDel.Name = "BtnRemove";
            this.BtnDel.Size = new System.Drawing.Size(75, 23);
            this.BtnDel.TabIndex = 4;
            this.BtnDel.Text = "Usuń";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // EdSum
            // 
            this.EdSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EdSum.Enabled = false;
            this.EdSum.Location = new System.Drawing.Point(12, 328);
            this.EdSum.Name = "EdSum";
            this.EdSum.ReadOnly = true;
            this.EdSum.Size = new System.Drawing.Size(48, 20);
            this.EdSum.TabIndex = 5;
            // 
            // BindingsTest
            // 
            this.AcceptButton = this.BtnIns;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 358);
            this.Controls.Add(this.EdSum);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnIns);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.EdPrice);
            this.Controls.Add(this.EdName);
            this.KeyPreview = true;
            this.Name = "BindingsTest";
            this.Text = "Bindings test ...";
            this.Load += new System.EventHandler(this.BindingsTest_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BindingsTest_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EdName;
        private System.Windows.Forms.TextBox EdPrice;
        private System.Windows.Forms.ListBox ProductList;
        private System.Windows.Forms.Button BtnIns;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.TextBox EdSum;
    }
}

