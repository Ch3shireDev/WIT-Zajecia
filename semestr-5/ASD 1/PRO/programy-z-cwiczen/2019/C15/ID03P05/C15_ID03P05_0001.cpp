#include<iostream>
using std::cout;
using std::cin;
using std::string;
using std::endl;
using std::to_string;
class A{
    public:
        int X(){return x;}
    protected:
        A(int x):x(x){}

    private:
        int x;

    };

class B:public A{
    public:
        B(int ax, int x):A(ax),x(x){}
        int X(){return x;}
        int AX(){return A::X();}
    private:
        int x;
    };
class C:public A{
    public:
        C(int x):A(x),x(2*x){}
    private:
        int x;
    };

void Main01(){
    ///A a1(5);
    B b1(5,6);
    cout<<b1.A::X()<<", "<<b1.X()<<endl;
    C c1(7);
    cout<<c1.X()<<endl;
    }



int main(){
    Main01();
    return 0;
    }
