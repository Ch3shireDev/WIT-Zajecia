#ifndef C1_H
#define C1_H
#include "B1.h"
#include "B2.h"

class C1:public B1, public B2
{
    public:
        C1(int, int, int);
        int GetX(char='C');
        string ToString();

    private:
        int x;
};

#endif // C1_H
