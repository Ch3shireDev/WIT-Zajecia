#include <stdio.h>
/************************************************************************/
/************************************************************************/
int MyRead();
int Max2(int, int);/** 1, 2 */
/************************************************************************/
/************************************************************************/
int MyRead(){
    int x;
    printf("x ?=");
    scanf("%d", &x);

    return x;
    }
/************************************************************************/
int Max2(int x1, int x2){
    if(x1>x2) return x1;
    return x2;
    }
/************************************************************************/
/************************************************************************/
int main(){
    printf("Max = %d\n",Max2(MyRead(), MyRead()));

    return 0;
    }
