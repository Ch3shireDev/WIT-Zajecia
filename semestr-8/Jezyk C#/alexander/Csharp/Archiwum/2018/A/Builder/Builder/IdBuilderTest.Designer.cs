namespace Builder
{
    partial class IdBuilderTest
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
            this.EdInfo = new System.Windows.Forms.TextBox();
            this.EdId = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnBuild = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EdInfo
            // 
            this.EdInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdInfo.Location = new System.Drawing.Point(12, 12);
            this.EdInfo.Multiline = true;
            this.EdInfo.Name = "EdInfo";
            this.EdInfo.ReadOnly = true;
            this.EdInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EdInfo.Size = new System.Drawing.Size(764, 345);
            this.EdInfo.TabIndex = 0;
            this.EdInfo.WordWrap = false;
            // 
            // EdId
            // 
            this.EdId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EdId.Location = new System.Drawing.Point(12, 375);
            this.EdId.Name = "EdId";
            this.EdId.Size = new System.Drawing.Size(100, 20);
            this.EdId.TabIndex = 1;
            this.EdId.Text = "0";
            this.EdId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EdId.TextChanged += new System.EventHandler(this.EdId_TextChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAdd.Location = new System.Drawing.Point(136, 373);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnBuild
            // 
            this.BtnBuild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnBuild.Location = new System.Drawing.Point(239, 373);
            this.BtnBuild.Name = "BtnBuild";
            this.BtnBuild.Size = new System.Drawing.Size(75, 23);
            this.BtnBuild.TabIndex = 3;
            this.BtnBuild.Text = "Buduj";
            this.BtnBuild.UseVisualStyleBackColor = true;
            this.BtnBuild.Click += new System.EventHandler(this.BtnBuild_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnClear.Location = new System.Drawing.Point(340, 373);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "Wyczyść";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // IdBuilderTest
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 407);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnBuild);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.EdId);
            this.Controls.Add(this.EdInfo);
            this.Name = "IdBuilderTest";
            this.Text = "Id builder ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EdInfo;
        private System.Windows.Forms.TextBox EdId;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnBuild;
        private System.Windows.Forms.Button BtnClear;
    }
}

