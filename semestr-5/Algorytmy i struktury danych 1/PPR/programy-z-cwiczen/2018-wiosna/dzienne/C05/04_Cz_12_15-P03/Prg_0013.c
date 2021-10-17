#include <stdio.h>
#include <stdlib.h>

int main(){
    int* myT;
    int sizeT;
    int i;
    int imax;

    printf("size ?=");
    scanf("%d", &sizeT);

    myT = (int*)malloc(sizeof(int)*sizeT);

    for(i = 0; i<sizeT; ++i){
        printf("T[%d] ?=", i);
        scanf("%d", &myT[i]); /** scanf("%d", myT+i); */
        }
    printf("**********************\n");
    for(i = 0; i<sizeT; ++i){
        printf("T[%d] = %d\n", i, myT[i]);
        }

    /** 2, 3, 4
        Indeks ostatniego max -> 6
        max = 12
    */

    imax = 0;
    for(i = 1; i<sizeT; ++i){
        if(myT[i]>=myT[imax]) imax = i;
        }
    printf("Indeks ostatniego max -> %d\nmax = %d",imax, myT[imax]);
    return 0;
    }
