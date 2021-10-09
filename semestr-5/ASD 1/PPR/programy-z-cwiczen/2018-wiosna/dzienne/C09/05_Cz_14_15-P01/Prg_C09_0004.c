#include <stdio.h>
#include <stdlib.h>
/********************************************************************/
/********************************************************************/
int MyRead();
void MySwap(int*, int*);
int* MyTabIntX01(int*);/** 3b, 4b, 5b */
/** 4, 5, 6 */
void PrintTabX01(int*, int);
void FillTabX01(int* myT, int sT, int a1, int r);
void SwapTableX01(int* *myT1, int* sT1, int* *myT2, int* sT2);
/********************************************************************/
/********************************************************************/
int MyRead(){
    int x;
    printf("x ?=");
    scanf("%d",&x);

    return x;
    }
/********************************************************************/
void MySwap(int* a, int* b){
    int tmp;

    tmp=*a;
    *a=*b;
    *b=tmp;

    }
/********************************************************************/
int* MyTabIntX01(int* sT){
    *sT = MyRead();
    return (int*)malloc(sizeof(int)**sT);
    }
/********************************************************************/
void PrintTabX01(int* mT, int sT){
    int i;
    for(i=0; i<sT;++i)
        printf("[%3d]",mT[i]);
    printf("\n");
    }
/********************************************************************/
void FillTabX01(int* myT, int sT, int a1, int r){
    int i;
    myT[0] = a1;
    for(i=1; i<sT;++i)
        myT[i] = myT[i-1] + r ;
    }
/********************************************************************/
void SwapTableX01(int* *myT1, int* sT1, int* *myT2, int* sT2){
    int* tmp;
    MySwap(sT1,sT2);
    tmp = *myT1;
    *myT1 = *myT2;
    *myT2 = tmp;
    }
/********************************************************************/
/********************************************************************/
int main(){
    int *mT1, sT1;
    int *mT2, sT2;

    mT1=MyTabIntX01(&sT1);
    mT2=MyTabIntX01(&sT2);
    FillTabX01(mT1,sT1,3,4);
    FillTabX01(mT2,sT2,3,-11);
    printf("mT1:  ");
    PrintTabX01(mT1,sT1);
    printf("mT2:  ");
    PrintTabX01(mT2,sT2);
    SwapTableX01(&mT1, &sT1, &mT2, &sT2);
    printf("mT1:  ");
    PrintTabX01(mT1,sT1);
    printf("mT2:  ");
    PrintTabX01(mT2,sT2);


    free(mT2);
    free(mT1);
    return 0;
    }
