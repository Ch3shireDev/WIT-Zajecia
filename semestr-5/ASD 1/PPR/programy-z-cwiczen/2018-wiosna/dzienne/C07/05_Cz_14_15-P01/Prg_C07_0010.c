#include <stdio.h>
/******************************************************************/
int MyRead();

/******************************************************************/
/******************************************************************/
int MyRead(){
    int x;

    printf("x ?=");
    scanf("%d", &x);

    return x;
    }

/******************************************************************/
/******************************************************************/
int main(){
    int x;
    int i, j;

    x = MyRead();

    for(i=0; i<x; ++i){
        for(j=0; j<x; ++j)
            printf("* ");
        printf("\n");
        }


    return 0;
    }
