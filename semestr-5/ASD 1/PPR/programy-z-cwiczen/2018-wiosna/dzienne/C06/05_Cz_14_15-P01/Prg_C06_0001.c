#include <stdio.h>
#include <stdlib.h>

int main(){
    int* * myT;
    int *t0, *t1, *t2, *t3;
    unsigned sT1=4, sT2=2;


    myT = (int**)malloc(sizeof(int*)*sT1);

    t0 = (int*)malloc(sizeof(int)*sT2);
    t1 = (int*)malloc(sizeof(int)*sT2);
    t2 = (int*)malloc(sizeof(int)*sT2);
    t3 = (int*)malloc(sizeof(int)*sT2);

    *(myT+0) = t0;
    *(myT+1) = t1;
    *(myT+2) = t2;
    *(myT+3) = t3;

    *(*(myT+0)+0)=1; /** <=> t0[0]=1; <=> *(t0+0)=1  */
    *(*(myT+0)+1)=1;

    *(*(myT+1)+0)=1;
    *(*(myT+1)+1)=1;

    *(*(myT+2)+0)=1;
    *(*(myT+2)+1)=1;

    *(*(myT+3)+0)=1;
    *(*(myT+3)+1)=1;



    return 0;
    }

