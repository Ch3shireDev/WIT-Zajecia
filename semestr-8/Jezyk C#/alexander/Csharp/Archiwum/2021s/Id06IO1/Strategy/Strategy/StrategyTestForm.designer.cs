﻿namespace Strategy
{
    partial class CommandTestForm
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
            this.btnRemoveCommand = new System.Windows.Forms.Button();
            this.btnRemoveTreningItem = new System.Windows.Forms.Button();
            this.txtTreningName = new System.Windows.Forms.TextBox();
            this.btnAppendCommands = new System.Windows.Forms.Button();
            this.txtSportsmenName = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.cbSwim = new System.Windows.Forms.ComboBox();
            this.cbJump = new System.Windows.Forms.ComboBox();
            this.cbRun = new System.Windows.Forms.ComboBox();
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
            this.lbTrening.Location = new System.Drawing.Point(662, 12);
            this.lbTrening.Name = "lbTrening";
            this.lbTrening.Size = new System.Drawing.Size(120, 108);
            this.lbTrening.TabIndex = 1;
            // 
            // btnAppendTrening
            // 
            this.btnAppendTrening.Location = new System.Drawing.Point(138, 12);
            this.btnAppendTrening.Name = "btnAppendTrening";
            this.btnAppendTrening.Size = new System.Drawing.Size(75, 23);
            this.btnAppendTrening.TabIndex = 2;
            this.btnAppendTrening.Text = "=>";
            this.btnAppendTrening.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCommand
            // 
            this.btnRemoveCommand.Location = new System.Drawing.Point(138, 41);
            this.btnRemoveCommand.Name = "btnRemoveCommand";
            this.btnRemoveCommand.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveCommand.TabIndex = 3;
            this.btnRemoveCommand.Text = "X";
            this.btnRemoveCommand.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTreningItem
            // 
            this.btnRemoveTreningItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveTreningItem.Location = new System.Drawing.Point(581, 41);
            this.btnRemoveTreningItem.Name = "btnRemoveTreningItem";
            this.btnRemoveTreningItem.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveTreningItem.TabIndex = 4;
            this.btnRemoveTreningItem.Text = "X";
            this.btnRemoveTreningItem.UseVisualStyleBackColor = true;
            // 
            // txtTreningName
            // 
            this.txtTreningName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTreningName.Location = new System.Drawing.Point(487, 70);
            this.txtTreningName.Name = "txtTreningName";
            this.txtTreningName.Size = new System.Drawing.Size(169, 20);
            this.txtTreningName.TabIndex = 5;
            this.txtTreningName.TextChanged += new System.EventHandler(this.txtTreningName_TextChanged);
            // 
            // btnAppendCommands
            // 
            this.btnAppendCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppendCommands.Location = new System.Drawing.Point(406, 68);
            this.btnAppendCommands.Name = "btnAppendCommands";
            this.btnAppendCommands.Size = new System.Drawing.Size(75, 23);
            this.btnAppendCommands.TabIndex = 6;
            this.btnAppendCommands.Text = "<=";
            this.btnAppendCommands.UseVisualStyleBackColor = true;
            // 
            // txtSportsmenName
            // 
            this.txtSportsmenName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSportsmenName.Location = new System.Drawing.Point(12, 125);
            this.txtSportsmenName.Name = "txtSportsmenName";
            this.txtSportsmenName.Size = new System.Drawing.Size(308, 20);
            this.txtSportsmenName.TabIndex = 7;
            this.txtSportsmenName.TextChanged += new System.EventHandler(this.txtSportsmenName_TextChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Location = new System.Drawing.Point(707, 123);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 8;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(12, 152);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(770, 233);
            this.txtLog.TabIndex = 9;
            // 
            // cbSwim
            // 
            this.cbSwim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSwim.FormattingEnabled = true;
            this.cbSwim.Location = new System.Drawing.Point(580, 125);
            this.cbSwim.Name = "cbSwim";
            this.cbSwim.Size = new System.Drawing.Size(121, 21);
            this.cbSwim.TabIndex = 10;
            // 
            // cbJump
            // 
            this.cbJump.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbJump.FormattingEnabled = true;
            this.cbJump.Location = new System.Drawing.Point(453, 125);
            this.cbJump.Name = "cbJump";
            this.cbJump.Size = new System.Drawing.Size(121, 21);
            this.cbJump.TabIndex = 11;
            // 
            // cbRun
            // 
            this.cbRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRun.FormattingEnabled = true;
            this.cbRun.Location = new System.Drawing.Point(326, 125);
            this.cbRun.Name = "cbRun";
            this.cbRun.Size = new System.Drawing.Size(121, 21);
            this.cbRun.TabIndex = 12;
            // 
            // CommandTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 397);
            this.Controls.Add(this.cbRun);
            this.Controls.Add(this.cbJump);
            this.Controls.Add(this.cbSwim);
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
            this.Name = "CommandTestForm";
            this.Text = "Command Test Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCommands;
        private System.Windows.Forms.ListBox lbTrening;
        private System.Windows.Forms.Button btnAppendTrening;
        private System.Windows.Forms.Button btnRemoveCommand;
        private System.Windows.Forms.Button btnRemoveTreningItem;
        private System.Windows.Forms.TextBox txtTreningName;
        private System.Windows.Forms.Button btnAppendCommands;
        private System.Windows.Forms.TextBox txtSportsmenName;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ComboBox cbSwim;
        private System.Windows.Forms.ComboBox cbJump;
        private System.Windows.Forms.ComboBox cbRun;
    }
}

