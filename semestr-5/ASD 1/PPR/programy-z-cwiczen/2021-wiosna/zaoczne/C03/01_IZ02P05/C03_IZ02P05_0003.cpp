#include <iostream>
using std::cout;
using std::endl;
using std::cin;

void MyTest();

int main(){
    auto MojaFunkcja = MyTest;
    MyTest();
    MojaFunkcja();


    return 0;
    }

void MyTest(){
    cout<<"\n\tTo jest MyTest()\n\n";
    }
