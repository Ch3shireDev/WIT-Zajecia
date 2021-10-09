///213.135.46.21:7070
#include <iostream>
using std::cout;
using std::cin;
using std::string;
using std::endl;

typedef void(*Aqq)(int);

typedef int myInt;

void MySwap(int*, int*);
void FF1(int);


void FF1(int x){ cout<<"x = "<<x<<endl;}

int main(){
    Aqq myF = FF1;
    myInt x;
    x =12;
    FF1(x);
    myF(x);
    return 0;
    }
