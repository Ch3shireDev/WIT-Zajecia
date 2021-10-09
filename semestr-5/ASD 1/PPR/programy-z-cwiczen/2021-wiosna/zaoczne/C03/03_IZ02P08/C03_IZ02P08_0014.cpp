#include <iostream>
using std::cout;
using std::endl;
using std::cin;
using std::string;
///------------------------------------------------------------------------------------
int ReadInt(string ="x? = ");
int MyAbs(int);
///------------------------------------------------------------------------------------
int ReadInt(string myStr){
    int x;
    cout<<myStr;
    cin>>x;
    return x;
    }
///------------------------------------------------------------------------------------
int MyAbs(int x){
    if(x>0) return x;
    return -x;
    }
///------------------------------------------------------------------------------------
///------------------------------------------------------------------------------------
int main(){    
    int x, y, ax, ay;
    x = ReadInt();
    y = ReadInt("y? = ");
    ax = MyAbs(x);
    ay = MyAbs(y);
    cout<<"|"<<x<<"| = "<<ax<<endl;
    cout<<"|"<<y<<"| = "<<ay<<endl;
    
    return 0;
    }

    
    
    
    
