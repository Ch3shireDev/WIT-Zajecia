#include<iostream>

using std::cout;
using std::cin;
using std::string;
using std::endl;
using std::to_string;
using std::ostream;

template <typename T>
class MyA{
    public:
        MyA(T a1=0):a1(a1){}
        int operator>(MyA myA){
            if(a1>myA.a1) return 1;
            return 0;
            }
    private:
        int a1;
    friend ostream& operator<<(ostream& s, MyA myA){
        s<<"MyA->a1="<<myA.a1<<endl;
        return s;
        }
    };
template <typename T1, typename T2>
T1 MyMax(T1 a, T2 b){
    if(a>b) return a;
    return b;
    }

double MyMax(int a, double b){
    if(a>b) return a;
    return b;
    }

template <typename T>
void Fun0001(T z){
    cout<<"z = "<<z<<endl;
    }

int main(){
    MyA<int> myA;
    MyA<int>myA2(12);
    Fun0001(myA);
    cout<<MyMax(myA, myA2)<<endl;
    return 0;
    }
