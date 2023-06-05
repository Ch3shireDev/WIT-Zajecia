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
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public partial class Client : Form
    {
        private TcpClient client;                           // miejsce połączeń klienta usług sieciowych protokołu TCP.
        private Thread watek;
        private UpdateProgressBar updateProgressBarObject;  // progressBar imitujący pracę servera
        private UTF8Encoding en;                             // reprezentuje kodowanie UTF-8 znaków Unicode.          
        private bool Work;
        private int progressValue;                           // wartość postępu
        private int n;                                      // liczba elementów ciągu harmonicznego
        private delegate void SetText(string str);
        private delegate void SetBool(bool val);
        public delegate void PrzesunPbar(ProgressBar pb); // update progressBar position 

        public Client()
        {
            InitializeComponent();
            en = new UTF8Encoding();
            watek = null;
            client = null;
            updateProgressBarObject = null;
            
        }

        //  dodaj wyniki do Log textboxa
        //-------------------------------
        public void AppendText(string str)
        {
            Log.AppendText(str + "\n");
        }

        public void ThreadAppendText(string str)       // for Log textbox( write connected Log ) 
        {
            Invoke( new SetText(AppendText), new Object[] { str } );
        }

        //---------------------------------------------------
        public void PrzesunBar(ProgressBar pb)
        {
            int H = 1;
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is ProgressBar)
                {
                    ctrl.Location = new System.Drawing.Point(18, H);
                    H += 25 ;
                }
            }
        }

        //-----------------------------------------------------
        public void PrzesunPbarThread(ProgressBar pb)
        {
            Invoke(new PrzesunPbar(PrzesunBar), pb);
        }

        //---------------------------------------------------
        public void StartCln(bool val)          // if (client connected) => Disable Host textbox and  Button Sent enable 
        {
            Host.Enabled = !val;
            BtnSend.Enabled = val;
        }

        //---------------------------------------------------
        public void ThreadStartCln(bool val)     // for checkBox Connected to server
        {
            Invoke( new SetBool(StartCln),  new Object[] { val } );
        }

        //-----------------------------------------------------------
        private void do_work()
        {
            ThreadStartCln(true);
            byte[] buf = new byte[1024];
            try
            {
                client = new TcpClient(Host.Text, 8001);        // inicjuje nowe wystąpienie TcpClient klasy i łączy z określonego portu na określonym hoście.
                client.ReceiveTimeout = 5;                      // Zwraca lub ustawia czas TcpClient będzie czekać do odbierania danych po zainicjowaniu operacji odczytu.
                
                while (Work) // checbox checked
                {
                    try
                    {

                        string cmdall = en.GetString(buf, 0, client.Client.Receive(buf));  // tu otrzymujemy od klienta zdekodowany zakres bajtów z tablicy bajtowej w ciąg znaków. (Zastępuje Encoding.GetString(Byte[], Int32, Int32)).
                        string[] cmdarr = cmdall.Split('\n');                               // podzial otrzymanego tekstu, bo mogliśmy otrzymać w nie tej kolejności / załączone żądania 
                        foreach (string cmd in cmdarr)
                        {
                            if (cmd[0] == 'p')                                              // otrzymaliśmy wartość progressBara to go update;uj
                            {
                                bool op = int.TryParse(cmd.Remove(0, 1), out progressValue);
                                panel1.Invoke(new MethodInvoker(delegate { updateProgressBarObject.progressB.Value = progressValue; }));
                            }
                            else
                            {                                                           //  otrzymaliśmy wynik to wyświetl go w Log textbox, usun progressBar 
                                ThreadAppendText(cmd);
                                panel1.Invoke(new MethodInvoker(delegate { panel1.Controls.Remove(updateProgressBarObject.progressB); }));
                                //PrzesunPbarThread(updateProgressBarObject.progressB);
                                updateProgressBarObject = null;
                                panel1.Invoke(new MethodInvoker(delegate { BtnSend.Enabled = true; }));   // odblokuj Send button
                              
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                client.Close();
                client = null;
            }
            catch{
                MessageBox.Show("Nie można nawiązać połączenia.");
                return;
            }
        }

        //-----------------------------------------------------
        private void BtnSend_Click_1(object sender, EventArgs e)
        {

                bool op = int.TryParse(Line.Text, out n);

                client.Client.Send(en.GetBytes(Line.Text));
                Line.SelectAll();
                Line.Focus();

                updateProgressBarObject = new UpdateProgressBar(this, n); // tworzymy progressBar
                BtnSend.Enabled = false;                                   // zablikuj button, aż do otrzymania wyniku
        }

        //---------------------------------------------------------------------
        private void Client_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Work = false;
            if (client != null) watek.Join();
        }

        // Nawiązanie/anulowanie połączenia z serwerem TCP 
        //--------------------------------------------------------------------
        private void BtnConnect_CheckedChanged_1(object sender, EventArgs e)
        {
            if (watek != null) // zakończ połączenie
            {
                Work = false;
                watek.Join();
                StartCln(false);
                watek = null;
             
            }
            else
            {                   // połącz z serwerem i odbieraj dane
                Work = true;
                watek = new Thread(do_work);
                watek.Priority = ThreadPriority.BelowNormal;
                watek.Start();
             
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

    }
}
