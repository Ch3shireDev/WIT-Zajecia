#include <stdio.h>
#include <stdlib.h>
/********************************************************************/
/********************************************************************/
int MyRead();
void MySwap(int*, int*);
int* MyTabIntX01(int*);/** 3b, 4b, 5b */
/** 4, 5, 6 */
void PrintTabX01(int*, int);
void PrintVertTabX01(int*, int);
void FillTabX01(int*, int, int, int);
/** 6b, 7b, 8b */
void SwapTableX01(int** myT1, int** myT2, int* sT1, int* sT2);
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
void PrintVertTabX01(int* myT, int sT){
    int i;
    for(i=0; i<sT;++i)
        printf("[%3d]",myT[i]);
    printf("\n");
    }
/********************************************************************/
void FillTabX01(int* myT, int sT, int a1, int r){
    int i;
    myT[0]=a1;
    for(i=1; i<sT;++i)
        myT[i]=myT[i-1]+r;
    }
/********************************************************************/
void SwapTableX01(int** myT1, int** myT2, int* sT1, int* sT2){
    int  tmp1, *tmp2;

    tmp1= *sT1;
    *sT1=*sT2;
    *sT2=tmp1;

    tmp2= *myT1;
    *myT1=*myT2;
    *myT2=tmp2;

    }
/********************************************************************/
/********************************************************************/
int main(){
    int* myT1, sT1;
    int* myT2, sT2;

    myT1 = MyTabIntX01(&sT1);
    myT2 = MyTabIntX01(&sT2);
    FillTabX01(myT1, sT1,2,4);
    FillTabX01(myT2, sT2,-2,-4);
    printf("myT1:  ");
    PrintVertTabX01(myT1,sT1);
    printf("myT2:  ");
    PrintVertTabX01(myT2,sT2);
    SwapTableX01(&myT1, &myT2,&sT1,&sT2);
    printf("myT1:  ");
    PrintVertTabX01(myT1,sT1);
    printf("myT2:  ");
    PrintVertTabX01(myT2,sT2);

    free(myT2);
    free(myT1);
    return 0;
    }
