#include<stdio.h>
#include<stdlib.h>

int main(){
    int* * myT;
    unsigned i,j;
    unsigned sT;
    int x =0;

    printf("size ?= ");
    scanf("%u", &sT);

    myT = (int**)malloc(sizeof(int*)*sT);

    for(i=0; i<sT;++i)
        myT[i] = (int*) malloc(sizeof(int)*(i+1));

    for(i=0; i<sT;++i)
        for(j=0;j<=i;++j)
            myT[i][j]= x++;
    for(i=0; i<sT;++i){
        for(j=0;j<=i;++j)
            printf("[%3d]", myT[i][j]);
        printf("\n");
        }

    for(i=0; i<sT;++i)
        free(myT[i]);
    free(myT);

    return 0;
    }
