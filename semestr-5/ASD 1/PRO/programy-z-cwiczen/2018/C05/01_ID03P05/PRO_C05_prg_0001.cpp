#include <iostream>
using std::cout;
using std::cin;
using std::endl;
using std::string;
using std::ostream;
using std::istream;
///********************************************************
///********************************************************
class MyA{
    public:
        MyA(int=0, int=0, int=0);
        MyA(const MyA&);
        MyA MyAIni(int, int, int);
        MyA MyAPrint();

        MyA operator+(const MyA&)const;
        MyA operator+(int)const;
        MyA operator++();
        MyA operator++(int);
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
    friend void TestFriend(MyA&);
    };
///********************************************************
///********************************************************
MyA operator+(int, const MyA&);
ostream& operator<<(ostream&, MyA&);
istream& operator>>(istream&, MyA&);
/*
cout<<x<<y;
operator<<(operator<<(cout,y),x);
*/
///********************************************************
int MyRead();
int MyRead(string);
int MyRead(string, istream&);
///********************************************************
///********************************************************
MyA::MyA(int x2, int x1, int x0){
    MyAIni(x2,x1,x0);
    }
///********************************************************
MyA::MyA(const MyA& myA){
    this->x2 = myA.x2;
    this->x1 = myA.x1;
    this->x0 = myA.x0;
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
MyA MyA::operator+(const MyA& myA)const{
    return MyA(this->x2+myA.x2, this->x1+myA.x1, this->x0+myA.x0);
    }
///********************************************************
MyA MyA::operator+(int x)const{
    return MyA(this->x2+x, this->x1+x, this->x0+x);
    }
///********************************************************
MyA MyA::operator++(){
    ++x2;
    ++x1;
    ++x0;
    SetCrC();
    return *this;
    }
///********************************************************
MyA MyA::operator++(int){
    MyA myA(*this);
    ++x2;
    ++x1;
    ++x0;
    SetCrC();
    return myA;
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
///********************************************************
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
MyA operator+(int x, const MyA& myA){
    return myA + x;
    }
///********************************************************
ostream& operator<<(ostream& s, MyA& myA){
    s<<"( "<<myA.GetX2()<<", "<<myA.GetX1()<<", ";
    s<<myA.GetX0()<<") -> "<<myA.GetCrC()<<endl;
    return s;
    }
///********************************************************
istream& operator>>(istream& s, MyA& myA){
    myA.SetX2(MyRead("x2? = ", s));
    myA.SetX1(MyRead("x1? = ", s));
    myA.SetX0(MyRead("x0? = ", s));
    return s;
    }
///********************************************************
void TestFriend(MyA& myA){
    cout<<"x2 = "<<myA.x2<<", x1 = "<<myA.x1;
    cout<<", x0 = "<<myA.x0<<", cRc = "<<myA.cRc<<endl;
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
int MyRead(string myStr, istream& s){
    int x;
    cout<<myStr;
    s>>x;
    return x;
    }
///********************************************************
///********************************************************
int main(){
    MyA myA(1,2,3);
    MyA myB(10,20,30);
/*    MyA myC;
    MyA myD(myA);
    myC = myA + myB;
    myC.MyAPrint();

    myC = myC + 5;
    myC.MyAPrint();
    myC = 5 + myC;
    myC.MyAPrint();
    ++myC;
    myC.MyAPrint();
    myD.MyAPrint();
    myC = myD++;
    myC.MyAPrint();
    myD.MyAPrint();
*/
//    TestFriend(myA);
    cin>>myA;
    cout<<myA<<endl;
    return 0;
    }

