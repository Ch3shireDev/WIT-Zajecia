#include <iostream>
using std::cout;
using std::endl;
using std::cin;
///------------------------------------------------------------------------------------
void MyTest();
void PrintInt(int);
int Add(int, int);
int Add(int, double);
int Add(double, int);
int Add(double, double);
int Add(int, int, int);
///------------------------------------------------------------------------------------
void MyTest(){
    cout<<"\n\n\t\tFunkcja MyTest()\n\n";
    }
///------------------------------------------------------------------------------------
void PrintInt(int x){
    cout<<"x = "<<x;
    }
///------------------------------------------------------------------------------------
int Add(int x, int y){
    return x + y;                     
    }
///------------------------------------------------------------------------------------
int Add(int x, int y, int z){
    return x + y + z;                     
    }
///------------------------------------------------------------------------------------
///------------------------------------------------------------------------------------
int main(){    
    int a = 7, b = 3, c = -10;   
    
    PrintInt(Add(a, b));
    cout<<endl;
    PrintInt(Add(a, b, c));
    cout<<endl;
    
    
    return 0;
    }
    
    
    
    
    
