namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.cBox = new System.Windows.Forms.ComboBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.panel_buttons = new System.Windows.Forms.Panel();
            this.bt_panel_3 = new System.Windows.Forms.Button();
            this.bt_panel_2 = new System.Windows.Forms.Button();
            this.bt_panel_1 = new System.Windows.Forms.Button();
            this.btn_test = new System.Windows.Forms.Button();
            this.panel_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBox
            // 
            this.cBox.FormattingEnabled = true;
            this.cBox.Location = new System.Drawing.Point(12, 12);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(121, 21);
            this.cBox.TabIndex = 0;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 138);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(138, 81);
            this.txtLog.TabIndex = 1;
            // 
            // panel_buttons
            // 
            this.panel_buttons.Controls.Add(this.bt_panel_3);
            this.panel_buttons.Controls.Add(this.bt_panel_2);
            this.panel_buttons.Controls.Add(this.bt_panel_1);
            this.panel_buttons.Location = new System.Drawing.Point(156, 73);
            this.panel_buttons.Name = "panel_buttons";
            this.panel_buttons.Size = new System.Drawing.Size(116, 158);
            this.panel_buttons.TabIndex = 2;
            // 
            // bt_panel_3
            // 
            this.bt_panel_3.Location = new System.Drawing.Point(26, 61);
            this.bt_panel_3.Name = "bt_panel_3";
            this.bt_panel_3.Size = new System.Drawing.Size(75, 23);
            this.bt_panel_3.TabIndex = 2;
            this.bt_panel_3.Text = "button3";
            this.bt_panel_3.UseVisualStyleBackColor = true;
            // 
            // bt_panel_2
            // 
            this.bt_panel_2.Location = new System.Drawing.Point(26, 32);
            this.bt_panel_2.Name = "bt_panel_2";
            this.bt_panel_2.Size = new System.Drawing.Size(75, 23);
            this.bt_panel_2.TabIndex = 1;
            this.bt_panel_2.Text = "button2";
            this.bt_panel_2.UseVisualStyleBackColor = true;
            // 
            // bt_panel_1
            // 
            this.bt_panel_1.Location = new System.Drawing.Point(26, 3);
            this.bt_panel_1.Name = "bt_panel_1";
            this.bt_panel_1.Size = new System.Drawing.Size(75, 23);
            this.bt_panel_1.TabIndex = 0;
            this.bt_panel_1.Text = "button1";
            this.bt_panel_1.UseVisualStyleBackColor = true;
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(182, 13);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(75, 23);
            this.btn_test.TabIndex = 3;
            this.btn_test.Text = "test";
            this.btn_test.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.panel_buttons);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.cBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_buttons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBox;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Panel panel_buttons;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Button bt_panel_3;
        private System.Windows.Forms.Button bt_panel_2;
        private System.Windows.Forms.Button bt_panel_1;
    }
}

