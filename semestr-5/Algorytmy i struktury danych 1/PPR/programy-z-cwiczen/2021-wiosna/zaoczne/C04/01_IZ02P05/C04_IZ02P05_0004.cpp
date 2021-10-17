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
void FillTab(vector<int> &, int, int);
void PrintTab(vector<int>& );
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
void FillTab(vector<int> & v, int a, int b){
    for(int i =0; i< v.size();++i) v[i] = Fate(a, b);
    }
///---------------------------------------------------------------------------
void PrintTab(vector<int>& v){
    for(int i =0; i< v.size();++i) 
        cout<<"v["<<setw(2)<<i<<"] = "<<setw(2)<< v[i] <<endl;
    }
///---------------------------------------------------------------------------
///---------------------------------------------------------------------------
int main(){
    srand(time(0));
    vector<int> v(20);
    FillTab(v, 0, 100);///FillTab(v, a, b) - wypełnia vector v wartościami losowymi z przedziału [a, b)
    PrintTab(v); ///drukuje vector v
            
    return 0;
    }
///30, 30, 30, 25, 25, 25, 25, 15 ...
