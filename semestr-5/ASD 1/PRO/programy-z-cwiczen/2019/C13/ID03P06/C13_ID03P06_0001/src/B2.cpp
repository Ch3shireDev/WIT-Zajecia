#include "B2.h"
///***************************************
B2::B2(int ax, int x, int y):A(ax),x(x),y(y){
    cout<<"\tKonstruktor B2"<<endl;
    }
///***************************************
string B2::ToString(){
    return A::ToString() +
     ", B2::x = " + to_string(x)+
     ", B2::y = " + to_string(y);
    }
///***************************************
int B2::GetX(char c){
    if('A'==c)return A::GetX();
    return x;
    }
///***************************************
int B2::GetY(){return y;}
///***************************************
