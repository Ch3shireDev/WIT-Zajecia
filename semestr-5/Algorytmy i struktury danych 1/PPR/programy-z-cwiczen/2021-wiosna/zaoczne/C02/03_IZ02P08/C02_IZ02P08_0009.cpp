#include <iostream>
using std::cout;
using std::endl;
using std::cin;


int main(){
    int x, sum = 0;

    cout<<"x? = ";
    cin>>x;
    
    sum = x * (x+1)/2;
    
    cout<<"Suma od 0 do "<<x<<" = "<<sum<<endl;
    
    return 0;
    }
/**
x? = 12
Suma od 0 do 12 = 78
*/

/**
x? = 10
Suma od 0 do 10 = 55
*/

/**
x? = 4
Suma od 0 do 4 = 10
*/
///10, 10, 10, 10

