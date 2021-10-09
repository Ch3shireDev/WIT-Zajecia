///213.135.46.21:7070
#include <iostream>
using std::cout;
using std::cin;
using std::endl;
using std::string;

int MySwap(int*, int*);
int MySwap(int&, int&);

int MySwap(int * a, int *b){
    int tmP;

    tmP = *a;
    *a = *b;
    *b = tmP;

    return 0;
    }

int MySwap(int& a, int& b){
    int tmP;

    tmP = a;
    a = b;
    b = tmP;

    return 0;
    }



int main(){
    int x = 7, y =9;
    cout<<"x = "<<x<<", y = "<<y<<endl;
    MySwap(&x, &y);
    cout<<"x = "<<x<<", y = "<<y<<endl;
    MySwap(x, y);
    cout<<"x = "<<x<<", y = "<<y<<endl;

    return 0;
    }
