#include <stdio.h>

int main(){
    int x, y, z;
    int* px, * py, *pz;
    int *tmp;

    px = &x;
    py = &y;
    pz = &z;

    printf("x?=");
    scanf("%d", px);
    printf("y?=");
    scanf("%d", py);
    printf("z?=");
    scanf("%d", pz);

    if(*px > *py){
        tmp = px;
        px = py;
        py = tmp;
        }
    if(*py > *pz){
        tmp = pz;
        pz = py;
        py = tmp;
        }
    if(*px > *py){
        tmp = px;
        px = py;
        py = tmp;
        }



    printf("\n\t(%d, %d, %d) -> (%d, %d, %d)\n",x, y, z, *px, *py, *pz);



    printf("\nT H E   E N D\n");
    printf("press any key but RESET or POWER\n");

    return 0;
    }
