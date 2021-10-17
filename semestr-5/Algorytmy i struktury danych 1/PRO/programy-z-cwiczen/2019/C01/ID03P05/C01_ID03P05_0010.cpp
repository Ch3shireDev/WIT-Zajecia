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
    Aqq  * myF;

    myF = new Aqq[8];

    myF[0] = FT1;
    myF[1] = FT2;
    myF[2] = FT3;
    myF[3] = FT3;
    myF[4] = FT2;
    myF[5] = FT3;
    myF[6] = FT2;
    myF[7] = FT1;


    for(int i=0; i<8;++i) myF[i]();

    return 0;
    }
