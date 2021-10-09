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
    auto myChar = 'a';
    auto myInt = 9;
    auto myDouble = 5.0;
    
    cout<<sizeof(myChar)<<endl;
    cout<<sizeof(myInt)<<endl;
    cout<<sizeof(myDouble)<<endl;
    
    
    return 0;
    }
