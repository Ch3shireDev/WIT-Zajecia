namespace Decorator
{
    partial class Form1
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
            this.BoxModel = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BoxModel
            // 
            this.BoxModel.FormattingEnabled = true;
            this.BoxModel.Location = new System.Drawing.Point(374, 12);
            this.BoxModel.Name = "BoxModel";
            this.BoxModel.Size = new System.Drawing.Size(121, 21);
            this.BoxModel.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(420, 227);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(12, 12);
            this.Info.Multiline = true;
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(356, 238);
            this.Info.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 262);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BoxModel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BoxModel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox Info;
    }
}

