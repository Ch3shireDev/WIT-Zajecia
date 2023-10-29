#include "event.h"
#include "ievent.h"
#include <stdlib.h>
#include <iostream.h>
#include <time.h>
#include <dos.h>
void label(int v){
    if(v == 1)  cout << "Autor: Noname\n\n";
    else if(v == 0){
        InfoEvent e;
        e << " Nie wipisana wizytowka\n\n";
        throw e;
     }
     else{
         Event e;
         e.setFName("label");
         e << "Bledny parametr";
         e.setTime();
         throw(e);     
     }
}
int getValue(){
    int val;
    cout << "Podaj wartosc dodatnia:";
    cin >> val;
    if(val < 0) throw("Blad IO: Wartosc ujemna.");
    return val;
}
float calc(int v){
    if(v == 0){
         Event e;
         e.setFName("calc");
         e << "Dzielenie przez zero";
         e.setTime();
         throw(e);
    }
    return 1.0/v;
}

int main(int argc, char *argv[])
{
    try{
        label(3);
    }
    catch(Event & e){
        e.show();
    }
    
    int opcja;
    float wyn;
    try{
        opcja = getValue();
        wyn = calc(opcja);
    }
    catch(int b){
        cout << b << endl;
    }
    catch(const char* b){
        cout << b << endl;
    }
    catch(Event &e){
        e.show();
        e.exe();
    }
    catch(...){
        cout << "nieznany blad" << endl;    
    }
    
    cout << "Wynik :" << wyn << endl;
  
  system("PAUSE");	
  return 0;
}
