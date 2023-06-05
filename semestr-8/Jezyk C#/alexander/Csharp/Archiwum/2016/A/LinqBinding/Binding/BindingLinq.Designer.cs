namespace Test006
{
    partial class BindingLinq
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
            this.foodEnergy = new System.Windows.Forms.TextBox();
            this.sumEnergy = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.Box = new System.Windows.Forms.DataGridView();
            this.foodWeight = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
            this.SuspendLayout();
            // 
            // foodName
            // 
            this.foodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foodName.Location = new System.Drawing.Point(5, 239);
            this.foodName.Name = "foodName";
            this.foodName.ReadOnly = true;
            this.foodName.Size = new System.Drawing.Size(265, 20);
            this.foodName.TabIndex = 1;
            this.foodName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edit_KeyDown);
            // 
            // foodEnergy
            // 
            this.foodEnergy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.foodEnergy.Location = new System.Drawing.Point(344, 239);
            this.foodEnergy.Name = "foodEnergy";
            this.foodEnergy.ReadOnly = true;
            this.foodEnergy.Size = new System.Drawing.Size(62, 20);
            this.foodEnergy.TabIndex = 3;
            this.foodEnergy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.foodEnergy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edit_KeyDown);
            // 
            // sumEnergy
            // 
            this.sumEnergy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sumEnergy.Location = new System.Drawing.Point(344, 268);
            this.sumEnergy.Name = "sumEnergy";
            this.sumEnergy.ReadOnly = true;
            this.sumEnergy.Size = new System.Drawing.Size(62, 20);
            this.sumEnergy.TabIndex = 4;
            this.sumEnergy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAdd.Location = new System.Drawing.Point(6, 265);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDel.Location = new System.Drawing.Point(87, 265);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 23);
            this.BtnDel.TabIndex = 6;
            this.BtnDel.Text = "Usuń";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // Box
            // 
            this.Box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Box.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Box.Location = new System.Drawing.Point(6, 12);
            this.Box.Name = "Box";
            this.Box.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Box.Size = new System.Drawing.Size(400, 221);
            this.Box.TabIndex = 0;
            this.Box.SelectionChanged += new System.EventHandler(this.Box_SelectionChanged);
            // 
            // foodWeight
            // 
            this.foodWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.foodWeight.Location = new System.Drawing.Point(276, 239);
            this.foodWeight.Name = "foodWeight";
            this.foodWeight.ReadOnly = true;
            this.foodWeight.Size = new System.Drawing.Size(62, 20);
            this.foodWeight.TabIndex = 2;
            this.foodWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFilter.Location = new System.Drawing.Point(168, 265);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 7;
            this.btnFilter.Text = "Filtruj";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnAll
            // 
            this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAll.Location = new System.Drawing.Point(249, 265);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 8;
            this.btnAll.Text = "Wszystko";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // BindingLinq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 294);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.foodWeight);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.sumEnergy);
            this.Controls.Add(this.foodEnergy);
            this.Controls.Add(this.foodName);
            this.Name = "BindingLinq";
            this.Text = "Lista zakupów";
            ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox foodName;
        private System.Windows.Forms.TextBox foodEnergy;
        private System.Windows.Forms.TextBox sumEnergy;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.DataGridView Box;
        private System.Windows.Forms.TextBox foodWeight;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnAll;
    }
}

