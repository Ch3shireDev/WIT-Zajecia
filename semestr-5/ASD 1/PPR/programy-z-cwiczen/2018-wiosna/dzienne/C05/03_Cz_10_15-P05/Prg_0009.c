#include <stdio.h>
#include <stdlib.h>

int main(){
    int * myT;
    int sizeT;

    sizeT = 4;
    myT = (int*)malloc(sizeof(int)*sizeT);

    *(myT+0) = 12; /**  myT[0]  = 12; */
    *(myT+1) =  7; /**  myT[1]  =  7; */
    *(myT+2) = -9; /**  myT[2]  = -9; */
    *(myT+3) = 28; /**  myT[3]  = 28; */
    *(myT+4) =  8; /**  myT[4]  = 28; */



    return 0;
    }
