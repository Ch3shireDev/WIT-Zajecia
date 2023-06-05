namespace DecoratorTest
{
    partial class DecoratorTest
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
            this.ModelBox = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.InfoBox = new System.Windows.Forms.TextBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ModelBox
            // 
            this.ModelBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelBox.FormattingEnabled = true;
            this.ModelBox.Location = new System.Drawing.Point(664, 12);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(185, 21);
            this.ModelBox.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Location = new System.Drawing.Point(774, 440);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // InfoBox
            // 
            this.InfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoBox.Location = new System.Drawing.Point(12, 12);
            this.InfoBox.Multiline = true;
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InfoBox.Size = new System.Drawing.Size(646, 451);
            this.InfoBox.TabIndex = 2;
            this.InfoBox.WordWrap = false;
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.Location = new System.Drawing.Point(664, 39);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(185, 395);
            this.Panel.TabIndex = 3;
            // 
            // DecoratorTest
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 475);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.ModelBox);
            this.Name = "DecoratorTest";
            this.Text = "Decorator Car Sell";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ModelBox;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox InfoBox;
        private System.Windows.Forms.Panel Panel;
    }
}

