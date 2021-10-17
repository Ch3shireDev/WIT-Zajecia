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
    for(int i=0; i<5;++i)
        x+=ff(x);
    return x;
    }
int Ekstremum(int x, int y, function<int(int, int)> ff){return ff(x,y);}

int main(){
    int x =12, y = 22;
    int myMin, myMax;
    
    myMax=Ekstremum(x, y, [](int x, int y){if(x>y) return x; return y; });
    myMin=Ekstremum(x, y, [](int x, int y){if(x<y) return x; return y; });
    
    cout<<"Max("<<x<<", "<<y<<") = "<<myMax<<endl;
    cout<<"min("<<x<<", "<<y<<") = "<<myMin<<endl;
    
    
    return 0;
    }
