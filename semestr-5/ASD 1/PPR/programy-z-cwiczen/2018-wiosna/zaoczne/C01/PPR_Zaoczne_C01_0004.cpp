#include <iostream>
using namespace std;

int main(){
    int x;
    int * px;

    px = &x;
    *px = 9;

    cout<<" x = "<<x<<endl;


    return 0;
    }
