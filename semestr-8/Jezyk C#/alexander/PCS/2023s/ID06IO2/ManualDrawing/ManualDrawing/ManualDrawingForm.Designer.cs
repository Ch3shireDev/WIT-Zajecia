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
            this.PnlLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlList = new System.Windows.Forms.Panel();
            this.LbShapes = new System.Windows.Forms.ListBox();
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDn = new System.Windows.Forms.Button();
            this.BtnUp = new System.Windows.Forms.Button();
            this.PnlParameters = new System.Windows.Forms.Panel();
            this.LblParameters = new System.Windows.Forms.Label();
            this.TbParameters = new System.Windows.Forms.TextBox();
            this.PnlShapes = new System.Windows.Forms.Panel();
            this.LblShapes = new System.Windows.Forms.Label();
            this.CbShapes = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PbImage = new System.Windows.Forms.PictureBox();
            this.PnlLeft.SuspendLayout();
            this.PnlList.SuspendLayout();
            this.PnlButtons.SuspendLayout();
            this.PnlParameters.SuspendLayout();
            this.PnlShapes.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlLeft
            // 
            this.PnlLeft.Controls.Add(this.panel1);
            this.PnlLeft.Controls.Add(this.PnlList);
            this.PnlLeft.Controls.Add(this.PnlButtons);
            this.PnlLeft.Controls.Add(this.PnlParameters);
            this.PnlLeft.Controls.Add(this.PnlShapes);
            this.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLeft.Location = new System.Drawing.Point(0, 0);
            this.PnlLeft.Name = "PnlLeft";
            this.PnlLeft.Padding = new System.Windows.Forms.Padding(8);
            this.PnlLeft.Size = new System.Drawing.Size(179, 510);
            this.PnlLeft.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(172, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 6;
            // 
            // PnlList
            // 
            this.PnlList.Controls.Add(this.LbShapes);
            this.PnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlList.Location = new System.Drawing.Point(8, 86);
            this.PnlList.Name = "PnlList";
            this.PnlList.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.PnlList.Size = new System.Drawing.Size(163, 360);
            this.PnlList.TabIndex = 5;
            // 
            // LbShapes
            // 
            this.LbShapes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbShapes.FormattingEnabled = true;
            this.LbShapes.Location = new System.Drawing.Point(0, 8);
            this.LbShapes.Name = "LbShapes";
            this.LbShapes.Size = new System.Drawing.Size(163, 344);
            this.LbShapes.TabIndex = 2;
            this.LbShapes.SelectedValueChanged += new System.EventHandler(this.LbShapes_SelectedValueChanged);
            // 
            // PnlButtons
            // 
            this.PnlButtons.Controls.Add(this.BtnRemove);
            this.PnlButtons.Controls.Add(this.BtnAdd);
            this.PnlButtons.Controls.Add(this.BtnDn);
            this.PnlButtons.Controls.Add(this.BtnUp);
            this.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlButtons.Location = new System.Drawing.Point(8, 446);
            this.PnlButtons.Name = "PnlButtons";
            this.PnlButtons.Size = new System.Drawing.Size(163, 56);
            this.PnlButtons.TabIndex = 4;
            // 
            // BtnRemove
            // 
            this.BtnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRemove.Location = new System.Drawing.Point(45, 28);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(73, 28);
            this.BtnRemove.TabIndex = 7;
            this.BtnRemove.Text = "&Usuń";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdd.Location = new System.Drawing.Point(45, 0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(73, 28);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "&Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDn
            // 
            this.BtnDn.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnDn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnDn.Location = new System.Drawing.Point(118, 0);
            this.BtnDn.Name = "BtnDn";
            this.BtnDn.Size = new System.Drawing.Size(45, 56);
            this.BtnDn.TabIndex = 5;
            this.BtnDn.Text = "▼";
            this.BtnDn.UseVisualStyleBackColor = true;
            this.BtnDn.Click += new System.EventHandler(this.BtnDn_Click);
            // 
            // BtnUp
            // 
            this.BtnUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnUp.Location = new System.Drawing.Point(0, 0);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Size = new System.Drawing.Size(45, 56);
            this.BtnUp.TabIndex = 4;
            this.BtnUp.Text = "▲";
            this.BtnUp.UseVisualStyleBackColor = true;
            this.BtnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // PnlParameters
            // 
            this.PnlParameters.Controls.Add(this.LblParameters);
            this.PnlParameters.Controls.Add(this.TbParameters);
            this.PnlParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlParameters.Location = new System.Drawing.Point(8, 47);
            this.PnlParameters.Name = "PnlParameters";
            this.PnlParameters.Size = new System.Drawing.Size(163, 39);
            this.PnlParameters.TabIndex = 1;
            // 
            // LblParameters
            // 
            this.LblParameters.AutoSize = true;
            this.LblParameters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblParameters.Location = new System.Drawing.Point(0, 6);
            this.LblParameters.Name = "LblParameters";
            this.LblParameters.Size = new System.Drawing.Size(57, 13);
            this.LblParameters.TabIndex = 3;
            this.LblParameters.Text = "&Parametry:";
            // 
            // TbParameters
            // 
            this.TbParameters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TbParameters.Location = new System.Drawing.Point(0, 19);
            this.TbParameters.Name = "TbParameters";
            this.TbParameters.Size = new System.Drawing.Size(163, 20);
            this.TbParameters.TabIndex = 2;
            this.TbParameters.TextChanged += new System.EventHandler(this.CbShapes_SelectedValueChanged);
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
            this.LblShapes.Size = new System.Drawing.Size(48, 13);
            this.LblShapes.TabIndex = 1;
            this.LblShapes.Text = "&Kształty:";
            this.LblShapes.Enter += new System.EventHandler(this.LblShapes_Enter);
            // 
            // CbShapes
            // 
            this.CbShapes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CbShapes.FormattingEnabled = true;
            this.CbShapes.Location = new System.Drawing.Point(0, 18);
            this.CbShapes.Name = "CbShapes";
            this.CbShapes.Size = new System.Drawing.Size(163, 21);
            this.CbShapes.TabIndex = 0;
            this.CbShapes.SelectedValueChanged += new System.EventHandler(this.CbShapes_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.PbImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(179, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.panel2.Size = new System.Drawing.Size(910, 510);
            this.panel2.TabIndex = 1;
            // 
            // PbImage
            // 
            this.PbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbImage.Location = new System.Drawing.Point(0, 8);
            this.PbImage.Name = "PbImage";
            this.PbImage.Size = new System.Drawing.Size(902, 494);
            this.PbImage.TabIndex = 0;
            this.PbImage.TabStop = false;
            // 
            // ManualDrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PnlLeft);
            this.Name = "ManualDrawingForm";
            this.Text = "`";
            this.PnlLeft.ResumeLayout(false);
            this.PnlList.ResumeLayout(false);
            this.PnlButtons.ResumeLayout(false);
            this.PnlParameters.ResumeLayout(false);
            this.PnlParameters.PerformLayout();
            this.PnlShapes.ResumeLayout(false);
            this.PnlShapes.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlLeft;
        private System.Windows.Forms.Panel PnlParameters;
        private System.Windows.Forms.Label LblParameters;
        private System.Windows.Forms.TextBox TbParameters;
        private System.Windows.Forms.Panel PnlShapes;
        private System.Windows.Forms.Label LblShapes;
        private System.Windows.Forms.ComboBox CbShapes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PbImage;
        private System.Windows.Forms.Panel PnlList;
        private System.Windows.Forms.ListBox LbShapes;
        private System.Windows.Forms.Panel PnlButtons;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDn;
        private System.Windows.Forms.Button BtnUp;
        private System.Windows.Forms.Panel panel1;
    }
}

