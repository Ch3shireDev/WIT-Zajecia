namespace Arcanoid
{
    partial class ArcanoidMainForm
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
            this.PaControls = new System.Windows.Forms.Panel();
            this.PaBoard = new System.Windows.Forms.Panel();
            this.PbBoard = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.PaBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // PaControls
            // 
            this.PaControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.PaControls.Location = new System.Drawing.Point(0, 0);
            this.PaControls.Name = "PaControls";
            this.PaControls.Size = new System.Drawing.Size(1046, 38);
            this.PaControls.TabIndex = 0;
            // 
            // PaBoard
            // 
            this.PaBoard.Controls.Add(this.PbBoard);
            this.PaBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaBoard.Location = new System.Drawing.Point(0, 38);
            this.PaBoard.Name = "PaBoard";
            this.PaBoard.Padding = new System.Windows.Forms.Padding(4);
            this.PaBoard.Size = new System.Drawing.Size(1046, 448);
            this.PaBoard.TabIndex = 1;
            this.PaBoard.Resize += new System.EventHandler(this.PaBoard_Resize);
            // 
            // PbBoard
            // 
            this.PbBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbBoard.Location = new System.Drawing.Point(4, 4);
            this.PbBoard.Name = "PbBoard";
            this.PbBoard.Size = new System.Drawing.Size(1038, 440);
            this.PbBoard.TabIndex = 0;
            this.PbBoard.TabStop = false;
            this.PbBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbBoard_MouseMove);
            // 
            // Timer
            // 
            this.Timer.Interval = 20;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // ArcanoidMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 486);
            this.Controls.Add(this.PaBoard);
            this.Controls.Add(this.PaControls);
            this.Name = "ArcanoidMainForm";
            this.Text = "Form1";
            this.PaBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PaControls;
        private System.Windows.Forms.Panel PaBoard;
        private System.Windows.Forms.PictureBox PbBoard;
        private System.Windows.Forms.Timer Timer;
    }
}

