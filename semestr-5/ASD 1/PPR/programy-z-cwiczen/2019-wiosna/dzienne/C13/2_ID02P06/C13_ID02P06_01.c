#include "TabX01Int.h"
///********************************************************
typedef struct{
    TabX01Int* pT;
    int sT;
    }TabX02Int;///3, 4, 5
///********************************************************
///********************************************************
TabX02Int TabX02IntNew(int, int);
TabX02Int TabX02IntDelete(TabX02Int*);
TabX02Int TabX02IntRand(TabX02Int, int, int);
TabX02Int TabX02IntPrint(TabX02Int, int);
///********************************************************
///********************************************************
TabX02Int TabX02IntNew(int sT0, int sT1){
    TabX02Int myT;
    if(sT0<1){
        myT.pT=NULL;
        myT.sT=0;
        return myT;
        }

    myT.pT=(TabX01Int*)malloc(sizeof(TabX01Int)*sT0);
    myT.sT=sT0;
    for(int i=0; i<sT0;++i)
        myT.pT[i] = TabX01IntNew(sT1);

    return myT;
    }
///********************************************************
TabX02Int TabX02IntDelete(TabX02Int* myT){
    for(int i =0; i<myT->sT;++i)
        TabX01IntDelete(&(myT->pT[i]));

    if(NULL!=myT->pT)
        free(myT->pT);
    myT->pT = NULL;
    myT->sT = 0;

    return *myT;
    }
///********************************************************
TabX02Int TabX02IntRand(TabX02Int myT, int a, int b){
    for(int i=0; i<myT.sT;++i)
        TabX01IntRand(myT.pT[i],a,b);
    return myT;
    }
///********************************************************
TabX02Int TabX02IntPrint(TabX02Int myT, int s){
    for(int i=0; i<myT.sT;++i){
        TabX01IntPrint(myT.pT[i],s);
        printf("\n");
        }
    return myT;
    }
///********************************************************




///********************************************************
///********************************************************
int main(){
    srand(time(0));

    TabX02Int t = TabX02IntNew(7,7);
    TabX02IntRand(t, 9, 10);
    TabX02IntPrint(t,2);
    TabX02IntDelete(&t);

    for(int i=0;i<10000;++i){
        t = TabX02IntNew(1000,1000);
        TabX02IntDelete(&t);
        }


    return 0;
    }
