#include<iostream>
using std::cout;
using std::endl;

int main(){
    int x = 7;;
    int y = 12;

    cout<<"x = "<<x<<endl;
    
    x = x + 1;
    cout<<"x = "<<x<<endl;
    x += 1;    
    cout<<"x = "<<x<<endl;
    
    ++x;
    cout<<"x = "<<x<<endl;
    x++;
    cout<<"x = "<<x<<endl;
    
    x += 5;
    cout<<"x = "<<x<<endl;
    
    x += y;
    cout<<"x = "<<x<<endl;
    
    return 0;
    }
