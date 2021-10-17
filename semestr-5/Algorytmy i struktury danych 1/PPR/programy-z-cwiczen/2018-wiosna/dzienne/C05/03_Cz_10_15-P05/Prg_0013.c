#include <stdio.h>
#include <stdlib.h>

int main(){
    int * myT;
    int sizeT;
    int i;

    /**  2, 3, 4
         size ?= 3
         T[0] ?= 5
         T[1] ?= 6
         T[2] ?= 1
         ****************
         T[0] = 5
         T[1] = 6
         T[2] = 1
    */
    printf("size ?=");
    scanf("%d", &sizeT);

    myT = (int*)malloc(sizeof(int)*sizeT);

    for(i = 0; i<sizeT; ++i){
        printf("T[%2d] ?=", i);
        scanf("%d", &myT[i]);/** scanf("%d", myT+i);      */
        }
    printf("*****************************\n");
    for(i = 0; i<sizeT; ++i){
        printf("T[%2d] = %2d\n", i, myT[i]);
        }




    return 0;
    }
