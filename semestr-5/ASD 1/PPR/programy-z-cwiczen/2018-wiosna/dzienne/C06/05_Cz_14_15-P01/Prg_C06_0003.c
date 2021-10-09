#include <stdio.h>
#include <stdlib.h>

int main(){
    int* * myT;
    unsigned sT1=4, sT2=2, i, j;

    myT = (int**)malloc(sizeof(int*)*sT1);

    for(i = 0; i< sT1; ++i)
        *(myT+i) = (int*)malloc(sizeof(int)*sT2);

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

