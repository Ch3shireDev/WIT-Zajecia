///213.135.46.21:7070
#include <iostream>
using std::cout;
using std::cin;
using std::string;
using std::endl;

int MySwap(int*, int*);
int MySwap(int&, int&);

int MySwap(int * x, int * y){
    int tmP;
    tmP= *x;
    *x = *y;
    *y = tmP;

    return 0;
    }

int MySwap(int&  x, int&  y){
    int tmP;
    tmP= x;
    x = y;
    y = tmP;

    return 0;
    }

int main(){
    int a=12, b=7;

    cout<<"a = "<<a<<", b = "<<b<<endl;
    MySwap(&a,&b);
    cout<<"a = "<<a<<", b = "<<b<<endl;
    MySwap(a,b);
    cout<<"a = "<<a<<", b = "<<b<<endl;
    return 0;
    }
