#include<iostream>
using std::cout;
using std::cin;
using std::string;
using std::endl;
using std::to_string;
class A{
    public:
        A(int x):x(x){}
        int& X(){return x;}
        virtual string ToString()=0;
        virtual bool operator<(A&)=0;
        virtual bool operator>(A&)=0;
        virtual bool operator<=(A&)=0;
        virtual bool operator>=(A&)=0;
        virtual bool operator==(A&)=0;
        virtual bool operator!=(A&)=0;

        virtual void operator+(A&)=0;

    private:
        int x;
    };
///********************************************************
class B:public A{
    public:
        B(int x, int y):A(x),y(y){}
        int X(){return A::X();}
        int Y(){return y;}
        string ToString(){return to_string(X())+", "+to_string(y);}
        bool operator<(A& a){return X()+y < ((B&)a).X()+((B&)a).y;}
        bool operator>(A& a){return X()+y > ((B&)a).X()+((B&)a).y;}
        bool operator<=(A& a){return X()+y <= ((B&)a).X()+((B&)a).y;}
        bool operator>=(A& a){return X()+y >= ((B&)a).X()+((B&)a).y;}
        bool operator==(A& a){return X()+y == ((B&)a).X()+((B&)a).y;}
        bool operator!=(A& a){return X()+y != ((B&)a).X()+((B&)a).y;}

        void operator+(A& a){ A::X()+=((B&)a).X();y+=((B&)a).y;}


        ///bool operator<(A& a){return X()+y<(dynamic_cast<B&>(a)).X()+(dynamic_cast<B&>(a)).y;}
    private:
        int y;
    };
///********************************************************
void Main01(){
    B b1(5,6), b2(3,19);
    cout<<b1.ToString()<<endl;
    if(b1<b2) cout<<"("<<b1.ToString()<<") < ("<<b2.ToString()<<")\n";
    else cout<<"("<<b1.ToString()<<") >= ("<<b2.ToString()<<")\n";
    b1+b2;
    cout<<b1.ToString()<<endl;

    }
///********************************************************
int main(){
    Main01();
    return 0;
    }
