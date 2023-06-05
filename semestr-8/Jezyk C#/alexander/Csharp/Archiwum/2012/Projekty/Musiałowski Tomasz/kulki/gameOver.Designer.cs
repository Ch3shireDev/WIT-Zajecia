namespace kulki
{
    partial class gameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameOver));
            this.game_over_new_game = new System.Windows.Forms.Button();
            this.alert = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.trophy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trophy)).BeginInit();
            this.SuspendLayout();
            // 
            // game_over_new_game
            // 
            this.game_over_new_game.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.game_over_new_game.Location = new System.Drawing.Point(12, 74);
            this.game_over_new_game.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this.game_over_new_game.Name = "game_over_new_game";
            this.game_over_new_game.Size = new System.Drawing.Size(75, 23);
            this.game_over_new_game.TabIndex = 0;
            this.game_over_new_game.Text = "Nowa gra";
            this.game_over_new_game.UseVisualStyleBackColor = true;
            this.game_over_new_game.Click += new System.EventHandler(this.game_over_new_game_Click);
            // 
            // alert
            // 
            this.alert.BackColor = System.Drawing.SystemColors.Menu;
            this.alert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alert.Location = new System.Drawing.Point(12, 11);
            this.alert.Multiline = true;
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(185, 53);
            this.alert.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(93, 74);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 3;
            this.exit.Text = "Zakończ";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // trophy
            // 
            this.trophy.Image = ((System.Drawing.Image)(resources.GetObject("trophy.Image")));
            this.trophy.Location = new System.Drawing.Point(203, 12);
            this.trophy.Name = "trophy";
            this.trophy.Size = new System.Drawing.Size(55, 83);
            this.trophy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trophy.TabIndex = 2;
            this.trophy.TabStop = false;
            this.trophy.Click += new System.EventHandler(this.trophy_Click);
            // 
            // gameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 109);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.alert);
            this.Controls.Add(this.game_over_new_game);
            this.Controls.Add(this.trophy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "gameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Koniec gry";
            ((System.ComponentModel.ISupportInitialize)(this.trophy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button game_over_new_game;
        private System.Windows.Forms.TextBox alert;
        private System.Windows.Forms.PictureBox trophy;
        private System.Windows.Forms.Button exit;
    }
}