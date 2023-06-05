using System.Windows.Forms;
using System.IO;
namespace kulki
{
    partial class gameGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameGUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.graToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaGraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAutorzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.kolejka = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kolejka)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // graToolStripMenuItem
            // 
            this.graToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaGraToolStripMenuItem,
            this.ustawieniaToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.graToolStripMenuItem.Name = "graToolStripMenuItem";
            this.graToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.graToolStripMenuItem.Text = "Gra";
            // 
            // nowaGraToolStripMenuItem
            // 
            this.nowaGraToolStripMenuItem.Name = "nowaGraToolStripMenuItem";
            this.nowaGraToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.nowaGraToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.nowaGraToolStripMenuItem.Text = "Nowa gra";
            this.nowaGraToolStripMenuItem.Click += new System.EventHandler(this.nowaGraToolStripMenuItem_Click);
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.Image = global::kulki.Properties.Resources.settings;
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            this.ustawieniaToolStripMenuItem.Click += new System.EventHandler(this.ustawieniaToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Image = global::kulki.Properties.Resources.close;
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oAutorzeToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // oAutorzeToolStripMenuItem
            // 
            this.oAutorzeToolStripMenuItem.Name = "oAutorzeToolStripMenuItem";
            this.oAutorzeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.oAutorzeToolStripMenuItem.Text = "O aplikacji";
            this.oAutorzeToolStripMenuItem.Click += new System.EventHandler(this.oAutorzeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ruch gracza:";
            // 
            // kolejka
            // 
            this.kolejka.Location = new System.Drawing.Point(89, 26);
            this.kolejka.Name = "kolejka";
            this.kolejka.Size = new System.Drawing.Size(16, 16);
            this.kolejka.TabIndex = 4;
            this.kolejka.TabStop = false;
            // 
            // gameGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.kolejka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "gameGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gomoku";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kolejka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public int tura = 1;
        public int ile;
        public int widthFields;
        public int heightFields;
        private int iconSet;
        private int overSound;
        private int fieldSound;
        private int gameMode;
        private string data;
        public int[,] tab1; //tablica punktów dla gracza zielonego
        public int[,] tab2; //tablic punktów dla gracza czerwonego
        private int[,] taktyczna1;
        private int[,] taktyczna2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem graToolStripMenuItem;
        private ToolStripMenuItem nowaGraToolStripMenuItem;
        private ToolStripMenuItem zakończToolStripMenuItem;
        private ToolStripMenuItem ustawieniaToolStripMenuItem;
        private FileStream plik;
        private StreamReader gameSetting;
        private string[] setting;
        private ToolStripMenuItem pomocToolStripMenuItem;
        private ToolStripMenuItem oAutorzeToolStripMenuItem;
        private Label label1;
        private PictureBox kolejka;
    }
}