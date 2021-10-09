#include <iostream>

using std::cout;
using std::endl;
using std::cin;

int main(){
    int x, y;
    cout<<"x? = ";
    cin>>x;
    y=x;
    if(y<0){
        y=-y;
        }
    
    cout<<"|"<<x<<"| = "<<y<<endl;    
    

    cout<<"T H E    E N D\n";
    return 0;
    }
/** 
x? = 5
|5| = 5
*/

/** 
x? = -9
|-9| = 9
*/

///15, 12, 12, 10, 10, 10, 10, 9, 9, 9, 9, 9, 9
