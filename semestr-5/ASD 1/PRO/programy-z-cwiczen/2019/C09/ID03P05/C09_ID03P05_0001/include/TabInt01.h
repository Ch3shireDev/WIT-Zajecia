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
using std::ostream;
///**********************************
///**********************************
class TabInt01{
    public:
        TabInt01(int=0);
        TabInt01(const TabInt01&);
        TabInt01& operator=(const TabInt01&);
        ~TabInt01();
        int *PT();
        int Length();
        int& Value(int);
        int& operator[](int);
        TabInt01 operator+(int);
        TabInt01 operator++();///++t;
        TabInt01 operator++(int);///t++;
        void FillRandom(int, int);
    private:
        int *pT;
        int  sT;

    friend ostream& operator<<(ostream&, TabInt01&);
    friend TabInt01 operator+(int, TabInt01&);
    };
///**********************************

#endif // TABINT01_H
