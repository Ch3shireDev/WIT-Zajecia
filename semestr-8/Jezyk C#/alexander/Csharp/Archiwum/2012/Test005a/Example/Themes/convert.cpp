#include <iostream>
#include <fstream>
using namespace std;

int main()
  {
   fstream f("P:\\Barski\\C#\\Test005a\\Example\\Themes\\JensOriginal.theme",ios::in);
   while(true)
     {
      int r,g,b;
      if(f>>r>>g>>b)
        {
         cout<<"            Color.FromArgb( "<<r<<", "<<g<<", "<<b<<"),"<<endl;
        }
      else break;
     }
   f.close();
   cin.sync();
   cin.get();
   return 0;
  }
