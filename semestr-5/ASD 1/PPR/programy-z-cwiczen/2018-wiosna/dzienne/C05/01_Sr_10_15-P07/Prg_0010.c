#include <stdio.h>
#include <stdlib.h>

int main(){
    int* myT;
    int size;
    int i;
    int maxi;

    printf("x ?= ");
    scanf("%d", &size);

    myT = (int*)malloc(sizeof(int)*size);

    for(i = 0; i< size; ++i){
        printf("T[%2d] ?= ", i);
        scanf("%d", myT+i);
        }

    for(i = 0; i< size; ++i){
        printf("t[%2d] = %3d\n", i, myT[i]);
        }

    /** indeks pierwszego max */

    maxi = 0;
    for(i = 1; i< size; ++i){
        if(myT[maxi]<myT[i])maxi=i;
        }
    printf("Max[%d]=%d\n",maxi, myT[maxi]);


    return 0;
    }
