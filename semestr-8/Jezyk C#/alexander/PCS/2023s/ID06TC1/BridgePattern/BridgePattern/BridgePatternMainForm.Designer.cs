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
            this.CbShapeKinds = new System.Windows.Forms.ComboBox();
            this.ScRight = new System.Windows.Forms.SplitContainer();
            this.TbXml = new System.Windows.Forms.TextBox();
            this.PbDraw = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScVertical)).BeginInit();
            this.ScVertical.Panel1.SuspendLayout();
            this.ScVertical.Panel2.SuspendLayout();
            this.ScVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScRight)).BeginInit();
            this.ScRight.Panel1.SuspendLayout();
            this.ScRight.Panel2.SuspendLayout();
            this.ScRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbDraw)).BeginInit();
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
            this.ScVertical.Panel1.Controls.Add(this.CbShapeKinds);
            this.ScVertical.Panel1.Padding = new System.Windows.Forms.Padding(4);
            // 
            // ScVertical.Panel2
            // 
            this.ScVertical.Panel2.Controls.Add(this.ScRight);
            this.ScVertical.Size = new System.Drawing.Size(935, 430);
            this.ScVertical.SplitterDistance = 311;
            this.ScVertical.SplitterWidth = 12;
            this.ScVertical.TabIndex = 4;
            // 
            // LbShapes
            // 
            this.LbShapes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbShapes.FormattingEnabled = true;
            this.LbShapes.Location = new System.Drawing.Point(4, 68);
            this.LbShapes.Name = "LbShapes";
            this.LbShapes.Size = new System.Drawing.Size(303, 358);
            this.LbShapes.TabIndex = 4;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdd.Location = new System.Drawing.Point(4, 45);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(303, 23);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TbParameters
            // 
            this.TbParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbParameters.Location = new System.Drawing.Point(4, 25);
            this.TbParameters.Name = "TbParameters";
            this.TbParameters.Size = new System.Drawing.Size(303, 20);
            this.TbParameters.TabIndex = 2;
            // 
            // CbShapeKinds
            // 
            this.CbShapeKinds.Dock = System.Windows.Forms.DockStyle.Top;
            this.CbShapeKinds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbShapeKinds.FormattingEnabled = true;
            this.CbShapeKinds.Location = new System.Drawing.Point(4, 4);
            this.CbShapeKinds.Name = "CbShapeKinds";
            this.CbShapeKinds.Size = new System.Drawing.Size(303, 21);
            this.CbShapeKinds.TabIndex = 1;
            // 
            // ScRight
            // 
            this.ScRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScRight.Location = new System.Drawing.Point(0, 0);
            this.ScRight.Name = "ScRight";
            this.ScRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScRight.Panel1
            // 
            this.ScRight.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ScRight.Panel1.Controls.Add(this.PbDraw);
            // 
            // ScRight.Panel2
            // 
            this.ScRight.Panel2.Controls.Add(this.TbXml);
            this.ScRight.Size = new System.Drawing.Size(612, 430);
            this.ScRight.SplitterDistance = 206;
            this.ScRight.SplitterWidth = 12;
            this.ScRight.TabIndex = 0;
            // 
            // TbXml
            // 
            this.TbXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbXml.Location = new System.Drawing.Point(0, 0);
            this.TbXml.Multiline = true;
            this.TbXml.Name = "TbXml";
            this.TbXml.Size = new System.Drawing.Size(612, 212);
            this.TbXml.TabIndex = 0;
            // 
            // PbDraw
            // 
            this.PbDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PbDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbDraw.Location = new System.Drawing.Point(0, 0);
            this.PbDraw.Name = "PbDraw";
            this.PbDraw.Size = new System.Drawing.Size(612, 206);
            this.PbDraw.TabIndex = 2;
            this.PbDraw.TabStop = false;
            this.PbDraw.Resize += new System.EventHandler(this.PbDraw_Resize);
            // 
            // BridgePatternMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 430);
            this.Controls.Add(this.ScVertical);
            this.Name = "BridgePatternMainForm";
            this.Text = "Bridge";
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
            ((System.ComponentModel.ISupportInitialize)(this.PbDraw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer ScVertical;
        private System.Windows.Forms.ListBox LbShapes;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TbParameters;
        private System.Windows.Forms.ComboBox CbShapeKinds;
        private System.Windows.Forms.SplitContainer ScRight;
        private System.Windows.Forms.TextBox TbXml;
        private System.Windows.Forms.PictureBox PbDraw;
    }
}

