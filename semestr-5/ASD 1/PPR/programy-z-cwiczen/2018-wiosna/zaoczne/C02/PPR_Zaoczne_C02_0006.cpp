#include<iostream>
using namespace std;
/** 2, 3, 4

x ?= 5
* * * * *  x - 0       j = 0    x - 0 = x - j
* * * *    x - 1       j = 1    x - 1 = x - j
* * *      x - 2       j = 2    x - 2 = x - j
* *        x - 3       j = 3    x - 3 = x - j
*          x - 4       j = 4    x - 4 = x - j

*/

int main(){
    int i, j;
    int x;

    cout<<"x ?=";
    cin>>x;

    for(j=0;j<x;++j){
        for(i=0;i<x - j;++i){
            cout<<"* ";
            }
        cout<<endl;
        }



    return 0;
    }
