#include<iostream>

using std::cout;
using std::cin;
using std::string;
using std::endl;
using std::to_string;
using std::ostream;

template <typename T>
void Fun0001(T z){
    cout<<"z = "<<z<<endl;
    }

template <typename T>
T MyMax(T a, T b){
    if(a>b) return a;
    return b;
    }

template<>
void Fun0001(char z){
    cout<<"Znaczek : "<<z<<endl;
    }


int main(){
    char z ='A';
    int x =7, y=8;
    double d1 =8.9, d2 =7.5;
    Fun0001(z);
    Fun0001<int>(z);
    Fun0001(x);

    cout<<MyMax(x,y)<<endl;
    cout<<MyMax(d1,d2)<<endl;
    cout<<MyMax((double)x,d2)<<endl;

    return 0;
    }
