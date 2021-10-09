#include<stdio.h>
#include<stdlib.h>

int main(){
    int* * myT;
    unsigned i,j;
    unsigned sT, sTd;

    printf("size ?= ");
    scanf("%u", &sT);

    sTd =((sT+1)*sT)/2;

    myT = (int**)malloc(sizeof(int*)*sT);
    myT[0] =(int*)malloc(sizeof(int)*sTd);

    for(i=1; i<sT;++i)
        myT[i]=myT[i-1]+i;

    for(i=0;i<sTd;++i)
        myT[0][i]=i;

    for(i=0;i<sT;++i){
        for(j=0;j<=i;++j)
            printf("[%3d]",myT[i][j]);
        printf("\n");
    }
    printf("\n");


    free(myT[0]);
    free(myT);

    return 0;
    }
