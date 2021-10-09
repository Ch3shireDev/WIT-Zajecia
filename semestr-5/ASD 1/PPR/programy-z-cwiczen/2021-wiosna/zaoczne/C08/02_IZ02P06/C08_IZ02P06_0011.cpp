#include<iostream>
#include<functional>
#include<vector>
#include<iomanip>

using std::cout;
using std::endl;
using std::cin;
using std::function;
using std::vector;
using std::setw;




int main(){
    int x =12 , y = 22;
    auto FL01 = [](int& a, int b){
        auto FFTemp = [](int& a){a*=2;};
        FFTemp(a); 
        if (a>b) 
            return a; 
        return b;
        };

    cout<<"Max("<<x<<", "<<y<<") = "<<FL01(x, y)<<endl;
    cout<<"Max("<<x<<", "<<y<<") = "<<FL01(x, y)<<endl;
    
    return 0;
    }
