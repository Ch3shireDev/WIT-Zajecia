using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace kulki
{
    public partial class gameOver : Form
    {
        //konstruktor okna końca gry, jako argument przyjmuje gracza, który zwyciężył bądź remis
        public gameOver(string gracz)
        {
            InitializeComponent();
            //wyświetlanie komunikatów o wyniku rozgrywki
            if(gracz == "remis")
                this.alert.AppendText("Rozgrywka zakończona remisem.\r\nCo chcesz dalej zrobić?");
            else
                this.alert.AppendText("Gracz " + gracz + " zwycięża! Gratulacje!\r\nCo chcesz dalej zrobić?");
        }
        public void uruchom()
        {
            Application.Run(new gameGUI());
        }
        //obługa zdarzenia włączenia nowej gry po wciśnięciu przycisku "Nowa gra"
        private void game_over_new_game_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(uruchom)); //utworzenie nowego wątku
            t.Start(); //uruchomienie nowego wątku, włączającego nową aplikację
            Application.ExitThread(); //zakończenie bieżącego wątku
        }
        //obsługa zdarzenia związanego z wciśnięciem "Zakończ" i wyłączenia aplikacji
        private void exit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
        //zamknięcie gry po kliknięciu na trofeum
        private void trophy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
