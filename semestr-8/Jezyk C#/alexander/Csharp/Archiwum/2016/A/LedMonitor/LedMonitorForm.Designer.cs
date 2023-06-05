namespace LedMonitor
{
    partial class LedMonitor
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
            this.ShowText = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ShowText
            // 
            this.ShowText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowText.Location = new System.Drawing.Point(8, 117);
            this.ShowText.Name = "ShowText";
            this.ShowText.Size = new System.Drawing.Size(199, 20);
            this.ShowText.TabIndex = 0;
            this.ShowText.Text = "13579";
            this.ShowText.TextChanged += new System.EventHandler(this.ShowText_TextChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 250;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // LedMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 147);
            this.Controls.Add(this.ShowText);
            this.Name = "LedMonitor";
            this.Text = "Led Monitor Test ...";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LedMonitor_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ShowText;
        private System.Windows.Forms.Timer timer;
    }
}

