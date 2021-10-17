#include <iostream>
using std::cout;
using std::endl;
using std::cin;


int main(){
    int i, x;
    
    i = 0;
    x =  ++i;
    cout<<"x = ++i -> "<<x<<"\ti = "<<i<<endl;
    i = 0;
    x =  i++;
    cout<<"x = i++ -> "<<x<<"\ti = "<<i<<endl;
    i = 0;
    ++i;
    cout<<"++i = "<<i<<endl;
    i = 0;
    i++;
    cout<<"i++ = "<<i<<endl;

    return 0;
    }
