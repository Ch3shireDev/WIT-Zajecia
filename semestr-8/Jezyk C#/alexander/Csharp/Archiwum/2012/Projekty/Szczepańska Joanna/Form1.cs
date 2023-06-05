using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication5
{
    
    public partial class Form1 : Form
    {

#region Inicjalizacja zmiennych globalnych************************************************************************
        private int x = 9;              ///szerokosc tablicy butonow
        private int y = 9;              ///wysokosc tablicy butonow
        private int k = 6;              ///ilosc kwadratow ogolnie
        private int maxk = 3;             ///maxymalna ilosc kwadratow losowana
        private Button[][] tab;         ///tablica butonow - pole gry
        private Color[] kwadraty;         ///tablica kwadratow - bedziemy pobierac z tad kolory kwadratow i ich wartosci
        private Button[] pictbox;         ///w niej beda ukazane kwadraty ktore pokaza sie jako nastepne (automatycznie)niepotxzrzebne
        private XY first;
        private int xy = 3;           ///to bedzie sprawdzało czy są jeszcze jakieś wolne miejsca na planszy chociaz w sumioe 
        private XY last;             ///W tych zmiennych przechowujemy koordynaty wcisnietego buttona(pierwszego i drugiego)
        private Button clickedbutton;   ///Ogólnie wcisniety button
        private int pts = 0;            //punkty
        private int f = 0;              ///Flaga, 0 oznacza pierwszy button 1 oznacza drugi button
        private int w = 0;              ///Flaga, 0 oznacza ze nie zniszczylismy kulek a 1 ze zniszczylismy
        private int[][] labtab ;          ///Tablica dwuwymiarowa okreslajaca najkrotsza droge do punktu docelowego
        private int licznik = 1;        ///Zlicza ile razy z rzedu usunelismy kwadraty
        private PictureBox punkty;      //PictureBox odpowiedzialny za punkty
        private PictureBox nastepne;      //PictureBox odpowiedzialny za "nastepne"
        private Label lPts;              //Liczba punktow
        Form mainn;                 //nasz podstawowy form
        

#endregion Inicjalizacja zmiennych globalnych************************************************************************

#region Konstruktor Form1
        /// <summary>
        /// Konstruktor
        /// wywoływane są w nim wszystkie funkcje
        /// </summary>
        public Form1(Form frm, int OXY, int OK)
        {
            mainn = frm;
            x = OXY;
            y = OXY;
            k = OK;
            InitializeComponent();
            punkty = new PictureBox();
            grafika();
            

            generujkolory();
            playNext();
           
            //this.Visible = true;
        }
#endregion
        /*
        private void Splashform()
        {
            Splash newsplash = new Splash();
            newsplash.ShowDialog();
            newsplash.Dispose();
        }*/

        #region playNEXT
        ///<summary>
        /// Funkcja playNext
        /// wyrzuca losowo na plansze obrazki przy kazdym ruchu
        ///</summary>
        private void playNext()
        {
            Random rand = new Random();
            for (int i = 0; i < maxk; ++i)      //sa 3 kwadraty wylosowane dla kazdej z nich:
            {
                if (ifNotNull())     //sprawza czy jest wolne miejsce na planszy jezeli tak to
                {
                    int flag = 0;               //flaga na 0
                    int r1, r2;                 //losowe x i y
                    while (flag == 0)           //dopoki flaga jest rowna 0
                    {
                        r1 = rand.Next() % (x); //losuj x
                        r2 = rand.Next() % (y); //losuj y

                        if (tab[r1][r2].BackColor == Color.Transparent)  //jezeli button x y nie bedzie miec obrazka
                        {
                            tab[r1][r2].BackColor = pictbox[i].BackColor;   //przypisz mu 1 element z wygenerwoanych 3 obrazkow
                            flag = 1;   //ustaw flage na 1
                        }
                        //jezeli buton x y ma obrazek to flaga nadal jest 0 dzieki czemu mozemy szukac innego wolnego miesjca
                    }
                }
            }
            ifNotNull();
            if (w == 1)
            {
                KoniecGry kon = new KoniecGry(this,pts);
                kon.ShowDialog();
                this.Close();
            }
            generujkolory();
        }
#endregion
#region ifNotNull
        private bool ifNotNull()
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; ++j)
                {
                    if (tab[i][j].BackColor== Color.Transparent)
                    {
                        return true;
                    }
                }
            }
            w = 1;
            return false;
        }
#endregion
#region generuj
        /// <summary>
        /// Funkcja generuj
        /// jej zadaniem jest wylosowanie trzech kolorow ktore beda przeslane na pole gry gdy sie ruszymy 
        /// </summary>
        private void generujkolory()
        {
            Random rand = new Random();

            for (int i = 0; i < maxk; ++i)
            {
                int r = rand.Next() % k;

                pictbox[i].BackColor = kwadraty[r];
 //               txtbx.AppendText((r + 1).ToString() + "\t");
                //pictbox[i].Tag = (r + 1).ToString();
            }
        }
#endregion
#region button_Click
        /// <summary>
        /// Funkcja button_Click
        /// Odpowiedzialna za klikniecie buttona. Sprawdza czy najpierw zostal klikniety button pierwszy czy drugi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            clickedbutton = (Button)sender;     //Buttonowi clickedbutton przypisujemy klikniety button
            Point pp = new Point();             //Tworzymy obiekt point
            pp = (Point)clickedbutton.Tag;      //Rzutujemy wartosc w tagu na Pointa(ktora wrzucilismy wczesniej) dzieki temu uzyskalismy x i y 
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; ++j)
                {
                    labtab[i][j] = 0;
                }
            }

            if (f == 0 && clickedbutton.BackColor != Color.Transparent)  //jezeli flaga ustawiona jest na 0 to znaczy ze wcisnales buttona ktory ma byc przesuniety
            {
                first = new XY(pp.X,pp.Y);
                f = 1;
                //textBox2.Text = "F: " + clickedbutton.Tag.ToString() + "\n";
            }
            else if (f == 1 && clickedbutton.BackColor != Color.Transparent)     //jezeli wcisnales inny button to wtedy on jest aktwyny
            {
                first = new XY(pp.X, pp.Y);
                //textBox2.Text = "F: " + clickedbutton.Tag.ToString() + "\n";
            }
            else if (f == 1 && clickedbutton.BackColor == Color.Transparent)
            {
                last = new XY(pp.X, pp.Y);
                shortest_Way(first, last);
                f = 0;
         //       textBox2.AppendText("L: " + clickedbutton.Tag.ToString());
            }
        }
#endregion
#region isOutOfMap
        private bool isOutOfMap(XY check)
        {
            if (check.px < 0 || check.py < 0 || check.py >= y || check.px >= x)
                return true;
            return false;
        }
#endregion
#region shortest way
        /// <summary>
        /// Funkcja szuka najkrotszej drogi do elementu ktory nacisnelismy numerujac poszczegolne mozliwosci od 1 do ostatniego buttona np 7
        /// </summary>
        /// <param name="first"></param>
        /// <param name="last"></param>
        private void shortest_Way(XY first, XY last)
        {
            XY[] dirtab = { new XY(1, 0), new XY(0, 1), new XY(-1, 0), new XY(0, -1) };     // prawo lewo dol gora - kierunki
            labtab[first.px][first.py] = 1;     //buttonowi ktory nacisnelismy przypisujemy wartos 1 poniewaz od niego zaczymamy
            XY pomv = new XY(0,0);      //tu 0,0 przypisalam ale moze da sie przeciazyc jeszcze jakos konstruktor.....
            XY pomw = new XY(0,0);

            Queue<XY> q = new Queue<XY>();  //kolejka do ktorej beda wrzucane kolejne kroki
            q.Enqueue(first);       //wrzucamy pierwszy button do kolejki

            while (q.Count > 0) //dopoki kolejka nie jest pusta wykonuj:
            {
                pomv.px = q.Peek().px;  //przypisujemy do zmiennej pomocniczej pomv polozenie elementu ktory jest pierwszy w kolejce 
                pomv.py = q.Peek().py;  //w tym przypadku jest to button ktory kliknelismy
                
                q.Dequeue();    //usuwamy pierwszy element z kolejki
                                //(bo przypisalismy juz wartosci do zmiennej pomocniczej a drugi raz buttona nie bedziemy rozpatrywac)

                for (int d = 0; d < 4; ++d) //sizeof tablica?
                {
                    pomw.px = pomv.px + dirtab[d].px;   //do kolejnej zmiennej pomocniczej pomw przypisujemy wartosci naokolo buttona pomw 
                    pomw.py = pomv.py + dirtab[d].py;   //za kazdym razem bedzie to inna wartosc(z tablicy dirtab)

                    if (!isOutOfMap(pomw))  //jezeli pomw nie wychodzi poza granice mapy
                    {
                        //jezeli pomw jest puste i nie ma tam obrazka
                        if (labtab[pomw.px][pomw.py] == 0 && tab[pomw.px][pomw.py].BackColor == Color.Transparent)
                        {
                            labtab[pomw.px][pomw.py] = labtab[pomv.px][pomv.py] + 1;    //wartosc w pomw jest o 1 wieksza niz wartosc w pomv
                            q.Enqueue(pomw);    //wrzucamy pomw do kolejki poniewaz nadaje sie do rozpatrywania
                        }
                        //jezeli pomw jest rowny buttonowi ktory nacisnelismy jako drugi to
                        if (pomw.px == last.px && pomw.py == last.py)   
                        {
                            d = 4;  //ustaw wartosc do wartosci poczatkowiej        mozna dac d=4 i d--
                            while (q.Count > 0) //dopoki kolejka nie jest pusta
                            { q.Dequeue(); }    //usuwaj elementy z kolejki
                            labtab[pomw.px][pomw.py] = labtab[pomv.px][pomv.py] + 1;    //pomw(ostatni element) +1
                            createWay(first, pomw, dirtab);         //stworz droge
                            //playNext();
                            move_Button(first, last);
                        }
                    }
                }
            }
        }
#endregion
#region create Way
        /// <summary>
        /// Funkcja createWay na podstawie funkcji shorthestWay tworzy droge idac od konca czyli np od 7 do 1
        /// </summary>
        /// <param name="first"></param>
        /// <param name="actuallast"></param>
        /// <param name="dirtab"></param>
        private void createWay(XY first, XY actuallast, XY[] dirtab)
        {
            List<XY> q = new List<XY>();        //stworz liste q
            XY pom = new XY(0, 0);

            int odlx = last.px - first.px;
            int odly = last.py - first.py;
            //dopoki aktualnie rozpatrywany element jest rozny od pierwszego
            while (actuallast.px != first.px && actuallast.py != first.py)  
            {
                q.Add(actuallast);  //dodaj do listy ten element
                for (int i = 0; i < 4; ++i)
                {
                    
                    pom.px = actuallast.px + dirtab[i].px;      //przypisujemy do zmiennej pomocniczej wartosci naookolo rozpatrywanego elementu
                    pom.py = actuallast.py + dirtab[i].py;
                    if (!isOutOfMap(pom))//jezeli pom nie wykracza poza tablice
                    {
                        //jezeli wartosc przechowywana pod parametrami pom jest taka sama jak wartosc w rozpatrywanym parametrze -1
                        if (labtab[pom.px][pom.py] == labtab[actuallast.px][actuallast.py] - 1)
                        {
                            actuallast.px = pom.px; //to przypisz wartosc pom wartosci rozpatrywanej(od teraz zmieniamy glowna wartosc)
                            actuallast.py = pom.py;
                            q.Add(actuallast);

                            //move_Button(first, actuallast);   
                            i = 0;  //ustaw wartosc do wartosci poczatkowej
                            
                        }
                    }
                }
            }
            
            //move_Button(actuallast, last); 
            //move2(q);
        }
#endregion
#region move Button
        /// <summary>
        /// Funkcja move_Button()
        /// odpowiedzialna za znalezienie najkrotszej drogi do miejsca docelowego(drugiego buttona).
        /// Sprawdza czy da sie tam dotrzec
        /// </summary>
        private void move_Button(XY first, XY last)
        {
            if (tab[last.px][last.py].BackColor == Color.Transparent)
            {
                tab[last.px][last.py].BackColor = tab[first.px][first.py].BackColor;            //przypisuje kolor
                tab[first.px][first.py].BackColor = Color.Transparent;                                   //usuwa kolor
            }

            check_Buttons(last);
            
            //playNext();
        }
#endregion
#region check_Button
        ///<summary>
        ///Funkcja check_Buttons()
        ///Jej zadaniem jest sprawdzenie czy obok siebie znajduje się 5 takich samych buttonow
        ///</summary> 
        private void check_Buttons(XY last)
        {
            int count = 1;  //liczy ile jest obok siebie takich samych kulek

            XY[,] dirPts = new XY[,]
                            { 
                                { new XY(1, 0), new XY(-1, 0) },                    //poziom
                                { new XY(0, 1), new XY(0, -1) },                    //pion
                                { new XY(1, 1), new XY(-1, -1) },                   // skos 1
                                { new XY(1, -1), new XY(-1, 1) }                    // skos 2
                            };

            Stack<XY> lst = new Stack<XY>();        //Stos - potrzebujemy tutaj opcji LIFO
            XY poms = new XY();                     //pozyycja o 1 mniejsza/wieksza w zaleznosci od tablicy dirPts
            XY pom= new XY(last.px,last.py);        //aktualna pozycja
            Color temp = tab[last.px][last.py].BackColor;   //Zmienna pomocnicza przetrzymujaca kolor buttona ktorym sie obslugujemy
            int fwin = 0;   //Flaga jezeli nie zniszczymy 5 kulek w linni lub po skosie na tablice wyrzucane sa kolejne 3 kwadraty 
                            //w przeciwnym przypadku mozemy grac dalej


            //lst.Push(pom);  //dodajemy last na stos 

            for (int i = 0; i < 4; ++i)
            {
                
                for (int j = 0; j < 2; ++j)
                {
                    int ff = 1;     //flaga odpowiedzialna za sprawdzenie czy sa takie same
                    while (ff == 1)
                    {
                        poms.px = pom.px + dirPts[i, j].px;    
                        poms.py = pom.py + dirPts[i, j].py;
                        if (!isOutOfMap(poms))  //Jezeli wartosci z pomocniczej zmiennej nie znajduja sie poza granicami mapy rob:
                        {
                            if (temp != tab[poms.px][poms.py].BackColor) //Sprawdzamy tutaj czy obrazki sa takie same
                            {
                                ff = 0; //jezeli nie to ustawiamy flage na 0 i wychodzimy z wwhilea
                            }
                            else
                            {
                                count++;                //zliczamy ile jest obok siebie takich samych obrazkow
                                pom.px = pom.px + dirPts[i, j].px;
                                pom.py = pom.py + dirPts[i, j].py;
                                lst.Push(pom);      //dodajemy je nastepnie na stos
                            }
                        }
                        else
                            ff = 0;     //Jezeli wartosci z pomocniczej zmiennej nie znajduja sie poza granicami mapy to wychodzimy z whilea
                    }
                    pom.px = last.px;   //Zmienna pomocnicza pom znowu wskazuje na kulke ktora przenieslesmy
                    pom.py = last.py;   //
                }
                    lst.Push(pom);  //dodajemy last na stos
                if (count < 5)          //Jezeli count ma wartosc ponizej 5, czyli obok siebie nie znajduje sie 5 kulek to wyczysc stos i ustaw count na 1
                {
                    lst.Clear();
                    count = 1;
                }
                else                    //jezeli mamy 5 kulek w rzedzie lub po linii to usuwamy je
                {
                    int punkty = 0;
                    foreach (XY value in lst)
                    {
                        //dla kazdej wartosci w stosie wyzeruj button
                        tab[value.px][value.py].BackColor = Color.Transparent;
                        punkty++;
                        count = 1;
                        fwin = 1;
                    }
                    pts = pts+ punkty * licznik;
                    licznik++;
                    lst.Clear();
                    //lst.Push(pom);  //znowu dodajemy last na stos
                }
                

            }
            if (fwin == 0)  //Jezeli nie zniszczylismy zadnych kulek to wyrzuc na plansze jeszcze 3
            {
                licznik = 1;
                playNext();
            }
            lPts.Text = pts.ToString();
            //textBox3.AppendText(xy + "  ");
        }
#endregion
#region Zamkniecie 
        public void Closee()
        {
            mainn.Show();
            this.Close();
        }
#endregion
#region FUNKCJE ODPOWIEDZIALNE ZA TWORZENIE OBIEKTOW--------------------------------------------------------------------/
        #region pictBoxAdd
        /// <summary>
        /// Funkcja pictBoxAdd()
        /// jej zadaniem jest stworzenie 3 buttonow i ustalenie lokacji dla nich  //dodac to pozniej do ogolnych buttonow
        /// </summary>
        private void pictBoxAdd()
        {
            //tworzymy 3 picture boxy gdzie beda sie pokazywac kwadraty nastepne
            pictbox = new Button[3];
            for (int i = 0; i < maxk; ++i)
            {
                pictbox[i] = new Button();
                pictbox[i].FlatStyle = FlatStyle.Flat;
                pictbox[i].Size = new Size(30, 30);
                pictbox[i].Location = new System.Drawing.Point(74 + i * 34, 305);
                
                Controls.Add(pictbox[i]);
            }
        }
        #endregion
        #region obrazki
        /// <summary>
        /// Funkcja obrazki
        /// Jej zadaniem jest przydzielenie kazdemu elementowi tablicy obrazka. Wywowylana tylko raz
        /// </summary>
        private void kolory()
        {
            kwadraty = new Color[k];
            kwadraty[0] = Color.Blue;
            kwadraty[1] = Color.BlueViolet;
            kwadraty[2] = Color.Crimson;
            kwadraty[3] = Color.LimeGreen;
            kwadraty[4] = Color.DarkOrange;
            
            if (k > 5)
            {
                kwadraty[5] = Color.DeepPink;
            }
            if (k > 6)
            {
                kwadraty[6]= Color.Gold;
            }
            if (k > 7)
            {
                kwadraty[7] = Color.LightGreen;
            }
            if (k > 8)
            {
                kwadraty[8] = Color.Cyan;
            }
        }
        #endregion
        #region grafika
        /// <summary>
        /// Ta funkcja odpala wszystkie funkcje ktore sa wywolywane tylko raz zeby nie zasmiecac kodu gdzie indziej
        /// </summary>
        public void grafika()
        {
            //TABLICA BUTTONOW
            tablicaButtonow();

            kolory();
            pictBoxAdd();

            this.BackgroundImage = Image.FromFile("pattern.png");
            //PUNKTY - picture box
            punkty = new PictureBox();
            punkty.Image = Image.FromFile("punkty.png");
            punkty.Location = new Point(30, 45);
            punkty.Size = punkty.Image.Size;
            punkty.Name = "punkty";
            punkty.BackColor = Color.Transparent;
            punkty.SendToBack();
            Controls.Add(punkty);

            //NASTEPNE - picture box
            nastepne = new PictureBox();
            nastepne.Image = Image.FromFile("nastepne.png");
            nastepne.Location = new Point(30, 255);
            nastepne.Size = nastepne.Image.Size;
            nastepne.Name = "nastepne";
            nastepne.BackColor = Color.Transparent;
            Controls.Add(nastepne);

            //LICZBA PUNKTOW
            lPts = new Label();
            lPts.Location = new Point(55, 101);
            lPts.Font = new Font("Arial", 19.25F);
            lPts.Size = new Size(40, 25);
            lPts.Text = "0";
            lPts.Name = "lpts";
            lPts.BackColor = Color.Transparent;
            Controls.Add(lPts);
            lPts.BringToFront();

            

            
        }
        #endregion
        /// <summary>
        /// Funkcja tabliaButtonow
        /// Jej zadaniem jest stworzenie pola gry na ktorym bedzie toczyła sie rozgrywka
        /// </summary>
        private void tablicaButtonow()
        {
            tab = new Button[x][];      //alokujemy pamiec do tablicy
            labtab = new int[x][];
            for (int i = 0; i < x; ++i)
            {
                tab[i] = new Button[y];
                labtab[i] = new int[y];
            }
            //Tworzymy Buttony w tablicy glownej
            for (int i = 0; i < x; ++i)
            {
                for (int j = 0; j < y; ++j)
                {
                    tab[i][j] = new Button();           //tworzenie obiekitu
                    tab[i][j].Location = new Point(255 + i * 30, 45 + j * 30); //miejsce na planszy
                    tab[i][j].Size = new Size(30, 30);       //rozmiar
                    tab[i][j].BackColor = Color.Transparent;
                    tab[i][j].FlatStyle = FlatStyle.Flat;
                    tab[i][j].Tag = new Point(i, j);          //to wazne bo dzieki temu sprawdzamy czy kwadrat obok ma taka sama wartosc
                    tab[i][j].Name = "Button[" + (i).ToString() + (j).ToString() + "]";    //nazwa np Button[2][7]
                    tab[i][j].Click += new System.EventHandler(this.button_Click);
                    labtab[i][j] = 0;
                   // tab[i][j].Text = i.ToString() + " " + j.ToString();                 // takie testowe tylko
                    Controls.Add(tab[i][j]);
                }
            }
        }
        //----------------------------------------------------------------------------------------------------------------/
#endregion


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainn.Show();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            w = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pts = pts + 5;
        }


    }

#region struktura XY
    struct XY
    {
        private int x, y;
        public XY(int xx, int yy)
        {
            x = xx;
            y = yy;
        }

        public int px
        {
            get { return x; }
            set { x = value; }
        }
        public int py
        {
            get { return y; }
            set { y = value; }

        }
    }
    
}
#endregion