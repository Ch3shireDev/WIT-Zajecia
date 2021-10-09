///213.135.46.21:7070
#include <iostream>
using std::cout;
using std::cin;
using std::string;
using std::endl;

typedef void(*Aqq)(int);

void MySwap(int*, int*);
void FF1(int);


void FF1(int x){ cout<<"x = "<<x<<endl;}

int main(){
    Aqq myF = FF1;


    FF1(12);
    myF(12);
    return 0;
    }
