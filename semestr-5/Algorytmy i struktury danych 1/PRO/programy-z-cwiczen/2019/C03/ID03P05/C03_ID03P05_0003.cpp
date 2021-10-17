///213.135.46.21:7075
/// \\sz240
#include <iostream>
using std::cout;
using std::cin;
using std::string;
using std::endl;
///**********************************
class MyClass{
    public:
        MyClass();
        MyClass(int, int, int);
        ~MyClass();

        int x2;
        int x1;
        int x0;
    };
///**********************************
///**********************************

MyClass::MyClass(){
    cout<<"Konstruktor MyClass()\n";
    }

///**********************************
MyClass::MyClass(int px2, int px1, int px0){
    x2 = px2;
    x1 = px1;
    x0 = px0;
    cout<<"Konstruktor 3-arg MyClass()\n";
    }
///**********************************
MyClass::~MyClass(){
    cout<<"Destruktor MyClass()\n";
    }
///**********************************
///**********************************
int MyRead(string="x ?= ");
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

    MyClass myClass(1,2,3), mC;


    cout<<myClass.x2<<", "<<myClass.x1<<", "<<myClass.x0<<endl;

    return 0;
    }

