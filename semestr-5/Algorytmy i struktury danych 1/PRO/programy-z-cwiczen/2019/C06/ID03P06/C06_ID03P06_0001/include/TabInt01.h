#ifndef TABINT01_H
#define TABINT01_H

///213.135.46.21:7070
///\\sz240\temp\PRO
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
        TabInt01(int);
        TabInt01(const TabInt01&);
        ~TabInt01();
        int  Length();
        int* PT();
        int& Value(int);
        int& operator[](int);
    private:
        int  sT;
        int *pT;
    };
///**********************************


#endif // TABINT01_H
