///213.135.46.21:7070
#include <iostream>
using std::cout;
using std::cin;
using std::string;
using std::endl;
using std::to_string;
///**********************************
class MyClass{
    public:
        MyClass();
        MyClass(int, int, int);
        int x2;
        int x1;
        int x0;
    };
///**********************************
///**********************************
MyClass::MyClass(){
    x2 = x1 = x0 = 0;
    }
///**********************************
MyClass::MyClass(int x2, int x1, int x0){
    this->x2 = x2;
    this->x1 = x1;
    this->x0 = x0;
    }
///**********************************
///**********************************
int MyRead(string="x ?= ");
///**********************************
///**********************************
int MyRead(string myStr){
    int x;
    cout<<myStr;
    cin>>x;
    return x;
    }
///**********************************
///**********************************
int main(){
    MyClass myClass(1,11,123);

    cout<<"myClass("<<myClass.x0<<", "<<myClass.x1<<", "<<myClass.x2<<")\n";

    return 0;
    }

