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
            this.LblMessage = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.PnlParameters = new System.Windows.Forms.Panel();
            this.LblParameters = new System.Windows.Forms.Label();
            this.TbParameters = new System.Windows.Forms.TextBox();
            this.PnlShapes = new System.Windows.Forms.Panel();
            this.LblShapes = new System.Windows.Forms.Label();
            this.CbShapes = new System.Windows.Forms.ComboBox();
            this.PnlImage = new System.Windows.Forms.Panel();
            this.PbImage = new System.Windows.Forms.PictureBox();
            this.PnlLeft.SuspendLayout();
            this.PnlParameters.SuspendLayout();
            this.PnlShapes.SuspendLayout();
            this.PnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlLeft
            // 
            this.PnlLeft.Controls.Add(this.LblMessage);
            this.PnlLeft.Controls.Add(this.BtnAdd);
            this.PnlLeft.Controls.Add(this.PnlParameters);
            this.PnlLeft.Controls.Add(this.PnlShapes);
            this.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLeft.Location = new System.Drawing.Point(0, 0);
            this.PnlLeft.Name = "PnlLeft";
            this.PnlLeft.Padding = new System.Windows.Forms.Padding(4);
            this.PnlLeft.Size = new System.Drawing.Size(178, 282);
            this.PnlLeft.TabIndex = 0;
            // 
            // LblMessage
            // 
            this.LblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMessage.ForeColor = System.Drawing.Color.Red;
            this.LblMessage.Location = new System.Drawing.Point(4, 82);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(170, 173);
            this.LblMessage.TabIndex = 7;
            this.LblMessage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAdd.Location = new System.Drawing.Point(4, 255);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(170, 23);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // PnlParameters
            // 
            this.PnlParameters.Controls.Add(this.LblParameters);
            this.PnlParameters.Controls.Add(this.TbParameters);
            this.PnlParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlParameters.Location = new System.Drawing.Point(4, 43);
            this.PnlParameters.Name = "PnlParameters";
            this.PnlParameters.Size = new System.Drawing.Size(170, 39);
            this.PnlParameters.TabIndex = 5;
            // 
            // LblParameters
            // 
            this.LblParameters.AutoSize = true;
            this.LblParameters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblParameters.Location = new System.Drawing.Point(0, 6);
            this.LblParameters.Name = "LblParameters";
            this.LblParameters.Size = new System.Drawing.Size(57, 13);
            this.LblParameters.TabIndex = 5;
            this.LblParameters.Text = "Parametry:";
            // 
            // TbParameters
            // 
            this.TbParameters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TbParameters.Location = new System.Drawing.Point(0, 19);
            this.TbParameters.Name = "TbParameters";
            this.TbParameters.Size = new System.Drawing.Size(170, 20);
            this.TbParameters.TabIndex = 4;
            // 
            // PnlShapes
            // 
            this.PnlShapes.Controls.Add(this.LblShapes);
            this.PnlShapes.Controls.Add(this.CbShapes);
            this.PnlShapes.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlShapes.Location = new System.Drawing.Point(4, 4);
            this.PnlShapes.Name = "PnlShapes";
            this.PnlShapes.Size = new System.Drawing.Size(170, 39);
            this.PnlShapes.TabIndex = 4;
            // 
            // LblShapes
            // 
            this.LblShapes.AutoSize = true;
            this.LblShapes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblShapes.Location = new System.Drawing.Point(0, 5);
            this.LblShapes.Name = "LblShapes";
            this.LblShapes.Size = new System.Drawing.Size(43, 13);
            this.LblShapes.TabIndex = 2;
            this.LblShapes.Text = "Kształt:";
            // 
            // CbShapes
            // 
            this.CbShapes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CbShapes.FormattingEnabled = true;
            this.CbShapes.Location = new System.Drawing.Point(0, 18);
            this.CbShapes.Name = "CbShapes";
            this.CbShapes.Size = new System.Drawing.Size(170, 21);
            this.CbShapes.TabIndex = 1;
            // 
            // PnlImage
            // 
            this.PnlImage.Controls.Add(this.PbImage);
            this.PnlImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlImage.Location = new System.Drawing.Point(178, 0);
            this.PnlImage.Name = "PnlImage";
            this.PnlImage.Padding = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.PnlImage.Size = new System.Drawing.Size(419, 282);
            this.PnlImage.TabIndex = 1;
            // 
            // PbImage
            // 
            this.PbImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbImage.Location = new System.Drawing.Point(0, 4);
            this.PbImage.Name = "PbImage";
            this.PbImage.Size = new System.Drawing.Size(415, 274);
            this.PbImage.TabIndex = 0;
            this.PbImage.TabStop = false;
            // 
            // ManualDrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 282);
            this.Controls.Add(this.PnlImage);
            this.Controls.Add(this.PnlLeft);
            this.MinimumSize = new System.Drawing.Size(385, 155);
            this.Name = "ManualDrawingForm";
            this.Text = "Form1";
            this.PnlLeft.ResumeLayout(false);
            this.PnlParameters.ResumeLayout(false);
            this.PnlParameters.PerformLayout();
            this.PnlShapes.ResumeLayout(false);
            this.PnlShapes.PerformLayout();
            this.PnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlLeft;
        private System.Windows.Forms.Panel PnlShapes;
        private System.Windows.Forms.Label LblShapes;
        private System.Windows.Forms.ComboBox CbShapes;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Panel PnlParameters;
        private System.Windows.Forms.Label LblParameters;
        private System.Windows.Forms.TextBox TbParameters;
        private System.Windows.Forms.Panel PnlImage;
        private System.Windows.Forms.PictureBox PbImage;
        private System.Windows.Forms.Label LblMessage;
    }
}

