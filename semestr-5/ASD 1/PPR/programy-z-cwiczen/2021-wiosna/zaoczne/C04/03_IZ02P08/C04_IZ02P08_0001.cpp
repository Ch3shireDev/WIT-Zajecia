#include <iostream>

#include<ctime>
#include<cstdlib>

using std::cout;
using std::cin;
using std::endl;

///---------------------------------------------------------------------------------------
///std = c++0x
///---------------------------------------------------------------------------------------
int main(){
    srand(time(0));
    
    cout<<rand()%10<<endl;
    cout<<rand()%10<<endl;
    cout<<rand()%10<<endl;
    
    return 0;
    }
