namespace Mandelbroat
{
    partial class MandelbroatForm
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
            this.Box = new System.Windows.Forms.PictureBox();
            this.lbPtX = new System.Windows.Forms.Label();
            this.txtPtX = new System.Windows.Forms.TextBox();
            this.txtPtY = new System.Windows.Forms.TextBox();
            this.lbPtY = new System.Windows.Forms.Label();
            this.txtZoom = new System.Windows.Forms.TextBox();
            this.lbZoom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Box.Location = new System.Drawing.Point(1, 32);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(685, 360);
            this.Box.TabIndex = 0;
            this.Box.TabStop = false;
            // 
            // lbPtX
            // 
            this.lbPtX.AutoSize = true;
            this.lbPtX.Location = new System.Drawing.Point(12, 9);
            this.lbPtX.Name = "lbPtX";
            this.lbPtX.Size = new System.Drawing.Size(17, 13);
            this.lbPtX.TabIndex = 1;
            this.lbPtX.Text = "X:";
            // 
            // txtPtX
            // 
            this.txtPtX.Location = new System.Drawing.Point(35, 6);
            this.txtPtX.Name = "txtPtX";
            this.txtPtX.Size = new System.Drawing.Size(130, 20);
            this.txtPtX.TabIndex = 2;
            this.txtPtX.Text = "-0,5";
            this.txtPtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPtX.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtPtY
            // 
            this.txtPtY.Location = new System.Drawing.Point(199, 6);
            this.txtPtY.Name = "txtPtY";
            this.txtPtY.Size = new System.Drawing.Size(130, 20);
            this.txtPtY.TabIndex = 4;
            this.txtPtY.Text = "0";
            this.txtPtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPtY.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lbPtY
            // 
            this.lbPtY.AutoSize = true;
            this.lbPtY.Location = new System.Drawing.Point(176, 9);
            this.lbPtY.Name = "lbPtY";
            this.lbPtY.Size = new System.Drawing.Size(17, 13);
            this.lbPtY.TabIndex = 3;
            this.lbPtY.Text = "Y:";
            // 
            // txtZoom
            // 
            this.txtZoom.Location = new System.Drawing.Point(386, 6);
            this.txtZoom.Name = "txtZoom";
            this.txtZoom.Size = new System.Drawing.Size(99, 20);
            this.txtZoom.TabIndex = 6;
            this.txtZoom.Text = "200";
            this.txtZoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtZoom.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lbZoom
            // 
            this.lbZoom.AutoSize = true;
            this.lbZoom.Location = new System.Drawing.Point(343, 9);
            this.lbZoom.Name = "lbZoom";
            this.lbZoom.Size = new System.Drawing.Size(37, 13);
            this.lbZoom.TabIndex = 5;
            this.lbZoom.Text = "Zoom:";
            // 
            // MandelbroatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 393);
            this.Controls.Add(this.txtZoom);
            this.Controls.Add(this.lbZoom);
            this.Controls.Add(this.txtPtY);
            this.Controls.Add(this.lbPtY);
            this.Controls.Add(this.txtPtX);
            this.Controls.Add(this.lbPtX);
            this.Controls.Add(this.Box);
            this.Name = "MandelbroatForm";
            this.Text = "Mandelbroat fractals ...";
            ((System.ComponentModel.ISupportInitialize)(this.Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Box;
        private System.Windows.Forms.Label lbPtX;
        private System.Windows.Forms.TextBox txtPtX;
        private System.Windows.Forms.Label lbPtY;
        private System.Windows.Forms.TextBox txtPtY;
        private System.Windows.Forms.Label lbZoom;
        private System.Windows.Forms.TextBox txtZoom;
    }
}

