#ifndef B1_H
#define B1_H
#include"A.h"

class B1:virtual public A
{
    public:
        B1(int, int);
        int GetX(char='B');
        string ToString();

    private:
        int x;
};

#endif // B1_H
