#include <stdio.h>
#include <stdlib.h>

int main(){
    int* myT;
    int size;
    int i;

    printf("x ?= ");
    scanf("%d", &size);

    myT = (int*)malloc(sizeof(int)*size);

    *(myT+0) =  12;/**  myT[0] =  12;   */
    *(myT+1) =  34;/**  myT[1] =  34;   */
    *(myT+2) =   4;/**  myT[2] =   4;   */
    *(myT+3) = -15;/**  myT[3] = -15;   */

    for(i = 0; i< size; ++i){
        printf("t[%d] = %3d\n", i, myT[i]);
        }


    return 0;
    }
