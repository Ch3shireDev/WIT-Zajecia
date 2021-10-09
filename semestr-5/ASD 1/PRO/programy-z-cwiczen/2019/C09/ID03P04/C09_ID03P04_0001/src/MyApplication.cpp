#include "MyApplication.h"

void MyApplication::Run()
{
    srand(time(0));
    Main10();
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

void MyApplication::Main06()
{
    TabInt01 t1(10), t2, t3;

    for(int i =0; i<t1.Length();++i)
        t1[i] = rand()%10;


    cout<<"t1: ";
    for(int i =0; i<t1.Length();++i)
        cout<<t1[i]<<" ";

    cout<<endl;

    t2 = t1;
    for(int i =0; i<t1.Length();++i)
        t2[i] = 999;


    cout<<"t1: ";
    for(int i =0; i<t1.Length();++i)
        cout<<t1[i]<<" ";


    for(int i=0; i<999999;++i)
        for(int j=0; j<999999;++j)
            t2=t1;
}

void MyApplication::Main07()
{
    TabInt01 t1(10);

    for(int i =0; i<t1.Length();++i)
        t1[i] = rand()%10;

    ///cout<<"t1: ";
    ///operator<<(cout,"t1: ");
    ///operator<<(cout, t1);
    ///operator<<(operator<<(cout,"t1: "), t1);

    ///operator<<(cout,"t1: ")<<t1;
    cout<<"t1: "<<t1;

    cout<<endl;

    ///cout<<"t1: "<<t1<<endl;

}
void MyApplication::Main08()
{
    TabInt01 t1(10), t2, t3, t4;

    for(int i =0; i<t1.Length();++i)
        t1[i] = 1;

    t2 = t1 + 5;
    t2 = t1.operator+(5);

    cout<<"t1: "<<t1<<endl;
    cout<<"t2: "<<t2<<endl;

    ///t2 = 3.operator+(t1); - Ÿle !!!
    t2 = 3 + t1;
    t2 = operator+(3, t1);

    cout<<"t2: "<<t2<<endl;


    t3 = ++t2;
    cout<<"t3: "<<t3<<endl;
    t4 = t3++;
    cout<<"t2: "<<t2<<endl;
    cout<<"t3: "<<t3<<endl;
    cout<<"t4: "<<t4<<endl;
    ///5, 5, 4, 4, 4

    }
void MyApplication::Main09()
{
    TabInt02 t1(20,10);
    TabInt01 tt(10);
    tt.FillRandom(0,10);
    cout<<endl<<tt<<endl;

}
void MyApplication::Main10()
{
    TabInt02 t1(4,10);
    t1.FillRandom(0,10);
    cout<<endl<<t1<<endl;
}
