#include <iostream>

using std::cout;
using std::cin;
using std::string;
using std::endl;
using std::to_string;
using std::ostream;

class MyA{};
ostream& operator<<(ostream& s, MyA myA){s<<"Obiekt MyA"<<endl; return s;}

template <typename T>
void MyFun0001(T t){
    cout<<"value ="<<t<<endl;
    }

template<>
void MyFun0001(MyA t){
    cout<<"Pusty obiekt : "<<t<<endl;
    }

template<>
void MyFun0001(char z){
    cout<<"Znaki i znaczki ... "<<z<<endl;
    }

int main(){
    int x =12;
    MyA mA;
    char c='z';
    MyFun0001(x);
    cout<<mA<<endl;
    MyFun0001(mA);
    MyFun0001(c);
    MyFun0001<int>(c);
    return 0;
    }
