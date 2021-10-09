#ifndef MyBox_H
#define MyBox_H
#include "MyA.h"

class MyBox{
    public:
        MyBox(MyA, MyA, MyA);

    private:

        int CrC();
        int SetCrC();

        MyA x2;
        MyA x1;
        MyA x0;

        int cRc;
friend ostream& operator<<(ostream&, MyBox);
friend istream& operator>>(istream&, MyBox&);

///B: 4,5,6,7,8,9
    };
#include "MyBox.cpp"
#endif // MyBox_H
