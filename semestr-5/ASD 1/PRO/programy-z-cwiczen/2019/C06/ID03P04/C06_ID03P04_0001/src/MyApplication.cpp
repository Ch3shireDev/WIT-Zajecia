#include "MyApplication.h"

void MyApplication::Run()
{
    srand(time(0));
    Main05();
}

void MyApplication::Main01()
{
    cout<<"x = "<<MyUtility::MyRead()<<endl;
}

void MyApplication::Main02()
{
    TabInt01 t(10);
    for(int i =0; i<t.Length();++i)
        t.T()[i] = rand()%10;
    for(int i =0; i<t.Length();++i)
        cout<<t.T()[i]<<endl;
}

void MyApplication::Main03()
{
    TabInt01 t(10);
    for(int i =0; i<t.Length();++i)
        t.Value(i) = rand()%10;
    for(int i =0; i<t.Length();++i)
        cout<<t.Value(i)<<endl;
}

void MyApplication::Main04()
{
    TabInt01 t(10);
    for(int i =0; i<t.Length();++i)
        t.operator[](i) = rand()%10;
    for(int i =0; i<t.Length();++i)
        cout<<t.operator[](i)<<endl;
}

void MyApplication::Main05()
{
    TabInt01 t(10);
    for(int i =0; i<t.Length();++i)
        t[i] = rand()%10;
    for(int i =0; i<t.Length();++i)
        cout<<t[i]<<endl;
}
