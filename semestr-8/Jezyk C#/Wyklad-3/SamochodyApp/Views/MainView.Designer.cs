namespace SamochodyApp.Views
{
    partial class MainView
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
            splitContainer1 = new SplitContainer();
            AddonsListBox = new ListBox();
            AddButton = new Button();
            label2 = new Label();
            CarMakesComboBox = new ComboBox();
            label1 = new Label();
            SelectedCarsListBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(AddonsListBox);
            splitContainer1.Panel1.Controls.Add(AddButton);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(CarMakesComboBox);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(SelectedCarsListBox);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // AddonsListBox
            // 
            AddonsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddonsListBox.FormattingEnabled = true;
            AddonsListBox.ItemHeight = 15;
            AddonsListBox.Location = new Point(3, 84);
            AddonsListBox.Name = "AddonsListBox";
            AddonsListBox.SelectionMode = SelectionMode.MultiSimple;
            AddonsListBox.Size = new Size(260, 334);
            AddonsListBox.TabIndex = 4;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddButton.Location = new Point(3, 420);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(260, 23);
            AddButton.TabIndex = 3;
            AddButton.Text = "AddCarButton";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(3, 61);
            label2.Name = "label2";
            label2.Size = new Size(257, 20);
            label2.TabIndex = 2;
            label2.Text = "Dodatki";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // CarMakesComboBox
            // 
            CarMakesComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CarMakesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CarMakesComboBox.FormattingEnabled = true;
            CarMakesComboBox.Location = new Point(3, 35);
            CarMakesComboBox.Margin = new Padding(10);
            CarMakesComboBox.Name = "CarMakesComboBox";
            CarMakesComboBox.Size = new Size(260, 23);
            CarMakesComboBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(260, 23);
            label1.TabIndex = 0;
            label1.Text = "Marka samochodu";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // SelectedCarsListBox
            // 
            SelectedCarsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedCarsListBox.FormattingEnabled = true;
            SelectedCarsListBox.ItemHeight = 15;
            SelectedCarsListBox.Location = new Point(3, 4);
            SelectedCarsListBox.Name = "SelectedCarsListBox";
            SelectedCarsListBox.Size = new Size(524, 439);
            SelectedCarsListBox.TabIndex = 0;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "MainView";
            Text = "MainView";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label2;
        private ComboBox CarMakesComboBox;
        private Label label1;
        private ListBox AddonsListBox;
        private Button AddButton;
        private ListBox SelectedCarsListBox;
    }
}