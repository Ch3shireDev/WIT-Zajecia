namespace Strategy
{
    partial class SportsmenCommandStrategyMainForm
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
            this.BtnRemoveFromCommands = new System.Windows.Forms.Button();
            this.BtnAddToCommands = new System.Windows.Forms.Button();
            this.TbTreningName = new System.Windows.Forms.TextBox();
            this.BtnRemoveFromTrening = new System.Windows.Forms.Button();
            this.TbSportsmenName = new System.Windows.Forms.TextBox();
            this.BtnExecute = new System.Windows.Forms.Button();
            this.TbLog = new System.Windows.Forms.TextBox();
            this.CbStrategyRun = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LbCommands
            // 
            this.LbCommands.FormattingEnabled = true;
            this.LbCommands.Location = new System.Drawing.Point(12, 12);
            this.LbCommands.Name = "LbCommands";
            this.LbCommands.Size = new System.Drawing.Size(120, 134);
            this.LbCommands.TabIndex = 0;
            // 
            // LbTrening
            // 
            this.LbTrening.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbTrening.FormattingEnabled = true;
            this.LbTrening.Location = new System.Drawing.Point(589, 12);
            this.LbTrening.Name = "LbTrening";
            this.LbTrening.Size = new System.Drawing.Size(120, 134);
            this.LbTrening.TabIndex = 1;
            // 
            // BtnAddToTrening
            // 
            this.BtnAddToTrening.Location = new System.Drawing.Point(138, 12);
            this.BtnAddToTrening.Name = "BtnAddToTrening";
            this.BtnAddToTrening.Size = new System.Drawing.Size(75, 23);
            this.BtnAddToTrening.TabIndex = 2;
            this.BtnAddToTrening.Text = "=>";
            this.BtnAddToTrening.UseVisualStyleBackColor = true;
            // 
            // BtnRemoveFromCommands
            // 
            this.BtnRemoveFromCommands.Location = new System.Drawing.Point(138, 123);
            this.BtnRemoveFromCommands.Name = "BtnRemoveFromCommands";
            this.BtnRemoveFromCommands.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoveFromCommands.TabIndex = 3;
            this.BtnRemoveFromCommands.Text = "X";
            this.BtnRemoveFromCommands.UseVisualStyleBackColor = true;
            // 
            // BtnAddToCommands
            // 
            this.BtnAddToCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddToCommands.Location = new System.Drawing.Point(235, 47);
            this.BtnAddToCommands.Name = "BtnAddToCommands";
            this.BtnAddToCommands.Size = new System.Drawing.Size(75, 23);
            this.BtnAddToCommands.TabIndex = 4;
            this.BtnAddToCommands.Text = "<=";
            this.BtnAddToCommands.UseVisualStyleBackColor = true;
            // 
            // TbTreningName
            // 
            this.TbTreningName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbTreningName.Location = new System.Drawing.Point(316, 49);
            this.TbTreningName.Name = "TbTreningName";
            this.TbTreningName.Size = new System.Drawing.Size(267, 20);
            this.TbTreningName.TabIndex = 5;
            // 
            // BtnRemoveFromTrening
            // 
            this.BtnRemoveFromTrening.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemoveFromTrening.Location = new System.Drawing.Point(508, 123);
            this.BtnRemoveFromTrening.Name = "BtnRemoveFromTrening";
            this.BtnRemoveFromTrening.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoveFromTrening.TabIndex = 6;
            this.BtnRemoveFromTrening.Text = "X";
            this.BtnRemoveFromTrening.UseVisualStyleBackColor = true;
            // 
            // TbSportsmenName
            // 
            this.TbSportsmenName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbSportsmenName.Location = new System.Drawing.Point(12, 179);
            this.TbSportsmenName.Name = "TbSportsmenName";
            this.TbSportsmenName.Size = new System.Drawing.Size(616, 20);
            this.TbSportsmenName.TabIndex = 7;
            // 
            // BtnExecute
            // 
            this.BtnExecute.Location = new System.Drawing.Point(634, 177);
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(75, 23);
            this.BtnExecute.TabIndex = 8;
            this.BtnExecute.Text = "Execute";
            this.BtnExecute.UseVisualStyleBackColor = true;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // TbLog
            // 
            this.TbLog.Location = new System.Drawing.Point(12, 206);
            this.TbLog.Multiline = true;
            this.TbLog.Name = "TbLog";
            this.TbLog.Size = new System.Drawing.Size(697, 180);
            this.TbLog.TabIndex = 9;
            // 
            // CbStrategyRun
            // 
            this.CbStrategyRun.FormattingEnabled = true;
            this.CbStrategyRun.Location = new System.Drawing.Point(12, 152);
            this.CbStrategyRun.Name = "CbStrategyRun";
            this.CbStrategyRun.Size = new System.Drawing.Size(121, 21);
            this.CbStrategyRun.TabIndex = 10;
            // 
            // SportsmenCommandStrategyMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 398);
            this.Controls.Add(this.CbStrategyRun);
            this.Controls.Add(this.TbLog);
            this.Controls.Add(this.BtnExecute);
            this.Controls.Add(this.TbSportsmenName);
            this.Controls.Add(this.BtnRemoveFromTrening);
            this.Controls.Add(this.TbTreningName);
            this.Controls.Add(this.BtnAddToCommands);
            this.Controls.Add(this.BtnRemoveFromCommands);
            this.Controls.Add(this.BtnAddToTrening);
            this.Controls.Add(this.LbTrening);
            this.Controls.Add(this.LbCommands);
            this.Name = "SportsmenCommandStrategyMainForm";
            this.Text = "Sportsmen Command ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbCommands;
        private System.Windows.Forms.ListBox LbTrening;
        private System.Windows.Forms.Button BtnAddToTrening;
        private System.Windows.Forms.Button BtnRemoveFromCommands;
        private System.Windows.Forms.Button BtnAddToCommands;
        private System.Windows.Forms.TextBox TbTreningName;
        private System.Windows.Forms.Button BtnRemoveFromTrening;
        private System.Windows.Forms.TextBox TbSportsmenName;
        private System.Windows.Forms.Button BtnExecute;
        private System.Windows.Forms.TextBox TbLog;
        private System.Windows.Forms.ComboBox CbStrategyRun;
    }
}

