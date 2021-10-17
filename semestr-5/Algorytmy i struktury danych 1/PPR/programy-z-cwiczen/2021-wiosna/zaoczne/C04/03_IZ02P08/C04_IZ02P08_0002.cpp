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
///---------------------------------------------------------------------------------------
int Fate(int a, int b){
    return rand()%(b-a)+a;
    }
///---------------------------------------------------------------------------------------
///std = c++0x
///---------------------------------------------------------------------------------------
int main(){
    srand(time(0));
    
    for(int i = 0; i< 20; ++i)
        cout<<Fate(0, 100)<<endl;
    
    
    return 0;
    }
///17, 13, 13, 13, 13, 10 ...
