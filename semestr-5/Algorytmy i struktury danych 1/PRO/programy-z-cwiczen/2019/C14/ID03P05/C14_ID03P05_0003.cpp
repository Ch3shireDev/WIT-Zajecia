#include <iostream>

using std::cout;
using std::cin;
using std::string;
using std::endl;
using std::to_string;
using std::ostream;

template <typename T>
class MyA{
    public:
        MyA(T a1, T a2):a1(a1), a2(a2){}
        void Print();
    private:
        T a1, a2;
    friend ostream& operator<<(ostream& s, MyA<T> myA){
        s<<"a1 = "<<myA.a1<<", a2 = "<<myA.a2<<endl;
        return s;
        }
    };
template <typename ZZ>
void MyA<ZZ>::Print(){cout<<"a1 = "<<a1<<", a2 = "<<a2<<endl;}

int main(){
    MyA<int> myA(1,2);
    myA.Print();
    cout<<myA;
    return 0;
    }
