#include "MyApplication.h"
///***************************************
void MyApplication::Run(){
    srand(time(0));
    Main06();
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
