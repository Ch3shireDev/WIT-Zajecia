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


int main(){
    int x =12 , y = 22;

    y = MyTest(x, [](int x){return 2*x;});    
    cout<<"Test("<<x<<") = "<<y<<endl;
    
    y = MyTest(x, [](int x){return 2+x;});    
    cout<<"Test("<<x<<") = "<<y<<endl;
    
    y = MyTest(x, [](int x){return x-1;});    
    cout<<"Test("<<x<<") = "<<y<<endl;
    
        
    return 0;
    }
///40, 40, 35, 35, 35, 30 ...
