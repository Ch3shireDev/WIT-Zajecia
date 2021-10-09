#include <stdio.h>

int Add(int px, int py){
    return px + py;
    }

int main(){
    int x=3, y=5, z=2;
    printf("%d + %d = %d\n",x,y, Add(x,y));

    printf("suma = %d\n", Add(Add(x,y),Add(x,z)));/// suma = 2x + y + z


    return 0;
    }
