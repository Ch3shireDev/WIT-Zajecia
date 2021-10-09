#include <iostream>
using std::cout;
using std::endl;
using std::cin;


int main(){
    int x, cnt = 0, sum=0;
    cout<<"x? = ";
    cin>>x;
    
    while(0!=x){
        sum+=x;
        ++cnt;
        cout<<"x? = ";
        cin>>x;        
        }
    if(cnt>0)    
        cout<<"suma "<<cnt<<" liczb = "<<sum<<endl;
    else
        cout<<"Brak danych\n";
 
    return 0;
    }
/**
x? = 12
x? = 1
x? = -5
x? = 4
x? = 0

suma 4 liczb = 12
*/

/**
x? = 1
x? = 3
x? = 0

suma 2 liczb = 0
*/
/**
x? = 0
Brak danych
*/
///10, 10

