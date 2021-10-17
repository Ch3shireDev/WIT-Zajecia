#include <iostream>

#include <iomanip>

#include<ctime>
#include<cstdlib>

using std::cout;
using std::cin;
using std::endl;
using std::setw;

///---------------------------------------------------------------------------------------
int Fate(int a, int b);///zwraca losową wartość z przedziału [a, b)
void MySwap(int&, int&);
void PrintInt(int&);
void PrintInt(int&&);
///---------------------------------------------------------------------------------------
int Fate(int a, int b){
    return rand()%(b-a)+a;
    }
///---------------------------------------------------------------------------------------
void MySwap(int& a, int& b){
    int tmp = a;
    a = b;
    b = tmp;
    }
///---------------------------------------------------------------------------------------
void PrintInt(int& x){
    cout<<"zmienna = "<<x<<endl;
    }
///---------------------------------------------------------------------------------------
void PrintInt(int&& x){    
    cout<<"liczba = "<<x<<endl;
    }
///---------------------------------------------------------------------------------------
///std = c++0x
///---------------------------------------------------------------------------------------
int main(){
    srand(time(0));
    int x = 7;
    PrintInt(x);
    PrintInt(22);
        
    
    return 0;
    }
