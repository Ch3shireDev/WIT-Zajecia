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
    auto myDouble = 5.5;
    auto myInt = 5;
    auto myChar = 'a';
    
    cout<<"Sizeof(myDouble) = "<<sizeof(myDouble)<<endl;
    cout<<"Sizeof(myInt) = "<<sizeof(myInt)<<endl;
    cout<<"Sizeof(myChar) = "<<sizeof(myChar)<<endl;
    

    
    return 0;
    }
