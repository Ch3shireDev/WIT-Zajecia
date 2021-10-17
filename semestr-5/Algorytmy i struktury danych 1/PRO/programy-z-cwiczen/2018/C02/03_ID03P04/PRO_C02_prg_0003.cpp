#include <iostream>
using std::cout;
using std::cin;
using std::endl;
using std::string;
///**************************************************************
///**************************************************************
int MyRead(string);
///**************************************************************
///**************************************************************
class MyA{
    public:
        MyA& MyAIni(){
            x0=MyRead("x0? = ");
            x1=MyRead("x1? = ");
            x2=MyRead("x2? = ");
            return *this;
            }
        MyA& MyAIni(int x0, int x1, int x2){
            this -> x0 = x0;
            this -> x1 = x1;
            this -> x2 = x2;
            return *this;
            }
        MyA& MyAPrint(){
            cout<<"x0 = "<<x0<<endl;
            cout<<"x1 = "<<x1<<endl;
            cout<<"x2 = "<<x2<<endl;
            return *this;
            }

        int x0;
        int x1;
        int x2;

    };
///**************************************************************
///**************************************************************
MyA& MyAIni(MyA*);
MyA& MyAIni(MyA&);
MyA& MyAPrint(MyA&);
///**************************************************************
///**************************************************************
int MyRead(string myStr){
    int x;
    cout<<myStr;
    cin>>x;
    return x;
    }
///**************************************************************
MyA& MyAIni(MyA* myA){
    myA->x0=MyRead("x0? = ");
    myA->x1=MyRead("x1? = ");
    myA->x2=MyRead("x2? = ");
    return *myA;
    }
///**************************************************************
MyA& MyAIni(MyA& myA){
    myA.x0=MyRead("x0? = ");
    myA.x1=MyRead("x1? = ");
    myA.x2=MyRead("x2? = ");
    return myA;
    }
///**************************************************************
MyA& MyAPrint(MyA& myA){
    cout<<"x0 = "<<myA.x0<<endl;
    cout<<"x1 = "<<myA.x1<<endl;
    cout<<"x2 = "<<myA.x2<<endl;
    return myA;
    }
///**************************************************************
///**************************************************************
int main(){
    MyA myA;
    myA.MyAIni().MyAPrint().MyAIni().MyAPrint().MyAPrint().MyAPrint();

    return 0;
    }
