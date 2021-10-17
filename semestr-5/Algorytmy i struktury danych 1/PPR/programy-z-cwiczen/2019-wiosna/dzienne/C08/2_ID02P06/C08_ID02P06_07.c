#include <stdio.h>
#include <stdlib.h>
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
    MyFunction* myT;
    int sT = 5;
    x = MyRead("x? = ");
    y = MyRead("y? = ");

    myT = (MyFunction*)malloc(sizeof(MyFunction)*sT);
    myT[0] = MyMin;
    myT[1] = MySum;
    myT[2] = MyMax;
    myT[3] = MyMin;
    myT[4] = MySum;

    for(int i=0; i<sT;++i)
        printf("%d\n", myT[i](x,y));


    return 0;
    }

