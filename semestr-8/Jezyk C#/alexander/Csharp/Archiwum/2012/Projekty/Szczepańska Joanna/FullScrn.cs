using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    class FullScrn
    {
        private Form _form;     //zmienna przechowujaca form
        private bool _FScrF;     //flaga sprawdzajaca czy mamy pelny ekran czy nie
        private FormWindowState _cwinstate;
        private FormBorderStyle _cwinborder;
        private Rectangle _bounds;
        private Size _fsizeof;
        
        public FullScrn(Form form)
        {
            _form = form;   //Przy wywolaniu konstruktora przypisuje dany formularz do zmiennej _form
            _FScrF = false; //flaga na 0 nie ma fullscreen
        }

        private void ScreenMode()
        {
            //set fullscreen
            if (!_FScrF)
            {
                // Get the WinForm properties
                _cwinborder = _form.FormBorderStyle;
                _bounds = _form.Bounds;  
                _cwinstate = _form.WindowState;
                _fsizeof = new Size(_form.Width, _form.Height);
                                
                // set to false to avoid site effect
                _form.Visible = false;          //Unikamy tutaj patrzenia na powiekszajacy sie ekran - brzydko to wyglada
                
                handleTaskBar.hideTaskBar();

                //ustawia nowe wlasciwosci
                _form.FormBorderStyle = FormBorderStyle.None;   //usuwamy ramki
                _form.WindowState = FormWindowState.Maximized;  //powiekszamy okno na maxa

                _form.Visible = true;       //Pokazujemy po modyfikacji okna
                _FScrF = true;              //flaga na 1 oznacza ze mamy fullscreen
            }
            else
            {
                
                _form.Visible = false;      //ukrywamy na czas modyfikacji okna by uniknac efektow ubocznych
                _form.WindowState = _cwinstate; //to musi byc przed border style zeby zadzialalo
                _form.FormBorderStyle = _cwinborder;
                _form.Size = _fsizeof;      //do poprzedniej wartosci wraca
                
                
                handleTaskBar.showTaskBar();

                _form.Visible = true;       //Pokazujemy po modyfikacji okna

                _FScrF = false; //flaga na 0 oznacza ze wychodzimy z fullscreen
            }
        }
        public void showFullScreen()
        {
            ScreenMode();
        }
        public void resetTaskBar()
        {
            handleTaskBar.showTaskBar();
        }
        

    }
}
