#include <stdio.h>

int Add2(int px, int py){
    int sum;
    sum = px+py;
    return sum;
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
    printf("x = %d\n",x);

    return 0;
    }
/**1, 2
x? = 5
x = 5
*/
