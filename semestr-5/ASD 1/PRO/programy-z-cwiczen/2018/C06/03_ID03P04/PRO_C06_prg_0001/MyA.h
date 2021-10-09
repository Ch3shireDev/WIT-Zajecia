#ifndef MyA_H
#define MyA_H
#include<iostream>
#include "MyUtility.h"
using std::cout;
using std::cin;
using std::endl;
using std::string;
using std::ostream;
using std::istream;
///*****************************************************************************************************
///*****************************************************************************************************
class MyA{
    public:
        MyA(int=0, int=0, int=0);
        MyA& MyAIni(int=0, int=0, int=0);
        MyA operator+(const MyA&);
        MyA operator+(int);
        MyA& operator++();
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
    };
///*****************************************************************************************************
///*****************************************************************************************************
MyA operator+(int, MyA&);
ostream& operator<<(ostream&, MyA&);
istream& operator>>(istream&, MyA&);


#include "MyA.cpp"
#endif // MyA_H
