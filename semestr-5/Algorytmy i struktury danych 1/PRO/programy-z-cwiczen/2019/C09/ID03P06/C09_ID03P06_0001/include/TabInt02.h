#ifndef TABINT02_H
#define TABINT02_H
#include "TabInt01.h"

class TabInt02
{
    public:
        TabInt02(int=0, int=0);
        TabInt02(const TabInt02&);
        ~TabInt02();

        void FillRandom(int, int);

    private:
        TabInt01* pT;
        int sT;
friend ostream& operator<<(ostream&, TabInt02&);
};

#endif // TABINT02_H
