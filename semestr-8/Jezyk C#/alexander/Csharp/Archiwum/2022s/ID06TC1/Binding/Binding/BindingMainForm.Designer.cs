namespace Binding
{
    partial class BindingMainForm
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
            this.LbBuyList = new System.Windows.Forms.ListBox();
            this.TbSumAmount = new System.Windows.Forms.TextBox();
            this.TbAmount = new System.Windows.Forms.TextBox();
            this.TbTitle = new System.Windows.Forms.TextBox();
            this.BtnAppend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbBuyList
            // 
            this.LbBuyList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbBuyList.FormattingEnabled = true;
            this.LbBuyList.Location = new System.Drawing.Point(12, 12);
            this.LbBuyList.Name = "LbBuyList";
            this.LbBuyList.Size = new System.Drawing.Size(574, 251);
            this.LbBuyList.TabIndex = 0;
            this.LbBuyList.SelectedValueChanged += new System.EventHandler(this.LbBuyList_SelectedValueChanged);
            // 
            // TbSumAmount
            // 
            this.TbSumAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TbSumAmount.Location = new System.Drawing.Point(12, 277);
            this.TbSumAmount.Name = "TbSumAmount";
            this.TbSumAmount.ReadOnly = true;
            this.TbSumAmount.Size = new System.Drawing.Size(100, 20);
            this.TbSumAmount.TabIndex = 1;
            // 
            // TbAmount
            // 
            this.TbAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TbAmount.Location = new System.Drawing.Point(12, 305);
            this.TbAmount.Name = "TbAmount";
            this.TbAmount.Size = new System.Drawing.Size(100, 20);
            this.TbAmount.TabIndex = 2;
            // 
            // TbTitle
            // 
            this.TbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbTitle.Location = new System.Drawing.Point(118, 305);
            this.TbTitle.Name = "TbTitle";
            this.TbTitle.Size = new System.Drawing.Size(387, 20);
            this.TbTitle.TabIndex = 3;
            // 
            // BtnAppend
            // 
            this.BtnAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAppend.Location = new System.Drawing.Point(511, 303);
            this.BtnAppend.Name = "BtnAppend";
            this.BtnAppend.Size = new System.Drawing.Size(75, 23);
            this.BtnAppend.TabIndex = 4;
            this.BtnAppend.Text = "Dodaj";
            this.BtnAppend.UseVisualStyleBackColor = true;
            this.BtnAppend.Click += new System.EventHandler(this.BtnAppend_Click);
            // 
            // BindingMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 337);
            this.Controls.Add(this.BtnAppend);
            this.Controls.Add(this.TbTitle);
            this.Controls.Add(this.TbAmount);
            this.Controls.Add(this.TbSumAmount);
            this.Controls.Add(this.LbBuyList);
            this.Name = "BindingMainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbBuyList;
        private System.Windows.Forms.TextBox TbSumAmount;
        private System.Windows.Forms.TextBox TbAmount;
        private System.Windows.Forms.TextBox TbTitle;
        private System.Windows.Forms.Button BtnAppend;
    }
}

