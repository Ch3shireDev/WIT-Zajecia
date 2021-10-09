#include<iostream>
using namespace std;
/** 2, 3, 4

x ?= 5
* * * * *
* * * * *
* * * * *
* * * * *
* * * * *

*/

int main(){
    int i, j;
    int x;

    cout<<"x ?=";
    cin>>x;

    for(j=0;j<x;++j){
        for(i=0;i<x;++i){
            cout<<"* ";
            }
        cout<<endl;
        }



    return 0;
    }
