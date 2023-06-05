namespace CarDecorator
{
    partial class CarDecoratorMain
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
            this.PriceList = new System.Windows.Forms.ListBox();
            this.Kind = new System.Windows.Forms.ComboBox();
            this.Decorations = new System.Windows.Forms.CheckedListBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PriceList
            // 
            this.PriceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceList.FormattingEnabled = true;
            this.PriceList.Location = new System.Drawing.Point(12, 12);
            this.PriceList.Name = "PriceList";
            this.PriceList.Size = new System.Drawing.Size(385, 303);
            this.PriceList.TabIndex = 0;
            // 
            // Kind
            // 
            this.Kind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Kind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Kind.FormattingEnabled = true;
            this.Kind.Location = new System.Drawing.Point(403, 12);
            this.Kind.Name = "Kind";
            this.Kind.Size = new System.Drawing.Size(121, 21);
            this.Kind.TabIndex = 1;
            // 
            // Decorations
            // 
            this.Decorations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Decorations.FormattingEnabled = true;
            this.Decorations.Location = new System.Drawing.Point(403, 39);
            this.Decorations.Name = "Decorations";
            this.Decorations.Size = new System.Drawing.Size(120, 109);
            this.Decorations.TabIndex = 2;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Location = new System.Drawing.Point(403, 151);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // CarDecoratorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 323);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.Decorations);
            this.Controls.Add(this.Kind);
            this.Controls.Add(this.PriceList);
            this.Name = "CarDecoratorMain";
            this.Text = "Car Decorators Example ...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox PriceList;
        private System.Windows.Forms.ComboBox Kind;
        private System.Windows.Forms.CheckedListBox Decorations;
        private System.Windows.Forms.Button BtnAdd;
    }
}

