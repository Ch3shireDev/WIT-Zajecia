#include <stdio.h>
#include <stdlib.h>


int main(){
    int* px;
    int x = 111111;
    char z;

    z =(char)x;
    x =(int)z;

    printf("x = %d\n", x);

    z ='a';
    printf("z = %c\n", z);

    z =' '; /**  00100000 = 1*2^5 + 0*2^4 +0*2^3 + 0*2^2 + 0*2^1 + 0*2^0 */
            /**      32 = 3*10^1 + 2*10^0 */

    printf("z(%d) = %c\n", (int)z, z);

    z =' ' + ' ';/**  00100000
                    + 00100000
                    = 01000000  */
    printf("z(%d) = %c\n", (int)z, z);

    px = malloc(sizeof(int));



    *px = 12;
    printf("x = %d\n", *px);


    return 0;
    }
