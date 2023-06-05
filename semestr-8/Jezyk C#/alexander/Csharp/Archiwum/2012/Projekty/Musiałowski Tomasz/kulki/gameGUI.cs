using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace kulki
{
    public partial class gameGUI : Form
    {
        public gameGUI()
        {
            InitializeComponent();
            readSettings(); //wczytanie ustawień z pliku settings.conf
            generateGameFields(); //wygenerowanie buttonów umożliwiających rozgrywkę
            data = DateTime.Now.ToShortDateString()+" "+DateTime.Now.Hour+"h "+DateTime.Now.Minute+"min "+DateTime.Now.Second+"s.txt";
            //ustalenie wielkości okna w zależności od ilości wygnenerowanych buttonów
            this.Size = new System.Drawing.Size(19 * widthFields + 44, 19 * heightFields + 102);
            //inicjalizacja tabel zawierających informacje o ilości sąsiadujących ze sobą pionków
            tab1 = new int[heightFields + 2, widthFields + 2];
            tab2 = new int[heightFields + 2, widthFields + 2];
            //taktyczna do AI (do rozwinięcia kiedy indziej)
            taktyczna1 = new int[heightFields + 2, widthFields + 2];
            taktyczna2 = new int[heightFields + 2, widthFields + 2];
            //wypełnienie tablic zliczających pionki w rzędzie wartością początkową -1
            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int j = 0; j < tab1.GetLength(1); j++)
                {
                    tab1[i, j] = -1;
                }
            }
            for (int i = 0; i < tab2.GetLength(0); i++)
            {
                for (int j = 0; j < tab2.GetLength(1); j++)
                {
                    tab2[i, j] = -1;
                }
            }
            //tablice dla AI
            for (int i = 0; i < taktyczna1.GetLength(0); i++)
            {
                for (int j = 0; j < taktyczna1.GetLength(1); j++)
                {
                    taktyczna1[i, j] = 0;
                }
            }
            for (int i = 0; i < taktyczna2.GetLength(0); i++)
            {
                for (int j = 0; j < taktyczna2.GetLength(1); j++)
                {
                    taktyczna2[i, j] = 0;
                }
            }
            //ustawienie początkowej informacji o tym, który pionek rozpocznie grę
            //w zależności od tego, który zestaw ikon został ustawiony
            if (iconSet == 0)
                kolejka.Image = Properties.Resources.player1;
            if (iconSet == 1)
                kolejka.Image = Properties.Resources.windows;
            if (iconSet == 2)
                kolejka.Image = Properties.Resources.angel;
        }
        //wycztanie ustawień gry z pliku settings.conf
        private void readSettings()
        {
            string pom; //zmienna do przechowywania lini treści pliku
            int i = 0; //licznik linijek
            setting = new string[7]; //tablica przechowująca wartość ustawień
            //ustawienie wartości domyślnych, w razie gdyby jakiś idiota usunął plik settings.conf
            setting[0] = "15"; //ilość pól na szerkość
            setting[1] = "15"; //ilość pól na wysokość
            setting[2] = "5"; //liczba pól w rzędzie potrzebna do wygranej
            setting[3] = "0"; //numer zestawu ikon 0 - kulki, 1 - OS, 2 - anioły/demony
            setting[4] = "1"; //włączenie dźwięku na koniec gry, informującego o zwycięstwie (złośliwy śmiech)
            setting[5] = "1"; //włączenie dźwięku zajmowania pól
            setting[6] = "1"; //tryb rozgrywki 0 - gracz vs gracz 1 - gracz vs cpu
            try
            {
                plik = new FileStream("settings.conf", FileMode.Open); //próba otwarcia pliku settings.conf zawierającego ustawienia gry
            }
            catch (FileNotFoundException)
            {
                //w razie niepowodzenia zostanie wyświetlony komunikat o błędzie
                MessageBox.Show("Błąd pliku konfiguracyjnego settings.conf. Plik nie istnieje lub nie można utworzyć pliku.\r\nBłąd ten prawdopodobnie zostanie usunięty przy kolejnym uruchomieniu aplikacji.", "Błąd konfiguracyjny", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //próba otwarcia lub utworzenia pliku settings.conf
                plik = new FileStream("settings.conf", FileMode.OpenOrCreate);
                //zmienna do pisania do pliku
                StreamWriter save = new StreamWriter(plik);
                //wpisanie domyślnych ustawień
                save.Write(setting[0] + "\r\n" + setting[1] + "\r\n" + setting[2] + "\r\n" + setting[3] + "\r\n" + setting[4] + "\r\n" + setting[5] + "\r\n" + setting[6]);
                //zakończenie pracy z plikiem i całej aplikacji
                //powinna się ona wczytać bezproblemowo po ponownym jej otworzeniu
                save.Flush();
                save.Close();
                this.Close();
                return;
            }
            gameSetting = new StreamReader(plik);
            pom = gameSetting.ReadLine();
            while (pom != null)
            {
                setting[i] = pom;
                i++;
                pom = gameSetting.ReadLine();
            }
            this.widthFields = Convert.ToInt32(setting[0]);
            this.heightFields = Convert.ToInt32(setting[1]);
            if (setting[6] == "0")
                this.ile = Convert.ToInt32(setting[2]);
            else
                this.ile = 5;
            this.iconSet = Convert.ToInt32(setting[3]);
            this.overSound = Convert.ToInt32(setting[4]);
            this.fieldSound = Convert.ToInt32(setting[5]);
            this.gameMode = Convert.ToInt32(setting[6]);
            plik.Close();
            gameSetting.Close();
        }
        //uruchomienie aplikacji
        private void uruchom()
        {
            Application.Run(new gameGUI());
        }
        //uruchominie nowego okna, ustawienie tablic na wartości domyślne
        private void nowaGra()
        {
            //wstawienie do całych tablic zliczających sąsiadujące pionki początkowych wartości
            for (int i = 0; i < tab1.GetLength(0); i++)
            {
                for (int j = 0; j < tab1.GetLength(1); j++)
                {
                    tab1[i, j] = -1;
                }
            }
            for (int i = 0; i < tab2.GetLength(0); i++)
            {
                for (int j = 0; j < tab2.GetLength(1); j++)
                {
                    tab2[i, j] = -1;
                }
            }
            //utworzenie nowego wątku, uruchamiającego nową aplikację
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(uruchom));
            //uruchomienie nowego wątku
            t.Start();
            //zamknięcie starego wątku
            Application.ExitThread();
        }
        //ustawienie pionka na planszy, przyznanie punktów dla pól
        private void ustaw(int i, int j, int[,] tablica, int[,] przeciwnika)
        {
            //skopiowanie pozycji punktu
            int copy_i = i;
            int copy_j = j;
            int ir = i; //będzie obliczony indeks i w przeciwnym kierunku
            int jr = j; //będzie obliczony indeks j w przeciwnym kierunku
            int rzad = 1; //zmienna przetrzymująca informację o ilości pionków w rzędzie
            tablica[i, j] = 0; //ustawienie dla wybranego wartości 0, czyli wartości pola gdy ustawiony jest na niej pionek
            przeciwnika[i, j] = -2;
            //ustalenie dla, którego gracza ma być ustalanie punktów wokół jego punktu
            //ustawienie pkt dla lewego górnego rogu i prawego dolnego
            //sytuacja gdy z lewej górnej strony jest już ustawiony pionek
            while (tablica[i - 1, j - 1] == 0)
            {
                i--;
                j--;
                rzad++;
            }
            //sytuacja gdy z prawej dolnej strony jest już ustawiony pionek
            while (tablica[ir + 1, jr + 1] == 0)
            {
                ir++;
                jr++;
                rzad++;
            }
            if (tablica[i - 1, j - 1] < rzad && tablica[i - 1, j - 1] != -2 || rzad >= 5)
                tablica[i - 1, j - 1] = rzad;
            if (tablica[ir + 1, jr + 1] < rzad && tablica[ir + 1, jr + 1] != -2 || rzad >= 5)
                tablica[ir + 1, jr + 1] = rzad;
            //wczytujemy początkowe współrzędne
            i = copy_i;
            j = copy_j;
            ir = i;
            jr = j;
            rzad = 1;
            //sytuacja gdy z prawej górnej strony jest już ustawiony pionek
            while (tablica[i - 1, j + 1] == 0)
            {
                i--;
                j++;
                rzad++;
            }
            //sytuacja gdy z lewej dolnej strony jest już ustawiony pionek
            while (tablica[ir + 1, jr - 1] == 0)
            {
                ir++;
                jr--;
                rzad++;
            }
            if (tablica[i - 1, j + 1] < rzad && tablica[i - 1, j + 1] != -2 || rzad >= 5)
                tablica[i - 1, j + 1] = rzad;
            if (tablica[ir + 1, jr - 1] < rzad && tablica[ir + 1, jr - 1] != -2 || rzad >= 5)
                tablica[ir + 1, jr - 1] = rzad;
            //wczytujemy początkowe współrzędne
            i = copy_i;
            j = copy_j;
            ir = i;
            jr = j;
            rzad = 1;
            //sytuacja gdy z górnej strony jest już ustawiony pionek
            while (tablica[i - 1, j] == 0)
            {
                i--;
                rzad++;
            }
            //sytuacja gdy z dolnej strony jest już ustawiony pionek
            while (tablica[ir + 1, jr] == 0)
            {
                ir++;
                rzad++;
            }
            if (tablica[i - 1, j] < rzad && tablica[i - 1, j] != -2 || rzad >= 5)
                tablica[i - 1, j] = rzad;
            if (tablica[ir + 1, jr] < rzad && tablica[ir + 1, jr] != -2 || rzad >= 5)
                tablica[ir + 1, jr] = rzad;
            //wczytujemy początkowe współrzędne
            i = copy_i;
            j = copy_j;
            ir = i;
            jr = j;
            rzad = 1;
            //sytuacja gdy z lewej strony jest już ustawiony pionek
            while (tablica[i, j - 1] == 0)
            {
                j--;
                rzad++;
            }
            //sytuacja gdy z prawej strony jest już ustawiony pionek
            while (tablica[ir, jr + 1] == 0)
            {
                jr++;
                rzad++;
            }
            if (tablica[i, j - 1] < rzad && tablica[i, j - 1] != -2 || rzad >= 5)
                tablica[i, j - 1] = rzad;
            if (tablica[ir, jr + 1] < rzad && tablica[ir, jr + 1] != -2 || rzad >= 5)
                tablica[ir, jr + 1] = rzad;
            //tymczasowe wysyłanie tablicy taktycznej do pliku
            /*if (tura % 2 == 1)
            {
                FileStream plik = new FileStream("taktyczna.txt", FileMode.Append);
                StreamWriter tab = new StreamWriter(plik);
                if (tura % 2 == 1)
                    tab.WriteLine("Gracz 1: ");
                else
                    tab.WriteLine("Gracz 2: ");
                tab.Write("\r\n");
                for (int y = 0; y < tablica.GetLength(0); y++)
                {
                    for (int x = 0; x < tablica.GetLength(1); x++)
                    {
                        if (tablica[y, x] == -1)
                        {
                            tab.Write("[.]");
                        }
                        else
                        {
                            if (tablica[y, x] == 0)
                            {
                                tab.Write("[@]");
                            }
                            else
                            {
                                if (tablica[y, x] == -2)
                                {
                                    tab.Write("[!]");
                                }
                                else
                                {
                                    tab.Write("[" + tablica[y, x] + "]");
                                }
                            }
                        }
                    }
                    tab.Write("\r\n");
                }
                tab.Write("\r\n");
                tab.Flush();
                tab.Close();
            }*/
        }
        private int sumaTab(int[,] tablica)
        {
            int suma = 0;
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    if (tablica[i, j] > 0 || tab1[i, j] == -2)
                        suma += tablica[i, j];
                }
            }
            return suma;
        }
        private void zapiszTab(int[,] tablica)
        {
            FileStream plik = new FileStream("taktyczna.txt", FileMode.Append);
            StreamWriter tab = new StreamWriter(plik);
            if (tura % 2 == 1)
                tab.WriteLine("Gracz 1: ");
            else
                tab.WriteLine("Gracz 2: ");
            tab.Write("\r\n");
            for (int y = 0; y < tablica.GetLength(0); y++)
            {
                for (int x = 0; x < tablica.GetLength(1); x++)
                {
                    if (tablica[y, x] == -1)
                    {
                        tab.Write("[.]");
                    }
                    else
                    {
                        if (tablica[y, x] == 0)
                        {
                            tab.Write("[@]");
                        }
                        else
                        {
                            if (tablica[y, x] == -2)
                            {
                                tab.Write("[!]");
                            }
                            else
                            {
                                tab.Write("[" + tablica[y, x] + "]");
                            }
                        }
                    }
                }
                tab.Write("\r\n");
            }
            tab.Write("\r\n");
            tab.Flush();
            tab.Close();
        }
        private void ruch_AI()
        {
            int ruchAI_i = -4;
            int ruchAI_j = -4;
            int danger = 0;
            int[,] tab1_copy = new int[widthFields + 2, heightFields + 2];
            int[,] tab2_copy = new int[widthFields + 2, heightFields + 2];
            int suma1 = 0;
            int suma2 = 0;
            int max = -999999;
            //int uklad4 = 0;
            int win = 0;
            int finish = 0;
            for (int i = 1; i <= widthFields; i++)
            {
                for (int j = 1; j <= heightFields; j++)
                {
                    if (tab1[i, j] > 0)
                    {
                        suma1 = 0;
                        suma2 = 0;
                        Array.Copy(tab1, tab1_copy, tab1.Length);
                        Array.Copy(tab2, tab2_copy, tab2.Length);
                        ustaw(i, j, tab1_copy, tab2_copy);
                        suma1 = sumaTab(tab1_copy);
                        //MessageBox.Show("Weszło tu przy współrzędnej P(" + i + ", " + j + ") i wartości tablicy " + tab1[i, j] + "\r\n" + "Suma: " + suma1);
                        if (suma1 > max)
                        {
                            ruchAI_i = i;
                            ruchAI_j = j;
                            //MessageBox.Show("ruchAI_i = " + ruchAI_i + "\r\nruchAI_j = " + ruchAI_j);
                            max = suma1;
                        }
                    }
                }
            }
            /*if (ustalonoPkt == 1)
                MessageBox.Show("Ustalono punkt: [" + ruchAI_i + "][" + ruchAI_j + "]");*/
            //wyszukanie ruchu kończącego dla komputerowego gracza
            for (int i = 1; i <= widthFields; i++)
            {
                for (int j = 1; j <= heightFields; j++)
                {
                    if (tab2[i, j] == 4)
                    {
                        ruchAI_i = i;
                        ruchAI_j = j;
                        finish = 1;
                    }
                }
            }
            //wyszukanie ruchów kończących
            if (finish == 0)
            {
                for (int i = 1; i <= widthFields; i++)
                {
                    for (int j = 1; j <= heightFields; j++)
                    {
                        if (tab1[i, j] == 4)
                        {
                            ruchAI_i = i;
                            ruchAI_j = j;
                            danger = 2;
                        }
                        // UKŁAD oo-oo, o-ooo, ooo-o
                        if (j <= widthFields - 5)
                        {
                            //poziomo oo-oo
                            if (tab1[i, j] == 0 && tab1[i, j + 1] == 0 && tab1[i, j + 2] != 0 && tab1[i, j + 2] != -2 && tab1[i, j + 3] == 0 && tab1[i, j + 4] == 0)
                            {
                                ruchAI_j = j + 2;
                                ruchAI_i = i;
                                danger = 2;
                            }
                            //poziomo o-ooo
                            if (tab1[i, j] == 0 && tab1[i, j + 1] != 0 && tab1[i, j + 1] != -2 && tab1[i, j + 2] == 0 && tab1[i, j + 3] == 0 && tab1[i, j + 4] == 0)
                            {
                                ruchAI_j = j + 1;
                                ruchAI_i = i;
                                danger = 2;
                            }
                            //poziomo ooo-o
                            if (tab1[i, j] == 0 && tab1[i, j + 1] == 0 && tab1[i, j + 2] == 0 && tab1[i, j + 3] != 0 && tab1[i, j + 3] != -2 && tab1[i, j + 4] == 0)
                            {
                                ruchAI_j = j + 3;
                                ruchAI_i = i;
                                danger = 2;
                            }
                            //po ukosie w stronę prawego dolnego rogu
                            if (i <= heightFields - 5)
                            {
                                //oo-oo
                                if (tab1[i, j] == 0 && tab1[i + 1, j + 1] == 0 && tab1[i + 2, j + 2] != 0 && tab1[i + 2, j + 2] != -2 && tab1[i + 3, j + 3] == 0 && tab1[i + 4, j + 4] == 0)
                                {
                                    ruchAI_i = i + 2;
                                    ruchAI_j = j + 2;
                                    danger = 2;
                                }
                                //o-ooo
                                if (tab1[i, j] == 0 && tab1[i + 1, j + 1] != 0 && tab1[i + 1, j + 1] != -2 && tab1[i + 2, j + 2] == 0 && tab1[i + 3, j + 3] == 0 && tab1[i + 4, j + 4] == 0)
                                {
                                    ruchAI_j = j + 1;
                                    ruchAI_i = i + 1;
                                    danger = 2;
                                }
                                //ooo-o
                                if (tab1[i, j] == 0 && tab1[i + 1, j + 1] == 0 && tab1[i + 2, j + 2] == 0 && tab1[i + 3, j + 3] != 0 && tab1[i + 3, j + 3] != -2 && tab1[i + 4, j + 4] == 0)
                                {
                                    ruchAI_j = j + 3;
                                    ruchAI_i = i + 3;
                                    danger = 2;
                                }
                            }
                        }
                        //sprawdzenie w pionie układu oo-oo
                        if (i <= heightFields - 5)
                        {
                            //oo-oo
                            if (tab1[i, j] == 0 && tab1[i + 1, j] == 0 && tab1[i + 2, j] != 0 && tab1[i + 2, j] != -2 && tab1[i + 3, j] == 0 && tab1[i + 4, j] == 0)
                            {
                                ruchAI_i = i + 2;
                                ruchAI_j = j;
                                danger = 2;
                            }
                            //poziomo o-ooo
                            if (tab1[i, j] == 0 && tab1[i + 1, j] != 0 && tab1[i + 1, j] != -2 && tab1[i + 2, j] == 0 && tab1[i + 3, j] == 0 && tab1[i + 4, j] == 0)
                            {
                                ruchAI_j = j;
                                ruchAI_i = i + 1;
                                danger = 2;
                            }
                            //poziomo ooo-o
                            if (tab1[i, j] == 0 && tab1[i + 1, j] == 0 && tab1[i + 2, j] == 0 && tab1[i + 3, j] != 0 && tab1[i + 3, j] != -2 && tab1[i + 4, j] == 0)
                            {
                                ruchAI_j = j;
                                ruchAI_i = i + 3;
                                danger = 2;
                            }
                        }
                        //sprawdzenie po ukosie w stronę lewego dolnego rogu układu oo-oo
                        if (j >= 6 && i <= heightFields - 5)
                        {
                            //oo-oo
                            if (tab1[i, j] == 0 && tab1[i + 1, j - 1] == 0 && tab1[i + 2, j - 2] != 0 && tab1[i + 2, j - 2] != -2 && tab1[i + 3, j - 3] == 0 && tab1[i + 4, j - 4] == 0)
                            {
                                ruchAI_i = i + 2;
                                ruchAI_j = j - 2;
                                danger = 2;
                            }
                            //o-ooo
                            if (tab1[i, j] == 0 && tab1[i + 1, j - 1] != 0 && tab1[i + 1, j - 1] != -2 && tab1[i + 2, j - 2] == 0 && tab1[i + 3, j - 3] == 0 && tab1[i + 4, j - 4] == 0)
                            {
                                ruchAI_j = j - 1;
                                ruchAI_i = i + 1;
                                danger = 2;
                            }
                            //ooo-o
                            if (tab1[i, j] == 0 && tab1[i + 1, j - 1] == 0 && tab1[i + 2, j - 2] == 0 && tab1[i + 3, j - 3] != 0 && tab1[i + 3, j - 3] != -2 && tab1[i + 4, j - 4] == 0)
                            {
                                ruchAI_j = j - 3;
                                ruchAI_i = i + 3;
                                danger = 2;
                            }
                        }
                    }
                }
            }
            //SPRAWDZENIE CZY KOMPUTEROWY GRACZ MOŻE WPROWADZIĆ STAN ZAGROŻENIA DLA PRZECIWNIKA
            if (danger != 2 && finish == 0)
            {
                for (int i = 1; i <= widthFields; i++)
                {
                    for (int j = 1; j <= heightFields; j++)
                    {
                        // UKŁADY: -oo-o- i -o-oo-
                        if (j <= widthFields - 5)
                        {
                            //poziomo -oo-o-
                            if (tab2[i, j] != 0 && tab2[i, j] != -2 && tab2[i, j + 1] == 0 && tab2[i, j + 2] == 0 && tab2[i, j + 3] != 0 && tab2[i, j + 3] != -2 && tab2[i, j + 4] == 0 && tab2[i, j + 5] != 0 && tab2[i, j + 5] != -2)
                            {
                                ruchAI_j = j + 3;
                                ruchAI_i = i;
                                win = 1;
                            }
                            //poziomo -o-oo-
                            if (tab2[i, j] != 0 && tab2[i, j] != -2 && tab2[i, j + 1] == 0 && tab2[i, j + 2] != 0 && tab2[i, j + 2] != -2 && tab2[i, j + 3] == 0 && tab2[i, j + 4] == 0 && tab2[i, j + 5] != 0 && tab2[i, j + 5] != -2)
                            {
                                ruchAI_j = j + 2;
                                ruchAI_i = i;
                                win = 1;
                            }
                            //po ukosie w stronę prawego dolnego rogu
                            if (i <= heightFields - 5)
                            {
                                //-oo-o-
                                if (tab2[i, j] != 0 && tab2[i, j] != -2 && tab2[i + 1, j + 1] == 0 && tab2[i + 2, j + 2] == 0 && tab2[i + 3, j + 3] != 0 && tab2[i + 3, j + 3] != -2 && tab2[i + 4, j + 4] == 0 && tab2[i + 5, j + 5] != 0 && tab2[i + 5, j + 5] != -2)
                                {
                                    ruchAI_i = i + 3;
                                    ruchAI_j = j + 3;
                                    win = 1;
                                }
                                //-o-oo-
                                if (tab2[i, j] != 0 && tab2[i, j] != -2 && tab2[i + 1, j + 1] == 0 && tab2[i + 2, j + 2] != 0 && tab2[i + 2, j + 2] != -2 && tab2[i + 3, j + 3] == 0 && tab2[i + 4, j + 4] == 0 && tab2[i + 5, j + 5] != 0 && tab2[i + 5, j + 5] != -2)
                                {
                                    ruchAI_i = i + 2;
                                    ruchAI_j = j + 2;
                                    win = 1;
                                }
                            }
                        }
                        //sprawdzenie w pionie układów: -oo-o- i -o-oo-
                        if (i <= heightFields - 5)
                        {
                            //-oo-o-
                            if (tab2[i, j] != 0 && tab2[i, j] != -2 && tab2[i + 1, j] == 0 && tab2[i + 2, j] == 0 && tab2[i + 3, j] != 0 && tab2[i + 3, j] != -2 && tab2[i + 4, j] == 0 && tab2[i + 5, j] != 0 && tab2[i + 5, j] != -2)
                            {
                                ruchAI_i = i + 3;
                                ruchAI_j = j;
                                win = 1;
                            }
                            //-o-oo-
                            if (tab2[i, j] != 0 && tab2[i, j] != -2 && tab2[i + 1, j] == 0 && tab2[i + 2, j] != 0 && tab2[i + 2, j] != -2 && tab2[i + 3, j] == 0 && tab2[i + 4, j] == 0 && tab2[i + 5, j] != 0 && tab2[i + 5, j] != -2)
                            {
                                ruchAI_i = i + 2;
                                ruchAI_j = j;
                                win = 1;
                            }
                        }
                        //sprawdzenie po ukosie w stronę lewego dolnego rogu układów: -oo-o- i -o-oo-
                        if (j >= 6 && i <= heightFields - 5)
                        {
                            //-oo-o-
                            if (tab2[i, j] != 0 && tab2[i, j] != -2 && tab2[i + 1, j - 1] == 0 && tab2[i + 2, j - 2] == 0 && tab2[i + 3, j - 3] != 0 && tab2[i + 3, j - 3] != -2 && tab2[i + 4, j - 4] == 0 && tab2[i + 5, j - 5] != 0 && tab2[i + 5, j - 5] != -2)
                            {
                                ruchAI_i = i + 3;
                                ruchAI_j = j - 3;
                                win = 1;
                            }
                            //-o-oo-
                            if (tab2[i, j] != 0 && tab2[i, j] != -2 && tab2[i + 1, j - 1] == 0 && tab2[i + 2, j - 2] != 0 && tab2[i + 2, j - 2] != -2 && tab2[i + 3, j - 3] == 0 && tab2[i + 4, j - 4] == 0 && tab2[i + 5, j - 5] != 0 && tab2[i + 5, j - 5] != -2)
                            {
                                ruchAI_i = i + 2;
                                ruchAI_j = j - 2;
                                win = 1;
                            }
                        }
                        //UKŁAD -ooo-
                        if (j <= widthFields - 4)
                        {
                            //w poziomie
                            if (tab2[i, j] != 0 && tab2[i, j] != -2 && tab2[i, j + 1] == 0 && tab2[i, j + 2] == 0 && tab2[i, j + 3] == 0 && tab2[i, j + 4] != 0 && tab2[i, j + 4] != -2)
                            {
                                //wyzerowanie sum
                                suma1 = 0;
                                suma2 = 0;
                                //kopiujemy tablicę gracza i przeciwnika
                                Array.Copy(tab2, tab2_copy, tab2.Length);
                                Array.Copy(tab2, tab2_copy, tab2.Length);
                                //testowe ustawienie pionka w polu i, j + 2 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                ustaw(i, j, tab2_copy, tab2_copy);
                                //obliczenie wygenerowanej sumy
                                suma1 = sumaTab(tab2_copy);
                                //kopiujemy na nowo tablicę gracza i przeciwnika
                                Array.Copy(tab2, tab2_copy, tab2.Length);
                                Array.Copy(tab2, tab2_copy, tab2.Length);
                                //testowe ustawienie pionka w polu i, j + 4 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                ustaw(i, j + 4, tab2_copy, tab2_copy);
                                //obliczenie wygenerowanej sumy
                                suma2 = sumaTab(tab2_copy);
                                //wybranie ruchu, który wygenerował większą sumę
                                if (suma1 > suma2)
                                    ruchAI_j = j;
                                else
                                    ruchAI_j = j + 4;
                                ruchAI_i = i;
                                //ustawienie stanu zagrożenia
                                win = 1;
                            }
                            if (i <= heightFields - 4)
                            {
                                //na skos w kiernuku prawego dolnego rogu
                                if (tab2[i, j] != 0 && tab2[i, j] != -2 && tab2[i + 1, j + 1] == 0 && tab2[i + 2, j + 2] == 0 && tab2[i + 3, j + 3] == 0 && tab2[i + 4, j + 4] != 0 && tab2[i + 4, j + 4] != -2)
                                {
                                    //wyzerowanie sum
                                    suma1 = 0;
                                    suma2 = 0;
                                    //kopiujemy tablicę gracza i przeciwnika
                                    Array.Copy(tab2, tab2_copy, tab2.Length);
                                    Array.Copy(tab2, tab2_copy, tab2.Length);
                                    //testowe ustawienie pionka w polu i, j + 2 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                    ustaw(i, j, tab2_copy, tab2_copy);
                                    //obliczenie wygenerowanej sumy
                                    suma1 = sumaTab(tab2_copy);
                                    //kopiujemy na nowo tablicę gracza i przeciwnika
                                    Array.Copy(tab2, tab2_copy, tab2.Length);
                                    Array.Copy(tab2, tab2_copy, tab2.Length);
                                    //testowe ustawienie pionka w polu i, j + 4 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                    ustaw(i + 4, j + 4, tab2_copy, tab2_copy);
                                    //obliczenie wygenerowanej sumy
                                    suma2 = sumaTab(tab2_copy);
                                    //wybranie ruchu, który wygenerował większą sumę
                                    if (suma1 > suma2)
                                    {
                                        ruchAI_i = i;
                                        ruchAI_j = j;
                                    }
                                    else
                                    {
                                        ruchAI_i = i + 4;
                                        ruchAI_j = j + 4;
                                    }
                                    //ustawienie stanu zagrożenia
                                    win = 1;
                                }
                            }
                        }
                        if (i <= heightFields - 4)
                        {
                            //w pionie
                            if (tab2[i, j] != 0 && tab2[i, j] != -2 && tab2[i + 1, j] == 0 && tab2[i + 2, j] == 0 && tab2[i + 3, j] == 0 && tab2[i + 4, j] != 0 && tab2[i + 4, j] != -2)
                            {
                                //wyzerowanie sum
                                suma1 = 0;
                                suma2 = 0;
                                //kopiujemy tablicę gracza i przeciwnika
                                Array.Copy(tab2, tab2_copy, tab2.Length);
                                Array.Copy(tab2, tab2_copy, tab2.Length);
                                //testowe ustawienie pionka w polu i, j + 2 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                ustaw(i, j, tab2_copy, tab2_copy);
                                //obliczenie wygenerowanej sumy
                                suma1 = sumaTab(tab2_copy);
                                //kopiujemy na nowo tablicę gracza i przeciwnika
                                Array.Copy(tab2, tab2_copy, tab2.Length);
                                Array.Copy(tab2, tab2_copy, tab2.Length);
                                //testowe ustawienie pionka w polu i, j + 4 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                ustaw(i + 4, j, tab2_copy, tab2_copy);
                                //obliczenie wygenerowanej sumy
                                suma2 = sumaTab(tab2_copy);
                                //wybranie ruchu, który wygenerował większą sumę
                                if (suma1 > suma2)
                                    ruchAI_i = i;
                                else
                                    ruchAI_i = i + 4;
                                ruchAI_j = j;
                                //ustawienie stanu zagrożenia
                                win = 1;
                            }
                            if (j >= 5)
                            {
                                //na skos w kierunku lewego dolnego rogu
                                if (tab2[i, j] != 0 && tab2[i, j] != -2 && tab2[i + 1, j - 1] == 0 && tab2[i + 2, j - 2] == 0 && tab2[i + 3, j - 3] == 0 && tab2[i + 4, j - 4] != 0 && tab2[i + 4, j - 4] != -2)
                                {
                                    //wyzerowanie sum
                                    suma1 = 0;
                                    suma2 = 0;
                                    //kopiujemy tablicę gracza i przeciwnika
                                    Array.Copy(tab2, tab2_copy, tab2.Length);
                                    Array.Copy(tab2, tab2_copy, tab2.Length);
                                    //testowe ustawienie pionka w polu i, j + 2 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                    ustaw(i, j, tab2_copy, tab2_copy);
                                    //obliczenie wygenerowanej sumy
                                    suma1 = sumaTab(tab2_copy);
                                    //kopiujemy na nowo tablicę gracza i przeciwnika
                                    Array.Copy(tab2, tab2_copy, tab2.Length);
                                    Array.Copy(tab2, tab2_copy, tab2.Length);
                                    //testowe ustawienie pionka w polu i, j + 4 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                    ustaw(i + 4, j - 4, tab2_copy, tab2_copy);
                                    //obliczenie wygenerowanej sumy
                                    suma2 = sumaTab(tab2_copy);
                                    //wybranie ruchu, który wygenerował większą sumę
                                    if (suma1 > suma2)
                                    {
                                        ruchAI_i = i;
                                        ruchAI_j = j;
                                    }
                                    else
                                    {
                                        ruchAI_i = i + 4;
                                        ruchAI_j = j - 4;
                                    }
                                    //ustawienie stanu zagrożenia
                                    win = 1;
                                }
                            }
                        }
                    }
                }
            }
            //SPRWDZENIE STANÓW ZAGROŻENIA WPROWADZONYCH PRZEZ GRACZA
            if (danger == 0 && win != 1 && finish == 0)
            {
                for (int i = 1; i <= widthFields; i++)
                {
                    for (int j = 1; j <= heightFields; j++)
                    {
                        // UKŁADY: -oo-o- i -o-oo-
                        if (j <= widthFields - 5)
                        {
                            //poziomo -oo-o-
                            if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i, j + 1] == 0 && tab1[i, j + 2] == 0 && tab1[i, j + 3] != 0 && tab1[i, j + 3] != -2 && tab1[i, j + 4] == 0 && tab1[i, j + 5] != 0 && tab1[i, j + 5] != -2)
                            {
                                //MessageBox.Show("Jestem tutaj");
                                ruchAI_j = j + 3;
                                ruchAI_i = i;
                                danger = 1;
                            }
                            //poziomo -o-oo-
                            if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i, j + 1] == 0 && tab1[i, j + 2] != 0 && tab1[i, j + 2] != -2 && tab1[i, j + 3] == 0 && tab1[i, j + 4] == 0 && tab1[i, j + 5] != 0 && tab1[i, j + 5] != -2)
                            {
                                ruchAI_j = j + 2;
                                ruchAI_i = i;
                                danger = 1;
                            }
                            //po ukosie w stronę prawego dolnego rogu
                            if (i <= heightFields - 5)
                            {
                                //-oo-o-
                                if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i + 1, j + 1] == 0 && tab1[i + 2, j + 2] == 0 && tab1[i + 3, j + 3] != 0 && tab1[i + 3, j + 3] != -2 && tab1[i + 4, j + 4] == 0 && tab1[i + 5, j + 5] != 0 && tab1[i + 5, j + 5] != -2)
                                {
                                    ruchAI_i = i + 3;
                                    ruchAI_j = j + 3;
                                    danger = 1;
                                }
                                //-o-oo-
                                if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i + 1, j + 1] == 0 && tab1[i + 2, j + 2] != 0 && tab1[i + 2, j + 2] != -2 && tab1[i + 3, j + 3] == 0 && tab1[i + 4, j + 4] == 0 && tab1[i + 5, j + 5] != 0 && tab1[i + 5, j + 5] != -2)
                                {
                                    ruchAI_i = i + 2;
                                    ruchAI_j = j + 2;
                                    danger = 1;
                                }
                            }
                        }
                        //sprawdzenie w pionie układów: -oo-o- i -o-oo-
                        if (i <= heightFields - 5)
                        {
                            //-oo-o-
                            if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i + 1, j] == 0 && tab1[i + 2, j] == 0 && tab1[i + 3, j] != 0 && tab1[i + 3, j] != -2 && tab1[i + 4, j] == 0 && tab1[i + 5, j] != 0 && tab1[i + 5, j] != -2)
                            {
                                ruchAI_i = i + 3;
                                ruchAI_j = j;
                                danger = 1;
                            }
                            //-o-oo-
                            if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i + 1, j] == 0 && tab1[i + 2, j] != 0 && tab1[i + 2, j] != -2 && tab1[i + 3, j] == 0 && tab1[i + 4, j] == 0 && tab1[i + 5, j] != 0 && tab1[i + 5, j] != -2)
                            {
                                ruchAI_i = i + 2;
                                ruchAI_j = j;
                                danger = 1;
                            }
                        }
                        //sprawdzenie po ukosie w stronę lewego dolnego rogu układów: -oo-o- i -o-oo-
                        if (j >= 6 && i <= heightFields - 5)
                        {
                            //-oo-o-
                            if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i + 1, j - 1] == 0 && tab1[i + 2, j - 2] == 0 && tab1[i + 3, j - 3] != 0 && tab1[i + 3, j - 3] != -2 && tab1[i + 4, j - 4] == 0 && tab1[i + 5, j - 5] != 0 && tab1[i + 5, j - 5] != -2)
                            {
                                ruchAI_i = i + 3;
                                ruchAI_j = j - 3;
                                danger = 1;
                            }
                            //-o-oo-
                            if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i + 1, j - 1] == 0 && tab1[i + 2, j - 2] != 0 && tab1[i + 2, j - 2] != -2 && tab1[i + 3, j - 3] == 0 && tab1[i + 4, j - 4] == 0 && tab1[i + 5, j - 5] != 0 && tab1[i + 5, j - 5] != -2)
                            {
                                ruchAI_i = i + 2;
                                ruchAI_j = j - 2;
                                danger = 1;
                            }
                        }
                        //UKŁADY -o-o-o-
                        /*if (j <= widthFields - 6 && uklad4 != 1) //upewniamy się, że sprawdzane pola w tablicy nie wyjdą poza nią
                        {
                            //w poziomie
                            if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i, j + 1] == 0 && tab1[i, j + 2] != 0 && tab1[i, j + 2] != -2 && tab1[i, j + 3] == 0 && tab1[i, j + 4] != 0 && tab1[i, j + 4] != -2 && tab1[i, j + 5] == 0 && tab1[i, j + 6] != 0 && tab1[i, j + 6] != -2)
                            {
                                //wyzerowanie sum
                                suma1 = 0;
                                suma2 = 0;
                                //kopiujemy tablicę gracza i przeciwnika
                                Array.Copy(tab1, tab1_copy, tab1.Length);
                                Array.Copy(tab2, tab2_copy, tab2.Length);
                                //testowe ustawienie pionka w polu i, j + 2 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                ustaw(i, j + 2, tab1_copy, tab2_copy);
                                //obliczenie wygenerowanej sumy
                                suma1 = sumaTab(tab1_copy);
                                //kopiujemy na nowo tablicę gracza i przeciwnika
                                Array.Copy(tab1, tab1_copy, tab1.Length);
                                Array.Copy(tab2, tab2_copy, tab2.Length);
                                //testowe ustawienie pionka w polu i, j + 4 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                ustaw(i, j + 4, tab1_copy, tab2_copy);
                                //obliczenie wygenerowanej sumy
                                suma2 = sumaTab(tab1_copy);
                                //wybranie ruchu, który wygenerował większą sumę
                                if (suma1 > suma2)
                                    ruchAI_j = j + 2;
                                else
                                    ruchAI_j = j + 4;
                                ruchAI_i = i;
                                //ustawienie stanu zagrożenia
                                danger = 1;
                            }
                        }
                        if (i <= heightFields - 7 && uklad4 != 1)
                        {
                            //w pionie -o-o-o-
                            if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i + 1, j] == 0 && tab1[i + 2, j] != 0 && tab1[i + 2, j] != -2 && tab1[i + 3, j] == 0 && tab1[i + 4, j] != 0 && tab1[i + 4, j] != -2 && tab1[i + 5, j] == 0 && tab1[i + 6, j] != 0 && tab1[i + 6, j] != -2)
                            {
                                //wyzerowanie sum
                                suma1 = 0;
                                suma2 = 0;
                                //kopiujemy tablicę gracza i przeciwnika
                                Array.Copy(tab1, tab1_copy, tab1.Length);
                                Array.Copy(tab2, tab2_copy, tab2.Length);
                                //testowe ustawienie pionka w polu i, j + 2 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                ustaw(i + 2, j, tab1_copy, tab2_copy);
                                //obliczenie wygenerowanej sumy
                                suma1 = sumaTab(tab1_copy);
                                //kopiujemy na nowo tablicę gracza i przeciwnika
                                Array.Copy(tab1, tab1_copy, tab1.Length);
                                Array.Copy(tab2, tab2_copy, tab2.Length);
                                //testowe ustawienie pionka w polu i, j + 4 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                ustaw(i + 4, j, tab1_copy, tab2_copy);
                                //obliczenie wygenerowanej sumy
                                suma2 = sumaTab(tab1_copy);
                                //wybranie ruchu, który wygenerował większą sumę
                                if (suma1 > suma2)
                                    ruchAI_i = i + 2;
                                else
                                    ruchAI_i = i + 4;
                                ruchAI_j = j;
                                //ustawienie stanu zagrożenia
                                danger = 1;
                            }
                        }
                        //po skosie w stronę lewego dolnego rogu -o-o-o-
                        if (j >= 7 && i <= heightFields - 6 && uklad4 != 1)
                        {
                            if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i + 1, j - 1] == 0 && tab1[i + 2, j - 2] != 0 && tab1[i + 2, j - 2] != -2 && tab1[i + 3, j - 3] == 0 && tab1[i + 4, j - 4] != 0 && tab1[i + 4, j - 4] != -2 && tab1[i + 5, j - 5] == 0 && tab1[i + 6, j - 6] != 0 && tab1[i + 6, j - 6] != -2)
                            {
                                //wyzerowanie sum
                                suma1 = 0;
                                suma2 = 0;
                                //kopiujemy tablicę gracza i przeciwnika
                                Array.Copy(tab1, tab1_copy, tab1.Length);
                                Array.Copy(tab2, tab2_copy, tab2.Length);
                                //testowe ustawienie pionka w polu i, j + 2 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                ustaw(i + 2, j - 2, tab1_copy, tab2_copy);
                                //obliczenie wygenerowanej sumy
                                suma1 = sumaTab(tab1_copy);
                                //kopiujemy na nowo tablicę gracza i przeciwnika
                                Array.Copy(tab1, tab1_copy, tab1.Length);
                                Array.Copy(tab2, tab2_copy, tab2.Length);
                                //testowe ustawienie pionka w polu i, j + 4 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                ustaw(i + 4, j - 4, tab1_copy, tab2_copy);
                                //obliczenie wygenerowanej sumy
                                suma2 = sumaTab(tab1_copy);
                                //wybranie ruchu, który wygenerował większą sumę
                                if (suma1 > suma2)
                                {
                                    ruchAI_i = i + 2;
                                    ruchAI_j = j - 2;
                                }
                                else
                                {
                                    ruchAI_i = i + 4;
                                    ruchAI_j = j - 4;
                                }
                                //ustawienie stanu zagrożenia
                                danger = 1;
                            }
                        }
                        if (j <= widthFields - 6 && i <= heightFields - 6 && uklad4 != 1)
                        {
                            //po skosie do prawego dolnego rogu
                            if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i + 1, j + 1] == 0 && tab1[i + 2, j + 2] != 0 && tab1[i + 2, j + 2] != -2 && tab1[i + 3, j + 3] == 0 && tab1[i + 4, j + 4] != 0 && tab1[i + 4, j + 4] != -2 && tab1[i + 5, j + 5] == 0 && tab1[i + 6, j + 6] != 0 && tab1[i + 6, j + 6] != -2)
                            {
                                //wyzerowanie sum
                                suma1 = 0;
                                suma2 = 0;
                                //kopiujemy tablicę gracza i przeciwnika
                                Array.Copy(tab1, tab1_copy, tab1.Length);
                                Array.Copy(tab2, tab2_copy, tab2.Length);
                                //testowe ustawienie pionka w polu i, j + 2 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                ustaw(i + 2, j + 2, tab1_copy, tab2_copy);
                                //obliczenie wygenerowanej sumy
                                suma1 = sumaTab(tab1_copy);
                                //kopiujemy na nowo tablicę gracza i przeciwnika
                                Array.Copy(tab1, tab1_copy, tab1.Length);
                                Array.Copy(tab2, tab2_copy, tab2.Length);
                                //testowe ustawienie pionka w polu i, j + 4 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                ustaw(i + 4, j + 4, tab1_copy, tab2_copy);
                                //obliczenie wygenerowanej sumy
                                suma2 = sumaTab(tab1_copy);
                                //wybranie ruchu, który wygenerował większą sumę
                                if (suma1 > suma2)
                                {
                                    ruchAI_i = i + 2;
                                    ruchAI_j = j + 2;
                                }
                                else
                                {
                                    ruchAI_i = i + 4;
                                    ruchAI_j = j + 4;
                                }
                                //ustawienie stanu zagrożenia
                                danger = 1;
                            }
                        }
                        //UKŁADY -o-o-o-o-
                        if (j <= widthFields - 8)
                        {
                            //w poziomie
                            if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i, j + 1] == 0 && tab1[i, j + 2] != 0 && tab1[i, j + 2] != -2 && tab1[i, j + 3] == 0 && tab1[i, j + 4] != 0 && tab1[i, j + 4] != -2 && tab1[i, j + 5] == 0 && tab1[i, j + 6] != 0 && tab1[i, j + 6] != -2 && tab1[i, j + 7] == 0 && tab1[i, j + 8] != 0 && tab1[i, j + 8] != -2)
                            {
                                ruchAI_i = i;
                                ruchAI_j = j + 4;
                                danger = 1;
                                uklad4 = 1;
                            }
                            //na skos w stronę prawego dolnego rogu
                            if (i <= heightFields - 8)
                            {
                                if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i + 1, j + 1] == 0 && tab1[i + 2, j + 2] != 0 && tab1[i + 2, j + 2] != -2 && tab1[i + 3, j + 3] == 0 && tab1[i + 4, j + 4] != 0 && tab1[i + 4, j + 4] != -2 && tab1[i + 5, j + 5] == 0 && tab1[i + 6, j + 6] != 0 && tab1[i + 6, j + 6] != -2 && tab1[i + 7, j + 7] == 0 && tab1[i + 8, j + 8] != 0 && tab1[i + 8, j + 8] != -2)
                                {
                                    ruchAI_i = i + 4;
                                    ruchAI_j = j + 4;
                                    danger = 1;
                                    uklad4 = 1;
                                }
                            }
                        }
                        if (i <= heightFields - 8)
                        {
                            //w pionie
                            if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i + 1, j] == 0 && tab1[i + 2, j] != 0 && tab1[i + 2, j] != -2 && tab1[i + 3, j] == 0 && tab1[i + 4, j] != 0 && tab1[i + 4, j] != -2 && tab1[i + 5, j] == 0 && tab1[i + 6, j] != 0 && tab1[i + 6, j] != -2 && tab1[i + 7, j] == 0 && tab1[i + 8, j] != 0 && tab1[i + 8, j] != -2)
                            {
                                ruchAI_i = i + 4;
                                ruchAI_j = j;
                                danger = 1;
                                uklad4 = 1;
                            }
                            //na ukos w stronę lewego dolnego rogu
                            if (j >= 9)
                            {
                                if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i + 1, j - 1] == 0 && tab1[i + 2, j - 2] != 0 && tab1[i + 2, j - 2] != -2 && tab1[i + 3, j - 3] == 0 && tab1[i + 4, j - 4] != 0 && tab1[i + 4, j - 4] != -2 && tab1[i + 5, j - 5] == 0 && tab1[i + 6, j - 6] != 0 && tab1[i + 6, j - 6] != -2 && tab1[i + 7, j - 7] == 0 && tab1[i + 8, j - 8] != 0 && tab1[i + 8, j - 8] != -2)
                                {
                                    ruchAI_i = i + 4;
                                    ruchAI_j = j - 4;
                                    danger = 1;
                                    uklad4 = 1;
                                }
                            }
                        }*/
                        //UKŁAD -ooo-
                        if (j <= widthFields - 4)
                        {
                            //w poziomie
                            if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i, j + 1] == 0 && tab1[i, j + 2] == 0 && tab1[i, j + 3] == 0 && tab1[i, j + 4] != 0 && tab1[i, j + 4] != -2)
                            {
                                //wyzerowanie sum
                                suma1 = 0;
                                suma2 = 0;
                                //kopiujemy tablicę gracza i przeciwnika
                                Array.Copy(tab1, tab1_copy, tab1.Length);
                                Array.Copy(tab2, tab2_copy, tab2.Length);
                                //testowe ustawienie pionka w polu i, j + 2 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                ustaw(i, j, tab1_copy, tab2_copy);
                                //obliczenie wygenerowanej sumy
                                suma1 = sumaTab(tab1_copy);
                                //kopiujemy na nowo tablicę gracza i przeciwnika
                                Array.Copy(tab1, tab1_copy, tab1.Length);
                                Array.Copy(tab2, tab2_copy, tab2.Length);
                                //testowe ustawienie pionka w polu i, j + 4 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                ustaw(i, j + 4, tab1_copy, tab2_copy);
                                //obliczenie wygenerowanej sumy
                                suma2 = sumaTab(tab1_copy);
                                //wybranie ruchu, który wygenerował większą sumę
                                if (suma1 > suma2)
                                    ruchAI_j = j;
                                else
                                    ruchAI_j = j + 4;
                                ruchAI_i = i;
                                //ustawienie stanu zagrożenia
                                danger = 1;
                            }
                            if (i <= heightFields - 4)
                            {
                                //na skos w kiernuku prawego dolnego rogu
                                if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i + 1, j + 1] == 0 && tab1[i + 2, j + 2] == 0 && tab1[i + 3, j + 3] == 0 && tab1[i + 4, j + 4] != 0 && tab1[i + 4, j + 4] != -2)
                                {
                                    //wyzerowanie sum
                                    suma1 = 0;
                                    suma2 = 0;
                                    //kopiujemy tablicę gracza i przeciwnika
                                    Array.Copy(tab1, tab1_copy, tab1.Length);
                                    Array.Copy(tab2, tab2_copy, tab2.Length);
                                    //testowe ustawienie pionka w polu i, j + 2 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                    ustaw(i, j, tab1_copy, tab2_copy);
                                    //obliczenie wygenerowanej sumy
                                    suma1 = sumaTab(tab1_copy);
                                    //kopiujemy na nowo tablicę gracza i przeciwnika
                                    Array.Copy(tab1, tab1_copy, tab1.Length);
                                    Array.Copy(tab2, tab2_copy, tab2.Length);
                                    //testowe ustawienie pionka w polu i, j + 4 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                    ustaw(i + 4, j + 4, tab1_copy, tab2_copy);
                                    //obliczenie wygenerowanej sumy
                                    suma2 = sumaTab(tab1_copy);
                                    //wybranie ruchu, który wygenerował większą sumę
                                    if (suma1 > suma2)
                                    {
                                        ruchAI_i = i;
                                        ruchAI_j = j;
                                    }
                                    else
                                    {
                                        ruchAI_i = i + 4;
                                        ruchAI_j = j + 4;
                                    }
                                    //ustawienie stanu zagrożenia
                                    danger = 1;
                                }
                            }
                        }
                        if (i <= heightFields - 4)
                        {
                            //w pionie
                            if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i + 1, j] == 0 && tab1[i + 2, j] == 0 && tab1[i + 3, j] == 0 && tab1[i + 4, j] != 0 && tab1[i + 4, j] != -2)
                            {
                                //wyzerowanie sum
                                suma1 = 0;
                                suma2 = 0;
                                //kopiujemy tablicę gracza i przeciwnika
                                Array.Copy(tab1, tab1_copy, tab1.Length);
                                Array.Copy(tab2, tab2_copy, tab2.Length);
                                //testowe ustawienie pionka w polu i, j + 2 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                ustaw(i, j, tab1_copy, tab2_copy);
                                //obliczenie wygenerowanej sumy
                                suma1 = sumaTab(tab1_copy);
                                //kopiujemy na nowo tablicę gracza i przeciwnika
                                Array.Copy(tab1, tab1_copy, tab1.Length);
                                Array.Copy(tab2, tab2_copy, tab2.Length);
                                //testowe ustawienie pionka w polu i, j + 4 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                ustaw(i + 4, j, tab1_copy, tab2_copy);
                                //obliczenie wygenerowanej sumy
                                suma2 = sumaTab(tab1_copy);
                                //wybranie ruchu, który wygenerował większą sumę
                                if (suma1 > suma2)
                                    ruchAI_i = i;
                                else
                                    ruchAI_i = i + 4;
                                ruchAI_j = j;
                                //ustawienie stanu zagrożenia
                                danger = 1;
                            }
                            if (j >= 5)
                            {
                                //na skos w kierunku lewego dolnego rogu
                                if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i + 1, j - 1] == 0 && tab1[i + 2, j - 2] == 0 && tab1[i + 3, j - 3] == 0 && tab1[i + 4, j - 4] != 0 && tab1[i + 4, j - 4] != -2)
                                {
                                    //wyzerowanie sum
                                    suma1 = 0;
                                    suma2 = 0;
                                    //kopiujemy tablicę gracza i przeciwnika
                                    Array.Copy(tab1, tab1_copy, tab1.Length);
                                    Array.Copy(tab2, tab2_copy, tab2.Length);
                                    //testowe ustawienie pionka w polu i, j + 2 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                    ustaw(i, j, tab1_copy, tab2_copy);
                                    //obliczenie wygenerowanej sumy
                                    suma1 = sumaTab(tab1_copy);
                                    //kopiujemy na nowo tablicę gracza i przeciwnika
                                    Array.Copy(tab1, tab1_copy, tab1.Length);
                                    Array.Copy(tab2, tab2_copy, tab2.Length);
                                    //testowe ustawienie pionka w polu i, j + 4 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                    ustaw(i + 4, j - 4, tab1_copy, tab2_copy);
                                    //obliczenie wygenerowanej sumy
                                    suma2 = sumaTab(tab1_copy);
                                    //wybranie ruchu, który wygenerował większą sumę
                                    if (suma1 > suma2)
                                    {
                                        ruchAI_i = i;
                                        ruchAI_j = j;
                                    }
                                    else
                                    {
                                        ruchAI_i = i + 4;
                                        ruchAI_j = j - 4;
                                    }
                                    //ustawienie stanu zagrożenia
                                    danger = 1;
                                }
                            }
                        }
                    }
                }
            }
            //wyszukanie standardowego ruchu dla gracza komputerowego
            if (danger == 0 && win != 1 && finish != 1)
            {
                for (int i = 1; i <= widthFields; i++)
                {
                    for (int j = 1; j <= heightFields; j++)
                    {
                        //UKŁAD -o-o-
                        if (j <= widthFields - 4)
                        {
                            if (tab2[i, j] != 0 && tab2[i, j] != -2 && tab2[i, j + 1] == 0 && tab2[i, j + 2] != 0 && tab2[i, j + 2] != -2 && tab2[i, j + 3] == 0 && tab2[i, j + 4] != 0 && tab2[i, j + 4] != -2)
                            {
                                ruchAI_i = i;
                                ruchAI_j = j + 2;
                            }
                            if (i <= heightFields - 4)
                            {
                                if (tab2[i, j] != 0 && tab2[i, j] != -2 && tab2[i + 1, j + 1] == 0 && tab2[i + 2, j + 2] != 0 && tab2[i + 2, j + 2] != -2 && tab2[i + 3, j + 3] == 0 && tab2[i + 4, j + 4] != 0 && tab2[i + 4, j + 4] != -2)
                                {
                                    ruchAI_i = i + 2;
                                    ruchAI_j = j + 2;
                                }
                            }
                        }
                        if (i <= heightFields - 4)
                        {
                            if (tab2[i, j] != 0 && tab2[i, j] != -2 && tab2[i + 1, j] == 0 && tab2[i + 2, j] != 0 && tab2[i + 2, j] != -2 && tab2[i + 3, j] == 0 && tab2[i + 4, j] != 0 && tab2[i + 4, j] != -2)
                            {
                                ruchAI_i = i + 2;
                                ruchAI_j = j;
                            }
                            if (j >= 5)
                            {
                                if (tab2[i, j] != 0 && tab2[i, j] != -2 && tab2[i + 1, j - 1] == 0 && tab2[i + 2, j - 2] != 0 && tab2[i + 2, j - 2] != -2 && tab2[i + 3, j - 3] == 0 && tab2[i + 4, j - 4] != 0 && tab2[i + 4, j - 4] != -2)
                                {
                                    ruchAI_i = i + 2;
                                    ruchAI_j = j - 2;
                                }
                            }
                        }
                        //UKŁAD -oo-
                        if (j <= widthFields - 3)
                        {
                            if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i, j + 1] == 0 && tab1[i, j + 2] == 0 && tab1[i, j + 3] != 0 && tab1[i, j + 3] != -2)
                            {

                                //wyzerowanie sum
                                suma1 = 0;
                                suma2 = 0;
                                //kopiujemy tablicę gracza i przeciwnika
                                Array.Copy(tab1, tab1_copy, tab1.Length);
                                Array.Copy(tab2, tab2_copy, tab2.Length);
                                //testowe ustawienie pionka w polu i, j + 2 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                ustaw(i, j, tab1_copy, tab2_copy);
                                //obliczenie wygenerowanej sumy
                                suma1 = sumaTab(tab1_copy);
                                //kopiujemy na nowo tablicę gracza i przeciwnika
                                Array.Copy(tab1, tab1_copy, tab1.Length);
                                Array.Copy(tab2, tab2_copy, tab2.Length);
                                //testowe ustawienie pionka w polu i, j + 4 w celu sprawdzenia sumy jaką taki ruch wygeneruje
                                ustaw(i, j + 3, tab1_copy, tab2_copy);
                                //obliczenie wygenerowanej sumy
                                suma2 = sumaTab(tab1_copy);
                                //wybranie ruchu, który wygenerował większą sumę
                                if (suma1 > suma2)
                                    ruchAI_j = j;
                                else
                                    ruchAI_j = j + 3;
                                ruchAI_i = i;
                            }
                            if (i <= heightFields - 3)
                            {
                                if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i + 1, j + 1] == 0 && tab1[i + 2, j + 2] == 0 && tab1[i + 3, j + 3] != 0 && tab1[i + 3, j + 3] != -2)
                                {
                                    ruchAI_i = i + 3;
                                    ruchAI_j = j + 3;
                                }
                            }
                        }
                        if (i <= heightFields - 3)
                        {
                            if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i + 1, j] == 0 && tab1[i + 2, j] == 0 && tab1[i + 3, j] != 0 && tab1[i + 3, j] != -2)
                            {
                                ruchAI_i = i + 3;
                                ruchAI_j = j;
                            }
                            if (j >= 4)
                            {
                                if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i + 1, j - 1] == 0 && tab1[i + 2, j - 2] == 0 && tab1[i + 3, j - 3] != 0 && tab1[i + 3, j - 3] != -2)
                                {
                                    ruchAI_i = i + 3;
                                    ruchAI_j = j - 3;
                                }
                            }
                        }
                        //UKŁAD -o-o-
                        if (j <= widthFields - 4)
                        {
                            if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i, j + 1] == 0 && tab1[i, j + 2] != 0 && tab1[i, j + 2] != -2 && tab1[i, j + 3] == 0 && tab1[i, j + 4] != 0 && tab1[i, j + 4] != -2)
                            {
                                ruchAI_i = i;
                                ruchAI_j = j + 2;
                            }
                            if (i <= heightFields - 4)
                            {
                                if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i + 1, j + 1] == 0 && tab1[i + 2, j + 2] != 0 && tab1[i + 2, j + 2] != -2 && tab1[i + 3, j + 3] == 0 && tab1[i + 4, j + 4] != 0 && tab1[i + 4, j + 4] != -2)
                                {
                                    ruchAI_i = i + 2;
                                    ruchAI_j = j + 2;
                                }
                            }
                        }
                        if (i <= heightFields - 4)
                        {
                            if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i + 1, j] == 0 && tab1[i + 2, j] != 0 && tab1[i + 2, j] != -2 && tab1[i + 3, j] == 0 && tab1[i + 4, j] != 0 && tab1[i + 4, j] != -2)
                            {
                                ruchAI_i = i + 2;
                                ruchAI_j = j;
                            }
                            if (j >= 5)
                            {
                                if (tab1[i, j] != 0 && tab1[i, j] != -2 && tab1[i + 1, j - 1] == 0 && tab1[i + 2, j - 2] != 0 && tab1[i + 2, j - 2] != -2 && tab1[i + 3, j - 3] == 0 && tab1[i + 4, j - 4] != 0 && tab1[i + 4, j - 4] != -2)
                                {
                                    ruchAI_i = i + 2;
                                    ruchAI_j = j - 2;
                                }
                            }
                        }
                    }
                }
            }
            //zapiszTab(tab1);
            //MessageBox.Show("ruchAI_i = " + ruchAI_i + "\r\nruchAI_j = " + ruchAI_j);
            //zapis ruchów do pliku
            FileStream plik = new FileStream("logs\\"+data, FileMode.Append);
            StreamWriter tab = new StreamWriter(plik);
            tab.WriteLine("   \t\tGracz 2: [" + ruchAI_i + "][" + ruchAI_j + "]");
            tab.Flush();
            tab.Close();


            ustaw(ruchAI_i, ruchAI_j, tab2, tab1);
            //zapiszTab(tab1);
            //zapiszTab(tab2);
            string name = "button" + ((ruchAI_i - 1) * widthFields + (ruchAI_j - 1)).ToString();
            this.Controls[name].Visible = false;
            PictureBox pic = new PictureBox();
            pic.Name = "pictureBox" + ((ruchAI_i*ruchAI_j + ruchAI_j) * 2 - 1).ToString();
            pic.Size = new System.Drawing.Size(16, 16);
            if (iconSet == 0)
            {
                kolejka.Image = Properties.Resources.player1;
                pic.Image = kulki.Properties.Resources.player2;
            }
            if (iconSet == 1)
            {
                kolejka.Image = Properties.Resources.windows;
                pic.Image = kulki.Properties.Resources.linux;
            }
            if (iconSet == 2)
            {
                kolejka.Image = Properties.Resources.angel;
                pic.Image = kulki.Properties.Resources.devil;
            }
            pic.Visible = true;
            pic.Location = new System.Drawing.Point(27 + (ruchAI_j - 1) * 19, 64 + (ruchAI_i - 1) * 19);
            this.Controls.Add(pic);
            sprawdzWynik();
            //tura++;
            //MessageBox.Show("i = " + ruchAI_i + ", j = " + ruchAI_j, "Najlepsze pole", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //sprawdenie wyniku i wyświetlanie okna na koniec gry
        private void sprawdzWynik()
        {
                if (tura % 2 == 1) //jeżeli funckję wywołano dla pierwszego gracza
                {
                    //przeszukaj tablicę w poszukiwaniu układu tylu pionków w rzędzie ile wskazuje na to zmienna "ile"
                    for (int i = 0; i < tab1.GetLength(0); i++)
                    {
                        for (int j = 0; j < tab1.GetLength(1); j++)
                        {
                            if (tab1[i, j] >= ile) //sprawdź czy jest takie pole, które informuje o tym, że gracz zdobył wymaganą ilość pionków w rzędzie
                            {
                                //w przypadku wgranej wgeneruj odpowiednie okienko
                                gameOver win = new gameOver("zielony");
                                this.Enabled = false; //zablokowanie formularza z grą
                                //odtwórz dźwięk zwycięstwa
                                if (overSound != 0)
                                {
                                    SoundPlayer player = new SoundPlayer(Properties.Resources.wygrana);
                                    player.Play();
                                }
                                //wyświetl wygenerowane okno
                                win.ShowDialog();

                                //this.Close();
                            }
                            else
                            {
                                if (tura >= widthFields * heightFields) //w sytuacji gdy wszystkie pola są już zajęte a nie wyłoniono zwycięscy
                                {
                                    gameOver draw = new gameOver("remis");
                                    this.Enabled = false;
                                    draw.ShowDialog();
                                    //this.Close();
                                }
                            }

                        }
                    }
                }
                else //to samo dla drugiego gracza
                {
                    for (int i = 0; i < tab2.GetLength(0); i++)
                    {
                        for (int j = 0; j < tab2.GetLength(1); j++)
                        {
                            if (tab2[i, j] >= ile)
                            {
                                gameOver win = new gameOver("czerwony");
                                this.Enabled = false;
                                if (overSound != 0)
                                {
                                    SoundPlayer player = new SoundPlayer(Properties.Resources.wygrana);
                                    player.Play();
                                }
                                win.ShowDialog();
                                //this.Close();
                            }
                            else
                            {
                                if (tura >= widthFields * heightFields) //w sytuacji gdy wszystkie pola są już zajęte a nie wyłoniono zwycięscy
                                {
                                    gameOver draw = new gameOver("remis");
                                    this.Enabled = false;
                                    draw.ShowDialog();
                                    //this.Close();
                                }
                            }
                        }
                    }
                }
        }
        //generowanie dynamiczne pól planszy do gry
        private void generateGameFields()
        {
            for (int i = 0; i < heightFields; i++)
            {
                Label label = new Label();
                Label label2 = new Label();
                label.Location = new System.Drawing.Point(4, 48 + i * 19 + 15);
                label.Text = (i + 1).ToString();
                label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                label.Size = new System.Drawing.Size(19, 19);
                label2.Location = new System.Drawing.Point(6 + i * 19 + 19, 43);
                label2.Text = (i + 1).ToString();
                label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                label2.Size = new System.Drawing.Size(19, 19);
                this.Controls.Add(label);
                this.Controls.Add(label2);
                for (int j = 0; j < widthFields; j++)
                {
                    Button button = new Button();
                    PictureBox pictureBox1 = new PictureBox();
                    PictureBox pictureBox2 = new PictureBox();
                    int id = i * widthFields + j;
                    button.Name = "button" + id.ToString();
                    button.Size = new System.Drawing.Size(20, 20);
                    button.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
                    button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
                    button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
                    button.Location = new System.Drawing.Point(25 + j * 19, 62 + i * 19);
                    button.TabIndex = id;
                    button.Visible = true;
                    button.Tag = i;
                    button.Click += new EventHandler(ustaw_Click);
                    button.KeyDown += new KeyEventHandler(gameGUI_KeyDown);
                    this.Controls.Add(button);
                }
            }
        }
        //obługa zdarzeń
        private void gameGUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
        private void new_game_Click(object sender, EventArgs e)
        {
            nowaGra();
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ustaw_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            PictureBox zielony = new PictureBox();
            PictureBox czerwony = new PictureBox();
            if (fieldSound != 0)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.ustaw);
                player.Play();
            }
            btn.Visible = false;
            int i, j, id;
            int.TryParse(btn.Tag.ToString(), out i);
            int.TryParse(btn.TabIndex.ToString(), out id);
            j = id - i * widthFields;
            if (tura % 2 == 1)
            {
                PictureBox pic = new PictureBox();
                pic.Name = "pictureBox" + (id * 2).ToString();
                pic.Size = new System.Drawing.Size(16, 16);
                if (iconSet == 0)
                {
                    kolejka.Image = Properties.Resources.player2;
                    pic.Image = kulki.Properties.Resources.player1;
                }
                if (iconSet == 1)
                {
                    kolejka.Image = Properties.Resources.linux;
                    pic.Image = kulki.Properties.Resources.windows;
                }
                if (iconSet == 2)
                {
                    kolejka.Image = Properties.Resources.devil;
                    pic.Image = kulki.Properties.Resources.angel;
                }
                pic.Visible = true;
                pic.Location = new System.Drawing.Point(27 + j * 19, 64 + i * 19);
                this.Controls.Add(pic);
                //tutaj i oraz j wrzucamy zwiększone o 1 by mieściły się w obszarze gry
                //stworzenie pliku
                FileStream plik = new FileStream("logs\\" + data, FileMode.OpenOrCreate);
                plik.Flush();
                plik.Close();
                //zapis ruchów do pliku
                plik = new FileStream("logs\\"+data, FileMode.Append);
                StreamWriter tab = new StreamWriter(plik);
                tab.Write("Gracz 1: [" + (i + 1) + "][" + (j + 1) + "]");
                tab.Flush();
                tab.Close();
                ustaw(i + 1, j + 1, tab1, tab2);
                sprawdzWynik();
                if (this.gameMode == 1)
                {
                    tura++;
                    if (this.Enabled == true)
                        ruch_AI();
                }
            }
            else
            {
                PictureBox pic = new PictureBox();
                pic.Name = "pictureBox" + (id * 2 - 1).ToString();
                pic.Size = new System.Drawing.Size(16, 16);
                if (iconSet == 0)
                {
                    kolejka.Image = Properties.Resources.player1;
                    pic.Image = kulki.Properties.Resources.player2;
                }
                if (iconSet == 1)
                {
                    kolejka.Image = Properties.Resources.windows;
                    pic.Image = kulki.Properties.Resources.linux;
                }
                if (iconSet == 2)
                {
                    kolejka.Image = Properties.Resources.angel;
                    pic.Image = kulki.Properties.Resources.devil;
                }
                pic.Visible = true;
                pic.Location = new System.Drawing.Point(27 + j * 19, 64 + i * 19);
                this.Controls.Add(pic);
                //tutaj i oraz j wrzucamy zwiększone o 1 by mieściły się w obszarze gry
                ustaw(i + 1, j + 1, tab2, tab1);
                sprawdzWynik();
            }
            ++tura;
        }
        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nowaGra();
        }
        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeSettings ustawienia = new changeSettings();
            ustawienia.ShowDialog();
        }
        private void oAutorzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kulki v1.0.2\r\nAutor: Tomasz Musiałowski", "Autor aplikacji", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
