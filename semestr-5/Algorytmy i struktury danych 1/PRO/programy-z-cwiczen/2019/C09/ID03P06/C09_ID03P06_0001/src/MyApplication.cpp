#include "MyApplication.h"
///***************************************
void MyApplication::Run(){
    srand(time(0));
    Main01();
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
