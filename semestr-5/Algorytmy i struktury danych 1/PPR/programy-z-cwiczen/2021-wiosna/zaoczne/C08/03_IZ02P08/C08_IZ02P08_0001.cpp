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
    auto myInt=7;
    auto myDouble=7.0;
    auto myChar='a';
    
    
    cout<<"Size of myInt    = "<<sizeof(myInt)<<endl;
    cout<<"Size of myDouble = "<<sizeof(myDouble)<<endl;
    cout<<"Size of myChar   = "<<sizeof(myChar)<<endl;
        
    return 0;
    }
