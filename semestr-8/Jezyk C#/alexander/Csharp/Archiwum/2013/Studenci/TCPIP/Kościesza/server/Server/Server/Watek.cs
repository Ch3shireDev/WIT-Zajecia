using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets; 

namespace Server
{
    /*  
     *  Klasa obsluguje jednego klienta w nowym wątku
     */
    class Watek
    {

        public Server form;             // wskaznik do formy Server
        public Thread watek;            //
        public ProgressBar progressB;   // progressBar wskazujacy postęp wyliczenia wartosci ciagu harmonicznego
        public double wynik;            // wartosc ciagu harmonicznego 
        Socket s;                       // gniazdo niezbedne do wyslania danych do podłączonych gniazd
        UTF8Encoding en;                // reprezentuje kodowanie UTF-8 znaków Unicode.
        public int n;                 // liczba składnikow ciagu harmonicznego
        private double max_wyl;
        private int max_key;

        public Watek(Server f, Socket sck, int max_find_key , double wyl , int ile)
        {
            form = f;                                       // uzupelniam pola klasy argumentami
            s=sck;
            n = ile;
            max_wyl = wyl;
            max_key = max_find_key;
            watek = new Thread(new ThreadStart(do_work));   // tworze nowy watek w ktorym wykonuje metodę do_work()
            byte[] buf = new byte[1024];                    // tworzę tablicę bajtów przechowujacą dane do wysłania klientowi
            

            en = new UTF8Encoding();                        
              
            //-------------------------------------

                progressB = new ProgressBar();
                form.panel1.Invoke(new MethodInvoker(delegate { form.panel1.Controls.Add(progressB); }));
                form.panel1.Invoke(new MethodInvoker(delegate { progressB.Maximum = n; }));
                form.panel1.Invoke(new MethodInvoker(delegate { form.Arrange(null); }));
                watek.Start();
            

        }
        //////////////////// LICZ SZEREG HARMON I UPDATE PROGRESSBAR /////////////////////////////
        public void do_work()
        {
            // int ile=1;
            double j = 1;
            for (int i = 1; i <= n; i++)          // wyliczam sumę poszczególnych składników 
            {
                wynik += (1.0 / j);
                if ((i & 0x1FFFFF) == 0) // %   (i * 100 / n) == (10 * ile)
                {
                    form.panel1.Invoke(new MethodInvoker(delegate { progressB.Value = i; }));
                    s.Send(en.GetBytes( "p"+i.ToString() + "\n"));
                   // ile+=1;
                    // ilesc wynik toString() 
                }
                j++;
            } //end for


            String space = "    ";

            

            form.panel1.Invoke(new MethodInvoker(delegate { form.panel1.Controls.Remove(progressB); }));
            try
            {
                form.Invoke(new MethodInvoker(delegate { form.wyliczone.Add(max_key + n, max_wyl + Math.Round(wynik, 2)); }));
               
                s.Send(en.GetBytes(n.ToString() + space  + (max_wyl + Math.Round(wynik, 2)).ToString() + "\n")); // wysyłam klientowi wynik w postaci tablicy bajtów
            }
            catch {
            
            }

            wynik = 0.0;
            form.ThreadArrange(progressB);              // obliczenia zakończyły sie wiec usuwam progressBar i Updateuje pozycję progressBarów ustawionych za nim
            
        }


    }; // end Thread
}
