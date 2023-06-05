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
            this.PnlControl = new System.Windows.Forms.Panel();
            this.PnlClient = new System.Windows.Forms.Panel();
            this.PbFigures = new System.Windows.Forms.PictureBox();
            this.EdParameters = new System.Windows.Forms.TextBox();
            this.LbFigures = new System.Windows.Forms.ListBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.CbFigureKinds = new System.Windows.Forms.ComboBox();
            this.PnlControl.SuspendLayout();
            this.PnlClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbFigures)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlControl
            // 
            this.PnlControl.Controls.Add(this.EdParameters);
            this.PnlControl.Controls.Add(this.LbFigures);
            this.PnlControl.Controls.Add(this.BtnAdd);
            this.PnlControl.Controls.Add(this.CbFigureKinds);
            this.PnlControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlControl.Location = new System.Drawing.Point(0, 0);
            this.PnlControl.Name = "PnlControl";
            this.PnlControl.Size = new System.Drawing.Size(148, 349);
            this.PnlControl.TabIndex = 6;
            // 
            // PnlClient
            // 
            this.PnlClient.Controls.Add(this.PbFigures);
            this.PnlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlClient.Location = new System.Drawing.Point(148, 0);
            this.PnlClient.Name = "PnlClient";
            this.PnlClient.Padding = new System.Windows.Forms.Padding(4);
            this.PnlClient.Size = new System.Drawing.Size(438, 349);
            this.PnlClient.TabIndex = 7;
            this.PnlClient.Resize += new System.EventHandler(this.PnlClient_Resize);
            // 
            // PbFigures
            // 
            this.PbFigures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbFigures.Location = new System.Drawing.Point(4, 4);
            this.PbFigures.Name = "PbFigures";
            this.PbFigures.Size = new System.Drawing.Size(430, 341);
            this.PbFigures.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbFigures.TabIndex = 6;
            this.PbFigures.TabStop = false;
            // 
            // EdParameters
            // 
            this.EdParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdParameters.Location = new System.Drawing.Point(12, 34);
            this.EdParameters.Name = "EdParameters";
            this.EdParameters.Size = new System.Drawing.Size(120, 20);
            this.EdParameters.TabIndex = 8;
            // 
            // LbFigures
            // 
            this.LbFigures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbFigures.FormattingEnabled = true;
            this.LbFigures.Location = new System.Drawing.Point(12, 90);
            this.LbFigures.Name = "LbFigures";
            this.LbFigures.Size = new System.Drawing.Size(120, 238);
            this.LbFigures.TabIndex = 7;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(12, 60);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // CbFigureKinds
            // 
            this.CbFigureKinds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbFigureKinds.FormattingEnabled = true;
            this.CbFigureKinds.Location = new System.Drawing.Point(12, 7);
            this.CbFigureKinds.Name = "CbFigureKinds";
            this.CbFigureKinds.Size = new System.Drawing.Size(121, 21);
            this.CbFigureKinds.TabIndex = 5;
            // 
            // BridgeShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 349);
            this.Controls.Add(this.PnlClient);
            this.Controls.Add(this.PnlControl);
            this.Name = "BridgeShowForm";
            this.Text = "Form1";
            this.PnlControl.ResumeLayout(false);
            this.PnlControl.PerformLayout();
            this.PnlClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbFigures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlControl;
        private System.Windows.Forms.TextBox EdParameters;
        private System.Windows.Forms.ListBox LbFigures;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ComboBox CbFigureKinds;
        private System.Windows.Forms.Panel PnlClient;
        private System.Windows.Forms.PictureBox PbFigures;

    }
}

