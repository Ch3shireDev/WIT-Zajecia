#include<iostream>
using namespace std;

int main(){
    int x;
    int *px;

    px = &x;
    *px= 12;
    cout<<"x = "<<*px<<endl;


    return 0;
    }
