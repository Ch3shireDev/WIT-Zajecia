using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
//Inicjalizacja zmiennych globalnych************************************************************************
        private int x = 8;              //szerokosc tablicy butonow
        private int y = 8;              //wysokosc tablicy butonow
        private int k = 6;              //ilosc kulek ogolnie
        private int maxk = 3;             //maxymalna ilosc kulek losowana
        private Button[] tab;         //tablica butonow - pole gry                                   ///nie musi byc zaznaczone ze chce dwuwymiarowa?
        private Image[] kulki;         //tablica kulek - bedziemy pobierac z tad obrazki kulek i ich wartosci
        private Button[] pictbox;          //w niej beda ukazane kulki ktore pokaza sie jako nastepne (automatycznie)
        private int xy = 0;           //to bedzie sprawdzało czy są jeszcze jakieś wolne miejsca na planszy chociaz w sumioe niepotxzrzebne
        private int ppi, ppj;
        
//Inicjalizacja zmiennych globalnych************************************************************************

//Konstruktor***********************************************************************************************
        public Form1()
        {
            InitializeComponent();
            tab = new Button[x * y];      //alokujemy pamiec do tablicy

            obrazki();
            tablicaButtonow();
            pictBoxAdd();
            playNext();


            for (int i = 0; i < x*y; ++i)
            {
               // for (int j = 0; j < y; ++j)
               // {
                    tab[x*y-1].Click += new System.EventHandler(this.button_First);
               // }
            }
        }
        //***********************************************************************************************************

        //Funkcja wrzucajaca losowo na plansze obrazki***************************************************************
        private void playNext()
        {
            Random rand = new Random();
            for (int i = 0; i < maxk; ++i)
            {
                if (pictbox[i].Tag != null && xy < x * y)     //czy to jest dobrze?
                {
                    int flag = 0;
                    int r;
                    while (flag == 0)
                    {
                        r = rand.Next() % (x * y);
                        if (tab[r].Tag.ToString() == "0")
                        {
                            tab[r].Image = pictbox[i].Image;
                            tab[r].Tag = pictbox[i].Tag;
                            tab[r].Text = (tab[r].Tag).ToString();           //tylko w celach kontrolnych
                            textBox1.AppendText(tab[r].Tag + "\t");
                            flag = 1;
                            xy++;
                        }
                    }
                }
                else
                {
                    //textBox1.AppendText("KONIEC!");                         // tu poprawic zeby sie na poczatku niewylowywawo blablabla
                }
            }
            generuj();
        }
//***********************************************************************************************************

        //Funkcja sprawdzajaca czy w rzedzie znajduje sie 5 takich samych obrazkow**********************************
        private void check_Buttons()
        {
            //int count = 1;  //liczy ile jest obok siebie takich samych pokemonow
            //int xxx = x;
            //int yyy = y;
            //int ff = 1;
            //while (ff == 1)
            //{
            //    if (count > 4)
            //        ff = 0;
            //    if (xxx >= 0 && xxx <= x)
            //    {
                    
            //    }

            //}
            ////pion

        }
        //***********************************************************************************************************


        //Funkcja przyporzadkowujaca rozne obrazki do buttonow*******************************************************
        private void generuj()
        {
            Random rand = new Random();
            
            for (int i = 0; i < maxk; ++i)
            {
                int r = rand.Next() % k;

                pictbox[i].Image = kulki[r];
                pictbox[i].Size = kulki[r].Size;
                txtbx.AppendText((r + 1).ToString() + "\t");
                pictbox[i].Tag = (r + 1).ToString();
            }
        }
        //***********************************************************************************************************

//Funkcja tworzaca 3 Buttony*********************************************************************************
        private void pictBoxAdd()
        {
            //tworzymy 3 picture boxy gdzie beda sie pokazywac kulki nastepne
            pictbox = new Button[3];
            for (int i = 0; i < maxk; ++i)
            {
                pictbox[i]=new Button();
                pictbox[i].Location = new System.Drawing.Point(30 + i * 57, 399);
                Controls.Add(pictbox[i]);
            }
        }
//***********************************************************************************************************



//Funkcja przydzielająca kazdemu elementowi tablicy obrazek**************************************************
        private void obrazki()
        {
            kulki = new Image[k];
            for (int i = 0; i < k; i++)
            {
                kulki[i] = Image.FromFile((i+1).ToString() + ".png");
            }
        }
//***********************************************************************************************************

//Funkcja tworzaca tablice buttonow - pole na ktorym bedzie toczyla sie rozgrywka****************************
        private void tablicaButtonow()
        {
            //tab = new Button[x * y];      //alokujemy pamiec do tablicy
            //Tworzymy Buttony w tablicy glownej(nie musismy klikac zeby je zrobic)
            for (int i = 0; i < x; ++i)
            {
                for (int j = 0; j < y; ++j)
                {
                    tab[i + j*x] = new Button();
                    tab[i + j * x].Location = new Point(283 + i * 57, 113 + j * 57);
                    tab[i + j * x].Size = new Size(57, 57);       //????
                    tab[i + j * x].BackColor = Color.Transparent;
                    tab[i + j * x].Tag = "0";          //to wazne bo kazdy ma miec wartosc ujemna
                    tab[i + j * x].Text = (tab[i + j * x].Tag).ToString();
                    tab[i + j * x].Name = "Button" + (i + j * x).ToString();    //to chyba nie przyda sie....
                    Controls.Add(tab[i + j * x]);
                }
            }
        }
//***********************************************************************************************************
        private void button111111_Click(object sender, EventArgs e)
        {
            playNext();
            check_Buttons();
            button_First(sender,e);
        }

        private void button_First(object sender, EventArgs e)
        {
            Button clickedbutton=(Button)sender;
            Point pp;
            clickedbutton = (Button)sender;
            pp = (Point)clickedbutton.Tag;
            ppi = pp.X;
            ppj = pp.Y;
            textBox2.AppendText(ppi + "\t");
        }



        
    }
}
