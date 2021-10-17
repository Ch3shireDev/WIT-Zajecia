#include <stdio.h>
#include <stdlib.h>
#include <time.h>

///************************************************************
int MyRead(char*);
void MySwap(int* , int*);
void MySwapP(int** , int**);
void MySwapP2(int** , int**);
void MySortV(int*, int*, int*);
void MySortP(int**, int**, int**);
int * TabIntX01New(int);
int * TabIntX01FillRandom(int*, int, int, int);
int * TabIntX01Print(int*, int);
///************************************************************
int MyRead(char* myStr){
    int x;
    printf("%s",myStr);
    scanf("%d",&x);
    return x;
    }
///************************************************************
void MySwap(int* a, int* b){
    int tmp;
    tmp = *a;
    *a = *b;
    *b = tmp;
    }
///************************************************************
void MySwapP(int** a, int** b){
    int * tmp;
    tmp = *a;
    *a = *b;
    *b = tmp;    }
///************************************************************
void MySortV(int* a, int* b, int* c){
    if(*a>*b) MySwap(a,b);
    if(*b>*c) MySwap(c,b);
    if(*a>*b) MySwap(a,b);
    }
///************************************************************
void MySortP(int** a, int** b, int** c){
    if(**a>**b) MySwapP(a,b);
    if(**b>**c) MySwapP(c,b);
    if(**a>**b) MySwapP(a,b);
    }
///************************************************************
void MySortP2(int** a, int** b, int** c){
    if(a[0][0]>b[0][0]) MySwapP(a,b);
    if(**b>**c) MySwapP(c,b);
    if(**a>**b) MySwapP(a,b);
    }
///************************************************************
int * TabIntX01New(int sT){
    if(sT<1) return NULL;
    return (int*)malloc(sizeof(int)*sT);
    }
///************************************************************
int * TabIntX01FillRandom(int* myT, int sT, int a, int b){
    for(int i=0; i<sT;++i)
        myT[i] = rand()%(b-a+1)+a;
    return myT;
    }
///************************************************************
int * TabIntX01Print(int* myT, int sT){
    for(int i=0; i<sT;++i)
         printf("T[%2d] = %2d\n",i,myT[i]);
    return myT;
    }
///************************************************************
///************************************************************
int main(){
    srand(time(NULL));
    int sT =12;
    int* myT = TabIntX01New(sT);
    TabIntX01FillRandom(myT,sT,10,20);
    TabIntX01Print(myT,sT);


    free(myT);
    return 0;
    }


