#include <stdio.h>
#include <stdlib.h>

int main(){
    int* *myT;
    unsigned sT, i, j;

    printf("x ?= ");
    scanf("%u", &sT);

    myT = (int**)malloc(sizeof(int*)*sT);
/*
    for(i=0; i<sT;++i)
        myT[i] = (int*)malloc(sizeof(int)*(i+1));
  */
    myT[0] = (int*)malloc(sizeof(int)*((sT+1)*sT)/2);


    for(i = 1;i<sT;++i)
        myT[i] = myT[i-1] + i;




    for(j = 0; j<((sT+1)*sT)/2; ++j)
        myT[0][j]=j;



    for(i = 0; i<sT; ++i){
        for(j = 0; j<=i; ++j)
            printf("[%3d]", myT[i][j]);
        printf("\n");
        }


    free(myT);
    return 0;
    }
