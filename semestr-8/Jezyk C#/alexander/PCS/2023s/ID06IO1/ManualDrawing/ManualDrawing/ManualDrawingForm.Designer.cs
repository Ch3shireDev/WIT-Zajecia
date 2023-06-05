namespace ManualDrawing
{
    partial class ManualDrawingForm
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
            this.PnlToolbox = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbShapes = new System.Windows.Forms.ListBox();
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnDn = new System.Windows.Forms.Button();
            this.BtnUp = new System.Windows.Forms.Button();
            this.PnlParamiters = new System.Windows.Forms.Panel();
            this.LblParamiters = new System.Windows.Forms.Label();
            this.TbParamiters = new System.Windows.Forms.TextBox();
            this.PnlShapes = new System.Windows.Forms.Panel();
            this.LblShapes = new System.Windows.Forms.Label();
            this.CbShapes = new System.Windows.Forms.ComboBox();
            this.PnlImage = new System.Windows.Forms.Panel();
            this.PbImage = new System.Windows.Forms.PictureBox();
            this.PnlToolbox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PnlButtons.SuspendLayout();
            this.PnlParamiters.SuspendLayout();
            this.PnlShapes.SuspendLayout();
            this.PnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlToolbox
            // 
            this.PnlToolbox.Controls.Add(this.panel1);
            this.PnlToolbox.Controls.Add(this.PnlButtons);
            this.PnlToolbox.Controls.Add(this.PnlParamiters);
            this.PnlToolbox.Controls.Add(this.PnlShapes);
            this.PnlToolbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlToolbox.Location = new System.Drawing.Point(0, 0);
            this.PnlToolbox.Name = "PnlToolbox";
            this.PnlToolbox.Padding = new System.Windows.Forms.Padding(8);
            this.PnlToolbox.Size = new System.Drawing.Size(179, 377);
            this.PnlToolbox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LbShapes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 86);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.panel1.Size = new System.Drawing.Size(163, 229);
            this.panel1.TabIndex = 5;
            // 
            // LbShapes
            // 
            this.LbShapes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbShapes.FormattingEnabled = true;
            this.LbShapes.Location = new System.Drawing.Point(0, 8);
            this.LbShapes.Name = "LbShapes";
            this.LbShapes.Size = new System.Drawing.Size(163, 213);
            this.LbShapes.TabIndex = 0;
            this.LbShapes.SelectedValueChanged += new System.EventHandler(this.LbShapes_SelectedValueChanged);
            // 
            // PnlButtons
            // 
            this.PnlButtons.Controls.Add(this.BtnAdd);
            this.PnlButtons.Controls.Add(this.BtnRemove);
            this.PnlButtons.Controls.Add(this.BtnDn);
            this.PnlButtons.Controls.Add(this.BtnUp);
            this.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlButtons.Location = new System.Drawing.Point(8, 315);
            this.PnlButtons.Name = "PnlButtons";
            this.PnlButtons.Size = new System.Drawing.Size(163, 54);
            this.PnlButtons.TabIndex = 4;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAdd.Location = new System.Drawing.Point(35, 31);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(93, 23);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRemove.Location = new System.Drawing.Point(35, 0);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(93, 23);
            this.BtnRemove.TabIndex = 6;
            this.BtnRemove.Text = "Usuń";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnDn
            // 
            this.BtnDn.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnDn.Location = new System.Drawing.Point(128, 0);
            this.BtnDn.Name = "BtnDn";
            this.BtnDn.Size = new System.Drawing.Size(35, 54);
            this.BtnDn.TabIndex = 5;
            this.BtnDn.Text = "▼";
            this.BtnDn.UseVisualStyleBackColor = true;
            this.BtnDn.Click += new System.EventHandler(this.BtnDn_Click);
            // 
            // BtnUp
            // 
            this.BtnUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnUp.Location = new System.Drawing.Point(0, 0);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Size = new System.Drawing.Size(35, 54);
            this.BtnUp.TabIndex = 4;
            this.BtnUp.Text = "▲";
            this.BtnUp.UseVisualStyleBackColor = true;
            this.BtnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // PnlParamiters
            // 
            this.PnlParamiters.Controls.Add(this.LblParamiters);
            this.PnlParamiters.Controls.Add(this.TbParamiters);
            this.PnlParamiters.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlParamiters.Location = new System.Drawing.Point(8, 47);
            this.PnlParamiters.Name = "PnlParamiters";
            this.PnlParamiters.Size = new System.Drawing.Size(163, 39);
            this.PnlParamiters.TabIndex = 1;
            // 
            // LblParamiters
            // 
            this.LblParamiters.AutoSize = true;
            this.LblParamiters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblParamiters.Location = new System.Drawing.Point(0, 6);
            this.LblParamiters.Name = "LblParamiters";
            this.LblParamiters.Size = new System.Drawing.Size(57, 13);
            this.LblParamiters.TabIndex = 3;
            this.LblParamiters.Text = "Parametry:";
            // 
            // TbParamiters
            // 
            this.TbParamiters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TbParamiters.Location = new System.Drawing.Point(0, 19);
            this.TbParamiters.Name = "TbParamiters";
            this.TbParamiters.Size = new System.Drawing.Size(163, 20);
            this.TbParamiters.TabIndex = 2;
            this.TbParamiters.TextChanged += new System.EventHandler(this.CbShapes_ParametersChanged);
            // 
            // PnlShapes
            // 
            this.PnlShapes.Controls.Add(this.LblShapes);
            this.PnlShapes.Controls.Add(this.CbShapes);
            this.PnlShapes.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlShapes.Location = new System.Drawing.Point(8, 8);
            this.PnlShapes.Name = "PnlShapes";
            this.PnlShapes.Size = new System.Drawing.Size(163, 39);
            this.PnlShapes.TabIndex = 0;
            // 
            // LblShapes
            // 
            this.LblShapes.AutoSize = true;
            this.LblShapes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblShapes.Location = new System.Drawing.Point(0, 5);
            this.LblShapes.Name = "LblShapes";
            this.LblShapes.Size = new System.Drawing.Size(43, 13);
            this.LblShapes.TabIndex = 1;
            this.LblShapes.Text = "Kształt:";
            // 
            // CbShapes
            // 
            this.CbShapes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CbShapes.FormattingEnabled = true;
            this.CbShapes.Location = new System.Drawing.Point(0, 18);
            this.CbShapes.Name = "CbShapes";
            this.CbShapes.Size = new System.Drawing.Size(163, 21);
            this.CbShapes.TabIndex = 0;
            this.CbShapes.SelectedValueChanged += new System.EventHandler(this.CbShapes_ParametersChanged);
            // 
            // PnlImage
            // 
            this.PnlImage.Controls.Add(this.PbImage);
            this.PnlImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlImage.Location = new System.Drawing.Point(179, 0);
            this.PnlImage.Name = "PnlImage";
            this.PnlImage.Padding = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.PnlImage.Size = new System.Drawing.Size(577, 377);
            this.PnlImage.TabIndex = 1;
            // 
            // PbImage
            // 
            this.PbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbImage.Location = new System.Drawing.Point(0, 8);
            this.PbImage.Name = "PbImage";
            this.PbImage.Size = new System.Drawing.Size(569, 361);
            this.PbImage.TabIndex = 0;
            this.PbImage.TabStop = false;
            // 
            // ManualDrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 377);
            this.Controls.Add(this.PnlImage);
            this.Controls.Add(this.PnlToolbox);
            this.Name = "ManualDrawingForm";
            this.Text = "Form1";
            this.PnlToolbox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PnlButtons.ResumeLayout(false);
            this.PnlParamiters.ResumeLayout(false);
            this.PnlParamiters.PerformLayout();
            this.PnlShapes.ResumeLayout(false);
            this.PnlShapes.PerformLayout();
            this.PnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlToolbox;
        private System.Windows.Forms.Panel PnlParamiters;
        private System.Windows.Forms.Label LblParamiters;
        private System.Windows.Forms.TextBox TbParamiters;
        private System.Windows.Forms.Panel PnlShapes;
        private System.Windows.Forms.Label LblShapes;
        private System.Windows.Forms.ComboBox CbShapes;
        private System.Windows.Forms.Panel PnlImage;
        private System.Windows.Forms.PictureBox PbImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox LbShapes;
        private System.Windows.Forms.Panel PnlButtons;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnDn;
        private System.Windows.Forms.Button BtnUp;
    }
}

