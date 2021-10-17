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

typedef  int(*FF02)(int&, int);
function <int(int&, int)> FL01;

int main(){    
    int x = 7, y =9;
    FL01=[](int& x, int y){
        auto FFTemp = [](int& a){a*=2;};
        FFTemp(x);
        if(x>y) 
            return x;
        return y;
        };
    
    int myMaks = FL01(x, y);
    
    cout<<"Max("<<x<<", "<<y<<") = "<<myMaks<<endl;
    
    return 0;
    }
