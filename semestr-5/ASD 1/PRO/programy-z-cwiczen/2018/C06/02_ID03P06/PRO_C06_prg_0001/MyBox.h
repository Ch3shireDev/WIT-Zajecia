#ifndef MyBox_H
#define MyBox_H
#include "MyA.h"
class MyBox{
    public:
        MyBox(MyA, MyA, MyA);
        MyBox();

        MyA GetX2();
        MyA GetX1();
        MyA GetX0();
        int GetCrC();

        MyA SetX2(int, int);
        MyA SetX1(int, int);
        MyA SetX0(int, int);

    private:
        int CrC();
        int SetCrC();
                                                                     /// x2   0 0 0   0 0 0  1 0 0
                                                                     /// x1   0 0 0   0 0 0  1 1 1
                                                                     /// x0   0 0 0   0 0 0  0 1 0

                                                                     ///      0 0 0   0 0 0  0 0 0
                                                                     ///      1 0 0   1 1 1  0 1 0

        MyA x2;
        MyA x1;
        MyA x0;

        int cRc;


friend istream& operator>>(istream&, MyBox&);
    };
///********************************************************************
ostream& operator<<(ostream&, MyBox);

#include "MyBox.cpp"
#endif // MyBox_H
