#include <stdio.h>
#include <stdlib.h>

int main(){
    int* myT;
    int sizeT;
    int i;

    sizeT = 4;
    myT = (int*)malloc(sizeof(int)*sizeT);

    *(myT+0) =12; /** myT[0] = 12;  */
    *(myT+1) = 9; /** myT[1] =  9;  */
    *(myT+2) =-5; /** myT[2] = -5;  */
    *(myT+3) =28; /** myT[3] = 28;  */

    myT[0] = 12;
    myT[4] = 78; /** poza tablicπ - è L E  !!!! */


    printf("\n%d\n%d\n",*myT, *(myT+1));
    printf("%d\n%d\n\n",*(myT+2), myT[3]);
    /** 2, 3, 4
    size ?= 3
    T[0] ?= 6
    T[1] ?= -8
    T[2] ?= 4
    *******************
    T[0] = 6
    T[1] = -8
    T[2] = 4
    */

    return 0;
    }
