namespace test023
{
    partial class Snake
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
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.Status = new System.Windows.Forms.StatusStrip();
            this.Score = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tick
            // 
            this.Tick.Enabled = true;
            this.Tick.Interval = 200;
            this.Tick.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Score});
            this.Status.Location = new System.Drawing.Point(0, 112);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(221, 22);
            this.Status.TabIndex = 0;
            // 
            // Score
            // 
            this.Score.AutoSize = false;
            this.Score.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Score.ForeColor = System.Drawing.Color.Red;
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(100, 17);
            this.Score.Text = "0";
            this.Score.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 134);
            this.Controls.Add(this.Status);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Snake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Snake game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Snake_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snake_KeyDown);
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Tick;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel Score;

    }
}

