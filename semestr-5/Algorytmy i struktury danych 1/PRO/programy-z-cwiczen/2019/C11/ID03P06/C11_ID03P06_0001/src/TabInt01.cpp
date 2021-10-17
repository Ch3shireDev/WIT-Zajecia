#include "TabInt01.h"

///**********************************
TabInt01::TabInt01(int sT){
    if(sT<1){
        ///cout<<"TabInt01.pT=NULL"<<endl;
        this->pT = NULL;
        this->sT = 0;
        }
    else{
        ///cout<<"TabInt01.pT["<<sT<<"]"<<endl;
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
        for(int i=0;i<sT;++i)
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
        for(int i=0;i<sT;++i)
            this->pT[i] = t.pT[i];
        }

    return *this;
    }
///**********************************
TabInt01::~TabInt01(){
    ///cout<<"Destruktor TabInt01"<<endl;
    delete[] pT;
    pT = NULL;
    sT = 0;
    }
///**********************************
int  TabInt01::Length(){return sT;}
///**********************************
int* TabInt01::PT(){return pT;}
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
TabInt01 TabInt01::operator+(TabInt01& t){
    TabInt01 tt(sT+t.sT);
    int i, j;
    for(i=0, j=0;i<sT;tt[j++]=pT[i++]);
    for(i=0;i<t.sT;tt[j++]=t[i++]);
    return tt;
    }
///**********************************
TabInt01& TabInt01::operator++(){
    for(int i=0; i<sT;++(*this)[i++]);
    /**
    for(int i=0; i< st;++i)
        ++pT[i];

    */
    return(*this);
    }
///**********************************
TabInt01 TabInt01::operator++(int){
    TabInt01 t(*this);
    ++(*this);
    return t;
    }
///**********************************
void TabInt01::FillRandom(int a, int b){
    for(int i=0; i<sT; ++i)
        pT[i] = rand()%(b-a) + a;
    }
///**********************************
ostream& operator<<(ostream& s, TabInt01& t){
    for(int i =0; i<t.Length();s<<t[i++]<<" ");
    /**
    for(int i =0; i<t.Length();)
        s<<t[i++]<<" ";
    for(int i =0; i<t.Length();++i)
        s<<t[i]<<" ";
    */
    return s;
    }
///**********************************
TabInt01 operator+(int x, TabInt01& t){
    return t + x;
    }
