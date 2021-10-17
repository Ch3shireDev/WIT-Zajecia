#include "TabX01Int.h"
typedef struct{
    TabX01Int* pT;
    int sT;
    }TabX02Int;
///2, 3, 4
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

    for(int i =0; i<sT0;++i)
        myT.pT[i] = TabX01IntNew(sT1);

    return myT;
    }
///********************************************************
TabX02Int TabX02IntDelete(TabX02Int* myT){
    if(NULL!=myT->pT){
        for(int i = 0;i<myT->sT;++i)
            TabX01IntDelete(&(myT->pT[i]));
        free(myT->pT);
        }
    myT->pT = NULL;
    myT->sT = 0;
    return *myT;
    }
///********************************************************
TabX02Int TabX02IntRand(TabX02Int myT, int a, int b){
    for(int i=0; i<myT.sT;++i)
        TabX01IntRand(myT.pT[i], a, b);
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


///********************************************************
///********************************************************
///213.135.45.65:7070
int main(){
    srand(time(0));

    TabX02Int t = TabX02IntNew(10,7);
    TabX02IntRand(t,0,99);
    TabX02IntPrint(t,2);

    return 0;
    }
