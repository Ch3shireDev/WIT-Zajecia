#include<iostream>

using std::cout;
using std::cin;
using std::string;
using std::endl;
using std::to_string;
using std::ostream;


template <typename T1, typename T2>
T1 MyMax(T1 a, T2 b){
    if(a>b) return a;
    return b;
    }

double MyMax(int a, double b){
    if(a>b) return a;
    return b;
    }


int main(){
    char z ='A';
    int x =7, y=8;
    double d1 =8.9, d2 =7.5;

    cout<<MyMax(x,y)<<endl;
    cout<<MyMax(d1,d2)<<endl;
    cout<<MyMax(x,d2)<<endl;

    return 0;
    }
