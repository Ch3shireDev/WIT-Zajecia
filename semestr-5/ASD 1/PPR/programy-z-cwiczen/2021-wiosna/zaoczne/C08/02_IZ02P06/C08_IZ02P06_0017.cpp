#include<iostream>
#include<functional>
#include<vector>
#include<iomanip>
#include<cstdio>

using std::cout;
using std::endl;
using std::cin;
using std::function;
using std::vector;
using std::setw;


int MyTest(int x, function<int(int)> ff){
    for(int i=0; i< 5;++i) x+=ff(x);
    return x;
    }

int Ekstremum(int x, int y, function<int(int, int)> ff){return ff(x, y);}

int main(){
    int x =12 , y = 22;

    cout<<"Min("<<x<<", "<<y<<") = "<<Ekstremum(x, y, [](int x, int y){if(x<y)return x; return y;})<<endl;
    cout<<"Max("<<x<<", "<<y<<") = "<<Ekstremum(x, y, [](int x, int y){if(x>y)return x; return y;})<<endl;
    
    
    
    
        
    return 0;
    }
