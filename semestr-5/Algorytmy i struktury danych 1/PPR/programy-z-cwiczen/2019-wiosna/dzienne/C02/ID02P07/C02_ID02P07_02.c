#include <stdio.h>
int main(){
    int x0, y0, z0;

    int* px0,* py0,* pz0;
    int* px1,* py1,* pz1;
    int *ptmp;

    px0 = &x0;
    py0 = &y0;
    pz0 = &z0;

    px1 = px0;
    py1 = py0;
    pz1 = pz0;

    printf("x? = ");
    scanf("%d",px0);
    printf("y? = ");
    scanf("%d",py0);
    printf("z? = ");
    scanf("%d",pz0);

    if(*px1>*py1){
        ptmp = px1;
        px1 = py1;
        py1 = ptmp;
        }
    if(*py1>*pz1){
        ptmp = pz1;
        pz1 = py1;
        py1 = ptmp;
        }
    if(*px1>*py1){
        ptmp = px1;
        px1 = py1;
        py1 = ptmp;
        }

    printf("(%d, %d, %d) -> (%d, %d, %d)\n", *px0, *py0, *pz0, *px1, *py1, *pz1);

    return 0;
    }
/// bonus 12
/**
x? = 9
y? = 4
z? = 6

(9, 4, 6) -> (4, 6, 9)


*/
