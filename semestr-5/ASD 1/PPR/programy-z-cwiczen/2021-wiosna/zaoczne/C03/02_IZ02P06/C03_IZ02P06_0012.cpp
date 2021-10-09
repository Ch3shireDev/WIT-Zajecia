#include <iostream>
using std::cout;
using std::endl;
using std::cin;
using std::string;
using std::to_string;
///---------------------------------------------------------------------------------
int ReadInt(string = "x? = ");
int MyAbs(int);
int MyMax(int, int);
int MyMax(int, int, int);
int MyMax(int, int, int, int, int, int, int);
///---------------------------------------------------------------------------------
int ReadInt(string myStr){
    int x;
    cout<<myStr;
    cin>>x;
    return x;
    }
///---------------------------------------------------------------------------------
int MyAbs(int x){
    if(x>0) return x;
    return -x; 
    }
///---------------------------------------------------------------------------------
int MyMax(int x0, int x1){
    if(x0>x1) return x0;
    return x1;
    }
///---------------------------------------------------------------------------------
int MyMax(int x0, int x1, int x2){
    return MyMax(MyMax(x0, x1), x2);
    }
///---------------------------------------------------------------------------------
int MyMax(int x0, int x1, int x2, int x3, int x4, int x5, int x6){
    return MyMax(MyMax(x0, x1, x2), MyMax(x3, x4, x5), x6);
    }
///---------------------------------------------------------------------------------
///---------------------------------------------------------------------------------
int main(){
    int x0, x1, x2, x3, x4, x5, x6 ;
    x0 = ReadInt("x0? = ");
    x1 = ReadInt("x1? = ");
    x2 = ReadInt("x2? = ");
    x3 = ReadInt("x3? = ");
    x4 = ReadInt("x4? = ");
    x5 = ReadInt("x5? = ");
    x6 = ReadInt("x6? = ");

    
    cout<<"Max("<<x0<<", "<<x1<<") = "<<MyMax(x0, x1)<<endl;
    cout<<"Max("<<x0<<", "<<x1<<", "<<x2<<") = "<<MyMax(x0, x1, x2)<<endl;
    cout<<"Max("<<x0<<", "<<x1<<", "<<x2<<", "<<x3<<", "<<x4<<", "<<x5<<", "<<x6<<") = "<<MyMax(x0, x1, x2, x3, x4, x5, x6)<<endl;
    
    return 0;
    }
///15, 15, 15, 15, 10 ...
    
    
    
    
    
