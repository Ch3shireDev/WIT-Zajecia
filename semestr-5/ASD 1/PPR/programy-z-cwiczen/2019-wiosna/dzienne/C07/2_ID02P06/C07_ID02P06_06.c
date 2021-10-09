#include <stdio.h>
#include <stdlib.h>
#include <time.h>
///************************************************************
int MyRead(char*);
void MySwap(int*, int*);
void MySwapP(int**, int**);
void MySortV(int*, int*, int*);
void MySortP(int**, int**, int**);
int* TabIntX01New(int);
int* TabIntX01FillRandom(int*, int, int, int);
int* TabIntX01Print(int*, int);
///************************************************************
int MyRead(char* myStr){
    int x;
    printf("%s", myStr);
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
    int* tmp;
    tmp = *a;
    *a = *b;
    *b = tmp;
    }
///************************************************************
void MySortV(int* x, int* y, int* z){
    if(*x>*y) MySwap(x, y);
    if(*y>*z) MySwap(z, y);
    if(*x>*y) MySwap(x, y);
    }
///************************************************************
void MySortP(int** x, int** y, int** z){
    if(**x>**y) MySwapP(x, y);
    if(**y>**z) MySwapP(z, y);
    if(**x>**y) MySwapP(x, y);
    }
///************************************************************
int* TabIntX01New(int sT){
    if(sT<1) return NULL;
    return (int*)malloc(sizeof(int)*sT);
    }
///************************************************************
int* TabIntX01FillRandom(int* myT, int sT, int a, int b){
    for(int i=0; i<sT;++i)
        myT[i] = rand()%(b-a+1) + a;
    return myT;
    }
///************************************************************
int* TabIntX01Print(int* myT, int sT){
    for(int i=0; i<sT;++i)
        printf("T[%2d] = %2d\n", i, myT[i]);
    return myT;
    }
///************************************************************
///************************************************************
int main(){
    srand(time(NULL));
    int sT = MyRead("size ? = ");
    int* myT = TabIntX01Print(TabIntX01FillRandom(TabIntX01New(sT), sT, 10, 20), sT);

    free(myT);
    return 0;
    }



