#include<stdio.h>
#include<stdlib.h>
#include<time.h>


int main(){
    srand(time(NULL));
    int x0, x1, x2;
    int * px1;
    px1 = &x1;
    x0 =10;
    x1 = 8;
    x2 =24;

    int* *t;
    t=(int* *)malloc(sizeof(int*)*3);
    t[0]=&x0;
    t[1]=&x1;
    t[2]=&x2;

    printf("x0 = %d\n", *(t[0]));

    return 0;
    }
