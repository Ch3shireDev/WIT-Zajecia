namespace UserControlTest
{
    partial class WorkerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EdPhoto = new System.Windows.Forms.PictureBox();
            this.Client = new System.Windows.Forms.Panel();
            this.EdName = new System.Windows.Forms.TextBox();
            this.EdSurname = new System.Windows.Forms.TextBox();
            this.EdNameHint = new System.Windows.Forms.Label();
            this.EdSurnameHint = new System.Windows.Forms.Label();
            this.DlgOpen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.EdPhoto)).BeginInit();
            this.Client.SuspendLayout();
            this.SuspendLayout();
            // 
            // EdPhoto
            // 
            this.EdPhoto.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.EdPhoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.EdPhoto.Location = new System.Drawing.Point(4, 4);
            this.EdPhoto.Name = "EdPhoto";
            this.EdPhoto.Size = new System.Drawing.Size(100, 145);
            this.EdPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EdPhoto.TabIndex = 0;
            this.EdPhoto.TabStop = false;
            this.EdPhoto.DoubleClick += new System.EventHandler(this.EdPhoto_DoubleClick);
            // 
            // Client
            // 
            this.Client.Controls.Add(this.EdSurnameHint);
            this.Client.Controls.Add(this.EdNameHint);
            this.Client.Controls.Add(this.EdSurname);
            this.Client.Controls.Add(this.EdName);
            this.Client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Client.Location = new System.Drawing.Point(104, 4);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(235, 145);
            this.Client.TabIndex = 1;
            // 
            // EdName
            // 
            this.EdName.Dock = System.Windows.Forms.DockStyle.Top;
            this.EdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdName.Location = new System.Drawing.Point(0, 0);
            this.EdName.Name = "EdName";
            this.EdName.Size = new System.Drawing.Size(235, 26);
            this.EdName.TabIndex = 0;
            this.EdName.TextChanged += new System.EventHandler(this.EdName_TextChanged);
            // 
            // EdSurname
            // 
            this.EdSurname.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EdSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdSurname.Location = new System.Drawing.Point(0, 119);
            this.EdSurname.Name = "EdSurname";
            this.EdSurname.Size = new System.Drawing.Size(235, 26);
            this.EdSurname.TabIndex = 1;
            this.EdSurname.TextChanged += new System.EventHandler(this.EdSurname_TextChanged);
            // 
            // EdNameHint
            // 
            this.EdNameHint.AutoSize = true;
            this.EdNameHint.BackColor = System.Drawing.SystemColors.Window;
            this.EdNameHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdNameHint.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.EdNameHint.Location = new System.Drawing.Point(8, 3);
            this.EdNameHint.Name = "EdNameHint";
            this.EdNameHint.Size = new System.Drawing.Size(39, 20);
            this.EdNameHint.TabIndex = 2;
            this.EdNameHint.Text = "Imię";
            // 
            // EdSurnameHint
            // 
            this.EdSurnameHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EdSurnameHint.AutoSize = true;
            this.EdSurnameHint.BackColor = System.Drawing.SystemColors.Window;
            this.EdSurnameHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EdSurnameHint.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.EdSurnameHint.Location = new System.Drawing.Point(8, 122);
            this.EdSurnameHint.Name = "EdSurnameHint";
            this.EdSurnameHint.Size = new System.Drawing.Size(76, 20);
            this.EdSurnameHint.TabIndex = 3;
            this.EdSurnameHint.Text = "Nazwisko";
            // 
            // DlgOpen
            // 
            this.DlgOpen.DefaultExt = "bmp";
            this.DlgOpen.FileName = "P:\\Barski\\Csharp\\Data*.bmp";
            this.DlgOpen.Filter = "Bitmapy (*.bmp)|*.bmp";
            this.DlgOpen.Title = "Wskaż zdjęcie pracownika ...";
            // 
            // WorkerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Client);
            this.Controls.Add(this.EdPhoto);
            this.Name = "WorkerControl";
            this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.Size = new System.Drawing.Size(343, 149);
            this.Resize += new System.EventHandler(this.WorkerControl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.EdPhoto)).EndInit();
            this.Client.ResumeLayout(false);
            this.Client.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox EdPhoto;
        private System.Windows.Forms.Panel Client;
        private System.Windows.Forms.TextBox EdSurname;
        private System.Windows.Forms.TextBox EdName;
        private System.Windows.Forms.Label EdSurnameHint;
        private System.Windows.Forms.Label EdNameHint;
        private System.Windows.Forms.OpenFileDialog DlgOpen;
    }
}
