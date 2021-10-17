#ifndef MyA_H
#define MyA_H

#include <iostream>
#include "MyUtility.h"
using std::cout;
using std::cin;
using std::endl;
using std::string;
using std::ostream;
using std::istream;
///********************************************************
///********************************************************
class MyA{
    public:
        MyA(int=0, int=0, int=0);
        MyA(const MyA&);
        MyA MyAIni(int, int, int);
        MyA MyAPrint();

        MyA operator+(const MyA&)const;
        MyA operator+(int)const;
        MyA operator++();
        MyA operator++(int);
        int GetX2();
        int GetX1();
        int GetX0();
        int GetCrC();
        int SetX2(int);
        int SetX1(int);
        int SetX0(int);

    private:
        int CrC();
        int SetCrC();

        int x2;
        int x1;
        int x0;

        int cRc;
    friend void TestFriend(MyA&);
    };
///********************************************************
///********************************************************
MyA operator+(int, const MyA&);
ostream& operator<<(ostream&, MyA&);
istream& operator>>(istream&, MyA&);

#include "MyA.cpp"
#endif // MyA_H
