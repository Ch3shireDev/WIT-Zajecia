#include<iostream>
#include<iomanip>
#include<ctime>
#include<cstdlib>

#include<vector>

using std::cout;
using std::cin;
using std::endl;
using std::setw;
using std::vector;

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
    vector<int> v(20);
    
    cout<<"table size = "<<v.size()<<endl;
    
    
    for(int i = 0; i < v.size(); ++i)
        v[i] = Fate(0, 100);
        
    for(int i = 0; i < v.size(); ++i)
        cout<<"v["<<setw(2)<<i<<"] = "<<setw(2)<<v[i]<<endl;
    
    return 0;
    }
