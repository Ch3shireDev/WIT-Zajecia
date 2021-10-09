#include <stdio.h>
///213.135.45.65:7080
/// \\sz065
typedef int(*MyFunction)(int, int);
///************************************************************
int MyRead(char*);
int MyMax(int, int);
int MyMin(int, int);
int MySum(int, int);
int MyTest(MyFunction, int, int);
int MyTestF(MyFunction, MyFunction, int, int);
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
int MySum(int x, int y){
    return x + y;
    }
///************************************************************
int MyTest(MyFunction MyF, int x, int y){
    return MyF(x,y);
    }
///************************************************************
int MyTestF(MyFunction F1, MyFunction F2, int x, int y){
    return F1(x,y) + F2(x,y);
    }
///************************************************************
///************************************************************
int main(){
    int x, y;
    x = MyRead("x? = ");
    y = MyRead("y? = ");

    printf("2*min(%d, %d) = %d\n", x, y, MyTestF( MyMin, MyMin, x, y));
    printf("min(%d, %d) + max(%d, %d) = %d\n", x, y, x, y, MyTestF( MyMin, MyMax, x, y));
    printf("2*max(%d, %d) = %d\n", x, y, MyTestF( MyMax, MyMax, x, y));
    printf("sum(%d, %d) + max(%d, %d) = %d\n", x, y, x, y, MyTestF( MySum, MyMax, x, y));
    printf("2*sum(%d, %d) = %d\n", x, y, MyTestF( MySum, MySum, x, y));
    printf("sum(%d, %d) + min(%d, %d) = %d\n", x, y, x, y, MyTestF( MySum, MyMin, x, y));

    return 0;
    }

///3, 4, 5
/**
printf("2*min(%d, %d) = %d", x, y, MyTestF( ..., x, y));
printf("min(%d, %d) + max(%d, %d) = %d", x, y, x, y, MyTestF( ..., x, y));
printf("2*max(%d, %d) = %d", x, y, MyTestF( ..., x, y));
printf("sum(%d, %d) + max(%d, %d) = %d", x, y, x, y, MyTestF( ..., x, y));
printf("2*sum(%d, %d) = %d", x, y, MyTestF( ..., x, y));
printf("sum(%d, %d) + min(%d, %d) = %d", x, y, x, y, MyTestF( ..., x, y));

---------------------------------------------------------
x? = 4
y? = 7
2*min(4, 7) = 8
min(4, 7) + max(4, 7) = 11
2*max(4, 7) = 14
sum(4, 7) + max(4, 7) = 18
2*sum(4, 7) = 22
sum(4, 7) + min(4, 7) = 15
*/







