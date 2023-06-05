using System;
using System.Windows.Forms;

namespace Crom.Controls.Test
{
   public class Info : Form
   {
      private Label label1;
      private Label label2;
      private Label label3;
      private Label label5;
      private Label label4;
      private Label label6;
      private Label label7;
      private Label label8;
      private Label label9;
      private Button _cmdClose;

      public Info()
      {
         InitializeComponent();
      }

      private void InitializeComponent()
      {
         this._cmdClose = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // _cmdClose
         // 
         this._cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this._cmdClose.DialogResult = System.Windows.Forms.DialogResult.OK;
         this._cmdClose.Location = new System.Drawing.Point(351, 242);
         this._cmdClose.Name = "_cmdClose";
         this._cmdClose.Size = new System.Drawing.Size(75, 23);
         this._cmdClose.TabIndex = 0;
         this._cmdClose.Text = "Close";
         this._cmdClose.UseVisualStyleBackColor = true;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
         this.label1.Location = new System.Drawing.Point(12, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(283, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "Use menu: Help -> Info to show this dialog again";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 58);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(221, 13);
         this.label2.TabIndex = 2;
         this.label2.Text = "2. Use menu: File -> Save to save your layout";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(12, 36);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(318, 13);
         this.label3.TabIndex = 3;
         this.label3.Text = "1. Use menu: Work -> Initialize to create a pre-defined set of forms";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(12, 80);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(235, 13);
         this.label5.TabIndex = 5;
         this.label5.Text = "3. Use menu: File -> Load to load a saved layout";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(12, 116);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(177, 13);
         this.label4.TabIndex = 6;
         this.label4.Text = "Use Ctrl+Tab to show forms selector";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(12, 138);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(300, 13);
         this.label6.TabIndex = 7;
         this.label6.Text = "Use Auto-Hide button to toggle the auto-hide mode of the form";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(12, 160);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(311, 13);
         this.label7.TabIndex = 8;
         this.label7.Text = "Use context menu button to display the context menu of the form";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(12, 183);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(173, 13);
         this.label8.TabIndex = 9;
         this.label8.Text = "Use close button to close the forms";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(16, 206);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(338, 13);
         this.label9.TabIndex = 10;
         this.label9.Text = "Hoover the mouse over the auto-hidden buttons to view forms preview";
         // 
         // Info
         // 
         this.AcceptButton = this._cmdClose;
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
         this.ClientSize = new System.Drawing.Size(438, 277);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this._cmdClose);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "Info";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Read me";
         this.ResumeLayout(false);
         this.PerformLayout();

      }
   }
}
