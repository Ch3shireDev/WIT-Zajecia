namespace UserControlTest
{
    partial class WorkerEdit
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
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.EdWorker = new UserControlTest.WorkerControl();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.BtnCancel);
            this.Footer.Controls.Add(this.BtnOk);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 282);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(785, 36);
            this.Footer.TabIndex = 1;
            // 
            // BtnOk
            // 
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.Location = new System.Drawing.Point(12, 6);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.Text = "Akceptuj";
            this.BtnOk.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(698, 6);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Rezygnuj";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // EdWorker
            // 
            this.EdWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EdWorker.Location = new System.Drawing.Point(0, 0);
            this.EdWorker.Name = "EdWorker";
            this.EdWorker.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.EdWorker.Size = new System.Drawing.Size(785, 282);
            this.EdWorker.TabIndex = 2;
            this.EdWorker.worker = null;
            // 
            // WorkerEdit
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(785, 318);
            this.Controls.Add(this.EdWorker);
            this.Controls.Add(this.Footer);
            this.Name = "WorkerEdit";
            this.Text = "Edycja pracownika ...";
            this.Footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Footer;
        private WorkerControl EdWorker;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOk;
    }
}