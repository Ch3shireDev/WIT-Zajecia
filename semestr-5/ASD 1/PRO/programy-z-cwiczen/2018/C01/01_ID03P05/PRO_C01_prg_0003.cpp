#include <iostream>
using std::cout;
using std::cin;
using std::endl;
using std::string;
///**************************************************************
///**************************************************************
int MyRead();
int MyRead(string);
int MyAdd(int, int);
int MyAdd(int, int, int);
/*
Error:
char MyAdd(int, int, int);
*/
///**************************************************************
///**************************************************************
int MyRead(){
    int x;
    cout<<"x? = ";
    cin>>x;
    return x;
    }
///**************************************************************
int MyRead(string myStr){
    int x;
    cout<<myStr;
    cin>>x;
    return x;
    }
///**************************************************************
int MyAdd(int x0, int x1){
    return x0 + x1;
    }
///**************************************************************
int MyAdd(int x0, int x1, int x2){
    return x0 + x1 + x2;
    }
///**************************************************************
///**************************************************************
int main(){
    int x;
    x = MyRead("podaj haslo: ");
    cout<<"x = "<<x<<endl;





    return 0;
    }
