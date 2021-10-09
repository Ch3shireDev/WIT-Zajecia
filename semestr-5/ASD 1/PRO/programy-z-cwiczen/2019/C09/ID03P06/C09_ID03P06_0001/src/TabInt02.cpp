#include "TabInt02.h"
///**********************************
TabInt02::TabInt02(int sT, int sTT){
    if(sT<1){
        this->pT = NULL;
        this->sT = 0;
        }
    else{
        this->pT = new TabInt01[sT];
        this->sT = sT;
        if(sTT>0){
            for(int i = 0; i<sT;++i)
                pT[i] = TabInt01(sTT);
            }
        }
    }
///**********************************
TabInt02::TabInt02(const TabInt02& t){
    if(t.sT<1){
        this->pT = NULL;
        this->sT = 0;
        }
    else{
        this->pT = new TabInt01[t.sT];
        this->sT = t.sT;
        for(int i = 0; i<sT;++i)
            pT[i] = t.pT[i];
        }
    }
///**********************************
TabInt02::~TabInt02()
{
    delete[] pT;
    pT = NULL;
    sT = 0;
}
///**********************************
void TabInt02::FillRandom(int a, int b){
    for(int i=0; i<sT; ++i)
        pT[i].FillRandom(a,b);
    }
///**********************************
ostream& operator<<(ostream& s, TabInt02& t){
    for(int i=0; i< t.sT;++i)
        s<<t.pT[i]<<endl;
    return s;
    }
