#include <iostream>
using std::cout;
using std::endl;
using std::cin;


int main(){
    int x, cnt = 0, sum = 0;
        
    cout<<"x? = ";
    cin>>x;            

    while(0!=x){
        sum+=x;
        ++cnt;
        cout<<"x? = ";
        cin>>x;            
        }
    if(0==cnt)   cout<<"Brak danych\n";
    else cout<<"Suma "<<cnt<<" liczb wynosi "<<sum<<endl;
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

