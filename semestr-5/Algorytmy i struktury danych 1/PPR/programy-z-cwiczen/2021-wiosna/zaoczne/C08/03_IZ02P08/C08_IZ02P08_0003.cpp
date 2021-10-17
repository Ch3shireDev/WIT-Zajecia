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




int main(){    
    auto FL01=[]()->void{cout<<"Moja pierwsza Lambda"<<endl;};
    
    FL01();
    
    return 0;
    }
