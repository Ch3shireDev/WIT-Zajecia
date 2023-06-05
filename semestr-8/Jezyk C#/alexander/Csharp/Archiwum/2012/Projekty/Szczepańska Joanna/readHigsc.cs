using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsFormsApplication5
{
    class readHigsc
    {
        private static string[] line;
        string[] imie;
        string[] wyniki;

        public readHigsc()
        {
            highsc();
        }

#region getset
        //getset Imie
        public string[] gsImie
        {
            get { return imie; }
            set { imie = value; }
        }
        //getset wyniki
        public string[] gsWyniki
        {
            get { return wyniki; }
            set { wyniki = value; }
        }
#endregion
#region highscore read from file
        private void highsc()
        {
            imie = new string[10];
            wyniki = new string[10];
            line = new string[10];
            string[] pom = new string[2];
            try
            {
                using (System.IO.StreamReader sr = System.IO.File.OpenText("highscore.txt"))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        line[i] = sr.ReadLine();
                        pom = line[i].Split(' ');
                        for (int j = 0; j < 2; j++)
                        {
                            if (j == 0)
                            {
                                imie[i] = pom[j];
                            }
                            else
                            {
                                wyniki[i] = pom[j];
                            }
                        }
                    }
                    sr.Close();
                }
            }
            catch (IOException) { }

        }
        #endregion
    }
}
