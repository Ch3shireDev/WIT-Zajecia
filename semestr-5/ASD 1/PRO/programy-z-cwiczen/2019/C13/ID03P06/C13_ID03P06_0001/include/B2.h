#ifndef B2_H
#define B2_H
#include "A.h"

class B2:virtual public A{
    public:
        B2(int, int, int);
        string ToString();
        int GetX(char='B');
        int GetY();
    private:
        int x;
        int y;
};

#endif // B2_H
