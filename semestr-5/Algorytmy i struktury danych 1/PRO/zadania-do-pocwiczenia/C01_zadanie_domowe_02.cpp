#include <cstdio>

int main(){
    int x, y, z;
    int * wx, *wy, *wz, *wt;
    int ** wwx, **wwy, **wwz;

    wwx = &wx;
    wwy = &wy;
    wwz = &wz;


    wx = &x;
    wy = &y;
    wz = &z;

    printf("x? = ");
    scanf("%d", &x);

    printf("y? = ");
    scanf("%d", &y);

    printf("z? = ");
    scanf("%d", &z);

/**
    w miesjce tego komentarza proszę wpisać kod
    wolno używać tylko zmiennych wwx, wwy, wwz, wt
*/


    printf("(%d, %d, %d) -> (%d, %d, %d)\n",x, y, z, *wx, *wy, *wz);    

    return 0;
    }
/**
Program ma wyświetlić w pierwszym nawiasie wartości według kolejności wczytania,
a w drugim nawiasie od wartości najmniejeszej do największej np.:

x? = 9
y? = 5
z? = 1
(9, 5, 1) -> (1, 5, 9)

albo np.:

x? = 1
y? = 5
z? = 9
(1, 5, 9) -> (1, 5, 9)

albo np.:

x? = 7
y? = 5
z? = 9
(7, 5, 9) -> (5, 7, 9)

*/
