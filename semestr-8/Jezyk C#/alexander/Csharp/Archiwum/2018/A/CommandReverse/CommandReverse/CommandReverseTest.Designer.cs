namespace CommandTest
{
    partial class CommandReverseTest
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
            this.Log = new System.Windows.Forms.TextBox();
            this.BtnReverseTest = new System.Windows.Forms.Button();
            this.BtnClassicTest = new System.Windows.Forms.Button();
            this.LstAvailable = new System.Windows.Forms.ListBox();
            this.LstTrening = new System.Windows.Forms.ListBox();
            this.EdName = new System.Windows.Forms.TextBox();
            this.BtnExecute = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnAppend = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Log
            // 
            this.Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Log.Location = new System.Drawing.Point(12, 142);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Log.Size = new System.Drawing.Size(440, 108);
            this.Log.TabIndex = 0;
            // 
            // BtnReverseTest
            // 
            this.BtnReverseTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReverseTest.Location = new System.Drawing.Point(458, 152);
            this.BtnReverseTest.Name = "BtnReverseTest";
            this.BtnReverseTest.Size = new System.Drawing.Size(87, 23);
            this.BtnReverseTest.TabIndex = 1;
            this.BtnReverseTest.Text = "Test Reverse";
            this.BtnReverseTest.UseVisualStyleBackColor = true;
            this.BtnReverseTest.Click += new System.EventHandler(this.BtnReverseTest_Click);
            // 
            // BtnClassicTest
            // 
            this.BtnClassicTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClassicTest.Location = new System.Drawing.Point(458, 181);
            this.BtnClassicTest.Name = "BtnClassicTest";
            this.BtnClassicTest.Size = new System.Drawing.Size(87, 23);
            this.BtnClassicTest.TabIndex = 2;
            this.BtnClassicTest.Text = "Test Classic";
            this.BtnClassicTest.UseVisualStyleBackColor = true;
            this.BtnClassicTest.Click += new System.EventHandler(this.BtnClassicTest_Click);
            // 
            // LstAvailable
            // 
            this.LstAvailable.FormattingEnabled = true;
            this.LstAvailable.Location = new System.Drawing.Point(12, 12);
            this.LstAvailable.Name = "LstAvailable";
            this.LstAvailable.Size = new System.Drawing.Size(120, 95);
            this.LstAvailable.TabIndex = 3;
            // 
            // LstTrening
            // 
            this.LstTrening.FormattingEnabled = true;
            this.LstTrening.Location = new System.Drawing.Point(332, 38);
            this.LstTrening.Name = "LstTrening";
            this.LstTrening.Size = new System.Drawing.Size(120, 69);
            this.LstTrening.TabIndex = 4;
            // 
            // EdName
            // 
            this.EdName.Location = new System.Drawing.Point(332, 12);
            this.EdName.Name = "EdName";
            this.EdName.Size = new System.Drawing.Size(120, 20);
            this.EdName.TabIndex = 5;
            this.EdName.TextChanged += new System.EventHandler(this.EdName_TextChanged);
            // 
            // BtnExecute
            // 
            this.BtnExecute.Location = new System.Drawing.Point(12, 113);
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(75, 23);
            this.BtnExecute.TabIndex = 6;
            this.BtnExecute.Text = "Wykonaj";
            this.BtnExecute.UseVisualStyleBackColor = true;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Enabled = false;
            this.BtnAdd.Location = new System.Drawing.Point(332, 113);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "Dodaj";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnAppend
            // 
            this.BtnAppend.Location = new System.Drawing.Point(197, 38);
            this.BtnAppend.Name = "BtnAppend";
            this.BtnAppend.Size = new System.Drawing.Size(75, 23);
            this.BtnAppend.TabIndex = 8;
            this.BtnAppend.Text = ">";
            this.BtnAppend.UseVisualStyleBackColor = true;
            this.BtnAppend.Click += new System.EventHandler(this.BtnAppend_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(197, 84);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnRemove.TabIndex = 9;
            this.BtnRemove.Text = "<";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // CommandReverseTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 262);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAppend);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnExecute);
            this.Controls.Add(this.EdName);
            this.Controls.Add(this.LstTrening);
            this.Controls.Add(this.LstAvailable);
            this.Controls.Add(this.BtnClassicTest);
            this.Controls.Add(this.BtnReverseTest);
            this.Controls.Add(this.Log);
            this.Name = "CommandReverseTest";
            this.Text = "Command test ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.Button BtnReverseTest;
        private System.Windows.Forms.Button BtnClassicTest;
        private System.Windows.Forms.ListBox LstAvailable;
        private System.Windows.Forms.ListBox LstTrening;
        private System.Windows.Forms.TextBox EdName;
        private System.Windows.Forms.Button BtnExecute;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnAppend;
        private System.Windows.Forms.Button BtnRemove;
    }
}

