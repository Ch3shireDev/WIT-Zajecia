#include <stdio.h>
///************************************************************
int MyRead(char*);
void MySwap(int* , int*);
void MySwapP(int** , int**);
void MySwapP2(int** , int**);
void MySortV(int*, int*, int*);
void MySortP(int**, int**, int**);
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
///************************************************************
int main(){
    int x, y, z;
    int *px, *py, *pz;
    x=MyRead("x? = ");
    y=MyRead("y? = ");
    z=MyRead("z? = ");

    px = &x;
    py = &y;
    pz = &z;

    MySortP2(&px, &py, &pz);
    printf("(%d, %d, %d) -> (%d, %d, %d)\n", x, y, z, *px, *py, *pz);

    return 0;
    }



///5, 6, 7

