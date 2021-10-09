#include <stdio.h>
#include <stdlib.h>

int main(){
    int * myT;
    int sizeT;
    int i;

    sizeT = 4;
    myT = (int*)malloc(sizeof(int)*sizeT);

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

    *(myT+0) = 12; /**  myT[0]  = 12; */
    *(myT+1) =  7; /**  myT[1]  =  7; */
    *(myT+2) = -9; /**  myT[2]  = -9; */
    *(myT+3) = 28; /**  myT[3]  = 28; */
    *(myT+4) =  8; /**  myT[4]  = 28;  - mazanie po pamiÍci - è L E !!! */
    myT[0] = 12;
    myT[1] =  7;
    myT[2] = -9;
    myT[3] = 28;


    return 0;
    }
