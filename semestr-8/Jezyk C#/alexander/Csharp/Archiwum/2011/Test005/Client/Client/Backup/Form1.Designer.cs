namespace Client
{
    partial class AClient
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
            this.Line = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.Host = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.TextBox();
            this.Connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Log
            // 
            this.Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Log.Location = new System.Drawing.Point(0, 31);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Log.Size = new System.Drawing.Size(618, 237);
            this.Log.TabIndex = 3;
            this.Log.TabStop = false;
            this.Log.DoubleClick += new System.EventHandler(this.Log_DoubleClick);
            // 
            // Line
            // 
            this.Line.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Line.Enabled = false;
            this.Line.Location = new System.Drawing.Point(4, 274);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(528, 20);
            this.Line.TabIndex = 4;
            this.Line.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Line_KeyPress);
            // 
            // Send
            // 
            this.Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Send.Enabled = false;
            this.Send.Location = new System.Drawing.Point(538, 272);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 5;
            this.Send.Text = "&Wyœlij";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(4, 5);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(129, 20);
            this.Host.TabIndex = 6;
            this.Host.Text = "127.0.0.1";
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(139, 5);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(129, 20);
            this.User.TabIndex = 1;
            this.User.Text = "anonim";
            this.User.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.User_KeyPress);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(274, 5);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 2;
            this.Connect.Text = "&Po³¹cz";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // AClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 299);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.Log);
            this.MinimumSize = new System.Drawing.Size(362, 154);
            this.Name = "AClient";
            this.Text = "Okno klienta ...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AClient_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.TextBox Line;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.Button Connect;
    }
}

