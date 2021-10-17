#include <iostream>
using std::cout;
using std::endl;
using std::cin;

void MyTest();
typedef void(*Fun)();

int main(){
    auto MojaFunkcja = MyTest;
    Fun aqq = MyTest;
    
    MyTest();
    
    
    MojaFunkcja();
    
    aqq();
    
    return 0;
    }
    
void MyTest(){
    cout<<"\n\n\t\tFunkcja MyTest()\n\n";
    }
    
    
    
    
