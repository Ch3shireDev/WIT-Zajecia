namespace Kalkulator.Views
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
            FirstValueTextBox = new TextBox();
            OperationComboBox = new ComboBox();
            SecondValueTextBox = new TextBox();
            CalculateButton = new Button();
            ResultTextBox = new TextBox();
            SuspendLayout();
            // 
            // FirstValueTextBox
            // 
            FirstValueTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FirstValueTextBox.Location = new Point(12, 12);
            FirstValueTextBox.Name = "FirstValueTextBox";
            FirstValueTextBox.Size = new Size(100, 23);
            FirstValueTextBox.TabIndex = 0;
            FirstValueTextBox.TextChanged += FirstValueTextBox_TextChanged;
            FirstValueTextBox.KeyPress += FirstValueTextBox_TextChanged;
            FirstValueTextBox.PreviewKeyDown += FirstValueTextBox_TextChanged;
            // 
            // OperationComboBox
            // 
            OperationComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OperationComboBox.FormattingEnabled = true;
            OperationComboBox.Location = new Point(118, 12);
            OperationComboBox.Name = "OperationComboBox";
            OperationComboBox.Size = new Size(210, 23);
            OperationComboBox.TabIndex = 1;
            // 
            // SecondValueTextBox
            // 
            SecondValueTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SecondValueTextBox.Location = new Point(334, 12);
            SecondValueTextBox.Name = "SecondValueTextBox";
            SecondValueTextBox.Size = new Size(100, 23);
            SecondValueTextBox.TabIndex = 2;
            SecondValueTextBox.TextChanged += SecondValueTextBox_TextChanged;
            // 
            // CalculateButton
            // 
            CalculateButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CalculateButton.Location = new Point(440, 11);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(80, 23);
            CalculateButton.TabIndex = 3;
            CalculateButton.Text = "Oblicz";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ResultTextBox
            // 
            ResultTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ResultTextBox.Location = new Point(12, 41);
            ResultTextBox.Margin = new Padding(10);
            ResultTextBox.Multiline = true;
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.Size = new Size(508, 302);
            ResultTextBox.TabIndex = 4;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 355);
            Controls.Add(ResultTextBox);
            Controls.Add(CalculateButton);
            Controls.Add(SecondValueTextBox);
            Controls.Add(OperationComboBox);
            Controls.Add(FirstValueTextBox);
            Name = "MainView";
            Text = "MainView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FirstValueTextBox;
        private ComboBox OperationComboBox;
        private TextBox SecondValueTextBox;
        private Button CalculateButton;
        private TextBox ResultTextBox;
    }
}