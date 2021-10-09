#include <iostream>
using std::cout;
using std::cin;
using std::endl;
using std::string;
///********************************************************
///********************************************************
class MyA{
    public:
        MyA(int=0, int=0, int=0);
        MyA MyAIni(int, int, int);
        MyA MyAPrint();
        int GetX2();
        int GetX1();
        int GetX0();
        int GetCrC();
        int SetX2(int);
        int SetX1(int);
        int SetX0(int);

    private:
        int CrC();
        int SetCrC();

        int x2;
        int x1;
        int x0;

        int cRc;
    };
///********************************************************
///********************************************************
int MyRead();
int MyRead(string);
///********************************************************
///********************************************************
MyA::MyA(int x2, int x1, int x0){
    ///this->x0 = x0;this->x1 = x1;this->x2 = x2;
    MyAIni(x2,x1,x0);
    SetCrC();
    }
///********************************************************
MyA MyA::MyAIni(int x2, int x1, int x0){
    this->x2 = x2;
    this->x1 = x1;
    this->x0 = x0;
    SetCrC();
    return *this;
    }
///********************************************************
MyA MyA::MyAPrint(){
    cout<<"x2 = "<<x2<<", x1 = "<<x1;
    cout<<", x0 = "<<x0<<", cRc = "<<cRc<<endl;
    return *this;
    }
///********************************************************
int MyA::CrC(){
    return 2*2*(x2%2)+2*(x1%2)+1*(x0%2);
    }
///********************************************************
int MyA::SetCrC(){
    cRc= CrC();
    return cRc;
    }
int MyA::GetX2(){return x2;}
///********************************************************
int MyA::GetX1(){return x1;}
///********************************************************
int MyA::GetX0(){return x0;}
///********************************************************
int MyA::GetCrC(){return cRc;}
///********************************************************
int MyA::SetX2(int x2){
    this->x2=x2;
    SetCrC();
    return x2;
    }
///********************************************************
int MyA::SetX1(int x1){
    this->x1=x1;
    SetCrC();
    return x1;
    }
///********************************************************
int MyA::SetX0(int x0){
    this->x0=x0;
    SetCrC();
    return x0;
    }
///********************************************************
///********************************************************
int MyRead(){
    return MyRead("x? = ");
    }
///********************************************************
int MyRead(string myStr){
    int x;
    cout<<myStr;
    cin>>x;
    return x;
    }
///********************************************************
///********************************************************
int main(){
    MyA myA(1,2,3);
    myA.MyAPrint();
    myA.SetX2(124);
    myA.MyAPrint();
    return 0;
    }

