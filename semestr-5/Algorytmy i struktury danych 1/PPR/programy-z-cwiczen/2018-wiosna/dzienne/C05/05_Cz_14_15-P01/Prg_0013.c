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
    int imax;

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

    imax = 0;
    for(i=1; i<sizeT; ++i){
        if(myT[imax]<=myT[i]) imax = i;
        }

    printf("indeks ostatniego maximum - > %d\nMax = %d\n", imax, myT[imax]);

    return 0;
    }




