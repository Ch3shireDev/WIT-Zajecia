///213.135.46.21:7070
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
        ~MyClass();
        void Ini(int, int, int);
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
MyClass::~MyClass(){
    cout<<"Destruktor MyClass()\n";
    }
///**********************************
void MyClass::Ini(int px2, int px1, int px0){
    x2 = px2;
    x1 = px1;
    x0 = px0;
    }
///**********************************
///**********************************
int MyRead(string="x ?= ");
void MyClassIni(MyClass&, int, int, int);
///**********************************
int MyRead(string myStr){
    int x;
    cout<<myStr;
    cin>>x;
    return x;
    }
///**********************************
void MyClassIni(MyClass& myClass, int x2, int x1, int x0){
    myClass.x2 = x2;
    myClass.x1 = x1;
    myClass.x0 = x0;
    }
///**********************************
///**********************************
int main(){
    MyClass myClass;
    MyClassIni(myClass,1,2,3);
    cout<<"myClass("<<myClass.x0<<", "<<myClass.x1<<", "<<myClass.x2<<")\n";
    myClass.Ini(11,12,13);
    cout<<"myClass("<<myClass.x0<<", "<<myClass.x1<<", "<<myClass.x2<<")\n";
    return 0;
    }

