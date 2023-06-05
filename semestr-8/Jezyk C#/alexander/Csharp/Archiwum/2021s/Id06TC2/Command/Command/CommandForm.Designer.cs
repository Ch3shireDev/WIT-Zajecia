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
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtSportsmenName = new System.Windows.Forms.TextBox();
            this.btnAppendCommands = new System.Windows.Forms.Button();
            this.txtTreningName = new System.Windows.Forms.TextBox();
            this.btnRemoveTreningItem = new System.Windows.Forms.Button();
            this.btnRemoveCommand = new System.Windows.Forms.Button();
            this.btnAppendTrening = new System.Windows.Forms.Button();
            this.lbTrening = new System.Windows.Forms.ListBox();
            this.lbCommands = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(12, 152);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(762, 197);
            this.txtLog.TabIndex = 19;
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Location = new System.Drawing.Point(699, 123);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 18;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            // 
            // txtSportsmenName
            // 
            this.txtSportsmenName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSportsmenName.Location = new System.Drawing.Point(12, 126);
            this.txtSportsmenName.Name = "txtSportsmenName";
            this.txtSportsmenName.Size = new System.Drawing.Size(681, 20);
            this.txtSportsmenName.TabIndex = 17;
            // 
            // btnAppendCommands
            // 
            this.btnAppendCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppendCommands.Location = new System.Drawing.Point(398, 68);
            this.btnAppendCommands.Name = "btnAppendCommands";
            this.btnAppendCommands.Size = new System.Drawing.Size(75, 23);
            this.btnAppendCommands.TabIndex = 16;
            this.btnAppendCommands.Text = "<=";
            this.btnAppendCommands.UseVisualStyleBackColor = true;
            // 
            // txtTreningName
            // 
            this.txtTreningName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTreningName.Location = new System.Drawing.Point(479, 70);
            this.txtTreningName.Name = "txtTreningName";
            this.txtTreningName.Size = new System.Drawing.Size(169, 20);
            this.txtTreningName.TabIndex = 15;
            // 
            // btnRemoveTreningItem
            // 
            this.btnRemoveTreningItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveTreningItem.Location = new System.Drawing.Point(573, 41);
            this.btnRemoveTreningItem.Name = "btnRemoveTreningItem";
            this.btnRemoveTreningItem.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveTreningItem.TabIndex = 14;
            this.btnRemoveTreningItem.Text = "X";
            this.btnRemoveTreningItem.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCommand
            // 
            this.btnRemoveCommand.Location = new System.Drawing.Point(138, 41);
            this.btnRemoveCommand.Name = "btnRemoveCommand";
            this.btnRemoveCommand.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveCommand.TabIndex = 13;
            this.btnRemoveCommand.Text = "X";
            this.btnRemoveCommand.UseVisualStyleBackColor = true;
            // 
            // btnAppendTrening
            // 
            this.btnAppendTrening.Location = new System.Drawing.Point(138, 12);
            this.btnAppendTrening.Name = "btnAppendTrening";
            this.btnAppendTrening.Size = new System.Drawing.Size(75, 23);
            this.btnAppendTrening.TabIndex = 12;
            this.btnAppendTrening.Text = "=>";
            this.btnAppendTrening.UseVisualStyleBackColor = true;
            // 
            // lbTrening
            // 
            this.lbTrening.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTrening.FormattingEnabled = true;
            this.lbTrening.Location = new System.Drawing.Point(654, 12);
            this.lbTrening.Name = "lbTrening";
            this.lbTrening.Size = new System.Drawing.Size(120, 108);
            this.lbTrening.TabIndex = 11;
            // 
            // lbCommands
            // 
            this.lbCommands.FormattingEnabled = true;
            this.lbCommands.Location = new System.Drawing.Point(12, 12);
            this.lbCommands.Name = "lbCommands";
            this.lbCommands.Size = new System.Drawing.Size(120, 108);
            this.lbCommands.TabIndex = 10;
            // 
            // CommandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 361);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtSportsmenName);
            this.Controls.Add(this.btnAppendCommands);
            this.Controls.Add(this.txtTreningName);
            this.Controls.Add(this.btnRemoveTreningItem);
            this.Controls.Add(this.btnRemoveCommand);
            this.Controls.Add(this.btnAppendTrening);
            this.Controls.Add(this.lbTrening);
            this.Controls.Add(this.lbCommands);
            this.Name = "CommandForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtSportsmenName;
        private System.Windows.Forms.Button btnAppendCommands;
        private System.Windows.Forms.TextBox txtTreningName;
        private System.Windows.Forms.Button btnRemoveTreningItem;
        private System.Windows.Forms.Button btnRemoveCommand;
        private System.Windows.Forms.Button btnAppendTrening;
        private System.Windows.Forms.ListBox lbTrening;
        private System.Windows.Forms.ListBox lbCommands;

    }
}

