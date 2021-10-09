#include<stdio.h>
#include<stdlib.h>
/************************************************************************/
/************************************************************************/
int MyRead();
void MySwap(int*, int*);
/** 3b, 4b, 5b*/
int* MyTabIntX01(int*);
/** 3, 4, 5 */
void FillTabIntX01(int*, int, int, int);
void PrinTabIntX01(int*, int);
/************************************************************************/
/************************************************************************/
int MyRead(){
    int x;
    printf("x ?=");
    scanf("%d", &x);
    return x;
    }
/************************************************************************/
void MySwap(int* a, int* b){
    int tmp;

    tmp=*a;
    *a=*b;
    *b=tmp;
    }
/************************************************************************/
int* MyTabIntX01(int* sT){
    *sT=MyRead();
    return (int*)malloc(sizeof(int)**sT);
    }
/************************************************************************/
void FillTabIntX01(int* mT, int sT, int a1, int r){
    int i;
    mT[0]=a1;
    for(i=1; i<sT;++i)
        mT[i]=mT[i-1]+r;
    }
/************************************************************************/
void PrinTabIntX01(int* mT, int sT){
    int i;
    for(i=0; i<sT;++i)
        printf("[%2d]",mT[i]);
    }

/************************************************************************/
/************************************************************************/
int main(){
    int *myT, sT;


    myT=MyTabIntX01(&sT);

    FillTabIntX01(myT, sT, MyRead(), MyRead());
    PrinTabIntX01(myT, sT);

    free(myT);
    return 0;
    }
