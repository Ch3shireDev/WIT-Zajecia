#include <stdio.h>
/******************************************************************/
int MyRead();
void BlackLine(int);
void MySquare(int);
/******************************************************************/
/******************************************************************/
int MyRead(){
    int x;

    printf("x ?=");
    scanf("%d", &x);

    return x;
    }
/******************************************************************/
void BlackLine(int x){
    int j;
    for(j=0; j<x; ++j)
        printf("* ");
    }
/******************************************************************/
void MySquare(int x){
    int i;

    for(i=0; i<x; ++i){
        BlackLine(x);
        printf("\n");
        }
    }
/******************************************************************/
/******************************************************************/
int main(){
    int x;

    x = MyRead();
    MySquare(x);

    return 0;
    }
