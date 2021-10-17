#include <stdio.h>

int Add2(int px, int py){
    int sum;
    sum = px+py;
    return sum;
    }

int main(){
    int x=6,y=7,z=12;

    printf("%d + %d = %d\n",x,y,Add2(x,y));
    printf("suma = %d\n",Add2(Add2(x,y),Add2(y,z)));///suma = x+2y+z

    return 0;
    }
