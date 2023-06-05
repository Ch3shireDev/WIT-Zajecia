namespace UserControlTest
{
    partial class WorkerEditor
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
            this.Footer = new System.Windows.Forms.Panel();
            this.UcWorker = new UserControlTest.WorkerControl();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.BtnCancel);
            this.Footer.Controls.Add(this.BtnAccept);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 237);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(824, 37);
            this.Footer.TabIndex = 2;
            // 
            // UcWorker
            // 
            this.UcWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcWorker.Location = new System.Drawing.Point(0, 0);
            this.UcWorker.Name = "UcWorker";
            this.UcWorker.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.UcWorker.Person = null;
            this.UcWorker.ReadOnly = false;
            this.UcWorker.Size = new System.Drawing.Size(824, 237);
            this.UcWorker.TabIndex = 3;
            // 
            // BtnAccept
            // 
            this.BtnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAccept.Location = new System.Drawing.Point(12, 6);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(75, 23);
            this.BtnAccept.TabIndex = 0;
            this.BtnAccept.Text = "Akceptuj";
            this.BtnAccept.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(737, 6);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Rezygnuj";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // WorkerEditor
            // 
            this.AcceptButton = this.BtnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(824, 274);
            this.Controls.Add(this.UcWorker);
            this.Controls.Add(this.Footer);
            this.Name = "WorkerEditor";
            this.Text = "Edycja pracownika ...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkerEditor_FormClosing);
            this.Footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Footer;
        private WorkerControl UcWorker;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAccept;
    }
}