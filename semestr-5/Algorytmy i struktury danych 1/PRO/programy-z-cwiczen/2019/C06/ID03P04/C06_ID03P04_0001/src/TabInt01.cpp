#include "TabInt01.h"
///**********************************
///**********************************
TabInt01::TabInt01(int sT){
    if(sT<1){
        this->pT = NULL;
        this->sT = 0;
        }
    else{
        this->pT = new int[sT];
        this->sT = sT;
        }
    }
///**********************************
TabInt01::TabInt01(const TabInt01& t){
     if(t.sT<1){
        this->pT = NULL;
        this->sT = 0;
        }
    else{
        this->sT = t.sT;
        this->pT = new int[sT];
        for(int i=0;i<sT;++i)
            pT[i] = t.pT[i];
        }
    }
///**********************************
TabInt01::~TabInt01(){
    delete[] pT;
    pT = NULL;
    sT = 0;
    }
///**********************************
int TabInt01::Length(){return sT;}
///**********************************
int* TabInt01::T(){return pT;}
///**********************************
int& TabInt01::Value(int i){return pT[i];}
///**********************************
int& TabInt01::operator[](int i){return pT[i];}
///**********************************
