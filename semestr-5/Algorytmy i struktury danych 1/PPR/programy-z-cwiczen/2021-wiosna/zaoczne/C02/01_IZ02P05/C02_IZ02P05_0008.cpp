#include <iostream>
using std::cout;
using std::endl;
using std::cin;


int main(){
    int x;
    cout<<"x? = ";
    cin>>x;
    
    int sum = x*(x+1)/2;
    
    cout<<"suma od 0 do "<<x<<" = "<<sum<<endl;
 
    return 0;
    }
/**
x? = 12
suma od 0 do 12 = 78
*/

