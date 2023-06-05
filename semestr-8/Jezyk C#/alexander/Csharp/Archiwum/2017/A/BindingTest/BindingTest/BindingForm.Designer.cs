namespace BindingTest
{
    partial class BindingForm
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
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.sumValue = new System.Windows.Forms.TextBox();
            this.Box = new System.Windows.Forms.ListBox();
            this.foodValue = new System.Windows.Forms.TextBox();
            this.foodName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnDel
            // 
            this.BtnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDel.Location = new System.Drawing.Point(87, 181);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 23);
            this.BtnDel.TabIndex = 11;
            this.BtnDel.Text = "Usuń";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAdd.Location = new System.Drawing.Point(6, 181);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // sumValue
            // 
            this.sumValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sumValue.Location = new System.Drawing.Point(318, 184);
            this.sumValue.Name = "sumValue";
            this.sumValue.ReadOnly = true;
            this.sumValue.Size = new System.Drawing.Size(62, 20);
            this.sumValue.TabIndex = 12;
            this.sumValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Box
            // 
            this.Box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Box.FormattingEnabled = true;
            this.Box.Location = new System.Drawing.Point(5, 8);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(375, 134);
            this.Box.TabIndex = 13;
            this.Box.SelectedIndexChanged += new System.EventHandler(this.Box_SelectedIndexChanged);
            // 
            // foodValue
            // 
            this.foodValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.foodValue.Location = new System.Drawing.Point(318, 155);
            this.foodValue.Name = "foodValue";
            this.foodValue.ReadOnly = true;
            this.foodValue.Size = new System.Drawing.Size(62, 20);
            this.foodValue.TabIndex = 9;
            this.foodValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // foodName
            // 
            this.foodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foodName.Location = new System.Drawing.Point(5, 155);
            this.foodName.Name = "foodName";
            this.foodName.ReadOnly = true;
            this.foodName.Size = new System.Drawing.Size(307, 20);
            this.foodName.TabIndex = 8;
            this.foodName.TextChanged += new System.EventHandler(this.foodName_TextChanged);
            // 
            // BindingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 212);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.sumValue);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.foodValue);
            this.Controls.Add(this.foodName);
            this.Name = "BindingForm";
            this.Text = "Lista zakupów ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox sumValue;
        private System.Windows.Forms.ListBox Box;
        private System.Windows.Forms.TextBox foodValue;
        private System.Windows.Forms.TextBox foodName;
    }
}

