namespace CommandTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommandForm));
            this.LbCommands = new System.Windows.Forms.ListBox();
            this.LbComplex = new System.Windows.Forms.ListBox();
            this.BtnDelCommand = new System.Windows.Forms.Button();
            this.BtnDelComplex = new System.Windows.Forms.Button();
            this.EdLog = new System.Windows.Forms.TextBox();
            this.EdSportsmenName = new System.Windows.Forms.TextBox();
            this.BtnExecute = new System.Windows.Forms.Button();
            this.BtnStoreComplex = new System.Windows.Forms.Button();
            this.EdSequenceName = new System.Windows.Forms.TextBox();
            this.EdMultiply = new System.Windows.Forms.NumericUpDown();
            this.BtnStoreMultiply = new System.Windows.Forms.Button();
            this.BtnAddComplex = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EdMultiply)).BeginInit();
            this.SuspendLayout();
            // 
            // LbCommands
            // 
            this.LbCommands.FormattingEnabled = true;
            this.LbCommands.Location = new System.Drawing.Point(12, 12);
            this.LbCommands.Name = "LbCommands";
            this.LbCommands.Size = new System.Drawing.Size(120, 199);
            this.LbCommands.TabIndex = 0;
            this.LbCommands.Click += new System.EventHandler(this.LbCommands_Click);
            this.LbCommands.SelectedValueChanged += new System.EventHandler(this.LbCommands_SelectedValueChanged);
            // 
            // LbComplex
            // 
            this.LbComplex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbComplex.FormattingEnabled = true;
            this.LbComplex.Location = new System.Drawing.Point(547, 12);
            this.LbComplex.Name = "LbComplex";
            this.LbComplex.Size = new System.Drawing.Size(120, 199);
            this.LbComplex.TabIndex = 1;
            this.LbComplex.SelectedValueChanged += new System.EventHandler(this.LbComplex_SelectedValueChanged);
            // 
            // BtnDelCommand
            // 
            this.BtnDelCommand.Location = new System.Drawing.Point(12, 217);
            this.BtnDelCommand.Name = "BtnDelCommand";
            this.BtnDelCommand.Size = new System.Drawing.Size(120, 23);
            this.BtnDelCommand.TabIndex = 2;
            this.BtnDelCommand.Text = "Delete";
            this.BtnDelCommand.UseVisualStyleBackColor = true;
            this.BtnDelCommand.Click += new System.EventHandler(this.BtnDelCommand_Click);
            // 
            // BtnDelComplex
            // 
            this.BtnDelComplex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelComplex.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelComplex.Image")));
            this.BtnDelComplex.Location = new System.Drawing.Point(547, 217);
            this.BtnDelComplex.Name = "BtnDelComplex";
            this.BtnDelComplex.Size = new System.Drawing.Size(120, 23);
            this.BtnDelComplex.TabIndex = 3;
            this.BtnDelComplex.Text = "Delete";
            this.BtnDelComplex.UseVisualStyleBackColor = true;
            this.BtnDelComplex.Click += new System.EventHandler(this.BtnDelComplex_Click);
            // 
            // EdLog
            // 
            this.EdLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdLog.Location = new System.Drawing.Point(12, 246);
            this.EdLog.Multiline = true;
            this.EdLog.Name = "EdLog";
            this.EdLog.Size = new System.Drawing.Size(655, 168);
            this.EdLog.TabIndex = 4;
            // 
            // EdSportsmenName
            // 
            this.EdSportsmenName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdSportsmenName.Location = new System.Drawing.Point(138, 219);
            this.EdSportsmenName.Name = "EdSportsmenName";
            this.EdSportsmenName.Size = new System.Drawing.Size(322, 20);
            this.EdSportsmenName.TabIndex = 5;
            this.EdSportsmenName.Text = "Adam Kowalski";
            this.EdSportsmenName.TextChanged += new System.EventHandler(this.EdSportsmenName_TextChanged);
            // 
            // BtnExecute
            // 
            this.BtnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExecute.Location = new System.Drawing.Point(466, 217);
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(75, 23);
            this.BtnExecute.TabIndex = 6;
            this.BtnExecute.Text = "Execute";
            this.BtnExecute.UseVisualStyleBackColor = true;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // BtnStoreComplex
            // 
            this.BtnStoreComplex.Location = new System.Drawing.Point(141, 10);
            this.BtnStoreComplex.Name = "BtnStoreComplex";
            this.BtnStoreComplex.Size = new System.Drawing.Size(75, 23);
            this.BtnStoreComplex.TabIndex = 7;
            this.BtnStoreComplex.Text = "Store";
            this.BtnStoreComplex.UseVisualStyleBackColor = true;
            this.BtnStoreComplex.Click += new System.EventHandler(this.BtnStoreComplex_Click);
            // 
            // EdSequenceName
            // 
            this.EdSequenceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdSequenceName.Location = new System.Drawing.Point(222, 12);
            this.EdSequenceName.Name = "EdSequenceName";
            this.EdSequenceName.Size = new System.Drawing.Size(319, 20);
            this.EdSequenceName.TabIndex = 8;
            this.EdSequenceName.TextChanged += new System.EventHandler(this.EdComplexName_TextChanged);
            // 
            // EdMultiply
            // 
            this.EdMultiply.Location = new System.Drawing.Point(222, 42);
            this.EdMultiply.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.EdMultiply.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EdMultiply.Name = "EdMultiply";
            this.EdMultiply.Size = new System.Drawing.Size(39, 20);
            this.EdMultiply.TabIndex = 9;
            this.EdMultiply.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // BtnStoreMultiply
            // 
            this.BtnStoreMultiply.Location = new System.Drawing.Point(141, 39);
            this.BtnStoreMultiply.Name = "BtnStoreMultiply";
            this.BtnStoreMultiply.Size = new System.Drawing.Size(75, 23);
            this.BtnStoreMultiply.TabIndex = 10;
            this.BtnStoreMultiply.Text = "Store";
            this.BtnStoreMultiply.UseVisualStyleBackColor = true;
            this.BtnStoreMultiply.Click += new System.EventHandler(this.BtnStoreMultiply_Click);
            // 
            // BtnAddComplex
            // 
            this.BtnAddComplex.Location = new System.Drawing.Point(141, 68);
            this.BtnAddComplex.Name = "BtnAddComplex";
            this.BtnAddComplex.Size = new System.Drawing.Size(75, 23);
            this.BtnAddComplex.TabIndex = 11;
            this.BtnAddComplex.Text = "Append";
            this.BtnAddComplex.UseVisualStyleBackColor = true;
            this.BtnAddComplex.Click += new System.EventHandler(this.BtnAddComplex_Click);
            // 
            // CommandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 426);
            this.Controls.Add(this.BtnAddComplex);
            this.Controls.Add(this.BtnStoreMultiply);
            this.Controls.Add(this.EdMultiply);
            this.Controls.Add(this.EdSequenceName);
            this.Controls.Add(this.BtnStoreComplex);
            this.Controls.Add(this.BtnExecute);
            this.Controls.Add(this.EdSportsmenName);
            this.Controls.Add(this.EdLog);
            this.Controls.Add(this.BtnDelComplex);
            this.Controls.Add(this.BtnDelCommand);
            this.Controls.Add(this.LbComplex);
            this.Controls.Add(this.LbCommands);
            this.Name = "CommandForm";
            this.Text = "Command";
            ((System.ComponentModel.ISupportInitialize)(this.EdMultiply)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LbCommands;
        private System.Windows.Forms.ListBox LbComplex;
        private System.Windows.Forms.Button BtnDelCommand;
        private System.Windows.Forms.Button BtnDelComplex;
        private System.Windows.Forms.TextBox EdLog;
        private System.Windows.Forms.TextBox EdSportsmenName;
        private System.Windows.Forms.Button BtnExecute;
        private System.Windows.Forms.Button BtnStoreComplex;
        private System.Windows.Forms.TextBox EdSequenceName;
        private System.Windows.Forms.NumericUpDown EdMultiply;
        private System.Windows.Forms.Button BtnStoreMultiply;
        private System.Windows.Forms.Button BtnAddComplex;
    }
}

