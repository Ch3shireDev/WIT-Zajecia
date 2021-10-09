#include <iostream>
#include <vector>
#include<iomanip>
#include<ctime>
#include<cstdlib>
using std::cout;
using std::endl;
using std::cin;

using std::vector;
using std::setw;
using std::string;

///---------------------------------------------------------------------------
int Fate(int, int);///losowa liczba z przedziału [a, b)

///vector o losowym rozmiarze z przedziału [as, bs]
///wypełniony losowymi danymi z przedziału [a, b)
vector<int> RandTab01(int as, int bs, int a, int b );


///vector "dwuwymiarowy" s0 x s1
///wypełniony losowymi danymi z przedziału [a, b)
vector<vector<int>> NewTab02(int s0, int s1, int a, int b );

void PrintTab01(vector<int>& );
void PrintTab01(vector<vector<int>>& );

int MaxTab(vector<int>&);
///---------------------------------------------------------------------------
int Fate(int a, int b){
    return (rand()%(b-a))  + a;
    }
///---------------------------------------------------------------------------
vector<int> RandTab01(int as, int bs, int a, int b ){
    vector<int> v(Fate(as, bs+1));
    for(size_t i = 0; i< v.size();++i)
        v[i] = Fate(a,b);
    return v;
    }
///---------------------------------------------------------------------------
vector<vector<int>> NewTab02(int s0, int s1, int a, int b ){
    vector<vector<int>> v(s0, vector<int>(s1));
    for(size_t i =0 ; i< v.size();++i)
        for(size_t j = 0; j<v[i].size(); ++j)
            v[i][j] = Fate(a, b);
    
    return v;
    }    
///---------------------------------------------------------------------------
void PrintTab01(vector<int>& v){
    for(size_t i =0; i< v.size();++i) 
        cout<<"["<<setw(2)<< v[i] <<"]";
    }
///---------------------------------------------------------------------------
void PrintTab01(vector<vector<int>>& v){
    for(size_t i =0 ; i< v.size();++i,cout<<endl)
        for(size_t j = 0; j<v[i].size(); ++j)
            cout<<"["<<setw(2)<<v[i][j]<<"]";
    }
///---------------------------------------------------------------------------
int MaxTab(vector<int>& v){
    int myMax = v[0];
    for(size_t i = 1; i< v.size();++i)
        if(myMax< v[i]) myMax = v[i];
    
    return myMax;
    }
///---------------------------------------------------------------------------
int main(){
    srand(time(0));
    vector<vector<int>> v  = NewTab02(4,7,0,100);
    PrintTab01(v);
    
    

    cout<<"--------------------------------------------\n";
        
    return 0;
    }
    
///45, 40, 40, 35, 35, 35, 30, 30, 30, 25 ....
