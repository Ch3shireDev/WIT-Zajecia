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

typedef int(*FF02)(int&, int);
typedef void(*FF03)(int&);



int main(){
    int x =12, y = 22;
    FF02 FL01 = [](int& a, int b){
    FF03 FFTemp = [](int& a){ a *= 2;};
        FFTemp(a);
        if(a>b)
            return a;
        return b;
        };
        
        cout<<"Max("<<x<<", "<<y<<") = "<<FL01(x,y)<<endl;
        cout<<"Max("<<x<<", "<<y<<") = "<<FL01(x,y)<<endl;
        
    return 0;
    }
///35, 35, 35, 30 ...
