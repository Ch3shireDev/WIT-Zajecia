namespace Command
{
    partial class CommandForm
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
            this.btnAppendTrening = new System.Windows.Forms.Button();
            this.BtnDropTreningItem = new System.Windows.Forms.Button();
            this.btnDeleteCommandItem = new System.Windows.Forms.Button();
            this.txtTreningName = new System.Windows.Forms.TextBox();
            this.btnAppendCommand = new System.Windows.Forms.Button();
            this.txtSportsmenName = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbCommands
            // 
            this.lbCommands.FormattingEnabled = true;
            this.lbCommands.Location = new System.Drawing.Point(12, 12);
            this.lbCommands.Name = "lbCommands";
            this.lbCommands.Size = new System.Drawing.Size(101, 134);
            this.lbCommands.TabIndex = 0;
            // 
            // lbTrening
            // 
            this.lbTrening.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTrening.FormattingEnabled = true;
            this.lbTrening.Location = new System.Drawing.Point(707, 12);
            this.lbTrening.Name = "lbTrening";
            this.lbTrening.Size = new System.Drawing.Size(101, 134);
            this.lbTrening.TabIndex = 1;
            // 
            // btnAppendTrening
            // 
            this.btnAppendTrening.Location = new System.Drawing.Point(119, 12);
            this.btnAppendTrening.Name = "btnAppendTrening";
            this.btnAppendTrening.Size = new System.Drawing.Size(75, 23);
            this.btnAppendTrening.TabIndex = 2;
            this.btnAppendTrening.Text = "=>";
            this.btnAppendTrening.UseVisualStyleBackColor = true;
            // 
            // BtnDropTreningItem
            // 
            this.BtnDropTreningItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDropTreningItem.Location = new System.Drawing.Point(626, 12);
            this.BtnDropTreningItem.Name = "BtnDropTreningItem";
            this.BtnDropTreningItem.Size = new System.Drawing.Size(75, 23);
            this.BtnDropTreningItem.TabIndex = 3;
            this.BtnDropTreningItem.Text = "X";
            this.BtnDropTreningItem.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCommandItem
            // 
            this.btnDeleteCommandItem.Location = new System.Drawing.Point(119, 123);
            this.btnDeleteCommandItem.Name = "btnDeleteCommandItem";
            this.btnDeleteCommandItem.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCommandItem.TabIndex = 4;
            this.btnDeleteCommandItem.Text = "X";
            this.btnDeleteCommandItem.UseVisualStyleBackColor = true;
            // 
            // txtTreningName
            // 
            this.txtTreningName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTreningName.Location = new System.Drawing.Point(550, 41);
            this.txtTreningName.Name = "txtTreningName";
            this.txtTreningName.Size = new System.Drawing.Size(151, 20);
            this.txtTreningName.TabIndex = 5;
            // 
            // btnAppendCommand
            // 
            this.btnAppendCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppendCommand.Location = new System.Drawing.Point(469, 39);
            this.btnAppendCommand.Name = "btnAppendCommand";
            this.btnAppendCommand.Size = new System.Drawing.Size(75, 23);
            this.btnAppendCommand.TabIndex = 6;
            this.btnAppendCommand.Text = "<=";
            this.btnAppendCommand.UseVisualStyleBackColor = true;
            // 
            // txtSportsmenName
            // 
            this.txtSportsmenName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSportsmenName.Location = new System.Drawing.Point(12, 152);
            this.txtSportsmenName.Name = "txtSportsmenName";
            this.txtSportsmenName.Size = new System.Drawing.Size(689, 20);
            this.txtSportsmenName.TabIndex = 7;
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Location = new System.Drawing.Point(707, 150);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(101, 23);
            this.btnExecute.TabIndex = 8;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(13, 178);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(795, 175);
            this.txtLog.TabIndex = 9;
            // 
            // CommandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 365);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtSportsmenName);
            this.Controls.Add(this.btnAppendCommand);
            this.Controls.Add(this.txtTreningName);
            this.Controls.Add(this.btnDeleteCommandItem);
            this.Controls.Add(this.BtnDropTreningItem);
            this.Controls.Add(this.btnAppendTrening);
            this.Controls.Add(this.lbTrening);
            this.Controls.Add(this.lbCommands);
            this.Name = "CommandForm";
            this.Text = "Command Test Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCommands;
        private System.Windows.Forms.ListBox lbTrening;
        private System.Windows.Forms.Button btnAppendTrening;
        private System.Windows.Forms.Button BtnDropTreningItem;
        private System.Windows.Forms.Button btnDeleteCommandItem;
        private System.Windows.Forms.TextBox txtTreningName;
        private System.Windows.Forms.Button btnAppendCommand;
        private System.Windows.Forms.TextBox txtSportsmenName;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtLog;
    }
}

