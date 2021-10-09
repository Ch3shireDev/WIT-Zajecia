#include<stdio.h>
#include<stdlib.h>
/************************************************************************/
/************************************************************************/
int MyRead(char*);
void MySwap(int*, int*);
int* MyTabIntX01(int*);
/** 3, 4, 5  */
void FillTabX01( int*, int, int, int );
void PrinTabX01(int*, int);
/** 6b, 7b, 8b  */
void SwapTable( int** , int *, int** , int*);
/************************************************************************/
/************************************************************************/
int MyRead(char* myStr){
    int x;
    printf("%s", myStr);
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
int* MyTabIntX01(int* sS){
    int * myT;
    *sS=MyRead("size ?=");
    myT=(int*)malloc(sizeof(int)* *sS);
    return myT;
    }
/************************************************************************/
void FillTabX01( int* myT, int sT, int a1, int r){
    int i;
    myT[0]=a1;
    for(i=1;i<sT;++i)
        myT[i]=myT[i-1]+r;
    }
/************************************************************************/
void PrinTabX01(int* myT, int sT){
    int i;
    for(i=0;i<sT;++i)
        printf("[%2d]",myT[i]);
    }
/************************************************************************/
void SwapTable( int** myT1, int *sT1, int** myT2 , int* sT2){
    int* tmp;

    tmp=*myT1;
    *myT1=*myT2;
    *myT2=tmp;
    MySwap(sT1,sT2);

    }
/************************************************************************/
/************************************************************************/
int main(){
    int *myT1, sT1;
    int *myT2, sT2;

    printf("myT1: ");
    myT1=MyTabIntX01(&sT1);
    printf("myT2: ");
    myT2=MyTabIntX01(&sT2);

    printf("myT1: ");
    FillTabX01(myT1, sT1,MyRead("a1 ?="),MyRead("r ?="));
    printf("myT2: ");
    FillTabX01(myT2, sT2,MyRead("a1 ?="),MyRead("r ?="));

    printf("myT1: ");
    PrinTabX01(myT1, sT1);
    printf("\nmyT2: ");
    PrinTabX01(myT2, sT2);
    printf("\n");

    SwapTable(&myT1,&sT1,&myT2,&sT2);

    printf("myT1: ");
    PrinTabX01(myT1, sT1);
    printf("\nmyT2: ");
    PrinTabX01(myT2, sT2);
    printf("\n");


    free(myT1);
    free(myT2);
    return 0;
    }
