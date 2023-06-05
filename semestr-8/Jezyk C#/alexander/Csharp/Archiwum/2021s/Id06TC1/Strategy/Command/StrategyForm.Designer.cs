namespace Command
{
    partial class StrategyForm
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
            this.lbCommands = new System.Windows.Forms.ListBox();
            this.lbTrening = new System.Windows.Forms.ListBox();
            this.btnAppendTrenig = new System.Windows.Forms.Button();
            this.txtTreningName = new System.Windows.Forms.TextBox();
            this.btnAppendCommand = new System.Windows.Forms.Button();
            this.txtSportsmenName = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.cbRun = new System.Windows.Forms.ComboBox();
            this.cbJump = new System.Windows.Forms.ComboBox();
            this.cbSwim = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbCommands
            // 
            this.lbCommands.FormattingEnabled = true;
            this.lbCommands.Location = new System.Drawing.Point(12, 12);
            this.lbCommands.Name = "lbCommands";
            this.lbCommands.Size = new System.Drawing.Size(120, 108);
            this.lbCommands.TabIndex = 0;
            // 
            // lbTrening
            // 
            this.lbTrening.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTrening.FormattingEnabled = true;
            this.lbTrening.Location = new System.Drawing.Point(557, 12);
            this.lbTrening.Name = "lbTrening";
            this.lbTrening.Size = new System.Drawing.Size(120, 108);
            this.lbTrening.TabIndex = 1;
            // 
            // btnAppendTrenig
            // 
            this.btnAppendTrenig.Location = new System.Drawing.Point(138, 12);
            this.btnAppendTrenig.Name = "btnAppendTrenig";
            this.btnAppendTrenig.Size = new System.Drawing.Size(75, 23);
            this.btnAppendTrenig.TabIndex = 2;
            this.btnAppendTrenig.Text = "=>";
            this.btnAppendTrenig.UseVisualStyleBackColor = true;
            this.btnAppendTrenig.Click += new System.EventHandler(this.btnAppendTrenig_Click);
            // 
            // txtTreningName
            // 
            this.txtTreningName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTreningName.Location = new System.Drawing.Point(451, 44);
            this.txtTreningName.Name = "txtTreningName";
            this.txtTreningName.Size = new System.Drawing.Size(100, 20);
            this.txtTreningName.TabIndex = 3;
            // 
            // btnAppendCommand
            // 
            this.btnAppendCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppendCommand.Location = new System.Drawing.Point(370, 42);
            this.btnAppendCommand.Name = "btnAppendCommand";
            this.btnAppendCommand.Size = new System.Drawing.Size(75, 23);
            this.btnAppendCommand.TabIndex = 4;
            this.btnAppendCommand.Text = "<=";
            this.btnAppendCommand.UseVisualStyleBackColor = true;
            this.btnAppendCommand.Click += new System.EventHandler(this.btnAppendCommand_Click);
            // 
            // txtSportsmenName
            // 
            this.txtSportsmenName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSportsmenName.Location = new System.Drawing.Point(392, 128);
            this.txtSportsmenName.Name = "txtSportsmenName";
            this.txtSportsmenName.Size = new System.Drawing.Size(204, 20);
            this.txtSportsmenName.TabIndex = 5;
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Location = new System.Drawing.Point(602, 126);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 6;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(12, 154);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(665, 96);
            this.txtLog.TabIndex = 7;
            // 
            // cbRun
            // 
            this.cbRun.FormattingEnabled = true;
            this.cbRun.Location = new System.Drawing.Point(11, 128);
            this.cbRun.Name = "cbRun";
            this.cbRun.Size = new System.Drawing.Size(121, 21);
            this.cbRun.TabIndex = 8;
            // 
            // cbJump
            // 
            this.cbJump.FormattingEnabled = true;
            this.cbJump.Location = new System.Drawing.Point(138, 128);
            this.cbJump.Name = "cbJump";
            this.cbJump.Size = new System.Drawing.Size(121, 21);
            this.cbJump.TabIndex = 9;
            // 
            // cbSwim
            // 
            this.cbSwim.FormattingEnabled = true;
            this.cbSwim.Location = new System.Drawing.Point(265, 128);
            this.cbSwim.Name = "cbSwim";
            this.cbSwim.Size = new System.Drawing.Size(121, 21);
            this.cbSwim.TabIndex = 10;
            // 
            // StrategyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 262);
            this.Controls.Add(this.cbSwim);
            this.Controls.Add(this.cbJump);
            this.Controls.Add(this.cbRun);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtSportsmenName);
            this.Controls.Add(this.btnAppendCommand);
            this.Controls.Add(this.txtTreningName);
            this.Controls.Add(this.btnAppendTrenig);
            this.Controls.Add(this.lbTrening);
            this.Controls.Add(this.lbCommands);
            this.Name = "StrategyForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCommands;
        private System.Windows.Forms.ListBox lbTrening;
        private System.Windows.Forms.Button btnAppendTrenig;
        private System.Windows.Forms.TextBox txtTreningName;
        private System.Windows.Forms.Button btnAppendCommand;
        private System.Windows.Forms.TextBox txtSportsmenName;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ComboBox cbRun;
        private System.Windows.Forms.ComboBox cbJump;
        private System.Windows.Forms.ComboBox cbSwim;
    }
}

