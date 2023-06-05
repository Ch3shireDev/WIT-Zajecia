namespace BindingsTest
{
    partial class BindingsTest
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
            this.EdFirstname = new System.Windows.Forms.TextBox();
            this.EdLastname = new System.Windows.Forms.TextBox();
            this.PersonList = new System.Windows.Forms.ListBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EdFirstname
            // 
            this.EdFirstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EdFirstname.Enabled = false;
            this.EdFirstname.Location = new System.Drawing.Point(12, 328);
            this.EdFirstname.Name = "EdFirstname";
            this.EdFirstname.Size = new System.Drawing.Size(100, 20);
            this.EdFirstname.TabIndex = 0;
            // 
            // EdLastname
            // 
            this.EdLastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EdLastname.Enabled = false;
            this.EdLastname.Location = new System.Drawing.Point(118, 328);
            this.EdLastname.Name = "EdLastname";
            this.EdLastname.Size = new System.Drawing.Size(132, 20);
            this.EdLastname.TabIndex = 1;
            // 
            // PersonList
            // 
            this.PersonList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PersonList.FormattingEnabled = true;
            this.PersonList.Location = new System.Drawing.Point(12, 12);
            this.PersonList.Name = "PersonList";
            this.PersonList.Size = new System.Drawing.Size(545, 303);
            this.PersonList.TabIndex = 2;
            this.PersonList.SelectedValueChanged += new System.EventHandler(this.PersonList_SelectedValueChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAdd.Location = new System.Drawing.Point(256, 328);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemove.Location = new System.Drawing.Point(482, 328);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnRemove.TabIndex = 4;
            this.BtnRemove.Text = "Usuń";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BindingsTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 358);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.PersonList);
            this.Controls.Add(this.EdLastname);
            this.Controls.Add(this.EdFirstname);
            this.Name = "BindingsTest";
            this.Text = "Bindings test ...";
            this.Load += new System.EventHandler(this.BindingsTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EdFirstname;
        private System.Windows.Forms.TextBox EdLastname;
        private System.Windows.Forms.ListBox PersonList;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnRemove;
    }
}

