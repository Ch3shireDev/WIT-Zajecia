namespace CommandTest
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
            this.LbCommands = new System.Windows.Forms.ListBox();
            this.LbTrening = new System.Windows.Forms.ListBox();
            this.EdTrening = new System.Windows.Forms.TextBox();
            this.BtnAddToTrening = new System.Windows.Forms.Button();
            this.BtnDelFromCommands = new System.Windows.Forms.Button();
            this.BtnDelFromTrening = new System.Windows.Forms.Button();
            this.BtnAddTrening = new System.Windows.Forms.Button();
            this.EdSportsman = new System.Windows.Forms.TextBox();
            this.BtnExecute = new System.Windows.Forms.Button();
            this.EdLog = new System.Windows.Forms.TextBox();
            this.BtnAddMultiply = new System.Windows.Forms.Button();
            this.EdCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.EdCount)).BeginInit();
            this.SuspendLayout();
            // 
            // LbCommands
            // 
            this.LbCommands.FormattingEnabled = true;
            this.LbCommands.Location = new System.Drawing.Point(12, 12);
            this.LbCommands.Name = "LbCommands";
            this.LbCommands.Size = new System.Drawing.Size(207, 173);
            this.LbCommands.TabIndex = 0;
            this.LbCommands.SelectedValueChanged += new System.EventHandler(this.SomeField_SomeChanged);
            this.LbCommands.DoubleClick += new System.EventHandler(this.LbCommands_DoubleClick);
            // 
            // LbTrening
            // 
            this.LbTrening.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbTrening.FormattingEnabled = true;
            this.LbTrening.Location = new System.Drawing.Point(407, 12);
            this.LbTrening.Name = "LbTrening";
            this.LbTrening.Size = new System.Drawing.Size(207, 147);
            this.LbTrening.TabIndex = 1;
            this.LbTrening.SelectedIndexChanged += new System.EventHandler(this.SomeField_SomeChanged);
            // 
            // EdTrening
            // 
            this.EdTrening.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EdTrening.Location = new System.Drawing.Point(407, 165);
            this.EdTrening.Name = "EdTrening";
            this.EdTrening.Size = new System.Drawing.Size(207, 20);
            this.EdTrening.TabIndex = 2;
            this.EdTrening.TextChanged += new System.EventHandler(this.SomeField_SomeChanged);
            // 
            // BtnAddToTrening
            // 
            this.BtnAddToTrening.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddToTrening.Location = new System.Drawing.Point(326, 12);
            this.BtnAddToTrening.Name = "BtnAddToTrening";
            this.BtnAddToTrening.Size = new System.Drawing.Size(75, 23);
            this.BtnAddToTrening.TabIndex = 3;
            this.BtnAddToTrening.Text = ">>";
            this.BtnAddToTrening.UseVisualStyleBackColor = true;
            this.BtnAddToTrening.Click += new System.EventHandler(this.BtnAddToTrening_Click);
            // 
            // BtnDelFromCommands
            // 
            this.BtnDelFromCommands.Enabled = false;
            this.BtnDelFromCommands.Location = new System.Drawing.Point(225, 162);
            this.BtnDelFromCommands.Name = "BtnDelFromCommands";
            this.BtnDelFromCommands.Size = new System.Drawing.Size(75, 23);
            this.BtnDelFromCommands.TabIndex = 4;
            this.BtnDelFromCommands.Text = "Usuń";
            this.BtnDelFromCommands.UseVisualStyleBackColor = true;
            this.BtnDelFromCommands.Click += new System.EventHandler(this.BtnDelFromCommands_Click);
            // 
            // BtnDelFromTrening
            // 
            this.BtnDelFromTrening.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelFromTrening.Enabled = false;
            this.BtnDelFromTrening.Location = new System.Drawing.Point(326, 136);
            this.BtnDelFromTrening.Name = "BtnDelFromTrening";
            this.BtnDelFromTrening.Size = new System.Drawing.Size(75, 23);
            this.BtnDelFromTrening.TabIndex = 5;
            this.BtnDelFromTrening.Text = "Usuń";
            this.BtnDelFromTrening.UseVisualStyleBackColor = true;
            this.BtnDelFromTrening.Click += new System.EventHandler(this.BtnDelFromTrening_Click);
            // 
            // BtnAddTrening
            // 
            this.BtnAddTrening.Enabled = false;
            this.BtnAddTrening.Location = new System.Drawing.Point(225, 57);
            this.BtnAddTrening.Name = "BtnAddTrening";
            this.BtnAddTrening.Size = new System.Drawing.Size(75, 23);
            this.BtnAddTrening.TabIndex = 6;
            this.BtnAddTrening.Text = "<<";
            this.BtnAddTrening.UseVisualStyleBackColor = true;
            this.BtnAddTrening.Click += new System.EventHandler(this.BtnAddTrening_Click);
            // 
            // EdSportsman
            // 
            this.EdSportsman.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdSportsman.Location = new System.Drawing.Point(12, 191);
            this.EdSportsman.Name = "EdSportsman";
            this.EdSportsman.Size = new System.Drawing.Size(521, 20);
            this.EdSportsman.TabIndex = 7;
            this.EdSportsman.TextChanged += new System.EventHandler(this.SomeField_SomeChanged);
            // 
            // BtnExecute
            // 
            this.BtnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExecute.Enabled = false;
            this.BtnExecute.Location = new System.Drawing.Point(539, 191);
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(75, 23);
            this.BtnExecute.TabIndex = 8;
            this.BtnExecute.Text = "Wykonaj";
            this.BtnExecute.UseVisualStyleBackColor = true;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // EdLog
            // 
            this.EdLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdLog.Enabled = false;
            this.EdLog.Location = new System.Drawing.Point(12, 220);
            this.EdLog.Multiline = true;
            this.EdLog.Name = "EdLog";
            this.EdLog.Size = new System.Drawing.Size(602, 130);
            this.EdLog.TabIndex = 9;
            // 
            // BtnAddMultiply
            // 
            this.BtnAddMultiply.Enabled = false;
            this.BtnAddMultiply.Location = new System.Drawing.Point(225, 86);
            this.BtnAddMultiply.Name = "BtnAddMultiply";
            this.BtnAddMultiply.Size = new System.Drawing.Size(75, 23);
            this.BtnAddMultiply.TabIndex = 10;
            this.BtnAddMultiply.Text = "<<";
            this.BtnAddMultiply.UseVisualStyleBackColor = true;
            this.BtnAddMultiply.Click += new System.EventHandler(this.BtnAddMultiply_Click);
            // 
            // EdCount
            // 
            this.EdCount.Location = new System.Drawing.Point(306, 89);
            this.EdCount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.EdCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.EdCount.Name = "EdCount";
            this.EdCount.Size = new System.Drawing.Size(42, 20);
            this.EdCount.TabIndex = 11;
            this.EdCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EdCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // CommandTestForm
            // 
            this.AcceptButton = this.BtnExecute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 362);
            this.Controls.Add(this.EdCount);
            this.Controls.Add(this.BtnAddMultiply);
            this.Controls.Add(this.EdLog);
            this.Controls.Add(this.BtnExecute);
            this.Controls.Add(this.EdSportsman);
            this.Controls.Add(this.BtnAddTrening);
            this.Controls.Add(this.BtnDelFromTrening);
            this.Controls.Add(this.BtnDelFromCommands);
            this.Controls.Add(this.BtnAddToTrening);
            this.Controls.Add(this.EdTrening);
            this.Controls.Add(this.LbTrening);
            this.Controls.Add(this.LbCommands);
            this.Name = "CommandTestForm";
            this.Text = "Wzorzec Polecenie ...";
            ((System.ComponentModel.ISupportInitialize)(this.EdCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbCommands;
        private System.Windows.Forms.ListBox LbTrening;
        private System.Windows.Forms.TextBox EdTrening;
        private System.Windows.Forms.Button BtnAddToTrening;
        private System.Windows.Forms.Button BtnDelFromCommands;
        private System.Windows.Forms.Button BtnDelFromTrening;
        private System.Windows.Forms.Button BtnAddTrening;
        private System.Windows.Forms.TextBox EdSportsman;
        private System.Windows.Forms.Button BtnExecute;
        private System.Windows.Forms.TextBox EdLog;
        private System.Windows.Forms.Button BtnAddMultiply;
        private System.Windows.Forms.NumericUpDown EdCount;
    }
}

