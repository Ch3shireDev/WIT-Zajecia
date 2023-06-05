namespace Mnozenie
{
    partial class Product
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
            this.BtnRunT = new System.Windows.Forms.Button();
            this.BtnRunN = new System.Windows.Forms.Button();
            this.TimeT = new System.Windows.Forms.TextBox();
            this.TimeN = new System.Windows.Forms.TextBox();
            this.Generator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRunT
            // 
            this.BtnRunT.Location = new System.Drawing.Point(279, 210);
            this.BtnRunT.Name = "BtnRunT";
            this.BtnRunT.Size = new System.Drawing.Size(75, 23);
            this.BtnRunT.TabIndex = 0;
            this.BtnRunT.Text = "Run &T";
            this.BtnRunT.UseVisualStyleBackColor = true;
            this.BtnRunT.Click += new System.EventHandler(this.BtnRunT_Click);
            // 
            // BtnRunN
            // 
            this.BtnRunN.Location = new System.Drawing.Point(526, 210);
            this.BtnRunN.Name = "BtnRunN";
            this.BtnRunN.Size = new System.Drawing.Size(75, 23);
            this.BtnRunN.TabIndex = 1;
            this.BtnRunN.Text = "Run &N";
            this.BtnRunN.UseVisualStyleBackColor = true;
            this.BtnRunN.Click += new System.EventHandler(this.BtnRunN_Click);
            // 
            // TimeT
            // 
            this.TimeT.Location = new System.Drawing.Point(279, 137);
            this.TimeT.Name = "TimeT";
            this.TimeT.ReadOnly = true;
            this.TimeT.Size = new System.Drawing.Size(104, 20);
            this.TimeT.TabIndex = 2;
            this.TimeT.TabStop = false;
            // 
            // TimeN
            // 
            this.TimeN.Location = new System.Drawing.Point(526, 137);
            this.TimeN.Name = "TimeN";
            this.TimeN.ReadOnly = true;
            this.TimeN.Size = new System.Drawing.Size(104, 20);
            this.TimeN.TabIndex = 3;
            this.TimeN.TabStop = false;
            // 
            // Generator
            // 
            this.Generator.Location = new System.Drawing.Point(408, 47);
            this.Generator.Name = "Generator";
            this.Generator.Size = new System.Drawing.Size(75, 23);
            this.Generator.TabIndex = 4;
            this.Generator.Text = "&Generuj";
            this.Generator.UseVisualStyleBackColor = true;
            this.Generator.Click += new System.EventHandler(this.Generator_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 266);
            this.Controls.Add(this.Generator);
            this.Controls.Add(this.TimeN);
            this.Controls.Add(this.TimeT);
            this.Controls.Add(this.BtnRunN);
            this.Controls.Add(this.BtnRunT);
            this.Name = "Product";
            this.Text = "Mno¿enie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRunT;
        private System.Windows.Forms.Button BtnRunN;
        private System.Windows.Forms.TextBox TimeT;
        private System.Windows.Forms.TextBox TimeN;
        private System.Windows.Forms.Button Generator;
    }
}

