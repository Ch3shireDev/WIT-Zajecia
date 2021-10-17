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
    int* myT;
    int sizeT;
    int i;

    printf("size ?=");
    scanf("%d", &sizeT);

    myT = (int*)malloc(sizeof(int)*sizeT);

    for(i=0; i<sizeT; ++i){
        printf("T[%d] ?=",i);
        scanf("%d", &myT[i]); /** scanf("%d", myT+i); */
        }
   printf("******************\n");
    for(i=0; i<sizeT; ++i){
        printf("T[%d] = %d\n",i, myT[i]);
        }




    return 0;
    }




