using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    /*
        klasa ustawiająca progressBara
     */
    class UpdateProgressBar
    {

        //--------------------------------------
        public UpdateProgressBar(Client form, int n)
        {
 
            ProgressBar progressB = new ProgressBar(); 
            form.panel1.Invoke(new MethodInvoker(delegate { form.panel1.Controls.Add(progressB); }));
            form.panel1.Invoke(new MethodInvoker(delegate { progressB.Maximum = n; }));
            form.panel1.Invoke(new MethodInvoker(delegate { form.PrzesunBar(null); }));
        }


    } 
}
