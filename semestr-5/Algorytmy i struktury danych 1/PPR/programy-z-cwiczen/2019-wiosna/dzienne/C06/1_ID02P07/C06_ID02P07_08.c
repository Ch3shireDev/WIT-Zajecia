#include <stdio.h>

///********************************************************
int Add2(int px, int py){
    int sum;
    sum = px+py;
    return sum;
    }
///********************************************************
int MyAbs(int x){
    if(x<0) x=-x;
    return x;
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
    int x=6,y=7,z=12;

    x = MyRead();
    printf("|%d| = %d\n",x,MyAbs(x));

    return 0;
    }
/**1, 2
x? = 5
|5| = 5


x? = -9
|-9| = 9

*/
