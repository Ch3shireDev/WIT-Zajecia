namespace Test007
{
    partial class HarmForm
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
            this.Count = new System.Windows.Forms.TextBox();
            this.List = new System.Windows.Forms.ListBox();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(12, 12);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(100, 20);
            this.Count.TabIndex = 0;
            this.Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Count.TextChanged += new System.EventHandler(this.Count_TextChanged);
            // 
            // List
            // 
            this.List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.List.FormattingEnabled = true;
            this.List.Location = new System.Drawing.Point(118, 12);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(258, 290);
            this.List.TabIndex = 1;
            this.List.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(12, 38);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtnCalc.TabIndex = 2;
            this.BtnCalc.Text = "Licz";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Enabled = false;
            this.BtnDel.Location = new System.Drawing.Point(12, 67);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 23);
            this.BtnDel.TabIndex = 3;
            this.BtnDel.Text = "&Usuń";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // HarmForm
            // 
            this.AcceptButton = this.BtnCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 311);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.List);
            this.Controls.Add(this.Count);
            this.KeyPreview = true;
            this.Name = "HarmForm";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HarmForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Button BtnDel;
    }
}

