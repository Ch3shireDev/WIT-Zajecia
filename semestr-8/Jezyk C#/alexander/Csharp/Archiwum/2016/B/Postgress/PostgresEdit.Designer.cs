namespace Postgress
{
    partial class PostgresEdit
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lbAdres = new System.Windows.Forms.Label();
            this.txtPESEL = new System.Windows.Forms.TextBox();
            this.lbPESEL = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lbSurname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(287, 203);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 25;
            this.btnAccept.Text = "Akceptuj";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(15, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Rezygnuj";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtAdres
            // 
            this.txtAdres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdres.Location = new System.Drawing.Point(15, 169);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(347, 20);
            this.txtAdres.TabIndex = 23;
            // 
            // lbAdres
            // 
            this.lbAdres.AutoSize = true;
            this.lbAdres.Location = new System.Drawing.Point(12, 153);
            this.lbAdres.Name = "lbAdres";
            this.lbAdres.Size = new System.Drawing.Size(34, 13);
            this.lbAdres.TabIndex = 22;
            this.lbAdres.Text = "Adres";
            // 
            // txtPESEL
            // 
            this.txtPESEL.Location = new System.Drawing.Point(15, 120);
            this.txtPESEL.Name = "txtPESEL";
            this.txtPESEL.Size = new System.Drawing.Size(70, 20);
            this.txtPESEL.TabIndex = 21;
            // 
            // lbPESEL
            // 
            this.lbPESEL.AutoSize = true;
            this.lbPESEL.Location = new System.Drawing.Point(12, 104);
            this.lbPESEL.Name = "lbPESEL";
            this.lbPESEL.Size = new System.Drawing.Size(41, 13);
            this.lbPESEL.TabIndex = 20;
            this.lbPESEL.Text = "PESEL";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 20);
            this.txtName.TabIndex = 19;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 54);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(26, 13);
            this.lbName.TabIndex = 18;
            this.lbName.Text = "Imie";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(15, 25);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(191, 20);
            this.txtSurname.TabIndex = 17;
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(12, 9);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(53, 13);
            this.lbSurname.TabIndex = 16;
            this.lbSurname.Text = "Nazwisko";
            // 
            // PostgresEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 239);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lbAdres);
            this.Controls.Add(this.txtPESEL);
            this.Controls.Add(this.lbPESEL);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lbSurname);
            this.MinimumSize = new System.Drawing.Size(390, 277);
            this.Name = "PostgresEdit";
            this.Text = "PostgresEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lbAdres;
        private System.Windows.Forms.TextBox txtPESEL;
        private System.Windows.Forms.Label lbPESEL;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lbSurname;
    }
}