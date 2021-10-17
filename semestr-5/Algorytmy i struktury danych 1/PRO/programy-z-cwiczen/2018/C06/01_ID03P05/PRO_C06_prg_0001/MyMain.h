#ifndef MyMain_H
#define MyMain_H

#include <iostream>
#include "MyA.h"
#include "MyAAA.h"
#include "MyUtility.h"

using std::cout;
using std::cin;
using std::endl;
using std::string;
using std::ostream;
using std::istream;

class MyMain{
    public:
        void ApplicationRun();
    private:
        void MyMain0001();
        void MyMain0002();
        void MyMain0003();
    };
#include "MyMain.cpp"
#endif // MyMain_H
