namespace PgDatabase
{
    partial class PersonEdit
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
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lbSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtPESEL = new System.Windows.Forms.TextBox();
            this.lbPESEL = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lbAdres = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(12, 23);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(191, 20);
            this.txtSurname.TabIndex = 7;
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(9, 7);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(53, 13);
            this.lbSurname.TabIndex = 6;
            this.lbSurname.Text = "Nazwisko";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 20);
            this.txtName.TabIndex = 9;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(9, 52);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(26, 13);
            this.lbName.TabIndex = 8;
            this.lbName.Text = "Imie";
            // 
            // txtPESEL
            // 
            this.txtPESEL.Location = new System.Drawing.Point(12, 118);
            this.txtPESEL.Name = "txtPESEL";
            this.txtPESEL.Size = new System.Drawing.Size(70, 20);
            this.txtPESEL.TabIndex = 11;
            // 
            // lbPESEL
            // 
            this.lbPESEL.AutoSize = true;
            this.lbPESEL.Location = new System.Drawing.Point(9, 102);
            this.lbPESEL.Name = "lbPESEL";
            this.lbPESEL.Size = new System.Drawing.Size(41, 13);
            this.lbPESEL.TabIndex = 10;
            this.lbPESEL.Text = "PESEL";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(12, 167);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(423, 20);
            this.txtAdres.TabIndex = 13;
            // 
            // lbAdres
            // 
            this.lbAdres.AutoSize = true;
            this.lbAdres.Location = new System.Drawing.Point(9, 151);
            this.lbAdres.Name = "lbAdres";
            this.lbAdres.Size = new System.Drawing.Size(34, 13);
            this.lbAdres.TabIndex = 12;
            this.lbAdres.Text = "Adres";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Rezygnuj";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(379, 227);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 15;
            this.btnAccept.Text = "Akceptuj";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // PersonEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 262);
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
            this.Name = "PersonEdit";
            this.Text = "PersonEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtPESEL;
        private System.Windows.Forms.Label lbPESEL;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lbAdres;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
    }
}