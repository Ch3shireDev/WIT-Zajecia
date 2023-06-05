namespace Decorator
{
    partial class DecoratorForm
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
            this.ClbDecorators = new System.Windows.Forms.CheckedListBox();
            this.CbCars = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LbPriceList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ClbDecorators
            // 
            this.ClbDecorators.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClbDecorators.FormattingEnabled = true;
            this.ClbDecorators.Location = new System.Drawing.Point(362, 12);
            this.ClbDecorators.Name = "ClbDecorators";
            this.ClbDecorators.Size = new System.Drawing.Size(146, 94);
            this.ClbDecorators.TabIndex = 0;
            // 
            // CbCars
            // 
            this.CbCars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCars.FormattingEnabled = true;
            this.CbCars.Location = new System.Drawing.Point(13, 12);
            this.CbCars.Name = "CbCars";
            this.CbCars.Size = new System.Drawing.Size(147, 21);
            this.CbCars.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 84);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LbPriceList
            // 
            this.LbPriceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbPriceList.FormattingEnabled = true;
            this.LbPriceList.Location = new System.Drawing.Point(13, 113);
            this.LbPriceList.Name = "LbPriceList";
            this.LbPriceList.Size = new System.Drawing.Size(495, 251);
            this.LbPriceList.TabIndex = 3;
            // 
            // DecoratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 374);
            this.Controls.Add(this.LbPriceList);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CbCars);
            this.Controls.Add(this.ClbDecorators);
            this.Name = "DecoratorForm";
            this.Text = "Car Dekorator ...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ClbDecorators;
        private System.Windows.Forms.ComboBox CbCars;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ListBox LbPriceList;
    }
}

