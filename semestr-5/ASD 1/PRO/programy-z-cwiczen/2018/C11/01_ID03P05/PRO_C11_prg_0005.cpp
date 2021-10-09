#include<iostream>
#include<cstdlib>
#include<ctime>
using std::cout;
using std::cin;
using std::endl;
using std::string;
using std::ostream;
using std::istream;
///********************************************************************************************
///********************************************************************************************
class A{
    public:
        A(int, int);
        int GetX1();
        int GetX2();
        void PrintA(string="");
    private:
        int x1;
        int x2;
    };
///********************************************************************************************
class B:public A{
    public:
        B(int, int);
        int GetX1();
        void PrintB(string="");
    private:
        int x1;
    };
///********************************************************************************************
class C:public A{
    public:
        C(int, int);
        int GetX1();
        int GetX2();
        void PrintC(string="");
    private:
        int x1;
        int x2;
    };
///********************************************************************************************
///********************************************************************************************
A::A(int x1, int x2):x1(x1), x2(x2){}
///********************************************************************************************
int A::GetX1(){return x1;}
///********************************************************************************************
int A::GetX2(){return x2;}
///********************************************************************************************
void A::PrintA(string  myStr){cout<<"x1 = "<<x1<<", x2 = "<<x2<<myStr;}
///********************************************************************************************
///********************************************************************************************
B::B(int x1, int x2):A(x1,x2), x1(x1+x2){}
///********************************************************************************************
int B::GetX1(){return x1;}
///********************************************************************************************
void B::PrintB(string  myStr){
    PrintA();
    cout<<", x1 = "<<x1<<myStr;
    }
///********************************************************************************************
///********************************************************************************************
C::C(int x1, int x2):A(x1,x2){
    if(x1>x2){
        this->x1=x1;
        this->x2=x2;
        }
    else{
        this->x1=x2;
        this->x2=x1;
        }
    }
///********************************************************************************************
int C::GetX1(){return x1;}
///********************************************************************************************
int C::GetX2(){return x2;}
///********************************************************************************************
void C::PrintC(string  myStr){
    PrintA();
    cout<<", x1 = "<<x1<<", x2 = "<<x2<<myStr;
    }
///********************************************************************************************
///********************************************************************************************
int main(){
    C myA(1,2);

    myA.PrintC();
///7, 8, 9, 10
    return 0;
    }
