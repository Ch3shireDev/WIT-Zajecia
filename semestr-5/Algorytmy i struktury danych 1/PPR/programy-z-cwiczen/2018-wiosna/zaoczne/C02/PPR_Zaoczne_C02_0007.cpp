#include<iostream>
using namespace std;
/** 2, 3, 4

x ?= 5
* * * * *
- * * * *
- - * * *
- - - * *
- - - - *

0
1 -
2 - -
3 - - -
4 - - - -


*/

int main(){
    int i, j;
    int x;

    cout<<"x ?=";
    cin>>x;

    for(j=0;j<x;++j){
        for(i=0;i<j;++i){
            cout<<"- ";
            }
        cout<<endl;
        }


    for(j=0;j<x;++j){
        for(i=0;i<j;++i){
            cout<<"- ";
            }
        for(i=0;i<x - j;++i){
            cout<<"* ";
            }
        cout<<endl;
        }

    for(j=0;j<x;++j){
        for(i=0;i<j;++i){
            cout<<"- ";
            }
        for(;i<x;++i){
            cout<<"* ";
            }
        cout<<endl;
        }


    return 0;
    }
