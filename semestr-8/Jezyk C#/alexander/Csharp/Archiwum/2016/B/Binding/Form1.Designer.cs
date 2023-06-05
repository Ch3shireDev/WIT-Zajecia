namespace Bindings
{
    partial class FoodForm
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
            this.foodName = new System.Windows.Forms.TextBox();
            this.foodValue = new System.Windows.Forms.TextBox();
            this.Box = new System.Windows.Forms.ListBox();
            this.sumValue = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // foodName
            // 
            this.foodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foodName.Location = new System.Drawing.Point(5, 181);
            this.foodName.Name = "foodName";
            this.foodName.ReadOnly = true;
            this.foodName.Size = new System.Drawing.Size(350, 20);
            this.foodName.TabIndex = 1;
            // 
            // foodValue
            // 
            this.foodValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.foodValue.Location = new System.Drawing.Point(361, 181);
            this.foodValue.Name = "foodValue";
            this.foodValue.ReadOnly = true;
            this.foodValue.Size = new System.Drawing.Size(62, 20);
            this.foodValue.TabIndex = 2;
            this.foodValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.foodValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.foodValue_KeyDown);
            // 
            // Box
            // 
            this.Box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Box.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Box.FormattingEnabled = true;
            this.Box.ItemHeight = 14;
            this.Box.Location = new System.Drawing.Point(5, 10);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(418, 158);
            this.Box.TabIndex = 7;
            this.Box.SelectedIndexChanged += new System.EventHandler(this.Box_SelectedIndexChanged);
            // 
            // sumValue
            // 
            this.sumValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sumValue.Location = new System.Drawing.Point(361, 210);
            this.sumValue.Name = "sumValue";
            this.sumValue.ReadOnly = true;
            this.sumValue.Size = new System.Drawing.Size(62, 20);
            this.sumValue.TabIndex = 6;
            this.sumValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAdd.Location = new System.Drawing.Point(6, 207);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDel.Location = new System.Drawing.Point(87, 207);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 23);
            this.BtnDel.TabIndex = 5;
            this.BtnDel.Text = "Usuń";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 236);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.sumValue);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.foodValue);
            this.Controls.Add(this.foodName);
            this.KeyPreview = true;
            this.Name = "FoodForm";
            this.Text = "Lista zakupów";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FoodForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox foodName;
        private System.Windows.Forms.TextBox foodValue;
        private System.Windows.Forms.ListBox Box;
        private System.Windows.Forms.TextBox sumValue;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDel;
    }
}

