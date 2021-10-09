#include <stdio.h>

int main(){
    int x0, y0, z0;
    int x1, y1, z1;
    int tmp, *ptmp;
    int *px0, *py0, *pz0;
    int *px1, *py1, *pz1;

    px0 = &x0;
    py0 = &y0;
    pz0 = &z0;

    px1 = &x1;
    py1 = &y1;
    pz1 = &z1;

    ptmp = &tmp;

    printf("x? = ");
    scanf("%d", px0);
    printf("y? = ");
    scanf("%d", py0);
    printf("z? = ");
    scanf("%d", pz0);

    *px1 = *px0;
    *py1 = *py0;
    *pz1 = *pz0;

    if(*px1>*py1){
        *ptmp = *px1;
        *px1 = *py1;
        *py1 = *ptmp;
        }

    if(*py1>*pz1){
        *ptmp = *pz1;
        *pz1 = *py1;
        *py1 = *ptmp;
        }
    if(*px1>*py1){
        *ptmp = *px1;
        *px1 = *py1;
        *py1 = *ptmp;
        }

    printf("(%d, %d, %d) -> (%d, %d, %d)\n",*px0, *py0, *pz0,*px1, *py1, *pz1);

    return 0;
    }
/**4, 5, 6, 7, 8, 9
bonus 12
x? = 9
y? = 4
z? = 7
(9, 4, 7) -> (4, 7, 9)



*/
