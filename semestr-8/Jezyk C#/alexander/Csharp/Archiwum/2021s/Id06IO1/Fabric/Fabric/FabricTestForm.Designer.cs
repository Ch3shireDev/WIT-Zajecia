namespace Fabric
{
    partial class FabricTestForm
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
            this.CbKinds = new System.Windows.Forms.ComboBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CbKinds
            // 
            this.CbKinds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbKinds.FormattingEnabled = true;
            this.CbKinds.Location = new System.Drawing.Point(12, 12);
            this.CbKinds.Name = "CbKinds";
            this.CbKinds.Size = new System.Drawing.Size(121, 21);
            this.CbKinds.TabIndex = 0;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(139, 12);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Location = new System.Drawing.Point(562, 10);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtLog
            // 
            this.TxtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtLog.Location = new System.Drawing.Point(12, 39);
            this.TxtLog.Multiline = true;
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.Size = new System.Drawing.Size(625, 250);
            this.TxtLog.TabIndex = 3;
            // 
            // FabricTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 301);
            this.Controls.Add(this.TxtLog);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.CbKinds);
            this.Name = "FabricTestForm";
            this.Text = "Fabric of Animal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbKinds;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtLog;
    }
}

