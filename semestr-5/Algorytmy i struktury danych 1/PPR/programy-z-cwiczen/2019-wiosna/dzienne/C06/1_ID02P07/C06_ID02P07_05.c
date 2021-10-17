#include <stdio.h>

void Add(int px, int py){

    printf("%d + %d = %d\n",px, py, px + py);
    printf("---------------------------\n");
    }

int main(){
    int x=6,y=7,z=12;

    Add(x,y);
    Add(x,z);
    Add(y,z);


    return 0;
    }
