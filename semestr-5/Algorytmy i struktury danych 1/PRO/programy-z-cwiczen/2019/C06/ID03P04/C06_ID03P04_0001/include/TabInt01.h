#ifndef TABINT01_H
#define TABINT01_H
///213.135.46.21:7070
///\\sz240
#include <iostream>
#include<ctime>
using std::cout;
using std::cin;
using std::string;
using std::endl;
using std::to_string;
///**********************************
///**********************************
class TabInt01{
    public:
        TabInt01(int=0);
        TabInt01(const TabInt01&);
        ~TabInt01();
        int Length();
        int* T();
        int& Value(int);
        int& operator[](int);
    private:
        int *pT;
        int  sT;
    };


#endif // TABINT01_H
