#include <stdio.h>
///213.135.45.65:7070
///************************************************************
typedef int (*MyFF)(int, int);
///************************************************************
int MyRead(char*);
int MyMax(int,int);
int MyMin(int,int);
int MySum(int,int);
int MyTest(MyFF, int, int);
///************************************************************
///************************************************************
int MyRead(char* myStr){
    int x;
    printf("%s",myStr);
    scanf("%d",&x);
    return x;
    }
///************************************************************
int MyMax(int x, int y){
    if(x>y) return x;
    return y;
    }
///************************************************************
int MyMin(int x, int y){
    if(x<y) return x;
    return y;
    }
///************************************************************
int MyTest(MyFF myF, int x, int y){
    return myF(x,y);
    }
///************************************************************
int MySum(int x,int y){
    return x+y;
    }
///************************************************************
///************************************************************
int main(){
    int x, y;
    x = MyRead("x? = ");
    y = MyRead("y? = ");

    printf("Max(%d, %d) = %d\n", x, y, MyTest(MyMax,x,y));
    printf("Min(%d, %d) = %d\n", x, y, MyTest(MyMin,x,y));
    printf("%d + %d = %d\n", x, y, MyTest(MySum,x,y));

    return 0;
    }
