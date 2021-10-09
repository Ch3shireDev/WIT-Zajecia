#include <stdio.h>
#include <stdlib.h>
/********************************************************************/
/********************************************************************/
int MyRead();
void MySwap(int*, int*);
int* MyTabIntX01(int*);/** 3b, 4b, 5b */
/** 4, 5, 6 */
void PrintTabX01(int*, int);
void FillTabX01(int*, int, int, int);
void SwapTable  /** 6b, 7b, 8b */
/********************************************************************/
/********************************************************************/
int MyRead(){
    int x;
    printf("x ?=");
    scanf("%d", &x);

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
    int* myT;

    /** *sT = MyRead();*/
    printf("size ?=");
    scanf("%d", sT);

    myT = (int*)malloc(sizeof(int)**sT);

    return myT;
    }
/********************************************************************/
void PrintTabX01(int* myT, int sT){
    int i;
    for(i=0; i<sT;++i)
        printf("T[%2d] = %2d\n",i,myT[i]);
    }
/********************************************************************/
void FillTabX01(int* myT, int sT, int a1, int r){
    int i;
    myT[0]=a1;
    for(i=1; i<sT;++i)
        myT[i]=myT[i-1]+r;
    }
/********************************************************************/
/********************************************************************/
int main(){
    int* myT, sT;

    myT = MyTabIntX01(&sT);
    FillTabX01(myT, sT,MyRead(),MyRead());
    PrintTabX01(myT,sT);

	free(myT);
    return 0;
    }
