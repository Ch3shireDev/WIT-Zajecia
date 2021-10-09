///213.135.46.21:7070
///\\sz240
#include <iostream>
#include <string>
using std::cout;
using std::cin;
using std::string;
using std::endl;
using std::to_string;

///**********************************
///**********************************
class MyClass{
    public:
        MyClass();
        MyClass(int, int, int);
        ~MyClass();
        void Ini(int, int, int);
        void Print(string="");
        string ToString();
        int x0;
        int x1;
        int x2;
    };
///**********************************
///**********************************
MyClass::MyClass(){
    cout<<"Konstruktor MyClass\n";
    }
///**********************************
MyClass::MyClass(int x0, int x1, int x2){
    this->x0 = x0;
    this->x1 = x1;
    this->x2 = x2;
    cout<<"Konstruktor 3-arg MyClass\n";
    }
///**********************************
MyClass::~MyClass(){
    cout<<"Destruktor MyClass\n";
    }
///**********************************
void MyClass::Ini(int x0, int x1, int x2){
    this->x0 = x0;
    this->x1 = x1;
    this->x2 = x2;
    }
///**********************************
void MyClass::Print(string myStr){
    cout<<myStr;
    cout<<x0<<", "<<x1<<", "<<x2;
    }
///**********************************
string MyClass::ToString(){
    return to_string(x0) + ", "
         + to_string(x1) + ", "
         + to_string(x2);
    }
///**********************************
///**********************************
int MyRead(string="x? = ");
void MyClassIni(MyClass&, int, int, int);
int main01();
int main02();
///**********************************
int MyRead(string myStr){
    int x;
    cout<<myStr;
    cin>>x;
    return x;
    }
///**********************************
void MyClassIni(MyClass& myClass,int x0, int x1, int x2){
    myClass.x0 = x0;
    myClass.x1 = x1;
    myClass.x2 = x2;
    }
///**********************************
///**********************************
int main01(){
    MyClass myClass, mC1;
    MyClassIni(myClass, 2,3,5);
    myClass.Print("myClass(");
    cout<<")\n";
    myClass.Ini(12,13,15);
    myClass.Print("myClass(");
    cout<<")\n";
    mC1.Ini(91,92,93);
    mC1.Print("mC1(");
    cout<<")\n";
    return 0;
    }
///**********************************
int main02(){
    {
    MyClass myClass(1,2,3);
    cout<<myClass.ToString()<<endl;
    }
    cout<<"Koniec main02\n";
    return 0;
    }
///**********************************
///**********************************

int main(){
    main02();

    return 0;
    }

