#include <stdio.h>
#include <stdlib.h>

/**  2, 3, 4
size ?= 4
T[0] ?= 5
T[1] ?= 3
T[2] ?= -7
T[3] ?= 5
****************
T[0] = 5
T[1] = 3
T[2] = -7
T[3] = 5

indeks ostatniego maximum - > 3
Max = 5
*/

int main(){
    int* myT;
    int sizeT;
    int i;
    int* imax;

    printf("size ?=");
    scanf("%d", &sizeT);

    myT = (int*)malloc(sizeof(int)*sizeT);

    for(i=0; i<sizeT; ++i){
        printf("T[%d] ?=",i);
        scanf("%d", myT);
        ++myT;
        }
    for(i=0; i<sizeT; ++i){
        --myT;
        }
   printf("******************\n");
    for(i=0; i<sizeT; ++i){
        printf("T[%d] = %d\n",i, *myT);
        ++myT;
        }

    for(i=0; i<sizeT; ++i){
        --myT;
        }
    imax = myT;

    for(i=1; i<sizeT; ++i){
        if(*myT>=*imax) imax =myT;
        ++myT;
        }
    for(i=0; i<sizeT; ++i){
        --myT;
        }

    printf("Max = %d\n", *imax);
    printf("indeks = %d\n", (int)(imax - myT)-1);

    return 0;
    }




