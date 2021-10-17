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
///std = c++0x
///---------------------------------------------------------------------------------------
int main(){
    srand(time(0));
    int x = 7, y =3;
        
    cout<<"x = "<<x<<"\ty = "<<y<<endl;
    MySwap(x, y);
    cout<<"x = "<<x<<"\ty = "<<y<<endl;
    
    
    return 0;
    }
