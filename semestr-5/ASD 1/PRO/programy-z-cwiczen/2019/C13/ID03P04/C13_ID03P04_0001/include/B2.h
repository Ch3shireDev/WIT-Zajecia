#ifndef B2_H
#define B2_H
#include "A.h"

class B2:virtual public A
{
    public:
        B2(int, int, int);
        int GetX(char='B');
        int GetY();
        string ToString();

    private:
        int x;
        int y;
};

#endif // B2_H
