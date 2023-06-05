namespace Builder
{
    partial class BuilderTest
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
            this.Log = new System.Windows.Forms.TextBox();
            this.EdIdValue = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnBuild = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Log
            // 
            this.Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Log.Location = new System.Drawing.Point(12, 12);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Log.Size = new System.Drawing.Size(902, 502);
            this.Log.TabIndex = 0;
            // 
            // EdIdValue
            // 
            this.EdIdValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EdIdValue.Location = new System.Drawing.Point(920, 12);
            this.EdIdValue.Name = "EdIdValue";
            this.EdIdValue.Size = new System.Drawing.Size(100, 20);
            this.EdIdValue.TabIndex = 1;
            this.EdIdValue.Text = "0";
            this.EdIdValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EdIdValue.TextChanged += new System.EventHandler(this.EdIdValue_TextChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Location = new System.Drawing.Point(945, 38);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnBuild
            // 
            this.BtnBuild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuild.Location = new System.Drawing.Point(945, 67);
            this.BtnBuild.Name = "BtnBuild";
            this.BtnBuild.Size = new System.Drawing.Size(75, 23);
            this.BtnBuild.TabIndex = 3;
            this.BtnBuild.Text = "Buduj";
            this.BtnBuild.UseVisualStyleBackColor = true;
            this.BtnBuild.Click += new System.EventHandler(this.BtnBuild_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.Location = new System.Drawing.Point(945, 97);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "Wyczyść";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BuilderTest
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 526);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnBuild);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.EdIdValue);
            this.Controls.Add(this.Log);
            this.Name = "BuilderTest";
            this.Text = "Id Builder Test ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.TextBox EdIdValue;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnBuild;
        private System.Windows.Forms.Button BtnClear;
    }
}

