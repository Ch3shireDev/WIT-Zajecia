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
void FillTab(vector<int>&, int, int);
void PrintTab(vector<int>&);
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
void FillTab(vector<int>& v, int a, int b){
    for(int  i = 0; i< v.size(); ++i)
        v[i] = Fate(a, b);
    }
///---------------------------------------------------------------------------------------
void PrintTab(vector<int>& v){
    for(int  i = 0; i< v.size(); ++i)
        cout<<"v["<<setw(2)<<i<<"] = "<<setw(2)<<v[i]<<endl;
    }
///---------------------------------------------------------------------------------------
///std = c++0x
///---------------------------------------------------------------------------------------
int main(){
    srand(time(0));
    vector<int> v(20);    
    
    FillTab(v, 0, 100);
    PrintTab(v);
    
    return 0;
    }

