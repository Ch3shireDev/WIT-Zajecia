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


void Test(){}

int main(){
    auto ff=Test;
    
    
    cout<<"Size of Test    = "<<sizeof(ff)<<endl;
        
    printf("%p\n",(void*)Test);        
    cout<<(void*)Test<<endl;
    
    printf("%p\n",(void*)ff);        
    cout<<(void*)ff<<endl;

    return 0;
    }
