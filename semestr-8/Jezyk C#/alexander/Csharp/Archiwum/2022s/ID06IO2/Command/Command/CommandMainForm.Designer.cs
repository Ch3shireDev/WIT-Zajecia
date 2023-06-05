namespace Command
{
    partial class CommandMainForm
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
            this.LbCommands = new System.Windows.Forms.ListBox();
            this.LbTrening = new System.Windows.Forms.ListBox();
            this.BtnAddToTrening = new System.Windows.Forms.Button();
            this.BtnRemoveFromCommans = new System.Windows.Forms.Button();
            this.BtnRemoveFromTrening = new System.Windows.Forms.Button();
            this.BtnAddToCommands = new System.Windows.Forms.Button();
            this.TbTreningName = new System.Windows.Forms.TextBox();
            this.TbSportsmenName = new System.Windows.Forms.TextBox();
            this.BtnExecute = new System.Windows.Forms.Button();
            this.TbLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LbCommands
            // 
            this.LbCommands.FormattingEnabled = true;
            this.LbCommands.Location = new System.Drawing.Point(12, 12);
            this.LbCommands.Name = "LbCommands";
            this.LbCommands.Size = new System.Drawing.Size(120, 95);
            this.LbCommands.TabIndex = 0;
            this.LbCommands.SelectedIndexChanged += new System.EventHandler(this.LbCommands_SelectedIndexChanged);
            // 
            // LbTrening
            // 
            this.LbTrening.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbTrening.FormattingEnabled = true;
            this.LbTrening.Location = new System.Drawing.Point(687, 12);
            this.LbTrening.Name = "LbTrening";
            this.LbTrening.Size = new System.Drawing.Size(120, 95);
            this.LbTrening.TabIndex = 1;
            this.LbTrening.SelectedIndexChanged += new System.EventHandler(this.LbTrening_SelectedIndexChanged);
            // 
            // BtnAddToTrening
            // 
            this.BtnAddToTrening.Location = new System.Drawing.Point(138, 12);
            this.BtnAddToTrening.Name = "BtnAddToTrening";
            this.BtnAddToTrening.Size = new System.Drawing.Size(75, 23);
            this.BtnAddToTrening.TabIndex = 2;
            this.BtnAddToTrening.Text = "=>";
            this.BtnAddToTrening.UseVisualStyleBackColor = true;
            this.BtnAddToTrening.Click += new System.EventHandler(this.BtnAddToTrening_Click);
            // 
            // BtnRemoveFromCommans
            // 
            this.BtnRemoveFromCommans.Location = new System.Drawing.Point(138, 84);
            this.BtnRemoveFromCommans.Name = "BtnRemoveFromCommans";
            this.BtnRemoveFromCommans.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoveFromCommans.TabIndex = 3;
            this.BtnRemoveFromCommans.Text = "X";
            this.BtnRemoveFromCommans.UseVisualStyleBackColor = true;
            this.BtnRemoveFromCommans.Click += new System.EventHandler(this.BtnRemoveFromCommans_Click);
            // 
            // BtnRemoveFromTrening
            // 
            this.BtnRemoveFromTrening.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemoveFromTrening.Location = new System.Drawing.Point(606, 84);
            this.BtnRemoveFromTrening.Name = "BtnRemoveFromTrening";
            this.BtnRemoveFromTrening.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoveFromTrening.TabIndex = 4;
            this.BtnRemoveFromTrening.Text = "X";
            this.BtnRemoveFromTrening.UseVisualStyleBackColor = true;
            this.BtnRemoveFromTrening.Click += new System.EventHandler(this.BtnRemoveFromTrening_Click);
            // 
            // BtnAddToCommands
            // 
            this.BtnAddToCommands.Location = new System.Drawing.Point(227, 45);
            this.BtnAddToCommands.Name = "BtnAddToCommands";
            this.BtnAddToCommands.Size = new System.Drawing.Size(75, 23);
            this.BtnAddToCommands.TabIndex = 5;
            this.BtnAddToCommands.Text = "<=";
            this.BtnAddToCommands.UseVisualStyleBackColor = true;
            this.BtnAddToCommands.Click += new System.EventHandler(this.BtnAddToCommands_Click);
            // 
            // TbTreningName
            // 
            this.TbTreningName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbTreningName.Location = new System.Drawing.Point(309, 47);
            this.TbTreningName.Name = "TbTreningName";
            this.TbTreningName.Size = new System.Drawing.Size(372, 20);
            this.TbTreningName.TabIndex = 6;
            this.TbTreningName.TextChanged += new System.EventHandler(this.TbTreningName_TextChanged);
            // 
            // TbSportsmenName
            // 
            this.TbSportsmenName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbSportsmenName.Location = new System.Drawing.Point(12, 115);
            this.TbSportsmenName.Name = "TbSportsmenName";
            this.TbSportsmenName.Size = new System.Drawing.Size(714, 20);
            this.TbSportsmenName.TabIndex = 7;
            this.TbSportsmenName.TextChanged += new System.EventHandler(this.TbSportsmenName_TextChanged);
            // 
            // BtnExecute
            // 
            this.BtnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExecute.Location = new System.Drawing.Point(732, 113);
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(75, 23);
            this.BtnExecute.TabIndex = 8;
            this.BtnExecute.Text = "Execute";
            this.BtnExecute.UseVisualStyleBackColor = true;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // TbLog
            // 
            this.TbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbLog.Location = new System.Drawing.Point(12, 141);
            this.TbLog.Multiline = true;
            this.TbLog.Name = "TbLog";
            this.TbLog.Size = new System.Drawing.Size(795, 224);
            this.TbLog.TabIndex = 9;
            // 
            // CommandMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 377);
            this.Controls.Add(this.TbLog);
            this.Controls.Add(this.BtnExecute);
            this.Controls.Add(this.TbSportsmenName);
            this.Controls.Add(this.TbTreningName);
            this.Controls.Add(this.BtnAddToCommands);
            this.Controls.Add(this.BtnRemoveFromTrening);
            this.Controls.Add(this.BtnRemoveFromCommans);
            this.Controls.Add(this.BtnAddToTrening);
            this.Controls.Add(this.LbTrening);
            this.Controls.Add(this.LbCommands);
            this.Name = "CommandMainForm";
            this.Text = "Command Sportsmen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbCommands;
        private System.Windows.Forms.ListBox LbTrening;
        private System.Windows.Forms.Button BtnAddToTrening;
        private System.Windows.Forms.Button BtnRemoveFromCommans;
        private System.Windows.Forms.Button BtnRemoveFromTrening;
        private System.Windows.Forms.Button BtnAddToCommands;
        private System.Windows.Forms.TextBox TbTreningName;
        private System.Windows.Forms.TextBox TbSportsmenName;
        private System.Windows.Forms.Button BtnExecute;
        private System.Windows.Forms.TextBox TbLog;
    }
}

