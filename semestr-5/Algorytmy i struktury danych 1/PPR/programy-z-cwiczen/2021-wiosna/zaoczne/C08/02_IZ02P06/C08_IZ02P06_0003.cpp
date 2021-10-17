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
    auto FL01 = [](){cout<<"Moja pierwsza Lambda\n\n";};
    FL01();
    
    return 0;
    }
