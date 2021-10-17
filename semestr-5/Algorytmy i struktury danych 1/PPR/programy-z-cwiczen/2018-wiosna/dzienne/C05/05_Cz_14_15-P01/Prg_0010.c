#include <stdio.h>
#include <stdlib.h>

int main(){
    int* myT;
    int sizeT;

    sizeT = 4;

    myT = (int*)malloc(sizeof(int)*sizeT);

    *(myT+0) = 12; /** myT[0] = 12; */
    *(myT+1) =  9; /** myT[1] =  9; */
    *(myT+2) = -3; /** myT[2] = -3; */
    *(myT+3) = 27; /** myT[3] = 27; */


    myT[0] = 12;
    myT[4] = 78;

    return 0;
    }




