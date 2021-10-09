#include <iostream>

using std::cout;
using std::cin;
using std::string;
using std::endl;
using std::to_string;
using std::ostream;

class MyA{
    public:
        MyA(int a1=4):a1(a1){}
        int operator>(MyA myA){
            if(a1>myA.a1) return 1;
            return 0;
            }
    private:
        int a1;
    friend ostream& operator<<(ostream& s, MyA myA);
    };
ostream& operator<<(ostream& s, MyA myA){s<<myA.a1<<endl; return s;}

template <typename T>
T MyMax(T x1, T x2){
    cout<<"MyMax<typename T>"<<endl;
    if(x1>x2)return x1;
    return x2;
    }
template <typename T1, typename T2>
T1 MyMax(T1 x1, T2 x2){
    cout<<"MyMax<typename T1, typename T2>"<<endl;
    if(x1>x2)return x1;
    return (T1)x2;
    }
double MyMax(int x1, double x2){
    if(x1>x2)return (double)x1;
    return x2;
    }
int main(){
    int x =12, y=11;
    double z1 =11, z2=13.5;
    MyA a1, a2(6);
    cout<<MyMax(x,y)<<endl;
    cout<<MyMax(z1,z2)<<endl;
    cout<<MyMax(y,z2)<<endl;
    cout<<MyMax<int,double>(y,z2)<<endl;
    cout<<MyMax(z2,y)<<endl;
    cout<<MyMax(a1,a2)<<endl;

    return 0;
    }
