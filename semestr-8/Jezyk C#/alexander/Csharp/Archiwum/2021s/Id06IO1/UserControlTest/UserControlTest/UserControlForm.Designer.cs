namespace UserControlTest
{
    partial class UserControlForm
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
            this.PnButtons = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.PnList = new System.Windows.Forms.Panel();
            this.PnButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnButtons
            // 
            this.PnButtons.Controls.Add(this.BtnAdd);
            this.PnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnButtons.Location = new System.Drawing.Point(0, 216);
            this.PnButtons.Name = "PnButtons";
            this.PnButtons.Size = new System.Drawing.Size(494, 46);
            this.PnButtons.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 11);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // PnList
            // 
            this.PnList.AutoScroll = true;
            this.PnList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnList.Location = new System.Drawing.Point(0, 0);
            this.PnList.Name = "PnList";
            this.PnList.Padding = new System.Windows.Forms.Padding(4);
            this.PnList.Size = new System.Drawing.Size(494, 216);
            this.PnList.TabIndex = 2;
            // 
            // UserControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 262);
            this.Controls.Add(this.PnList);
            this.Controls.Add(this.PnButtons);
            this.Name = "UserControlForm";
            this.Text = "Form1";
            this.PnButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnButtons;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Panel PnList;
    }
}

