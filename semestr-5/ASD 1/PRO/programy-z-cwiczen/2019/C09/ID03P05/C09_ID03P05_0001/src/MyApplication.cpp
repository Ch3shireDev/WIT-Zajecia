#include "MyApplication.h"
///*****************************************
void MyApplication::Run()
{
    srand(time(0));
    Main03();
}
///*****************************************
void MyApplication::Main01()
{
   /* TabInt01 t(10);
    t.FillRandom(0,10);
    cout<<endl<<t<<endl;
    */
}
///*****************************************
void MyApplication::Main02()
{
    TabInt02 tt(20);
}
///*****************************************
void MyApplication::Main03()
{
    TabInt02 tt(8,12);
    tt.FillRandom(0,10);
    cout<<tt;
}









