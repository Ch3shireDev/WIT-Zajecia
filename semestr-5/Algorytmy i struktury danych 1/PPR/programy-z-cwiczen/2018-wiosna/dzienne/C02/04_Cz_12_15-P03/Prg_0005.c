#include <stdio.h>

int main(){
    int x0, y0, z0;
    int* x1, *y1, *z1;


    x1=&x0;
    y1=&y0;
    z1=&z0;


    printf("x?= ");
    scanf("%d", x1);
    printf("y?= ");
    scanf("%d", y1);
    printf("z?= ");
    scanf("%d", z1);


    if(x1>y1){
        tmp=x1;
        x1=y1;
        y1=tmp;
        }
    if(z1<y1){
        tmp=z1;
        z1=y1;
        y1=tmp;
        }
    if(x1>y1){
        tmp=x1;
        x1=y1;
        y1=tmp;
        }

    printf("\n(%d, %d, %d) -> (%d, %d, %d)\n",x0, y0, z0, *x1, *y1, *z1);

    printf("\n\tT H E    E N D\n");

    return 0;
    }
