namespace Steganography
{
    partial class Steganography
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnEncode = new System.Windows.Forms.Button();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnDecode = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BoxImage = new System.Windows.Forms.PictureBox();
            this.EdText = new System.Windows.Forms.TextBox();
            this.DlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.DlgSave = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.BtnEncode);
            this.panel1.Controls.Add(this.BtnLoad);
            this.panel1.Controls.Add(this.BtnDecode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 54);
            this.panel1.TabIndex = 2;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSave.Location = new System.Drawing.Point(629, 19);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Zapisz";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnEncode
            // 
            this.BtnEncode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEncode.Location = new System.Drawing.Point(442, 19);
            this.BtnEncode.Name = "BtnEncode";
            this.BtnEncode.Size = new System.Drawing.Size(75, 23);
            this.BtnEncode.TabIndex = 2;
            this.BtnEncode.Text = "Zakoduj";
            this.BtnEncode.UseVisualStyleBackColor = true;
            this.BtnEncode.Click += new System.EventHandler(this.BtnEncode_Click);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnLoad.Location = new System.Drawing.Point(255, 19);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 1;
            this.BtnLoad.Text = "Wczytaj";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnDecode
            // 
            this.BtnDecode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDecode.Location = new System.Drawing.Point(68, 19);
            this.BtnDecode.Name = "BtnDecode";
            this.BtnDecode.Size = new System.Drawing.Size(75, 23);
            this.BtnDecode.TabIndex = 0;
            this.BtnDecode.Text = "Odkoduj";
            this.BtnDecode.UseVisualStyleBackColor = true;
            this.BtnDecode.Click += new System.EventHandler(this.BtnDecode_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BoxImage);
            this.panel2.Controls.Add(this.EdText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 396);
            this.panel2.TabIndex = 3;
            // 
            // BoxImage
            // 
            this.BoxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoxImage.Location = new System.Drawing.Point(0, 0);
            this.BoxImage.Name = "BoxImage";
            this.BoxImage.Padding = new System.Windows.Forms.Padding(4);
            this.BoxImage.Size = new System.Drawing.Size(507, 396);
            this.BoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BoxImage.TabIndex = 3;
            this.BoxImage.TabStop = false;
            // 
            // EdText
            // 
            this.EdText.Dock = System.Windows.Forms.DockStyle.Right;
            this.EdText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdText.Location = new System.Drawing.Point(507, 0);
            this.EdText.Margin = new System.Windows.Forms.Padding(4);
            this.EdText.Multiline = true;
            this.EdText.Name = "EdText";
            this.EdText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EdText.Size = new System.Drawing.Size(263, 396);
            this.EdText.TabIndex = 2;
            this.EdText.Text = "Zażółć gęślą jaźń";
            // 
            // DlgOpen
            // 
            this.DlgOpen.DefaultExt = "bmp";
            this.DlgOpen.Filter = "Pliki BMP (*.bmp)|*.bmp|Pliki PNG (*.png)|*.png";
            this.DlgOpen.ShowReadOnly = true;
            this.DlgOpen.Title = "Wczytaj obrazek ...";
            // 
            // DlgSave
            // 
            this.DlgSave.DefaultExt = "bmp";
            this.DlgSave.Filter = "Pliki BMP (*.bmp)|*.bmp|Pliki PNG (*.png)|*.png";
            this.DlgSave.Title = "Zapisz obrazek ...";
            // 
            // Steganography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Steganography";
            this.Text = "Steganografia ...";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnEncode;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button BtnDecode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox BoxImage;
        private System.Windows.Forms.TextBox EdText;
        private System.Windows.Forms.OpenFileDialog DlgOpen;
        private System.Windows.Forms.SaveFileDialog DlgSave;
    }
}

