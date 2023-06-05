namespace TotalBasic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TbData = new System.Windows.Forms.TextBox();
            this.TbResult = new System.Windows.Forms.TextBox();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbData
            // 
            this.TbData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TbData.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TbData.Location = new System.Drawing.Point(10, 12);
            this.TbData.Multiline = true;
            this.TbData.Name = "TbData";
            this.TbData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbData.Size = new System.Drawing.Size(102, 237);
            this.TbData.TabIndex = 0;
            this.TbData.Text = resources.GetString("TbData.Text");
            this.TbData.WordWrap = false;
            // 
            // TbResult
            // 
            this.TbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbResult.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TbResult.Location = new System.Drawing.Point(208, 12);
            this.TbResult.Multiline = true;
            this.TbResult.Name = "TbResult";
            this.TbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbResult.Size = new System.Drawing.Size(413, 237);
            this.TbResult.TabIndex = 1;
            this.TbResult.WordWrap = false;
            // 
            // BtnConvert
            // 
            this.BtnConvert.Location = new System.Drawing.Point(127, 12);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(75, 23);
            this.BtnConvert.TabIndex = 2;
            this.BtnConvert.Text = "Konwertuj";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 261);
            this.Controls.Add(this.BtnConvert);
            this.Controls.Add(this.TbResult);
            this.Controls.Add(this.TbData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbData;
        private System.Windows.Forms.TextBox TbResult;
        private System.Windows.Forms.Button BtnConvert;
    }
}

