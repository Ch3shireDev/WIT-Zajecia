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
    auto FL01 = []()->void{
        cout<<"Moja Lambda 0001"<<endl;
        };
        
        FL01();
    
    
    return 0;
    }
