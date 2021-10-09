#include <stdio.h>

int main(){
    int x, y, z;
    int *px, *py, *pz;

    px=&x;
    py=&y;
    pz=&z;

    printf("x?=");
    scanf("%d",px);

    printf("y?=");
    scanf("%d",py);


    printf("z?=");
    scanf("%d",pz);



    printf("%d * %d = %d", *px, *py, *px**py);






    printf("\nT H E   E N D\n");
    printf("press any key but RESET or POWER\n");

    return 0;
    }
