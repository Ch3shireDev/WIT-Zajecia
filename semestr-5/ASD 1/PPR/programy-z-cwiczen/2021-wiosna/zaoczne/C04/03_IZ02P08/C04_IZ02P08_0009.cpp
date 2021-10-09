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
int CntMax(vector<int>&);
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
    for(unsigned  i = 0; i< v.size(); ++i)
        v[i] = Fate(a, b);
    }
///---------------------------------------------------------------------------------------
void PrintTab(vector<int>& v){
    for(size_t  i = 0; i< v.size(); ++i)
        cout<<"v["<<setw(2)<<i<<"] = "<<setw(2)<<v[i]<<endl;
    }
///---------------------------------------------------------------------------------------
int CntMax(vector<int>& v){
    int cnt =0;
    int mmax = v[0];
    for(size_t i =0; i< v.size(); ++i){
        if(mmax<v[i]){
            mmax = v[i];
            cnt = 0;
            }
        if (mmax == v[i]) ++cnt;
        }    
    return cnt;
    }
///---------------------------------------------------------------------------------------
///std = c++0x
///---------------------------------------------------------------------------------------
int main(){
    srand(time(0));
    vector<int> v(20);    
    
    FillTab(v, 0, 7);
    PrintTab(v);
    
    cout<<"cnt = "<<CntMax(v)<<endl;
    
    return 0;
    }

