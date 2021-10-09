#include<stdio.h>
#include<stdlib.h>
/************************************************************************/
/************************************************************************/
typedef int (*ptrMyComp)(int, int);
/************************************************************************/
/************************************************************************/
int MyRead();
int MyAdd(int, int);
int MyMul(int, int);
int MyQqq(int, int);
int MyCalc(int, int, ptrMyComp);
int MyFun(int, int, int (*mfF)(int, int));
/************************************************************************/
/************************************************************************/
int MyRead(){
    int x;
    printf("x ?=");
    scanf("%d", &x);

    return x;
    }
/************************************************************************/
int MyAdd(int x, int y){
    return x + y;
    }
/************************************************************************/
int MyMul(int x, int y){
    return x * y;
    }
/************************************************************************/
int MyQqq(int x, int y){
    int i,j;
    for(i=0;i<x;++i){
        for(j=0;j<y+x-i;++j)
            printf("* ");
        printf("\n");
        }
    return 0;
    }
/************************************************************************/
int MyCalc(int x, int y, ptrMyComp mF){
    return mF(x, y);
    }
/************************************************************************/
int MyFun(int x, int y, int (*mfF)(int, int)){
    return mfF(x, y);
    }
/************************************************************************/
/************************************************************************/
int main(){
    int x, y;
    x = MyRead();
    y = MyRead();

    printf("%d + %d = %d\n", x, y, MyCalc(x, y, MyAdd));
    printf("%d * %d = %d\n", x, y, MyCalc(x, y, MyMul));
    printf("%d , %d = %d\n", x, y, MyCalc(x, y, MyQqq));

    printf("\n\n\t\tFun\n\n");

    printf("%d + %d = %d\n", x, y, MyFun(x, y, MyAdd));
    printf("%d * %d = %d\n", x, y, MyFun(x, y, MyMul));
    printf("%d , %d = %d\n", x, y, MyFun(x, y, MyQqq));
    return 0;
    }
