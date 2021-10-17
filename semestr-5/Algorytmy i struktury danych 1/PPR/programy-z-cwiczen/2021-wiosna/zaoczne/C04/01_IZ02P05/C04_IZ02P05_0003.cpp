#include <iostream>

#include <vector>
#include <ctime>
#include <iomanip>


using std::cout;
using std::endl;
using std::cin;

using std::vector;
using std::setw;

///---------------------------------------------------------------------------
int Fate(int, int);///losowa liczba z przedziału [a, b)
void MySwap(int&, int&);
void PrintInt(int&);
void PrintInt(int&& );
///---------------------------------------------------------------------------
int Fate(int a, int b){
    return (rand()%(b-a))  + a;
    }
///---------------------------------------------------------------------------
void MySwap(int& x, int& y){
    int tmp;
    tmp = x;
    x = y;
    y =tmp;
    }
///---------------------------------------------------------------------------
void PrintInt(int&x){
    cout<<"zmienna = "<<x<<endl;
    }
///---------------------------------------------------------------------------
void PrintInt(int&& x){
    cout<<"liczba = "<<x<<endl;
    }
///---------------------------------------------------------------------------
///---------------------------------------------------------------------------
int main(){
    srand(time(0));
    int x =7, y =3;
    cout<<"x = "<<x<<"\t y = "<<y<<endl;
    MySwap(x, y);
    cout<<"x = "<<x<<"\t y = "<<y<<endl;
    PrintInt(x);
    PrintInt(22);
    
            
    return 0;
    }

