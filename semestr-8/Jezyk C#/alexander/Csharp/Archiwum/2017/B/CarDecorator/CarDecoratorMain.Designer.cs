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
            this.List = new System.Windows.Forms.ListBox();
            this.Kind = new System.Windows.Forms.ComboBox();
            this.Decorations = new System.Windows.Forms.CheckedListBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // List
            // 
            this.List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.List.FormattingEnabled = true;
            this.List.Location = new System.Drawing.Point(12, 12);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(323, 290);
            this.List.TabIndex = 0;
            // 
            // Kind
            // 
            this.Kind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Kind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Kind.FormattingEnabled = true;
            this.Kind.Location = new System.Drawing.Point(341, 12);
            this.Kind.Name = "Kind";
            this.Kind.Size = new System.Drawing.Size(189, 21);
            this.Kind.TabIndex = 1;
            // 
            // Decorations
            // 
            this.Decorations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Decorations.FormattingEnabled = true;
            this.Decorations.Location = new System.Drawing.Point(341, 39);
            this.Decorations.Name = "Decorations";
            this.Decorations.Size = new System.Drawing.Size(189, 199);
            this.Decorations.TabIndex = 2;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Location = new System.Drawing.Point(341, 252);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "&Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnModify
            // 
            this.BtnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModify.Location = new System.Drawing.Point(455, 252);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(75, 23);
            this.BtnModify.TabIndex = 4;
            this.BtnModify.Text = "&Modify";
            this.BtnModify.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(341, 281);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "&Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // CarDecoratorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 314);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.Decorations);
            this.Controls.Add(this.Kind);
            this.Controls.Add(this.List);
            this.Name = "CarDecoratorMain";
            this.Text = "Car Decorator Test ...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.ComboBox Kind;
        private System.Windows.Forms.CheckedListBox Decorations;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BtnDelete;
    }
}

