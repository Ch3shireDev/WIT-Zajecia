namespace UserFrameTestSpace
{
    partial class UserFrameTest
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
            this.Buttons = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.ScrollBox = new System.Windows.Forms.Panel();
            this.Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // Buttons
            // 
            this.Buttons.Controls.Add(this.BtnAdd);
            this.Buttons.Dock = System.Windows.Forms.DockStyle.Right;
            this.Buttons.Location = new System.Drawing.Point(516, 0);
            this.Buttons.Name = "Buttons";
            this.Buttons.Size = new System.Drawing.Size(98, 428);
            this.Buttons.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Location = new System.Drawing.Point(11, 12);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // ScrollBox
            // 
            this.ScrollBox.AutoScroll = true;
            this.ScrollBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScrollBox.Location = new System.Drawing.Point(0, 0);
            this.ScrollBox.Name = "ScrollBox";
            this.ScrollBox.Size = new System.Drawing.Size(516, 428);
            this.ScrollBox.TabIndex = 2;
            // 
            // UserFrameTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 428);
            this.Controls.Add(this.ScrollBox);
            this.Controls.Add(this.Buttons);
            this.Name = "UserFrameTest";
            this.Text = "User Control Test ...";
            this.Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Buttons;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Panel ScrollBox;
    }
}

