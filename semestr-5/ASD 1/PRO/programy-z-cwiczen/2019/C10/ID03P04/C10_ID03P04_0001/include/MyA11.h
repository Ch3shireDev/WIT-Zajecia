#ifndef MYA11_H
#define MYA11_H
#include "MyA.h"

class MyA11: public MyA
{
    public:
        MyA11(int =1234, int = 9876);
        void Print();

        int x;
        int y;
    protected:

    private:
};

#endif // MYA11_H
