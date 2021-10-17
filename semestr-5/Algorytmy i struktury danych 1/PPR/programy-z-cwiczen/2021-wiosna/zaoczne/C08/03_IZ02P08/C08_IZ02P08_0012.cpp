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


function <int(int&, int)> FL01;
function <void(int&)> FFTemp;

int main(){    
    int x = 7, y =9;
    FL01=[](int& x, int y){
        FFTemp = [](int& a){a*=2;};
        FFTemp(x);
        if(x>y) 
            return x;
        return y;
        };
    
    int myMaks = FL01(x, y);
    
    cout<<"Max("<<x<<", "<<y<<") = "<<myMaks<<endl;
    
    return 0;
    }
///45, 40, 40, 35, 35, 35, 30 ...
