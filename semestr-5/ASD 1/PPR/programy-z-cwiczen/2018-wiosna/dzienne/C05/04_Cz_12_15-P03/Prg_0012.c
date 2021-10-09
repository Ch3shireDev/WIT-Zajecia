#include <stdio.h>
#include <stdlib.h>

int main(){
    int* myT;
    int sizeT;
    int i;

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

    return 0;
    }
