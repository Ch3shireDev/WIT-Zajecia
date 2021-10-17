#include <stdio.h>
/********************************************************/
/********************************************************/
int MyRead(char*);
int Max2(int, int);
int Max3(int, int, int);
int Max7(int, int, int, int, int, int, int);
/********************************************************/
/********************************************************/
int MyRead(char* myStr){
    int x;
    printf("%s",myStr);
    scanf("%d",&x);
    return x;
    }
/********************************************************/
int Max2(int x, int y){
    if(x<y) return y;
    return x;
    }
/********************************************************/
int Max3(int x0, int x1, int x2){
    return Max2(Max2(x0,x1),x2);
    }
/********************************************************/
int Max7(int x0, int x1, int x2, int x3, int x4, int x5, int x6){
    return Max3(Max3(x0,x1,x2),Max3(x3,x4,x5),x6);
    }
/********************************************************/
/********************************************************/
int main(){
    int x,y;

    x = MyRead("x? = ");
    y = MyRead("y? = ");
    printf("Max(%d, %d) = %d\n", x, y, Max2(x,y));

    return 0;
    }
/**
8, 9, 10



*/
