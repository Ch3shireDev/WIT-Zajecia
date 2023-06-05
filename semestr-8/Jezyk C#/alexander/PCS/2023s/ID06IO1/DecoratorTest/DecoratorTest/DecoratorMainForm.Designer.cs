namespace DecoratorTest
{
    partial class DecoratorMainForm
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
            this.CbModels = new System.Windows.Forms.ComboBox();
            this.CbAdditions = new System.Windows.Forms.CheckedListBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TbResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CbModels
            // 
            this.CbModels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbModels.FormattingEnabled = true;
            this.CbModels.Location = new System.Drawing.Point(12, 12);
            this.CbModels.Name = "CbModels";
            this.CbModels.Size = new System.Drawing.Size(121, 21);
            this.CbModels.TabIndex = 0;
            // 
            // CbAdditions
            // 
            this.CbAdditions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CbAdditions.FormattingEnabled = true;
            this.CbAdditions.Location = new System.Drawing.Point(13, 39);
            this.CbAdditions.Name = "CbAdditions";
            this.CbAdditions.Size = new System.Drawing.Size(120, 184);
            this.CbAdditions.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAdd.Location = new System.Drawing.Point(13, 226);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(120, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TbResults
            // 
            this.TbResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbResults.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TbResults.Location = new System.Drawing.Point(139, 13);
            this.TbResults.Multiline = true;
            this.TbResults.Name = "TbResults";
            this.TbResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbResults.Size = new System.Drawing.Size(457, 236);
            this.TbResults.TabIndex = 3;
            this.TbResults.WordWrap = false;
            // 
            // DecoratorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 261);
            this.Controls.Add(this.TbResults);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CbAdditions);
            this.Controls.Add(this.CbModels);
            this.Name = "DecoratorMainForm";
            this.Text = "Decorator ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbModels;
        private System.Windows.Forms.CheckedListBox CbAdditions;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TbResults;
    }
}

