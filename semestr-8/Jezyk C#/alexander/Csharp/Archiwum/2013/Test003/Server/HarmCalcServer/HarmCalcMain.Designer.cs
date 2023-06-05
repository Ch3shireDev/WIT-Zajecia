namespace HarmCalcThread
{
    partial class HarmCalcMain
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
            this.Box = new System.Windows.Forms.Panel();
            this.EResult = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.EPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Box.AutoScroll = true;
            this.Box.Location = new System.Drawing.Point(12, 39);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(181, 211);
            this.Box.TabIndex = 2;
            // 
            // EResult
            // 
            this.EResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EResult.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EResult.Location = new System.Drawing.Point(199, 39);
            this.EResult.Multiline = true;
            this.EResult.Name = "EResult";
            this.EResult.ReadOnly = true;
            this.EResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EResult.Size = new System.Drawing.Size(373, 211);
            this.EResult.TabIndex = 3;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(55, 10);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(84, 22);
            this.BtnConnect.TabIndex = 13;
            this.BtnConnect.Text = "Połącz";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // EPort
            // 
            this.EPort.Location = new System.Drawing.Point(13, 12);
            this.EPort.Name = "EPort";
            this.EPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EPort.Size = new System.Drawing.Size(36, 20);
            this.EPort.TabIndex = 12;
            this.EPort.Text = "8083";
            this.EPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HarmCalcMain
            // 
            this.AcceptButton = this.BtnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.EPort);
            this.Controls.Add(this.EResult);
            this.Controls.Add(this.Box);
            this.Name = "HarmCalcMain";
            this.Text = "Ciąg harmoniczny server ...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HarmCalcMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EResult;
        public System.Windows.Forms.Panel Box;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.TextBox EPort;
    }
}

