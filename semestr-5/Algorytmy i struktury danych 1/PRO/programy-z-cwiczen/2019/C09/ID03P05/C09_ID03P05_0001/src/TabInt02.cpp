#include "TabInt02.h"
///**********************************
TabInt02::TabInt02(int sT1, int sT2)
{
    if(sT1<1){
        this->pT  = NULL;
        this->sT1 = 0;
        this->sT2 = 0;
        }
    else{
        this->sT1 = sT1;
        this->pT  = new TabInt01[sT1];
        if(sT2<1) this->sT2 = 0;
        else{
            this->sT2 = sT2;
            for(int i =0; i<sT1;++i)
                pT[i] = TabInt01(sT2);
            }
        }
}
///**********************************
TabInt02::~TabInt02()
{

}
///**********************************
void TabInt02::FillRandom(int a, int b)
{
    for(int i =0; i<sT1; ++i)
        pT[i].FillRandom(a,b);
}
///**********************************
ostream& operator<<(ostream& s, TabInt02& t)
{
    for(int i = 0; i<t.sT1;++i)
        s<<t.pT[i]<<endl;
    return s;
}














