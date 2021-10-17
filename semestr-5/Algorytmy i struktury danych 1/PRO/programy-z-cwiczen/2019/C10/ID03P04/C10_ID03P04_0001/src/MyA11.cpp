#include "MyA11.h"

MyA11::MyA11(int x, int y): MyA(x+y,x-y),x(x), y(y){
        cout<<"\n---------->Konstruktor MyA11"<<endl;

    }
///******************************************************
void MyA11::Print(){
    MyA::Print();
    cout<<"x = "<<x<<", y = "<<y<<endl;
    }
///******************************************************
