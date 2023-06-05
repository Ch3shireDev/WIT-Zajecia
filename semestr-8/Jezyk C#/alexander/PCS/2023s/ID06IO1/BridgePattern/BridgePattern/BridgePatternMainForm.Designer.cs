namespace BridgePattern
{
    partial class BridgePatternMainForm
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
            this.ScVertical = new System.Windows.Forms.SplitContainer();
            this.LbShapes = new System.Windows.Forms.ListBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TbParameters = new System.Windows.Forms.TextBox();
            this.LblParameters = new System.Windows.Forms.Label();
            this.CbShapeKinds = new System.Windows.Forms.ComboBox();
            this.LblShapeKinds = new System.Windows.Forms.Label();
            this.ScRight = new System.Windows.Forms.SplitContainer();
            this.PbImage = new System.Windows.Forms.PictureBox();
            this.TbXml = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScVertical)).BeginInit();
            this.ScVertical.Panel1.SuspendLayout();
            this.ScVertical.Panel2.SuspendLayout();
            this.ScVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScRight)).BeginInit();
            this.ScRight.Panel1.SuspendLayout();
            this.ScRight.Panel2.SuspendLayout();
            this.ScRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ScVertical
            // 
            this.ScVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScVertical.Location = new System.Drawing.Point(0, 0);
            this.ScVertical.Name = "ScVertical";
            // 
            // ScVertical.Panel1
            // 
            this.ScVertical.Panel1.Controls.Add(this.LbShapes);
            this.ScVertical.Panel1.Controls.Add(this.BtnAdd);
            this.ScVertical.Panel1.Controls.Add(this.TbParameters);
            this.ScVertical.Panel1.Controls.Add(this.LblParameters);
            this.ScVertical.Panel1.Controls.Add(this.CbShapeKinds);
            this.ScVertical.Panel1.Controls.Add(this.LblShapeKinds);
            this.ScVertical.Panel1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 8);
            this.ScVertical.Panel1MinSize = 200;
            // 
            // ScVertical.Panel2
            // 
            this.ScVertical.Panel2.Controls.Add(this.ScRight);
            this.ScVertical.Panel2.Padding = new System.Windows.Forms.Padding(0, 13, 8, 8);
            this.ScVertical.Panel2MinSize = 200;
            this.ScVertical.Size = new System.Drawing.Size(1002, 412);
            this.ScVertical.SplitterDistance = 250;
            this.ScVertical.SplitterWidth = 12;
            this.ScVertical.TabIndex = 0;
            // 
            // LbShapes
            // 
            this.LbShapes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbShapes.FormattingEnabled = true;
            this.LbShapes.Location = new System.Drawing.Point(8, 90);
            this.LbShapes.Name = "LbShapes";
            this.LbShapes.Size = new System.Drawing.Size(242, 314);
            this.LbShapes.TabIndex = 5;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdd.Location = new System.Drawing.Point(8, 67);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(242, 23);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TbParameters
            // 
            this.TbParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbParameters.Location = new System.Drawing.Point(8, 47);
            this.TbParameters.Name = "TbParameters";
            this.TbParameters.Size = new System.Drawing.Size(242, 20);
            this.TbParameters.TabIndex = 3;
            // 
            // LblParameters
            // 
            this.LblParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblParameters.Location = new System.Drawing.Point(8, 34);
            this.LblParameters.Name = "LblParameters";
            this.LblParameters.Size = new System.Drawing.Size(242, 13);
            this.LblParameters.TabIndex = 2;
            this.LblParameters.Text = "Parameters:";
            // 
            // CbShapeKinds
            // 
            this.CbShapeKinds.Dock = System.Windows.Forms.DockStyle.Top;
            this.CbShapeKinds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbShapeKinds.FormattingEnabled = true;
            this.CbShapeKinds.Location = new System.Drawing.Point(8, 13);
            this.CbShapeKinds.Name = "CbShapeKinds";
            this.CbShapeKinds.Size = new System.Drawing.Size(242, 21);
            this.CbShapeKinds.TabIndex = 1;
            // 
            // LblShapeKinds
            // 
            this.LblShapeKinds.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblShapeKinds.Location = new System.Drawing.Point(8, 0);
            this.LblShapeKinds.Name = "LblShapeKinds";
            this.LblShapeKinds.Size = new System.Drawing.Size(242, 13);
            this.LblShapeKinds.TabIndex = 0;
            this.LblShapeKinds.Text = "Shape kinds:";
            // 
            // ScRight
            // 
            this.ScRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScRight.Location = new System.Drawing.Point(0, 13);
            this.ScRight.Name = "ScRight";
            this.ScRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScRight.Panel1
            // 
            this.ScRight.Panel1.Controls.Add(this.PbImage);
            this.ScRight.Panel1.Resize += new System.EventHandler(this.splitContainer1_Panel1_Resize);
            this.ScRight.Panel1MinSize = 150;
            // 
            // ScRight.Panel2
            // 
            this.ScRight.Panel2.Controls.Add(this.TbXml);
            this.ScRight.Panel2MinSize = 150;
            this.ScRight.Size = new System.Drawing.Size(732, 391);
            this.ScRight.SplitterDistance = 219;
            this.ScRight.TabIndex = 0;
            // 
            // PbImage
            // 
            this.PbImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbImage.Location = new System.Drawing.Point(0, 0);
            this.PbImage.Name = "PbImage";
            this.PbImage.Size = new System.Drawing.Size(732, 219);
            this.PbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbImage.TabIndex = 0;
            this.PbImage.TabStop = false;
            // 
            // TbXml
            // 
            this.TbXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbXml.Location = new System.Drawing.Point(0, 0);
            this.TbXml.Multiline = true;
            this.TbXml.Name = "TbXml";
            this.TbXml.Size = new System.Drawing.Size(732, 168);
            this.TbXml.TabIndex = 0;
            // 
            // BridgePatternMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 412);
            this.Controls.Add(this.ScVertical);
            this.Name = "BridgePatternMainForm";
            this.Text = "Bridge Pattern";
            this.ScVertical.Panel1.ResumeLayout(false);
            this.ScVertical.Panel1.PerformLayout();
            this.ScVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScVertical)).EndInit();
            this.ScVertical.ResumeLayout(false);
            this.ScRight.Panel1.ResumeLayout(false);
            this.ScRight.Panel2.ResumeLayout(false);
            this.ScRight.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScRight)).EndInit();
            this.ScRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer ScVertical;
        private System.Windows.Forms.ListBox LbShapes;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TbParameters;
        private System.Windows.Forms.Label LblParameters;
        private System.Windows.Forms.ComboBox CbShapeKinds;
        private System.Windows.Forms.Label LblShapeKinds;
        private System.Windows.Forms.SplitContainer ScRight;
        private System.Windows.Forms.PictureBox PbImage;
        private System.Windows.Forms.TextBox TbXml;
    }
}

