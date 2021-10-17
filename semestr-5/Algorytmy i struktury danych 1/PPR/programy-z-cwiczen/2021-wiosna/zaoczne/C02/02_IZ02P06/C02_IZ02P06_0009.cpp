#include <iostream>
using std::cout;
using std::endl;
using std::cin;


int main(){
    int x, sum = 0;
        
    cout<<"x? = ";
    cin>>x;            
    
    sum = x*(x+1)/2;
            
    cout<<"suma od 0 do "<<x<<" = "<<sum<<endl;
    return 0;
    }
/**
x? = 12
x? = 3
x? = -5
x? = 2
x? = 0

Suma 4 liczb wynosi 12
*/

/**
x? = 10
x? = 0
Suma 1 liczb wynosi 10
*/
/**
x? = 0
Brak danych
*/
///12, 12, 12, 10, 10, 10, 10

