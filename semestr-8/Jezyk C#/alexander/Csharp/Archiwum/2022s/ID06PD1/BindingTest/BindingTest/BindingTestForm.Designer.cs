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
            this.LbProducts = new System.Windows.Forms.ListBox();
            this.TbPrice = new System.Windows.Forms.TextBox();
            this.TbTitle = new System.Windows.Forms.TextBox();
            this.TbTotal = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbProducts
            // 
            this.LbProducts.FormattingEnabled = true;
            this.LbProducts.Location = new System.Drawing.Point(12, 12);
            this.LbProducts.Name = "LbProducts";
            this.LbProducts.Size = new System.Drawing.Size(505, 433);
            this.LbProducts.TabIndex = 0;
            this.LbProducts.SelectedValueChanged += new System.EventHandler(this.LbProducts_SelectedValueChanged);
            // 
            // TbPrice
            // 
            this.TbPrice.Location = new System.Drawing.Point(12, 486);
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.Size = new System.Drawing.Size(76, 20);
            this.TbPrice.TabIndex = 1;
            this.TbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TbTitle
            // 
            this.TbTitle.Location = new System.Drawing.Point(94, 486);
            this.TbTitle.Name = "TbTitle";
            this.TbTitle.Size = new System.Drawing.Size(342, 20);
            this.TbTitle.TabIndex = 2;
            // 
            // TbTotal
            // 
            this.TbTotal.Location = new System.Drawing.Point(12, 460);
            this.TbTotal.Name = "TbTotal";
            this.TbTotal.ReadOnly = true;
            this.TbTotal.Size = new System.Drawing.Size(76, 20);
            this.TbTotal.TabIndex = 3;
            this.TbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbTotal.WordWrap = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(442, 484);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Append";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BindingTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 518);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TbTotal);
            this.Controls.Add(this.TbTitle);
            this.Controls.Add(this.TbPrice);
            this.Controls.Add(this.LbProducts);
            this.Name = "BindingTestForm";
            this.Text = "BindingTestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbProducts;
        private System.Windows.Forms.TextBox TbPrice;
        private System.Windows.Forms.TextBox TbTitle;
        private System.Windows.Forms.TextBox TbTotal;
        private System.Windows.Forms.Button BtnAdd;
    }
}

