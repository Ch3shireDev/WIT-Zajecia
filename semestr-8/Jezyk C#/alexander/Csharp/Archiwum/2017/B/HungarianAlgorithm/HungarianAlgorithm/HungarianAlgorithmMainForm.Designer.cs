namespace HungarianAlgorithm
{
    partial class HungarianAlgorithmMainForm
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
            this.Footer = new System.Windows.Forms.Panel();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.Client = new System.Windows.Forms.Panel();
            this.Data = new System.Windows.Forms.TextBox();
            this.Footer.SuspendLayout();
            this.Client.SuspendLayout();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.BtnCalc);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 341);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(479, 45);
            this.Footer.TabIndex = 1;
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(12, 10);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtnCalc.TabIndex = 0;
            this.BtnCalc.Text = "&Calculate";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // Client
            // 
            this.Client.Controls.Add(this.Data);
            this.Client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Client.Location = new System.Drawing.Point(0, 0);
            this.Client.Name = "Client";
            this.Client.Padding = new System.Windows.Forms.Padding(4);
            this.Client.Size = new System.Drawing.Size(479, 341);
            this.Client.TabIndex = 2;
            // 
            // Data
            // 
            this.Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Data.Location = new System.Drawing.Point(4, 4);
            this.Data.Multiline = true;
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(471, 333);
            this.Data.TabIndex = 1;
            this.Data.Text = "\\\tzA\tzB\tzC\tzD\r\np1\t20\t40\t10\t50\r\np2\t100\t80\t30\t40\r\np3\t10\t5\t60\t20\r\np4\t70\t30\t10\t25";
            // 
            // HungarianAlgorithmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 386);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.Footer);
            this.Name = "HungarianAlgorithmMainForm";
            this.Text = "Form1";
            this.Footer.ResumeLayout(false);
            this.Client.ResumeLayout(false);
            this.Client.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Panel Client;
        private System.Windows.Forms.TextBox Data;
    }
}

