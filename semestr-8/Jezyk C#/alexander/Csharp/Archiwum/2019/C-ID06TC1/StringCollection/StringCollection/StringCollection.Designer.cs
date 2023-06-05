﻿namespace StringCollection
{
    partial class StringCollection
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
            this.Box = new System.Windows.Forms.ListBox();
            this.Input = new System.Windows.Forms.TextBox();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Box.FormattingEnabled = true;
            this.Box.Location = new System.Drawing.Point(12, 12);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(636, 355);
            this.Box.TabIndex = 0;
            this.Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StringCollection_KeyDown);
            // 
            // Input
            // 
            this.Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Input.Location = new System.Drawing.Point(12, 384);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(636, 20);
            this.Input.TabIndex = 1;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemove.Enabled = false;
            this.BtnRemove.Location = new System.Drawing.Point(654, 12);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnRemove.TabIndex = 2;
            this.BtnRemove.Text = "Usuń";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Enabled = false;
            this.BtnAdd.Location = new System.Drawing.Point(654, 381);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // StringCollection
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 416);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Box);
            this.KeyPreview = true;
            this.Name = "StringCollection";
            this.Text = "Lista napisów ...";
            this.Activated += new System.EventHandler(this.StringCollection_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Box;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnAdd;
    }
}

