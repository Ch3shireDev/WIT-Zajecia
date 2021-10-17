#include <iostream>
using std::cout;
using std::cin;
using std::endl;
using std::string;
///**************************************************************
///**************************************************************
class MyA{
    public:
        int x0;
        int x1;
        int x2;
    };
///**************************************************************
///**************************************************************
int MyRead(string);
MyA MyAIni(MyA*);
MyA MyAIni(MyA&);
MyA MyAPrint(MyA);
///**************************************************************
///**************************************************************
int MyRead(string myStr){
    int x;
    cout<<myStr;
    cin>>x;
    return x;
    }
///**************************************************************
MyA MyAIni(MyA* myA){
    myA->x0 = MyRead("x0? = ");
    myA->x1 = MyRead("x1? = ");
    myA->x2 = MyRead("x2? = ");
    return *myA;
    }
///**************************************************************
MyA MyAIni(MyA& myA){
    myA.x0 = MyRead("x0? = ");
    myA.x1 = MyRead("x1? = ");
    myA.x2 = MyRead("x2? = ");
    return myA;
    }
///**************************************************************
MyA MyAPrint(MyA myA){
    cout<<"x0 = "<<myA.x0<<endl;
    cout<<"x1 = "<<myA.x1<<endl;
    cout<<"x2 = "<<myA.x2<<endl;
    return myA;
    }
///**************************************************************
///**************************************************************
int main(){
    MyA myA;
    MyAPrint(MyAIni(&myA));
    MyAPrint(MyAIni(myA));



    return 0;
    }
