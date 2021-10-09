#include<iostream>
using std::cout;
using std::cin;
using std::string;
using std::endl;
using std::to_string;
///********************************************************
class A{
    public:
        A(int x):x(x){}
        int X(){return x;}
        virtual string ToString()=0;
        virtual bool operator<(A&)=0;
        virtual bool operator>(A&)=0;
        virtual bool operator<=(A&)=0;
        virtual bool operator>=(A&)=0;
        virtual bool operator==(A&)=0;
        virtual bool operator!=(A&)=0;
    protected:

    private:
        int x;
    };
///********************************************************
class B:public A{
    public:
        B(int x, int y):A(x),y(y){}
        int Y(){return y;}
        virtual string ToString(){return "x = " + to_string(X())+" y = " + to_string(y);}
        virtual bool operator<(A& a){ return X()+Y() < ((B&)a).X()+ ((B&)a).Y();}
        virtual bool operator>(A& a){ return X()+Y() > ((B&)a).X()+ ((B&)a).Y();}
        virtual bool operator<=(A& a){ return X()+Y() <= ((B&)a).X()+ ((B&)a).Y();}
        virtual bool operator>=(A& a){ return X()+Y() >= ((B&)a).X()+ ((B&)a).Y();}
        virtual bool operator==(A& a){ return X()+Y() == ((B&)a).X()+ ((B&)a).Y();}
        virtual bool operator!=(A& a){ return X()+Y() != ((B&)a).X()+ ((B&)a).Y();}
    protected:

    private:
        int y;
    };
///********************************************************
void Main01(){
//    A a(1);
    B b(5,6);
    cout<<"x = "<<b.X()<<endl;
    cout<<"x = "<<b.X()<<", y = "<<b.Y()<<endl;

    }
///********************************************************
void Main02(){
    //A a(1);
    B b(5,6), b2(1,30);

    cout<<b.ToString()<<endl;
    cout<<b2.ToString()<<endl;
    if(b<b2)cout<<"b<b2\n"; else cout<<"b2<=b\n";
    if(b>b2)cout<<"b>b2\n"; else cout<<"b2>=b\n";
    if(b<=b2)cout<<"b<=b2\n"; else cout<<"b2<b\n";
    if(b>=b2)cout<<"b>=b2\n"; else cout<<"b2>b\n";
    if(b==b2)cout<<"b==b2\n"; else cout<<"b2!=b\n";
    if(b!=b2)cout<<"b!=b2\n"; else cout<<"b2==b\n";
    }
///********************************************************
int main(){
    Main02();
    return 0;
    }
