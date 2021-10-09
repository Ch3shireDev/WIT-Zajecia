#ifndef MYA_H
#define MYA_H

#include<iostream>
#include "MyUtility.h"

using std::cout;
using std::cin;
using std::string;
using std::endl;
using std::to_string;

class MyA
{
    public:
        MyA(int, int);
        void Print();

    int x;
    int y;
    protected:

    private:
};

#endif // MYA_H
