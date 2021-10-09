#include <stdio.h>
#include <stdlib.h>

int main(){
    int* myT;
    int size;
    int i;

    printf("x ?= ");
    scanf("%d", &size);

    myT = (int*)malloc(sizeof(int)*size);

    /** 1, 2, 3 */
    /**     T[0] ?= 5       */
    /**     T[1] ?= -9       */

    for(i = 0; i< size; ++i){
        printf("T[%2d] ?= ", i);
        /** scanf("%d", &myT[i]); /** scanf("%d", myT+i); */
        scanf("%d", myT+i);
        /** &myT[i]  <=>  myT + i   - adresy*/
        /** myT[i]  <=>  *(myT + i)  - wartoœci*/
        }

/** myT[i] <=> *(myT + i) <=> *(i + myT) <=> i[myT] */


    for(i = 0; i< size; ++i){
        printf("t[%2d] = %3d\n", i, myT[i]);
        }

    printf("\n\t%d\n", 0[myT]);


    return 0;
    }
