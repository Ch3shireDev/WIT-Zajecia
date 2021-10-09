#include <iostream>
using std::cout;
using std::endl;
using std::cin;


int main(){
    int i, x;
    
    cout<<"x? = ";
    cin>>x;
    
    i = 0;
    while (i<x) {
        cout<<"i = "<<i<<endl;
        ++i;
        cout<<"i = "<<i<<endl;
        }
    return 0;
    }
