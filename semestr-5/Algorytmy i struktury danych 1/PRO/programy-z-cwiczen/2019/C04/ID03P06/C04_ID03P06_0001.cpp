///213.135.46.21:7070
///\\sz240\temp\PRO
#include <iostream>
using std::cout;
using std::cin;
using std::string;
using std::endl;
using std::to_string;
///**********************************
class MyClass{
    public:
        MyClass(int, int, int);
        string ToString();
        int CRC();
        int x2;
        int x1;
        int x0;
    private:
        int CrC();
        int cRc;
    };
///**********************************
class MySchool{
    public:
        MySchool(MyClass,MyClass,MyClass);
        MyClass x2;
        MyClass x1;
        MyClass x0;
    private:
        int cRc;
    };
///**********************************
///**********************************
MyClass::MyClass(int x2, int x1, int x0){
    this->x2 = x2;
    this->x1 = x1;
    this->x0 = x0;
    }
///**********************************
string MyClass::ToString(){
    return to_string(x2) + ", " +
           to_string(x1) + ", " +
           to_string(x0) + " -> "
           + to_string(CRC());
    }
///**********************************
int MyClass::CRC(){
    cRc = CrC();
    return cRc;
    }
///**********************************
int MyClass::CrC(){
    return 4*(x2%2) + 2*(x1%2) +x0%2;
    }
///**********************************
///**********************************
MySchool::MySchool(MyClass x2,MyClass x1,MyClass x0)
        :x2(x2), x1(x1), x0(x0)
    {cout<<"MySchool()"<<endl;}
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
int main01(){
    MyClass myClass(1,11,123);

    cout<<myClass.ToString()<<endl;

    cout<<myClass.CRC()<<endl;
    myClass.x2 = 2;
    cout<<myClass.ToString()<<endl;
    cout<<myClass.CRC()<<endl;
    return 0;
    }
///**********************************
int main02(){
    MySchool mySchool;
    return 0;
    }
///**********************************
///**********************************
int main(){
    main02();
    return 0;
    }

