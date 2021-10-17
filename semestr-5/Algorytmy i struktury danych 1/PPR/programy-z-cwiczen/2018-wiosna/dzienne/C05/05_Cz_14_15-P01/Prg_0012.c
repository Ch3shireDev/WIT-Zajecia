#include <stdio.h>
#include <stdlib.h>

/**  2
size ?= 3
T[0] ?= 5
T[1] ?= 3
T[2] ?= -7
****************
T[0] = 5
T[1] = 3
T[2] = -7

*/

int main(){
    int* myT,sizeT,i;
    printf("size ?=");
    scanf("%d", &sizeT);
    myT = (int*)malloc(sizeof(int)*sizeT);
    for(i=0; i<sizeT;printf("T[%d] ?=",i),scanf("%d", &myT[i++]));
    for(printf("******************\n"),i=0;i<sizeT;printf("T[%d] = %d\n",i,myT[i++]));
    return 0;
    }




