#include <stdio.h>
///************************************************************
int MyRead(char*);
void MySwap(int*, int*);
void MySwapP(int**, int**);
void MySortV(int*, int*, int*);
void MySortP(int**, int**, int**);
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
///************************************************************
int main(){
    int x, y, z ;
    int *px, *py, *pz;
    x = MyRead("x? = ");        ///x? = 9
    y = MyRead("y? = ");        ///y? = 4
    z = MyRead("z? = ");        ///z? = 1
    px = &x;
    py = &y;
    pz = &z;

    MySortP(&px, &py, &pz);

    printf("(%d, %d, %d) -> (%d, %d, %d)\n", x, y, z, *px, *py, *pz); ///(9, 4, 1) -> (1, 4, 9)

    return 0;
    }
///3, 4, 5, 6, 7



