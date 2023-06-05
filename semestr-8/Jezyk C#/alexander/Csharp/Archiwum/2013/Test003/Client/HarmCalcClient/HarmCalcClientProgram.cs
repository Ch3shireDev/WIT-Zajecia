using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HarmCalcThread
{
    static class HarmCalcClientProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HarmCalcMain());
        }
    }
}
