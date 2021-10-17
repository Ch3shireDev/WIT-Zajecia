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
void PrintTab01(vector<int>& );
int MaxTab01(vector<int>);
///---------------------------------------------------------------------------
int Fate(int a, int b){
    return (rand()%(b-a))  + a;
    }
///---------------------------------------------------------------------------
vector<int> RandTab01(int as, int bs, int a, int b ){
    vector<int> v(Fate(as,bs+1));
    for(size_t i = 0; i<v.size();++i) v[i] = Fate(a, b);
    return v;
    }
///---------------------------------------------------------------------------
void PrintTab01(vector<int>& v){
    for(size_t i =0; i< v.size();++i) 
        cout<<"["<<setw(2)<< v[i] <<"]";
    }
///---------------------------------------------------------------------------
int MaxTab01(vector<int> v){
    int myMax = v[0];
    for(size_t i = 1; i< v.size();++i)
        if(myMax<v[i]) myMax = v[i];    
    return myMax;
    }
///---------------------------------------------------------------------------
int main(){
    srand(time(0));
    vector <int> v0 = RandTab01(5,5,0,100);
    vector <int> v1 = RandTab01(5,5,0,100);
    vector <int> v2 = RandTab01(5,5,0,100);
    PrintTab01(v0);
    cout<<endl;
    PrintTab01(v1);
    cout<<endl;
    PrintTab01(v2);
    cout<<endl;
    vector<vector<int>>v (3);
    v[0] = v0;
    v[1] = v1;
    v[2] = v2;
    
    cout<<"-----------------------------------------------------------------------\n";
    for(size_t i=0; i<v.size(); ++i, cout<<endl)
        PrintTab01(v[i]);
    cout<<"-----------------------------------------------------------------------\n";
    v[0][0] = -1;
    for(size_t i=0; i<v.size(); ++i, cout<<endl)
        for(size_t j =0; j<v[i].size(); ++j)
            cout<<"["<<setw(2)<< v[i][j] <<"]";
    cout<<"-----------------------------------------------------------------------\n";
    vector<vector<int>>vv (6, vector<int>(9));
    for(size_t i=0; i<vv.size(); ++i, cout<<endl)
        for(size_t j =0; j<vv[i].size(); ++j)
            vv[i][j] = Fate(0,100);

            
    for(size_t i=0; i<vv.size(); ++i, cout<<endl)
        for(size_t j =0; j<vv[i].size(); ++j)
            cout<<"["<<setw(2)<< vv[i][j] <<"]";
    cout<<"-----------------------------------------------------------------------\n";

    
    return 0;
    }

