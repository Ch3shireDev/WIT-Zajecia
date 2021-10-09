#ifndef B1_H
#define B1_H
#include "A.h"
class B1:virtual public A{
    public:
        B1(int, int);
        string ToString();
        int GetX(char='B');
    private:
        int x;
};
#endif // B1_H
