﻿namespace HarmonicSum
{
    partial class HarmonicSumForm
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
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnSimple = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnOneThread = new System.Windows.Forms.Button();
            this.btnMultiThread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(12, 12);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 0;
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            // 
            // btnSimple
            // 
            this.btnSimple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimple.Location = new System.Drawing.Point(571, 10);
            this.btnSimple.Name = "btnSimple";
            this.btnSimple.Size = new System.Drawing.Size(75, 23);
            this.btnSimple.TabIndex = 1;
            this.btnSimple.Text = "Simple";
            this.btnSimple.UseVisualStyleBackColor = true;
            this.btnSimple.Click += new System.EventHandler(this.btnSimple_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(12, 38);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(634, 212);
            this.txtLog.TabIndex = 2;
            // 
            // btnOneThread
            // 
            this.btnOneThread.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOneThread.Location = new System.Drawing.Point(490, 10);
            this.btnOneThread.Name = "btnOneThread";
            this.btnOneThread.Size = new System.Drawing.Size(75, 23);
            this.btnOneThread.TabIndex = 3;
            this.btnOneThread.Text = "One Thread";
            this.btnOneThread.UseVisualStyleBackColor = true;
            this.btnOneThread.Click += new System.EventHandler(this.btnOneThread_Click);
            // 
            // btnMultiThread
            // 
            this.btnMultiThread.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMultiThread.Location = new System.Drawing.Point(409, 10);
            this.btnMultiThread.Name = "btnMultiThread";
            this.btnMultiThread.Size = new System.Drawing.Size(75, 23);
            this.btnMultiThread.TabIndex = 4;
            this.btnMultiThread.Text = "Multi Thread";
            this.btnMultiThread.UseVisualStyleBackColor = true;
            this.btnMultiThread.Click += new System.EventHandler(this.btnMultiThread_Click);
            // 
            // HarmonicSumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 262);
            this.Controls.Add(this.btnMultiThread);
            this.Controls.Add(this.btnOneThread);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnSimple);
            this.Controls.Add(this.txtCount);
            this.Name = "HarmonicSumForm";
            this.Text = "Harmonic Sum Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnSimple;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnOneThread;
        private System.Windows.Forms.Button btnMultiThread;
    }
}

