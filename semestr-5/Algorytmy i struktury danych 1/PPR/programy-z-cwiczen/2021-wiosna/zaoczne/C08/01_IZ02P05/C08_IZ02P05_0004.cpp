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
    int x =12;
    auto FL01 = []()->int{
        return 22;
        };
        
        cout<<"x = "<<x<<endl;
        
        x = FL01();
    
        cout<<"x = "<<x<<endl;
    
    return 0;
    }
