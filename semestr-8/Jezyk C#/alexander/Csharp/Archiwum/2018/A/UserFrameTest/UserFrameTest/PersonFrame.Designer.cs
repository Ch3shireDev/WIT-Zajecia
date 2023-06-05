namespace UserFrameTestSpace
{
    partial class PersonFrame
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Line = new System.Windows.Forms.Panel();
            this.FaceBox = new System.Windows.Forms.PictureBox();
            this.Space = new System.Windows.Forms.Panel();
            this.EdFirstname = new System.Windows.Forms.TextBox();
            this.EdLastname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FaceBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Line.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Line.Location = new System.Drawing.Point(0, 119);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(364, 3);
            this.Line.TabIndex = 1;
            // 
            // FaceBox
            // 
            this.FaceBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.FaceBox.Location = new System.Drawing.Point(0, 0);
            this.FaceBox.Name = "FaceBox";
            this.FaceBox.Size = new System.Drawing.Size(100, 119);
            this.FaceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FaceBox.TabIndex = 2;
            this.FaceBox.TabStop = false;
            // 
            // Space
            // 
            this.Space.Dock = System.Windows.Forms.DockStyle.Left;
            this.Space.Location = new System.Drawing.Point(100, 0);
            this.Space.Name = "Space";
            this.Space.Size = new System.Drawing.Size(8, 119);
            this.Space.TabIndex = 3;
            // 
            // EdFirstname
            // 
            this.EdFirstname.Dock = System.Windows.Forms.DockStyle.Top;
            this.EdFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdFirstname.Location = new System.Drawing.Point(108, 0);
            this.EdFirstname.Name = "EdFirstname";
            this.EdFirstname.ReadOnly = true;
            this.EdFirstname.Size = new System.Drawing.Size(256, 29);
            this.EdFirstname.TabIndex = 4;
            // 
            // EdLastname
            // 
            this.EdLastname.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EdLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdLastname.Location = new System.Drawing.Point(108, 90);
            this.EdLastname.Name = "EdLastname";
            this.EdLastname.ReadOnly = true;
            this.EdLastname.Size = new System.Drawing.Size(256, 29);
            this.EdLastname.TabIndex = 5;
            // 
            // PersonFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EdLastname);
            this.Controls.Add(this.EdFirstname);
            this.Controls.Add(this.Space);
            this.Controls.Add(this.FaceBox);
            this.Controls.Add(this.Line);
            this.Name = "PersonFrame";
            this.Size = new System.Drawing.Size(364, 122);
            ((System.ComponentModel.ISupportInitialize)(this.FaceBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Line;
        private System.Windows.Forms.PictureBox FaceBox;
        private System.Windows.Forms.Panel Space;
        private System.Windows.Forms.TextBox EdFirstname;
        private System.Windows.Forms.TextBox EdLastname;
    }
}
