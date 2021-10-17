///213.135.46.21:7070
#include <iostream>
using std::cout;
using std::cin;
using std::endl;
using std::string;

typedef void (*Aqq)();
void FT1();
void FT2();
void FT3();

int MySwap(int*, int*);

void FT1(){cout<<"FT1"<<endl;}
void FT2(){cout<<"\tFT2"<<endl;}
void FT3(){cout<<"\t\tFT3"<<endl;}


int main(){
    int x = 7, y =9;
    //cout<<"x = "<<x<<", y = "<<y<<endl;
    Aqq myF1 = FT1, myF2 = FT2, myF3 = FT3;


    myF1();
    myF2();
    myF3();

    return 0;
    }
