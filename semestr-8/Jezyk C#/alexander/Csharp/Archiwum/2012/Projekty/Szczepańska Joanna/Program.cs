using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //SplashScreen splashContext = new SplashScreen(new Form1(), new Splash());

            //Application.Run(splashContext);
            Application.Run(new MainForm());
        }
    }
}
