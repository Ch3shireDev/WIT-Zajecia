#include <stdio.h>

///********************************************************
int Add2(int px, int py){
    int sum;
    sum = px+py;
    return sum;
    }
///********************************************************
int MyAbs(int px){
    if(px<0) px=-px;
    return px;
    }
///********************************************************
int MyRead(){
    int x;
    printf("x? = ");
    scanf("%d",&x);
    return x;
    }
///********************************************************
int main(){
    int x;

    x = MyRead();
    printf("|%d| = %d\n",x,MyAbs(x));
    printf("Adres MyAbs = %p\n ",MyAbs);
    return 0;
    }
/**1, 2
x? = 5
|5| = 5


x? = -9
|-9| = 9

*/
