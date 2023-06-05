namespace UlamClasterTest
{
    partial class UlamClusterForm
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
            this.Box = new System.Windows.Forms.PictureBox();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.EdNumber = new System.Windows.Forms.TextBox();
            this.BtnCalc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Box.Location = new System.Drawing.Point(0, 0);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(740, 326);
            this.Box.TabIndex = 0;
            this.Box.TabStop = false;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.BtnCalc);
            this.LeftPanel.Controls.Add(this.EdNumber);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.LeftPanel.Location = new System.Drawing.Point(623, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(117, 326);
            this.LeftPanel.TabIndex = 1;
            // 
            // EdNumber
            // 
            this.EdNumber.Location = new System.Drawing.Point(12, 12);
            this.EdNumber.Name = "EdNumber";
            this.EdNumber.Size = new System.Drawing.Size(93, 20);
            this.EdNumber.TabIndex = 0;
            this.EdNumber.TextChanged += new System.EventHandler(this.EdNumber_TextChanged);
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(12, 38);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(93, 23);
            this.BtnCalc.TabIndex = 1;
            this.BtnCalc.Text = "Rysuj";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // UlamClusterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 326);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.Box);
            this.Name = "UlamClusterForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Box;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.TextBox EdNumber;
    }
}

