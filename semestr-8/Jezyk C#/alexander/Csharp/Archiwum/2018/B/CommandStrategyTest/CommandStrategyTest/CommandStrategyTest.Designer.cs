namespace CommandStrategyTest
{
    partial class CommandStrategyTest
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
            this.LstMainList = new System.Windows.Forms.ListBox();
            this.LstNewList = new System.Windows.Forms.ListBox();
            this.BtnExecute = new System.Windows.Forms.Button();
            this.BtnAppend = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnMakeNew = new System.Windows.Forms.Button();
            this.EdNewName = new System.Windows.Forms.TextBox();
            this.Log = new System.Windows.Forms.TextBox();
            this.BoxRun = new System.Windows.Forms.ComboBox();
            this.BoxJump = new System.Windows.Forms.ComboBox();
            this.BoxSwim = new System.Windows.Forms.ComboBox();
            this.EdName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LstMainList
            // 
            this.LstMainList.FormattingEnabled = true;
            this.LstMainList.Location = new System.Drawing.Point(12, 12);
            this.LstMainList.Name = "LstMainList";
            this.LstMainList.Size = new System.Drawing.Size(165, 186);
            this.LstMainList.TabIndex = 0;
            this.LstMainList.SelectedIndexChanged += new System.EventHandler(this.LstMainList_SelectedIndexChanged);
            // 
            // LstNewList
            // 
            this.LstNewList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LstNewList.FormattingEnabled = true;
            this.LstNewList.Location = new System.Drawing.Point(688, 12);
            this.LstNewList.Name = "LstNewList";
            this.LstNewList.Size = new System.Drawing.Size(165, 186);
            this.LstNewList.TabIndex = 1;
            this.LstNewList.SelectedIndexChanged += new System.EventHandler(this.LstNewList_SelectedIndexChanged);
            // 
            // BtnExecute
            // 
            this.BtnExecute.Location = new System.Drawing.Point(183, 175);
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(75, 23);
            this.BtnExecute.TabIndex = 2;
            this.BtnExecute.Text = "Wykonaj";
            this.BtnExecute.UseVisualStyleBackColor = true;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // BtnAppend
            // 
            this.BtnAppend.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAppend.Location = new System.Drawing.Point(395, 12);
            this.BtnAppend.Name = "BtnAppend";
            this.BtnAppend.Size = new System.Drawing.Size(75, 23);
            this.BtnAppend.TabIndex = 3;
            this.BtnAppend.Text = ">>";
            this.BtnAppend.UseVisualStyleBackColor = true;
            this.BtnAppend.Click += new System.EventHandler(this.BtnAppend_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemove.Enabled = false;
            this.BtnRemove.Location = new System.Drawing.Point(607, 60);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnRemove.TabIndex = 4;
            this.BtnRemove.Text = "Usuń";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnMakeNew
            // 
            this.BtnMakeNew.Enabled = false;
            this.BtnMakeNew.Location = new System.Drawing.Point(183, 122);
            this.BtnMakeNew.Name = "BtnMakeNew";
            this.BtnMakeNew.Size = new System.Drawing.Size(75, 23);
            this.BtnMakeNew.TabIndex = 5;
            this.BtnMakeNew.Text = "<<";
            this.BtnMakeNew.UseVisualStyleBackColor = true;
            this.BtnMakeNew.Click += new System.EventHandler(this.BtnMakeNew_Click);
            // 
            // EdNewName
            // 
            this.EdNewName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdNewName.Location = new System.Drawing.Point(264, 125);
            this.EdNewName.Name = "EdNewName";
            this.EdNewName.Size = new System.Drawing.Size(418, 20);
            this.EdNewName.TabIndex = 6;
            this.EdNewName.TextChanged += new System.EventHandler(this.EdNewName_TextChanged);
            // 
            // Log
            // 
            this.Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Log.Location = new System.Drawing.Point(183, 204);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Log.Size = new System.Drawing.Size(670, 256);
            this.Log.TabIndex = 7;
            this.Log.WordWrap = false;
            // 
            // BoxRun
            // 
            this.BoxRun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxRun.FormattingEnabled = true;
            this.BoxRun.Location = new System.Drawing.Point(12, 233);
            this.BoxRun.Name = "BoxRun";
            this.BoxRun.Size = new System.Drawing.Size(165, 21);
            this.BoxRun.TabIndex = 8;
            // 
            // BoxJump
            // 
            this.BoxJump.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxJump.FormattingEnabled = true;
            this.BoxJump.Location = new System.Drawing.Point(12, 260);
            this.BoxJump.Name = "BoxJump";
            this.BoxJump.Size = new System.Drawing.Size(165, 21);
            this.BoxJump.TabIndex = 9;
            // 
            // BoxSwim
            // 
            this.BoxSwim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxSwim.FormattingEnabled = true;
            this.BoxSwim.Location = new System.Drawing.Point(12, 287);
            this.BoxSwim.Name = "BoxSwim";
            this.BoxSwim.Size = new System.Drawing.Size(165, 21);
            this.BoxSwim.TabIndex = 10;
            // 
            // EdName
            // 
            this.EdName.Location = new System.Drawing.Point(12, 207);
            this.EdName.Name = "EdName";
            this.EdName.Size = new System.Drawing.Size(165, 20);
            this.EdName.TabIndex = 11;
            this.EdName.Text = "Kowalski Jan";
            this.EdName.TextChanged += new System.EventHandler(this.EdName_TextChanged);
            // 
            // CommandStrategyTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 472);
            this.Controls.Add(this.EdName);
            this.Controls.Add(this.BoxSwim);
            this.Controls.Add(this.BoxJump);
            this.Controls.Add(this.BoxRun);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.EdNewName);
            this.Controls.Add(this.BtnMakeNew);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAppend);
            this.Controls.Add(this.BtnExecute);
            this.Controls.Add(this.LstNewList);
            this.Controls.Add(this.LstMainList);
            this.Name = "CommandStrategyTest";
            this.Text = "Command/Strategy test ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstMainList;
        private System.Windows.Forms.ListBox LstNewList;
        private System.Windows.Forms.Button BtnExecute;
        private System.Windows.Forms.Button BtnAppend;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnMakeNew;
        private System.Windows.Forms.TextBox EdNewName;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.ComboBox BoxRun;
        private System.Windows.Forms.ComboBox BoxJump;
        private System.Windows.Forms.ComboBox BoxSwim;
        private System.Windows.Forms.TextBox EdName;
    }
}

