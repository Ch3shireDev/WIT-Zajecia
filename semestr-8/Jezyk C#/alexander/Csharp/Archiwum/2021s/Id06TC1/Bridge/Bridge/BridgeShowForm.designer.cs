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
            this.PnFigures = new System.Windows.Forms.Panel();
            this.PbFigures = new System.Windows.Forms.PictureBox();
            this.PnFigures.SuspendLayout();
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
            // TxtParameters
            // 
            this.TxtParameters.Location = new System.Drawing.Point(12, 39);
            this.TxtParameters.Name = "TxtParameters";
            this.TxtParameters.Size = new System.Drawing.Size(120, 20);
            this.TxtParameters.TabIndex = 4;
            // 
            // PnFigures
            // 
            this.PnFigures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnFigures.BackColor = System.Drawing.SystemColors.Control;
            this.PnFigures.Controls.Add(this.PbFigures);
            this.PnFigures.Location = new System.Drawing.Point(139, 12);
            this.PnFigures.Name = "PnFigures";
            this.PnFigures.Padding = new System.Windows.Forms.Padding(4);
            this.PnFigures.Size = new System.Drawing.Size(435, 321);
            this.PnFigures.TabIndex = 5;
            this.PnFigures.Resize += new System.EventHandler(this.PbFigures_Resize);
            // 
            // PbFigures
            // 
            this.PbFigures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbFigures.Location = new System.Drawing.Point(4, 4);
            this.PbFigures.Name = "PbFigures";
            this.PbFigures.Size = new System.Drawing.Size(427, 313);
            this.PbFigures.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbFigures.TabIndex = 4;
            this.PbFigures.TabStop = false;
            // 
            // BridgeShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 349);
            this.Controls.Add(this.PnFigures);
            this.Controls.Add(this.TxtParameters);
            this.Controls.Add(this.LbFigures);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CbFigureKinds);
            this.Name = "BridgeShowForm";
            this.Text = "Form1";
            this.PnFigures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbFigures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbFigureKinds;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ListBox LbFigures;
        private System.Windows.Forms.TextBox TxtParameters;
        private System.Windows.Forms.Panel PnFigures;
        private System.Windows.Forms.PictureBox PbFigures;
    }
}

