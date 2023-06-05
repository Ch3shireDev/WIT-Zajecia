namespace BridgeTest
{
    partial class BridgeTestForm
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
            this.Client = new System.Windows.Forms.SplitContainer();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.Buttons = new System.Windows.Forms.Panel();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.EdParameters = new System.Windows.Forms.TextBox();
            this.CbFigure = new System.Windows.Forms.ComboBox();
            this.ListPane = new System.Windows.Forms.Panel();
            this.LbFigures = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.Client)).BeginInit();
            this.Client.Panel1.SuspendLayout();
            this.Client.Panel2.SuspendLayout();
            this.Client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.Buttons.SuspendLayout();
            this.ListPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // Client
            // 
            this.Client.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Client.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.Client.Location = new System.Drawing.Point(0, 0);
            this.Client.Name = "Client";
            // 
            // Client.Panel1
            // 
            this.Client.Panel1.Controls.Add(this.ListPane);
            this.Client.Panel1.Controls.Add(this.Buttons);
            this.Client.Panel1MinSize = 180;
            // 
            // Client.Panel2
            // 
            this.Client.Panel2.Controls.Add(this.ImageBox);
            this.Client.Panel2MinSize = 100;
            this.Client.Size = new System.Drawing.Size(547, 497);
            this.Client.SplitterDistance = 294;
            this.Client.SplitterWidth = 6;
            this.Client.TabIndex = 6;
            // 
            // ImageBox
            // 
            this.ImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageBox.Location = new System.Drawing.Point(0, 0);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(243, 493);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 1;
            this.ImageBox.TabStop = false;
            // 
            // Buttons
            // 
            this.Buttons.Controls.Add(this.BtnRemove);
            this.Buttons.Controls.Add(this.BtnAdd);
            this.Buttons.Controls.Add(this.EdParameters);
            this.Buttons.Controls.Add(this.CbFigure);
            this.Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Buttons.Location = new System.Drawing.Point(0, 393);
            this.Buttons.Name = "Buttons";
            this.Buttons.Size = new System.Drawing.Size(290, 100);
            this.Buttons.TabIndex = 0;
            // 
            // BtnRemove
            // 
            this.BtnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemove.Location = new System.Drawing.Point(208, 69);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnRemove.TabIndex = 9;
            this.BtnRemove.Text = "Usuń";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(8, 69);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // EdParameters
            // 
            this.EdParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EdParameters.Location = new System.Drawing.Point(8, 43);
            this.EdParameters.Name = "EdParameters";
            this.EdParameters.Size = new System.Drawing.Size(275, 20);
            this.EdParameters.TabIndex = 7;
            // 
            // CbFigure
            // 
            this.CbFigure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbFigure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFigure.FormattingEnabled = true;
            this.CbFigure.Location = new System.Drawing.Point(8, 16);
            this.CbFigure.Name = "CbFigure";
            this.CbFigure.Size = new System.Drawing.Size(275, 21);
            this.CbFigure.TabIndex = 6;
            // 
            // ListPane
            // 
            this.ListPane.Controls.Add(this.LbFigures);
            this.ListPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPane.Location = new System.Drawing.Point(0, 0);
            this.ListPane.Name = "ListPane";
            this.ListPane.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.ListPane.Size = new System.Drawing.Size(290, 393);
            this.ListPane.TabIndex = 1;
            // 
            // LbFigures
            // 
            this.LbFigures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbFigures.FormattingEnabled = true;
            this.LbFigures.Location = new System.Drawing.Point(8, 8);
            this.LbFigures.Margin = new System.Windows.Forms.Padding(8);
            this.LbFigures.Name = "LbFigures";
            this.LbFigures.Size = new System.Drawing.Size(274, 385);
            this.LbFigures.TabIndex = 3;
            // 
            // BridgeTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 497);
            this.Controls.Add(this.Client);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "BridgeTestForm";
            this.Text = "Bridge test form ...";
            this.Client.Panel1.ResumeLayout(false);
            this.Client.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Client)).EndInit();
            this.Client.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.Buttons.ResumeLayout(false);
            this.Buttons.PerformLayout();
            this.ListPane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Client;
        private System.Windows.Forms.Panel Buttons;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox EdParameters;
        private System.Windows.Forms.ComboBox CbFigure;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Panel ListPane;
        private System.Windows.Forms.ListBox LbFigures;
    }
}

