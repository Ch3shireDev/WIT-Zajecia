#ifndef MyBox_H
#define MyBox_H
#include "MyA.h"
class MyBox{
    public:
        MyBox(MyA, MyA, MyA);
        MyBox();

    private:
        MyA x2;
        MyA x1;
        MyA x0;

        int cRc;
    };
#include "MyBox.cpp"
#endif // MyBox_H
