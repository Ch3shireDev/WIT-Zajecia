#include<stdio.h>
#include<stdlib.h>

int main(){
    int* * myT;
    int i,j;
    unsigned sT1, sT2;
    sT1=4;
    sT2=2;

    myT = (int**)malloc(sizeof(int*)*sT1);
    myT[0] =(int*)malloc(sizeof(int)*sT1*sT2);

    for(i=1; i<sT1;++i)
        myT[i]=myT[0]+i*sT2;

    for(i=0;i<sT1;++i)
        for(j=0;j<sT2;++j)
        myT[i][j]=1;

    for(i=0;i<sT1;++i){
        for(j=0;j<sT2;++j)
            printf("[%2d]",myT[i][j]);
        printf("\n");
    }
    printf("\n");

    for(j=0;j<sT2;++j){
        for(i=0;i<sT1;++i)
            printf("[%2d]",myT[i][j]);
        printf("\n");
    }

    free(myT[0]);
    free(myT);

    return 0;
    }
