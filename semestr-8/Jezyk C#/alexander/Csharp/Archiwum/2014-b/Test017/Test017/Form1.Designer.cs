namespace Test017
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
            this.ATab = new System.Windows.Forms.TableLayoutPanel();
            this.BTab = new System.Windows.Forms.TableLayoutPanel();
            this.CTab = new System.Windows.Forms.TableLayoutPanel();
            this.Operation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ATab
            // 
            this.ATab.ColumnCount = 4;
            this.ATab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ATab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ATab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ATab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ATab.Location = new System.Drawing.Point(12, 12);
            this.ATab.Margin = new System.Windows.Forms.Padding(1);
            this.ATab.Name = "ATab";
            this.ATab.RowCount = 4;
            this.ATab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ATab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ATab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ATab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ATab.Size = new System.Drawing.Size(200, 100);
            this.ATab.TabIndex = 9;
            // 
            // BTab
            // 
            this.BTab.ColumnCount = 4;
            this.BTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BTab.Location = new System.Drawing.Point(227, 12);
            this.BTab.Margin = new System.Windows.Forms.Padding(1);
            this.BTab.Name = "BTab";
            this.BTab.RowCount = 4;
            this.BTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BTab.Size = new System.Drawing.Size(200, 100);
            this.BTab.TabIndex = 10;
            // 
            // CTab
            // 
            this.CTab.ColumnCount = 4;
            this.CTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CTab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CTab.Location = new System.Drawing.Point(120, 141);
            this.CTab.Margin = new System.Windows.Forms.Padding(1);
            this.CTab.Name = "CTab";
            this.CTab.RowCount = 4;
            this.CTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CTab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CTab.Size = new System.Drawing.Size(200, 100);
            this.CTab.TabIndex = 11;
            // 
            // Operation
            // 
            this.Operation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Operation.FormattingEnabled = true;
            this.Operation.Items.AddRange(new object[] {
            "Add",
            "Sub",
            "Mul"});
            this.Operation.Location = new System.Drawing.Point(159, 116);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(121, 21);
            this.Operation.TabIndex = 12;
            this.Operation.SelectedIndexChanged += new System.EventHandler(this.Calculate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 262);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.CTab);
            this.Controls.Add(this.BTab);
            this.Controls.Add(this.ATab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ATab;
        private System.Windows.Forms.TableLayoutPanel BTab;
        private System.Windows.Forms.TableLayoutPanel CTab;
        private System.Windows.Forms.ComboBox Operation;
    }
}

