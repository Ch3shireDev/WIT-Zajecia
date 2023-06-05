namespace BridgeTest
{
    partial class BridgeShowForm
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
            this.CbFigureKinds = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LbFigures = new System.Windows.Forms.ListBox();
            this.TxtParameters = new System.Windows.Forms.TextBox();
            this.PnImage = new System.Windows.Forms.Panel();
            this.PbFigures = new System.Windows.Forms.PictureBox();
            this.TxtJsonBox = new System.Windows.Forms.TextBox();
            this.PnImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbFigures)).BeginInit();
            this.SuspendLayout();
            // 
            // CbFigureKinds
            // 
            this.CbFigureKinds.FormattingEnabled = true;
            this.CbFigureKinds.Location = new System.Drawing.Point(12, 12);
            this.CbFigureKinds.Name = "CbFigureKinds";
            this.CbFigureKinds.Size = new System.Drawing.Size(121, 21);
            this.CbFigureKinds.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 65);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LbFigures
            // 
            this.LbFigures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbFigures.FormattingEnabled = true;
            this.LbFigures.Location = new System.Drawing.Point(12, 95);
            this.LbFigures.Name = "LbFigures";
            this.LbFigures.Size = new System.Drawing.Size(120, 277);
            this.LbFigures.TabIndex = 2;
            // 
            // TxtParameters
            // 
            this.TxtParameters.Location = new System.Drawing.Point(12, 39);
            this.TxtParameters.Name = "TxtParameters";
            this.TxtParameters.Size = new System.Drawing.Size(120, 20);
            this.TxtParameters.TabIndex = 4;
            // 
            // PnImage
            // 
            this.PnImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnImage.Controls.Add(this.PbFigures);
            this.PnImage.Location = new System.Drawing.Point(139, 12);
            this.PnImage.Name = "PnImage";
            this.PnImage.Size = new System.Drawing.Size(435, 229);
            this.PnImage.TabIndex = 5;
            // 
            // PbFigures
            // 
            this.PbFigures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbFigures.Location = new System.Drawing.Point(0, 0);
            this.PbFigures.Name = "PbFigures";
            this.PbFigures.Size = new System.Drawing.Size(435, 229);
            this.PbFigures.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbFigures.TabIndex = 4;
            this.PbFigures.TabStop = false;
            // 
            // TxtJsonBox
            // 
            this.TxtJsonBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtJsonBox.Location = new System.Drawing.Point(139, 247);
            this.TxtJsonBox.Multiline = true;
            this.TxtJsonBox.Name = "TxtJsonBox";
            this.TxtJsonBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtJsonBox.Size = new System.Drawing.Size(435, 130);
            this.TxtJsonBox.TabIndex = 6;
            this.TxtJsonBox.WordWrap = false;
            // 
            // BridgeShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 389);
            this.Controls.Add(this.TxtJsonBox);
            this.Controls.Add(this.PnImage);
            this.Controls.Add(this.TxtParameters);
            this.Controls.Add(this.LbFigures);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CbFigureKinds);
            this.Name = "BridgeShowForm";
            this.Text = "Figure Bridges ...";
            this.PnImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbFigures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbFigureKinds;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ListBox LbFigures;
        private System.Windows.Forms.TextBox TxtParameters;
        private System.Windows.Forms.Panel PnImage;
        private System.Windows.Forms.PictureBox PbFigures;
        private System.Windows.Forms.TextBox TxtJsonBox;
    }
}

