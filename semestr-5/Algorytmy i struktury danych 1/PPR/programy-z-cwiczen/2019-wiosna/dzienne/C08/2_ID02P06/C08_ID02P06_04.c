#include <stdio.h>
///213.135.45.65:7080

typedef int(*MyFunction)(int, int);
///************************************************************
int MyRead(char*);
int MyMax(int, int);
int MyMin(int, int);
int MyTest(MyFunction, int, int);
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
int MyTest(MyFunction MyF, int x, int y){
    int z;
    z = MyF(x,y);
    return z;
    }
///************************************************************
///************************************************************

int main(){
    int x, y;
    x = MyRead("x? = ");
    y = MyRead("y? = ");

    printf("Max(%d, %d) = %d\n", x, y, MyMax(x, y));
    printf("Min(%d, %d) = %d\n", x, y, MyMin(x, y));


    printf("Max(%d, %d) = %d\n", x, y, MyTest(MyMax, x, y));
    printf("Min(%d, %d) = %d\n", x, y, MyTest(MyMin, x, y));

    return 0;
    }









