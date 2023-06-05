namespace Test018
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.PaintBox = new System.Windows.Forms.PictureBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.btnNewCircle = new System.Windows.Forms.Button();
            this.btnNewSquare = new System.Windows.Forms.Button();
            this.btnNewRectangle = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.LbSurface = new System.Windows.Forms.ToolStripStatusLabel();
            this.LbPerimeter = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PaintBox)).BeginInit();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PaintBox
            // 
            this.PaintBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PaintBox.Location = new System.Drawing.Point(2, 2);
            this.PaintBox.Name = "PaintBox";
            this.PaintBox.Size = new System.Drawing.Size(357, 267);
            this.PaintBox.TabIndex = 0;
            this.PaintBox.TabStop = false;
            this.PaintBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseMove);
            this.PaintBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseDown);
            this.PaintBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintBox_Paint);
            this.PaintBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PaintBox_MouseUp);
            // 
            // ListBox
            // 
            this.ListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(365, 2);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(100, 238);
            this.ListBox.TabIndex = 1;
            this.ListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDoubleClick);
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // btnNewCircle
            // 
            this.btnNewCircle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewCircle.Location = new System.Drawing.Point(364, 246);
            this.btnNewCircle.Name = "btnNewCircle";
            this.btnNewCircle.Size = new System.Drawing.Size(30, 23);
            this.btnNewCircle.TabIndex = 2;
            this.btnNewCircle.Text = "o";
            this.btnNewCircle.UseVisualStyleBackColor = true;
            this.btnNewCircle.Click += new System.EventHandler(this.btnNewCircle_Click);
            // 
            // btnNewSquare
            // 
            this.btnNewSquare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewSquare.Location = new System.Drawing.Point(400, 246);
            this.btnNewSquare.Name = "btnNewSquare";
            this.btnNewSquare.Size = new System.Drawing.Size(30, 23);
            this.btnNewSquare.TabIndex = 3;
            this.btnNewSquare.Text = "[ ]";
            this.btnNewSquare.UseVisualStyleBackColor = true;
            this.btnNewSquare.Click += new System.EventHandler(this.btnNewSquare_Click);
            // 
            // btnNewRectangle
            // 
            this.btnNewRectangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewRectangle.Location = new System.Drawing.Point(434, 246);
            this.btnNewRectangle.Name = "btnNewRectangle";
            this.btnNewRectangle.Size = new System.Drawing.Size(30, 23);
            this.btnNewRectangle.TabIndex = 4;
            this.btnNewRectangle.Text = "[]";
            this.btnNewRectangle.UseVisualStyleBackColor = true;
            this.btnNewRectangle.Click += new System.EventHandler(this.btnNewRectangle_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LbSurface,
            this.LbPerimeter});
            this.statusBar.Location = new System.Drawing.Point(0, 272);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(468, 22);
            this.statusBar.TabIndex = 5;
            this.statusBar.Text = "statusStrip1";
            // 
            // LbSurface
            // 
            this.LbSurface.AutoSize = false;
            this.LbSurface.Name = "LbSurface";
            this.LbSurface.Size = new System.Drawing.Size(100, 17);
            this.LbSurface.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbPerimeter
            // 
            this.LbPerimeter.AutoSize = false;
            this.LbPerimeter.Name = "LbPerimeter";
            this.LbPerimeter.Size = new System.Drawing.Size(120, 17);
            this.LbPerimeter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 294);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.btnNewRectangle);
            this.Controls.Add(this.btnNewSquare);
            this.Controls.Add(this.btnNewCircle);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.PaintBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PaintBox)).EndInit();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PaintBox;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button btnNewCircle;
        private System.Windows.Forms.Button btnNewSquare;
        private System.Windows.Forms.Button btnNewRectangle;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel LbSurface;
        private System.Windows.Forms.ToolStripStatusLabel LbPerimeter;
        private System.Windows.Forms.Timer timer;
    }
}

