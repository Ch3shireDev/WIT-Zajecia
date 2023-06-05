using System;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication5
{

    /// <summary>
    /// This class will show or hide windows taskbar for full screen mode.
    /// </summary>
    class handleTaskBar
    {
        private const int SWP_HIDEWINDOW = 0x0080;
		private const int SWP_SHOWWINDOW = 0x0040;

        public handleTaskBar()
        {
        }

        [DllImport("User32.dll", EntryPoint="FindWindow")]     //pobieramy z pliku zewnetrznego User32.dll funkcje FindWindow
            private static extern int FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll")]   //pobieramy z pliku zewnetrznego User32.dll funkcje (nie ma wpisanego jaka dlatego domyslnie brana jest ta nizej)
            private static extern int SetWindowPos(int hWn, int hWnInsertAfter, int x, int y, int cx, int cy, int wFlags);

        public static void showTaskBar()
        {
            int hWnd = FindWindow("Shell_TrayWnd", "");
            SetWindowPos(hWnd, 0, 0, 0, 0, 0, SWP_SHOWWINDOW);
        }

        public static void hideTaskBar()
        {
            int hWnd = FindWindow("Shell_TrayWnd", "");
            SetWindowPos(hWnd, 0, 0, 0, 0, 0, SWP_HIDEWINDOW);
        }
        
    }
}
