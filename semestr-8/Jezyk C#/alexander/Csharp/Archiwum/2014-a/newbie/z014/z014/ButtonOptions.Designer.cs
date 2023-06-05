namespace z014
{
    partial class ButtonOptions
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
            this.LName = new System.Windows.Forms.Label();
            this.EName = new System.Windows.Forms.TextBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.BtnColor = new System.Windows.Forms.Button();
            this.BtnFont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(12, 9);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(40, 13);
            this.LName.TabIndex = 0;
            this.LName.Text = "Nazwa";
            // 
            // EName
            // 
            this.EName.Location = new System.Drawing.Point(58, 6);
            this.EName.Name = "EName";
            this.EName.Size = new System.Drawing.Size(194, 20);
            this.EName.TabIndex = 1;
            this.EName.Text = "Nowy";
            // 
            // BtnOk
            // 
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.Location = new System.Drawing.Point(12, 107);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 2;
            this.BtnOk.Text = "Akceptuj";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BtnRemove.Location = new System.Drawing.Point(96, 107);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnRemove.TabIndex = 4;
            this.BtnRemove.Text = "Usuń";
            this.BtnRemove.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(177, 107);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Rezygnuj";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnColor
            // 
            this.BtnColor.Location = new System.Drawing.Point(15, 46);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(75, 23);
            this.BtnColor.TabIndex = 6;
            this.BtnColor.Text = "Color";
            this.BtnColor.UseVisualStyleBackColor = true;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // BtnFont
            // 
            this.BtnFont.Location = new System.Drawing.Point(177, 46);
            this.BtnFont.Name = "BtnFont";
            this.BtnFont.Size = new System.Drawing.Size(75, 23);
            this.BtnFont.TabIndex = 7;
            this.BtnFont.Text = "Font";
            this.BtnFont.UseVisualStyleBackColor = true;
            this.BtnFont.Click += new System.EventHandler(this.BtnFont_Click);
            // 
            // ButtonOptions
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 142);
            this.Controls.Add(this.BtnFont);
            this.Controls.Add(this.BtnColor);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.EName);
            this.Controls.Add(this.LName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ButtonOptions";
            this.Text = "Właściwości przycisku ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LName;
        public System.Windows.Forms.TextBox EName;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.Button BtnColor;
        private System.Windows.Forms.Button BtnFont;
    }
}