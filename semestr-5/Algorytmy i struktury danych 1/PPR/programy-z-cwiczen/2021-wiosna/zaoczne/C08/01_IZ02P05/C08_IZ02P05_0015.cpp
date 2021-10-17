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





void MyPrint(int x, function<void(int)> ff){
    ff(x);
    }


int main(){
    int x =12, y = 22;

    MyPrint(x, [](int a){cout<<"x = "<<a<<endl;});
            
    return 0;
    }
