#include <iostream>
using std::cout;
using std::endl;
using std::cin;
///---------------------------------------------------------------------------------
void MyTest();
void PrintInt(int);
int Add(int, int);
int Add(int, int, int);
///void Add(int, int);
///---------------------------------------------------------------------------------
void MyTest(){
    cout<<"\n\t\tFunkcja MyTest()\n\n";
    }
///---------------------------------------------------------------------------------
void PrintInt(int x){
    cout<<"x = "<<x;
    }
///---------------------------------------------------------------------------------
int Add(int x, int y){return x + y;}
int Add(int x, int y, int z){return x + y + z;}
///---------------------------------------------------------------------------------
///---------------------------------------------------------------------------------
int main(){
    int x =7, y = 12, z = -5;
    PrintInt(Add(x, y));
    cout<<endl;
    PrintInt(Add(x, y, z));
    Add(5, 7);
    cout<<endl;
    return 0;
    }

    
    
    
    
    
