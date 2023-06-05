namespace Client
{
    partial class Client
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
            this.BtnSend = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.TextBox();
            this.Host = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Line = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BtnSend
            // 
            this.BtnSend.Enabled = false;
            this.BtnSend.Location = new System.Drawing.Point(181, 217);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 0;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click_1);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(13, 134);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Log.Size = new System.Drawing.Size(246, 77);
            this.Log.TabIndex = 1;
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(56, 6);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(114, 20);
            this.Host.TabIndex = 2;
            this.Host.Text = "localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Host";
            // 
            // Line
            // 
            this.Line.Location = new System.Drawing.Point(101, 39);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(117, 20);
            this.Line.TabIndex = 4;
            this.Line.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnConnect
            // 
            this.BtnConnect.AutoSize = true;
            this.BtnConnect.Location = new System.Drawing.Point(186, 9);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(78, 17);
            this.BtnConnect.TabIndex = 5;
            this.BtnConnect.Text = "Connected";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.CheckedChanged += new System.EventHandler(this.BtnConnect_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "dlugość ciagu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wyniki:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(13, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 34);
            this.panel1.TabIndex = 8;
            // 
            // Client
            // 
            this.AcceptButton = this.BtnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 248);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.BtnSend);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing_1);
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox BtnConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Line;
        public System.Windows.Forms.TextBox Log;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox Host;
    }
}

