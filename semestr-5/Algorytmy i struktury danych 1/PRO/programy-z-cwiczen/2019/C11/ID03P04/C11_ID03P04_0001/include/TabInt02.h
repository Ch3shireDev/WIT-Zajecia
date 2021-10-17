#ifndef TABINT02_H
#define TABINT02_H

#include <iostream>
#include<ctime>
#include "TabInt01.h"

using std::cout;
using std::cin;
using std::string;
using std::endl;
using std::to_string;
using std::ostream;


class TabInt02
{
    public:
        TabInt02(int=0, int=0);
        TabInt02(const TabInt02&);
        ~TabInt02();
        TabInt01& operator[](int);

        void FillRandom(int , int);
        int Length();

    private:
        TabInt01* pT;
        int sT1;
        int sT2;
friend ostream& operator<<(ostream&, TabInt02&);
};

#endif // TABINT02_H
