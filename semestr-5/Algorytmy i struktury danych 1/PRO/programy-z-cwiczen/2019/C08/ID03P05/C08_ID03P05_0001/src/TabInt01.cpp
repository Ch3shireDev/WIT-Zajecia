#include "TabInt01.h"
///**********************************
TabInt01::TabInt01(int sT){
    if(sT<1){
        this->pT = NULL;
        this->sT = 0;
        }
    else{
        this->sT = sT;
        this->pT = new int[this->sT];
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
        this->pT = new int[this->sT];
        for(int i=0; i<sT;++i)
            this->pT[i] = t.pT[i];
        }
    }
///**********************************
TabInt01& TabInt01::operator=(const TabInt01& t){
    delete[] pT;
    if(t.sT<1){
        this->pT = NULL;
        this->sT = 0;
        }
    else{
        this->sT = t.sT;
        this->pT = new int[this->sT];
        for(int i=0; i<sT;++i)
            this->pT[i] = t.pT[i];
        }

    return *this;
    }
///**********************************
TabInt01::~TabInt01(){
    delete[] pT;
    pT = NULL;
    sT = 0;
    }
///**********************************
int* TabInt01::PT(){return pT;}
///**********************************
int  TabInt01::Length(){return sT;}
///**********************************
int& TabInt01::Value(int i){return pT[i];}
///**********************************
int& TabInt01::operator[](int i){return pT[i];}
///**********************************
TabInt01 TabInt01::operator+(int x){
    TabInt01 t(*this);
    for(int i=0; i<sT;t[i++]+=x);
    return t;
    }
///**********************************
ostream& operator<<(ostream& s, TabInt01& t){
    for(int i=0; i<t.Length();s<<t[i++]<<" ");
    return s;
    }
///**********************************
TabInt01 operator+(int x, TabInt01& t){
    return t + x;
    }
///**********************************
TabInt01 TabInt01::operator++(){///++t;
    for(int i=0; i<sT;++(*this)[i++]);
    return *this;
    }
///**********************************
TabInt01 TabInt01::operator++(int){///t++;
    TabInt01 t(*this);
    ++(*this);
    return t;
    }
///**********************************













