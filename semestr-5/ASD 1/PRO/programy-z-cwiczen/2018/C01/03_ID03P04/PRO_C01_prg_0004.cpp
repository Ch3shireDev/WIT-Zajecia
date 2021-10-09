#include <iostream>

using std::cout;
using std::cin;
using std::endl;
using std::string;
///***************************************************************
///***************************************************************
int MyRead();
int MyRead(string);
int MyAdd(int, int);
int MyAdd(int, int, int);
int MyMax(int, int);
int MyMax(int, int, int, int, int, int, int, int);
///***************************************************************
///***************************************************************
int MyRead(){
    int x;
    cout<<"x? = ";
    cin>>x;
    return x;
    }
///***************************************************************
int MyRead(string myStr){
    int x;
    cout<<myStr;
    cin>>x;
    return x;
    }
///***************************************************************
int MyAdd(int x0, int x1){
    return x0 + x1;
    }
///***************************************************************
int MyAdd(int x0, int x1, int x2){
    return x0 + x1 + x2;
    }
///***************************************************************
int MyMax(int x0, int x1){
    if(x0>x1) return x0;
    return x1;
    }
///***************************************************************
int MyMax(int x0, int x1, int x2, int x3,
          int x4, int x5, int x6, int x7){
          return MyMax(
                       MyMax(MyMax(x0,x1),MyMax(x2,x3)),
                       MyMax(MyMax(x4,x5),MyMax(x6,x7))
                       );
          }
///***************************************************************
///***************************************************************
int main(){
    cout<<"Max = "<<MyMax(
                    MyRead("x7? = "),
                    MyRead("x6? = "),
                    MyRead("x5? = "),
                    MyRead("x4? = "),
                    MyRead("x3? = "),
                    MyRead("x2? = "),
                    MyRead("x1? = "),
                    MyRead("x0? = ")
                    )<<endl;

    return 0;
    }




