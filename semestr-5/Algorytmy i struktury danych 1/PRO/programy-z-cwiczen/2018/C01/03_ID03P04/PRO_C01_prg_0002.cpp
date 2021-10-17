#include <iostream>

using std::cout;
using std::cin;
using std::endl;
using std::string;



int main(){
    int x;
    cout<<"x? = ";
    cin>>x;

    for(int i=0; i<x; ++i){
        cout<<"i = ";
        cout.width(2);
        cout<<i;
        cout<<endl;
        }

    return 0;
    }
