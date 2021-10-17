#include <stdio.h>
#include <stdlib.h>

int main(){
    int* *myT;
    unsigned sT1=4, sT2=2, i, j;

    myT = (int**)malloc(sizeof(int*)*sT1);
    free(myT);/** zwolnienie pamiêci*/

    myT = (int**)malloc(sizeof(int*)*sT1);

    for(i=0;i<sT1; ++i)
        myT[i] = (int*)malloc(sizeof(int)*sT2);

   for(i=0;i<sT1; ++i)
        for(j=0;j<sT2;++j)
            myT[i][j] = 1;

    for(i=0;i<sT1; ++i){
        for(j=0;j<sT2;++j)
            printf("[%2d]",myT[i][j]); /** *(t0+j)  <=> t0[j] */
        printf("\n");
        }

    for(i=0;i<sT1; ++i){
        free(myT[i]);

    free(myT);
    return 0;
    }
