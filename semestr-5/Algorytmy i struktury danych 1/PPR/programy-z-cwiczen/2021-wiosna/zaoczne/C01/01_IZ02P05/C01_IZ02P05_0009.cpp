#include <iostream>
using std::cout;
using std::endl;
using std::cin;

int main(){
    int x;

    cout<<"x? = ";
    cin>>x;
    cout<<"x = "<<x<<endl;
    
    x = x + 1;
    x += 1;
    
    x++;
    ++x;
    
    x = x + 7;
    x += 7;
        
    return 0;
    }
