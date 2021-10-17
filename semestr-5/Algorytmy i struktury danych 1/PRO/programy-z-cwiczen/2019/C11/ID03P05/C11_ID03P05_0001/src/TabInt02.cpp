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
TabInt02::TabInt02(const TabInt02& tabInt02)
{
    if(tabInt02.sT1<1){
        this->pT  = NULL;
        this->sT1 = 0;
        this->sT2 = 0;
        }
    else{
        this->sT1 = tabInt02.sT1;
        this->pT  = new TabInt01[sT1];
        if(tabInt02.sT2<1) this->sT2 = 0;
        else{
            this->sT2 = tabInt02.sT2;
            for(int i =0; i<sT1;++i)
                pT[i] = tabInt02.pT[i];
            }
        }
}
///**********************************
TabInt02& TabInt02::operator=(const TabInt02& t){
    delete[] pT;
    if(t.sT1<1){
        this->pT = NULL;
        this->sT1 = 0;
        }
    else{
        this->sT1 = t.sT1;
        this->pT = new TabInt01[this->sT1];
        if(t.sT2<1) this->sT2 = 0;
            for(int i=0; i<sT1;++i)
                this->pT[i] = t.pT[i];
        }
    return *this;
    }
///**********************************
TabInt02::~TabInt02()
{
    delete[] pT;
    pT = NULL;
    sT1 = 0;
    sT2 = 0;
}
///**********************************
TabInt01& TabInt02::operator[](int i){return pT[i];}
///**********************************
int TabInt02::Length(){return sT1;}

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














