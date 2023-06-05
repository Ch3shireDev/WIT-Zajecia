using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;

namespace CircleCross
{

    public class frmCircleCross : System.Windows.Forms.Form
    {
        #region Form Initialization
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label2_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label3_1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label4_1;
        private System.Windows.Forms.PictureBox pic23;
        private System.Windows.Forms.PictureBox pic22;
        private System.Windows.Forms.PictureBox pic33;
        private System.Windows.Forms.PictureBox pic32;
        private System.Windows.Forms.PictureBox pic31;
        private System.Windows.Forms.PictureBox pic11;
        private System.Windows.Forms.PictureBox pic12;
        private System.Windows.Forms.PictureBox pic13;
        private System.Windows.Forms.PictureBox pic21;
        private System.Windows.Forms.PictureBox picWinner;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.StatusBar stbMessage;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem mnNew;
        private System.Windows.Forms.MenuItem mnExit;
        private System.Windows.Forms.MenuItem mnOnePlayer;
        private System.Windows.Forms.MenuItem mnTwoPlayers;
        private System.Windows.Forms.MenuItem mnStartServer;
        private System.Windows.Forms.MenuItem mnConnectServer;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem mnCPUX;
        private System.Windows.Forms.MenuItem mnCPUO;
        private System.Windows.Forms.MenuItem mnDifficultHard;
        private System.Windows.Forms.MenuItem mnDifficultEasy;
        private System.Windows.Forms.MenuItem mnDificuldade;
        private System.Windows.Forms.MenuItem mnRede;
        private System.Windows.Forms.MenuItem mnDifficultAverage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbScoreBall;
        private System.Windows.Forms.Label lbScoreCross;
        private System.Windows.Forms.Label lbScoreDraw;
        private System.Windows.Forms.Label lbMaches;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem mnResetScore;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem mnDisconnect;
        private System.Windows.Forms.ImageList ilKolkoKrzyzyk;
        private System.Windows.Forms.GroupBox gbScore;
        private System.ComponentModel.IContainer components;

        public frmCircleCross()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCircleCross));
            this.pic11 = new System.Windows.Forms.PictureBox();
            this.label0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic12 = new System.Windows.Forms.PictureBox();
            this.pic13 = new System.Windows.Forms.PictureBox();
            this.pic23 = new System.Windows.Forms.PictureBox();
            this.pic22 = new System.Windows.Forms.PictureBox();
            this.pic21 = new System.Windows.Forms.PictureBox();
            this.pic33 = new System.Windows.Forms.PictureBox();
            this.pic32 = new System.Windows.Forms.PictureBox();
            this.pic31 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label2_1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label3_1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label4_1 = new System.Windows.Forms.Label();
            this.picWinner = new System.Windows.Forms.PictureBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnNew = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnResetScore = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.mnExit = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.mnOnePlayer = new System.Windows.Forms.MenuItem();
            this.mnTwoPlayers = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnCPUX = new System.Windows.Forms.MenuItem();
            this.mnCPUO = new System.Windows.Forms.MenuItem();
            this.mnDificuldade = new System.Windows.Forms.MenuItem();
            this.mnDifficultEasy = new System.Windows.Forms.MenuItem();
            this.mnDifficultAverage = new System.Windows.Forms.MenuItem();
            this.mnDifficultHard = new System.Windows.Forms.MenuItem();
            this.mnRede = new System.Windows.Forms.MenuItem();
            this.mnStartServer = new System.Windows.Forms.MenuItem();
            this.mnConnectServer = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.mnDisconnect = new System.Windows.Forms.MenuItem();
            this.stbMessage = new System.Windows.Forms.StatusBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbScoreBall = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbScoreCross = new System.Windows.Forms.Label();
            this.lbScoreDraw = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbMaches = new System.Windows.Forms.Label();
            this.gbScore = new System.Windows.Forms.GroupBox();
            this.ilKolkoKrzyzyk = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWinner)).BeginInit();
            this.gbScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic11
            // 
            this.pic11.Location = new System.Drawing.Point(34, 27);
            this.pic11.Name = "pic11";
            this.pic11.Size = new System.Drawing.Size(62, 56);
            this.pic11.TabIndex = 0;
            this.pic11.TabStop = false;
            this.pic11.Click += new System.EventHandler(this.pic1_Click);
            // 
            // label0
            // 
            this.label0.BackColor = System.Drawing.Color.Gray;
            this.label0.Location = new System.Drawing.Point(21, 25);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(8, 212);
            this.label0.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(98, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(8, 212);
            this.label1.TabIndex = 1;
            // 
            // pic12
            // 
            this.pic12.Location = new System.Drawing.Point(109, 27);
            this.pic12.Name = "pic12";
            this.pic12.Size = new System.Drawing.Size(62, 56);
            this.pic12.TabIndex = 2;
            this.pic12.TabStop = false;
            this.pic12.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic13
            // 
            this.pic13.Location = new System.Drawing.Point(187, 27);
            this.pic13.Name = "pic13";
            this.pic13.Size = new System.Drawing.Size(62, 56);
            this.pic13.TabIndex = 3;
            this.pic13.TabStop = false;
            this.pic13.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic23
            // 
            this.pic23.Location = new System.Drawing.Point(187, 99);
            this.pic23.Name = "pic23";
            this.pic23.Size = new System.Drawing.Size(62, 56);
            this.pic23.TabIndex = 6;
            this.pic23.TabStop = false;
            this.pic23.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic22
            // 
            this.pic22.Location = new System.Drawing.Point(110, 97);
            this.pic22.Name = "pic22";
            this.pic22.Size = new System.Drawing.Size(62, 56);
            this.pic22.TabIndex = 5;
            this.pic22.TabStop = false;
            this.pic22.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic21
            // 
            this.pic21.Location = new System.Drawing.Point(34, 98);
            this.pic21.Name = "pic21";
            this.pic21.Size = new System.Drawing.Size(62, 56);
            this.pic21.TabIndex = 4;
            this.pic21.TabStop = false;
            this.pic21.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic33
            // 
            this.pic33.Location = new System.Drawing.Point(187, 170);
            this.pic33.Name = "pic33";
            this.pic33.Size = new System.Drawing.Size(62, 56);
            this.pic33.TabIndex = 9;
            this.pic33.TabStop = false;
            this.pic33.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic32
            // 
            this.pic32.Location = new System.Drawing.Point(110, 170);
            this.pic32.Name = "pic32";
            this.pic32.Size = new System.Drawing.Size(62, 56);
            this.pic32.TabIndex = 8;
            this.pic32.TabStop = false;
            this.pic32.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic31
            // 
            this.pic31.Location = new System.Drawing.Point(34, 170);
            this.pic31.Name = "pic31";
            this.pic31.Size = new System.Drawing.Size(62, 56);
            this.pic31.TabIndex = 7;
            this.pic31.TabStop = false;
            this.pic31.Click += new System.EventHandler(this.pic1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(175, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(8, 213);
            this.label2.TabIndex = 10;
            // 
            // label2_1
            // 
            this.label2_1.BackColor = System.Drawing.Color.Gray;
            this.label2_1.Location = new System.Drawing.Point(251, 25);
            this.label2_1.Name = "label2_1";
            this.label2_1.Size = new System.Drawing.Size(8, 213);
            this.label2_1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(21, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 11);
            this.label3.TabIndex = 11;
            // 
            // label3_1
            // 
            this.label3_1.BackColor = System.Drawing.Color.Gray;
            this.label3_1.Location = new System.Drawing.Point(21, 18);
            this.label3_1.Name = "label3_1";
            this.label3_1.Size = new System.Drawing.Size(238, 11);
            this.label3_1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(21, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 11);
            this.label4.TabIndex = 12;
            // 
            // label4_1
            // 
            this.label4_1.BackColor = System.Drawing.Color.Gray;
            this.label4_1.Location = new System.Drawing.Point(21, 230);
            this.label4_1.Name = "label4_1";
            this.label4_1.Size = new System.Drawing.Size(238, 11);
            this.label4_1.TabIndex = 12;
            // 
            // picWinner
            // 
            this.picWinner.Location = new System.Drawing.Point(0, 0);
            this.picWinner.Name = "picWinner";
            this.picWinner.Size = new System.Drawing.Size(287, 261);
            this.picWinner.TabIndex = 13;
            this.picWinner.TabStop = false;
            this.picWinner.Visible = false;
            this.picWinner.Paint += new System.Windows.Forms.PaintEventHandler(this.picWinner_Paint);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem5,
            this.mnDificuldade,
            this.mnRede});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnNew,
            this.menuItem3,
            this.mnResetScore,
            this.menuItem4,
            this.mnExit});
            this.menuItem1.Text = "&Gra";
            // 
            // mnNew
            // 
            this.mnNew.Index = 0;
            this.mnNew.Shortcut = System.Windows.Forms.Shortcut.F2;
            this.mnNew.Text = "&Nowa Gra";
            this.mnNew.Click += new System.EventHandler(this.mnNew_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "-";
            // 
            // mnResetScore
            // 
            this.mnResetScore.Index = 2;
            this.mnResetScore.Text = "&Resetuj wyniki";
            this.mnResetScore.Click += new System.EventHandler(this.mnResetScore_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 3;
            this.menuItem4.Text = "-";
            // 
            // mnExit
            // 
            this.mnExit.Index = 4;
            this.mnExit.Text = "&Wyjœcie";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnOnePlayer,
            this.mnTwoPlayers,
            this.menuItem2,
            this.mnCPUX,
            this.mnCPUO});
            this.menuItem5.Text = "&Multiplayer";
            // 
            // mnOnePlayer
            // 
            this.mnOnePlayer.Checked = true;
            this.mnOnePlayer.Index = 0;
            this.mnOnePlayer.Text = "&Jeden gracz";
            this.mnOnePlayer.Click += new System.EventHandler(this.mnOnePlayer_Click);
            // 
            // mnTwoPlayers
            // 
            this.mnTwoPlayers.Index = 1;
            this.mnTwoPlayers.Text = "&Dwóch graczy (network)";
            this.mnTwoPlayers.Click += new System.EventHandler(this.mnTwoPlayers_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.Text = "-";
            // 
            // mnCPUX
            // 
            this.mnCPUX.Checked = true;
            this.mnCPUX.Index = 3;
            this.mnCPUX.Text = "Komputer - &X";
            this.mnCPUX.Click += new System.EventHandler(this.mnCPUX_Click);
            // 
            // mnCPUO
            // 
            this.mnCPUO.Index = 4;
            this.mnCPUO.Text = "Komputer - &O";
            this.mnCPUO.Click += new System.EventHandler(this.mnCPUO_Click);
            // 
            // mnDificuldade
            // 
            this.mnDificuldade.Index = 2;
            this.mnDificuldade.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnDifficultEasy,
            this.mnDifficultAverage,
            this.mnDifficultHard});
            this.mnDificuldade.Text = "&Poziom gry";
            // 
            // mnDifficultEasy
            // 
            this.mnDifficultEasy.Index = 0;
            this.mnDifficultEasy.Text = "Easy";
            this.mnDifficultEasy.Click += new System.EventHandler(this.mnDifficultEasy_Click);
            // 
            // mnDifficultAverage
            // 
            this.mnDifficultAverage.Index = 1;
            this.mnDifficultAverage.Text = "Average";
            this.mnDifficultAverage.Click += new System.EventHandler(this.mnDifficultAverage_Click);
            // 
            // mnDifficultHard
            // 
            this.mnDifficultHard.Checked = true;
            this.mnDifficultHard.Index = 2;
            this.mnDifficultHard.Text = "Hard";
            this.mnDifficultHard.Click += new System.EventHandler(this.mnDifficultHard_Click);
            // 
            // mnRede
            // 
            this.mnRede.Index = 3;
            this.mnRede.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnStartServer,
            this.mnConnectServer,
            this.menuItem6,
            this.mnDisconnect});
            this.mnRede.Text = "&Network";
            // 
            // mnStartServer
            // 
            this.mnStartServer.Index = 0;
            this.mnStartServer.Text = "Start &server (nas³uchuj)";
            this.mnStartServer.Click += new System.EventHandler(this.mnStartServer_Click);
            // 
            // mnConnectServer
            // 
            this.mnConnectServer.Index = 1;
            this.mnConnectServer.Text = "&Connect to server";
            this.mnConnectServer.Click += new System.EventHandler(this.mnConnectServer_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 2;
            this.menuItem6.Text = "-";
            // 
            // mnDisconnect
            // 
            this.mnDisconnect.Enabled = false;
            this.mnDisconnect.Index = 3;
            this.mnDisconnect.Text = "&Disconnect";
            this.mnDisconnect.Click += new System.EventHandler(this.mnDisconnect_Click);
            // 
            // stbMessage
            // 
            this.stbMessage.Location = new System.Drawing.Point(0, 259);
            this.stbMessage.Name = "stbMessage";
            this.stbMessage.ShowPanels = true;
            this.stbMessage.Size = new System.Drawing.Size(472, 22);
            this.stbMessage.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(8, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Wyniki:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(15, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kó³ko:";
            // 
            // lbScoreBall
            // 
            this.lbScoreBall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbScoreBall.ForeColor = System.Drawing.Color.Blue;
            this.lbScoreBall.Location = new System.Drawing.Point(85, 72);
            this.lbScoreBall.Name = "lbScoreBall";
            this.lbScoreBall.Size = new System.Drawing.Size(49, 23);
            this.lbScoreBall.TabIndex = 17;
            this.lbScoreBall.Text = "0";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(15, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Krzy¿yk:";
            // 
            // lbScoreCross
            // 
            this.lbScoreCross.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbScoreCross.ForeColor = System.Drawing.Color.Red;
            this.lbScoreCross.Location = new System.Drawing.Point(85, 104);
            this.lbScoreCross.Name = "lbScoreCross";
            this.lbScoreCross.Size = new System.Drawing.Size(49, 23);
            this.lbScoreCross.TabIndex = 19;
            this.lbScoreCross.Text = "0";
            // 
            // lbScoreDraw
            // 
            this.lbScoreDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbScoreDraw.ForeColor = System.Drawing.Color.Green;
            this.lbScoreDraw.Location = new System.Drawing.Point(85, 136);
            this.lbScoreDraw.Name = "lbScoreDraw";
            this.lbScoreDraw.Size = new System.Drawing.Size(33, 23);
            this.lbScoreDraw.TabIndex = 21;
            this.lbScoreDraw.Text = "0";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(15, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "Remisy:";
            // 
            // lbMaches
            // 
            this.lbMaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbMaches.Location = new System.Drawing.Point(70, 34);
            this.lbMaches.Name = "lbMaches";
            this.lbMaches.Size = new System.Drawing.Size(80, 16);
            this.lbMaches.TabIndex = 22;
            this.lbMaches.Text = "0 matches";
            // 
            // gbScore
            // 
            this.gbScore.Controls.Add(this.label8);
            this.gbScore.Controls.Add(this.lbMaches);
            this.gbScore.Controls.Add(this.lbScoreCross);
            this.gbScore.Controls.Add(this.lbScoreDraw);
            this.gbScore.Controls.Add(this.label11);
            this.gbScore.Controls.Add(this.label5);
            this.gbScore.Controls.Add(this.label6);
            this.gbScore.Controls.Add(this.lbScoreBall);
            this.gbScore.Location = new System.Drawing.Point(7, 273);
            this.gbScore.Name = "gbScore";
            this.gbScore.Size = new System.Drawing.Size(160, 225);
            this.gbScore.TabIndex = 23;
            this.gbScore.TabStop = false;
            // 
            // ilKolkoKrzyzyk
            // 
            this.ilKolkoKrzyzyk.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilKolkoKrzyzyk.ImageStream")));
            this.ilKolkoKrzyzyk.TransparentColor = System.Drawing.Color.Transparent;
            this.ilKolkoKrzyzyk.Images.SetKeyName(0, "");
            this.ilKolkoKrzyzyk.Images.SetKeyName(1, "");
            // 
            // frmCircleCross
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 281);
            this.Controls.Add(this.gbScore);
            this.Controls.Add(this.stbMessage);
            this.Controls.Add(this.picWinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label4_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label3_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label2_1);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.pic33);
            this.Controls.Add(this.pic32);
            this.Controls.Add(this.pic31);
            this.Controls.Add(this.pic23);
            this.Controls.Add(this.pic22);
            this.Controls.Add(this.pic21);
            this.Controls.Add(this.pic13);
            this.Controls.Add(this.pic12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "frmCircleCross";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kolko & Krzyzyk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Closed += new System.EventHandler(this.frmCircleCross_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.pic11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWinner)).EndInit();
            this.gbScore.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        #region Variables/API calls
        GameAI objGameAI;
        Network objNetwork;
        public bool wNetworkPlay = false;
        int wNumberPlayers = 1;
        string wServerIP = "";
        public bool wServer = false;
        public bool wClient = false;
        int wScoreTotalMatches = 0;
        int wScoreBall = 0;
        int wScoreCross = 0;
        int wScoreDraw = 0;
        private enLineType wLineType = enLineType.Vertical;
        private int wLinePosition;
        public enDifficulty wDifficulty = enDifficulty.Hard;
        public enPlayType wTurn = enPlayType.Ball;
        public enPlayType wWinner = enPlayType.None;
        public enPlayType wTypeCPU = enPlayType.Cross;
        public enPlayType wTypePlayer = enPlayType.Ball;
        public enPlayType[,] wBoard = new enPlayType[4, 4] {{enPlayType.None,enPlayType.None,enPlayType.None,enPlayType.None},
															 {enPlayType.None,enPlayType.None,enPlayType.None,enPlayType.None},
															 {enPlayType.None,enPlayType.None,enPlayType.None,enPlayType.None},
															 {enPlayType.None,enPlayType.None,enPlayType.None,enPlayType.None}};
        [DllImport("GDI32.dll")]
        public static extern bool BitBlt(IntPtr hdcDest, int nXDest, int nYDest,
            int nWidth, int nHeight, IntPtr hdcSrc,
            int nXSrc, int nYSrc, int dwRop);
        #endregion
        #region Initializations

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new frmCircleCross());
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            stbMessage.Panels.Add("");
            stbMessage.Panels[0].AutoSize = StatusBarPanelAutoSize.Spring;
            gbScore.Location = new Point(290, 15);
            objNetwork = new Network(this);
            mnOnePlayer_Click(null, null);
        }
        #endregion
        #region Game (2 players)
        public void RestartGame()
        {
            picWinner.Visible = false;
            pic11.Image = null; pic12.Image = null; pic13.Image = null;
            pic21.Image = null; pic22.Image = null; pic23.Image = null;
            pic31.Image = null; pic32.Image = null; pic33.Image = null;
            wTurn = enPlayType.Ball;
            wWinner = enPlayType.None;
            SetStatusMessage("");

            wBoard = new enPlayType[4, 4] {{enPlayType.None,enPlayType.None,enPlayType.None,enPlayType.None},
																{enPlayType.None,enPlayType.None,enPlayType.None,enPlayType.None},
																{enPlayType.None,enPlayType.None,enPlayType.None,enPlayType.None},
																{enPlayType.None,enPlayType.None,enPlayType.None,enPlayType.None}};
            objGameAI = new GameAI(this);
            if ((wTypeCPU == enPlayType.Ball) && (wNumberPlayers == 1))
                objGameAI.MakeComputerMove();

        }
        private void pic1_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.PictureBox wImage = (System.Windows.Forms.PictureBox)(sender);
            string wNumber = ((System.Windows.Forms.Control)(((System.Windows.Forms.PictureBox)(sender)))).Name;
            int wRow = int.Parse(wNumber.Substring(3, 1));
            int wColumn = int.Parse(wNumber.Substring(4, 1));
            MakeMove(wRow, wColumn);
        }

        public void MakeMove(int pRow, int pColumn)
        {
            int wRow = pRow;
            int wColumn = pColumn;

            if ((stbMessage.Panels[0].Text == "Connecting...") ||
                (stbMessage.Panels[0].Text == "Waiting for connection..."))
                return;

            System.Windows.Forms.PictureBox wImage = pic11;

            if (wRow == 1 && wColumn == 1) wImage = pic11;
            if (wRow == 1 && wColumn == 2) wImage = pic12;
            if (wRow == 1 && wColumn == 3) wImage = pic13;
            if (wRow == 2 && wColumn == 1) wImage = pic21;
            if (wRow == 2 && wColumn == 2) wImage = pic22;
            if (wRow == 2 && wColumn == 3) wImage = pic23;
            if (wRow == 3 && wColumn == 1) wImage = pic31;
            if (wRow == 3 && wColumn == 2) wImage = pic32;
            if (wRow == 3 && wColumn == 3) wImage = pic33;

            if (((wServer == true) && (wTurn == enPlayType.Ball) && (wNetworkPlay == false)) ||
                 ((wClient == true) && (wTurn == enPlayType.Cross) && (wNetworkPlay == false)))
            {
                objNetwork.SendMove(wRow, wColumn);
            }
            else
            {
                if (((wServer == true) && (wTurn == enPlayType.Cross) && (wNetworkPlay == false)) ||
                    ((wClient == true) && (wTurn == enPlayType.Ball) && (wNetworkPlay == false)))
                    return;
            }
            if (wBoard[wRow, wColumn] == enPlayType.None)
            {
                wBoard[wRow, wColumn] = wTurn;
                if (wTurn == enPlayType.Cross)
                {
                    // Krzy¿yk - sczytuje z tablicy, która jest w MainForm.resx
                    wImage.Image = ilKolkoKrzyzyk.Images[0];
                    wImage.Refresh();
                    wTurn = enPlayType.Ball;
                }
                else
                {
                    // Kó³ko
                    wImage.Image = ilKolkoKrzyzyk.Images[1];
                    wImage.Refresh();
                    wTurn = enPlayType.Cross;
                }

                if (wWinner == enPlayType.None)
                {
                    // sprawdzenie czy ktos wygral
                    VerifyWinner();

                    if ((wTurn == wTypeCPU) && (wNumberPlayers == 1))
                        objGameAI.MakeComputerMove();
                }

            }	
            wNetworkPlay = false;
        }


        private void VerifyWinner()
        {
            // Funkcja do sprawdzania zwyciêzcy

            int wSum1 = (int)wBoard[1, 1] + (int)wBoard[1, 2] + (int)wBoard[1, 3];
            int wSum2 = (int)wBoard[2, 1] + (int)wBoard[2, 2] + (int)wBoard[2, 3];
            int wSum3 = (int)wBoard[3, 1] + (int)wBoard[3, 2] + (int)wBoard[3, 3];

            int wSum4 = (int)wBoard[1, 1] + (int)wBoard[2, 1] + (int)wBoard[3, 1];
            int wSum5 = (int)wBoard[1, 2] + (int)wBoard[2, 2] + (int)wBoard[3, 2];
            int wSum6 = (int)wBoard[1, 3] + (int)wBoard[2, 3] + (int)wBoard[3, 3];

            int wSum7 = (int)wBoard[1, 1] + (int)wBoard[2, 2] + (int)wBoard[3, 3];
            int wSum8 = (int)wBoard[3, 1] + (int)wBoard[2, 2] + (int)wBoard[1, 3];

            if ((wSum1 == 3) || (wSum2 == 3) || (wSum3 == 3) ||
                (wSum4 == 3) || (wSum5 == 3) || (wSum6 == 3) ||
                (wSum7 == 3) || (wSum8 == 3))
            {
                wWinner = enPlayType.Ball;
                SetStatusMessage("KÓ£KO wygrywa!");
                wScoreTotalMatches++;
                wScoreBall++;
                RefreshScore();

                goto winner;
            }
            if ((wSum1 == 30) || (wSum2 == 30) || (wSum3 == 30) ||
                (wSum4 == 30) || (wSum5 == 30) || (wSum6 == 30) ||
                (wSum7 == 30) || (wSum8 == 30))
            {
                wWinner = enPlayType.Cross;
                SetStatusMessage("KRZY¯YK wygrywa!");
                wScoreTotalMatches++;
                wScoreCross++;
                RefreshScore();
                goto winner;
            }

            bool wDraw = true;
            int e = 0;
            int f = 0;
            for (e = 1; e <= 3; e++)
                for (f = 1; f <= 3; f++)
                    if (wBoard[f, e] == enPlayType.None)
                    {
                        wDraw = false;
                        goto winner;
                    }
            if (wDraw == true)
            {
                SetStatusMessage("REMIS!");
                DrawLine(0, enLineType.Vertical);
                wScoreTotalMatches++;
                wScoreDraw++;
                RefreshScore();
                return;
            }
        winner:
            if ((wSum1 == 3) || (wSum1 == 30))
                DrawLine(1, enLineType.Horizontal);
            if ((wSum2 == 3) || (wSum2 == 30))
                DrawLine(2, enLineType.Horizontal);
            if ((wSum3 == 3) || (wSum3 == 30))
                DrawLine(3, enLineType.Horizontal);
            if ((wSum4 == 3) || (wSum4 == 30))
                DrawLine(1, enLineType.Vertical);
            if ((wSum5 == 3) || (wSum5 == 30))
                DrawLine(2, enLineType.Vertical);
            if ((wSum6 == 3) || (wSum6 == 30))
                DrawLine(3, enLineType.Vertical);
            if ((wSum7 == 3) || (wSum7 == 30))
                DrawLine(1, enLineType.DiagonalRight);
            if ((wSum8 == 3) || (wSum8 == 30))
                DrawLine(1, enLineType.DiagonalLeft);
        }
        private void DrawLine(int pPosition, enLineType pLineType)
        {
            wLinePosition = pPosition;
            wLineType = pLineType;
            Graphics g1 = this.CreateGraphics();
            Bitmap MyImage = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height, g1);
            Graphics g2 = Graphics.FromImage(MyImage);
            IntPtr dc1 = g1.GetHdc();
            IntPtr dc2 = g2.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            g1.ReleaseHdc(dc1);
            g2.ReleaseHdc(dc2);
            picWinner.Image = MyImage;
            object[] p = new object[1];
            p[0] = picWinner;
            picWinner.Invoke(new MakeVisibleHandler(MakeVisible), p);

        }
        public delegate void MakeVisibleHandler(Control control);

        public void MakeVisible(Control control)
        {
            control.Visible = true;
        }

        private void picWinner_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.RoyalBlue, 6);
            if (wWinner == enPlayType.Ball)
                myPen.Color = Color.RoyalBlue;
            if (wWinner == enPlayType.Cross)
                myPen.Color = Color.OrangeRed;
            switch (wLineType)
            {
                case enLineType.Horizontal:
                    {
                        e.Graphics.DrawLine(myPen, 25, 55 + (wLinePosition - 1) * 73, picWinner.Height - 10, 55 + (wLinePosition - 1) * 73);
                        break;
                    }
                case enLineType.Vertical:
                    {
                        e.Graphics.DrawLine(myPen, 65 + (wLinePosition - 1) * 75, 25, 65 + (wLinePosition - 1) * 75, picWinner.Width - 50);
                        break;
                    }
                case enLineType.DiagonalRight:
                    {
                        e.Graphics.DrawLine(myPen, 25, 25, picWinner.Height - 10, picWinner.Width - 65);
                        break;
                    }
                case enLineType.DiagonalLeft:
                    {
                        e.Graphics.DrawLine(myPen, picWinner.Height - 10, 25, 25, picWinner.Width - 55);
                        break;
                    }
            }
            myPen.Dispose();
        }
        private void RefreshScore()
        {
            lbMaches.Text = wScoreTotalMatches.ToString() + " matches";
            lbScoreBall.Text = wScoreBall.ToString();
            lbScoreCross.Text = wScoreCross.ToString();
            lbScoreDraw.Text = wScoreDraw.ToString();
        }
        public void SetStatusMessage(string pMensagem)
        {
            stbMessage.Panels[0].Text = pMensagem;
        }
        #endregion
        #region Menu
        private void mnNew_Click(object sender, System.EventArgs e)
        {
            if ((wClient == true) || (wServer == true))
                objNetwork.SendsRestartPacket();
            RestartGame();
        }

        private void mnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void mnResetScore_Click(object sender, System.EventArgs e)
        {
            wScoreTotalMatches = 0;
            wScoreBall = 0;
            wScoreCross = 0;
            wScoreDraw = 0;
            RefreshScore();
        }
        private void mnOnePlayer_Click(object sender, System.EventArgs e)
        {
            mnDisconnect_Click(null, null);
            wNumberPlayers = 1;
            mnTwoPlayers.Checked = false;
            mnOnePlayer.Checked = true;
            mnDificuldade.Enabled = true;
            mnCPUO.Enabled = true;
            mnCPUX.Enabled = true;
            mnCPUX_Click(null, null);
            mnRede.Enabled = false;
            RestartGame();
        }
        private void mnTwoPlayers_Click(object sender, System.EventArgs e)
        {
            wNumberPlayers = 2;
            mnOnePlayer.Checked = false;
            mnTwoPlayers.Checked = true;
            mnDificuldade.Enabled = false;
            mnCPUO.Enabled = false;
            mnCPUX.Enabled = false;
            mnRede.Enabled = true;
            RestartGame();
        }
        private void mnCPUX_Click(object sender, System.EventArgs e)
        {
            wTypeCPU = enPlayType.Cross;
            wTypePlayer = enPlayType.Ball;
            mnCPUO.Checked = false;
            mnCPUX.Checked = true;
            RestartGame();
        }
        private void mnCPUO_Click(object sender, System.EventArgs e)
        {
            wTypeCPU = enPlayType.Ball;
            wTypePlayer = enPlayType.Cross;
            mnCPUX.Checked = false;
            mnCPUO.Checked = true;
            RestartGame();
        }
        private void mnDifficultHard_Click(object sender, System.EventArgs e)
        {
            wDifficulty = enDifficulty.Hard;
            mnDifficultEasy.Checked = false;
            mnDifficultAverage.Checked = false;
            mnDifficultHard.Checked = true;
            RestartGame();
        }
        private void mnDifficultAverage_Click(object sender, System.EventArgs e)
        {
            wDifficulty = enDifficulty.Average;
            mnDifficultEasy.Checked = false;
            mnDifficultAverage.Checked = true;
            mnDifficultHard.Checked = false;
            RestartGame();
        }
        private void mnDifficultEasy_Click(object sender, System.EventArgs e)
        {
            mnDifficultEasy.Checked = true;
            mnDifficultAverage.Checked = false;
            mnDifficultHard.Checked = false;
            wDifficulty = enDifficulty.Easy;
            RestartGame();
        }
        private void mnStartServer_Click(object sender, System.EventArgs e)
        {
            wServer = true;
            objNetwork.StartServer();
            SetStatusMessage("Waiting for connection...");
            mnConnectServer.Enabled = false;
            mnStartServer.Enabled = false;
            mnDisconnect.Enabled = true;
        }
        private void mnConnectServer_Click(object sender, System.EventArgs e)
        {
            DialogResult wDialog = InputBox.ShowInputBox("What is the server Name/IP?", "Server name", wServerIP, ref wServerIP);
            if (wDialog == DialogResult.Cancel)
                return;
            wClient = true;
            objNetwork.ConnectServer(wServerIP);
            SetStatusMessage("Connecting...");
            mnConnectServer.Enabled = false;
            mnStartServer.Enabled = false;
            mnDisconnect.Enabled = true;
        }
        private void frmCircleCross_Closed(object sender, System.EventArgs e)
        {
            if ((wServer == true) || (wClient == true))
            objNetwork.Disconnect();
        }
        public void mnDisconnect_Click(object sender, System.EventArgs e)
        {
            objNetwork.Disconnect();
            wServer = false;
            wClient = false;
            mnConnectServer.Enabled = true;
            mnStartServer.Enabled = true;
            mnDisconnect.Enabled = false;
            RestartGame();
        }
        #endregion
    }
}