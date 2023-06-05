namespace Mandelbroat
{
    partial class ServerListForm
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
            this.LstServers = new System.Windows.Forms.ListBox();
            this.LbHost = new System.Windows.Forms.Label();
            this.EdHost = new System.Windows.Forms.TextBox();
            this.EdPort = new System.Windows.Forms.TextBox();
            this.LbPort = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstServers
            // 
            this.LstServers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstServers.FormattingEnabled = true;
            this.LstServers.Location = new System.Drawing.Point(12, 12);
            this.LstServers.Name = "LstServers";
            this.LstServers.Size = new System.Drawing.Size(468, 199);
            this.LstServers.TabIndex = 0;
            this.LstServers.SelectedIndexChanged += new System.EventHandler(this.LstServers_SelectedIndexChanged);
            // 
            // LbHost
            // 
            this.LbHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LbHost.AutoSize = true;
            this.LbHost.Location = new System.Drawing.Point(7, 218);
            this.LbHost.Name = "LbHost";
            this.LbHost.Size = new System.Drawing.Size(29, 13);
            this.LbHost.TabIndex = 1;
            this.LbHost.Text = "&Host";
            // 
            // EdHost
            // 
            this.EdHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EdHost.Location = new System.Drawing.Point(10, 234);
            this.EdHost.Name = "EdHost";
            this.EdHost.Size = new System.Drawing.Size(116, 20);
            this.EdHost.TabIndex = 2;
            // 
            // EdPort
            // 
            this.EdPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EdPort.Location = new System.Drawing.Point(138, 234);
            this.EdPort.Name = "EdPort";
            this.EdPort.Size = new System.Drawing.Size(100, 20);
            this.EdPort.TabIndex = 4;
            this.EdPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LbPort
            // 
            this.LbPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LbPort.AutoSize = true;
            this.LbPort.Location = new System.Drawing.Point(135, 218);
            this.LbPort.Name = "LbPort";
            this.LbPort.Size = new System.Drawing.Size(26, 13);
            this.LbPort.TabIndex = 3;
            this.LbPort.Text = "&Port";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Location = new System.Drawing.Point(324, 231);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "&Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemove.Location = new System.Drawing.Point(405, 231);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnRemove.TabIndex = 6;
            this.BtnRemove.Text = "&Remove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // ServerListForm
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 267);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.EdPort);
            this.Controls.Add(this.LbPort);
            this.Controls.Add(this.EdHost);
            this.Controls.Add(this.LbHost);
            this.Controls.Add(this.LstServers);
            this.Name = "ServerListForm";
            this.Text = "ServerListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstServers;
        private System.Windows.Forms.Label LbHost;
        private System.Windows.Forms.TextBox EdHost;
        private System.Windows.Forms.TextBox EdPort;
        private System.Windows.Forms.Label LbPort;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnRemove;
    }
}