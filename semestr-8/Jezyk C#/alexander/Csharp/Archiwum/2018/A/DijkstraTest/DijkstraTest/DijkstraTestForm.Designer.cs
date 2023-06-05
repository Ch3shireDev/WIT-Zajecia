namespace DijkstraTest
{
    partial class DijkstraTestForm
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
            this.EdData = new System.Windows.Forms.TextBox();
            this.EdResult = new System.Windows.Forms.TextBox();
            this.BtnRead = new System.Windows.Forms.Button();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.DlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // EdData
            // 
            this.EdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdData.Location = new System.Drawing.Point(12, 12);
            this.EdData.Multiline = true;
            this.EdData.Name = "EdData";
            this.EdData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EdData.Size = new System.Drawing.Size(451, 347);
            this.EdData.TabIndex = 0;
            this.EdData.Text = "A B 2\r\nA C 1\r\nA D 6\r\nB D 3\r\nC D 4";
            // 
            // EdResult
            // 
            this.EdResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdResult.Location = new System.Drawing.Point(469, 12);
            this.EdResult.Multiline = true;
            this.EdResult.Name = "EdResult";
            this.EdResult.ReadOnly = true;
            this.EdResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EdResult.Size = new System.Drawing.Size(156, 318);
            this.EdResult.TabIndex = 1;
            // 
            // BtnRead
            // 
            this.BtnRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRead.Location = new System.Drawing.Point(469, 336);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(75, 23);
            this.BtnRead.TabIndex = 2;
            this.BtnRead.Text = "Wczytaj";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // BtnCalc
            // 
            this.BtnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCalc.Location = new System.Drawing.Point(550, 336);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtnCalc.TabIndex = 3;
            this.BtnCalc.Text = "Oblicz";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // DlgOpen
            // 
            this.DlgOpen.DefaultExt = "txt";
            this.DlgOpen.Filter = "Pliki tekstowe (*.txt)|*.txt";
            this.DlgOpen.Title = "Wskaż plik ...";
            // 
            // DijkstraTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 371);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.EdResult);
            this.Controls.Add(this.EdData);
            this.Name = "DijkstraTestForm";
            this.Text = "Dijkstra test ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EdData;
        private System.Windows.Forms.TextBox EdResult;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.OpenFileDialog DlgOpen;
    }
}

