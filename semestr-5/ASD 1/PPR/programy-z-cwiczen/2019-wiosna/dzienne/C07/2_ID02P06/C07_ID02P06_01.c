#include <stdio.h>
void MySwap(int, int);
///************************************************************
void MySwap(int a, int b){
    int tmp;
    tmp = a;
    a = b;
    b = tmp;
    }
///************************************************************
///************************************************************
int main(){
    int x, y;
    int u, z, tmp;
    x = 12;
    y = 7;


    u = x;
    z = y;

    tmp = u;
    u = z;
    z = tmp;

    printf("x = %d, y = %d\n", x, y);

    MySwap(x,y);

    printf("x = %d, y = %d\n", x, y);


    return 0;
    }
