namespace Test005
{
    partial class Form1
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
            this.Tabs = new System.Windows.Forms.TabControl();
            this.PgTab = new System.Windows.Forms.TabPage();
            this.Tab = new System.Windows.Forms.TableLayoutPanel();
            this.TabSize = new System.Windows.Forms.NumericUpDown();
            this.PgField = new System.Windows.Forms.TabPage();
            this.BoxTab = new System.Windows.Forms.TextBox();
            this.Info = new System.Windows.Forms.Label();
            this.BtnCopy = new System.Windows.Forms.Button();
            this.BtnPaste = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.DlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.DlgSave = new System.Windows.Forms.SaveFileDialog();
            this.Tabs.SuspendLayout();
            this.PgTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabSize)).BeginInit();
            this.PgField.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Controls.Add(this.PgTab);
            this.Tabs.Controls.Add(this.PgField);
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(571, 268);
            this.Tabs.TabIndex = 1;
            // 
            // PgTab
            // 
            this.PgTab.Controls.Add(this.Tab);
            this.PgTab.Controls.Add(this.TabSize);
            this.PgTab.Location = new System.Drawing.Point(4, 22);
            this.PgTab.Name = "PgTab";
            this.PgTab.Padding = new System.Windows.Forms.Padding(3);
            this.PgTab.Size = new System.Drawing.Size(563, 242);
            this.PgTab.TabIndex = 0;
            this.PgTab.Text = "Tabela";
            this.PgTab.UseVisualStyleBackColor = true;
            // 
            // Tab
            // 
            this.Tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab.ColumnCount = 2;
            this.Tab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Tab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.5F));
            this.Tab.Location = new System.Drawing.Point(8, 35);
            this.Tab.Name = "Tab";
            this.Tab.RowCount = 2;
            this.Tab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Tab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Tab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tab.Size = new System.Drawing.Size(418, 147);
            this.Tab.TabIndex = 4;
            // 
            // TabSize
            // 
            this.TabSize.Location = new System.Drawing.Point(8, 8);
            this.TabSize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TabSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.TabSize.Name = "TabSize";
            this.TabSize.Size = new System.Drawing.Size(51, 20);
            this.TabSize.TabIndex = 3;
            this.TabSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TabSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.TabSize.ValueChanged += new System.EventHandler(this.TabSize_ValueChanged);
            // 
            // PgField
            // 
            this.PgField.Controls.Add(this.BoxTab);
            this.PgField.Location = new System.Drawing.Point(4, 22);
            this.PgField.Name = "PgField";
            this.PgField.Padding = new System.Windows.Forms.Padding(3);
            this.PgField.Size = new System.Drawing.Size(563, 242);
            this.PgField.TabIndex = 1;
            this.PgField.Text = "Pole";
            this.PgField.UseVisualStyleBackColor = true;
            // 
            // BoxTab
            // 
            this.BoxTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxTab.Location = new System.Drawing.Point(6, 6);
            this.BoxTab.Multiline = true;
            this.BoxTab.Name = "BoxTab";
            this.BoxTab.Size = new System.Drawing.Size(549, 228);
            this.BoxTab.TabIndex = 0;
            this.BoxTab.TextChanged += new System.EventHandler(this.BoxTab_TextChanged);
            // 
            // Info
            // 
            this.Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Info.Location = new System.Drawing.Point(4, 271);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(401, 44);
            this.Info.TabIndex = 4;
            // 
            // BtnCopy
            // 
            this.BtnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCopy.Location = new System.Drawing.Point(411, 270);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(75, 23);
            this.BtnCopy.TabIndex = 5;
            this.BtnCopy.Text = "Kopiuj";
            this.BtnCopy.UseVisualStyleBackColor = true;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // BtnPaste
            // 
            this.BtnPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPaste.Location = new System.Drawing.Point(492, 270);
            this.BtnPaste.Name = "BtnPaste";
            this.BtnPaste.Size = new System.Drawing.Size(75, 23);
            this.BtnPaste.TabIndex = 6;
            this.BtnPaste.Text = "Wklej";
            this.BtnPaste.UseVisualStyleBackColor = true;
            this.BtnPaste.Click += new System.EventHandler(this.BtnPaste_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(411, 292);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Zapisz";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLoad.Location = new System.Drawing.Point(492, 292);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 8;
            this.BtnLoad.Text = "Wczytaj";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // DlgOpen
            // 
            this.DlgOpen.FileName = "test.csv";
            this.DlgOpen.Filter = "Pliki specjalne (*.csv)|*.csv|Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|" +
    "*.*";
            this.DlgOpen.FilterIndex = 0;
            this.DlgOpen.Title = "Wczytaj z ...";
            // 
            // DlgSave
            // 
            this.DlgSave.FileName = "test.csv";
            this.DlgSave.Filter = "Pliki specjalne (*.csv)|*.csv|Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|" +
    "*.*";
            this.DlgSave.FilterIndex = 0;
            this.DlgSave.Title = "Zapisz jako ...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 317);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnPaste);
            this.Controls.Add(this.BtnCopy);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Tabs);
            this.Name = "Form1";
            this.Text = "Input tables ...";
            this.Tabs.ResumeLayout(false);
            this.PgTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabSize)).EndInit();
            this.PgField.ResumeLayout(false);
            this.PgField.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage PgTab;
        private System.Windows.Forms.TableLayoutPanel Tab;
        private System.Windows.Forms.NumericUpDown TabSize;
        private System.Windows.Forms.TabPage PgField;
        private System.Windows.Forms.TextBox BoxTab;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Button BtnCopy;
        private System.Windows.Forms.Button BtnPaste;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.OpenFileDialog DlgOpen;
        private System.Windows.Forms.SaveFileDialog DlgSave;

    }
}

