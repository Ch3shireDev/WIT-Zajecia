﻿namespace HarmCalcWorker
{
    partial class HarmCalcMain
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
            this.EResult = new System.Windows.Forms.TextBox();
            this.Box = new System.Windows.Forms.Panel();
            this.BtnStart = new System.Windows.Forms.Button();
            this.ECount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EResult
            // 
            this.EResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EResult.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EResult.Location = new System.Drawing.Point(199, 40);
            this.EResult.Multiline = true;
            this.EResult.Name = "EResult";
            this.EResult.ReadOnly = true;
            this.EResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EResult.Size = new System.Drawing.Size(373, 211);
            this.EResult.TabIndex = 7;
            // 
            // Box
            // 
            this.Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Box.AutoScroll = true;
            this.Box.Location = new System.Drawing.Point(12, 40);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(181, 211);
            this.Box.TabIndex = 6;
            // 
            // BtnStart
            // 
            this.BtnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStart.Location = new System.Drawing.Point(497, 11);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 5;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // ECount
            // 
            this.ECount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ECount.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ECount.Location = new System.Drawing.Point(391, 13);
            this.ECount.Name = "ECount";
            this.ECount.Size = new System.Drawing.Size(100, 20);
            this.ECount.TabIndex = 4;
            this.ECount.Text = "100000000";
            this.ECount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HarmCalcMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.EResult);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.ECount);
            this.Name = "HarmCalcMain";
            this.Text = "Ciąg harmoniczny worker ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EResult;
        public System.Windows.Forms.Panel Box;
        private System.Windows.Forms.Button BtnStart;
        public System.Windows.Forms.TextBox ECount;

    }
}

