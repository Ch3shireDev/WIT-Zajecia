#include "MyApplication.h"
///***************************************
void MyApplication::Run(){
    srand(time(0));
    Main07();
    }
///***************************************
void MyApplication::Main01(){
    TabInt02 t(3,8), t1(t);
    t.FillRandom(0,10);
    t1.FillRandom(0,2);

    cout<<t;
    cout<<"------------------"<<endl;
    cout<<t1;
    }
///***************************************
void MyApplication::Main02(){
    TabInt02 t(1,8), t1;
    t.FillRandom(8,10);

    t1=t;

    t1.FillRandom(0,2);

    cout<<t;
    cout<<"------------------"<<endl;
    cout<<t1;
    cout<<"------------------"<<endl;
    }
///***************************************
void MyApplication::Main03(){
    TabInt02 t(5,8);
    t.FillRandom(8,10);

    cout<<t;
    cout<<"------------------"<<endl;
    }
///***************************************
void MyApplication::Main04(){
    TabInt02 t(15);
    t.FillRandom(8,10);

    cout<<t;
    cout<<"------------------"<<endl;
    }
///***************************************
void MyApplication::Main05(){
    TabInt02 t(10,12);
    t.FillRandom(8,10);

    t[0][0]=123;

    t.operator[](0).operator[](0)=123;

    cout<<t;
    cout<<"------------------"<<endl;
    }
///***************************************
void MyApplication::Main06(){
    TabInt02 t(20);

    for(int i=0;i< t.Length();++i)
        t[i]=TabInt01(i+1);
    t.FillRandom(1,2);

    cout<<t;
    cout<<"------------------"<<endl;
    }
///***************************************
void MyApplication::Main07(){
    TabInt02 t(20);

    for(int i=0;i< t.Length();++i)
        t[i]=TabInt01(rand()%25);
    t.FillRandom(0,10);

    cout<<t;
    cout<<"------------------"<<endl;
    }














