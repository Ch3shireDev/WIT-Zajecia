namespace WinFormsApp1
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            UserInputTB = new TextBox();
            UserOutputTB = new TextBox();
            CalculateButton = new Button();
            CalculationProgress = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 0;
            label1.Text = "Liczba elementów ciągu:";
            // 
            // UserInputTB
            // 
            UserInputTB.Location = new Point(155, 6);
            UserInputTB.Name = "UserInputTB";
            UserInputTB.Size = new Size(528, 23);
            UserInputTB.TabIndex = 1;
            UserInputTB.TextChanged += UserInputTB_TextChanged;
            // 
            // UserOutputTB
            // 
            UserOutputTB.Location = new Point(12, 64);
            UserOutputTB.Multiline = true;
            UserOutputTB.Name = "UserOutputTB";
            UserOutputTB.Size = new Size(776, 374);
            UserOutputTB.TabIndex = 2;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(689, 5);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(99, 24);
            CalculateButton.TabIndex = 3;
            CalculateButton.Text = "Oblicz";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // CalculationProgress
            // 
            CalculationProgress.Location = new Point(12, 35);
            CalculationProgress.Name = "CalculationProgress";
            CalculationProgress.Size = new Size(776, 23);
            CalculationProgress.TabIndex = 4;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CalculationProgress);
            Controls.Add(CalculateButton);
            Controls.Add(UserOutputTB);
            Controls.Add(UserInputTB);
            Controls.Add(label1);
            Name = "MainView";
            Text = "Suma ciągu harmonicznego";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private TextBox UserInputTB;
        private TextBox UserOutputTB;
        private Button CalculateButton;
        private ProgressBar CalculationProgress;

        TextBox NumberOfFields { get; set; }
    }
}