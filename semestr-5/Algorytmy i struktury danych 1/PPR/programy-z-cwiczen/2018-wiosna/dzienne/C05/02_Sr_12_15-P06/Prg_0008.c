#include <stdio.h>
#include <stdlib.h>


int main() {
    int * myT;
    int sizeT;
    sizeT = 4;

    myT = (int*)malloc(sizeof(int)*sizeT);

    *(myT + 0) = 0; /**    <=> myT[0] =  0;   */
    *(myT + 1) = 1; /**    <=> myT[1] =  1;   */
    *(myT + 2) = 2; /**    <=> myT[2] =  2;   */
    *(myT + 3) = 3; /**    <=> myT[3] =  3;   */



    printf("myT[0] = %2d\n", *(myT + 0));
    printf("myT[1] = %2d\n", *(myT + 1));
    printf("myT[2] = %2d\n", *(myT + 2));
    printf("myT[3] = %2d\n", *(myT + 3));

    return 0;
}
