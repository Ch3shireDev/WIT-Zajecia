#include <stdio.h>

int Add(int px, int py){
    printf("%d + %d = %d\n",px, py, px + py);
    printf("----------------------------------------------------\n");
    return px+py;
    }

int main(){
    int x=3, y=5, z=2;
    Add(x,y);
    Add(y,z);
    Add(x,z);



    return 0;
    }
