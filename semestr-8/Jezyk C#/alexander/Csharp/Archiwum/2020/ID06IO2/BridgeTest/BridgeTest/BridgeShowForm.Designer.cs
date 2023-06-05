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
            this.PbFigures = new System.Windows.Forms.PictureBox();
            this.EdParameters = new System.Windows.Forms.TextBox();
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
            this.LbFigures.Size = new System.Drawing.Size(120, 238);
            this.LbFigures.TabIndex = 2;
            // 
            // PbFigures
            // 
            this.PbFigures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbFigures.Location = new System.Drawing.Point(139, 12);
            this.PbFigures.Name = "PbFigures";
            this.PbFigures.Size = new System.Drawing.Size(435, 321);
            this.PbFigures.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbFigures.TabIndex = 3;
            this.PbFigures.TabStop = false;
            this.PbFigures.Resize += new System.EventHandler(this.PbFigures_Resize);
            // 
            // EdParameters
            // 
            this.EdParameters.Location = new System.Drawing.Point(12, 39);
            this.EdParameters.Name = "EdParameters";
            this.EdParameters.Size = new System.Drawing.Size(120, 20);
            this.EdParameters.TabIndex = 4;
            // 
            // BridgeShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 349);
            this.Controls.Add(this.EdParameters);
            this.Controls.Add(this.PbFigures);
            this.Controls.Add(this.LbFigures);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CbFigureKinds);
            this.Name = "BridgeShowForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbFigures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbFigureKinds;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ListBox LbFigures;
        private System.Windows.Forms.PictureBox PbFigures;
        private System.Windows.Forms.TextBox EdParameters;
    }
}

