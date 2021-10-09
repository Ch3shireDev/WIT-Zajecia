#ifndef MyAAA_H
#define MyAAA_H
#include "MyA.h"
class MyAAA{
    public:

        MyAAA(MyA, MyA, MyA);
        MyAAA(const MyAAA&);

        MyAAA MyAAAIni(MyA, MyA, MyA);
///B 7, 8, 9
/**
        MyAAA operator+(const MyAAA&)const;
        MyAAA operator+(int)const;
        MyAAA operator++();
        MyAAA operator++(int);
        */
        MyA& GetX2();
        MyA& GetX1();
        MyA& GetX0();
        int GetCrC();

        MyA& SetX2(int, int);
        MyA& SetX1(int, int);
        MyA& SetX0(int, int);


    private:
        int CrC();
        int SetCrC();

        MyA x2;
        MyA x1;
        MyA x0;

        int cRc;


    };
///MyAAA operator+(int, const MyAAA&);

ostream& operator<<(ostream&, MyAAA&);

///istream& operator>>(istream&, MyAAA&);

#include "MyAAA.cpp"
#endif // MyAAA_H
