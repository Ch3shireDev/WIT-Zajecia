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
///---------------------------------------------------------------------------
int Fate(int a, int b){
    return (rand()%(b-a))  + a;
    }
///---------------------------------------------------------------------------
///---------------------------------------------------------------------------
int main(){
    srand(time(0));

    vector<int> v(15);
    cout<<"size table = "<<v.size()<<endl;
    for(int i =0; i< v.size();++i)
        v[i] = Fate(0,100);

    for(int i =0; i< v.size();++i)
        cout<<"v["<<setw(2)<<i<<"] = "<<setw(2)<<v[i]<<endl;
        
    return 0;
    }

