#include "MyApplication.h"
///*****************************************
void MyApplication::Run()
{
    srand(time(0));
    Main08();
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
///*****************************************
void MyApplication::Main04()
{
    TabInt02 tt(8,12);
    tt.FillRandom(0,2);
    TabInt02 ts(tt);
    cout<<ts;
    cout<<endl<<"---------------\n";
    ts.FillRandom(8,10);
    cout<<tt<<endl<<"---------------\n";
    cout<<ts;
}
///*****************************************
void MyApplication::Main05()
{
    TabInt02 tt(8,12);
    tt.FillRandom(0,2);
    TabInt02 ts;
    ts = tt;
    cout<<ts;
    cout<<endl<<"---------------\n";
    ts.FillRandom(8,10);
    cout<<tt<<endl<<"---------------\n";
    cout<<ts;
}
///*****************************************
void MyApplication::Main06()
{
    TabInt02 tt(8,12);
    tt.FillRandom(0,2);
    tt[0][0]=123;
    tt.operator[](0).operator[](0)=123;

    cout<<tt<<endl<<"---------------\n";
}

///*****************************************
void MyApplication::Main07()
{
    TabInt02 tt(12);

    for(int i =0; i<tt.Length();++i)
        tt[i]=TabInt01(i+1);
    tt.FillRandom(1,2);


    cout<<tt<<endl;
}

///*****************************************
void MyApplication::Main08()
{
    TabInt02 tt(12);

    for(int i =0; i<tt.Length();++i)
        tt[i]=TabInt01(rand()%20);
    tt.FillRandom(0,10);


    cout<<tt<<endl;
}








