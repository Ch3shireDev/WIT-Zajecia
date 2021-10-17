#include "MyApplication.h"
///***************************************
void MyApplication::Run(){
    srand(time(0));
    Main13();
}
///***************************************
void MyApplication::Main01(){
    cout<<"A q q i dobranoc ...\n";
}
///***************************************
void MyApplication::Main02(){
    cout<<"zmienna = "<<MyUtility::MyRead()<<endl;
}
///***************************************
void MyApplication::Main03(){
    TabInt01 t(10);

    for(int i =0; i< t.Length();++i)
        t.PT()[i] = rand()%10;
    for(int i =0; i< t.Length();++i)
        cout<<t.PT()[i]<<endl;
}
///***************************************
void MyApplication::Main04(){
    TabInt01 t(10);

    for(int i =0; i< t.Length();++i)
        t.Value(i) = rand()%10;
    for(int i =0; i< t.Length();++i)
        cout<<"t = "<<t.Value(i)<<endl;
}
///***************************************
void MyApplication::Main05(){
    TabInt01 t(10);

    for(int i =0; i< t.Length();++i)
        t.operator[](i) = rand()%10;
    for(int i =0; i< t.Length();++i)
        cout<<"t[] = "<<t.operator[](i)<<endl;
}
///***************************************
void MyApplication::Main06(){
    TabInt01 t(10);

    for(int i =0; i< t.Length();++i)
        t[i] = rand()%10;
    for(int i =0; i< t.Length();++i)
        cout<<"t["<<i<<"] = "<<t[i]<<endl;
}
///***************************************
void MyApplication::Main07(){
    TabInt01 t1(10), t2;

    for(int i =0; i< t1.Length();++i)
        t1[i] = rand()%10;

    cout<<"t1: ";
    for(int i =0; i< t1.Length();++i)
        cout<<t1[i]<<" ";
    cout<<endl;

    t2 = t1;
    for(int i =0; i< t2.Length();++i)
        t2[i] = 77;


    cout<<"t1: ";
    for(int i =0; i< t1.Length();++i)
        cout<<t1[i]<<" ";
    cout<<endl;

    cout<<"t2: ";
    for(int i =0; i< t2.Length();++i)
        cout<<t2[i]<<" ";
    cout<<endl;

}
///***************************************
void MyApplication::Main08(){
    TabInt01 t1(10), t2;

    for(int i =0; i< t1.Length();++i)
        t1[i] = rand()%10;

    cout<<"t1: ";
    for(int i =0; i< t1.Length();++i)
        cout<<t1[i]<<" ";
    cout<<endl;

    for(int i=0;i<999999999;++i)
        t2 = t1;

}
///***************************************
void MyApplication::Main09(){
    TabInt01 t1(10);

    for(int i =0; i< t1.Length();++i)
        t1[i] = rand()%10;

    cout<<"t1: ";
    cout<<t1;
    cout<<endl;
}
///***************************************
void MyApplication::Main10(){
    TabInt01 t1(10);

    for(int i =0; i< t1.Length();++i)
        t1[i] = rand()%10;

    cout<<"t1: "<<t1<<endl;
}
///***************************************
void MyApplication::Main11(){
    TabInt01 t1(10);

    for(int i =0; i< t1.Length();++i)
        t1[i] = rand()%10;

    cout<<"t1: "<<t1<<endl;


    operator<<(operator<<(cout,"t1: "),t1);
    cout<<endl;
}
///***************************************
void MyApplication::Main12(){
    TabInt01 t1(10), t2, t3, t4, t5;

    for(int i =0; i< t1.Length();++i)
        t1[i] = 1;

    t2 = t1 + 3;

    cout<<"t1: "<<t1<<endl;
    cout<<"t2: "<<t2<<endl<<endl;

    t2 = 2 + t1;

    cout<<"t1: "<<t1<<endl;
    cout<<"t2: "<<t2<<endl<<endl;

    t3 = ++t2;

    cout<<"t2: "<<t2<<endl;
    cout<<"t3: "<<t3<<endl<<endl;

    t4 = t3++;

    cout<<"t3: "<<t3<<endl;
    cout<<"t4: "<<t4<<endl<<endl;
    t5 = t4 + t3;
    cout<<"t5: "<<t5<<endl<<endl;
}
///***************************************
void MyApplication::Main13(){
    TabInt01 t1(10), t2, t3;

    for(int i =0; i< t1.Length();++i)
        t1[i] = 1;

    t2 = t1 + 3;

    t3 = t2 +t1;

    cout<<"t1: "<<t1<<endl;
    cout<<"t2: "<<t2<<endl<<endl;
    cout<<"t3: "<<t3<<endl<<endl;
}///***************************************

///6, 6, 5, 5, 4, 4

/**

t1: 1 1 1 1 1 1 1 1 1 1
t2: 4 4 4 4 4 4 4 4 4 4
t3: 4 4 4 4 4 4 4 4 4 4 1 1 1 1 1 1 1 1 1 1


*/






























