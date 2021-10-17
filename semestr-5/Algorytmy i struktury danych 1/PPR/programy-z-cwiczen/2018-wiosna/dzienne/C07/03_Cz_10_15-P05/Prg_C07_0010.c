#include <stdio.h>
/****************************************************/
int MyAbs(int x);
int Add(int x, int y);
int MyMax2(int x1, int x2);
int MyMax3(int x1, int x2, int x3);
int MyMax4(int x1, int x2, int x3, int x4);
int MyMax5(int x1, int x2, int x3, int x4, int x5);
int MyMax6(int x1, int x2, int x3, int x4, int x5, int x6);
int MyMax7(int x1, int x2, int x3, int x4, int x5, int x6, int x7);
int MyMax8(int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8);
int MyRead();
/****************************************************/
/** 2b, 3b, 4b
*/
/****************************************************/
int MyAbs(int x){
    if(x<0) return -x;
    return x;
    }
/****************************************************/
int Add(int x, int y){
    return x+y;
    }
/****************************************************/
int MyMax2(int x1, int x2){
    if(x1<x2) return x2;
    return x1;
    }
/****************************************************/
int MyMax3(int x1, int x2, int x3){
    return MyMax2(MyMax2(x1, x2), x3);
    }
/****************************************************/
int MyMax4(int x1, int x2, int x3, int x4){
    return MyMax2(MyMax3(x1, x2, x4), x3);
    }
/****************************************************/
int MyMax5(int x1, int x2, int x3, int x4, int x5){
    return MyMax2(MyMax4(x1, x2, x4, x5), x3);
    }
/****************************************************/
int MyMax6(int x1, int x2, int x3, int x4, int x5, int x6){
    return MyMax2(MyMax5(x1, x2, x4, x5, x6), x3);
    }
/****************************************************/
int MyMax7(int x1, int x2, int x3, int x4, int x5, int x6, int x7){
    return MyMax2(MyMax6(x1, x2, x4, x5, x6, x7), x3);
    }
/****************************************************/
int MyMax8(int x1, int x2, int x3, int x4, int x5, int x6, int x7, int x8){
    return MyMax2(MyMax7(x1, x2, x4, x5, x6, x7, x8), x3);
    }
/****************************************************/
int MyRead(){
    int x;

    printf("x ?=");
    scanf("%d", &x);

    return x;
    }
/****************************************************/
/****************************************************/
int main(){
    int x1, x2, x3, x4, x5,x6,x7, x8;

    x1=MyRead();
    x2=MyRead();
    x3=MyRead();
    x4=MyRead();
    x5=MyRead();
    x6=MyRead();
    x7=MyRead();
    x8=MyRead();

    printf("Max(%d, %d, %d, %d, %d, %d, %d, %d) = %d\n",
           x1,x2,x3,x4,x5,x6,x7,x8, MyMax8(x1,x2,x3,x4,x5,x6,x7,x8));

    return 0;
    }
