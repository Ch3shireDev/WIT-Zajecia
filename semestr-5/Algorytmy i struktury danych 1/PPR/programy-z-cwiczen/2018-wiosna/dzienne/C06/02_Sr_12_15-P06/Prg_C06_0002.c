#include<stdio.h>
#include<stdlib.h>

int main(){
    int* * myT;
    int i,j;
    unsigned sT1, sT2;
    sT1=4;
    sT2=2;

    myT = (int**)malloc(sizeof(int*)*sT1);

    myT[0]=(int*)malloc(sizeof(int)*sT2);
    myT[1]=(int*)malloc(sizeof(int)*sT2);
    myT[2]=(int*)malloc(sizeof(int)*sT2);
    myT[3]=(int*)malloc(sizeof(int)*sT2);



    *(*(myT+0)+0)=1;
    *(*(myT+0)+1)=1;

    *(*(myT+1)+0)=1;
    *(*(myT+1)+1)=1;

    *(*(myT+2)+0)=1;
    *(*(myT+2)+1)=1;

    *(*(myT+3)+0)=1;
    *(*(myT+3)+1)=1;

    for(i=0; i<sT1;++i){
        for(j=0; j<sT2;++j)
            printf("[%2d]", myT[i][j]);
        printf("\n");
        }
    printf("\n\n******************************************\n\n");
    for(j=0; j<sT2;++j){
        for(i=0; i<sT1;++i)
            printf("[%2d]", myT[i][j]);
        printf("\n");
        }

 printf("\n\n******************************************\n\n");
    for(j=0; j<sT2;++j){
        for(i=0; i<sT1;++i)
            printf("[%2d]", *(*(myT+i)+j));
        printf("\n");
        }
    return 0;
    }
