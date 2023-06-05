namespace BridgeTest
{
    partial class BridgeTestForm
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
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.BtnTest = new System.Windows.Forms.Button();
            this.LstLayer = new System.Windows.Forms.ListBox();
            this.CbFigure = new System.Windows.Forms.ComboBox();
            this.EdParams = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageBox
            // 
            this.ImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageBox.Location = new System.Drawing.Point(14, 12);
            this.ImageBox.Margin = new System.Windows.Forms.Padding(5);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(373, 285);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 0;
            this.ImageBox.TabStop = false;
            // 
            // BtnTest
            // 
            this.BtnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTest.Location = new System.Drawing.Point(523, 276);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(41, 23);
            this.BtnTest.TabIndex = 1;
            this.BtnTest.Text = "Test";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // LstLayer
            // 
            this.LstLayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstLayer.FormattingEnabled = true;
            this.LstLayer.Location = new System.Drawing.Point(395, 12);
            this.LstLayer.Name = "LstLayer";
            this.LstLayer.Size = new System.Drawing.Size(168, 199);
            this.LstLayer.TabIndex = 2;
            // 
            // CbFigure
            // 
            this.CbFigure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CbFigure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFigure.FormattingEnabled = true;
            this.CbFigure.Location = new System.Drawing.Point(395, 221);
            this.CbFigure.Name = "CbFigure";
            this.CbFigure.Size = new System.Drawing.Size(169, 21);
            this.CbFigure.TabIndex = 3;
            // 
            // EdParams
            // 
            this.EdParams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EdParams.Location = new System.Drawing.Point(395, 248);
            this.EdParams.Name = "EdParams";
            this.EdParams.Size = new System.Drawing.Size(168, 20);
            this.EdParams.TabIndex = 4;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Location = new System.Drawing.Point(395, 276);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(59, 23);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDel.Location = new System.Drawing.Point(457, 276);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(59, 23);
            this.BtnDel.TabIndex = 6;
            this.BtnDel.Text = "Usuń";
            this.BtnDel.UseVisualStyleBackColor = true;
            // 
            // BridgeTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 311);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.EdParams);
            this.Controls.Add(this.CbFigure);
            this.Controls.Add(this.LstLayer);
            this.Controls.Add(this.BtnTest);
            this.Controls.Add(this.ImageBox);
            this.Name = "BridgeTestForm";
            this.Text = "Bridge test ...";
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.ListBox LstLayer;
        private System.Windows.Forms.ComboBox CbFigure;
        private System.Windows.Forms.TextBox EdParams;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDel;
    }
}

