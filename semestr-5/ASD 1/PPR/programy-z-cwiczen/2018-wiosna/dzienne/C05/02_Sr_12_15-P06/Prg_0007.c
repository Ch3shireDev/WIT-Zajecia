#include <stdio.h>
#include <stdlib.h>


int main() {
    int * myT;
    int sizeT;
    sizeT = 4;

    myT = (int*)malloc(sizeof(int)*sizeT);

    *(myT + 0) = 12; /**    <=> myT[0] = 12;   */
    *(myT + 1) =  7; /**    <=> myT[1] =  7;   */
    *(myT + 2) = -9; /**    <=> myT[2] = -9;   */
    *(myT + 3) = 23; /**    <=> myT[3] = 23;   */



    printf("myT = %2d\n", *(myT + 0));
    printf("myT = %2d\n", *(myT + 1));
    printf("myT = %2d\n", *(myT + 2));
    printf("myT = %2d\n", *(myT + 3));

    return 0;
}
