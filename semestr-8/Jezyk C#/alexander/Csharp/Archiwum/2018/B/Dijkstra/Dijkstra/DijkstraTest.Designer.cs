namespace Dijkstra
{
    partial class DijkstraTest
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
            this.EdSource = new System.Windows.Forms.TextBox();
            this.EdResult = new System.Windows.Forms.TextBox();
            this.BtnRead = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.DlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // EdSource
            // 
            this.EdSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdSource.Location = new System.Drawing.Point(12, 12);
            this.EdSource.Multiline = true;
            this.EdSource.Name = "EdSource";
            this.EdSource.Size = new System.Drawing.Size(544, 425);
            this.EdSource.TabIndex = 0;
            // 
            // EdResult
            // 
            this.EdResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdResult.Location = new System.Drawing.Point(562, 12);
            this.EdResult.Multiline = true;
            this.EdResult.Name = "EdResult";
            this.EdResult.ReadOnly = true;
            this.EdResult.Size = new System.Drawing.Size(126, 425);
            this.EdResult.TabIndex = 1;
            // 
            // BtnRead
            // 
            this.BtnRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRead.Location = new System.Drawing.Point(694, 12);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(75, 23);
            this.BtnRead.TabIndex = 2;
            this.BtnRead.Text = "Wczytaj";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCalculate.Location = new System.Drawing.Point(694, 49);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 3;
            this.BtnCalculate.Text = "Oblicz";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // DlgOpen
            // 
            this.DlgOpen.DefaultExt = "txt";
            this.DlgOpen.Filter = "Pliki tekstowe (*.txt)|*.txt";
            this.DlgOpen.Title = "Wskaż plik ...";
            // 
            // DijkstraTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 449);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.EdResult);
            this.Controls.Add(this.EdSource);
            this.Name = "DijkstraTest";
            this.Text = "Dijkstra tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EdSource;
        private System.Windows.Forms.TextBox EdResult;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.OpenFileDialog DlgOpen;
    }
}

