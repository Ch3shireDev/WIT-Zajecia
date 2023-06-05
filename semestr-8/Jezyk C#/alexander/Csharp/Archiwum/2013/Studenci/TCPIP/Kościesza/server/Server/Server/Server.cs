using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;                     // dla IPAddress, ogólnie jest to  interface dla wielu protokołów np. http tu wykorzystuje 
using System.Net.Sockets;            // przestrzen do zarzadzania interface'm Sockets zawiera: (TcpClienta, TcpListenera, UdpClienta)
using System.Collections.Generic;

namespace Server
{
    public partial class Server : Form
    {
        private TcpListener server;                 // nasłuchuje połączenia TCP klientów sieci.
        private Thread watek;
        private bool is_work;                       // czy server pracuje tzn. user nie zamknął formy
        //private Watek watek_obliczenia;             // watek obslugujący jednego klienta
        public int n;                               // liczba przesłana przez klienta

        private int max_find_key = 0;                               // najwieksza pasujaca liczba
        private double max_find_value = 0.0;     
        public Dictionary<int, double> wyliczone = new Dictionary<int, double>();
  

        private delegate void SetText(string str);  // set text for Log textbox
        public delegate void SetArrange(ProgressBar pb); // set progressBars on correct position

        public Server()
        {
            InitializeComponent();
            
            is_work = true;
            server = new TcpListener(IPAddress.Any, 8001); // inicjuje nowe wystąpienie TcpListener klasy, który nasłuchuje przychodzących połączeń
                                                          //  próbuje  poączenia na określonym IP i porcie.
            watek = new Thread(listen);                   // nasłuchiwanie i ewentualna obsł. klientów wykonuje w watku
            watek.Priority = ThreadPriority.BelowNormal;
            watek.Start();

           
        }
        //-----------------------------------------------
        public void Text_log(string str)  // add text to Log textbox
        {
            Log.Text=str;
        }

        public void ThreadText(string str)
        {
            Invoke(new SetText(Text_log), new Object[] { str });
        }
        //------------------------------------------------
        public void Arrange(ProgressBar pb)
        {
            if (pb != null)
            {
                pb.Dispose();
            }

            int W = panel1.Width - 2 * 20, Y = 4;
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is ProgressBar)
                {
                    pb = ctrl as ProgressBar;

                    pb.Bounds = new Rectangle(10, Y, W, 23);
                    Y += 25;
                }
            }

        }


        public void ThreadArrange(ProgressBar pb)
        {
            Invoke(
                    new SetArrange(Arrange), new object[] { pb }
                );
        }
        //-----------------------------------------------
        public void listen()
        {
            try
            {
                while (is_work)                                                 // dopóki nie  zakończono pracy serwera(klient w każdej chwili może zamknąć)
                {
                    ThreadText("Start listening");
                    server.Start();                                             // rozpocznij nasłuchiwanie żądań połączeń przychodzących.
                    while (is_work)                                             // dopóki nie  zakończono pracy serwera
                    {
                        try
                        {
                            if (server.Pending())                               // określa czy są  żądania wobec serwera
                            {                                                   // jeśli tak to zaakceptuj żądanie i zacznij obsługę tego żądania w nowym wątku : metoda clientHandler() 
                                Thread watekn = new Thread(clientHandler);
                                watekn.Priority = ThreadPriority.BelowNormal;
                                watekn.Start(server.AcceptSocket());           /// Akceptuje żądania połączenia oczekującego.
                            }
                        }
                        catch (Exception)
                        {
                            if (is_work) ThreadText("Błąd nasłuchu");          // klient w czasie dokonywania akceptacji ROZŁĄCZYŁ SIĘ z serwerem
                            break;
                        }
                    }
                    server.Stop();                                            //zamykanie odbioru żądań
                    if (is_work) ThreadText("Koniec nasłuchu");
                }
            }
            catch (Exception)                                                  // nikt się jeszcze nie zgłosił
            {
                if (is_work) ThreadText("Błąd połączenia");
            }
        }
        //------------------Obsługa klienta-----------------------
        public void clientHandler(Object s)
        {
            Socket sck = s as Socket;
            string who = sck.RemoteEndPoint.ToString(); // Pobiera zdalny punkt końcowy(by podejżeć kto jest podłączony IP:port)  (IPEndPoint)sck.RemoteEndPoint).Address.ToString ()
             
            try
            {
                ThreadText("Połączenie: " + who);
                byte[] buf = new byte[1024];

                while (sck.Connected && is_work)           // dopóki klient jest  z nami  i serwer pracuje
                {
                    if (sck.Poll(100, SelectMode.SelectRead))      // jeśli serwer nasłuchuje, poczekaj na odpowiedź 100 mikrosekund
                    {
                        //
                        UTF8Encoding en = new UTF8Encoding();                 // reprezentuje kodowanie UTF-8 znaków Unicode.
                        string txt = "";
                        txt = en.GetString(buf, 0, sck.Receive(buf));   // tu otrzymujemy od klienta zdekodowany zakres bajtów z tablicy bajtowej w ciąg znaków. (Zastępuje Encoding.GetString(Byte[], Int32, Int32)).
                        int ile;
                        bool operand = int.TryParse(txt, out ile);

                        if (!operand)                                // gdy udało się sparsować tworzymy nowy progressBar i ustawiamy do na końcu listy
                        {
                            sck.Send(en.GetBytes(txt + ": Error"));
                        }
                        else
                        {


                            //-------------------------------------
                            foreach (KeyValuePair<int, double> wyl in wyliczone)
                            {

                                if ((wyl.Key < ile))
                                {
                                    max_find_key = wyl.Key;
                                    max_find_value = wyl.Value;
                                    break;
                                }
                             }
                            n = ile - max_find_key;
                            //
                            //watek_obliczenia =
                                new Watek(this, sck, max_find_key, max_find_value, n);   // przetwórz klienta



                        }
                    }
                }
                ThreadText("Rozłączenie: " + who);
            }
            catch (Exception)
            {
                ThreadText("Klient: " + who + " rozłączył się");
            }
            sck.Close();                                            // zamknij gniazdo gdy klient odszedł(rozłączył się)
        }
        //----------------------------------------------------------------------
       
        //----------------------------------------------------------------------
        private void Server_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            is_work = false;
            watek.Join();
        }
    }
}
