namespace UseForm
{
    partial class UseForm
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
            this.pButtons = new System.Windows.Forms.Panel();
            this.pBox = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pButtons
            // 
            this.pButtons.Controls.Add(this.btnAdd);
            this.pButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButtons.Location = new System.Drawing.Point(0, 299);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(462, 34);
            this.pButtons.TabIndex = 1;
            // 
            // pBox
            // 
            this.pBox.AutoScroll = true;
            this.pBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox.Location = new System.Drawing.Point(0, 0);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(462, 299);
            this.pBox.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // UseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 333);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.pButtons);
            this.Name = "UseForm";
            this.Text = "Kontrolki własne ...";
            this.pButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.Panel pBox;
        private System.Windows.Forms.Button btnAdd;
    }
}

