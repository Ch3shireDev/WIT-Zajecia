#include<iostream>
using namespace std;

int main(){
    int *px;

    px = new int[4];
    *px = 12;

    cout<<"x = "<<*px<<endl;

    return 0;
    }
