#include <stdio.h>
/****************************************************/
int MyAbs(int x);
int Add(int x, int y);
int MyMax(int x, int y);
int MyRead();
/****************************************************/
/** 1
    x ?= 5
    x ?= 12
    Max(5, 12) = 12
*/
/****************************************************/
int MyAbs(int x){
    if(x<0) return -x;
    return x;
    }
/****************************************************/
int Add(int x, int y){
    return x+y;
    }
/****************************************************/
int MyMax(int x, int y){
    if(x<y) return y;
    return x;
    }
/****************************************************/
int MyRead(){
    int x;

    printf("x ?=");
    scanf("%d", &x);

    return x;
    }
/****************************************************/
/****************************************************/
int main(){
    int x, y;

    x=MyRead();
    y=MyRead();

    printf("Max(%d, %d) = %d\n", x,y, MyMax(x,y));

    return 0;
    }
