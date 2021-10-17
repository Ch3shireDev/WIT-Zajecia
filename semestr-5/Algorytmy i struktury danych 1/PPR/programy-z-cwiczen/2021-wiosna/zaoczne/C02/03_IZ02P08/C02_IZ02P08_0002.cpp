#include <iostream>
using std::cout;
using std::endl;
using std::cin;


int main(){
    int x, i;

    i = 0;
    x = i++;
    cout<<"x = i++ -> "<<x<<endl;
    
    i = 0;
    x = ++i;
    cout<<"x = ++i -> "<<x<<endl;

    i = 0;
    i++;
    cout<<"i++ -> "<<i<<endl;

    i = 0;
    ++i;
    cout<<"++i -> "<<i<<endl;
            
    return 0;
    }
