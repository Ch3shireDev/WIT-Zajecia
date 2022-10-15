#ifndef TABINT02_H
#define TABINT02_H
#include "TabInt01.h"

class TabInt02
{
    public:
        TabInt02(int =0, int =0);
        ~TabInt02();

        void FillRandom(int, int);
    private:
        TabInt01* pT;
        int sT1;
        int sT2;
friend ostream& operator<<(ostream&, TabInt02&);
};

#endif // TABINT02_H
