#include "C1.h"

///***************************************
C1::C1(int ax, int bx, int x):
    A(ax),
    B1(ax, bx), B2(2*ax, 2*bx, ax+bx) ,x(x){
    cout<<"\t\tKonstruktor C1"<<endl;
    }
///***************************************
string C1::ToString(){
    return B1::ToString() +
     ", C1::x = " + to_string(x);
    }
///***************************************
int C1::GetX(char c){
    if('A'==c || 'B'==c )return B1::GetX(c);
    return x;
    }
///***************************************
